//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    class Customers
//    {
//        static void Main(string[] args)
//        {
//            ArrayList objCustomers = new ArrayList();
//            objCustomers.Add("Nicole Anderson");
//            objCustomers.Add("Ashley Thomas");
//            objCustomers.Add("Garry White");
//            Console.WriteLine("Fixed Size: " + objCustomers.IsFixedSize);
//            Console.WriteLine("Count: " + objCustomers.Count);
//            Console.WriteLine("List of customers: ");
//            foreach (string names in objCustomers)
//            {
//                Console.WriteLine("{0}", names);
//            }
//            objCustomers.Sort();
//            Console.WriteLine("\nList of customers after aorting; ");
//            foreach (string names in objCustomers)
//            {
//                Console.WriteLine("{0}", names);
//            }
//            objCustomers.Clear();
//            Console.WriteLine("count after removing all elements: " + objCustomers.Count);
//            Console.ReadKey();
//        }
//    }
//}
