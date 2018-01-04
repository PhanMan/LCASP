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
    public partial class ArcherImport : Form
    {
        private int school_id = 0;

        public ArcherImport(int s_id)
        {
            InitializeComponent();
            school_id = s_id;
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileNameBox.Text = openFileDialog1.FileName;
            iButton.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".csv";
            openFileDialog1.ShowDialog();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IButton_Click(object sender, EventArgs e)
        {
            new ImportType(fileNameBox.Text, school_id).ShowDialog();

            this.Close();
        }
    }
}
