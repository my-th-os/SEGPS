
namespace SEGPS
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGPS = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.timerClipboard = new System.Windows.Forms.Timer(this.components);
            this.tbLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAbove = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGravity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbJumpGPS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.tbRefDist = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btRef = new System.Windows.Forms.Button();
            this.btDb = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDbDist = new System.Windows.Forms.TextBox();
            this.tbDb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Color";
            // 
            // tbGPS
            // 
            this.tbGPS.Location = new System.Drawing.Point(84, 5);
            this.tbGPS.Name = "tbGPS";
            this.tbGPS.Size = new System.Drawing.Size(329, 20);
            this.tbGPS.TabIndex = 6;
            this.tbGPS.TextChanged += new System.EventHandler(this.tbGPS_TextChanged);
            this.tbGPS.DoubleClick += new System.EventHandler(this.tbGPS_DoubleClick);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(329, 20);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.tbDetail_TextChanged);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(84, 63);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(329, 20);
            this.tbX.TabIndex = 8;
            this.tbX.TextChanged += new System.EventHandler(this.tbDetail_TextChanged);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(84, 88);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(329, 20);
            this.tbY.TabIndex = 9;
            this.tbY.TextChanged += new System.EventHandler(this.tbDetail_TextChanged);
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(84, 114);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(329, 20);
            this.tbZ.TabIndex = 10;
            this.tbZ.TextChanged += new System.EventHandler(this.tbDetail_TextChanged);
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(84, 139);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(329, 20);
            this.tbColor.TabIndex = 11;
            this.tbColor.TextChanged += new System.EventHandler(this.tbDetail_TextChanged);
            // 
            // timerClipboard
            // 
            this.timerClipboard.Interval = 500;
            this.timerClipboard.Tick += new System.EventHandler(this.timerClipboard_Tick);
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(84, 172);
            this.tbLength.Name = "tbLength";
            this.tbLength.ReadOnly = true;
            this.tbLength.Size = new System.Drawing.Size(329, 20);
            this.tbLength.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Length [km]";
            // 
            // tbAbove
            // 
            this.tbAbove.Location = new System.Drawing.Point(84, 205);
            this.tbAbove.Name = "tbAbove";
            this.tbAbove.ReadOnly = true;
            this.tbAbove.Size = new System.Drawing.Size(329, 20);
            this.tbAbove.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Above";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(84, 231);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            this.tbHeight.Size = new System.Drawing.Size(329, 20);
            this.tbHeight.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Height [km]";
            // 
            // tbGravity
            // 
            this.tbGravity.Location = new System.Drawing.Point(84, 256);
            this.tbGravity.Name = "tbGravity";
            this.tbGravity.ReadOnly = true;
            this.tbGravity.Size = new System.Drawing.Size(329, 20);
            this.tbGravity.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Gravity [km]";
            // 
            // tbJumpGPS
            // 
            this.tbJumpGPS.Location = new System.Drawing.Point(84, 281);
            this.tbJumpGPS.Name = "tbJumpGPS";
            this.tbJumpGPS.ReadOnly = true;
            this.tbJumpGPS.Size = new System.Drawing.Size(329, 20);
            this.tbJumpGPS.TabIndex = 20;
            this.tbJumpGPS.DoubleClick += new System.EventHandler(this.tbJumpGPS_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Jump GPS";
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(84, 315);
            this.tbRef.Name = "tbRef";
            this.tbRef.ReadOnly = true;
            this.tbRef.Size = new System.Drawing.Size(304, 20);
            this.tbRef.TabIndex = 22;
            this.tbRef.DoubleClick += new System.EventHandler(this.tbRef_DoubleClick);
            // 
            // tbRefDist
            // 
            this.tbRefDist.Location = new System.Drawing.Point(84, 341);
            this.tbRefDist.Name = "tbRefDist";
            this.tbRefDist.ReadOnly = true;
            this.tbRefDist.Size = new System.Drawing.Size(329, 20);
            this.tbRefDist.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Reference";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Distance [km]";
            // 
            // btRef
            // 
            this.btRef.Location = new System.Drawing.Point(393, 315);
            this.btRef.Name = "btRef";
            this.btRef.Size = new System.Drawing.Size(20, 20);
            this.btRef.TabIndex = 23;
            this.btRef.Text = "<";
            this.btRef.UseVisualStyleBackColor = true;
            this.btRef.Click += new System.EventHandler(this.btRef_Click);
            // 
            // btDb
            // 
            this.btDb.Location = new System.Drawing.Point(393, 375);
            this.btDb.Name = "btDb";
            this.btDb.Size = new System.Drawing.Size(20, 20);
            this.btDb.TabIndex = 28;
            this.btDb.Text = "<";
            this.btDb.UseVisualStyleBackColor = true;
            this.btDb.Click += new System.EventHandler(this.btDb_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Distance [km]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Database";
            // 
            // tbDbDist
            // 
            this.tbDbDist.Location = new System.Drawing.Point(84, 400);
            this.tbDbDist.Name = "tbDbDist";
            this.tbDbDist.ReadOnly = true;
            this.tbDbDist.Size = new System.Drawing.Size(329, 20);
            this.tbDbDist.TabIndex = 31;
            // 
            // tbDb
            // 
            this.tbDb.Location = new System.Drawing.Point(84, 375);
            this.tbDb.Name = "tbDb";
            this.tbDb.ReadOnly = true;
            this.tbDb.Size = new System.Drawing.Size(304, 20);
            this.tbDb.TabIndex = 27;
            this.tbDb.DoubleClick += new System.EventHandler(this.tbDb_DoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 432);
            this.Controls.Add(this.btDb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbDbDist);
            this.Controls.Add(this.tbDb);
            this.Controls.Add(this.btRef);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbRefDist);
            this.Controls.Add(this.tbRef);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbJumpGPS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbGravity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAbove);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbGPS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Space Engineers GPS Tool";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGPS;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Timer timerClipboard;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAbove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGravity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbJumpGPS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.TextBox tbRefDist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btRef;
        private System.Windows.Forms.Button btDb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDbDist;
        private System.Windows.Forms.TextBox tbDb;
    }
}

