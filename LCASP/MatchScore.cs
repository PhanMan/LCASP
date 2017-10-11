﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCASP
{
    public partial class MatchScore : Form
    {
        ScannerComm sc = null;
        Timer aTimer = new Timer();
        public CommQueue theQueue = null;
        List<SchoolStanding> standingList = new List<SchoolStanding>();

        public MatchScore()
        {
            InitializeComponent();

            theQueue = new CommQueue();

            sc = new ScannerComm(theQueue);
            sc.Open();
            sc.InitializeScanner();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            sc.Close();
            this.Close();
        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MatchScore_Load(object sender, EventArgs e)
        {


            aTimer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            aTimer.Interval = 250;          // Timer will tick evert 10 seconds
            aTimer.Enabled = true;                       // Enable the timer
            aTimer.Start();                              // Start the timer
        }

        void timer_Tick(object sender, EventArgs e)
        {
            string dataLine = null;

            while ((dataLine = theQueue.DeQueue()) != null)
            {
                ArcherData ad = new ArcherData(dataLine);
                Archer a = new DatabaseQueries().GetArcher(ad.archer_id);
                string str = a.ArcherName + " :          (" + ad.archer_score.ToString(" 000 ") + "),     " + ad.archer_tens.ToString(" 00 ") + ",    " + ad.archer_nines.ToString(" 00 ") + ",    " + ad.archer_eights.ToString(" 00 ") + ",    " + ad.archer_sevens.ToString(" 00 ") + ",    " + ad.archer_sixes.ToString(" 00 ") + ",    " + ad.archer_fives.ToString(" 00 ") + ",    " + ad.archer_fours.ToString(" 00 ") + ",    " + ad.archer_threes.ToString(" 00 ") + ",    " + ad.archer_twos.ToString(" 00 ") + ",    " + ad.archer_ones.ToString(" 00 ") + ",    " + ad.archer_zeros.ToString(" 00 ");

                dataList.Items.Add(str);
            }
        }

        private void scoreMatch_Button(object sender, EventArgs e)
        {
            
            List<KeyValuePair<int, string>> schoolList = new DatabaseQueries().GetSchoolList();

            foreach(KeyValuePair<int,string> kvp in schoolList)
            {
                SchoolStanding theStanding = new SchoolStanding(Convert.ToInt32(kvp.Key));

                List<Archer> schoolArchers = new DatabaseQueries().GetSchoolArchers(Convert.ToInt32(kvp.Key));

                foreach(Archer theArcher in schoolArchers)
                {
                    ArcherData theData = new DatabaseQueries().GetArcherData(theArcher.ArcherID);

                    theStanding.overall.Add(theData.archer_score, theArcher.ArcherID);

                    if(theArcher.ArcherSex.CompareTo("M")==0)
                    {
                        theStanding.male.Add(theData.archer_score, theArcher.ArcherID);
                    }
                    else if(theArcher.ArcherSex.CompareTo("F")==0)
                    {
                        theStanding.female.Add(theData.archer_score, theArcher.ArcherID);
                    }
                }
                standingList.Add(theStanding);
            }


        }
    }
}
