namespace Pendenzen
{
    partial class reorganisation
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
            this.startButton = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.openOnly = new System.Windows.Forms.CheckBox();
            this.olderThanLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(150, 163);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dateBox
            // 
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(108, 12);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(62, 21);
            this.dateBox.TabIndex = 1;
            this.dateBox.SelectedIndexChanged += new System.EventHandler(this.dateBox_SelectedIndexChanged);
            // 
            // openOnly
            // 
            this.openOnly.AutoSize = true;
            this.openOnly.Checked = true;
            this.openOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openOnly.Location = new System.Drawing.Point(57, 52);
            this.openOnly.Name = "openOnly";
            this.openOnly.Size = new System.Drawing.Size(142, 17);
            this.openOnly.TabIndex = 2;
            this.openOnly.Text = "ohne Offene Pendenzen";
            this.openOnly.UseVisualStyleBackColor = true;
            // 
            // olderThanLabel
            // 
            this.olderThanLabel.AutoSize = true;
            this.olderThanLabel.Location = new System.Drawing.Point(12, 15);
            this.olderThanLabel.Name = "olderThanLabel";
            this.olderThanLabel.Size = new System.Drawing.Size(90, 13);
            this.olderThanLabel.TabIndex = 3;
            this.olderThanLabel.Text = "Löschen älter als:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(70, 128);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\u25CF';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // monthsLabel
            // 
            this.monthsLabel.AutoSize = true;
            this.monthsLabel.Location = new System.Drawing.Point(176, 15);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(43, 13);
            this.monthsLabel.TabIndex = 5;
            this.monthsLabel.Text = "Monate";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 131);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Kennwort";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.infoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoLabel.Enabled = false;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 72);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(59, 13);
            this.infoLabel.TabIndex = 20;
            this.infoLabel.Text = "infoLabel";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.Visible = false;
            // 
            // reorganisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 212);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.monthsLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.olderThanLabel);
            this.Controls.Add(this.openOnly);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.startButton);
            this.Icon = global::Pendenzen.Properties.Resources.favicon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reorganisation";
            this.Text = "Reorganisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.CheckBox openOnly;
        private System.Windows.Forms.Label olderThanLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label monthsLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}