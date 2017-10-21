using Lcasp;
using System;
using System.Collections;
using System.Drawing;

namespace Lcasp
{
    public class ScoreReport : System.Drawing.Printing.PrintDocument
    {
        private IEnumerator printItems = null;
        public Font PrinterFont { get; set; }

        private Scoring printScores = null;

        public ScoreReport(Scoring theScore)
        {
            printScores = theScore;


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
                PrinterFont = new Font("Courier New", 14, FontStyle.Bold);

            }
        }

        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Run base code
            base.OnPrintPage(e);

            // Print tools
            Graphics myGraphics = e.Graphics;
            SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Pen thePen = new Pen(myBrush);

            // Print Scores by Team
               // myGraphics.DrawString(theItem.ArcherName, PrinterFont, myBrush, archerNamePoint);
               // myGraphics.DrawString(theItem.ArcherID.ToString("00000"), PrinterFont, myBrush, archerIdPoint);
 
            myBrush.Dispose();
            myGraphics.Dispose();
        

            //Detemine if there is more text to print, if
            //there is the tell the printer there is more coming
            if (false)
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
