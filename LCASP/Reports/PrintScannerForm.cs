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
    public partial class PrintScannerForm : Form
    {
        private List<KeyValuePair<string, string>> ScanFormPair = new List<KeyValuePair<string, string>>();

        public PrintScannerForm()
        {
            InitializeComponent();

            sCombo.DisplayMember = "Text";
            sCombo.ValueMember = "Value";

            scanFormBox.DisplayMember = "Text";
            scanFormBox.ValueMember = "Value";

            aCombo.DisplayMember = "Text";
            aCombo.ValueMember = "Value";


            scanFormBox.Items.Add(new { Text = "NASP", Value = "NASP" });// new KeyValuePair<string, string>("NASP", "NASP"));
            scanFormBox.Items.Add(new { Text = "AIMS", Value = "AIMS" });// new KeyValuePair<string, string>("AIMS", "AIMS"));
            scanFormBox.Items.Add(new { Text = "TEXT", Value = "TEXT" });

        }

        private void PrintScannerForm_Load(object sender, EventArgs e)
        {
            ReloadSchoolBox();
        }

        private void ReloadSchoolBox()
        {
            sCombo.Items.Clear();

            List<KeyValuePair<int, string>> theList = new DatabaseQueries().GetSchoolList();

            foreach (KeyValuePair<int, string> kvp in theList)
            {
                sCombo.Items.Add(new { Text = kvp.Value, Value = kvp.Key });
            }

            sCombo.SelectedIndex = -1;
            sCombo.ResetText();
        }

        private void ReloadArcherBox()
        {
            aCombo.Items.Clear();

            List<Archer> theList = new DatabaseQueries().GetSchoolArchers((int)sCombo.SelectedItem.GetType().GetProperty("Value").GetValue(sCombo.SelectedItem), "XXXX");

            aCombo.Items.Add(new { Text = "All", Value = "All" });

            foreach (Archer archer in theList)
            {
                aCombo.Items.Add(new { Text = archer.ArcherName, Value = archer.ArcherID });
            }

            aCombo.SelectedIndex = -1;
            aCombo.ResetText();
        }


        private void SCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadArcherBox();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (scanFormBox.SelectedIndex != -1 && aCombo.SelectedIndex != -1 && sCombo.SelectedIndex != -1)
            {
                List<Archer> theArchers = null;

                if(aCombo.SelectedItem.GetType().GetProperty("Text").GetValue(aCombo.SelectedItem).ToString().CompareTo("All")==0)
                {
                    theArchers = new DatabaseQueries().GetSchoolArchers((int)sCombo.SelectedItem.GetType().GetProperty("Value").GetValue(sCombo.SelectedItem), (string)scanFormBox.SelectedItem.GetType().GetProperty("Value").GetValue(scanFormBox.SelectedItem));
                }
                else
                {
                    theArchers = new DatabaseQueries().GetSchoolArcher((int)sCombo.SelectedItem.GetType().GetProperty("Value").GetValue(sCombo.SelectedItem), (int)aCombo.SelectedItem.GetType().GetProperty("Value").GetValue(aCombo.SelectedItem), (string)scanFormBox.SelectedItem.GetType().GetProperty("Value").GetValue(scanFormBox.SelectedItem));
                }

                PrintDocument(theArchers);
            }
            else
            {
                MessageBox.Show("Please select a school, archer, and a form first!");
            }

        }

        private void PrintDocument(List<Archer> theArchers)
        {
            PrintDialog printDlg = null;

            if (theArchers[0].ScanForm.CompareTo("TEXT") == 0)
            {
                PrintOverallScoreReport(theArchers);
            }
            else
            {
                PrintScanForms scp = new PrintScanForms(theArchers);

                scp.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 500, 1100);

                if (Properties.Settings.Default.PrintDialog)
                {
                    printDlg = new PrintDialog();
                    PrintPreviewDialog printPrvDlg = new PrintPreviewDialog()
                    {

                        // preview the assigned document or you can create a different previewButton for it
                        Document = scp
                    };
                    printPrvDlg.ShowDialog(); // this shows the preview and then show the Printer Dlg below
                }

                if (Properties.Settings.Default.PrintDialog && printDlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }


                scp.Print();
            }
        }

        private void ScanFormBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            printButton.Enabled = true;
        }

        private void ArcherCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrintOverallScoreReport(List<Archer> theArchers)
        {
            Scoring theScore = new Scoring(true);

            OverallScoreReport osr = new OverallScoreReport(theScore.OverallList, theArchers[0].SchoolID);
            osr.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);

            osr.Print();

            theScore = null;
        }

    }
}
