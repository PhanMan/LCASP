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
    public partial class SchoolAdd : Form
    {
        public SchoolAdd()
        {
            InitializeComponent();
        }

        private void SButtonClick(object sender, EventArgs e)
        {
            new DatabaseQueries().AddSchool(NameBox.Text);

            this.Close();
            /*
            nameBox.Text = "";
            nameBox.Focus();
            */
        }

        private void CButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameBoxChanged(object sender, EventArgs e)
        {

        }
    }
}
