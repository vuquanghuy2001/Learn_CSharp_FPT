using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Reseach.OOP
{
    class Run
    {
        public static void Test()
        {
            Teacher teacher = new Teacher("Kim Thi",35,89328532,"Ha Noi");
            Student student = new Student("Huy", 19, 9823294, "Ha Noi");

            teacher.display();
            student.display();
            teacher.gotoschool();
        } 
    }
}
