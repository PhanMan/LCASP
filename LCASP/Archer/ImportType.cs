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
    public partial class ImportType : Form
    {
        private string fileName = "";
        private int school_id = 0;
        private int importType = 0;

        public ImportType()
        {
            InitializeComponent();
        }

        public ImportType(string file, int sID) : this()
        {
            fileName = file;
            school_id = sID;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            DatabaseQueries dq = new DatabaseQueries();

            string[] lines = System.IO.File.ReadAllLines(fileName);

            try
            {
                switch (importType)
                {
                    case 1:
                        {
                            foreach (string s in lines)
                            {
                                string[] items = s.Split(',');
                                //dq.AddArcher(items[2], Convert.ToInt32(items[1]), items[3], school_id);
                                dq.AddArcher(items[0], 0, items[1], school_id);
                            }

                            MessageBox.Show("Archers Imported.");

                        }
                        break;
                    /*
                    case 2:
                        {
                            foreach (string s in lines)
                            {
                                string[] items = s.Split(',');
                                //dq.AddArcher(items[2], Convert.ToInt32(items[1]), items[3], school_id);
                                dq.AddArcher(items[0], Convert.ToInt32(items[2]), items[1], school_id);
                            }

                            MessageBox.Show("Archers Imported.");

                        }
                        break;
                        */
                    case 3:
                        {
                            lines = lines.Where(w => w != lines[0]).ToArray();

                            foreach (string s in lines)
                            {
                                string[] items = s.Split(',');
                                //dq.AddArcher(items[2], Convert.ToInt32(items[1]), items[3], school_id);
                                dq.AddArcher(items[1], Convert.ToInt32(items[0]), items[2], school_id);
                            }

                            MessageBox.Show("Archers Imported.");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing data file!" + "\n" + ex.Message);
            }
            
            dq = null;

            this.Close();


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NsButton_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
            importType = 1;
        }

        private void NasButton_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
            importType = 2;
        }

        private void InsButton_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
            importType = 3;
        }
    }
}
