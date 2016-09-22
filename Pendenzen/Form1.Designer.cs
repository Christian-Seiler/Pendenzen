namespace Pendenzen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.firmaComboBox = new System.Windows.Forms.ComboBox();
            this.firmaLabel = new System.Windows.Forms.Label();
            this.referenzTextBox = new System.Windows.Forms.TextBox();
            this.referenzLabel = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(112, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name: Bob Meierhans";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Pendenzen.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(13, 13);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(187, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // firmaComboBox
            // 
            this.firmaComboBox.FormattingEnabled = true;
            this.firmaComboBox.Location = new System.Drawing.Point(13, 107);
            this.firmaComboBox.Name = "firmaComboBox";
            this.firmaComboBox.Size = new System.Drawing.Size(121, 21);
            this.firmaComboBox.TabIndex = 2;
            // 
            // firmaLabel
            // 
            this.firmaLabel.AutoSize = true;
            this.firmaLabel.Location = new System.Drawing.Point(15, 91);
            this.firmaLabel.Name = "firmaLabel";
            this.firmaLabel.Size = new System.Drawing.Size(32, 13);
            this.firmaLabel.TabIndex = 3;
            this.firmaLabel.Text = "Firma";
            // 
            // referenzTextBox
            // 
            this.referenzTextBox.Location = new System.Drawing.Point(141, 107);
            this.referenzTextBox.Name = "referenzTextBox";
            this.referenzTextBox.Size = new System.Drawing.Size(150, 20);
            this.referenzTextBox.TabIndex = 4;
            // 
            // referenzLabel
            // 
            this.referenzLabel.AutoSize = true;
            this.referenzLabel.Location = new System.Drawing.Point(141, 90);
            this.referenzLabel.Name = "referenzLabel";
            this.referenzLabel.Size = new System.Drawing.Size(67, 13);
            this.referenzLabel.TabIndex = 5;
            this.referenzLabel.Text = "Referenz-Nr.";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(893, 13);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(13, 134);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(122, 23);
            this.btnAddCompany.TabIndex = 7;
            this.btnAddCompany.Text = "Firma hinzufügen";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 593);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.referenzLabel);
            this.Controls.Add(this.referenzTextBox);
            this.Controls.Add(this.firmaLabel);
            this.Controls.Add(this.firmaComboBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.ComboBox firmaComboBox;
        private System.Windows.Forms.Label firmaLabel;
        private System.Windows.Forms.TextBox referenzTextBox;
        private System.Windows.Forms.Label referenzLabel;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAddCompany;
    }
}

