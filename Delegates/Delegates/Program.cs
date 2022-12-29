using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculation(int num1, int num2); //delegate
    class Program
    {
        public static void Addition (int num1,int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("Addition Result is {0}",res);
        }
        public static void Subtraction(int num1, int num2)
        {
            int res = num1 - num2;
            Console.WriteLine("Subtraction Result is {0}", res);
        }
        public static void Multiplication(int num1, int num2)
        {
            int res = num1 * num2;
            Console.WriteLine("Multiplication Result is {0}", res);
        }
        public static void Division(int num1, int num2)
        {
            int res = num1 /num2;
            Console.WriteLine("Division Result is {0}", res);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addition);//delegate object
            obj += Subtraction;
            obj += Multiplication;
            obj(50, 100);
           

            Console.Read();
        }
    }
}
