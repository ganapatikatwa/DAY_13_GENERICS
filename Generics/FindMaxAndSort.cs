using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaxAndSort
    {
        public int[] value;
        public FindMaxAndSort(int[] value)
        {
            this.value = value;
        }

        public int[] Sort(int[] values)
        {
            Array.Sort(values);
            return values;
        }

        public int MaxValues(params int[] values)
        {
            var Sorted_Values=Sort(values);
            return Sorted_Values[^1];
        }
        public int MaxMethod()
        {
            var max = MaxValues(this.value);
            return max;
        }
        public void PrintMaxvalue()
        {
            var max = MaxValues(this.value);
            Console.WriteLine("Maximum Value is:"+max);
        }
    }
}
