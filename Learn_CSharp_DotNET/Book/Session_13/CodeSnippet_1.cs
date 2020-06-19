//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_13
//{
//    class ReadOnly
//    {
//        static void Main(string[] args)
//        {
//            List<string> objList = new List<string>();
//            objList.Add("Francis");
//            objList.Add("James");
//            objList.Add("Baptista");
//            objList.Add("Micheal");
//            ReadOnlyCollection<string> objReadOnly = new ReadOnlyCollection<string>(objList);
//            foreach(string str in objReadOnly)
//            {
//                Console.WriteLine(str);
//            }
//            Console.WriteLine();
//            Console.WriteLine("Total number of elements in the read only collection: "+objReadOnly.Count);
//            if (objList.Contains("Francis"))
//            {
//                objList.Insert(2, "Peter");
//            }
//            Console.WriteLine("\nValues stroed in the list after modification");
//            foreach(string str in objReadOnly)
//            {
//                Console.WriteLine(str);
//            }
//            string[] array = new string[objReadOnly.Count * 2];
//            objReadOnly.CopyTo(array, 5);
//            Console.WriteLine("\nTotal number of values that can be stored in the new array: "+array.Length);
//            Console.WriteLine("values in the array");
//            foreach(string str in array)
//            {
//                if (str == null)
//                {
//                    Console.WriteLine("null");
//                }
//                else
//                {
//                    Console.WriteLine(str);
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}
