using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_QA
{
    public class Rectangle
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int Lenght { get; set; }

        public Rectangle()
        {
            Height = Lenght = Width = 1;
        }

        public Rectangle(int height, int length, int width)
        {
            Height = height;
            Lenght = length;
            Width = width;
        }

        public int GetLength()
        {
            return Lenght;
        }

        public int SetLength(int length)
        {
            Lenght = length;
            return Lenght;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int SetWidth(int width)
        {
            Width = width;
            return Width;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int SetHeight(int height)
        {
            Height = height;
            return Height;
        }

        public int GetVolume()
        {
            return Lenght * Height * Width;
        }
    }
}
