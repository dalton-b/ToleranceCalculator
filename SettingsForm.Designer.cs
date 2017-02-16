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
            this.SuspendLayout();
            // 
            // chkConvert
            // 
            this.chkConvert.AutoSize = true;
            this.chkConvert.Checked = true;
            this.chkConvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConvert.Location = new System.Drawing.Point(24, 25);
            this.chkConvert.Name = "chkConvert";
            this.chkConvert.Size = new System.Drawing.Size(128, 17);
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
            this.cmbDecPlaces.Location = new System.Drawing.Point(24, 65);
            this.cmbDecPlaces.Name = "cmbDecPlaces";
            this.cmbDecPlaces.Size = new System.Drawing.Size(40, 21);
            this.cmbDecPlaces.TabIndex = 1;
            this.cmbDecPlaces.SelectedIndex = 3;
            // 
            // lblDecPlaces
            // 
            this.lblDecPlaces.AutoSize = true;
            this.lblDecPlaces.Location = new System.Drawing.Point(81, 68);
            this.lblDecPlaces.Name = "lblDecPlaces";
            this.lblDecPlaces.Size = new System.Drawing.Size(127, 13);
            this.lblDecPlaces.TabIndex = 2;
            this.lblDecPlaces.Text = "Decimal places in answer";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDecPlaces);
            this.Controls.Add(this.cmbDecPlaces);
            this.Controls.Add(this.chkConvert);
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
    }
}