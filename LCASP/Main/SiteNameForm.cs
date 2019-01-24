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
    public partial class SiteNameForm : Form
    {
        public SiteNameForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SiteName = SiteNameBox.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SiteNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
