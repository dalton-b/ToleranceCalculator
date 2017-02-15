using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToleranceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Just display the input. Test
            Double input = Convert.ToDouble(txtInput.Text);
            lblOutput.Text = input.ToString();

            //Did the pull work?

        }
    }
}
