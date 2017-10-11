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
    public partial class ArcherMaintain : Form
    {
        public ArcherMaintain()
        {
            InitializeComponent();

            sCombo.DisplayMember = "Text";
            sCombo.ValueMember = "Value";

            aCombo.DisplayMember = "Text";
            aCombo.ValueMember = "Value";
        }

        private void ArcherMaintain_Load(object sender, EventArgs e)
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

        private void reloadArcherBox()
        {
            aCombo.Items.Clear();

            List<Archer> theList = new DatabaseQueries().GetSchoolArchers((int)sCombo.SelectedItem.GetType().GetProperty("Value").GetValue(sCombo.SelectedItem));

            foreach (Archer archer in theList)
            {
                aCombo.Items.Add(new { Text = archer.ArcherName, Value = archer.ArcherID });
            }

            aCombo.SelectedIndex = -1;
            aCombo.ResetText();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void schoolCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            reloadArcherBox();

            aCombo.Enabled = true;
            aButton.Enabled = true;

        }

        private void aButton_Click(object sender, EventArgs e)
        {
            new ArcherAdd((int)sCombo.SelectedItem.GetType().GetProperty("Value").GetValue(sCombo.SelectedItem)).ShowDialog();

            reloadArcherBox();
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            new DatabaseQueries().DeleteArcher((int)aCombo.SelectedItem.GetType().GetProperty("Value").GetValue(aCombo.SelectedItem));

            reloadArcherBox();

            aCombo.SelectedIndex = -1;
            aCombo.ResetText();

            dButton.Enabled = false;
        }

        private void aCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dButton.Enabled = true;
        }
    }
}
