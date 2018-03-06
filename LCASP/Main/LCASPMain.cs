using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace Lcasp
{
    public partial class LCASPMain : Form
    {
        private RealTimeDisplay theProjector = null;
        public  static ConcurrentQueue<string> archerQueue { get; set; }

        public LCASPMain()
        {
            InitializeComponent();

            Properties.Settings.Default.ProjectScores = false;

            /*
            string iData1 = "       ,180,0980,0000,            ,            ,            ,004, 02 01 02 01 03 03 04 03 03 04 04       ,       ,2,3,4,5,6,6,7,8,9,10,9,7,6,5,4,4,5,6,7,8,8,9,9,10,10,2,1,0,0,10,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";

            for(int count = 1; count<44; count+=3)
            {
                string str = count.ToString() + iData1;

                new DatabaseQueries().SetArcherData(new ArcherData(str));
            }
            */

            //ScannerComm sc = new ScannerComm();
            //sc.Open();
            // sc.InitializeScanner();


            //string iData1 = "90011       ,180,0980,0000,            ,            ,            ,004, 02 01 02 01 03 03 04 03 03 04 04       ,       ,2,3,4,5,6,6,7,8,9,10,9,7,6,5,4,4,5,6,7,8,8,9,9,10,10,2,1,0,0,10,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";
            //string iData2 = "90012       ,225,0980,0000,            ,            ,            ,018, 03 01 01 01 01 01 01 01 01 01 18       ,       ,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,9,8,7,6,5,4,3,2,1,0,0,0,10,10,10,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";

            //string iData2 = "103       ,225,0980,0000,            ,            ,            ,018, 03 01 01 01 01 01 01 01 01 01 18       ,       ,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,9,8,7,6,5,4,3,2,1,0,0,0,10,10,10,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";

            //ArcherData s1 = new DatabaseQueries().GetArcherData(103);

            //ArcherData a1 = new ArcherData(iData2);

            //ArcherData s12 = new DatabaseQueries().SetArcherData(a1);

            //int x = 0;
            //ArcherData a2 = new ArcherData(iData2);

            // ArcherData s22 = new DatabaseQueries().SetArcherData(a2);
            //new DatabaseQueries().CheckDatabaseVersion();

            archerQueue = new ConcurrentQueue<string>();

            new DatabaseQueries().CreateDatabase();

           // new DatabaseQueries().CheckForDBUpdates();

            this.Text = "Lamar Christian Archery " + CurrentVersion;

            new ReportLocation(CurrentVersion);

            if(Properties.Settings.Default.ProjectScores)
                OpenRealTimeScoringForm();
        }

        private void OpenRealTimeScoringForm()
        {
            theProjector = new RealTimeDisplay();
            Screen[] screens = Screen.AllScreens;
            Rectangle bounds = screens[1].Bounds;
            theProjector.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            theProjector.StartPosition = FormStartPosition.Manual;
            theProjector.Show();
        }
 
        private void ASchoolButton_Click(object sender, EventArgs e)
        {
            new SchoolMaintain().ShowDialog();
        }

        private void ASchool_Button(object sender, EventArgs e)
        {
            new SchoolMaintain().ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if(theProjector != null)
                theProjector.Close();
            this.Close();
        }

        private void ArcherButton_CLick(object sender, EventArgs e)
        {
            new ArcherMaintain().ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Confirm().ShowDialog();
        }

        private void MeetButton_Click(object sender, EventArgs e)
        {
            new MatchScore().ShowDialog();
        }

        private void PsButton_Click(object sender, EventArgs e)
        {
            new PrintScannerForm().ShowDialog();
        }
        public string CurrentVersion
        {
            get
            {
                return ApplicationDeployment.IsNetworkDeployed
                       ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
                       : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void projectScoresMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProjectScores = !Properties.Settings.Default.ProjectScores;

            if (Properties.Settings.Default.ProjectScores)
                OpenRealTimeScoringForm();
            else
            {
                if (theProjector != null)
                    theProjector.Close();
                theProjector = null;
            }
        }

        private void backupDatabaseMenuClick(object sender, EventArgs e)
        {
 

            new DatabaseQueries().BackupDatabase();
        }

        private void restoreDatabaseMenuClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Properties.Settings.Default.DatabaseBackup;
            openFileDialog1.Filter = "Database files (*.bak)|*.bak";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                //new DatabaseQueries().RestoreDatabase(selectedFileName);
            }
        }


        private void PrintGenderScoreReport(bool genderFemale)
        {
            Scoring theScore = new Scoring();

            GenderScoreReport osr = null;

            if (genderFemale)
                osr = new GenderScoreReport(theScore.FemaleFinalList, true);
            else
                osr = new GenderScoreReport(theScore.MaleFinalList, false);

            osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

            osr.Print();

            theScore = null;
        }

        private void femaleScoreReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintGenderScoreReport(true);
        }

        private void maleScoreReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintGenderScoreReport(false);
        }
    }
}
