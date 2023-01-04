using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //can do everything that normal chef does
    //SubClass
    internal class ItalianChef : Chef   //is gonna inherit all the functionality from the chef class
    {
        public void MakePasta()
        {
            Console.WriteLine("the chef makes pasta.");
        }

        //virtual keyword ünü override olarakd eğişitk
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm.");
        }
    }
}
