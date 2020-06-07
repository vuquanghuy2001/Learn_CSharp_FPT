using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Lab.Lab_3
{
    class Window
    {
        protected int top;
        protected int left;
        public Window(int top,int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing window at {0},{1}",top,left);
        }
    }
}
