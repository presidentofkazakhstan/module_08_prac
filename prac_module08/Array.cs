using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_module08
{
    public class Array
    {
        private int[] _array;
        public int Size { get; set; }
        public Array()
        {
            Size = 1;
            _array = new int[Size];
        }

        public Array(int size)
        {
            Size = size;
            _array = new int[Size];
        }
        public int this[int i]
        {
            get
            {
                return _array[i];
            }
            set
            {
                _array[i] = Convert.ToInt32(value * value);
            }
        }
    }
}
