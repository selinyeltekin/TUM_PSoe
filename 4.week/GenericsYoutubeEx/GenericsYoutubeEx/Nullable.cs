using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsYoutubeEx
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()         //default constructor
        {

        }
        public Nullable(T value)  //Constructor
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }
        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}
