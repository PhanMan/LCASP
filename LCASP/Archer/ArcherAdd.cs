using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCASP
{
    public partial class ArcherAdd : Form
    {
        private static int school_id = 0;

        public ArcherAdd(int s_id)
        {
            InitializeComponent();

            school_id = s_id;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sexBox.Text.ToUpper().CompareTo("M") == 0 || sexBox.Text.ToUpper().CompareTo("F") == 0)
            {
                new DatabaseQueries().AddArcher(nameBox.Text, sexBox.Text.ToUpper(), school_id);
            }
            else
            {
                MessageBox.Show("Archer Sex must be M or F!");
                sexBox.Text = "";
                sexBox.Focus();
                return;
            }

            nameBox.Text = "";
            sexBox.Text = "";

            nameBox.Focus();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            new ArcherImport(school_id).ShowDialog();
            this.Close();
        }

        private void sexBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
