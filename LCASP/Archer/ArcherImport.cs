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
    public partial class ArcherImport : Form
    {
        private int school_id = 0;

        public ArcherImport(int s_id)
        {
            InitializeComponent();
            school_id = s_id;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileNameBox.Text = openFileDialog1.FileName;
            iButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".csv";
            openFileDialog1.ShowDialog();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iButton_Click(object sender, EventArgs e)
        {
             string[] lines = System.IO.File.ReadAllLines(fileNameBox.Text);

            DatabaseQueries dq = new DatabaseQueries();

            foreach(string s in lines)
            {
                string[] items = s.Split(',');
                dq.AddArcher(items[0], items[1], school_id);
            }

            dq = null;

            this.Close();
        }
    }
}
