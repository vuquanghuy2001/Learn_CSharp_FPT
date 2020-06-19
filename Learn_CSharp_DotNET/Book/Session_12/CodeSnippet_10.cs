//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_12
//{
//    class Student : IEnumerable
//    {
//        LinkedList<string> objList = new LinkedList<string>();
//        public void StudentDetails()
//        {
//            objList.AddFirst("james");
//            objList.AddFirst("John");
//            objList.AddFirst("Patrick");
//            objList.AddFirst("Peter");
//            objList.AddFirst("James");
//            Console.WriteLine("Number of element stored in the list: " + objList.Count);
//        }
//        public void Display(string name)
//        {
//            LinkedListNode<string> objNode;
//            int count = 0;
//            for (objNode = objList.First; objNode != null; objNode =
//            objNode.Next)
//            {
//                if (objNode.Value.Equals(name))
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine("The value " + name + " appears " + count + " times in the list");
//        }
//        public IEnumerator GetEnumerator()
//        {
//            return objList.GetEnumerator();
//        }
//        static void Main(string[] args)
//        {
//            Student objStudent = new Student();
//            objStudent.StudentDetails();
//            foreach (string str in objStudent)
//            {
//                Console.WriteLine(str);
//            }
//            objStudent.Display("James");
//            objStudent.Display("John");
//            Console.ReadKey();
//        }
//    }
//}
