using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReference
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = null;
                Console.WriteLine(name.Length);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("String is null....");
                Console.WriteLine(ex.Message);

            }
        }
    }
}
