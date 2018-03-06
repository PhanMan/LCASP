using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lcasp
{
    public class TeamScoreReport : System.Drawing.Printing.PrintDocument
    {
        private IEnumerator printItems = null;
        public Font PrinterFont { get; set; }
        int offset = 0;
        int txtheight = 0;
        int archerCount = 0;
        int page = 1;
        //private SortedList<int, int> printList = null;
        private string printTeamName = "";
        private List<KeyValuePair<int, int>> processedList = new List<KeyValuePair<int, int>>();

        public TeamScoreReport(string teamName, SortedList<int, int> theList)
        {
            //printList = theList;
            printTeamName = teamName;

            ProcessTieRule(theList);

            printItems = processedList.GetEnumerator();
        }

        private void ProcessTieRule(SortedList<int,int> theList)
        {
            int duplicateIndex = 0, prevItem = 0, tempIndex = 0;

            DatabaseQueries dQ = new DatabaseQueries();

            foreach (KeyValuePair<int, int> item in theList)
            {
                if (item.Key != 0 && item.Key == prevItem)
                    tempIndex++;
                else
                {
                    if (tempIndex > duplicateIndex)
                        duplicateIndex = tempIndex;

                    tempIndex = 0;

                    prevItem = item.Key;
                }

                processedList.Add(item);
            }

            for (int duplicateRun = 0; duplicateRun < duplicateIndex; duplicateRun++)
            {
                for (int counter = 0; counter < processedList.Count - 1; counter++)
                {
                    if (processedList[counter].Value != 0 && processedList[counter].Key == processedList[counter + 1].Key)
                    {
                        for (int sections = 10; sections > 5; sections--)
                        {
                            int current = dQ.GetArcherSortingFactor(processedList[counter].Value, sections);
                            int ahead = dQ.GetArcherSortingFactor(processedList[counter + 1].Value, sections);

                            if (current > ahead)
                                break;
                            else
                            if (current < ahead)
                            {
                                KeyValuePair<int, int> tItem = processedList[counter + 1];
                                processedList[counter + 1] = processedList[counter];
                                processedList[counter] = tItem;

                                break;
                            }
                        }
                    }
                }
            }
            dQ.Close();
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
            int prevScore = 0;


            KeyValuePair<int, int> theItem = new KeyValuePair<int, int>();
            // Run base code
            base.OnPrintPage(e);

            // Print tools
            Graphics myGraphics = e.Graphics;
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Pen thePen = new Pen(myBrush);
            txtheight = TextRenderer.MeasureText("x", PrinterFont).Height;

            DrawPageHeader(myGraphics, myBrush, thePen, printTeamName + " Archer Report / Page " + page++.ToString().PadLeft(2));


            do
            {
                theItem = (KeyValuePair<int, int>)printItems.Current;

                Archer theArcher = new DatabaseQueries().GetArcher(theItem.Value);
                ArcherData theArcherData = new DatabaseQueries().GetArcherData(theItem.Value);
                archerCount++;


                string printString = archerCount.ToString().PadRight(3) + " " + theArcher.ArcherName.PadRight(17).Substring(0, 17) + sepString +
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

                DrawLine(myGraphics, myBrush, thePen, printString);
                //myGraphics.DrawRectangle(thePen, 5, offset * txtheight, 800, txtheight+10);
                //myGraphics.DrawString(printString, PrinterFont, myBrush, 10, (offset+=2 * txtheight)+5);
                //offset += txtheight + 10;

            } while ((offset < 900) && printItems.MoveNext());

            // Print Scores by Team
            // myGraphics.DrawString(theItem.ArcherName, PrinterFont, myBrush, archerNamePoint);
            // myGraphics.DrawString(theItem.ArcherID.ToString("00000"), PrinterFont, myBrush, archerIdPoint);
            offset = 0;
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

        private void DrawLine(Graphics g, Brush b, Pen p, string txt)
        {
            g.DrawRectangle(p, 5, offset, 800, txtheight + 10);
            g.DrawString(txt, PrinterFont, b, 10, (offset + 5));
            offset += (txtheight + 10);
        }

        private void DrawPageHeader(Graphics g, Brush b, Pen p, string txt)
        {
            Font myFont = new Font("Times New Roman", 14.0f, FontStyle.Bold);
            int height = TextRenderer.MeasureText("X", myFont).Height;
            g.DrawRectangle(p, 5, offset, 800, height + 20);
            g.DrawString(txt, myFont, b, 10, (offset + 10));
            offset += (height + 20);
        }
    }
}


