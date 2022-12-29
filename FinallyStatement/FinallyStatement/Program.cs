using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyStatement
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine("c: " + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed");
            }

            Console.Read();
        }
    }
}
