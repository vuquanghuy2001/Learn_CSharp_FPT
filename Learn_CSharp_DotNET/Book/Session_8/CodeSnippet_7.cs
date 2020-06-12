using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_8
{
    interface ITerrestrialAnimal2
    {
        string Eat();
    }
    interface IMarineAnimal2
    {
        string Eat();
    }
    class Crocodile2: ITerrestrialAnimal2, IMarineAnimal2
    {
        string ITerrestrialAnimal2.Eat()
        {
            string terCroc = "Crocodile eats other animals";
            return terCroc;
        }
        string IMarineAnimal2.Eat()
        {
            string marCroc = "Crocdile eats fish and marine animals";
            return marCroc;
        }
        public string EatTerrestrial()
        {
            IMarineAnimal2 objTerAnimal2;
            objTerAnimal2 = this;
            return objTerAnimal2.Eat();
        }
        public string EatMarine()
        {
            IMarineAnimal2 objMarAnimal2;
            objMarAnimal2 = this;
            return objMarAnimal2.Eat();
        }
    }
}
