namespace Pendenzen
{
    partial class addCompany
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
            this.submitButton = new System.Windows.Forms.Button();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.companyIDTextBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.companyIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(140, 25);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 25);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Bestätigen";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(15, 75);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(200, 20);
            this.companyTextBox.TabIndex = 1;
            // 
            // companyIDTextBox
            // 
            this.companyIDTextBox.Location = new System.Drawing.Point(15, 30);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyIDTextBox.TabIndex = 0;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(15, 60);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(35, 15);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Firma";
            // 
            // companyIDLabel
            // 
            this.companyIDLabel.AutoSize = true;
            this.companyIDLabel.Location = new System.Drawing.Point(15, 15);
            this.companyIDLabel.Name = "companyIDLabel";
            this.companyIDLabel.Size = new System.Drawing.Size(35, 15);
            this.companyIDLabel.TabIndex = 0;
            this.companyIDLabel.Text = "Kürzel";
            // 
            // addCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 105);
            this.Controls.Add(this.companyIDLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.companyIDTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "addCompany";
            this.Text = "Firma hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox companyIDTextBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label companyIDLabel;
    }
}