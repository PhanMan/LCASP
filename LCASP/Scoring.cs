using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class Scoring
    {
        List<SchoolStanding> standingList { get; set; }
        SortedList<int, int> overallList { get; set; } 

        public Scoring()
        {
            standingList = new List<SchoolStanding>();
            overallList = new SortedList<int, int>(new ScoreComparer<int>());

            ScoreMatch();
        }

        private void ScoreMatch()
        {
            List<KeyValuePair<int, string>> schoolList = new DatabaseQueries().GetSchoolList();

            foreach (KeyValuePair<int, string> kvp in schoolList)
            {
                
                SchoolStanding theStanding = new SchoolStanding(Convert.ToInt32(kvp.Key), kvp.Value);

                List<Archer> schoolArchers = new DatabaseQueries().GetSchoolArchers(Convert.ToInt32(kvp.Key));

                foreach (Archer theArcher in schoolArchers)
                {
                    ArcherData theData = new DatabaseQueries().GetArcherData(theArcher.ArcherID);

                    overallList.Add(theData.archer_score, theArcher.ArcherID);
                    theStanding.teamWide.Add(theData.archer_score, theArcher.ArcherID);

                    if (theArcher.ArcherSex.CompareTo("M") == 0)
                    {
                        theStanding.male.Add(theData.archer_score, theArcher.ArcherID);
                    }
                    else if (theArcher.ArcherSex.CompareTo("F") == 0)
                    {
                        theStanding.female.Add(theData.archer_score, theArcher.ArcherID);
                    }
                }
                standingList.Add(theStanding);
            }

            foreach (SchoolStanding ss in standingList)
            {
                if (ss.female.Count > 4)
                {
                    for (int count = 4; count < ss.female.Count; count++)
                    {
                        int keyVal = ss.female.Keys[count];
                        int valVal = ss.female.Values[count];

                        ss.overall.Add(keyVal, valVal);

                        ss.female.RemoveAt(count);
                    }

                    for (int count = 4; count < ss.male.Count; count++)
                    {
                        int keyVal = ss.male.Keys[count];
                        int valVal = ss.male.Values[count];

                        ss.overall.Add(keyVal, valVal);

                        ss.male.RemoveAt(count);
                    }
                }
            }
        }
    }
}
