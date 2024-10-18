using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SEGPS
{
    using Planet = System.Tuple<SEGPS.Gps, float>;

    public partial class MainWindow : Form
    {
        private List<Planet> planets = new List<Planet>();
        private List<Gps> database = new List<Gps>();
        private string databasePath = Path.ChangeExtension(Application.ExecutablePath, ".txt");
        private List<String> log = new List<String>();
        private string logPath = Path.ChangeExtension(Application.ExecutablePath, ".log");
        private bool textIsChanging = false;

        private string clipBoardContent;
        public MainWindow()
        {
            InitializeComponent();

            /*  https://spaceengineers.fandom.com/wiki/Planets
                Name	    Distance	Diameter    G-radius    GPS
                Earthlike	  163.43	120.00	    104         GPS:Earth:0.50:0.50:0.50:
                Moon	      186.04	 19.00   	 13         GPS:Moon:16384.50:136384.50:-113615.50:
                Marslike	1,800.08	120.00	    102         GPS:Mars:1031072.50:131072.50:1631072.50:
                Europa	    1,886.17	 19.00	     13         GPS:Europa:916384.50:16384.50:1616384.50:
                Triton	    2,505.86	 80.25	     74         GPS:Triton:-284463.50:-2434463.50:365536.50:
                Pertam	    4,036.21	 60.00	     49         GPS:Pertam:-3967231.50:-32231.50:-767231.50:
                Alien	    5,636.95	120.00	    105         GPS:Alien:131072.50:131072.50:5731072.50:
                Titan	    5,822.22	 19.00	     13         GPS:Titan:36384.50:226384.50:5796384.50:
             */
            planets.Add(new Planet(new Gps("GPS:Earth:0.50:0.50:0.50:#FF75C9F1:"), 104000));
            planets.Add(new Planet(new Gps("GPS:Moon:16384.50:136384.50:-113615.50:#FF75C9F1:"), 13000));
            planets.Add(new Planet(new Gps("GPS:Mars:1031072.50:131072.50:1631072.50:#FF75C9F1:"), 102000));
            planets.Add(new Planet(new Gps("GPS:Europa:916384.50:16384.50:1616384.50:#FF75C9F1:"), 13000));
            planets.Add(new Planet(new Gps("GPS:Triton:-284463.50:-2434463.50:365536.50:#FF75C9F1:"), 74000));
            planets.Add(new Planet(new Gps("GPS:Pertam:-3967231.50:-32231.50:-767231.50:#FF75C9F1:"), 49000));
            planets.Add(new Planet(new Gps("GPS:Alien:131072.50:131072.50:5731072.50:#FF75C9F1:"), 105000));
            planets.Add(new Planet(new Gps("GPS:Titan:36384.50:226384.50:5796384.50:#FF75C9F1:"), 13000));

            DatabaseLoad();
            LogLoad();

            timerClipboard.Enabled = true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerClipboard.Enabled = false;
        }

        private void timerClipboard_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
                string cb = Clipboard.GetText(TextDataFormat.UnicodeText);
                if (cb != clipBoardContent)
                {
                    clipBoardContent = cb;
                    Clipboard_Changed(sender, cb);
                }
            }
        }

        private void Clipboard_Changed(object sender, string content)
        {
            Gps gps = new Gps(content);
            if (gps.IsValid)
            {
                LogAppend(gps);
                Gps_Changed(sender, gps);
            }
        }

        private void SetTextBox(object sender, TextBox tb, string text)
        {
            if (sender != tb)
                tb.Text = text;
        }

        private void Gps_Changed(object sender, Gps gps)
        {
            textIsChanging = true;

            SetTextBox(sender, tbGPS, gps.ToString());

            SetTextBox(sender, tbName, gps.Name);
            SetTextBox(sender, tbX, gps.X.ToString(Gps.NumberFormat));
            SetTextBox(sender, tbY, gps.Y.ToString(Gps.NumberFormat));
            SetTextBox(sender, tbZ, gps.Z.ToString(Gps.NumberFormat));
            SetTextBox(sender, tbColor, gps.Color);
            try
            {
                ColorConverter cc = new ColorConverter();
                tbColor.BackColor = (Color)cc.ConvertFromString(tbColor.Text);
            }
            catch (Exception)
            {
                tbColor.BackColor = tbGPS.BackColor;
            }

            tbLength.Text = (gps.Length() / 1000).ToString("0.00", Gps.NumberFormat); // [km]

            Planet closestPlanet = GetClosestPlanet(gps);
            if (closestPlanet != null)
            {
                Gps center = closestPlanet.Item1;
                tbAbove.Text = center.Name;

                float height = center.Distance(gps);
                tbHeight.Text = (height / 1000).ToString("0.00", Gps.NumberFormat); // [km]

                float gravity = closestPlanet.Item2;
                tbGravity.Text = (gravity / 1000).ToString("0.00", Gps.NumberFormat); // [km]
                if (height > 1 && gravity - height > 1)
                {
                    Gps jump = center.ProjectOntoSphere(gps, gravity);
                    tbJumpGPS.Text = jump.ToString();
                }
                else
                {
                    tbJumpGPS.Text = "";
                }
            }

            Gps reference = new Gps(tbRef.Text);
            if (reference.IsValid)
            {
                float distance = reference.Distance(gps);
                tbRefDist.Text = (distance / 1000).ToString("0.00", Gps.NumberFormat); // [km]
            }

            Gps closestDatabase = GetClosestDatabase(gps);
            if (closestDatabase != null)
            {
                float distance = closestDatabase.Distance(gps);
                tbDb.Text = closestDatabase.ToString();
                tbDbDist.Text = (distance / 1000).ToString("0.00", Gps.NumberFormat); // [km]
            }

            textIsChanging = false;
        }

        private void DatabaseLoad()
        {
            database.Clear();
            if (File.Exists(databasePath))
            {
                foreach (var line in File.ReadAllLines(databasePath))
                {
                    database.Add(new Gps(line));
                }
            }
        }

        private void DatabaseWrite()
        {
            File.WriteAllLines(databasePath, database.ConvertAll(gps => gps.ToString()));
        }

        private void DatabaseUpdate(Gps gps)
        {
            bool found = false;
            for (int i = 0; i < database.Count; i++)
            {
                if (gps.Distance(database[i]) < 10) // [m]
                {
                    database[i] = gps;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                database.Add(gps);
            }
            DatabaseWrite();
        }

        private void LogLoad()
        {
            log.Clear();
            if (File.Exists(logPath))
            {
                foreach (var line in File.ReadAllLines(logPath))
                {
                    log.Add(line);
                }
            }
        }

        private void LogAppend(Gps gps)
        {
            var line = gps.ToString();
            // only log unseen coords
            foreach (var entry in log)
            {
                if (entry == line)
                {
                    return;
                }
            }
            using (var writer = File.AppendText(logPath))
            {
                writer.WriteLine(line);
            }
        }

        private Planet GetClosestPlanet(Gps gps)
        {
            Planet closest = null;
            float min = float.PositiveInfinity;

            foreach (var planet in planets)
            {
                float d = gps.Distance(planet.Item1);
                if (d < min)
                {
                    closest = planet;
                    min = d;
                }
            }
            return closest;
        }

        private Gps GetClosestDatabase(Gps gps)
        {
            Gps closest = null;
            float min = float.PositiveInfinity;

            foreach (var entry in database)
            {
                float d = gps.Distance(entry);
                if (d < min)
                {
                    closest = entry;
                    min = d;
                }
            }
            return closest;
        }

        private void tbGPS_TextChanged(object sender, EventArgs e)
        {
            Gps gps = new Gps(tbGPS.Text);
            if (!textIsChanging && gps.IsValid)
                Gps_Changed(sender, gps);
        }

        private void tbDetail_TextChanged(object sender, EventArgs e)
        {
            Gps gps = new Gps(Gps.GetGpsString(tbName.Text, tbX.Text, tbY.Text, tbZ.Text, tbColor.Text));
            if (!textIsChanging && gps.IsValid)
                Gps_Changed(sender, gps);
        }

        private void tbGPS_DoubleClick(object sender, EventArgs e)
        {
            tbGPS.Select(0, tbGPS.Text.Length);
            clipBoardContent = tbGPS.Text;
            Clipboard.SetText(clipBoardContent, TextDataFormat.UnicodeText);
        }

        private void tbJumpGPS_DoubleClick(object sender, EventArgs e)
        {
            if (tbJumpGPS.Text.Length > 0)
            {
                tbJumpGPS.Select(0, tbJumpGPS.Text.Length);
                // the JumpGPS coord will become new GPS coord, when clipboard change is detected
                // could be prevented by: clipBoardContent = tbJumpGPS.Text;
                Clipboard.SetText(tbJumpGPS.Text, TextDataFormat.UnicodeText);
            }
        }

        private void btRef_Click(object sender, EventArgs e)
        {
            tbRef.Text = tbGPS.Text;
            tbRefDist.Text = "0.00";
        }

        private void btDb_Click(object sender, EventArgs e)
        {
            tbDb.Text = tbGPS.Text;
            tbDbDist.Text = "0.00";
            DatabaseUpdate(new Gps(tbGPS.Text));
        }

        private void tbDb_DoubleClick(object sender, EventArgs e)
        {
            if (tbDb.Text.Length > 0)
            {
                tbDb.Select(0, tbDb.Text.Length);
                // the database coord will become new GPS coord, when clipboard change is detected
                // could be prevented by: clipBoardContent = tbDb.Text;
                Clipboard.SetText(tbDb.Text, TextDataFormat.UnicodeText);
            }
        }

        private void tbRef_DoubleClick(object sender, EventArgs e)
        {
            if (tbRef.Text.Length > 0)
            {
                tbRef.Select(0, tbRef.Text.Length);
                // the database coord will become new GPS coord, when clipboard change is detected
                // could be prevented by: clipBoardContent = tbRef.Text;
                Clipboard.SetText(tbRef.Text, TextDataFormat.UnicodeText);
            }
        }
    }
}
