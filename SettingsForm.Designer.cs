namespace ToleranceCalculator
{
    partial class SettingsForm
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
            this.chkConvert = new System.Windows.Forms.CheckBox();
            this.cmbDecPlaces = new System.Windows.Forms.ComboBox();
            this.lblDecPlaces = new System.Windows.Forms.Label();
            this.txtDefaultTol = new System.Windows.Forms.TextBox();
            this.lblDefaultTol = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkConvert
            // 
            this.chkConvert.AutoSize = true;
            this.chkConvert.Checked = true;
            this.chkConvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConvert.Location = new System.Drawing.Point(16, 94);
            this.chkConvert.Name = "chkConvert";
            this.chkConvert.Size = new System.Drawing.Size(183, 24);
            this.chkConvert.TabIndex = 0;
            this.chkConvert.Text = "Convert from mm to in";
            this.chkConvert.UseVisualStyleBackColor = true;
            // 
            // cmbDecPlaces
            // 
            this.cmbDecPlaces.FormattingEnabled = true;
            this.cmbDecPlaces.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDecPlaces.Location = new System.Drawing.Point(16, 127);
            this.cmbDecPlaces.Name = "cmbDecPlaces";
            this.cmbDecPlaces.Size = new System.Drawing.Size(40, 21);
            this.cmbDecPlaces.TabIndex = 1;
            // 
            // lblDecPlaces
            // 
            this.lblDecPlaces.AutoSize = true;
            this.lblDecPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecPlaces.Location = new System.Drawing.Point(62, 128);
            this.lblDecPlaces.Name = "lblDecPlaces";
            this.lblDecPlaces.Size = new System.Drawing.Size(187, 20);
            this.lblDecPlaces.TabIndex = 2;
            this.lblDecPlaces.Text = "Decimal places in answer";
            // 
            // txtDefaultTol
            // 
            this.txtDefaultTol.Location = new System.Drawing.Point(16, 164);
            this.txtDefaultTol.Name = "txtDefaultTol";
            this.txtDefaultTol.Size = new System.Drawing.Size(40, 20);
            this.txtDefaultTol.TabIndex = 3;
            this.txtDefaultTol.Text = "0.1";
            // 
            // lblDefaultTol
            // 
            this.lblDefaultTol.AutoSize = true;
            this.lblDefaultTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultTol.Location = new System.Drawing.Point(62, 164);
            this.lblDefaultTol.Name = "lblDefaultTol";
            this.lblDefaultTol.Size = new System.Drawing.Size(206, 20);
            this.lblDefaultTol.TabIndex = 4;
            this.lblDefaultTol.Text = "Default symmetric tolerance";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 220);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Directions: \r\nEnter a + to use symmetric tolerance mode\r\nEnter a - to use deviati" +
    "on tolerance mode";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDefaultTol);
            this.Controls.Add(this.txtDefaultTol);
            this.Controls.Add(this.lblDecPlaces);
            this.Controls.Add(this.cmbDecPlaces);
            this.Controls.Add(this.chkConvert);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkConvert;
        private System.Windows.Forms.Label lblDecPlaces;
        public System.Windows.Forms.ComboBox cmbDecPlaces;
        private System.Windows.Forms.Label lblDefaultTol;
        public System.Windows.Forms.TextBox txtDefaultTol;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}