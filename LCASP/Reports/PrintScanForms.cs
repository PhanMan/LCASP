using Lcasp.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lcasp
{
    class PrintScanForms : System.Drawing.Printing.PrintDocument
    {
        // Envy
        //private int[] xDim = { 85, 115, 145, 175, 205, 235, 265, 295, 325, 355 }; //{ 355, 325, 295, 265, 235, 205, 175, 145, 115, 85 };
        //private int[] yDim = { 760, 780, 800, 820, 840 }; //840, 820, 800, 780, 760 };

        // Form 980
        private int[] xDim = { 80, 110, 140, 170, 200, 230, 260, 290, 320, 350 }; //{ 355, 325, 295, 265, 235, 205, 175, 145, 115, 85 };
        private int[] yDim = { 755, 775, 795, 815, 835 }; //840, 820, 800, 780, 760 };
        private Point archerNamePoint = new Point(65 + Properties.Settings.Default.HoroAdjust, 905 + Properties.Settings.Default.VerticalAdjust);
        private Point archerIdPoint = new Point(360 + Properties.Settings.Default.HoroAdjust, 902 + Properties.Settings.Default.VerticalAdjust);

        // State Form
        private int[] xDim1 = { 51, 81, 111, 141, 171, 201, 231, 261, 291 };
        private int[] yDim1 = { 795, 815, 835, 855, 875, 895, 915, 935, 955, 975 };

        private Point archerNamePoint1 = new Point(60+ Properties.Settings.Default.HoroAdjust, 1030+ Properties.Settings.Default.VerticalAdjust);
        private Point archerIdPoint1 = new Point(360 + Properties.Settings.Default.HoroAdjust, 1030 + Properties.Settings.Default.VerticalAdjust);
        private Point archerSexPointMale1 = new Point(380 + Properties.Settings.Default.HoroAdjust, 772 + Properties.Settings.Default.VerticalAdjust);
        private Point archerSexPointFemale1 = new Point(380 + Properties.Settings.Default.HoroAdjust, 796 + Properties.Settings.Default.VerticalAdjust);

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
            catch (InvalidOperationException)
            {
                theItem = null;
            }

            if (theItem != null)
            {
                // Run base code
                base.OnPrintPage(e);

                Graphics myGraphics = e.Graphics;
                SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                Pen thePen = new Pen(myBrush);

                /*
        for (int x = 0; x < 400; x += 10)
        {
            for (int y = 0; y < 900; y += 10)
            {
                myGraphics.FillEllipse(myBrush, x, y, 1f, 1f);
            }
        }
        */

                if (theItem.ScanForm.CompareTo("NASP") == 0)
                {
                    string idNo = theItem.ArcherID.ToString("00000");

                    for (int counter = 0; counter < 5; counter++)
                    {
                        int digit = Convert.ToInt32(idNo[counter].ToString());

                        myGraphics.FillEllipse(myBrush, xDim[digit] + Properties.Settings.Default.HoroAdjust, yDim[counter] + Properties.Settings.Default.VerticalAdjust, 20, 15);
                    }

                    myGraphics.DrawString(theItem.ArcherName, PrinterFont, myBrush, archerNamePoint);
                    myGraphics.DrawString(theItem.ArcherID.ToString("00000"), PrinterFont, myBrush, archerIdPoint);
                }
                else if (theItem.ScanForm.CompareTo("AIMS") == 0)
                {
                    PrinterFont = new Font("Courier New", 9, FontStyle.Bold);

                    string idNo = "";

                    if (theItem.ArcherAIMSID == 0)
                    {
                        idNo = theItem.ArcherID.ToString("000000000");
                    }
                    else
                    {
                        idNo = theItem.ArcherAIMSID.ToString("000000000");
                    }

                    for (int counter = 0; counter < 9; counter++)
                    {
                        int digit = Convert.ToInt32(idNo[counter].ToString());

                        myGraphics.FillEllipse(myBrush, xDim1[counter] + Properties.Settings.Default.HoroAdjust, yDim1[digit] + Properties.Settings.Default.VerticalAdjust, 20, 15);
                    }

                    if (theItem.ArcherSex.CompareTo("M") == 0)
                    {
                        myGraphics.FillEllipse(myBrush, archerSexPointMale1.X, archerSexPointMale1.Y, 20, 15);
                    }
                    else if (theItem.ArcherSex.CompareTo("F") == 0)
                    {
                        myGraphics.FillEllipse(myBrush, archerSexPointFemale1.X, archerSexPointFemale1.Y, 20, 15);
                    }

                    myGraphics.DrawString(theItem.ArcherName, PrinterFont, myBrush, archerNamePoint1);
                    myGraphics.DrawString(idNo, PrinterFont, myBrush, archerIdPoint1);
                }
                else if (theItem.ScanForm.CompareTo("TEXT") == 0)
                {

                }

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
