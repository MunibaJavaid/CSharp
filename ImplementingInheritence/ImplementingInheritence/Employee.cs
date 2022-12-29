using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInheritence
{
    class Employee
    {
        string Name { get; set; }
        int age { get; set; }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "John Doe";
            e.age = 24;
            Console.WriteLine("Name: {0}, Age {1}",e.Name,e.age);
            Console.Read();
        }
    }
}
