using System.Windows.Forms;
using System.ComponentModel;

namespace PendenzenSetuper
{
    partial class Setuper
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private IContainer components = null;

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
        /// 
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mysqlInstalledCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Setup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createTables);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Test Requirenments";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(52, 80);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(38, 13);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(52, 154);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(52, 130);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(52, 105);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(82, 13);
            this.databaseLabel.TabIndex = 5;
            this.databaseLabel.Text = "Database name";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(155, 77);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(100, 20);
            this.serverTextBox.TabIndex = 6;
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Location = new System.Drawing.Point(155, 98);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.databaseTextBox.TabIndex = 7;
            // 
            // uidTextBox
            // 
            this.uidTextBox.Location = new System.Drawing.Point(155, 121);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(100, 20);
            this.uidTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(155, 147);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // mysqlInstalledCheck
            // 
            this.mysqlInstalledCheck.AutoSize = true;
            this.mysqlInstalledCheck.Enabled = false;
            this.mysqlInstalledCheck.Location = new System.Drawing.Point(408, 72);
            this.mysqlInstalledCheck.Name = "mysqlInstalledCheck";
            this.mysqlInstalledCheck.Size = new System.Drawing.Size(104, 17);
            this.mysqlInstalledCheck.TabIndex = 10;
            this.mysqlInstalledCheck.Text = "MySQL installiert";
            this.mysqlInstalledCheck.UseVisualStyleBackColor = true;
            // 
            // Setuper
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.mysqlInstalledCheck);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.uidTextBox);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Setuper";
            this.Text = "Pendenzen Server Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button button1;
        private Button button2;
        private Label serverLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label databaseLabel;
        private TextBox serverTextBox;
        private TextBox databaseTextBox;
        private TextBox uidTextBox;
        private TextBox passwordTextBox;
        private CheckBox mysqlInstalledCheck;
    }
}