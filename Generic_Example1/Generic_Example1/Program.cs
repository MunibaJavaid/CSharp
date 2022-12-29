using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            num[0] = 12;
            num[1] = 19;
            num[2] = 78;

            string[] names = { "xyz", "abc", "efg" };

            Example.showArray(num);
            Example.showArray(names);


            Console.WriteLine(Example.Check(10,20));

            Console.WriteLine(Example.Check('A','A'));
            Console.WriteLine(Example.Check("xyz","Abc"));


        }
    }

    class Example
    {
        public static void showArray<T>(T[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public static bool Check<T>(T a,T b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
}
