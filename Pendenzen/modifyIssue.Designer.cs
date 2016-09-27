using System.Windows.Forms;

namespace Pendenzen
{
    partial class modifyIssue
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
            this.changeIssueLabel = new System.Windows.Forms.Label();
            this.referenceLabel = new System.Windows.Forms.Label();
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
            this.changeButton = new System.Windows.Forms.Button();
            this.duePicker = new System.Windows.Forms.DateTimePicker();
            this.dueLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.companyBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // changeIssueLabel
            // 
            this.changeIssueLabel.AutoSize = true;
            this.changeIssueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeIssueLabel.Location = new System.Drawing.Point(13, 10);
            this.changeIssueLabel.Name = "changeIssueLabel";
            this.changeIssueLabel.Size = new System.Drawing.Size(181, 24);
            this.changeIssueLabel.TabIndex = 0;
            this.changeIssueLabel.Text = "Pendenz bearbeiten";
            // 
            // referenceLabel
            // 
            this.referenceLabel.AutoSize = true;
            this.referenceLabel.Location = new System.Drawing.Point(109, 105);
            this.referenceLabel.Name = "referenceLabel";
            this.referenceLabel.Size = new System.Drawing.Size(67, 13);
            this.referenceLabel.TabIndex = 1;
            this.referenceLabel.Text = "Referenz Nr.";
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(112, 121);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.referenceTextBox.TabIndex = 4;
            // 
            // documentTextBox
            // 
            this.documentTextBox.Location = new System.Drawing.Point(218, 121);
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentTextBox.TabIndex = 5;
            // 
            // responsibleTextBox
            // 
            this.responsibleTextBox.Location = new System.Drawing.Point(324, 121);
            this.responsibleTextBox.Name = "responsibleTextBox";
            this.responsibleTextBox.Size = new System.Drawing.Size(100, 20);
            this.responsibleTextBox.TabIndex = 6;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(13, 233);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(411, 20);
            this.detailsTextBox.TabIndex = 7;
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(13, 54);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(122, 13);
            this.creatorLabel.TabIndex = 8;
            this.creatorLabel.Text = "Erfasser: Bob Meierhans";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(14, 105);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(32, 13);
            this.companyLabel.TabIndex = 9;
            this.companyLabel.Text = "Firma";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(14, 76);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(98, 13);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Datum: 01.01.2016";
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Location = new System.Drawing.Point(215, 105);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(34, 13);
            this.documentLabel.TabIndex = 11;
            this.documentLabel.Text = "Beleg";
            // 
            // responsibleLabel
            // 
            this.responsibleLabel.AutoSize = true;
            this.responsibleLabel.Location = new System.Drawing.Point(321, 105);
            this.responsibleLabel.Name = "responsibleLabel";
            this.responsibleLabel.Size = new System.Drawing.Size(78, 13);
            this.responsibleLabel.TabIndex = 12;
            this.responsibleLabel.Text = "zuständiger SB";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(14, 205);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(39, 13);
            this.detailLabel.TabIndex = 13;
            this.detailLabel.Text = "Details";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(164, 410);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "OK";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // duePicker
            // 
            this.duePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duePicker.Location = new System.Drawing.Point(17, 182);
            this.duePicker.Name = "duePicker";
            this.duePicker.Size = new System.Drawing.Size(93, 20);
            this.duePicker.TabIndex = 15;
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Location = new System.Drawing.Point(14, 166);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(51, 13);
            this.dueLabel.TabIndex = 16;
            this.dueLabel.Text = "Fällig am:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(26, 361);
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
            this.companyBox.Location = new System.Drawing.Point(13, 121);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(93, 21);
            this.companyBox.Sorted = true;
            this.companyBox.TabIndex = 3;
            // 
            // modifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 494);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.dueLabel);
            this.Controls.Add(this.duePicker);
            this.Controls.Add(this.changeButton);
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
            this.Controls.Add(this.referenceLabel);
            this.Controls.Add(this.changeIssueLabel);
            this.Name = "modifyIssue";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "modifyIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label changeIssueLabel;
        private Label referenceLabel;
        private TextBox referenceTextBox;
        private TextBox documentTextBox;
        private TextBox responsibleTextBox;
        private TextBox detailsTextBox;
        private Label creatorLabel;
        private Label companyLabel;
        private Label dateLabel;
        private Label documentLabel;
        private Label responsibleLabel;
        private Label detailLabel;
        private Button changeButton;
        private DateTimePicker duePicker;
        private Label dueLabel;
        private Label errorLabel;
        private ComboBox companyBox;
    }
}