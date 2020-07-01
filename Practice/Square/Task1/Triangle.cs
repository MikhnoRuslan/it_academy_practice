using System;

namespace Task1
{
    class Triangle : Figure
    {
        public  Triangle() {}

        public Triangle(int firstSide, int secondSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        internal double SetArea()
        {
            return FirstSide * (double)SecondSide / 2;
        }

        internal override void GetFigureData()
        {
            base.GetFigureData();
            Console.WriteLine($" Square is {SetArea()}\n");
        }
    }
}
