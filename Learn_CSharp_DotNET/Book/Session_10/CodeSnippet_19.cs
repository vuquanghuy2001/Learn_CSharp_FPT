using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_10
{
    namespace Automotive
    {
        namespace Vehicle
        {
            namespace Jeep
            {
                class Category2
                {
                    string _category;
                    public Category2()
                    {
                        _category = "Multi Utility Vehicle";
                    }
                    public void Display()
                    {
                        Console.WriteLine("Jeep Category: "+_category);
                    }
                }
            }
        }
    }
}
