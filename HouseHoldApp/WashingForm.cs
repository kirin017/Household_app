using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseHoldApp
{
    public partial class WashingForm : Form
    {
        public WashingForm()
        {
            InitializeComponent();
        }

        private void comboBoxNumDish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int volume = Convert.ToInt32(comboBoxNumDish.Text);
            if (volume <= 3)
            {
                txtCost.Text = 30.ToString();
            }
            else
            {
                txtCost.Text = (volume * 10).ToString();
            }

        }
    }
}
