using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_01
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void btnDesignationLP_Click(object sender, EventArgs e)
        {
            this.Hide();
            DesignationForm DF = new DesignationForm();
            DF.Show();
        }
    }
}
