using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentDetails
    {
        string _studName = "John";
        int _studId = 30;
        public StudentDetails()
        {
            Console.WriteLine("Student Name: "+_studName);
            Console.WriteLine("Student Id: "+_studId);
        }
        static void Main(string[] args)
        {      
            StudentDetails SD = new StudentDetails();
            Examination.ScoreReport SR = new Examination.ScoreReport();
            Console.WriteLine("Subject: " + SR.subject);
            Console.WriteLine("Marks: " + SR.Marks);
        }
    }
}
namespace Examination
{
    class ScoreReport
    {
        public string subject = "Science";
        public int Marks = 60;

    }
}
