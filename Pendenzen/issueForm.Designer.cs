﻿namespace Pendenzen
{
    partial class issueForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.issueDataView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchDropBox = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pendenzTab = new System.Windows.Forms.TabPage();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.openLinkButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.kundeLabel = new System.Windows.Forms.Label();
            this.verkaufBusproLabel = new System.Windows.Forms.Label();
            this.einkaufBusproLabel = new System.Windows.Forms.Label();
            this.busproLabel = new System.Windows.Forms.Label();
            this.verkaufKontaktLabel = new System.Windows.Forms.Label();
            this.einkaufKontaktLabel = new System.Windows.Forms.Label();
            this.kontaktLabel = new System.Windows.Forms.Label();
            this.emailVerkaufLabel = new System.Windows.Forms.Label();
            this.emailEinkaufLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.companyChangeLabel = new System.Windows.Forms.Button();
            this.plzLabel = new System.Windows.Forms.Label();
            this.poBoxLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuePendenzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueAdresseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pendenzTab.SuspendLayout();
            this.companyTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: Bob Meierhans";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Pendenzen.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(17, 37);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(180, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 137);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(69, 25);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Neu";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(708, 157);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(108, 20);
            this.searchBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(919, 152);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 25);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // issueDataView
            // 
            this.issueDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.issueDataView.Cursor = System.Windows.Forms.Cursors.Default;
            this.issueDataView.Location = new System.Drawing.Point(0, 0);
            this.issueDataView.Name = "issueDataView";
            this.issueDataView.ReadOnly = true;
            this.issueDataView.ShowEditingIcon = false;
            this.issueDataView.Size = new System.Drawing.Size(1068, 436);
            this.issueDataView.TabIndex = 12;
            this.issueDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueDataView_CellClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(1014, 153);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchDropBox
            // 
            this.searchDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDropBox.FormattingEnabled = true;
            this.searchDropBox.Location = new System.Drawing.Point(822, 156);
            this.searchDropBox.Name = "searchDropBox";
            this.searchDropBox.Size = new System.Drawing.Size(91, 21);
            this.searchDropBox.TabIndex = 14;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.pendenzTab);
            this.tabControl.Controls.Add(this.companyTab);
            this.tabControl.Location = new System.Drawing.Point(13, 183);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1076, 462);
            this.tabControl.TabIndex = 15;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // pendenzTab
            // 
            this.pendenzTab.Controls.Add(this.issueDataView);
            this.pendenzTab.Location = new System.Drawing.Point(4, 22);
            this.pendenzTab.Name = "pendenzTab";
            this.pendenzTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendenzTab.Size = new System.Drawing.Size(1068, 436);
            this.pendenzTab.TabIndex = 0;
            this.pendenzTab.Text = "Pendenzen";
            this.pendenzTab.UseVisualStyleBackColor = true;
            // 
            // companyTab
            // 
            this.companyTab.Controls.Add(this.nextButton);
            this.companyTab.Controls.Add(this.previousButton);
            this.companyTab.Controls.Add(this.countLabel);
            this.companyTab.Controls.Add(this.openLinkButton);
            this.companyTab.Controls.Add(this.richTextBox1);
            this.companyTab.Controls.Add(this.kundeLabel);
            this.companyTab.Controls.Add(this.verkaufBusproLabel);
            this.companyTab.Controls.Add(this.einkaufBusproLabel);
            this.companyTab.Controls.Add(this.busproLabel);
            this.companyTab.Controls.Add(this.verkaufKontaktLabel);
            this.companyTab.Controls.Add(this.einkaufKontaktLabel);
            this.companyTab.Controls.Add(this.kontaktLabel);
            this.companyTab.Controls.Add(this.emailVerkaufLabel);
            this.companyTab.Controls.Add(this.emailEinkaufLabel);
            this.companyTab.Controls.Add(this.urlLabel);
            this.companyTab.Controls.Add(this.phoneLabel);
            this.companyTab.Controls.Add(this.countryLabel);
            this.companyTab.Controls.Add(this.cityLabel);
            this.companyTab.Controls.Add(this.companyChangeLabel);
            this.companyTab.Controls.Add(this.plzLabel);
            this.companyTab.Controls.Add(this.poBoxLabel);
            this.companyTab.Controls.Add(this.streetLabel);
            this.companyTab.Controls.Add(this.companyLabel);
            this.companyTab.Controls.Add(this.idLabel);
            this.companyTab.Location = new System.Drawing.Point(4, 22);
            this.companyTab.Name = "companyTab";
            this.companyTab.Padding = new System.Windows.Forms.Padding(3);
            this.companyTab.Size = new System.Drawing.Size(1068, 436);
            this.companyTab.TabIndex = 1;
            this.companyTab.Text = "Adressen";
            this.companyTab.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(400, 406);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 23);
            this.nextButton.TabIndex = 25;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(280, 406);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(23, 23);
            this.previousButton.TabIndex = 24;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(331, 411);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(43, 13);
            this.countLabel.TabIndex = 23;
            this.countLabel.Text = "1 von 1";
            // 
            // openLinkButton
            // 
            this.openLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openLinkButton.Location = new System.Drawing.Point(134, 406);
            this.openLinkButton.Name = "openLinkButton";
            this.openLinkButton.Size = new System.Drawing.Size(75, 23);
            this.openLinkButton.TabIndex = 22;
            this.openLinkButton.Text = "Link öffnen";
            this.openLinkButton.UseVisualStyleBackColor = true;
            this.openLinkButton.Click += new System.EventHandler(this.openLinkButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(691, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 423);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // kundeLabel
            // 
            this.kundeLabel.AutoSize = true;
            this.kundeLabel.Location = new System.Drawing.Point(448, 30);
            this.kundeLabel.Name = "kundeLabel";
            this.kundeLabel.Size = new System.Drawing.Size(107, 13);
            this.kundeLabel.TabIndex = 20;
            this.kundeLabel.Text = "Kunde seit Jan. 1970";
            // 
            // verkaufBusproLabel
            // 
            this.verkaufBusproLabel.AutoSize = true;
            this.verkaufBusproLabel.Location = new System.Drawing.Point(449, 230);
            this.verkaufBusproLabel.Name = "verkaufBusproLabel";
            this.verkaufBusproLabel.Size = new System.Drawing.Size(72, 13);
            this.verkaufBusproLabel.TabIndex = 19;
            this.verkaufBusproLabel.Text = "Verkauf: Nein";
            // 
            // einkaufBusproLabel
            // 
            this.einkaufBusproLabel.AutoSize = true;
            this.einkaufBusproLabel.Location = new System.Drawing.Point(449, 202);
            this.einkaufBusproLabel.Name = "einkaufBusproLabel";
            this.einkaufBusproLabel.Size = new System.Drawing.Size(71, 13);
            this.einkaufBusproLabel.TabIndex = 18;
            this.einkaufBusproLabel.Text = "Einkauf: Nein";
            // 
            // busproLabel
            // 
            this.busproLabel.AutoSize = true;
            this.busproLabel.Location = new System.Drawing.Point(448, 171);
            this.busproLabel.Name = "busproLabel";
            this.busproLabel.Size = new System.Drawing.Size(61, 13);
            this.busproLabel.TabIndex = 17;
            this.busproLabel.Text = "Im BusPro?";
            // 
            // verkaufKontaktLabel
            // 
            this.verkaufKontaktLabel.AutoSize = true;
            this.verkaufKontaktLabel.Location = new System.Drawing.Point(449, 117);
            this.verkaufKontaktLabel.Name = "verkaufKontaktLabel";
            this.verkaufKontaktLabel.Size = new System.Drawing.Size(72, 13);
            this.verkaufKontaktLabel.TabIndex = 16;
            this.verkaufKontaktLabel.Text = "Verkauf: Nein";
            // 
            // einkaufKontaktLabel
            // 
            this.einkaufKontaktLabel.AutoSize = true;
            this.einkaufKontaktLabel.Location = new System.Drawing.Point(449, 89);
            this.einkaufKontaktLabel.Name = "einkaufKontaktLabel";
            this.einkaufKontaktLabel.Size = new System.Drawing.Size(71, 13);
            this.einkaufKontaktLabel.TabIndex = 15;
            this.einkaufKontaktLabel.Text = "Einkauf: Nein";
            // 
            // kontaktLabel
            // 
            this.kontaktLabel.AutoSize = true;
            this.kontaktLabel.Location = new System.Drawing.Point(448, 58);
            this.kontaktLabel.Name = "kontaktLabel";
            this.kontaktLabel.Size = new System.Drawing.Size(47, 13);
            this.kontaktLabel.TabIndex = 14;
            this.kontaktLabel.Text = "Kontakt:";
            // 
            // emailVerkaufLabel
            // 
            this.emailVerkaufLabel.AutoSize = true;
            this.emailVerkaufLabel.Location = new System.Drawing.Point(242, 115);
            this.emailVerkaufLabel.Name = "emailVerkaufLabel";
            this.emailVerkaufLabel.Size = new System.Drawing.Size(93, 13);
            this.emailVerkaufLabel.TabIndex = 11;
            this.emailVerkaufLabel.Text = "verkauf@email.ch";
            // 
            // emailEinkaufLabel
            // 
            this.emailEinkaufLabel.AutoSize = true;
            this.emailEinkaufLabel.Location = new System.Drawing.Point(242, 90);
            this.emailEinkaufLabel.Name = "emailEinkaufLabel";
            this.emailEinkaufLabel.Size = new System.Drawing.Size(92, 13);
            this.emailEinkaufLabel.TabIndex = 10;
            this.emailEinkaufLabel.Text = "einkauf@email.ch";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(243, 58);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(116, 13);
            this.urlLabel.TabIndex = 9;
            this.urlLabel.Text = "http://www.website.ch";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(243, 30);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(39, 188);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(72, 162);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City";
            // 
            // companyChangeLabel
            // 
            this.companyChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.companyChangeLabel.Location = new System.Drawing.Point(6, 407);
            this.companyChangeLabel.Name = "companyChangeLabel";
            this.companyChangeLabel.Size = new System.Drawing.Size(75, 23);
            this.companyChangeLabel.TabIndex = 5;
            this.companyChangeLabel.Text = "Aktualisieren";
            this.companyChangeLabel.UseVisualStyleBackColor = true;
            this.companyChangeLabel.Click += new System.EventHandler(this.companyChangeLabel_Click);
            // 
            // plzLabel
            // 
            this.plzLabel.AutoSize = true;
            this.plzLabel.Location = new System.Drawing.Point(39, 162);
            this.plzLabel.Name = "plzLabel";
            this.plzLabel.Size = new System.Drawing.Size(27, 13);
            this.plzLabel.TabIndex = 4;
            this.plzLabel.Text = "PLZ";
            // 
            // poBoxLabel
            // 
            this.poBoxLabel.AutoSize = true;
            this.poBoxLabel.Location = new System.Drawing.Point(39, 129);
            this.poBoxLabel.Name = "poBoxLabel";
            this.poBoxLabel.Size = new System.Drawing.Size(49, 13);
            this.poBoxLabel.TabIndex = 3;
            this.poBoxLabel.Text = "P.O. Box";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(39, 91);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(35, 13);
            this.streetLabel.TabIndex = 2;
            this.streetLabel.Text = "Street";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(39, 58);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(51, 13);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Company";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(39, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "APW";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.schliessenToolStripMenuItem1});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuePendenzToolStripMenuItem,
            this.neueAdresseToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // neuePendenzToolStripMenuItem
            // 
            this.neuePendenzToolStripMenuItem.Name = "neuePendenzToolStripMenuItem";
            this.neuePendenzToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.neuePendenzToolStripMenuItem.Text = "Neue Pendenz";
            this.neuePendenzToolStripMenuItem.Click += new System.EventHandler(this.neuePendenzToolStripMenuItem_Click);
            // 
            // neueAdresseToolStripMenuItem
            // 
            this.neueAdresseToolStripMenuItem.Name = "neueAdresseToolStripMenuItem";
            this.neueAdresseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.neueAdresseToolStripMenuItem.Text = "Neue Adresse";
            this.neueAdresseToolStripMenuItem.Click += new System.EventHandler(this.neueAdresseToolStripMenuItem_Click);
            // 
            // schliessenToolStripMenuItem1
            // 
            this.schliessenToolStripMenuItem1.Name = "schliessenToolStripMenuItem1";
            this.schliessenToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.schliessenToolStripMenuItem1.Text = "Schliessen";
            this.schliessenToolStripMenuItem1.Click += new System.EventHandler(this.schliessenToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // schliessenToolStripMenuItem
            // 
            this.schliessenToolStripMenuItem.Name = "schliessenToolStripMenuItem";
            this.schliessenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.schliessenToolStripMenuItem.Text = "Schliessen";
            // 
            // issueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1102, 659);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.searchDropBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "issueForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Pendenzen";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pendenzTab.ResumeLayout(false);
            this.companyTab.ResumeLayout(false);
            this.companyTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView issueDataView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox searchDropBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pendenzTab;
        private System.Windows.Forms.TabPage companyTab;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button companyChangeLabel;
        private System.Windows.Forms.Label plzLabel;
        private System.Windows.Forms.Label poBoxLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label emailVerkaufLabel;
        private System.Windows.Forms.Label emailEinkaufLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label kundeLabel;
        private System.Windows.Forms.Label verkaufBusproLabel;
        private System.Windows.Forms.Label einkaufBusproLabel;
        private System.Windows.Forms.Label busproLabel;
        private System.Windows.Forms.Label verkaufKontaktLabel;
        private System.Windows.Forms.Label einkaufKontaktLabel;
        private System.Windows.Forms.Label kontaktLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schliessenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuePendenzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueAdresseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schliessenToolStripMenuItem1;
        private System.Windows.Forms.Button openLinkButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
    }
}

