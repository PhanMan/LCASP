using LCASP.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCASP
{
    class PrintScanForms : System.Drawing.Printing.PrintDocument
    {
        // Copied
        private int[] xDim = { 85, 115, 145, 175, 205, 235, 265, 295, 325, 355 }; //{ 355, 325, 295, 265, 235, 205, 175, 145, 115, 85 };
        private int[] yDim = { 760, 780, 800, 820, 840 }; //840, 820, 800, 780, 760 };

        private List<Archer> printArchers = null;
        private IEnumerator printItems = null;

        public Font PrinterFont { get; set; }

        public PrintScanForms(List<Archer> theArchers) : base()
        {
            printArchers = theArchers;
            printItems = printArchers.GetEnumerator();
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
            Archer theItem = null;

            try
            {
                theItem = (Archer)printItems.Current;
            }
            catch (InvalidOperationException ex)
            {
                theItem = null;
            }

            if (theItem != null)
            {
                // Run base code
                base.OnPrintPage(e);

                Graphics myGraphics = e.Graphics;

                // Draw background
                //myGraphics.DrawImage(Resources.score1, 0.0f,0.0f);

                SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

                string idNo = theItem.ArcherID.ToString("00000");

                for(int counter=0; counter<5; counter++)
                {
                    int digit = Convert.ToInt32(idNo[counter].ToString());

                    myGraphics.FillEllipse(myBrush, xDim[digit], yDim[counter], 20, 15);

                }
                Pen thePen = new Pen(myBrush);

                myGraphics.DrawString(theItem.ArcherName, PrinterFont, myBrush, new Point(65, 910));
                myGraphics.DrawString(theItem.ArcherID.ToString("00000"), PrinterFont, myBrush, new Point(360, 910));

                myBrush.Dispose();
                myGraphics.Dispose();
            }

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
