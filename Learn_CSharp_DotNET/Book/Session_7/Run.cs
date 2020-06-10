using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class Run
    {
        public static void Test()
        {
            //CS1
            //Dog objDog = new Dog();
            //objDog.Eat();
            //objDog.Feature();
            //objDog.Noise();

            //CS2
            //Run objectcat2= new Run();
            //objectcat2.Eat();
            //objectcat2.DoSomething();

            //CS3
            //Run run = new Run();
            //run.Food = "Mouse";
            //run.Activity = "laze around";
            //Console.WriteLine("The Cat loves to eat" + run.Food + ".");
            //Console.WriteLine("The Cat loves to" + run.Activity + ".");


            //Cat cat = new Cat();
            //cat.NoiceCat();

            //CS5
            //CodeSnippet_5 codeSnippet_5 = new CodeSnippet_5();
            //codeSnippet_5.Display();

            //CS6
            //Canine objCanine = new Canine();


            //CS7 code lai
            //CodeSnippet_7 objAutomobiles = new CodeSnippet_7("Chassies");


            //CS8
            //Cat3 cat3 = new Cat3();
            //Cat3.Eat();

            //CS9
            //CodeSnippet_9 codeSnippet_9 = new CodeSnippet_9();
            //Grade grade = new Grade();
            //codeSnippet_9.PrintDeails();
            //grade.PrintDeails();

            //CS10
            //CodeSnippet_10 codeSnippet_10 = new CodeSnippet_10();
            //codeSnippet_10.Quantity = 50;
            //codeSnippet_10.Cost = 75;
            //Console.WriteLine("Quantity of the Product: "+codeSnippet_10.Quantity);
            //Console.WriteLine("Cost of the product: "+codeSnippet_10.Cost);

            //CS12
            //int length = 10;
            //int breadth = 22;
            //double tbase = 2.5;
            //double theight = 1.5;
            //Console.WriteLine("Area of Rectangle: " + CalculateArea(length,
            //breadth));
            //Console.WriteLine("Area of triangle: " + CalculateArea(tbase, theight));

            //CS13
            CodeSnippet_13 objRunOne = new CodeSnippet_13();
            Console.WriteLine("Area is: "+ objRunOne.Area());
            CodeSnippet_13 objRunTow = new CodeSnippet_13();
            Console.WriteLine("Area is: "+objRunTow.Area());
        }
    }
}
