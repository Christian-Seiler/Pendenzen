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
            this.finalizedButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.RadioButton();
            this.historyLabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.RadioButton();
            this.historyTextBox = new System.Windows.Forms.RichTextBox();
            this.helpTextBox = new System.Windows.Forms.RichTextBox();
            this.openFilesButton = new System.Windows.Forms.Button();
            this.detailsFirmaButton = new System.Windows.Forms.Button();
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
            this.referenceTextBox.GotFocus += new System.EventHandler(this.referenceTextBox_Focused);
            // 
            // documentTextBox
            // 
            this.documentTextBox.Location = new System.Drawing.Point(218, 121);
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentTextBox.TabIndex = 5;
            this.documentTextBox.GotFocus += new System.EventHandler(this.documentTextBox_Focused);
            // 
            // responsibleTextBox
            // 
            this.responsibleTextBox.Location = new System.Drawing.Point(324, 121);
            this.responsibleTextBox.MaxLength = 5;
            this.responsibleTextBox.Name = "responsibleTextBox";
            this.responsibleTextBox.Size = new System.Drawing.Size(100, 20);
            this.responsibleTextBox.TabIndex = 6;
            this.responsibleTextBox.GotFocus += new System.EventHandler(this.responsibleTextBox_Focused);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsTextBox.Location = new System.Drawing.Point(13, 233);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(411, 20);
            this.detailsTextBox.TabIndex = 7;
            this.detailsTextBox.GotFocus += new System.EventHandler(this.detailsTextBox_Focused);
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
            this.detailLabel.Location = new System.Drawing.Point(14, 217);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(39, 13);
            this.detailLabel.TabIndex = 13;
            this.detailLabel.Text = "Details";
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.Location = new System.Drawing.Point(349, 452);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "OK";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // duePicker
            // 
            this.duePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duePicker.Location = new System.Drawing.Point(17, 182);
            this.duePicker.Name = "duePicker";
            this.duePicker.Size = new System.Drawing.Size(93, 20);
            this.duePicker.TabIndex = 15;
            this.duePicker.GotFocus += new System.EventHandler(this.duePicker_Focused);
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
            this.errorLabel.Location = new System.Drawing.Point(206, 416);
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
            this.companyBox.GotFocus += new System.EventHandler(this.companyBox_Focused);
            // 
            // finalizedButton
            // 
            this.finalizedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.finalizedButton.AutoSize = true;
            this.finalizedButton.Location = new System.Drawing.Point(9, 435);
            this.finalizedButton.Name = "finalizedButton";
            this.finalizedButton.Size = new System.Drawing.Size(97, 17);
            this.finalizedButton.TabIndex = 18;
            this.finalizedButton.Text = "Abgeschlossen";
            this.finalizedButton.UseVisualStyleBackColor = true;
            this.finalizedButton.CheckedChanged += new System.EventHandler(this.stateButton);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(10, 458);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 17);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Storniert";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.CheckedChanged += new System.EventHandler(this.stateButton);
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(13, 270);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(118, 13);
            this.historyLabel.TabIndex = 20;
            this.historyLabel.Text = "Unternommene Schritte";
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.AutoSize = true;
            this.openButton.Checked = true;
            this.openButton.Location = new System.Drawing.Point(9, 412);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(51, 17);
            this.openButton.TabIndex = 22;
            this.openButton.TabStop = true;
            this.openButton.Text = "Offen";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.CheckedChanged += new System.EventHandler(this.stateButton);
            // 
            // historyTextBox
            // 
            this.historyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.historyTextBox.Location = new System.Drawing.Point(13, 286);
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.Size = new System.Drawing.Size(411, 120);
            this.historyTextBox.TabIndex = 23;
            this.historyTextBox.Text = "";
            // 
            // helpTextBox
            // 
            this.helpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.helpTextBox.Location = new System.Drawing.Point(450, 105);
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.helpTextBox.Size = new System.Drawing.Size(188, 301);
            this.helpTextBox.TabIndex = 24;
            this.helpTextBox.Text = "";
            // 
            // openFilesButton
            // 
            this.openFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFilesButton.Location = new System.Drawing.Point(268, 452);
            this.openFilesButton.Name = "openFilesButton";
            this.openFilesButton.Size = new System.Drawing.Size(75, 23);
            this.openFilesButton.TabIndex = 25;
            this.openFilesButton.Text = "Dateien";
            this.openFilesButton.UseVisualStyleBackColor = true;
            this.openFilesButton.Click += new System.EventHandler(this.openFilesButton_Click);
            // 
            // detailsFirmaButton
            // 
            this.detailsFirmaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsFirmaButton.Location = new System.Drawing.Point(187, 452);
            this.detailsFirmaButton.Name = "detailsFirmaButton";
            this.detailsFirmaButton.Size = new System.Drawing.Size(75, 23);
            this.detailsFirmaButton.TabIndex = 26;
            this.detailsFirmaButton.Text = "Details Firma";
            this.detailsFirmaButton.UseVisualStyleBackColor = true;
            this.detailsFirmaButton.Click += new System.EventHandler(this.detailsFirmaButton_Click);
            // 
            // modifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 494);
            this.Controls.Add(this.detailsFirmaButton);
            this.Controls.Add(this.openFilesButton);
            this.Controls.Add(this.helpTextBox);
            this.Controls.Add(this.historyTextBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.finalizedButton);
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
            this.Icon = global::Pendenzen.Properties.Resources.favicon;
            this.Name = "modifyIssue";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Pendenz bearbeiten";
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
        private RadioButton finalizedButton;
        private RadioButton cancelButton;
        private Label historyLabel;
        private RadioButton openButton;
        private RichTextBox historyTextBox;
        private RichTextBox helpTextBox;
        private Button openFilesButton;
        private Button detailsFirmaButton;
    }
}