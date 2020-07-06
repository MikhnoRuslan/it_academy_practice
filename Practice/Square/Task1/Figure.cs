using System;

namespace Task1
{
    class Figure
    {
        private int  _firstSide;
        private int _secondSide;
        private int _radius;

        public Figure() {}

        internal int FirstSide
        {
            get => _firstSide;
            set
            {
                if (value >= 1 && value <= 10)
                    _firstSide = value;
                else
                    Console.WriteLine($"Error. Value should be from 1 to 10.");
            }
        }

        internal int SecondSide
        {
            get => _secondSide;
            set
            {
                if (value >= 1 && value <= 10)
                    _secondSide = value;
                else
                    Console.WriteLine($"Error. Value should be from 1 to 10.");
            }
        }

        internal int Radius
        {
            get => _radius;
            set
            {
                if (value >= 1 && value <= 10)
                    _radius = value;
                else
                    Console.WriteLine($"Error. Value should be from 1 to 10.");
            }
        }

        internal virtual void GetFigureData()
        {
            Console.Write($"This is {GetType().Name}. CLR Type is {GetType()}.");
        }
    }
}
