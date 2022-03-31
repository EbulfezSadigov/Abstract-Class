using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._03._2022.Models
{
    class Rectangular : Figure
    {
        private int _width;
        private int _length;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Area of rectangular is " + Width * Length);
        }
    }
}
