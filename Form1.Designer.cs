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
            this.txtPlusOrMinus = new System.Windows.Forms.TextBox();
            this.txtPlus = new System.Windows.Forms.TextBox();
            this.txtMinus = new System.Windows.Forms.TextBox();
            this.lblPlusOrMinus = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblNominal = new System.Windows.Forms.Label();
            this.lblPOMTol = new System.Windows.Forms.Label();
            this.lblMinusTol = new System.Windows.Forms.Label();
            this.lblPlusTol = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(190, 333);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(65, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(261, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 333);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(65, 23);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings...";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(28, 64);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(76, 35);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtPlusOrMinus
            // 
            this.txtPlusOrMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlusOrMinus.Location = new System.Drawing.Point(164, 64);
            this.txtPlusOrMinus.Name = "txtPlusOrMinus";
            this.txtPlusOrMinus.Size = new System.Drawing.Size(88, 35);
            this.txtPlusOrMinus.TabIndex = 5;
            this.txtPlusOrMinus.Visible = false;
            this.txtPlusOrMinus.TextChanged += new System.EventHandler(this.txtPlusOrMinus_TextChanged);
            // 
            // txtPlus
            // 
            this.txtPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlus.Location = new System.Drawing.Point(164, 41);
            this.txtPlus.Name = "txtPlus";
            this.txtPlus.Size = new System.Drawing.Size(88, 35);
            this.txtPlus.TabIndex = 6;
            this.txtPlus.Visible = false;
            // 
            // txtMinus
            // 
            this.txtMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinus.Location = new System.Drawing.Point(164, 79);
            this.txtMinus.Name = "txtMinus";
            this.txtMinus.Size = new System.Drawing.Size(88, 35);
            this.txtMinus.TabIndex = 7;
            this.txtMinus.Visible = false;
            // 
            // lblPlusOrMinus
            // 
            this.lblPlusOrMinus.AutoSize = true;
            this.lblPlusOrMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusOrMinus.Location = new System.Drawing.Point(120, 67);
            this.lblPlusOrMinus.Name = "lblPlusOrMinus";
            this.lblPlusOrMinus.Size = new System.Drawing.Size(27, 29);
            this.lblPlusOrMinus.TabIndex = 8;
            this.lblPlusOrMinus.Text = "±";
            this.lblPlusOrMinus.Visible = false;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(120, 47);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(27, 29);
            this.lblPlus.TabIndex = 9;
            this.lblPlus.Text = "+";
            this.lblPlus.Visible = false;
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(120, 82);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(21, 29);
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
            this.grpInput.Location = new System.Drawing.Point(26, 150);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(282, 154);
            this.grpInput.TabIndex = 11;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblOutput);
            this.grpOutput.Controls.Add(this.lblEquals);
            this.grpOutput.Controls.Add(this.lblNominal);
            this.grpOutput.Controls.Add(this.lblPOMTol);
            this.grpOutput.Controls.Add(this.lblMinusTol);
            this.grpOutput.Controls.Add(this.lblPlusTol);
            this.grpOutput.Location = new System.Drawing.Point(26, 12);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(282, 132);
            this.grpOutput.TabIndex = 12;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(192, 29);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(84, 29);
            this.lblOutput.TabIndex = 17;
            this.lblOutput.Text = "Output";
            this.lblOutput.Visible = false;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(159, 45);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(27, 29);
            this.lblEquals.TabIndex = 13;
            this.lblEquals.Text = "=";
            this.lblEquals.Visible = false;
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNominal.Location = new System.Drawing.Point(1, 45);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(103, 29);
            this.lblNominal.TabIndex = 13;
            this.lblNominal.Text = "Nominal";
            this.lblNominal.Visible = false;
            // 
            // lblPOMTol
            // 
            this.lblPOMTol.AutoSize = true;
            this.lblPOMTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOMTol.Location = new System.Drawing.Point(84, 45);
            this.lblPOMTol.Name = "lblPOMTol";
            this.lblPOMTol.Size = new System.Drawing.Size(69, 29);
            this.lblPOMTol.TabIndex = 14;
            this.lblPOMTol.Text = "± Tol";
            this.lblPOMTol.Visible = false;
            // 
            // lblMinusTol
            // 
            this.lblMinusTol.AutoSize = true;
            this.lblMinusTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusTol.Location = new System.Drawing.Point(90, 74);
            this.lblMinusTol.Name = "lblMinusTol";
            this.lblMinusTol.Size = new System.Drawing.Size(57, 29);
            this.lblMinusTol.TabIndex = 15;
            this.lblMinusTol.Text = "-Tol";
            this.lblMinusTol.Visible = false;
            // 
            // lblPlusTol
            // 
            this.lblPlusTol.AutoSize = true;
            this.lblPlusTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusTol.Location = new System.Drawing.Point(90, 29);
            this.lblPlusTol.Name = "lblPlusTol";
            this.lblPlusTol.Size = new System.Drawing.Size(63, 29);
            this.lblPlusTol.TabIndex = 16;
            this.lblPlusTol.Text = "+Tol";
            this.lblPlusTol.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(336, 371);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtPlusOrMinus;
        private System.Windows.Forms.TextBox txtPlus;
        private System.Windows.Forms.TextBox txtMinus;
        private System.Windows.Forms.Label lblPlusOrMinus;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblNominal;
        private System.Windows.Forms.Label lblPOMTol;
        private System.Windows.Forms.Label lblMinusTol;
        private System.Windows.Forms.Label lblPlusTol;
        private System.Windows.Forms.Label lblOutput;
    }
}

