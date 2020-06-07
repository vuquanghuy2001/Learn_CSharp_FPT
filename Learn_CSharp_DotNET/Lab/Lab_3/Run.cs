using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Lab.Lab_3
{
    class Run
    {
        public static void Test()
        {
            //Car myCar;
            //System.Console.WriteLine("Creating a Car object and assigning " + "ints memory location to myCar");
            //myCar = new Car();

            //myCar.make = "Toyota";
            //myCar.model = "MR2";
            //myCar.color = "black";
            //myCar.yearBuilt = 1995;

            //System.Console.WriteLine("MyCar detail: ");
            //System.Console.WriteLine("myCar.make= "+myCar.make);
            //System.Console.WriteLine("myCar.model= "+myCar.model);
            //System.Console.WriteLine("myCar.color= "+myCar.color);
            //System.Console.WriteLine("myCar.yearBulit= "+myCar.yearBuilt);

            //myCar.Start();
            //myCar.Stop();

            //System.Console.WriteLine("Creating another Car object and" + "assigning ist memory location to redPorsche");
            //Car redPorsche = new Car();
            //redPorsche.make = "Porsche";
            //redPorsche.model = "Boxster";
            //redPorsche.color = "red";
            //redPorsche.yearBuilt = 2000;

            //System.Console.WriteLine("redPorsche is a " + redPorsche.model);
            //System.Console.WriteLine("Assigning redPorsche to myCar");
            //myCar = redPorsche;
            //System.Console.WriteLine("myCar details: ");
            //System.Console.WriteLine("myCar.make = "+myCar.make);
            //System.Console.WriteLine("myCar.model = "+myCar.model);
            //System.Console.WriteLine("myCar.color = "+myCar.color);
            //System.Console.WriteLine("myCar.yearbuilt = "+myCar.yearBuilt);

            //myCar=null;
            //Console.ReadLine();



            //Window win = new Window(1, 2);
            //ListBox lb = new ListBox(3, 4, "Stand alone list box");
            //Button b = new Button(5, 6);
            //win.DrawWindow();
            //lb.DrawWindow();
            //b.DrawWindow();
            //Window[] winArray = new Window[3];
            //winArray[0] = new Window(1, 2);
            //winArray[1] = new ListBox(3, 4, "List box in array");
            //winArray[2] = new Button(5, 6);
            //for(int i = 0; i < 3; i++)
            //{
            //    winArray[i].DrawWindow();
            //}

            //BooleanAccept booleanAccept;
            //System.Console.WriteLine("Atomic Information");
            //System.Console.WriteLine("===================");
            //booleanAccept = new BooleanAccept();
            //booleanAccept.number = 3;
            //booleanAccept.symbol = "Li";
            //booleanAccept.name = "lithium";
            //booleanAccept.weight = 6.941;

            //System.Console.WriteLine("Enter atomic number: " + booleanAccept.number);
            //System.Console.WriteLine("Enter symbol: " + booleanAccept.symbol);
            //System.Console.WriteLine("Enter full name: " + booleanAccept.name);
            //System.Console.WriteLine("Enter atomic weight: " + booleanAccept.weight);

            //booleanAccept.number = 20;
            //booleanAccept.symbol = "Ca";
            //booleanAccept.name = "Calcium";
            //booleanAccept.weight = 40.078;

            //System.Console.WriteLine("Enter atomic number: " + booleanAccept.number);
            //System.Console.WriteLine("Enter symbol: " + booleanAccept.symbol);
            //System.Console.WriteLine("Enter full name: " + booleanAccept.name);
            //System.Console.WriteLine("Enter atomic weight: " + booleanAccept.weight);

            //booleanAccept.number = 30;
            //booleanAccept.symbol = "Zn";
            //booleanAccept.name = "zinc";
            //booleanAccept.weight = 65.409;

            //System.Console.WriteLine("Enter atomic number: " + booleanAccept.number);
            //System.Console.WriteLine("Enter symbol: " + booleanAccept.symbol);
            //System.Console.WriteLine("Enter full name: " + booleanAccept.name);
            //System.Console.WriteLine("Enter atomic weight: " + booleanAccept.weight);

            //booleanAccept.number = 0;
            //System.Console.WriteLine("No Sym Name Weight");
            //System.Console.WriteLine("--------------------------");
            //booleanAccept.Display();

            Employee employee = new Employee("Quang","Huy","Ha Noi",10,3.4);
            employee.toString();
            Console.WriteLine("Bonus = "+employee.Bonus());
        }
    }
}
