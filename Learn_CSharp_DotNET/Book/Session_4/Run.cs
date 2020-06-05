using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_4
{
    class Run
    {
        public static void Test()
        {
            //Code_Snippet_1();
            //Code_Snippet_2();
            //Code_Snippet_3();
            //Code_Snippet_4();
            //Code_Snippet_5();
            //Code_Snippet_6();
            //Code_Snippet_7();
            //Code_Snippet_8();
            //Code_Snippet_9();
            //Code_Snippet_10();
            //Code_Snippet_11();
            //Code_Snippet_12();
            //Code_Snippet_13();
            //Code_Snippet_14();
            //Code_Snippet_16();
            //Code_Snippet_17();
            //Code_Snippet_18();
            //Code_Snippet_19();
            //Code_Snippet_20();
            //Code_Snippet_21();
            //Code_Snippet_22();
            //Code_Snippet_23();
            //Code_Snippet_24();
        }

        public static void Code_Snippet_1()
        {
            int num = -4;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
        }

        public static void Code_Snippet_2()
        {
            int num = 10;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is positive");
            }
        }

        public static void Code_Snippet_3()
        {
            int num = 13;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if ((num % 2) == 0)
            {
                Console.WriteLine("The number is even");
            }
        }

        public static void Code_Snippet_4()
        {
            int yrsOfService = 3;
            double salary = 1500;
            int bonus = 0;
            if (yrsOfService < 5)
            {
                if (salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonus amount: " + bonus);
        }

        public static void Code_Snippet_5()
        {
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter a number between 1 to 7");
                    break;
            }
        }

        public static void Code_Snippet_6()
        {
            int numOne;
            int numTwo;
            int result = 0;
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Division");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value one");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value two");
            numTwo = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    result = numOne + numTwo;
                    break;
                case 2:
                    result = numOne - numTwo;
                    break;
                case 3:
                    result = numOne * numTwo;
                    break;
                case 4:
                    Console.WriteLine("Do you want to calculate the quotient or remainder ?");
                    Console.WriteLine("(1) Quotient");
                    Console.WriteLine("(2) Remainder");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            result = numOne / numTwo;
                            break;
                        case 2:
                            result = numOne % numTwo;
                            break;
                        default:
                            Console.WriteLine("Incorrect Choice");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect Choice");
                    break;
            }
            Console.WriteLine("Result: " + result);
        }

        public static void Code_Snippet_7()
        {
            string input;
            Console.WriteLine("Enter the month");
            input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "JANUARY":
                case "MARCH":
                case "MAY":
                case "JULY":
                case "AUGUST":
                case "OCTOBER":
                case "DECEMBER":
                    Console.WriteLine("This month has 31 days");
                    break;
                case "APRIL":
                case "JUNE":
                case "SEPTEMBER":
                case "NOVEMBER":
                    Console.WriteLine("This month has 30 days");
                    break;
                case "FEBRUARY:":
                    Console.WriteLine("This month has 28 days in a non - leap year and 29 days in a leap year");
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }
        }

        public static void Code_Snippet_8()
        {
            int num = 1;
            Console.WriteLine("Even Numbers");
            while (num <= 11)
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            }
        }

        public static void Code_Snippet_9()
        {
            int i = 0;
            int j;
            while (i <= 5)
            {
                j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }

        public static void Code_Snippet_10()
        {
            int num = 1;
            Console.WriteLine("Even Numbers");
            do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            } while (num <= 11);
        }

        public static void Code_Snippet_11()
        {
            int num;
            Console.WriteLine("Even Numbers");
            for (num = 1; num <= 11; num++)
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static void Code_Snippet_12()
        {
            int rows = 2;
            int columns = 2;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.WriteLine();
            }
        }

        public static void Code_Snippet_13()
        {
            Console.WriteLine("Square \t\tCube");
            for (int i = 1, j = 0; i < 11; i++, j++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write("{0} = {1} \t", i, (i * i));
                    Console.Write("{0} = {1} \n", j, (j * j * j));
                }
            }
        }

        public static void Code_Snippet_14()
        {
            int investment;
            int returns;
            int expenses;
            int profit;
            int counter = 0;
            for (investment = 1000, returns = 0; returns < investment;)
            {
                Console.WriteLine("Enter the monthly expenditure");
                expenses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the monthly profit");
                profit = Convert.ToInt32(Console.ReadLine());
                investment += expenses;
                returns += profit;
                counter++;
            }
            Console.WriteLine("Number of months to break even: " + counter);
        }

        public static void Code_Snippet_16()
        {
            char c;
            int numOne;
            int numTwo;
            int result;
            for (; ; )
            {
                Console.WriteLine("Enter number one");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number two");
                numTwo = Convert.ToInt32(Console.ReadLine());
                result = numOne + numTwo;
                Console.WriteLine("Result of Addition: " + result);
                Console.WriteLine("Do you wish to continue [Y / N]");
                c = Convert.ToChar(Console.ReadLine());
                if (c == 'Y' || c == 'y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        public static void Code_Snippet_17()
        {
            int fact = 1;
            int num, i;
            Console.WriteLine("Enter the number whose factorial you wish to calculate");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; fact *= i++) ;
            Console.WriteLine("Factorial: " +fact);
        }

        public static void Code_Snippet_18()
        {
            string[] employeeNames = { "Maria", "Wilson", "Elton", "Garry" };
            Console.WriteLine("Employee Names");
            foreach (string names in employeeNames)
            {
                Console.WriteLine("{0}", names);
            }
        }

        public static void Code_Snippet_19()
        {
            int numOne = 17;
            int numTwo = 2;
            while (numTwo <= numOne - 1)
            {
                if (numOne % numTwo == 0)
                {
                    Console.WriteLine("Not a Prime Number");
                    break;
                }
                numTwo++;
            }
            if (numTwo == numOne)
            {
                Console.WriteLine("Prime Number");
            }
        }

        public static void Code_Snippet_20()
        {
            Console.WriteLine("Even numbers in the range of 1 - 10");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }

        public static void Code_Snippet_21()
        {
            int i = 0;
            display:
            Console.WriteLine("Hello World");
            i++;
            if (i < 5)
            {
                goto display;
            }
        }

        public static void Code_Snippet_22()
        {
            byte num = 0;
            while (true)
            {
                byte fact = 1;
                Console.Write("Please enter a number: ");
                num = Convert.ToByte(Console.ReadLine());
                if (num < 0)
                {
                    goto stop;
                }
                for (byte j = num; j > 0; j--)
                {
                    if (j > 4)
                    {
                        goto stop;
                    }
                    fact *= j;
                }
                Console.WriteLine("Factorial of {0} is {1}", num, fact);
            }
            stop:
            Console.WriteLine("Exiting the program");
        }

        public static void Code_Snippet_24()
        {
            int yrsOfService = 5;
            double salary = 1250;
            double bonus = 0;
            if (yrsOfService <= 5)
            {
                bonus = 50;
                return;
            }
            else
            {
                bonus = salary * 0.2;
            }
            Console.WriteLine("Salary amount: " + salary);
            Console.WriteLine("Bonus amount: " + bonus);
        }
    }
}   
