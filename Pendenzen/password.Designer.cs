namespace Pendenzen
{
    partial class password
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
            this.okButton = new System.Windows.Forms.Button();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.altesPasswort = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswortLabel = new System.Windows.Forms.Label();
            this.neuesPasswort = new System.Windows.Forms.TextBox();
            this.confirmPasswort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(128, 125);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Location = new System.Drawing.Point(46, 36);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(76, 13);
            this.oldPasswordLabel.TabIndex = 5;
            this.oldPasswordLabel.Text = "Altes Passwort";
            // 
            // altesPasswort
            // 
            this.altesPasswort.Location = new System.Drawing.Point(128, 33);
            this.altesPasswort.Name = "altesPasswort";
            this.altesPasswort.PasswordChar = '●';
            this.altesPasswort.Size = new System.Drawing.Size(100, 20);
            this.altesPasswort.TabIndex = 0;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(20, 88);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(102, 13);
            this.confirmPasswordLabel.TabIndex = 4;
            this.confirmPasswordLabel.Text = "Passwort bestätigen";
            // 
            // newPasswortLabel
            // 
            this.newPasswortLabel.AutoSize = true;
            this.newPasswortLabel.Location = new System.Drawing.Point(38, 62);
            this.newPasswortLabel.Name = "newPasswortLabel";
            this.newPasswortLabel.Size = new System.Drawing.Size(84, 13);
            this.newPasswortLabel.TabIndex = 3;
            this.newPasswortLabel.Text = "Neues Passwort";
            // 
            // neuesPasswort
            // 
            this.neuesPasswort.Location = new System.Drawing.Point(128, 59);
            this.neuesPasswort.Name = "neuesPasswort";
            this.neuesPasswort.PasswordChar = '●';
            this.neuesPasswort.Size = new System.Drawing.Size(100, 20);
            this.neuesPasswort.TabIndex = 1;
            // 
            // confirmPasswort
            // 
            this.confirmPasswort.Location = new System.Drawing.Point(128, 85);
            this.confirmPasswort.Name = "confirmPasswort";
            this.confirmPasswort.PasswordChar = '●';
            this.confirmPasswort.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswort.TabIndex = 2;
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 203);
            this.Controls.Add(this.confirmPasswort);
            this.Controls.Add(this.neuesPasswort);
            this.Controls.Add(this.newPasswortLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.altesPasswort);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.okButton);
            this.Icon = global::Pendenzen.Properties.Resources.favicon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "password";
            this.Text = "Passwort ändern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox altesPasswort;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label newPasswortLabel;
        private System.Windows.Forms.TextBox neuesPasswort;
        private System.Windows.Forms.TextBox confirmPasswort;
    }
}