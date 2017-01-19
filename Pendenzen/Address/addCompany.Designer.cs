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
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.poBoxLabel = new System.Windows.Forms.Label();
            this.poBoxTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.plzTextBox = new System.Windows.Forms.TextBox();
            this.coutryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.einkaufEmailLabel = new System.Windows.Forms.Label();
            this.emailEinkaufTextBox = new System.Windows.Forms.TextBox();
            this.verkaufEmailLabel = new System.Windows.Forms.Label();
            this.emailVerkaufTextBox = new System.Windows.Forms.TextBox();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.kontaktLabel = new System.Windows.Forms.Label();
            this.verkaufKontaktCheck = new System.Windows.Forms.CheckBox();
            this.einkaufKontaktCheck = new System.Windows.Forms.CheckBox();
            this.verkaufBusproCheck = new System.Windows.Forms.CheckBox();
            this.neukundeVerkaufCheck = new System.Windows.Forms.CheckBox();
            this.neukundeEinkaufCheck = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.einkaufBusproCheck = new System.Windows.Forms.CheckBox();
            this.copyMailCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(493, 238);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 25);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Bestätigen";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(13, 75);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(200, 20);
            this.companyTextBox.TabIndex = 1;
            // 
            // companyIDTextBox
            // 
            this.companyIDTextBox.Location = new System.Drawing.Point(13, 26);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyIDTextBox.TabIndex = 0;
            this.companyIDTextBox.Leave += new System.EventHandler(this.getCountry);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(12, 59);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(32, 13);
            this.companyLabel.TabIndex = 29;
            this.companyLabel.Text = "Firma";
            // 
            // companyIDLabel
            // 
            this.companyIDLabel.AutoSize = true;
            this.companyIDLabel.Location = new System.Drawing.Point(12, 10);
            this.companyIDLabel.Name = "companyIDLabel";
            this.companyIDLabel.Size = new System.Drawing.Size(36, 13);
            this.companyIDLabel.TabIndex = 28;
            this.companyIDLabel.Text = "Kürzel";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(12, 98);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(42, 13);
            this.streetLabel.TabIndex = 27;
            this.streetLabel.Text = "Strasse";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(13, 114);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(200, 20);
            this.streetTextBox.TabIndex = 2;
            // 
            // poBoxLabel
            // 
            this.poBoxLabel.AutoSize = true;
            this.poBoxLabel.Location = new System.Drawing.Point(12, 137);
            this.poBoxLabel.Name = "poBoxLabel";
            this.poBoxLabel.Size = new System.Drawing.Size(49, 13);
            this.poBoxLabel.TabIndex = 26;
            this.poBoxLabel.Text = "Postfach";
            // 
            // poBoxTextBox
            // 
            this.poBoxTextBox.Location = new System.Drawing.Point(13, 153);
            this.poBoxTextBox.Name = "poBoxTextBox";
            this.poBoxTextBox.Size = new System.Drawing.Size(200, 20);
            this.poBoxTextBox.TabIndex = 3;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(10, 176);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(27, 13);
            this.zipLabel.TabIndex = 25;
            this.zipLabel.Text = "PLZ";
            // 
            // plzTextBox
            // 
            this.plzTextBox.Location = new System.Drawing.Point(13, 192);
            this.plzTextBox.Name = "plzTextBox";
            this.plzTextBox.Size = new System.Drawing.Size(49, 20);
            this.plzTextBox.TabIndex = 4;
            // 
            // coutryLabel
            // 
            this.coutryLabel.AutoSize = true;
            this.coutryLabel.Location = new System.Drawing.Point(12, 215);
            this.coutryLabel.Name = "coutryLabel";
            this.coutryLabel.Size = new System.Drawing.Size(31, 13);
            this.coutryLabel.TabIndex = 23;
            this.coutryLabel.Text = "Land";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(13, 231);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 20);
            this.countryTextBox.TabIndex = 24;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(249, 59);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(43, 13);
            this.phoneLabel.TabIndex = 22;
            this.phoneLabel.Text = "Telefon";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(252, 75);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(65, 176);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(32, 13);
            this.cityLabel.TabIndex = 21;
            this.cityLabel.Text = "Stadt";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(68, 192);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(145, 20);
            this.cityTextBox.TabIndex = 5;
            // 
            // einkaufEmailLabel
            // 
            this.einkaufEmailLabel.AutoSize = true;
            this.einkaufEmailLabel.Location = new System.Drawing.Point(249, 215);
            this.einkaufEmailLabel.Name = "einkaufEmailLabel";
            this.einkaufEmailLabel.Size = new System.Drawing.Size(71, 13);
            this.einkaufEmailLabel.TabIndex = 20;
            this.einkaufEmailLabel.Text = "Email Einkauf";
            // 
            // emailEinkaufTextBox
            // 
            this.emailEinkaufTextBox.Location = new System.Drawing.Point(252, 231);
            this.emailEinkaufTextBox.Name = "emailEinkaufTextBox";
            this.emailEinkaufTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailEinkaufTextBox.TabIndex = 10;
            // 
            // verkaufEmailLabel
            // 
            this.verkaufEmailLabel.AutoSize = true;
            this.verkaufEmailLabel.Location = new System.Drawing.Point(249, 137);
            this.verkaufEmailLabel.Name = "verkaufEmailLabel";
            this.verkaufEmailLabel.Size = new System.Drawing.Size(72, 13);
            this.verkaufEmailLabel.TabIndex = 19;
            this.verkaufEmailLabel.Text = "Email Verkauf";
            // 
            // emailVerkaufTextBox
            // 
            this.emailVerkaufTextBox.Location = new System.Drawing.Point(252, 153);
            this.emailVerkaufTextBox.Name = "emailVerkaufTextBox";
            this.emailVerkaufTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailVerkaufTextBox.TabIndex = 8;
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(249, 98);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(46, 13);
            this.websiteLabel.TabIndex = 18;
            this.websiteLabel.Text = "Website";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(252, 114);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(200, 20);
            this.urlTextBox.TabIndex = 7;
            // 
            // kontaktLabel
            // 
            this.kontaktLabel.AutoSize = true;
            this.kontaktLabel.Location = new System.Drawing.Point(490, 10);
            this.kontaktLabel.Name = "kontaktLabel";
            this.kontaktLabel.Size = new System.Drawing.Size(56, 13);
            this.kontaktLabel.TabIndex = 17;
            this.kontaktLabel.Text = "In Kontakt";
            // 
            // verkaufKontaktCheck
            // 
            this.verkaufKontaktCheck.AutoSize = true;
            this.verkaufKontaktCheck.Location = new System.Drawing.Point(493, 26);
            this.verkaufKontaktCheck.Name = "verkaufKontaktCheck";
            this.verkaufKontaktCheck.Size = new System.Drawing.Size(63, 17);
            this.verkaufKontaktCheck.TabIndex = 11;
            this.verkaufKontaktCheck.Text = "Verkauf";
            this.verkaufKontaktCheck.UseVisualStyleBackColor = true;
            // 
            // einkaufKontaktCheck
            // 
            this.einkaufKontaktCheck.AutoSize = true;
            this.einkaufKontaktCheck.Location = new System.Drawing.Point(493, 49);
            this.einkaufKontaktCheck.Name = "einkaufKontaktCheck";
            this.einkaufKontaktCheck.Size = new System.Drawing.Size(62, 17);
            this.einkaufKontaktCheck.TabIndex = 12;
            this.einkaufKontaktCheck.Text = "Einkauf";
            this.einkaufKontaktCheck.UseVisualStyleBackColor = true;
            // 
            // verkaufBusproCheck
            // 
            this.verkaufBusproCheck.AutoSize = true;
            this.verkaufBusproCheck.Location = new System.Drawing.Point(493, 114);
            this.verkaufBusproCheck.Name = "verkaufBusproCheck";
            this.verkaufBusproCheck.Size = new System.Drawing.Size(63, 17);
            this.verkaufBusproCheck.TabIndex = 13;
            this.verkaufBusproCheck.Text = "Verkauf";
            this.verkaufBusproCheck.UseVisualStyleBackColor = true;
            // 
            // neukundeVerkaufCheck
            // 
            this.neukundeVerkaufCheck.AutoSize = true;
            this.neukundeVerkaufCheck.Location = new System.Drawing.Point(493, 192);
            this.neukundeVerkaufCheck.Name = "neukundeVerkaufCheck";
            this.neukundeVerkaufCheck.Size = new System.Drawing.Size(63, 17);
            this.neukundeVerkaufCheck.TabIndex = 15;
            this.neukundeVerkaufCheck.Text = "Verkauf";
            this.neukundeVerkaufCheck.UseVisualStyleBackColor = true;
            this.neukundeVerkaufCheck.CheckStateChanged += new System.EventHandler(this.neukundeVerkauf_Checked);
            // 
            // neukundeEinkaufCheck
            // 
            this.neukundeEinkaufCheck.AutoSize = true;
            this.neukundeEinkaufCheck.Location = new System.Drawing.Point(493, 215);
            this.neukundeEinkaufCheck.Name = "neukundeEinkaufCheck";
            this.neukundeEinkaufCheck.Size = new System.Drawing.Size(62, 17);
            this.neukundeEinkaufCheck.TabIndex = 16;
            this.neukundeEinkaufCheck.Text = "Einkauf";
            this.neukundeEinkaufCheck.UseVisualStyleBackColor = true;
            this.neukundeEinkaufCheck.CheckStateChanged += new System.EventHandler(this.neukundeEinkauf_Checked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(490, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Im Buspro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ist Neukunde";
            // 
            // einkaufBusproCheck
            // 
            this.einkaufBusproCheck.AutoSize = true;
            this.einkaufBusproCheck.Location = new System.Drawing.Point(493, 137);
            this.einkaufBusproCheck.Name = "einkaufBusproCheck";
            this.einkaufBusproCheck.Size = new System.Drawing.Size(62, 17);
            this.einkaufBusproCheck.TabIndex = 14;
            this.einkaufBusproCheck.Text = "Einkauf";
            this.einkaufBusproCheck.UseVisualStyleBackColor = true;
            // 
            // copyMailCheck
            // 
            this.copyMailCheck.AutoSize = true;
            this.copyMailCheck.Location = new System.Drawing.Point(252, 195);
            this.copyMailCheck.Name = "copyMailCheck";
            this.copyMailCheck.Size = new System.Drawing.Size(96, 17);
            this.copyMailCheck.TabIndex = 9;
            this.copyMailCheck.Text = "Email Kopieren";
            this.copyMailCheck.UseVisualStyleBackColor = true;
            this.copyMailCheck.CheckStateChanged += new System.EventHandler(this.copyMailCheck_CheckStateChanged);
            // 
            // addCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(591, 287);
            this.Controls.Add(this.copyMailCheck);
            this.Controls.Add(this.einkaufBusproCheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.neukundeEinkaufCheck);
            this.Controls.Add(this.neukundeVerkaufCheck);
            this.Controls.Add(this.verkaufBusproCheck);
            this.Controls.Add(this.einkaufKontaktCheck);
            this.Controls.Add(this.verkaufKontaktCheck);
            this.Controls.Add(this.kontaktLabel);
            this.Controls.Add(this.websiteLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.verkaufEmailLabel);
            this.Controls.Add(this.emailVerkaufTextBox);
            this.Controls.Add(this.einkaufEmailLabel);
            this.Controls.Add(this.emailEinkaufTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.coutryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.plzTextBox);
            this.Controls.Add(this.poBoxLabel);
            this.Controls.Add(this.poBoxTextBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.companyIDLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.companyIDTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.submitButton);
            this.Icon = global::Pendenzen.Properties.Resources.favicon;
            this.Name = "addCompany";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Firma hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label companyIDLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label poBoxLabel;
        private System.Windows.Forms.TextBox poBoxTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox plzTextBox;
        private System.Windows.Forms.Label coutryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label einkaufEmailLabel;
        private System.Windows.Forms.TextBox emailEinkaufTextBox;
        private System.Windows.Forms.Label verkaufEmailLabel;
        private System.Windows.Forms.TextBox emailVerkaufTextBox;
        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label kontaktLabel;
        private System.Windows.Forms.CheckBox verkaufKontaktCheck;
        private System.Windows.Forms.CheckBox einkaufKontaktCheck;
        private System.Windows.Forms.CheckBox verkaufBusproCheck;
        private System.Windows.Forms.CheckBox neukundeVerkaufCheck;
        private System.Windows.Forms.CheckBox neukundeEinkaufCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox einkaufBusproCheck;
        private System.Windows.Forms.CheckBox copyMailCheck;
        protected internal System.Windows.Forms.TextBox companyIDTextBox;
    }
}