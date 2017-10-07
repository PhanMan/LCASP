﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{
    public class Archer
    {
        public Archer()
        { }

        public Archer(int s_id, int a_id, string a_name, char a_sex)
        {
            SchoolID = s_id;
            ArcherID = a_id;
            ArcherName = a_name;
            ArcherSex = a_sex;
        }

        public int SchoolID { get; set; }
        public int ArcherID { get; set; }
        public string ArcherName { get; set; }
        public char ArcherSex { get; set; }
    }
}
