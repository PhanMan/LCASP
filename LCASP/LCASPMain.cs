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
    public partial class LCASPMain : Form
    {
        public LCASPMain()
        {
            InitializeComponent();

            //ScannerComm sc = new ScannerComm();
            //sc.Open();
           // sc.InitializeScanner();


            //string iData1 = "90011       ,180,0980,0000,            ,            ,            ,004, 02 01 02 01 03 03 04 03 03 04 04       ,       ,2,3,4,5,6,6,7,8,9,10,9,7,6,5,4,4,5,6,7,8,8,9,9,10,10,2,1,0,0,10,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";
           // string iData2 = "90012       ,225,0980,0000,            ,            ,            ,018, 03 01 01 01 01 01 01 01 01 01 18       ,       ,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,9,8,7,6,5,4,3,2,1,0,0,0,10,10,10,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";


            //ArcherData a1 = new ArcherData(iData1);

            //ArcherData s12 = new DatabaseQueries().SetArcherData(a1);

            //ArcherData a2 = new ArcherData(iData2);

           // ArcherData s22 = new DatabaseQueries().SetArcherData(a2);


            int x1 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SchoolMaintain().Show();
        }

        private void pulseButton1_Click(object sender, EventArgs e)
        {
            new SchoolMaintain().Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aArcherButton_Click(object sender, EventArgs e)
        {
            new ArcherMaintain().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Confirm().ShowDialog();
        }
    }
}
