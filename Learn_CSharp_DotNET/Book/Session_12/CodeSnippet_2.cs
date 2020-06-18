//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    public delegate int Caculation(int numOne, int numTow);
//    class Mathematics
//    {
//        public static int Addition(int numOne, int numTow)
//        {
//            return (numOne + numTow);
//        }
//        public static int Subtraction(int numOne, int numTow)
//        {
//            return (numOne - numTow);
//        }
//        static void Main(string [] args)
//        {
//            int valOne = 5;
//            int valTow = 23;
//            Caculation objCaculation = new Caculation(Addition);
//            Console.WriteLine(valOne+"+"+valTow+"="+objCaculation(valOne, valTow));
//            Console.ReadKey();
//        }
//    }
//}
