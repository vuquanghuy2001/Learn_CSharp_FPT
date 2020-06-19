//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    class DictionaryCollecyion
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
//            objDictionary.Add(25, "Hard Disk");
//            objDictionary.Add(30, "Processor");
//            objDictionary.Add(15, "MotherBoard");
//            objDictionary.Add(65, "Memory");
//            ICollection objCollect = objDictionary.Keys;
//            Console.WriteLine("Original values stored in the collection");
//            Console.WriteLine("Keys\tValues");
//            Console.WriteLine("----------------");
//            foreach(int i in objCollect)
//            {
//                Console.WriteLine(i+"\t"+objDictionary[i]);
//            }
//            objDictionary.Remove(65);
//            Console.WriteLine();
//            if (objDictionary.ContainsValue("Memery"))
//            {
//                Console.WriteLine("Value Memory could not be deleted");
//            }
//            else
//            {
//                Console.WriteLine("Value Memory deleted succesfully");
//            }
//            Console.WriteLine();
//            Console.WriteLine("Values stored after removing element");
//            Console.WriteLine("Keys\tValues");
//            Console.WriteLine("----------------");
//            foreach(int i in objCollect)
//            {
//                Console.WriteLine(i+"\t"+objDictionary[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}
