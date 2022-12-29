using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are eligible");
                }
                else
                {
                    throw new Exception("You are not Eligible");
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            Console.Read();
        }
    }
}
