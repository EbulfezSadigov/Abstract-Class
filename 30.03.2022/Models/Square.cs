using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._03._2022.Models
{
    class Square : Figure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }
        public Square(int Side)
        {
            this.Side = Side;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Area of square is " + Side * Side);
        }
    }
}
