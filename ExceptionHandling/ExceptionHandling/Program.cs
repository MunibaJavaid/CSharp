using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne;
            int numTwo;
            int res;

            Console.WriteLine("Enter Num1: ");
            numOne = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Num2: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            try
            {
                res = numOne / numTwo;
                Console.WriteLine("Result: " + res);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can not divided by Zero");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Statemt 1");
            Console.WriteLine("Statemt 2");
            Console.WriteLine("Statemt 3");


        }
    }
}
