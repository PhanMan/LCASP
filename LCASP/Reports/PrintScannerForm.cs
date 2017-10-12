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
        public PrintScannerForm()
        {
            InitializeComponent();

            sCombo.DisplayMember = "Text";
            sCombo.ValueMember = "Value";
        }

        private void PrintScannerForm_Load(object sender, EventArgs e)
        {
            reloadSchoolBox();
        }

        private void reloadSchoolBox()
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


        private void sCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            printButton.Enabled = true;
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            List<Archer> theArchers = new DatabaseQueries().GetSchoolArchers((int)sCombo.SelectedItem.GetType().GetProperty("Value").GetValue(sCombo.SelectedItem));

            PrintDocument(theArchers);
        }

        private void PrintDocument(List<Archer> theArchers)
        {
            PrintDialog printDlg = null;

            PrintScanForms scp = new PrintScanForms(theArchers);
            scp.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 500, 1100);

            if (Properties.Settings.Default.PrintDialog)
            {
                printDlg = new PrintDialog();
                PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

                // preview the assigned document or you can create a different previewButton for it
                printPrvDlg.Document = scp;
                printPrvDlg.ShowDialog(); // this shows the preview and then show the Printer Dlg below
            }

            if (Properties.Settings.Default.PrintDialog && printDlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }


            scp.Print();
        }
    }
}
