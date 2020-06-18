//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    public delegate void Maths(int valOne, int valTow);
//    class MathsDemo
//    {
//        static void Addition(int valOne,int valTow)
//        {
//            int result = valOne + valTow;
//            Console.WriteLine("Addition: "+valOne+"+"+valTow+"="+result);
//        }
//        static void Subtraction(int valOne,int valTow)
//        {
//            int result = valOne - valTow;
//            Console.WriteLine("Subtraction: "+valOne+"-"+valTow+"="+result);
//        }
//        static void Multiplication(int valOne, int valTwo)
//        {
//            int result = valOne * valTwo;
//            Console.WriteLine("Multiplication: " +valOne + "*" +valTwo + "=" +result);
//        }
//        static void Division(int valOne,int valTow)
//        {
//            int result = valOne / valTow;
//            Console.WriteLine("Division: " + valOne + "/" + valTow + "=" + result);
//        }
//        static void Main(string[] args)
//        {
//            Maths objmaths = new Maths(Addition);
//            objmaths += new Maths(Subtraction);
//            objmaths += new Maths(Multiplication);
//            objmaths += new Maths(Division);
//            if (objmaths != null)
//            {
//                objmaths(20, 10);
//            }
//            Console.ReadKey();
//        }
//    }
//}
