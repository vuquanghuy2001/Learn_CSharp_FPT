//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.CodeLean.AP_15
//{
//    class Divide
//    {
//        static int Divide2(int first,int second)
//        {
//            int result = 0;
//            try
//            {
//                result = first / second;
//            }
//            catch(DivideByZeroException ex)
//            {
//                Console.WriteLine("Cannot divide bt zero,please provide a non-zero value for your second value");
//            }
//            return result;
//        }
//        static void Main(string [] agrs)
//        {
//            int first = 9;
//            int second = 0;
//            Console.WriteLine("Enter your first number: ");
//            first = System.Int32.Parse(Console.ReadLine());
//            Console.WriteLine("Enter your second number: ");
//            second = System.Int32.Parse(Console.ReadLine());

//            int result = Divide2(first, second);
//            Console.WriteLine($"The result of dividing {first} by {second} is {result}");
//            Console.ReadKey();
//        }
//    }
//}
