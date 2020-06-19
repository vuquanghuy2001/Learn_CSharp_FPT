//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    class Car
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
//            objDictionary.Add(201, "Gear Box");
//            objDictionary.Add(220, "Oil Filter");
//            objDictionary.Add(330, "Engine");
//            objDictionary.Add(305, "Radiator");
//            objDictionary.Add(303, "Steering");
//            Console.WriteLine("Dictionary class contains values of type");
//            Console.WriteLine(objDictionary.GetType());
//            Console.WriteLine("Keys \t\t Values");
//            Console.WriteLine("__________________________");
//            IDictionaryEnumerator objDictionayEnumerator = objDictionary.GetEnumerator();
//            while (objDictionayEnumerator.MoveNext())
//            {
//                Console.WriteLine(objDictionayEnumerator.Key.ToString()
//                + "\t\t" + objDictionayEnumerator.Value);
//            }
//            Console.ReadKey();
//        }
//    }
//}
