using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{


    public class ArcherData
    {
        private static int EndOffset = 10;

        private ArcherEndData ProcessEndSection(int end_no)
        {
            int[] sData = { 0, 0, 0, 0, 0 };

            string[] items = archer_raw_data.Split(',');

            int itemOffset = EndOffset + (end_no-1) * 5;

            for(int count=0; count<5; count++)
            {
                sData[count] = Convert.ToInt32(items[itemOffset + count]);
            }

            ArcherEndData retData = new ArcherEndData(sData[0], sData[1], sData[2], sData[3], sData[4]);

            return retData;
        }

        private void ProcessScoreData()
        {
            string[] dataItems = archer_raw_data.Split(',');

            string[] scoreItems = dataItems[8].Split(' ');

            archer_id = Convert.ToInt32(dataItems[0]);
            archer_score = Convert.ToInt32(dataItems[1]);

            archer_tens = Convert.ToInt32(scoreItems[11]);
            archer_nines = Convert.ToInt32(scoreItems[10]);
            archer_eights = Convert.ToInt32(scoreItems[9]);
            archer_sevens = Convert.ToInt32(scoreItems[8]);
            archer_sixes = Convert.ToInt32(scoreItems[7]);
            archer_fives = Convert.ToInt32(scoreItems[6]);
            archer_fours = Convert.ToInt32(scoreItems[5]);
            archer_threes = Convert.ToInt32(scoreItems[4]);
            archer_twos = Convert.ToInt32(scoreItems[3]);
            archer_ones = Convert.ToInt32(scoreItems[2]);
            archer_zeros = Convert.ToInt32(scoreItems[1]);

            EndOne = ProcessEndSection(1);
            EndTwo = ProcessEndSection(2);
            EndThree = ProcessEndSection(3);
            EndFour = ProcessEndSection(4);
            EndFive = ProcessEndSection(5);
            EndSix = ProcessEndSection(6);
        }

        public ArcherData(string inData)
        {
            archer_raw_data = inData;

            ProcessScoreData();
        }

        public int archer_data_id { get; set; }
        public int archer_id { get; set; }

        // Received Data from scanner
        public string archer_raw_data { get; set; }
        public int archer_score { get; set; }
        public int archer_tens { get; set; }
        public int archer_nines { get; set; }
        public int archer_eights { get; set; }
        public int archer_sevens { get; set; }
        public int archer_sixes { get; set; }
        public int archer_fives { get; set; }
        public int archer_fours { get; set; }
        public int archer_threes { get; set; }
        public int archer_twos { get; set; }
        public int archer_ones { get; set; }
        public int archer_zeros { get; set; }

        // Derived data
        public ArcherEndData EndOne { get; set; }
        public ArcherEndData EndTwo { get; set; }
        public ArcherEndData EndThree { get; set; }
        public ArcherEndData EndFour { get; set; }
        public ArcherEndData EndFive { get; set; }
        public ArcherEndData EndSix { get; set; }

        public string GetSqlInsert()
        {
            string sql = "INSERT INTO archer_data " +
                        "(archer_id,archer_raw_data,archer_score,archer_tens,archer_nines,archer_eights,archer_sevens, " +
                         "archer_sixes,archer_fives,archer_fours,archer_threes,archer_twos,archer_ones,archer_zeros,archer_end_1,archer_end_2, " +
                         "archer_end_3,archer_end_4,archer_end_5,archer_end_6) " +
                         " VALUES " +
                         "(" + archer_id + ", '" + archer_raw_data + "', " + archer_score + ", " + archer_tens + ", " + archer_nines + ", " + archer_eights + ", " +
                          archer_sevens + ", " + archer_sixes + ", " + archer_fives + ", " + archer_fours + ", " + archer_threes + ", " + archer_twos + ", " +
                          archer_ones + ", " + archer_zeros + ", " + EndOne.Score() + ", " + EndTwo.Score() + ", " + EndThree.Score() + ", " +
                          EndFour.Score() + ", " + EndFive.Score() + ", " + EndSix.Score() + ")";
            return sql;
        }
    }
}
