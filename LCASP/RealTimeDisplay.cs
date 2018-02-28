using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lcasp
{
    public partial class RealTimeDisplay : Form
    {
        Timer aTimer = new Timer();
        Timer bTimer = new Timer();
        private DatabaseQueries dQ = null;
        private List<string> myPrivateList = null;
        private int listIndex = 0;

        public RealTimeDisplay()
        {
            InitializeComponent();

            dQ = new DatabaseQueries();

            myPrivateList = dQ.GetAllParticipatingArchers();
        }

        void BTimer_Tick(object sender, EventArgs e)
        {
            string dataLine = null;

            if (listIndex >= myPrivateList.Count)
            {
                listIndex = 0;
                DataListBox.SuspendLayout();
                DataListBox.Items.Clear();
                DataListBox.ResumeLayout();
                myPrivateList.Clear();
                myPrivateList = null;
                myPrivateList = dQ.GetAllParticipatingArchers();
            }

            if (myPrivateList.Count > 0)
            {

                DataListBox.Font = new Font("Courier new", 40, FontStyle.Bold);

                dataLine = myPrivateList[listIndex];

                ArcherData ad = new ArcherData(dataLine);
                Archer a = dQ.GetArcher(ad.ArcherID);


                //string lstr = "Archer Name".PadRight(20) + "          " + "SCORE"; // + sep + "10s" + sep + "9s" + sep + "8s" + sep + "7s" + sep + "6s" + sep + "5s" + sep + "4s" + sep + "3s" + sep + "2s" + sep + "1s" + sep + "0s";

                string str = a.ArcherName.PadRight(25).Substring(0, 25) + " " + ad.ArcherScore.ToString("000 ");
                /*+ sep +
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
                                                                                       */

                DataListBox.Items.Add(str);
                DataListBox.SelectedIndex = DataListBox.Items.Count - 1;

                listIndex++;
            }
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            string dataLine = null;


            while (LCASPMain.archerQueue.TryDequeue(out dataLine))
            {
                myPrivateList.Add(dataLine);
            }
        }

        private void RealTimeDisplay_Load(object sender, EventArgs e)
        {
            aTimer.Tick += new EventHandler(Timer_Tick); // Everytime timer ticks, timer_Tick will be called
            aTimer.Interval = 1000;          // Timer will tick evert 10 seconds
            aTimer.Enabled = true;                       // Enable the timer
            aTimer.Start();

            bTimer.Tick += new EventHandler(BTimer_Tick); // Everytime timer ticks, timer_Tick will be called
            bTimer.Interval = 2000;          // Timer will tick evert 10 seconds
            bTimer.Enabled = true;                       // Enable the timer
            bTimer.Start();
        }

        private void RealTimeDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            dQ = null;
            aTimer.Stop();
            aTimer = null;
            bTimer.Stop();
            bTimer = null;
        }
    }
}
