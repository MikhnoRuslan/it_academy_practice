using System;

namespace Task1
{
    class Square : Figure
    {
        public Square() {}

        public Square(int firstSide, int secondSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
        }

        internal int SetArea()
        {
            return FirstSide * SecondSide;
        }

        internal override void GetFigureData()
        {
            base.GetFigureData();
            Console.WriteLine($" Square is {SetArea()}\n");
        }
    }
}
