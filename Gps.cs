using System.Globalization;
using System.Numerics;

namespace SEGPS
{
    class Gps
    {
        public const string ColorDefault = "#FF75C9F1";
        public const NumberStyles NumberStyle = NumberStyles.Number;
        public static CultureInfo NumberFormat = CultureInfo.CreateSpecificCulture("en-US");

        private Vector3 v = new Vector3();

        public string Name { get; private set; }
        public float X { get { return v.X; } private set { v.X = value; } }
        public float Y { get { return v.Y; } private set { v.Y = value; } }
        public float Z { get { return v.Z; } private set { v.Z = value; } }
        public string Color { get; private set; }

        public bool IsValid { get; private set; }

        public Gps(string text)
        {
            Color = ColorDefault;
            IsValid = true;

            string[] array = text.Split(':');
            if (array.Length != 7 || array[0] != "GPS")
            {
                IsValid = false;
                return;
            }

            Name = array[1];

            float x = 0;
            float y = 0;
            float z = 0;
            if (!float.TryParse(array[2], NumberStyle, NumberFormat, out x)) IsValid = false;
            if (!float.TryParse(array[3], NumberStyle, NumberFormat, out y)) IsValid = false;
            if (!float.TryParse(array[4], NumberStyle, NumberFormat, out z)) IsValid = false;
            v = new Vector3(x, y, z);

            Color = array[5];
        }

        public Gps(string name, float x, float y, float z, string color)
        {
            Name = name;
            X = x;
            Y = y;
            Z = z;
            Color = color;
        }

        public float Length()
        {
            return v.Length();
        }

        public float Distance(Gps other)
        {
            return (other.v - this.v).Length();
        }

        public Gps ProjectOntoSphere(Gps other, float radius)
        {
            float d = Distance(other);
            Vector3 direction = (other.v - this.v) / d;
            Vector3 scaled = this.v + direction * radius;
            return new Gps("-> " + other.Name, scaled.X, scaled.Y, scaled.Z, other.Color);
        }

        public static string GetGpsString(string name, string x, string y, string z, string color)
        {
            return $"GPS:{name}:{x}:{y}:{z}:{color}:";
        }

        public static string GetGpsString(string name, float x, float y, float z, string color)
        {
            return GetGpsString(name, x.ToString(NumberFormat), y.ToString(NumberFormat), z.ToString(NumberFormat), color);
        }

        public static string GetGpsString(string name, Vector3 v, string color)
        {
            return GetGpsString(name, v.X, v.Y, v.Z, color);
        }

        public override string ToString()
        {
            return GetGpsString(Name, v, Color);
        }
    }
}
