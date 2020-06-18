using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_10
{
    namespace Utility_Vehcle
    {
        namespace Car
        {
            class Category
            {
                string _category;
                public Category()
                {
                    _category = "Luxury Vehicle";
                }
                public void Display()
                {
                    Console.WriteLine("Car Category: "+_category);
                }
            }
        }
    }
}
