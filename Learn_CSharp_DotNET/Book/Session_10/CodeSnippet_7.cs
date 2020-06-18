using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_10
{
    namespace Automotive
    {
        public class Category
        {
            string _category;
            public Category()
            {
                _category = "Multi Utility Vehicle";
            }
            public void Display()
            {
                Console.WriteLine("Category: "+_category);
            }
        }
    }
}
