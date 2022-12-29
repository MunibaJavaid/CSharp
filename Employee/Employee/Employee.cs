using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private string _empName;
        private int _empID;
        public Employee()
        {
            _empName  = "David";
            _empID = 101;
        }
        static void Main(string[] args)
        {
            Employee E = new Employee();
            Employee e = E;
            E = null;

            try
            {
                Console.WriteLine("Emp Name: "+E._empName);
                Console.WriteLine("Emp ID: " + E._empID);
            }
            catch(NullReferenceException objNull)
            {
                Console.WriteLine("Error: "+objNull);
            }


        }
    }
}
