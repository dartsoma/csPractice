using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7I
{
    internal class Chef
    {
        public void makeChicken()
        {
            Console.WriteLine("The chef makes Chicken.");

        }
        public void makeSalad()
        {
            Console.WriteLine("The chef makes Salad.");

        }
        public virtual void makeSpecialDish()
        {
            Console.WriteLine("The chef makes Bbq Ribs.");

        }


    }
}
