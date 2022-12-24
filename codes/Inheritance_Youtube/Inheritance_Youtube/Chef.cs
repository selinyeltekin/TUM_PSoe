using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Youtube
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken. ");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad.");
        }
        public virtual void MakeSpecialDish()  //virtual means this method can be over readen ın any sub classes

        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
