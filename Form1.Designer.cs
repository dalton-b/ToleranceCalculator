namespace ToleranceCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtPlusOrMinus = new System.Windows.Forms.TextBox();
            this.txtPlus = new System.Windows.Forms.TextBox();
            this.txtMinus = new System.Windows.Forms.TextBox();
            this.lblPlusOrMinus = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(177, 260);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(258, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 260);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings...";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 48);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(76, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(134, 67);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output: ";
            // 
            // txtPlusOrMinus
            // 
            this.txtPlusOrMinus.Location = new System.Drawing.Point(109, 48);
            this.txtPlusOrMinus.Name = "txtPlusOrMinus";
            this.txtPlusOrMinus.Size = new System.Drawing.Size(100, 20);
            this.txtPlusOrMinus.TabIndex = 5;
            this.txtPlusOrMinus.Visible = false;
            this.txtPlusOrMinus.TextChanged += new System.EventHandler(this.txtPlusOrMinus_TextChanged);
            // 
            // txtPlus
            // 
            this.txtPlus.Location = new System.Drawing.Point(109, 35);
            this.txtPlus.Name = "txtPlus";
            this.txtPlus.Size = new System.Drawing.Size(100, 20);
            this.txtPlus.TabIndex = 6;
            this.txtPlus.Visible = false;
            // 
            // txtMinus
            // 
            this.txtMinus.Location = new System.Drawing.Point(109, 61);
            this.txtMinus.Name = "txtMinus";
            this.txtMinus.Size = new System.Drawing.Size(100, 20);
            this.txtMinus.TabIndex = 7;
            this.txtMinus.Visible = false;
            // 
            // lblPlusOrMinus
            // 
            this.lblPlusOrMinus.AutoSize = true;
            this.lblPlusOrMinus.Location = new System.Drawing.Point(88, 51);
            this.lblPlusOrMinus.Name = "lblPlusOrMinus";
            this.lblPlusOrMinus.Size = new System.Drawing.Size(13, 13);
            this.lblPlusOrMinus.TabIndex = 8;
            this.lblPlusOrMinus.Text = "±";
            this.lblPlusOrMinus.Visible = false;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(88, 35);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(13, 13);
            this.lblPlus.TabIndex = 9;
            this.lblPlus.Text = "+";
            this.lblPlus.Visible = false;
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Location = new System.Drawing.Point(90, 68);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(10, 13);
            this.lblMinus.TabIndex = 10;
            this.lblMinus.Text = "-";
            this.lblMinus.Visible = false;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Controls.Add(this.lblMinus);
            this.grpInput.Controls.Add(this.txtPlus);
            this.grpInput.Controls.Add(this.lblPlusOrMinus);
            this.grpInput.Controls.Add(this.lblPlus);
            this.grpInput.Controls.Add(this.txtPlusOrMinus);
            this.grpInput.Controls.Add(this.txtMinus);
            this.grpInput.Location = new System.Drawing.Point(68, 102);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(226, 100);
            this.grpInput.TabIndex = 11;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(345, 295);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtPlusOrMinus;
        private System.Windows.Forms.TextBox txtPlus;
        private System.Windows.Forms.TextBox txtMinus;
        private System.Windows.Forms.Label lblPlusOrMinus;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.GroupBox grpInput;
    }
}

