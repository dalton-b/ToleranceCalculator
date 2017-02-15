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


        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //this.btnSolve.Enabled = !string.IsNullOrWhiteSpace(this.txtVolume.Text);
            //lblVtarget.ForeColor = Color.Green;
            //lblin3.forecolor = color.green;

            if (txtInput.Text.Contains('+'))
            {
                lblPlusOrMinus.Visible = true;
                txtPlusOrMinus.Visible = true;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


    }
}
