using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleifelseapp
{
    public partial class PlanetForm : Form
    {
        public PlanetForm()
        {
            InitializeComponent();
        }
        private void showplanetnumberButton_Click(object sender, EventArgs e)
        {
            string planetname = planetnameComboBox.Text;

            if (planetname == "Planet")
            {
                MessageBox.Show("it is first planet");
            }

            else if (planetname == "Mars")
            {
                MessageBox.Show("it is 2nd planet");
            }
            else
            {
                MessageBox.Show("i dont know :(");
            }

        }
    }
}
