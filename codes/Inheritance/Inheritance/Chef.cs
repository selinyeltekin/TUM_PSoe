using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Chef
    {
        //has 3 methods
        //SupereClass
        public void MakeChicken()
        {
            Console.WriteLine("the chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad.");
        }

        //virtual keyword, means this method can be overwritten in another class.
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
