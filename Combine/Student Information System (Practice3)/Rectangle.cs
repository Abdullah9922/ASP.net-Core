using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Information_System__Practice3_
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(r1.Width + r2.Width, r1.Height + r2.Height);
        }
    }
}
