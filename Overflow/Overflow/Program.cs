using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
       
        static void Main(string[] args)
        {
            byte numOne = 200;
            byte numTwo = 5;
            byte res = 0;

            try
            {
                res = checked((byte)(numOne + numTwo));
                Console.WriteLine("Result = {0}",res);
            }
            catch(OverflowException Ex)
            {
                Console.WriteLine("Message: {0}",Ex.Message);
                Console.WriteLine("Source {0}",Ex.Source);
                Console.WriteLine("TargetSite: {0}",Ex.TargetSite);
                Console.WriteLine("StackTrace: {0}",Ex.StackTrace);

            }

        }
    }
}
