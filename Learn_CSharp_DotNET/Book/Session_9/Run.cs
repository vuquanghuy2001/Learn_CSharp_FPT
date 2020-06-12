using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    class Run
    {
        public static void Test()
        {
            //CS1
            //CodeSnippet_1 codeSnippet_1 = new CodeSnippet_1();
            //codeSnippet_1.EmployeeName = "Patrick Johnson";
            //Console.WriteLine("Employee Name: "+codeSnippet_1.EmployeeName);

            //CS2
            //Books objBook = new Books("Learn C# in 21 Days", 10015);
            //Console.WriteLine("Book Name: "+objBook.BookName);
            //Console.WriteLine("Book ID: "+objBook.BookID);

            //CS3
            //CodeSnippet_3 objDepartment = new CodeSnippet_3();
            //objDepartment.DeptID = 201;
            //objDepartment.DeptName = "Sales";
            //objDepartment.Display();

            //CS4
            //Product objProduct = new Product("Hard Disk",101);
            //objProduct.Price = 345.25F;
            //objProduct.Display();

            //CS5
            //University.UniversityName = "univercity of Maryland";
            //University.Department = "Physics";
            //Console.WriteLine("Univercity Name: "+University.UniversityName);
            //Console.WriteLine("Depratment name: "+University.Department);

            //CS6
            //Rectangle objRetangle = new Rectangle();
            //objRetangle.DimensionOne = 20;
            //objRetangle.DimensionTwo = 4.233F;
            //Console.WriteLine("Area of Rectangle: "+objRetangle.Area());

            //CS7
            //SalaryDetail objSalaryDetail = new SalaryDetail();
            //objSalaryDetail.EmpName = "Frank";
            //objSalaryDetail.EmpID = 10;
            //objSalaryDetail.Salary = 1000.25F;
            //Console.WriteLine("Name: " + objSalaryDetail.EmpName);
            //Console.WriteLine("ID: " + objSalaryDetail.EmpID);
            //Console.WriteLine("Salary: " + objSalaryDetail.Salary + "$");

            //CS8
            //Employee2 employee2 = new Employee2();
            //employee2.Name = "John Doe";
            //employee2.Age = 24;
            //employee2.Designation = "Sales Person";
            //Console.WriteLine("Name:{0},Age:{1},Designation:{2}",employee2.Name,employee2.Age,employee2.Designation);

            //CS9
            //Employee emp1 = new Employee
            //{
            //    Name = "John Doe",
            //    Age = 24,
            //    Designation = "Sales Person"
            //};
            //Console.WriteLine("Name: {0}, Age:{1}, Designation: {2}",emp1.Name,emp1.Age,emp1.Designation);

            //CS10
            //Car objCar = new Car();
            //objCar.CarType = "Utility Vehicle";
            //Ferrari objFerrari = new Ferrari();
            //objFerrari.CarType = "Sports Car";
            //Console.WriteLine("Car Type: "+objCar.CarType);
            //Console.WriteLine("Ferrari Car Type: " + objFerrari.CarType);

            //CS12
            //EmployeeDetails objEmp = new EmployeeDetails();
            //objEmp[0] = "Jack Anderson";
            //objEmp[1] = "Kate Jones";
            //Console.WriteLine("Employee Names: ");
            //for(int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(objEmp[i]+"\t");
            //}

            //cs13
            //EvemNumbers objEven = new EvemNumbers();
            //objEven[0] = 0;
            //objEven[1] = 2;
            //objEven[2] = 4;
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(objEven[i]);
            //}

            ////CS14
            //Result objResult = new Result();
            //objResult[0] = "First";
            //objResult[1] = "Pass";
            //Student objStudent = new Student();
            //objStudent[0] = "Peter";
            //objStudent[1] = "Patrick";
            //for(int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(objStudent[i]+"\t\t"+objResult[i]+"class");
            //}

            //CS15
            //Account objAccount = new Account();
            //string[] id = new string[3] { "1001", "1002", "1003" };
            //string[] name = new string[3] { "John", "Peter", "Patrick" };
            //int counter = 0;
            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; i < 1; j++)
            //    {
            //        objAccount[i, j] = id[counter];
            //        objAccount[i, j + 1] = name[counter++];
            //    }
            //}
            //Console.WriteLine("ID Name");
            //Console.WriteLine();
            //for(int i = 0; i < 4; i++)
            //{
            //    for(int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(objAccount[i,j]+"");
            //    }
            //    Console.WriteLine();
            //}

            //CS16
            Student objStudent = new Student();
            objStudent[0] = "James";
            objStudent[1] = "Wilson";
            objStudent[2] = "Patrick";
            Console.WriteLine("Student Names");
            Console.WriteLine();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(objStudent[i]);
            }
        }
    }
}
