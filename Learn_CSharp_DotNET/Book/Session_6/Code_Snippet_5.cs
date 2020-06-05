using System;

namespace Learn_CSharp_DotNET.Book.Session_6
{
    class Code_Snippet_5
    {
        void printMessage(String message = "Hello user!")
        {
            Console.WriteLine("{0}", message);
        }
        static void Main(string[] args)
        {
            Code_Snippet_5 opExample = new Code_Snippet_5();
            opExample.printMessage("Welcome User!");
            opExample.printMessage();
        }
    }
}
