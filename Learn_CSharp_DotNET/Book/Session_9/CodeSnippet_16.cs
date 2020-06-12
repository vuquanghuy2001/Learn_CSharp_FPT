using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_9
{
    public interface IDetails
    {
        string this[int index]
        {
            get;
            set;
        }
    }
    class Students : IDetails
    {
        string[] studentName = new string[3];
        int[] studentID = new int[3];
        public string this[int index]
        {
            get
            {
                return studentName[index];
            }
            set
            {
                studentName[index] = value;
            }
        }
    }
}
