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
    public partial class AddArcher : Form
    {
        private static int school_id = 0;

        public AddArcher(int s_id)
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
            new DatabaseQueries().AddArcher(nameBox.Text, sexBox.Text, school_id);

            nameBox.Text = "";
            sexBox.Text = "";

            nameBox.Focus();
        }
    }
}
