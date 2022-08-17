using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMax<T> where T : IComparable
    { public T First, Second, Third;
        public FindMax(T First, T Second, T Third)
        {
            this.First= First;
            this.Second = Second;
            this.Third = Third;

         }
        public T FindMaxInteger(T First, T Second, T Third)
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {

                return Third;
            }
            return default;
        }
        
    }
}