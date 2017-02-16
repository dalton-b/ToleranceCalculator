using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToleranceCalculator
{
    public partial class Form1 : Form
    {
        //Declare the settings window
        private SettingsForm _settings;
        
        public Form1()
        {
            InitializeComponent();

            //Create an instance of the settings window
            //and set the default output decimal places
            _settings = new SettingsForm();
            _settings.cmbDecPlaces.SelectedIndex = 3;
        }

        //If enter is clicked
        private void btnEnter_Click(object sender, EventArgs e)
        {

            //Store the nominal input
            Double input = Convert.ToDouble(txtInput.Text);


            //Initialize default tolerance values
            Double tolUpper = Convert.ToDouble(_settings.txtDefaultTol.Text);
            Double tolLower = Convert.ToDouble(_settings.txtDefaultTol.Text);

            //Clear the output window when new input is received
            clearOutput();

            //If the plus and minus textboxes are not empty, use those values
            if(!string.IsNullOrWhiteSpace(txtPlus.Text) && !string.IsNullOrWhiteSpace(txtMinus.Text))
            {
                //Store the upper and lower tolerance limit
                tolUpper = Convert.ToDouble(txtPlus.Text);
                tolLower = Convert.ToDouble(txtMinus.Text);

                //Display text in the output window
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

                //Display text in the output window
                lblPOMTol.Visible = true;
                lblPOMTol.Text = "±" + txtPlusOrMinus.Text;
            }
            else
            {
                //Display text in the output window
                lblPlusTol.Visible = true;
                lblPlusTol.Text = "+" + tolUpper;
                lblMinusTol.Visible = true;
                lblMinusTol.Text = "-" + tolLower;
            }

            //Apply the tolerances to the nominal value
            double outputUpper = input + tolUpper;
            double outputLower = input - tolLower;

            //Convert to metric if the checkbox is checked in the settings
            if (_settings.chkConvert.Checked == true)
            {
                outputUpper = outputUpper / 25.4;
                outputLower = outputLower / 25.4;
            }

            //Decimal places to round off
            int decPlaces = Convert.ToInt32(_settings.cmbDecPlaces.SelectedItem);

            //Round appropriately (truncate upper bound, round up lower bound
            outputUpper = Math.Floor(outputUpper * Math.Pow(10, decPlaces))/Math.Pow(10, decPlaces);
            outputLower = Math.Ceiling(outputLower * Math.Pow(10, decPlaces)) / Math.Pow(10, decPlaces);


            //Display the output, formatted to the correct number of decimal places
            lblOutput.Text   = outputUpper.ToString("N" + decPlaces) + "\n" + outputLower.ToString("N" + decPlaces);
            lblOutput.Visible = true;
            lblNominal.Visible = true;
            lblNominal.Text = input.ToString();
            lblEquals.Visible = true;

            //Clear the input window
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

            //Check for a '-' character
            if(txtInput.Text.Contains('-'))
            {
                //Make the plus or minus options visible
                txtPlus.Visible = true;
                txtMinus.Visible = true;
                lblPlus.Visible = true;
                lblMinus.Visible = true;

                //Get rid of the '-' character
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);

                txtPlus.Focus();
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

        //Show the settings window when the settings button is clicked
        private void btnSettings_Click(object sender, EventArgs e)
        {
            _settings.Show();
        }


        //Close the program
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Reset the input window to its initial state
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

        //Reset the output window to its initial state
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
