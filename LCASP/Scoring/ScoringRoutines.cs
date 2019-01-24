using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    public class ScoringRoutines : IDisposable
    {
        private DatabaseQueries dQ = null;

        public ScoringRoutines()
        {
            dQ = new DatabaseQueries();
        }

        public void Dispose()
        {
            dQ.Close();
            dQ = null;
            GC.Collect();
        }

        public void PrintTeamScoreReport()
        {
            Scoring theScore = new Scoring();

            foreach (SchoolStanding school in theScore.StandingList)
            {
                TeamScoreReport osr = new TeamScoreReport(school.School_Name, school.TeamWide);

                osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

                osr.Print();
            }

            theScore = null;
            GC.Collect();
        }

        public void PrintMatchResultsReport()
        {
            Scoring theScore = new Scoring();

            SortedList<int, int> theSortedList = new SortedList<int, int>(new ScoreComparer<int>());

            for (int counter = 0; counter < theScore.StandingList.Count; counter++)
            {
                theSortedList.Add(theScore.StandingList[counter].TeamMatchScore, counter);
            }

            MatchResultsReport osr = new MatchResultsReport(theScore, theSortedList);

            osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

            osr.Print();

            theScore = null;
            GC.Collect();
        }

        public void PrintMatchResultsReport(int school_id)
        {
            Scoring theScore = new Scoring();

            SortedList<int, int> theSortedList = new SortedList<int, int>(new ScoreComparer<int>());

            for (int counter = 0; counter < theScore.StandingList.Count; counter++)
            {
                if (theScore.StandingList[counter].School_ID == school_id)
                {
                    theSortedList.Add(theScore.StandingList[counter].TeamMatchScore, counter);
                    break;
                }
            }

            MatchResultsReport osr = new MatchResultsReport(theScore, theSortedList);

            osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

            osr.Print();

            theScore = null;
            GC.Collect();
        }


        public void PrintOverallScoreReport()
        {
            Scoring theScore = new Scoring();

            OverallScoreReport osr = new OverallScoreReport(theScore.OverallList);
            osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

            osr.Print();

            theScore = null;
            GC.Collect();
        }

        public void ExportMatchResult()
        {
            Scoring theScore = new Scoring();

            SortedList<int, int> theSortedList = new SortedList<int, int>(new ScoreComparer<int>());

            for (int counter = 0; counter < theScore.StandingList.Count; counter++)
            {
                theSortedList.Add(theScore.StandingList[counter].TeamMatchScore, counter);
            }

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MatchResults.csv");
            TextWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);
            sw.WriteLine("Overall Match Results");

            foreach (KeyValuePair<int, int> kvp in theSortedList)
            {
                sw.WriteLine(theScore.StandingList[kvp.Value].School_Name + "," + theScore.StandingList[kvp.Value].TeamMatchScore);

                foreach (KeyValuePair<int, int> male in theScore.StandingList[kvp.Value].Male)
                {
                    sw.WriteLine(GenerateCSVString("M", male));
                }

                foreach (KeyValuePair<int, int> female in theScore.StandingList[kvp.Value].Female)
                {
                    sw.WriteLine(GenerateCSVString("F", female));
                }

                foreach (KeyValuePair<int, int> overall in theScore.StandingList[kvp.Value].Overall)
                {
                    sw.WriteLine(GenerateCSVString(" ", overall));
                }

                sw.WriteLine("");
                sw.WriteLine("");

                sw.Flush();
            }

            sw.Close();

            sw = null;
            theSortedList = null;

            theScore = null;
            GC.Collect();
        }


        public void ExportTeamData()
        {
            Scoring theScore = new Scoring();

            foreach (SchoolStanding ss in theScore.StandingList)
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), ss.School_Name + ".csv");

                TextWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);

                sw.WriteLine(ss.School_Name + "," + ss.TeamMatchScore);

                foreach (KeyValuePair<int, int> male in ss.Male)
                {
                    sw.WriteLine(GenerateCSVString("M", male));
                }

                foreach (KeyValuePair<int, int> female in ss.Female)
                {
                    sw.WriteLine(GenerateCSVString("F", female));
                }

                foreach (KeyValuePair<int, int> overall in ss.Overall)
                {
                    sw.WriteLine(GenerateCSVString(" ", overall));
                }

                sw.WriteLine("");
                sw.WriteLine("");

                sw.WriteLine("Complete Team Listing");

                foreach (KeyValuePair<int, int> entire in ss.TeamWide)
                {
                    sw.WriteLine(GenerateCSVString(" ", entire));
                }

                sw.Flush();
                sw.Close();
            }

            theScore = null;
            GC.Collect();
        }

        public string GenerateCSVString(string sex, KeyValuePair<int, int> archer)
        {
            string retVal = "";
            string sepString = ",";

            if (archer.Key == 0 && archer.Value == 0)
            {
                string s = " ";

                if (sex.CompareTo("M") == 0 || sex.CompareTo("F") == 0)
                    s = "Gender Quota Violation";
                else
                    s = "Minimum Shooter Violation";

                retVal += s + "," + sex + "," + 0 + "," + 0 + ",";
                retVal += 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString;
                retVal += 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString;
                retVal += 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString;
                retVal += 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString;
                retVal += 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString;
                retVal += 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString + 0 + sepString;
            }
            else
            {
                Archer theArcher = dQ.GetArcher(archer.Value);
                ArcherData theArcherData = dQ.GetArcherData(archer.Value);

                retVal += theArcher.ArcherName + "," + theArcher.ArcherSex + "," + theArcher.ArcherAIMSID + "," + theArcherData.ArcherScore + ",";
                retVal += theArcherData.EndOne.ShotOne + sepString + theArcherData.EndOne.ShotTwo + sepString + theArcherData.EndOne.ShotThree + sepString + theArcherData.EndOne.ShotFour + sepString + theArcherData.EndOne.ShotFive + sepString;
                retVal += theArcherData.EndTwo.ShotOne + sepString + theArcherData.EndTwo.ShotTwo + sepString + theArcherData.EndTwo.ShotThree + sepString + theArcherData.EndTwo.ShotFour + sepString + theArcherData.EndTwo.ShotFive + sepString;
                retVal += theArcherData.EndThree.ShotOne + sepString + theArcherData.EndThree.ShotTwo + sepString + theArcherData.EndThree.ShotThree + sepString + theArcherData.EndThree.ShotFour + sepString + theArcherData.EndThree.ShotFive + sepString;
                retVal += theArcherData.EndFour.ShotOne + sepString + theArcherData.EndFour.ShotTwo + sepString + theArcherData.EndFour.ShotThree + sepString + theArcherData.EndFour.ShotFour + sepString + theArcherData.EndFour.ShotFive + sepString;
                retVal += theArcherData.EndFive.ShotOne + sepString + theArcherData.EndFive.ShotTwo + sepString + theArcherData.EndFive.ShotThree + sepString + theArcherData.EndFive.ShotFour + sepString + theArcherData.EndFive.ShotFive + sepString;
                retVal += theArcherData.EndSix.ShotOne + sepString + theArcherData.EndSix.ShotTwo + sepString + theArcherData.EndSix.ShotThree + sepString + theArcherData.EndSix.ShotFour + sepString + theArcherData.EndSix.ShotFive;
            }

            return retVal;
        }
    }
}
