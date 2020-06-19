//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    class HashCollection
//    {
//        public static void Main(string[] args)
//        {
//            Hashtable objTable = new Hashtable();
//            objTable.Add(001, "John");
//            objTable.Add(002, "Peter");
//            objTable.Add(003, "James");
//            objTable.Add(004, "Joe");
//            Console.WriteLine("Numbers of elements in the hash table: "+objTable.Count);
//            ICollection objCollection = objTable.Keys;
//            Console.WriteLine("Original values stored in hash table are: ");
//            foreach(int i in objCollection)
//            {
//                Console.WriteLine(i+":"+objTable[i]);
//            }
//            if (objTable.ContainsKey(002))
//            {
//                objTable[002] = "Patrick";
//            }
//            Console.WriteLine("Values stored in the hashtable after removing values");
//            foreach(int i in objCollection)
//            {
//                Console.WriteLine(i+":"+objTable[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}
