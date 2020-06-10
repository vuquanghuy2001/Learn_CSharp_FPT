//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.Book.Session_7
//{
//    class CodeSnippet_11
//    {
//        public virtual void Print()
//        {
//            Console.WriteLine("The system should be handled carefully");
//        }
//    }
//    class CompanySystem : CodeSnippet_11
//    {
//        public sealed override void Print()
//        {
//            Console.WriteLine("The system information is confidential");
//            Console.WriteLine("This information should not be overridden");
//        }
//    }
//    class SealesSystem : CompanySystem
//    {
//        public override void Print()
//        {
//            Console.WriteLine("This statement won't get excuted");
//        }
//        static void Main(string[] args)
//        {
//            SealesSystem sealesSystem = new SealesSystem();
//            sealesSystem.Print();
//        }
//    }
//}
