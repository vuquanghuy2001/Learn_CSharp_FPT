//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_13
//{
//    class Genetal<T,U>
//    {
//        T _valOne;
//        U _valTow;
//        public void AcceptValues(T item)
//        {
//            _valOne = item;
//        }
//        public void AcceptValues(U item)
//        {
//            _valTow = item;
//        }
//        public void Display()
//        {
//            Console.WriteLine(_valOne+"\t"+_valTow);
//        }
//    }
//    class MethodOverload
//    {
//        static void Main(string[] args)
//        {
//            Genetal<int, string> objGenOne = new Genetal<int, string>();
//            objGenOne.AcceptValues(10);
//            objGenOne.AcceptValues("Smith");
//            Console.WriteLine("ID\tName\tDesignatipn\tSalary");
//            objGenOne.Display();
//            Genetal<string, float> objFenTow = new Genetal<string, float>();
//            objFenTow.AcceptValues("Mechanic");
//            objFenTow.AcceptValues(2500);
//            Console.WriteLine("\t");
//            objFenTow.Display();
//            Console.WriteLine();
//            Console.ReadKey();
//        }
//    }
//}
