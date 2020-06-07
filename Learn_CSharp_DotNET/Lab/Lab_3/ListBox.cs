using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Lab.Lab_3
{
    class ListBox:Window
    {
        private string ListBoxContents;
        public ListBox(int top,int left,string contents) : base(top, left)
        {
            ListBoxContents = contents;
        }
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox:{0}",ListBoxContents);
        }
    }
}
