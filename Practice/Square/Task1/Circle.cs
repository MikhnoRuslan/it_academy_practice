using System;

namespace Task1
{
    class Circle : Figure
    {
        public Circle() {}

        public Circle(int radius)
        {
            Radius = radius;
        }

        internal double SetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        internal override void GetFigureData()
        {
            base.GetFigureData();
            Console.WriteLine($" Square is {SetArea()}\n");
        }
    }
}
