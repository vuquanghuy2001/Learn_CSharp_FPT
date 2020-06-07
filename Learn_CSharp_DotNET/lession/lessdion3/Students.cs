using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.lession.lessdion3.Students
{
    class Students
    {
        String _StudentName = "Jame Anderson";
        int _studAge = 27;
        public void Display()
        {
            Console.WriteLine("Student Name: " + _StudentName);
            Console.WriteLine("Stdent Age: " + _studAge);
        }
    }
}
