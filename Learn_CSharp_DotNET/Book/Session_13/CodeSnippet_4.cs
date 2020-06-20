//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_13
//{
//    class SWapNumbers
//    {
//        static void Swap<T>(ref T valOne,ref T valTow)
//        {
//            T temp = valOne;
//            valOne = valTow;
//            valTow = temp;
//        }
//        static void Main(string[] args)
//        {
//            int numOne = 23;
//            int numTow = 45;
//            Console.WriteLine("values before swapping: "+numOne+"&"+numTow);
//            Swap<int>(ref numOne, ref numTow);
//            Console.WriteLine("Values after swapping: "+numOne+"&"+numTow);
//            Console.ReadKey();
//        }
//    }
//}
