using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_11
{
    class NumberDoer
    {
        public void Process(int numOne, int numTow)
        {
            try
            {
                if (numTow == 0)
                {
                    throw new DivideByZeroException("Value of divisor is zero");
                }
                else
                {
                    Console.WriteLine("Quotient: " + (numOne / numTow));
                    Console.WriteLine("Remainder: " + (numOne / numTow));
                }
            }
            catch (DivideByZeroException objDivide)
            {
                {
                    Console.WriteLine("Error: " + objDivide);
                }
            }
        }
    }
    class NumberTester
    {
        NumberDoer objDoer = new NumberDoer();
        public void AcceptDetails()
        {
            int dividend = 0;
            int divisor = 0;
            Console.WriteLine("Enter the value of dividend");
            try
            {
                dividend = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException objForm)
            {
                Console.WriteLine("Error: " + objForm);
            }
            Console.WriteLine("Enter the value of divisor");
            try
            {
                divisor = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException objFormat)
            {
                Console.WriteLine("Error: " + objFormat);
            }
            if ((dividend > 0) || (divisor > 0))
            {
                objDoer.Process(dividend, divisor);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
