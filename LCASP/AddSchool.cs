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
    public partial class AddSchool : Form
    {
        public AddSchool()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            new DatabaseQueries().AddSchool(nameBox.Text);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            new DatabaseQueries().AddSchool(nameBox.Text);

            nameBox.Text = "";
            nameBox.Focus();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
