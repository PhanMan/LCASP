using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class ArcherData
    {
        private static int EndOffset = 10;

        private ArcherEndData ProcessEndSection(int end_no)
        {
            int[] sData = { 0, 0, 0, 0, 0 };

            string[] items = ArcherRawData.Split(',');

            int itemOffset = EndOffset + (end_no - 1) * 5;

            for (int count = 0; count < 5; count++)
            {
                sData[count] = Convert.ToInt32(items[itemOffset + count]);
            }

            ArcherEndData retData = new ArcherEndData(sData[0], sData[1], sData[2], sData[3], sData[4]);

            return retData;
        }

        private void ProcessScoreData()
        {
            string[] dataItems = ArcherRawData.Split(',');

            if (dataItems[8].Substring(0, 1).CompareTo("M") == 0 || dataItems[8].Substring(0, 1).CompareTo("F") == 0)
            {
                ArcherID = new DatabaseQueries().GetArcherID(Convert.ToInt32(dataItems[0]));
            }
            else
            {
                ArcherID = Convert.ToInt32(dataItems[0]);
            }

            string[] scoreItems = dataItems[8].Substring(1).Split(' ');

            ArcherScore = Convert.ToInt32(dataItems[1]);

            ArcherTens = Convert.ToInt32(scoreItems[10]);
            ArcherNines = Convert.ToInt32(scoreItems[9]);
            ArcherEights = Convert.ToInt32(scoreItems[8]);
            ArcherSevens = Convert.ToInt32(scoreItems[7]);
            ArcherSixes = Convert.ToInt32(scoreItems[6]);
            ArcherFives = Convert.ToInt32(scoreItems[5]);
            ArcherFours = Convert.ToInt32(scoreItems[4]);
            ArcherThrees = Convert.ToInt32(scoreItems[3]);
            ArcherTwos = Convert.ToInt32(scoreItems[2]);
            ArcherOnes = Convert.ToInt32(scoreItems[1]);
            ArcherZeros = Convert.ToInt32(scoreItems[0]);

            EndOne = ProcessEndSection(1);
            EndTwo = ProcessEndSection(2);
            EndThree = ProcessEndSection(3);
            EndFour = ProcessEndSection(4);
            EndFive = ProcessEndSection(5);
            EndSix = ProcessEndSection(6);
        }

        public ArcherData(string inData)
        {
            ArcherRawData = inData;

            ProcessScoreData();
        }

        public int ArcherDataID { get; set; }
        public int ArcherID { get; set; }

        // Received Data from scanner
        public string ArcherRawData { get; set; }
        public int ArcherScore { get; set; }
        public int ArcherTens { get; set; }
        public int ArcherNines { get; set; }
        public int ArcherEights { get; set; }
        public int ArcherSevens { get; set; }
        public int ArcherSixes { get; set; }
        public int ArcherFives { get; set; }
        public int ArcherFours { get; set; }
        public int ArcherThrees { get; set; }
        public int ArcherTwos { get; set; }
        public int ArcherOnes { get; set; }
        public int ArcherZeros { get; set; }

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
                         "(" + ArcherID + ", '" + ArcherRawData + "', " + ArcherScore + ", " + ArcherTens + ", " + ArcherNines + ", " + ArcherEights + ", " +
                          ArcherSevens + ", " + ArcherSixes + ", " + ArcherFives + ", " + ArcherFours + ", " + ArcherThrees + ", " + ArcherTwos + ", " +
                          ArcherOnes + ", " + ArcherZeros + ", " + EndOne.Score() + ", " + EndTwo.Score() + ", " + EndThree.Score() + ", " +
                          EndFour.Score() + ", " + EndFive.Score() + ", " + EndSix.Score() + ")";
            return sql;
        }
    }
}
