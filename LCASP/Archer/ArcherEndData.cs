using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{
    public class ArcherEndData
    {
        public ArcherEndData(int s1, int s2, int s3, int s4, int s5)
        {
            ShotOne = s1;
            ShotTwo = s2;
            ShotThree = s3;
            ShotFour = s4;
            ShotFive = s5;
        }

        public int ShotOne { get; set; }
        public int ShotTwo { get; set; }
        public int ShotThree { get; set; }
        public int ShotFour { get; set; }
        public int ShotFive { get; set; }

        public int Score()
        {
            return ShotOne + ShotTwo + ShotThree + ShotFour + ShotFive;
        }
    }
}
