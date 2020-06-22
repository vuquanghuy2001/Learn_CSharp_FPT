using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practive_VuQuangHuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] objProduct ={
                new Book(01,"Toan",10000,"Giao Duc"),
                new Book(02,"Ly",12000,"Giao Duc"),
                new Book(03,"Hoa",13000,"Giao Duc"),
                new MobilePhone(001,"Iphone",1200,"Apple"),
                new MobilePhone(002,"Galaxy",1000,"SamSung"),
                new MobilePhone(003,"Oppo",900,"Nokia")
            };
            double sumTax=0;
            foreach (var item in objProduct)
            {
                sumTax+=item.computeTax();
            }
            Console.WriteLine("Tax is: "+sumTax);
            Console.ReadKey();
        }
    }
}
