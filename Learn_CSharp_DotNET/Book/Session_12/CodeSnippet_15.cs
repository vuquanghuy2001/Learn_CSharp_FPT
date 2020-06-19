//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    class SortedCollection
//    {
//        static void Main(string[] args)
//        {
//            SortedList objSortList = new SortedList();
//            objSortList.Add("John", "Administration");
//            objSortList.Add("Jack", "Human Resources");
//            objSortList.Add("Peter", "Finance");
//            objSortList.Add("Joel", "Marketing");
//            Console.WriteLine("Original values stored in the sorted list");
//            Console.WriteLine("Key\t\tValues");
//            for(int i = 0; i < objSortList.Count; i++)
//            {
//                Console.WriteLine(objSortList.GetKey(i)+"\t\t"+objSortList.GetByIndex(i));
//            }
//            if (!objSortList.ContainsKey("jerry"))
//            {
//                objSortList.Add("Jerry", "Construction");
//            }
//            objSortList["Peter"] = "Engineering";
//            objSortList["Jerry"] = "information Technology";
//            Console.WriteLine();
//            Console.WriteLine("Update values stored in hashtable");
//            Console.WriteLine("Key\t\tValues");
//            for(int i = 0; i < objSortList.Count; i++)
//            {
//                Console.WriteLine(objSortList.GetKey(i)+"\t\t"+objSortList.GetByIndex(i));
//            }
//            Console.ReadKey();
//        }
//    }
//}
