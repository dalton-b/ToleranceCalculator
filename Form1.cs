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

        //If enter is clicked
        private void btnEnter_Click(object sender, EventArgs e)
        {

            //Store the nominal input
            Double input = Convert.ToDouble(txtInput.Text);

            //Initialize default tolerance values
            Double tolUpper = .1;
            Double tolLower = .1;

            clearOutput();

            //If the plus and minus textboxes are not empty, use those values
            if(!string.IsNullOrWhiteSpace(txtPlus.Text) && !string.IsNullOrWhiteSpace(txtMinus.Text))
            {
                //Store the upper and lower tolerance limit
                tolUpper = Convert.ToDouble(txtPlus.Text);
                tolLower = Convert.ToDouble(txtMinus.Text);

                lblPlusTol.Visible = true;
                lblPlusTol.Text = "+" + txtPlus.Text;
                lblMinusTol.Visible = true;
                lblMinusTol.Text = "-" + txtMinus.Text;
            }
            //If the plusOrMinus textbox is not empty, use that value
            else if(!string.IsNullOrWhiteSpace(txtPlusOrMinus.Text))
            {
                //tolUpper = tolLower because it is a symmetric tolerance
                tolUpper = Convert.ToDouble(txtPlusOrMinus.Text);
                tolLower = Convert.ToDouble(txtPlusOrMinus.Text);

                lblPOMTol.Visible = true;
                lblPOMTol.Text = "±" + txtPlusOrMinus.Text;
            }
            else
            {
                lblPlusTol.Visible = true;
                lblPlusTol.Text = "+" + tolUpper;
                lblMinusTol.Visible = true;
                lblMinusTol.Text = "-" + tolLower;
            }

            //Apply the tolerances to the nominal value
            double outputUpper = input + tolUpper;
            double outputLower = input - tolLower;

            //Display the output
            lblOutput.Text   = outputUpper.ToString() + "\n" + outputLower.ToString();
            lblOutput.Visible = true;
            lblNominal.Visible = true;
            lblNominal.Text = input.ToString();
            lblEquals.Visible = true;

            clearInput();

        }

        //When the input text is changed
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //Check for a '+' character
            if (txtInput.Text.Contains('+'))
            {
                //Make the plusOrMinus options visible
                lblPlusOrMinus.Visible = true;
                txtPlusOrMinus.Visible = true;

                //Remove the plus sign from the textbox
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);

                //Move the window focus to the next textbox
                txtPlusOrMinus.Focus();
            }

        }

        //When the plusOrMinus textbox is changed
        private void txtPlusOrMinus_TextChanged(object sender, EventArgs e)
        {
            //Check for a '-' character
            if(txtPlusOrMinus.Text.Contains('-'))
            {
                //Hide the plusOrMinus options
                lblPlusOrMinus.Visible = false;
                txtPlusOrMinus.Visible = false;

                //Show the plus options and minus options
                txtPlus.Visible = true;
                txtMinus.Visible = true;
                lblPlus.Visible = true;
                lblMinus.Visible = true;

                //Carry over the old input from the plusOrMinus box
                txtPlus.Text = txtPlusOrMinus.Text = txtPlusOrMinus.Text.Substring(0, txtPlusOrMinus.Text.Length - 1);

                //Move the window focus to the next textbox
                txtMinus.Focus();
            }
        }

        //Close the program
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void clearInput()
        {


            txtInput.Clear();
            txtPlusOrMinus.Clear();
            txtPlusOrMinus.Visible = false;
            lblPlusOrMinus.Visible = false;
            txtPlus.Clear();
            lblPlus.Visible = false;
            txtPlus.Visible = false;
            txtMinus.Clear();
            txtMinus.Visible = false;
            lblMinus.Visible = false;

            txtInput.Focus();

        }

        private void clearOutput()
        {
            lblNominal.Text = "";
            lblNominal.Visible = false;
            lblPlusTol.Text = "";
            lblMinusTol.Text = "";
            lblPlusTol.Visible = false;
            lblMinusTol.Visible = false;
            lblPOMTol.Visible = false;
            lblPOMTol.Text = "";
            lblOutput.Text = "";
            lblOutput.Visible = false;
        }

    }
}
