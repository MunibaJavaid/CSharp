using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Property
{
    public abstract class Figure
    {
        public abstract float DimensionOne
        {
            set;
        }
        public abstract float DimensionTwo {
            set;
        }

    }
    class Rectangle: Figure
    {
        float _dimensionOne;
        float _dimensionTwo;

        public override float DimensionOne {
            set
            {
                if(value <= 0)
                {
                    _dimensionOne = 0;
                    Console.WriteLine("value is not less than 0");                     
                }
                else
                {
                    _dimensionOne = value;
                }
            }
        }
        public override float DimensionTwo
        {
            set
            {
                if (value <= 0)
                {
                    _dimensionTwo = 0;
                    
                }
                else
                {
                    _dimensionTwo = value;
                }
            }
        }
        float Area()
        {
            return _dimensionOne * _dimensionTwo;
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.DimensionOne = -9;
            r.DimensionTwo = 90;
            Console.WriteLine("Area of Rectangle: "+r.Area());

            Console.Read();
        }
    }
}
