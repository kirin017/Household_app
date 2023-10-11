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
    public partial class FormCooking : Form
    {
        public FormCooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbers = Convert.ToInt32(comboBoxNumDish.Text);
            txtCost.Text = (numbers * 50).ToString();
        }
    }
}
