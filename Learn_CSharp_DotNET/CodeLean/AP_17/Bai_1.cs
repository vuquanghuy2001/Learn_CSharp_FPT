//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learn_CSharp_DotNET.CodeLean.AP_17
//{
//    namespace SampleApp
//    {
//        public delegate string MyDel(string str);
//        class Eventprogram
//        {
//            event MyDel MyEvent;
//            public Eventprogram()
//            {
//                this.MyEvent += new MyDel(this.WelcomeUser);
//            }
//            public string WelcomeUser(string username)
//            {
//                return "Wellcome " + username;
//            }
//            static void Main(string[] args)
//            {
//                Eventprogram obj1 = new Eventprogram();
//                string result = obj1.MyEvent("Tutorials Point");
//                Console.WriteLine(result);
//                Console.ReadKey();
//            }
//        }
//    }
//}
