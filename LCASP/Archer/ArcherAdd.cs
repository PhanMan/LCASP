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
    public partial class ArcherAdd : Form
    {
        private static int school_id = 0;

        public ArcherAdd(int s_id)
        {
            InitializeComponent();

            school_id = s_id;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsNumeric(string text)
        {
            return int.TryParse(text, out int test);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SexBox.Text.ToUpper().CompareTo("M") == 0 || SexBox.Text.ToUpper().CompareTo("F") == 0 && IsNumeric(StateIDBox.Text))
            {
                int archer_state_id = Convert.ToInt32(StateIDBox.Text);

                new DatabaseQueries().AddArcher(NameBox.Text, archer_state_id, SexBox.Text.ToUpper(), school_id);
            }
            else
            {
                MessageBox.Show("Archer Sex must be M or F and AIMS Id must be numeric.");
                SexBox.Text = "";
                SexBox.Focus();
                return;
            }

            this.Close();

            /*
            NameBox.Text = "";
            SexBox.Text = "";
            StateIDBox.Text = "";

            NameBox.Focus();
            */
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            new ArcherImport(school_id).ShowDialog();
            this.Close();
        }

        private void SexBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void StateIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
