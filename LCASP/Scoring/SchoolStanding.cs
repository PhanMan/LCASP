﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class SchoolStanding
    {
        public int School_ID { get; set; }
        public string School_Name { get; set; }
        public SortedList<int, int> Overall { get; set; }
        public SortedList<int, int> Male { get; set; }
        public SortedList<int, int> Female { get; set; }
        public SortedList<int, int> TeamWide { get; set; }
        public int TeamMatchScore
        {
            get
            {
                int result = 0;

                for(int count=0; count<4; count++)
                {
                    result += Male.Keys[count];
                    result += Female.Keys[count];
                    result += Overall.Keys[count];
                }

                return result;
            }
        }


        public SchoolStanding(int s_id, string school_name)
        {
            School_ID = s_id;

            Overall = new SortedList<int, int>(new ScoreComparer<int>());
            Male = new SortedList<int, int>(new ScoreComparer<int>());
            Female = new SortedList<int, int>(new ScoreComparer<int>());
            TeamWide = new SortedList<int, int>(new ScoreComparer<int>());
        }
    }
}
