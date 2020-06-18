using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_10
{
    namespace Students
    {
        class StudentDetails
        {
            string _studName="Alexander";
            int _studID = 30;
            public StudentDetails()
            {
                Console.WriteLine("Student Name: "+_studName);
                Console.WriteLine("Student ID: "+_studID);
            }
        }
    }
    namespace Examination
    {
        class ScoreReport
        {
            public string Subject = "Science";
            public int Mark = 60;
        }
    }
}
