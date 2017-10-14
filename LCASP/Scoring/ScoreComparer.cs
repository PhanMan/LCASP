using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class ScoreComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            int retVal = Comparer<T>.Default.Compare(y, x);

            if (retVal == 0)
                return 1;   // Handle equality as beeing greater
            else
                return retVal;
        }
    }
}
