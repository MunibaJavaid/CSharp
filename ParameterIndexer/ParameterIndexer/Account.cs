using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterIndexer
{
    class Account
    {
        string[,] accountDetails = new string[4, 2];

        public string this[int pos,int columns]
        {
            get {
                return (accountDetails[pos, columns]);
            }
            set {
                accountDetails[pos, columns] = value;
            }
        }
        static void Main(string[] args)
        {
            Account a = new Account();
            string[] id = new string[3] { "1001", "1002", "1003" };
            string[] name = new string[3] { "John", "Peter", "Patrick"};

            int counter = 0;//2
            for(int i = 0; i < 3; i++) //0<4//1<4
            {
                for(int j = 0; j < 1; j++) //0<1 //0<1
                {
                    a[i, j] = id[counter]; //a[0][0] = 1001 //a[1][0] = 1002
                    a[i, j + 1] = name[counter++]; //a[0][1] = John //a[1][1] = "Peter"
                }
            }
            Console.WriteLine("ID Name");
            Console.WriteLine();

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Array Index a[{0}][{1}] = {2}",i,j,a[i,j]+ " ");
                }
            }
            Console.WriteLine();

        }
    }
}
