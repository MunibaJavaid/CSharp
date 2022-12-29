using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism
{
    class Student
    {
        string[] studName = new string[2];
        public virtual string this[int index]
        {
            get {
                return studName[index];
            }
            
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s[0] = "ABC";
        }
    }
}
