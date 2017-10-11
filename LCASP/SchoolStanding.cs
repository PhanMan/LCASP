using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{
    public class SchoolStanding
    {
        public int school_id { get; set; }
        public SortedList<int, int> overall { get; set; }
        public SortedList<int, int> male { get; set; }
        public SortedList<int, int> female { get; set; }

        public SchoolStanding(int s_id)
        {
            school_id = s_id;

            overall = new SortedList<int, int>();
            male = new SortedList<int, int>();
            female = new SortedList<int, int>();
        }
    }
}
