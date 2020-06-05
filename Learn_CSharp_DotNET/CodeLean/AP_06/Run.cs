using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.CodeLean.AP_06
{
    class Run
    {
        public static void Test()
        {

        }

        // Defining Class Members
        public class DrinksMachine
        {
            // The following statements define a property with a private field.
            private string _location;
            public string Location
            {
                get
                {
                    return _location;
                }
                set
                {
                    if (value != null)
                        _location = value;
                }
            }
            // The following statements define properties.
            public string Make { get; set; }
            public string Model { get; set; }
            // The following statements define methods.
            public void MakeCappuccino()
            {
                // Method logic goes here.
            }
            public void MakeEspresso()
            {
                // Method logic goes here.
            }
            // The following statement defines an event. The delegate definition is not shown.
            //public event OutOfBeansHandler OutOfBeans;
        }

        //vi du 2
        public partial class DrinksMachine_02
        {

            public void MakeCappuccino()
            {
                // Method logic goes here.
            }
        }

        public partial class DrinksMachine_02
        {

            public void MakeEspresso()
            {
                // Method logic goes here.
            }
        }

        //vi du 3
        /* DrinksMachine dm = new DrinksMachine();
        var dm = new DrinksMachine();
        var dm = new DrinksMachine();
        dm.Make = "Fourth Coffee";
        dm.Model = "Beancrusher 3000";
        dm.Age = 2;
        dm.MakeEspresso(); */


        //vi su 4
        public class DrinksMachine_04
        {
            // private member variables
            private int age;
            private string make;


            // public properties
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
            public string Make
            {
                get
                {
                    return make;
                }
                set
                {
                    make = value;
                }
            }

            // auto-implemented property
            public string Model { get; set; }

            // Constructors
            public DrinksMachine_04(int age)
            {
                this.Age = age;
            }
            public DrinksMachine_04(string make, string model)
            {
                this.Make = make;
                this.Model = model;
            }
            public DrinksMachine_04(int age, string make, string model)
            {
                this.Age = age;
                this.Make = make;
                this.Model = model;
            }
        }

        //vi du 5
        // Adding a Constructor
        public class DrinksMachine_05
        {
            public int Age { get; set; }
            public DrinksMachine_05()
            {
                Age = 0;
            }
        }

        //vi du 6
        public class DrinksMachine_06
        {
            public int Age { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public DrinksMachine_06(int age)
            {
                this.Age = age;
            }
            public DrinksMachine_06(string make, string model)
            {
                this.Make = make;
                this.Model = model;
            }
            public DrinksMachine_06(int age, string make, string model)
            {
                this.Age = age;
                this.Make = make;
                this.Model = model;
            }
        }
    }
}
