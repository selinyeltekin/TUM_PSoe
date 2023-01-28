using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsYoutubeEx
{
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();           //It doesnt work because the compiler doesnt know exactly it is referin to.  So we created `new()` next to IComparable.
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
            // return a > b ? a : b;              gives error because the compailor doesnt know the type of T so it can not apply comparison between a and b
        }

    }
}
