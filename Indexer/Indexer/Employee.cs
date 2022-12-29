using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Employee
    {
        private int[] Age = new int[3];

        public int this[int index]
        {
            get {
                return Age[index];
            }
            set {
                if(index >= 0 && index < Age.Length)
                {
                    if(value > 0)
                    {
                        Age[index] = value;

                    }
                    else
                    {
                        Console.WriteLine("Value is Invalid");
                    }
                }

                Age[index] = value;
            }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e[0] = -24;
            e[1] = 15;
            e[2] = 19;
            Console.WriteLine("Employee Age: ");
            for(int i = 0; i <= 2; i++)
            {
                Console.Write(e[i]+ "\t");
            }

        }
    }
}
