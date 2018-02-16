using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class Scoring
    {
        public List<SchoolStanding> StandingList { get; set; }
        public SortedList<int, int> OverallList { get; set; }

        public Scoring()
        {
            StandingList = new List<SchoolStanding>();
            OverallList = new SortedList<int, int>(new ScoreComparer<int>());

            ScoreMatch(false);
        }

        public Scoring(Boolean showAllShooters)
        {
            StandingList = new List<SchoolStanding>();
            OverallList = new SortedList<int, int>(new ScoreComparer<int>());

            ScoreMatch(showAllShooters);
        }

        private void ScoreMatch(Boolean showAllShooters)
        {
            List<KeyValuePair<int, string>> schoolList = new DatabaseQueries().GetParticipatingSchoolList(showAllShooters);

            foreach (KeyValuePair<int, string> kvp in schoolList)
            {

                SchoolStanding theStanding = new SchoolStanding(Convert.ToInt32(kvp.Key), kvp.Value);

                List<Archer> schoolArchers = new DatabaseQueries().GetParticipatingSchoolArchers(showAllShooters, Convert.ToInt32(kvp.Key), "XXXX");

                foreach (Archer theArcher in schoolArchers)
                {
                    ArcherData theData = new DatabaseQueries().GetArcherData(theArcher.ArcherID);

                    if (theData != null)
                    {
                        OverallList.Add(theData.ArcherScore, theArcher.ArcherID);
                        theStanding.TeamWide.Add(theData.ArcherScore, theArcher.ArcherID);

                        if (theArcher.ArcherSex.CompareTo("M") == 0)
                        {
                            theStanding.Male.Add(theData.ArcherScore, theArcher.ArcherID);
                        }
                        else if (theArcher.ArcherSex.CompareTo("F") == 0)
                        {
                            theStanding.Female.Add(theData.ArcherScore, theArcher.ArcherID);
                        }
                    }
                    else
                    {
                        OverallList.Add(0, theArcher.ArcherID);
                        theStanding.TeamWide.Add(0, theArcher.ArcherID);
                    }
                }
                StandingList.Add(theStanding);
            }

            foreach (SchoolStanding ss in StandingList)
            {
                if (ss.Female.Count > 4)
                {
                    int fCount = ss.Female.Count-1;

                    for (int count = fCount; count >= 4; count--)
                    {
                        int keyVal = ss.Female.Keys[count];
                        int valVal = ss.Female.Values[count];

                        ss.Overall.Add(keyVal, valVal);

                        ss.Female.RemoveAt(count);
                    }
                }
                else if (ss.Female.Count < 4)
                {
                    for (int count = ss.Female.Count; count < 4; count++)
                        ss.Female.Add(0, 0);
                }

                if (ss.Male.Count > 4)
                {
                    int mCount = ss.Male.Count-1;

                    for (int count = mCount; count >= 4; count--)
                    {
                        int keyVal = ss.Male.Keys[count];
                        int valVal = ss.Male.Values[count];

                        ss.Overall.Add(keyVal, valVal);

                        ss.Male.RemoveAt(count);
                    }
                }
                else if (ss.Male.Count < 4)
                {
                    for (int count = ss.Male.Count; count < 4; count++)
                        ss.Male.Add(0, 0);
                }

                if (ss.Overall.Count > 4)
                {
                    int mCount = ss.Overall.Count - 1;

                    for (int count = mCount; count >= 4; count--)
                    {
                        ss.Overall.RemoveAt(count);
                    }
                }
                else if (ss.Overall.Count < 4)
                {
                    for (int count = ss.Overall.Count; count < 4; count++)
                        ss.Overall.Add(0, 0);
                }
            }
        }
    }
}

