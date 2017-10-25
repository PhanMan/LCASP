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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }

        private void YesButtonClick(object sender, EventArgs e)
        {
            new DatabaseQueries().ClearDatabase();
            this.Close();
        }

        private void NoButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
