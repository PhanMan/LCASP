using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

            SchoolComboBox.DisplayMember = "Text";
            SchoolComboBox.ValueMember = "Value";

            ScanFormComboBox.DisplayMember = "Text";
            ScanFormComboBox.ValueMember = "Value";

            ArcherComboBox.DisplayMember = "Text";
            ArcherComboBox.ValueMember = "Value";


            ScanFormComboBox.Items.Add(new { Text = "NASP 4 Digit ID", Value = "NASP4" });// new KeyValuePair<string, string>("NASP", "NASP"));
            ScanFormComboBox.Items.Add(new { Text = "NASP 5 Digit ID", Value = "NASP5" });// new KeyValuePair<string, string>("NASP", "NASP"));
            ScanFormComboBox.Items.Add(new { Text = "AIMS", Value = "AIMS" });// new KeyValuePair<string, string>("AIMS", "AIMS"));
            ScanFormComboBox.Items.Add(new { Text = "TEXT", Value = "TEXT" });

            HoroText.Text = Properties.Settings.Default.HoroAdjust.ToString();

            VerticalAdjust.Text = Properties.Settings.Default.VerticalAdjust.ToString();
        }

        private void PrintScannerForm_Load(object sender, EventArgs e)
        {
            ReloadSchoolBox();
        }

        private void ReloadSchoolBox()
        {
            SchoolComboBox.Items.Clear();

            List<KeyValuePair<int, string>> theList = new DatabaseQueries().GetSchoolList();

            foreach (KeyValuePair<int, string> kvp in theList)
            {
                SchoolComboBox.Items.Add(new { Text = kvp.Value, Value = kvp.Key });
            }

            SchoolComboBox.SelectedIndex = -1;
            SchoolComboBox.ResetText();
        }

        private void ReloadArcherBox()
        {
            ArcherComboBox.Items.Clear();

            List<Archer> theList = new DatabaseQueries().GetSchoolArchers((int)SchoolComboBox.SelectedItem.GetType().GetProperty("Value").GetValue(SchoolComboBox.SelectedItem), "XXXX");

            ArcherComboBox.Items.Add(new { Text = "All", Value = "All" });

            foreach (Archer archer in theList)
            {
                ArcherComboBox.Items.Add(new { Text = archer.ArcherName, Value = archer.ArcherID });
            }

            ArcherComboBox.SelectedIndex = -1;
            ArcherComboBox.ResetText();
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
            SaveConfigValues();

            if (ScanFormComboBox.SelectedIndex != -1 && ArcherComboBox.SelectedIndex != -1 && SchoolComboBox.SelectedIndex != -1)
            {
                List<Archer> theArchers = null;

                if(ArcherComboBox.SelectedItem.GetType().GetProperty("Text").GetValue(ArcherComboBox.SelectedItem).ToString().CompareTo("All")==0)
                {
                    theArchers = new DatabaseQueries().GetSchoolArchers((int)SchoolComboBox.SelectedItem.GetType().GetProperty("Value").GetValue(SchoolComboBox.SelectedItem), (string)ScanFormComboBox.SelectedItem.GetType().GetProperty("Value").GetValue(ScanFormComboBox.SelectedItem));
                }
                else
                {
                    theArchers = new DatabaseQueries().GetSchoolArcher((int)SchoolComboBox.SelectedItem.GetType().GetProperty("Value").GetValue(SchoolComboBox.SelectedItem), (int)ArcherComboBox.SelectedItem.GetType().GetProperty("Value").GetValue(ArcherComboBox.SelectedItem), (string)ScanFormComboBox.SelectedItem.GetType().GetProperty("Value").GetValue(ScanFormComboBox.SelectedItem));
                }

                PrintDocument(theArchers);


               // SchoolComboBox.SelectedIndex = -1;
               // ArcherComboBox.SelectedIndex = -1;
               // ScanFormComboBox.SelectedIndex = -1;
                PrintButton.Enabled = false;
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
            PrintButton.Enabled = true;
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

        private void HoroText_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerticalAdjust_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveConfigValues()
        {
            Properties.Settings.Default.HoroAdjust = Convert.ToInt32(HoroText.Text);
            Properties.Settings.Default.VerticalAdjust = Convert.ToInt32(VerticalAdjust.Text);

            Properties.Settings.Default.Save();
        }
    }
}
