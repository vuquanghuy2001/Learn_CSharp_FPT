using Learn_CSharp_DotNET.Book.Session_9;
using System;
using System.Threading;

namespace Learn_CSharp_DotNET.Book.Session_11
{
    class Run
    {
        public static void Test()
        {
            //CS1
            //try
            //{
            //    float numOne = 3.14F;
            //    Object obj = numOne;
            //    int result = (int)obj;
            //    Console.WriteLine("Value of numOne={0}",result);
            //}
            //catch(InvalidCastException objEx)
            //{
            //    Console.WriteLine("Message: {0}",objEx.Message);
            //    Console.WriteLine("Error: {0}",objEx);
            //}
            //catch(Exception objEx)
            //{
            //    Console.WriteLine("Error: {0}",objEx);
            //}

            //CS2
            //string[] names = { "james", "jack", "Peter" };
            //int[] id = { 10, 11, 12 };
            //double[] salary = { 1000, 2000, 3000 };
            //float[] bonus = new float[3];
            //try
            //{
            //    salary.CopyTo(bonus, 0);
            //}
            //catch(ArrayTypeMismatchException objType)
            //{
            //    Console.WriteLine("Error: "+objType);
            //}
            //catch(Exception objEx)
            //{
            //    Console.WriteLine("Error: "+objEx);
            //}

            //CS3
            //Employee objEmployee = new Employee();
            //Employee objEmp = objEmployee;
            //objEmployee = null;
            //try
            //{
            //    Console.WriteLine("Employee Name: " +objEmployee._empName);
            //    Console.WriteLine("Employee ID: " +objEmployee._empID);
            //}
            //catch (NullReferenceException objNull)
            //{
            //    Console.WriteLine("Error: " +objNull);
            //}
            //catch (Exception objEx)
            //{
            //    Console.WriteLine("Error: " +objEx);
            //}

            //CS4
            //byte numOne = 200;
            //byte numTow = 5;
            //byte result = 0;
            //try
            //{
            //    result = checked((byte)(numOne * numTow));
            //    Console.WriteLine("Result={0}",result);
            //}
            //catch(Exception objEx)
            //{
            //    Console.WriteLine("Error Description: { 0}", objEx.ToString());
            //    Console.WriteLine("Exception: { 0}", objEx.GetType());
            //}

            //CS5
            //byte numOne = 200;
            //byte numTow = 5;
            //byte result = 0;
            //try
            //{
            //    result = checked((byte)(numOne * numTow));
            //    System.Console.WriteLine("Result={0}",result);
            //}
            //catch(OverflowException objEx)
            //{
            //    Console.WriteLine("Message:{0}",objEx.Message);
            //    Console.WriteLine("Source:{0}",objEx.Source);
            //    Console.WriteLine("TargetSite:{0}",objEx.TargetSite);
            //    Console.WriteLine("StackTrace:{0}",objEx.StackTrace);
            //}
            //catch (Exception objEx)
            //{
            //    Console.WriteLine("Error:{0}",objEx);
            //}

            //CS6
            //int numOne = 133;
            //int numTow = 0;
            //int result;
            //try
            //{
            //    result = numOne / numTow;
            //}
            //catch(DivideByZeroException objDivide)
            //{
            //    Console.WriteLine("Exception caught: "+objDivide);
            //}

            //CS7
            //Students2 objStuent = new Students2();
            //try
            //{
            //    objStuent._name[4] = "Michael";
            //}
            //catch (Exception objException)
            //{
            //    Console.WriteLine("Error: " + objException);
            //}

            //CS8
            //Console.WriteLine("ThrowExample");
            //try
            //{
            //    string empName = null;
            //    ThrowException(empName);
            //}
            //catch(ArgumentNullException objNull)
            //{
            //    Console.WriteLine("Exception caught: "objNull);
            //}

            //CS9
            //int numOne = 133;
            //int numTow = 0;
            //int result;
            //try
            //{
            //    result = numOne / numTow;
            //}
            //catch(DivideByZeroException objDivide)
            //{
            //    Console.WriteLine("Exception caught: "+objDivide);
            //}
            //finally
            //{
            //    Console.WriteLine("This finally block will alway be excuted");
            //}

            //CS10
            //NumberTester objtester = new NumberTester();
            //objtester.AcceptDetails();

            //CS11
            //Product objGoods = new Product();
            //objGoods.AcceptDetails();
            //objGoods.Display();

            //CS12
            //string[] names = { "John", "James" };
            //int numOne = 0;
            //int result;
            //try
            //{
            //    Console.WriteLine("This is the outer try block");
            //    try
            //    {
            //        result = 133 / numOne;
            //    }
            //    catch(ArithmeticException objMaths)
            //    {
            //        Console.WriteLine("Divideby 0"+objMaths);
            //    }
            //    names[2] = "Smith";
            //}
            //catch(IndexOutOfRangeException objIndex)
            //{
            //    Console.WriteLine("Wrong number of arguments supplied"+objIndex);
            //}

            //CS13
            //    string [] names = {"John","James"}
            //    int numOne = 10;
            //    int result = 0;
            //    int index = 0;
            //    try
            //    {
            //        index = 3;
            //        names[index] = "Smilth";
            //        result = 130 / numOne;
            //    }
            //    catch(DivideByZeroException objDivide)
            //    {
            //        Console.WriteLine("Divide by 0"+objDivide);
            //    }
            //    catch(IndexOutOfRangeException objIndex)
            //    {
            //        Console.WriteLine("Wrong number of arguments supplied"+objIndex);
            //    }
            //    catch(Exception objException)
            //    {
            //        Console.WriteLine("Error: "+objException);
            //    }
            //    Console.WriteLine(result);

            //CS14
            //try
            //{
            //    TypeInitError objType = new TypeInitError();
            //}
            //catch(TypeInitializationException objEx)
            //{
            //    Console.WriteLine("Error: {0}",objEx);
            //}
            //catch(Exception objEx)
            //{
            //    Console.WriteLine("Error: {0}",objEx);
            //}

            //CS15
            //try
            //{
            //    throw new CustomMessage("This illustrates creation and catching of custom exception");
            //}
            //catch(CustomMessage objCustom)
            //{
            //    Console.WriteLine(objCustom.Message);
            //}
        }
    }
}
