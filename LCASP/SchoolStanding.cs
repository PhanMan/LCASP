using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class SchoolStanding
    {
        public int school_id { get; set; }
        public string school_name { get; set; }
        public SortedList<int, int> overall { get; set; }
        public SortedList<int, int> male { get; set; }
        public SortedList<int, int> female { get; set; }
        public SortedList<int, int> teamWide { get; set; }

        public SchoolStanding(int s_id, string school_name)
        {
            school_id = s_id;

            overall = new SortedList<int, int>(new ScoreComparer<int>());
            male = new SortedList<int, int>(new ScoreComparer<int>());
            female = new SortedList<int, int>(new ScoreComparer<int>());
            teamWide = new SortedList<int, int>(new ScoreComparer<int>());

        }
    }
}
