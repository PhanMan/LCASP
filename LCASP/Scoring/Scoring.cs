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
        public SortedList<int, int> FemaleList { get; set; }
        public List<KeyValuePair<int, int>> FemaleFinalList { get; set; }
        public SortedList<int, int> MaleList { get; set; }
        public List<KeyValuePair<int, int>> MaleFinalList { get; set; }

        public Scoring()
        {
            StandingList = new List<SchoolStanding>();
            OverallList = new SortedList<int, int>(new ScoreComparer<int>());
            FemaleList = new SortedList<int, int>(new ScoreComparer<int>());
            FemaleFinalList = new List<KeyValuePair<int, int>>();
            MaleList = new SortedList<int, int>(new ScoreComparer<int>());
            MaleFinalList = new List<KeyValuePair<int, int>>();

            ScoreMatch(false);
        }

        public Scoring(Boolean showAllShooters)
        {
            StandingList = new List<SchoolStanding>();
            OverallList = new SortedList<int, int>(new ScoreComparer<int>());
            FemaleList = new SortedList<int, int>(new ScoreComparer<int>());
            FemaleFinalList = new List<KeyValuePair<int, int>>();
            MaleList = new SortedList<int, int>(new ScoreComparer<int>());
            MaleFinalList = new List<KeyValuePair<int, int>>();

            ScoreMatch(showAllShooters);
        }

        private void ProcessMaleTieRule()
        {
            int duplicateIndex = 0, prevItem = 0, tempIndex = 0;

            DatabaseQueries dQ = new DatabaseQueries();

            foreach (KeyValuePair<int, int> male in MaleList)
            {
                if (male.Key != 0 && male.Key == prevItem)
                    tempIndex++;
                else
                {
                    if (tempIndex > duplicateIndex)
                        duplicateIndex = tempIndex;

                    tempIndex = 0;

                    prevItem = male.Key;
                }

                MaleFinalList.Add(male);
            }

            for (int duplicateRun = 0; duplicateRun < duplicateIndex; duplicateRun++)
            {
                for (int counter = 0; counter < MaleFinalList.Count - 1; counter++)
                {
                    if (MaleFinalList[counter].Value != 0 && MaleFinalList[counter].Key == MaleFinalList[counter + 1].Key)
                    {
                        for (int sections = 10; sections > 5; sections--)
                        {
                            int current = dQ.GetArcherSortingFactor(MaleFinalList[counter].Value, sections);
                            int ahead = dQ.GetArcherSortingFactor(MaleFinalList[counter + 1].Value, sections);

                            if (current > ahead)
                                break;
                            else
                            if (current < ahead)
                            {
                                KeyValuePair<int, int> tItem = MaleFinalList[counter + 1];
                                MaleFinalList[counter + 1] = MaleFinalList[counter];
                                MaleFinalList[counter] = tItem;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ProcessFemaleTieRule()
        {
            int duplicateIndex = 0, prevItem = 0,  tempIndex = 0;

            DatabaseQueries dQ = new DatabaseQueries();

            foreach(KeyValuePair<int, int> female in FemaleList)
            {
                if (female.Key!=0  && female.Key == prevItem)
                    tempIndex++;
                else
                {
                    if (tempIndex > duplicateIndex)
                        duplicateIndex = tempIndex;

                    tempIndex = 0;

                    prevItem = female.Key;
                }

                FemaleFinalList.Add(female);
            }

            for (int duplicateRun = 0; duplicateRun < duplicateIndex; duplicateRun++)
            {
                for (int counter = 0; counter < FemaleFinalList.Count - 1; counter++)
                {
                    if (FemaleFinalList[counter].Value != 0 && FemaleFinalList[counter].Key == FemaleFinalList[counter + 1].Key)
                    {
                        for (int sections = 10; sections > 5; sections--)
                        {
                            int current = dQ.GetArcherSortingFactor(FemaleFinalList[counter].Value, sections);
                            int ahead = dQ.GetArcherSortingFactor(FemaleFinalList[counter + 1].Value, sections);

                            if (current > ahead)
                                break;
                            else
                            if (current < ahead)
                            {
                                KeyValuePair<int, int> tItem = FemaleFinalList[counter + 1];
                                FemaleFinalList[counter + 1] = FemaleFinalList[counter];
                                FemaleFinalList[counter] = tItem;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ProcessTieRule()
        {
            ProcessFemaleTieRule();
            ProcessMaleTieRule();

            DatabaseQueries dQ = new DatabaseQueries();

            foreach (SchoolStanding ss in StandingList)
            {
                int prevItem = 0, tempIndex = 0, duplicateIndex = 0;

                foreach (KeyValuePair<int, int> top12 in ss.Top12)
                {
                    if (top12.Key != 0 && top12.Key == prevItem)
                        tempIndex++;
                    else
                    {
                        if (tempIndex > duplicateIndex)
                            duplicateIndex = tempIndex;

                        tempIndex = 0;

                        prevItem = top12.Key;
                    }

                    ss.FinalList.Add(top12);
                }

                for (int dupRun = 0; dupRun < duplicateIndex; dupRun++)
                {
                    for (int counter = 0; counter < ss.FinalList.Count - 1; counter++)
                    {
                        if (ss.FinalList[counter].Value != 0 && ss.FinalList[counter].Key == ss.FinalList[counter + 1].Key)
                        {
                            for (int sections = 10; sections > 5; sections--)
                            {
                                int current = dQ.GetArcherSortingFactor(ss.FinalList[counter].Value, sections);
                                int ahead = dQ.GetArcherSortingFactor(ss.FinalList[counter + 1].Value, sections);

                                if (current > ahead)
                                    break;
                                else
                                if (current < ahead)
                                {
                                    KeyValuePair<int, int> tItem = ss.FinalList[counter + 1];
                                    ss.FinalList[counter + 1] = ss.FinalList[counter];
                                    ss.FinalList[counter] = tItem;

                                    break;
                                }
                            }
                        }
                    }
                }
            }
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
                            MaleList.Add(theData.ArcherScore, theArcher.ArcherID);
                        }
                        else if (theArcher.ArcherSex.CompareTo("F") == 0)
                        {
                            theStanding.Female.Add(theData.ArcherScore, theArcher.ArcherID);
                            FemaleList.Add(theData.ArcherScore, theArcher.ArcherID);
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
                int femaleCount = 4;
                int maleCount = 4;
                int overallCount = 4;

                if (ss.Male.Count == 0)
                {
                    femaleCount = 12;
                    maleCount = 0;
                    overallCount = 0;
                }


                if (ss.Female.Count > femaleCount)
                {
                    int fCount = ss.Female.Count - 1;

                    for (int count = fCount; count >= femaleCount; count--)
                    {
                        int keyVal = ss.Female.Keys[count];
                        int valVal = ss.Female.Values[count];

                        ss.Overall.Add(keyVal, valVal);

                        ss.Female.RemoveAt(count);
                    }
                }
                else if (ss.Female.Count < femaleCount)
                {
                    for (int count = ss.Female.Count; count < femaleCount; count++)
                        ss.Female.Add(0, 0);
                }

                if (ss.Male.Count > maleCount)
                {
                    int mCount = ss.Male.Count - 1;

                    for (int count = mCount; count >= maleCount; count--)
                    {
                        int keyVal = ss.Male.Keys[count];
                        int valVal = ss.Male.Values[count];

                        ss.Overall.Add(keyVal, valVal);

                        ss.Male.RemoveAt(count);
                    }
                }
                else if (ss.Male.Count < maleCount)
                {
                    for (int count = ss.Male.Count; count < maleCount; count++)
                        ss.Male.Add(0, 0);
                }

                if (ss.Overall.Count > overallCount)
                {
                    int mCount = ss.Overall.Count - 1;

                    for (int count = mCount; count >= overallCount; count--)
                    {
                        ss.Overall.RemoveAt(count);
                    }
                }
                else if (ss.Overall.Count < overallCount)
                {
                    for (int count = ss.Overall.Count; count < overallCount; count++)
                        ss.Overall.Add(0, 0);
                }

                // Add to top 12 list in order of score.
                foreach (KeyValuePair<int, int> male in ss.Male)
                {
                    ss.Top12.Add(male.Key, male.Value);
                }

                foreach (KeyValuePair<int, int> female in ss.Female)
                {
                    ss.Top12.Add(female.Key, female.Value);
                }

                foreach (KeyValuePair<int, int> overall in ss.Overall)
                {
                    ss.Top12.Add(overall.Key, overall.Value);
                }
            }
            ProcessTieRule();
        }
    }
}

