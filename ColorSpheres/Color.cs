using System;

namespace ColorSpheres
{

    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public byte Red
        {
            get { return red; }
            private set { red = value; }
        }
        public byte Green
        {
            get { return green; }
            private set { green = value; }
        }
        public byte Blue
        {
            get { return blue; }
            private set { blue = value; }
        }
        public byte Alpha
        {
            get { return alpha; }
            private set { alpha = value; }
        }

        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        public byte GetGrey()
        {
            return (byte)((Red + Green + Blue) / 3);
        }

    }
}