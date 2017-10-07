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
    public partial class SchoolMaintain : Form
    {
        public SchoolMaintain()
        {
            InitializeComponent();

            schoolCombo.DisplayMember = "Text";
            schoolCombo.ValueMember = "Value";
        }

        private void SchoolMaintain_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> theList = new DatabaseQueries().GetSchoolList();

            foreach(KeyValuePair<int, string> kvp in theList)
            {
                schoolCombo.Items.Add(new { Text = kvp.Value, Value = kvp.Key });
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void reloadSchoolBox()
        {
            schoolCombo.Items.Clear();

            List<KeyValuePair<int, string>> theList = new DatabaseQueries().GetSchoolList();

            foreach (KeyValuePair<int, string> kvp in theList)
            {
                schoolCombo.Items.Add(new { Text = kvp.Value, Value = kvp.Key });
            }
            schoolCombo.SelectedIndex = -1;
            schoolCombo.ResetText();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            new AddSchool().ShowDialog();

            reloadSchoolBox();
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            int id = (int)schoolCombo.SelectedItem.GetType().GetProperty("Value").GetValue(schoolCombo.SelectedItem);

            new DatabaseQueries().DeleteSchool(id);

            reloadSchoolBox();
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
