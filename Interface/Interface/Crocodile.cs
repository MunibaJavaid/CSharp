using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ITerrestrialAnimal
    {
        string Eat();
    }
    interface IMarineAnimal {
        string Eat();
    }

    class Crocodile: ITerrestrialAnimal, IMarineAnimal
    {
        string ITerrestrialAnimal.Eat()
        {
            string terCroc = "Crocodile eats other animals";
            return terCroc;
        }

        string IMarineAnimal.Eat()
        {
            string marCroc = "Crocodile eats Fish and marine animals";
            return marCroc;
        }

        public string EatTerrestrial()
        {
            ITerrestrialAnimal objTerAnimal;
            objTerAnimal = this;
            return objTerAnimal.Eat();
        }

        public string EatMarine()
        {
            IMarineAnimal objMarAnimal;
            objMarAnimal = this;
            return objMarAnimal.Eat();
        }
        static void Main(string[] args)
        {
            Crocodile objCroc = new Crocodile();
            string terCroc = objCroc.EatTerrestrial();

            Console.WriteLine(terCroc);

            string marCroc = objCroc.EatMarine();
            Console.WriteLine(marCroc);

            Console.Read();
        }
    }
}
