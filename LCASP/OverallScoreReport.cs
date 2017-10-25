﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lcasp
{
    public class OverallScoreReport : System.Drawing.Printing.PrintDocument
    {
        private IEnumerator printItems = null;
        public Font PrinterFont { get; set; }
        int offset = 0;
        private SortedList<int, int> printList = null;

        public OverallScoreReport(SortedList<int, int> theList)
        {
            printList = theList;
            printItems = printList.GetEnumerator();
        }

        protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
        {
            // Run base code
            base.OnBeginPrint(e);

            printItems.MoveNext();

            //Check to see if the user provided a font
            //if they didn't then we default to Times New Roman
            if (PrinterFont == null)
            {
                //Create the font we need
                PrinterFont = new Font("Courier New", 7, FontStyle.Bold);

            }
        }

        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
        {
            string sepString = " ";

            KeyValuePair<int, int> theItem = new KeyValuePair<int, int>();
            // Run base code
            base.OnPrintPage(e);

            // Print tools
            Graphics myGraphics = e.Graphics;
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Pen thePen = new Pen(myBrush);
            int txtheight = TextRenderer.MeasureText("x", PrinterFont).Height;

            do
            {
                theItem = (KeyValuePair<int, int>)printItems.Current;

                Archer theArcher = new DatabaseQueries().GetArcher(theItem.Value);
                ArcherData theArcherData = new DatabaseQueries().GetArcherData(theItem.Value);
                
                string printString = theArcher.ArcherName.PadRight(17) + sepString +
                                     theArcher.ArcherSex.Substring(0, 1).PadLeft(1) + sepString +
                                     theArcher.ArcherAIMSID.ToString().PadLeft(10) + sepString +
                                     theArcherData.ArcherScore.ToString().PadLeft(3) + sepString +
                                     theArcherData.EndOne.ShotOne.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndOne.ShotTwo.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndOne.ShotThree.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndOne.ShotFour.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndOne.ShotFive.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndTwo.ShotOne.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndTwo.ShotTwo.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndTwo.ShotThree.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndTwo.ShotFour.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndTwo.ShotFive.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndThree.ShotOne.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndThree.ShotTwo.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndThree.ShotThree.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndThree.ShotFour.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndThree.ShotFive.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFour.ShotOne.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFour.ShotTwo.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFour.ShotThree.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFour.ShotFour.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFour.ShotFive.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFive.ShotOne.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFive.ShotTwo.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFive.ShotThree.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFive.ShotFour.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndFive.ShotFive.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndSix.ShotOne.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndSix.ShotTwo.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndSix.ShotThree.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndSix.ShotFour.ToString().PadLeft(2) + sepString +
                                     theArcherData.EndSix.ShotFive.ToString().PadLeft(2) + "\r\n";

                myGraphics.DrawString(printString, PrinterFont, myBrush, 10, (offset++ * txtheight));
            } while (printItems.MoveNext());

            // Print Scores by Team
            // myGraphics.DrawString(theItem.ArcherName, PrinterFont, myBrush, archerNamePoint);
            // myGraphics.DrawString(theItem.ArcherID.ToString("00000"), PrinterFont, myBrush, archerIdPoint);

            myBrush.Dispose();
            myGraphics.Dispose();

            //Detemine if there is more text to print, if
            //there is the tell the printer there is more coming
            if (printItems.MoveNext())
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
    }
}

