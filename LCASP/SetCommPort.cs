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
    public partial class SetCommPort : Form
    {
        public SetCommPort()
        {
            InitializeComponent();

            if (Properties.Settings.Default.COM.Length == 0)
                ComBox.SelectedIndex = 0;
            else
                ComBox.SelectedIndex = Convert.ToInt32(Properties.Settings.Default.COM.Substring(3,1));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            string comSelected = ComBox.SelectedItem.ToString();

            if (comSelected.CompareTo("AUTO") == 0)
                Properties.Settings.Default.COM = "";
            else
                Properties.Settings.Default.COM = comSelected;

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
