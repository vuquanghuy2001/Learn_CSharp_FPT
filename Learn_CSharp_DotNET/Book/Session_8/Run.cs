using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_8
{
    class Run
    {
        public static void Test()
        {
            //CS2
            //Lion objLion = new Lion();
            //objLion.AnimalSound();
            //objLion.Eat();

            //CS5
            //Dog objDog = new Dog();
            //Console.WriteLine(objDog.GetType().Name);
            //objDog.Habitat();

            //CS6
            //Crocodile objcrocodile = new Crocodile();
            //objcrocodile.Eat();
            //objcrocodile.Swim();

            //CS7
            //Crocodile2 crocodile2 = new Crocodile2();
            //string terCroc = crocodile2.EatTerrestrial();
            //Console.WriteLine(terCroc);
            //string marCroc = crocodile2.EatMarine();
            //Console.WriteLine(marCroc);

            //CS8
            //Crocodile3 crocodile3 = new Crocodile3();
            //Console.WriteLine(crocodile3.GetType().Name);
            //crocodile3.Habitat();
            //crocodile3.Eat();
            //crocodile3.Drink();

            //CS9
            //Sphere objSphere = new Sphere();
            //objSphere.Radius = 7;
            //objSphere.Area();
            //Console.WriteLine("Area of Sphere: { 0:F2}" ,objSphere._areaOfSphere);

            //CS10 
            //Rectangle rectangle = new Rectangle(10.2F,20.3F);
            //if(rectangle is ICalculate)
            //{
            //    Console.WriteLine("Area of rectangle: {0:F2}",rectangle.Area());
            //}
            //else
            //{
            //    Console.WriteLine("Interface method not implemented");
            //}

            //CS11
            Employee employee = new Employee();
            employee.AcceptDetails(10, "Jack");
            IGet objGet = employee as IGet;
            if (objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Incalid casting occurred");
            }
        }
    } 
}
