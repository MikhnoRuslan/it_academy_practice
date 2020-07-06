using System;

namespace Task1
{
    class Program
    {
        private const string First = "first";
        private const string Second = "second";
        private const string Square = "Square:";
        private const string Triangle = "Triangle:";
        private const string Circle = "Circle:";

        static void Main()
        {
            GetValueFigure(First, Second);
        }

        static int EnterValue(string str)
        {
            Console.WriteLine($"Enter {str} side:");
            int value = Convert.ToInt32(Console.ReadLine());

            return value;
        }

        static int EnterRadius()
        {
            Console.WriteLine($"Enter radius:");
            int value = Convert.ToInt32(Console.ReadLine());

            return value;
        }

        static int Key()
        {
            Console.WriteLine($"Which figure should be calculated?");
            Console.WriteLine($"1 - Square;\n2 - Triangle;\n3 - Circle;");
            int key;
            do
            {
                key = Convert.ToInt32(Console.ReadLine());
                if (key != 1 && key != 2 && key != 3)
                    Console.WriteLine($"Value should be from 1 to 3");
            } while (key != 1 && key !=2 && key != 3);

            return key;
        }

        static void GetValueFigure(string first, string second)
        {
            Figure[] figure = new Figure[5];

            for (int i = 0; i < figure.Length; i++)
            {
                int key = Key();
                if (key == 1)
                {
                    Console.WriteLine(Square);
                    figure[i] = new Square(EnterValue(first), EnterValue(second));
                    figure[i].GetFigureData();
                }
                else if (key == 2)
                {
                    Console.WriteLine(Triangle);
                    figure[i] = new Triangle(EnterValue(first), EnterValue(second));
                    figure[i].GetFigureData();
                }

                else if (key == 3)
                {
                    Console.WriteLine(Circle);
                    figure[i] = new Circle(EnterRadius());
                    figure[i].GetFigureData();
                }
            }
        }
    }
}
