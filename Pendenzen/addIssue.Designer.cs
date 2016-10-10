namespace Pendenzen
{
    partial class addIssue
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
            this.newIssueLabel = new System.Windows.Forms.Label();
            this.referenceLabel = new System.Windows.Forms.Label();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.documentTextBox = new System.Windows.Forms.TextBox();
            this.responsibleTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.documentLabel = new System.Windows.Forms.Label();
            this.responsibleLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.duePicker = new System.Windows.Forms.DateTimePicker();
            this.dueLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.companyBox = new System.Windows.Forms.ComboBox();
            this.helpTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // newIssueLabel
            // 
            this.newIssueLabel.AutoSize = true;
            this.newIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIssueLabel.Location = new System.Drawing.Point(13, 13);
            this.newIssueLabel.Name = "newIssueLabel";
            this.newIssueLabel.Size = new System.Drawing.Size(138, 24);
            this.newIssueLabel.TabIndex = 0;
            this.newIssueLabel.Text = "Neue Pendenz";
            // 
            // referenceLabel
            // 
            this.referenceLabel.AutoSize = true;
            this.referenceLabel.Location = new System.Drawing.Point(113, 95);
            this.referenceLabel.Name = "referenceLabel";
            this.referenceLabel.Size = new System.Drawing.Size(67, 13);
            this.referenceLabel.TabIndex = 1;
            this.referenceLabel.Text = "Referenz Nr.";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(353, 12);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompany.TabIndex = 2;
            this.btnAddCompany.Text = "Neue Firma";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(116, 115);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.referenceTextBox.TabIndex = 4;
            this.referenceTextBox.Enter += new System.EventHandler(this.referenceTextBox_Focused);
            // 
            // documentTextBox
            // 
            this.documentTextBox.Location = new System.Drawing.Point(222, 115);
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentTextBox.TabIndex = 5;
            this.documentTextBox.Enter += new System.EventHandler(this.documentTextBox_Focused);
            // 
            // responsibleTextBox
            // 
            this.responsibleTextBox.Location = new System.Drawing.Point(328, 115);
            this.responsibleTextBox.MaxLength = 5;
            this.responsibleTextBox.Name = "responsibleTextBox";
            this.responsibleTextBox.Size = new System.Drawing.Size(100, 20);
            this.responsibleTextBox.TabIndex = 6;
            this.responsibleTextBox.Enter += new System.EventHandler(this.responsibleTextBox_Focused);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsTextBox.Location = new System.Drawing.Point(17, 198);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(409, 20);
            this.detailsTextBox.TabIndex = 7;
            this.detailsTextBox.Enter += new System.EventHandler(this.detailsTextBox_Focused);
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(13, 41);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(122, 13);
            this.creatorLabel.TabIndex = 8;
            this.creatorLabel.Text = "Erfasser: Bob Meierhans";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(13, 95);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(32, 13);
            this.companyLabel.TabIndex = 9;
            this.companyLabel.Text = "Firma";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 57);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(98, 13);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Datum: 01.01.2016";
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Location = new System.Drawing.Point(222, 95);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(34, 13);
            this.documentLabel.TabIndex = 11;
            this.documentLabel.Text = "Beleg";
            // 
            // responsibleLabel
            // 
            this.responsibleLabel.AutoSize = true;
            this.responsibleLabel.Location = new System.Drawing.Point(328, 95);
            this.responsibleLabel.Name = "responsibleLabel";
            this.responsibleLabel.Size = new System.Drawing.Size(78, 13);
            this.responsibleLabel.TabIndex = 12;
            this.responsibleLabel.Text = "zuständiger SB";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(17, 182);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(39, 13);
            this.detailLabel.TabIndex = 13;
            this.detailLabel.Text = "Details";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(349, 224);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "OK";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // duePicker
            // 
            this.duePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duePicker.Location = new System.Drawing.Point(17, 159);
            this.duePicker.Name = "duePicker";
            this.duePicker.Size = new System.Drawing.Size(93, 20);
            this.duePicker.TabIndex = 15;
            this.duePicker.Enter += new System.EventHandler(this.duePicker_Focused);
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Location = new System.Drawing.Point(17, 143);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(51, 13);
            this.dueLabel.TabIndex = 16;
            this.dueLabel.Text = "Fällig am:";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(14, 221);
            this.errorLabel.MaximumSize = new System.Drawing.Size(411, 26);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(86, 13);
            this.errorLabel.TabIndex = 17;
            this.errorLabel.Text = "error message";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.UseMnemonic = false;
            this.errorLabel.Visible = false;
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(17, 115);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(93, 21);
            this.companyBox.Sorted = true;
            this.companyBox.TabIndex = 3;
            this.companyBox.Enter += new System.EventHandler(this.companyBox_Focused);
            // 
            // helpTextBox
            // 
            this.helpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.helpTextBox.Location = new System.Drawing.Point(12, 253);
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.helpTextBox.Size = new System.Drawing.Size(416, 141);
            this.helpTextBox.TabIndex = 25;
            this.helpTextBox.Text = "";
            // 
            // addIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 406);
            this.Controls.Add(this.helpTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.duePicker);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.responsibleLabel);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.responsibleTextBox);
            this.Controls.Add(this.documentTextBox);
            this.Controls.Add(this.referenceTextBox);
            this.Controls.Add(this.companyBox);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.referenceLabel);
            this.Controls.Add(this.newIssueLabel);
            this.Name = "addIssue";
            this.Text = "Neue Pendenz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newIssueLabel;
        private System.Windows.Forms.Label referenceLabel;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.TextBox documentTextBox;
        private System.Windows.Forms.TextBox responsibleTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label documentLabel;
        private System.Windows.Forms.Label responsibleLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker duePicker;
        private System.Windows.Forms.Label dueLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox companyBox;
        private System.Windows.Forms.RichTextBox helpTextBox;
    }
}