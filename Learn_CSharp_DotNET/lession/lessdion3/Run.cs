using Learn_CSharp_DotNET.lession.lessdion3.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.lession.lessdion3.Students
{
    class Run
    {
        public static void Test()
        {
            //Students objStudents = new Students();
            //objStudents.Display();

            //Book objBook = new Book();
            //objBook.Input("C#-The Complete Reference");
            //Console.WriteLine(objBook.Print());

            //Student_2 student_2 = new Student_2();
            //student_2.printName("henry", "parker");
            //student_2.printName(firstName: "Henry", lastName: "parker");
            //student_2.printName(lastName: "parker", firstName: "henry");
            //student_2.printName("Henry", lastName: "parker");

            //Option option = new Option();
            //option.printMessage("Welcome User!");
            //option.printMessage();

            //static không cần gọi qua đối tượng
            Product.Display();
        }
    }
}
