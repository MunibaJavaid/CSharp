using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        private int ID;
        private string Name;
        private int _TotalMarks = 100;
        public int _Id //Property
        {
            get
            {
                return ID;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Id is not Consider");
                }
                else
                {
                    ID = value;
                    Console.WriteLine("Student Id: " +ID);
                }
                
            }
        }
        public string _Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name is not consider");
                }
                else
                {
                    Name = value;
                    Console.WriteLine("Student Name: " + Name);
                }
               
            }
        }
        public int TotalMarks
        {
            get
            {
                return _TotalMarks;
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s._Id = 45;
            s._Name = "XYZ";

            //s.TotalMarks = 150;
            Console.WriteLine("Total Marks: "+s.TotalMarks);
           
            Console.Read();
        }
    }
}
