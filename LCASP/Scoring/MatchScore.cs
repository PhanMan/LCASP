﻿using System;
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
    public partial class MatchScore : Form
    {
        ScannerComm sc = null;
        Timer aTimer = new Timer();
        public CommQueue theQueue = null;

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
            string sep = "   ";

            while ((dataLine = theQueue.DeQueue()) != null)
            {
                ArcherData ad = new ArcherData(dataLine);
                Archer a = new DatabaseQueries().GetArcher(ad.archer_id);

                label1.Font = new Font("Courier new", 10);
                dataList.Font = new Font("Courier new", 10, FontStyle.Bold);


                string lstr = "Archer Name".PadRight(20) + "          " + "SCORE" + sep + "10s" + sep + "9s" + sep + "8s" + sep + "7s" + sep + "6s" + sep + "5s" + sep + "4s" + sep + "3s" + sep + "2s" + sep + "1s" + sep + "0s";
                label1.Text = lstr;
                string str = a.ArcherName.PadRight(20).Substring(0, 20) + "           " + ad.archer_score.ToString("000 ") + sep +
                                                                                       ad.archer_tens.ToString(" 00") + sep +
                                                                                       ad.archer_nines.ToString("00") + sep +
                                                                                       ad.archer_eights.ToString("00") + sep +
                                                                                       ad.archer_sevens.ToString("00") + sep +
                                                                                       ad.archer_sixes.ToString("00") + sep +
                                                                                       ad.archer_fives.ToString("00") + sep +
                                                                                       ad.archer_fours.ToString("00") + sep +
                                                                                       ad.archer_threes.ToString("00") + sep +
                                                                                       ad.archer_twos.ToString("00") + sep +
                                                                                       ad.archer_ones.ToString("00") + sep +
                                                                                       ad.archer_zeros.ToString("00");

                dataList.Items.Add(str);
            }
        }

        private void scoreMatch_Button(object sender, EventArgs e)
        {
            Scoring theScore = new Scoring();
        }
    }
}