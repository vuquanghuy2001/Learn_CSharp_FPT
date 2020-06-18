using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_10
{
    namespace Students
    {
        class StudentDetail
        {
            string _studName = "Alexander";
            int _studId = 30;
            public StudentDetail()
            {
                Console.WriteLine("Student Name: " + _studName);
                Console.WriteLine("Student ID: " + _studId);
            }
        }
    }
    namespace Examination
    {
        class ScoreReport2
        {
            public string Subject = "Science";
            public int Marks = 60;
        }
    }
}
