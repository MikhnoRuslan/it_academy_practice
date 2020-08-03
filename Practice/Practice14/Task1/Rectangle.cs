using System;

namespace Task1
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void ShowRectangle()
        {
            Console.WriteLine($"{Width} {Height}");
        }
    }
}