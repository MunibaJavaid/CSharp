using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> e1 = new Employee<String>();
            Employee<float> e2 = new Employee<float>(101.1F, 45.5F);
            Employee<string> e3 = new Employee<string>("001", "Xyz", "Abc");

            Console.WriteLine("\n\n");

            Student s1 = new Student();
            s1.info("101", "xyz","abc@gmail.com");
        }
    }

    public class Employee <T> {

        public Employee()
        {
            Console.WriteLine("This is Default Constructor");
        }

        public Employee(T id, T marks)
        {
            Console.WriteLine("My id is {0} ",id);
            Console.WriteLine("My marks is {0}",marks);
        }

        public Employee(T fn, T mn,T ln)
        {
            Console.WriteLine("My First Name is {0}",fn);
            Console.WriteLine("My Middle Name is {0}", mn);
            Console.WriteLine("My Last Name is {0}", ln);
        }
    }
}
public class Student
{
    public void info<T>(T std_Id, T std_name,T std_email)
    {
        Console.WriteLine("Student Id is: {0}",std_Id);
        Console.WriteLine("Student Name is: {0}", std_name);
        Console.WriteLine("Student Email is: {0}", std_email);
    }
}