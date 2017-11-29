using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lcasp
{
    public partial class MatchScore : Form
    {
        ScannerComm sc = null;
        Timer aTimer = new Timer();
        public CommQueue theQueue = null;
        private DatabaseQueries dQ = null;

        public MatchScore()
        {
            InitializeComponent();

            dQ = new DatabaseQueries();

            theQueue = new CommQueue();

            sc = new ScannerComm(theQueue);
            sc.Open();
            sc.InitializeScanner();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            dQ = null;
            aTimer.Stop();
            aTimer = null;
            sc.Close();
            this.Close();
        }

        private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MatchScore_Load(object sender, EventArgs e)
        {
            aTimer.Tick += new EventHandler(Timer_Tick); // Everytime timer ticks, timer_Tick will be called
            aTimer.Interval = 250;          // Timer will tick evert 10 seconds
            aTimer.Enabled = true;                       // Enable the timer
            aTimer.Start();                              // Start the timer
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            string dataLine = null;
            string sep = "   ";

            while ((dataLine = theQueue.DeQueue()) != null)
            {
                ArcherData ad = new ArcherData(dataLine);
                Archer a = dQ.GetArcher(ad.ArcherID);

                label1.Font = new Font("Courier new", 10);
                DataListBox.Font = new Font("Courier new", 10, FontStyle.Bold);


                string lstr = "Archer Name".PadRight(20) + "          " + "SCORE" + sep + "10s" + sep + "9s" + sep + "8s" + sep + "7s" + sep + "6s" + sep + "5s" + sep + "4s" + sep + "3s" + sep + "2s" + sep + "1s" + sep + "0s";
                label1.Text = lstr;
                string str = a.ArcherName.PadRight(20).Substring(0, 20) + "           " + ad.ArcherScore.ToString("000 ") + sep +
                                                                                       ad.ArcherTens.ToString(" 00") + sep +
                                                                                       ad.ArcherNines.ToString("00") + sep +
                                                                                       ad.ArcherEights.ToString("00") + sep +
                                                                                       ad.ArcherSevens.ToString("00") + sep +
                                                                                       ad.ArcherSixes.ToString("00") + sep +
                                                                                       ad.ArcherFives.ToString("00") + sep +
                                                                                       ad.ArcherFours.ToString("00") + sep +
                                                                                       ad.ArcherThrees.ToString("00") + sep +
                                                                                       ad.ArcherTwos.ToString("00") + sep +
                                                                                       ad.ArcherOnes.ToString("00") + sep +
                                                                                       ad.ArcherZeros.ToString("00");

                DataListBox.Items.Add(str);
                DataListBox.SelectedIndex = DataListBox.Items.Count - 1;

            }
        }

        private void ScoreMatch_Button(object sender, EventArgs e)
        {

            PrintOverallScoreReport();

            PrintTeamScoreReport();

            ExportMatchResult();

            ExportTeamData();

            MessageBox.Show("Match Processed : All Data Exported.");
        }

        private void PrintTeamScoreReport()
        {
            Scoring theScore = new Scoring();
            
            foreach(SchoolStanding school in theScore.StandingList)
            {
                TeamScoreReport osr = new TeamScoreReport(school.School_Name, school.TeamWide);

                osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

                osr.Print();

                theScore = null;
            }
        }

        private void PrintOverallScoreReport()
        {
            Scoring theScore = new Scoring();

            OverallScoreReport osr = new OverallScoreReport(theScore.OverallList);
            osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

            osr.Print();

            theScore = null;
        }

        private void ExportMatchResult()
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

            GC.Collect();
        }


        private void ExportTeamData()
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

            GC.Collect();
        }

        private string GenerateCSVString(string sex, KeyValuePair<int, int> archer)
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
