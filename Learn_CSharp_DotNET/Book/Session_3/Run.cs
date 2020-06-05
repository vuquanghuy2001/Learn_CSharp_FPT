using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_3
{
    class Run
    {
        public static void Test()
        {
            CS2();
            //CS4();
            //CS5();
            //CS7();
            //CS8();
            //CS15();
            //CS16();
            //CS17();
        }

        private static void CS2()
        {
            int side = 10;
            int height = 5;
            double area = 0.5 * side * height;
            Console.WriteLine("Area: {0}", area);
            Console.ReadKey();
        }

        private static void CS4()
        {
            byte numOne = 255;
            byte numTow = 1;
            byte result = 0;
            try
            {
                checked
                {
                    result = (byte)(numOne + numTow);
                }
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        private static void CS5()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                unchecked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        private static void CS7()
        {
            int valueOne = 10;
            int valueTwo = 2;
            int add = valueOne + valueTwo;
            int sub = valueOne - valueTwo;
            int mult = valueOne * valueTwo;
            int div = valueOne / valueTwo;
            int modu = valueOne % valueTwo;
            Console.WriteLine("Addition " + add);
            Console.WriteLine("Subtraction " + sub);
            Console.WriteLine("Multiplication " + mult);
            Console.WriteLine("Division " + div);
            Console.WriteLine("Remainder " + modu);
            Console.ReadKey();
        }

        private static void CS8()
        {
            int leftVal = 50;
            int rightVal = 100;
            Console.WriteLine("Equal: " + (leftVal == rightVal));
            Console.WriteLine("Not Equal: " + (leftVal != rightVal));
            Console.WriteLine("Greater: " + (leftVal > rightVal));
            Console.WriteLine("Lesser: " + (leftVal < rightVal));
            Console.WriteLine("Greater or Equal: " + (leftVal >= rightVal));
            Console.WriteLine("Lesser or Equal: " + (leftVal <= rightVal));
            Console.ReadKey();
        }

        private static void CS15()
        {
            int num = 0;
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
            else
            {
                Console.WriteLine("The number does not exist between 1 and 10");
            }
        }

        private static void CS16()
        {
            int num = 0;
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
            else
            {
                Console.WriteLine("The number does not exist between 1 and 10");
            }
        }

        private static void CS17()
        {
            int valueOne = 5;
            int valueTwo = 10;
            Console.WriteLine("Value1 =" + valueOne);
            valueOne += 4;
            Console.WriteLine("Value1 += 4 = " + valueOne);
            valueOne -= 8;
            Console.WriteLine("Value1 -= 8 = " + valueOne);
            valueOne *= 7;
            Console.WriteLine("Value1 *= 7 = " + valueOne);
            valueOne /= 2;
            Console.WriteLine("Value1 /= 2 = " + valueOne);
            Console.WriteLine("Value1 == Value2: { 0}", (valueOne == valueTwo));
        }

        private static void CS18()
        {
            int valueOne = 10;
            Console.WriteLine((4 * 5 - 3) / 6 + 7 - 8 % 5);
            Console.WriteLine((32 < 4) || (8 == 8));
            Console.WriteLine(((valueOne *= 6) > (valueOne += 5)) &&
            ((valueOne /= 2) != (valueOne -= 5)));
        }

        private static void CS19()
        {
            uint num = 100; // 01100100 = 100
            uint result = num << 1; // 11001000 = 200
            Console.WriteLine("Value before left shift: " + num);
            Console.WriteLine("Value after left shift " + result);
            num = 80; // 10100000 =
            result = num >> 1; // 01010000 = 40
            Console.WriteLine("\nValue before right shift: " + num);
            Console.WriteLine("Value after right shift: " + result);
        }

        private static void CS20()
        {
            int num = 6;
            string msg = "";
            if (num < 0)
            {
                msg = "The number " + num + " is negative";
            }
            else if ((num % 2) == 0)
            {
                msg = "The number " + num + " is even";
            }
            else
            {
                msg = "The number " + num + " is odd";
            }
            if (msg != "")
                Console.WriteLine(msg);
        }

        private static void CS21()
        {
            int numOne = 5;
            int numTwo = 25;
            int numThree = 15;
            int result = 0;
            if (numOne > numTwo)
            {
                result = (numOne > numThree) ? result = numOne : result =
                numThree;
            }
            else
            {
                result = (numTwo > numThree) ? result = numTwo : result =
                numThree;
            }
            if (result != 0)
                Console.WriteLine("{0} is the largest number", result);
        }

        private static void CS23()
        {
            double side = 10.5;
            int area;
            area = (int)(side * side);
            Console.WriteLine("Area of the square = {0}", area);
        }

        private static void CS24()
        {
            float flotNum = 500.25F;
            string stNum = flotNum.ToString();
            Console.WriteLine(stNum);
        }

        private static void CS25()
        {
            int radius = 10;
            double area;
            area = 3.14 * radius * radius;
            object boxed = area;
            Console.WriteLine("Area of the circle = {0}", boxed);
        }

        private static void CS26()
        {
            float radius = 4.5F;
            double circumference;
            circumference = 2 * 3.14 * radius;
            object boxed = (object)circumference;
            Console.WriteLine("Circumference of the circle = {0}", circumference);
        }

        private static void CS27()
        {
            float radius = 4.5F;
            double circumference;
            circumference = 2 * 3.14 * radius;
            object boxed = (object)circumference;
            Console.WriteLine("Circumference of the circle = {0}", circumference);
        }

        private static void CS28()
        {
            int num = 8;
            int result;
            result = Square(num);
            Console.WriteLine("Square of { 0} = { 1}", num, result);
        }
        static int Square(object inum)
        {
            return (int)inum * (int)inum;
        }
    }
}
