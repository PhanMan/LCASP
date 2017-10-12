using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{
    public class ScoreComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            return Comparer<T>.Default.Compare(y, x);
        }
    }
}
