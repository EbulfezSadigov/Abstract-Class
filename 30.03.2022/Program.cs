using _30._03._2022.Models;
using System;

namespace _30._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squ = new Square(5);

            Rectangular rec = new Rectangular(4, 5);
            bool f = true;
            int input = 0;
            while (f == true)
            {
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        squ.CalcArea();
                        break;
                    case 2:
                        rec.CalcArea();
                        break;
                    case 0:
                        f = false;
                        break;
                }
            }
        }
    }
}
