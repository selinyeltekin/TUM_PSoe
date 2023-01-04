using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Youtube
{
    class ItalianChef : Chef //Inheriting - miras vermek gibi
    {
        public override void MakeSpecialDish()  //override means override the method from super class but we wıll change inside
        {
            Console.WriteLine("The Chef makes chicken parmesan.");
        }
        public void MakePasta()
        {
            Console.Write("The Chef makes pasta.");
        }
    }
}
