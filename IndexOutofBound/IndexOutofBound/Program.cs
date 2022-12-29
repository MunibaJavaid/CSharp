using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutofBound
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            try
            {
                arr[0] = 11;
                arr[1] = 12;
                arr[2] = 13;
                arr[3] = 14;
                foreach(int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array range is exceed.......");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
