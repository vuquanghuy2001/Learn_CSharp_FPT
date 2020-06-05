using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_5
{
    class Run
    {
        public static void Test()
        {
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
        }

        private static void Code_Snippet_4()
        {
            int[] count = new int[10];
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                count[i] = counter++;
                Console.WriteLine("The count value is: " + count[i]);
            }
        }

        private static void Code_Snippet_5()
        {
            string[] students = new string[3] { "James", "Alex", "Fernando" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }

        private static void Code_Snippet_6()
        {
            int[,] dimension = new int[4, 5];
            int numOne = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dimension[i, j] = numOne;
                    numOne++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(dimension[i, j] + " ");
                }
                Console.Write(dimension[i, i] + " ");
            }
            Console.WriteLine();
        }

        private static void Code_Snippet_7()
        {
            string[] days = new string[7];
            days[0] = "Sunday";
            days[1] = "Monday";
            days[2] = "Tuesday";
            days[3] = "Wednesday";
            days[4] = "Thursday";
            days[5] = "Friday";
            days[6] = "Saturday";
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }

        private static void Code_Snippet_8()
        {
            string[] classOne = { "Allan", "Chris", "Monica" };
            string[] classTwo = { "Katie", "Niel", "Mark" };
            Console.WriteLine("Students of Class I:\tStudents of Class II");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);
            }
            classTwo = classOne;
            Console.WriteLine("\nStudents of Class II after referencing Class I:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classTwo[i] + " ");
            }
            Console.WriteLine();
            classTwo[2] = "Mike";
            Console.WriteLine("Students of Class I after changing the third student in Class II:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + " ");
            }
        }

        private static void Code_Snippet_9()
        {
            Console.Write("Enter the number of Students: ");
            int noOfStds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Exams: ");
            int exams = Convert.ToInt32(Console.ReadLine());
            string[] stdName = new string[noOfStds];
            string[,] details = new string[noOfStds, exams];
            for (int i = 0; i < noOfStds; i++)
            {
                Console.WriteLine();
                Console.Write("Enter the Student Name: ");
                stdName[i] = Convert.ToString(Console.ReadLine());
                for (int y = 0; y < exams; y++)
                {
                    Console.Write("Enter Score in Exam " + (y + 1) + ": ");
                    details[i, y] = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Student Exam Details");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("Student\t\tMarks");
            Console.WriteLine("-----\t\t------ -");
            for (int i = 0; i < stdName.Length; i++)
            {
                Console.WriteLine(stdName[i]);
                for (int j = 0; j < exams; j++)
                {
                    Console.WriteLine("\t\t" + details[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void Code_Snippet_10()
        {
            string[][] companies = new string[3][];
            companies[0] = new string[] { "Intel", "AMD" };
            companies[1] = new string[] { "IBM", "Microsoft", "Sun" };
            companies[2] = new string[] { "HP", "Canon", "Lexmark", "Epson" };
            for (int i = 0; i < companies.GetLength(0); i++)
            {
                Console.Write("List of companies in group " + (i + 1) + ":\t");
                for (int j = 0; j < companies[i].GetLength(0); j++)
                {
                    Console.Write(companies[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Code_Snippet_11()
        {
            string[] studentNames = new string[3] { "Ashley", "Joe", "Mikel"};
            foreach (string studName in studentNames)
            {
                Console.WriteLine("Congratulations!! " +studName + " you have been granted an extra leave");
            }
        }

        private static void Code_Snippet_12()
        {
            Array objArray = Array.CreateInstance(typeof(string), 5);
            objArray.SetValue("Marketing", 0);
            objArray.SetValue("Finance", 1);
            objArray.SetValue("Human Resources", 2);
            objArray.SetValue("Information Technology", 3);
            objArray.SetValue("Business Administration", 4);
            for (int i = 0; i <= objArray.GetUpperBound(0); i++)
            {
                Console.WriteLine(objArray.GetValue(i));
            }
        }

        private static void Code_Snippet_13()
        {
            Array objEmployeeDetails = Array.CreateInstance(typeof(string), 2, 3);
            objEmployeeDetails.SetValue("141", 0, 0);
            objEmployeeDetails.SetValue("147", 0, 1);
            objEmployeeDetails.SetValue("154", 0, 2);
            objEmployeeDetails.SetValue("Joan Fuller", 1, 0);
            objEmployeeDetails.SetValue("Barbara Boxen", 1, 1);
            objEmployeeDetails.SetValue("Paul Smith", 1, 2);
            Console.WriteLine("Rank: " +objEmployeeDetails.Rank);
            Console.WriteLine("Employee ID \tName");
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(objEmployeeDetails.GetValue(i, j) + "\t\t");
                    Console.WriteLine(objEmployeeDetails.GetValue(i + 1, j));
                }
            }
        }
    }
}
