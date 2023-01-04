using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods_Classes
{
    //internal class than static class a çevirdik Math çalışıp çalışmadığını görmek için
    static class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
