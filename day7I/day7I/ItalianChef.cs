using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7I
{
    internal class ItalianChef : Chef
    {
        public void makePasta()
        {
            Console.WriteLine("The chef makes Pasta.");

        }
        public override void makeSpecialDish()
        {
            Console.WriteLine("The chef makes Chicken Parm.");

        }
    }
}
