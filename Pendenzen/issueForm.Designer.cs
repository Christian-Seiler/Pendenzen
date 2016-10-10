using System.Windows.Forms;

namespace Pendenzen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.issueDataView = new System.Windows.Forms.DataGridView();
            this.onOffButton = new System.Windows.Forms.Button();
            this.searchDropBox = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pendenzTab = new System.Windows.Forms.TabPage();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.verkaufLabel = new System.Windows.Forms.Label();
            this.einkaufLabel = new System.Windows.Forms.Label();
            this.webLabel = new System.Windows.Forms.Label();
            this.einkaufEmailButton = new System.Windows.Forms.Button();
            this.verkaufEmailButton = new System.Windows.Forms.Button();
            this.einkauferLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.openLinkButton = new System.Windows.Forms.Button();
            this.historyBox = new System.Windows.Forms.RichTextBox();
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckvorschauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuePendenzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueAdresseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printIssues = new System.Drawing.Printing.PrintDocument();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pendenzTab.SuspendLayout();
            this.companyTab.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            this.searchBox.Location = new System.Drawing.Point(900, 157);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(108, 20);
            this.searchBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(1014, 152);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 25);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // issueDataView
            // 
            this.issueDataView.AllowUserToAddRows = false;
            this.issueDataView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.issueDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.issueDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.issueDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.issueDataView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.issueDataView.Location = new System.Drawing.Point(0, 0);
            this.issueDataView.MultiSelect = false;
            this.issueDataView.Name = "issueDataView";
            this.issueDataView.ReadOnly = true;
            this.issueDataView.RowHeadersVisible = false;
            this.issueDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.issueDataView.ShowCellErrors = false;
            this.issueDataView.ShowCellToolTips = false;
            this.issueDataView.ShowEditingIcon = false;
            this.issueDataView.ShowRowErrors = false;
            this.issueDataView.Size = new System.Drawing.Size(1067, 439);
            this.issueDataView.TabIndex = 12;
            this.issueDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueDataView_CellClick);
            this.issueDataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.issueDataView_CellMouseClick);
            // 
            // onOffButton
            // 
            this.onOffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onOffButton.AutoSize = true;
            this.onOffButton.BackColor = System.Drawing.Color.Lime;
            this.onOffButton.Location = new System.Drawing.Point(1049, 37);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.Size = new System.Drawing.Size(40, 23);
            this.onOffButton.TabIndex = 13;
            this.onOffButton.Text = "on";
            this.onOffButton.UseVisualStyleBackColor = false;
            this.onOffButton.Click += new System.EventHandler(this.onOffButton_Click);
            // 
            // searchDropBox
            // 
            this.searchDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDropBox.FormattingEnabled = true;
            this.searchDropBox.Location = new System.Drawing.Point(803, 155);
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
            this.tabControl.Size = new System.Drawing.Size(1076, 465);
            this.tabControl.TabIndex = 15;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // pendenzTab
            // 
            this.pendenzTab.Controls.Add(this.issueDataView);
            this.pendenzTab.Location = new System.Drawing.Point(4, 22);
            this.pendenzTab.Name = "pendenzTab";
            this.pendenzTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendenzTab.Size = new System.Drawing.Size(1068, 439);
            this.pendenzTab.TabIndex = 0;
            this.pendenzTab.Text = "Pendenzen";
            this.pendenzTab.UseVisualStyleBackColor = true;
            // 
            // companyTab
            // 
            this.companyTab.Controls.Add(this.verkaufLabel);
            this.companyTab.Controls.Add(this.einkaufLabel);
            this.companyTab.Controls.Add(this.webLabel);
            this.companyTab.Controls.Add(this.einkaufEmailButton);
            this.companyTab.Controls.Add(this.verkaufEmailButton);
            this.companyTab.Controls.Add(this.einkauferLabel);
            this.companyTab.Controls.Add(this.exportButton);
            this.companyTab.Controls.Add(this.nextButton);
            this.companyTab.Controls.Add(this.previousButton);
            this.companyTab.Controls.Add(this.countLabel);
            this.companyTab.Controls.Add(this.openLinkButton);
            this.companyTab.Controls.Add(this.historyBox);
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
            this.companyTab.Size = new System.Drawing.Size(1068, 439);
            this.companyTab.TabIndex = 1;
            this.companyTab.Text = "Adressen";
            this.companyTab.UseVisualStyleBackColor = true;
            // 
            // verkaufLabel
            // 
            this.verkaufLabel.AutoSize = true;
            this.verkaufLabel.Location = new System.Drawing.Point(39, 207);
            this.verkaufLabel.Name = "verkaufLabel";
            this.verkaufLabel.Size = new System.Drawing.Size(50, 13);
            this.verkaufLabel.TabIndex = 32;
            this.verkaufLabel.Text = "Verkauf: ";
            // 
            // einkaufLabel
            // 
            this.einkaufLabel.AutoSize = true;
            this.einkaufLabel.Location = new System.Drawing.Point(39, 190);
            this.einkaufLabel.Name = "einkaufLabel";
            this.einkaufLabel.Size = new System.Drawing.Size(49, 13);
            this.einkaufLabel.TabIndex = 31;
            this.einkaufLabel.Text = "Einkauf: ";
            // 
            // webLabel
            // 
            this.webLabel.AutoSize = true;
            this.webLabel.Location = new System.Drawing.Point(39, 173);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(33, 13);
            this.webLabel.TabIndex = 30;
            this.webLabel.Text = "Web:";
            // 
            // einkaufEmailButton
            // 
            this.einkaufEmailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.einkaufEmailButton.Location = new System.Drawing.Point(145, 357);
            this.einkaufEmailButton.Name = "einkaufEmailButton";
            this.einkaufEmailButton.Size = new System.Drawing.Size(90, 23);
            this.einkaufEmailButton.TabIndex = 29;
            this.einkaufEmailButton.Text = "Email Einkauf";
            this.einkaufEmailButton.UseVisualStyleBackColor = true;
            this.einkaufEmailButton.Click += new System.EventHandler(this.einkaufEmailButton_Click);
            // 
            // verkaufEmailButton
            // 
            this.verkaufEmailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.verkaufEmailButton.Location = new System.Drawing.Point(241, 357);
            this.verkaufEmailButton.Name = "verkaufEmailButton";
            this.verkaufEmailButton.Size = new System.Drawing.Size(90, 23);
            this.verkaufEmailButton.TabIndex = 28;
            this.verkaufEmailButton.Text = "Email Verkauf";
            this.verkaufEmailButton.UseVisualStyleBackColor = true;
            this.verkaufEmailButton.Click += new System.EventHandler(this.verkaufEmailButton_Click);
            // 
            // einkauferLabel
            // 
            this.einkauferLabel.AutoSize = true;
            this.einkauferLabel.Location = new System.Drawing.Point(425, 47);
            this.einkauferLabel.Name = "einkauferLabel";
            this.einkauferLabel.Size = new System.Drawing.Size(112, 13);
            this.einkauferLabel.TabIndex = 27;
            this.einkauferLabel.Text = "Einkauf seit Jan. 1970";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportButton.Location = new System.Drawing.Point(145, 386);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(90, 23);
            this.exportButton.TabIndex = 26;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nextButton.Location = new System.Drawing.Point(457, 386);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 23);
            this.nextButton.TabIndex = 25;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousButton.Location = new System.Drawing.Point(337, 386);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(23, 23);
            this.previousButton.TabIndex = 24;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(388, 391);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(43, 13);
            this.countLabel.TabIndex = 23;
            this.countLabel.Text = "1 von 1";
            // 
            // openLinkButton
            // 
            this.openLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openLinkButton.Location = new System.Drawing.Point(42, 357);
            this.openLinkButton.Name = "openLinkButton";
            this.openLinkButton.Size = new System.Drawing.Size(90, 23);
            this.openLinkButton.TabIndex = 22;
            this.openLinkButton.Text = "Link öffnen";
            this.openLinkButton.UseVisualStyleBackColor = true;
            this.openLinkButton.Click += new System.EventHandler(this.openLinkButton_Click);
            // 
            // historyBox
            // 
            this.historyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyBox.Location = new System.Drawing.Point(691, 7);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(371, 423);
            this.historyBox.TabIndex = 21;
            this.historyBox.Text = "";
            // 
            // kundeLabel
            // 
            this.kundeLabel.AutoSize = true;
            this.kundeLabel.Location = new System.Drawing.Point(425, 30);
            this.kundeLabel.Name = "kundeLabel";
            this.kundeLabel.Size = new System.Drawing.Size(107, 13);
            this.kundeLabel.TabIndex = 20;
            this.kundeLabel.Text = "Kunde seit Jan. 1970";
            // 
            // verkaufBusproLabel
            // 
            this.verkaufBusproLabel.AutoSize = true;
            this.verkaufBusproLabel.Location = new System.Drawing.Point(492, 173);
            this.verkaufBusproLabel.Name = "verkaufBusproLabel";
            this.verkaufBusproLabel.Size = new System.Drawing.Size(72, 13);
            this.verkaufBusproLabel.TabIndex = 19;
            this.verkaufBusproLabel.Text = "Verkauf: Nein";
            // 
            // einkaufBusproLabel
            // 
            this.einkaufBusproLabel.AutoSize = true;
            this.einkaufBusproLabel.Location = new System.Drawing.Point(492, 156);
            this.einkaufBusproLabel.Name = "einkaufBusproLabel";
            this.einkaufBusproLabel.Size = new System.Drawing.Size(71, 13);
            this.einkaufBusproLabel.TabIndex = 18;
            this.einkaufBusproLabel.Text = "Einkauf: Nein";
            // 
            // busproLabel
            // 
            this.busproLabel.AutoSize = true;
            this.busproLabel.Location = new System.Drawing.Point(425, 156);
            this.busproLabel.Name = "busproLabel";
            this.busproLabel.Size = new System.Drawing.Size(61, 13);
            this.busproLabel.TabIndex = 17;
            this.busproLabel.Text = "Im BusPro?";
            // 
            // verkaufKontaktLabel
            // 
            this.verkaufKontaktLabel.AutoSize = true;
            this.verkaufKontaktLabel.Location = new System.Drawing.Point(492, 98);
            this.verkaufKontaktLabel.Name = "verkaufKontaktLabel";
            this.verkaufKontaktLabel.Size = new System.Drawing.Size(72, 13);
            this.verkaufKontaktLabel.TabIndex = 16;
            this.verkaufKontaktLabel.Text = "Verkauf: Nein";
            // 
            // einkaufKontaktLabel
            // 
            this.einkaufKontaktLabel.AutoSize = true;
            this.einkaufKontaktLabel.Location = new System.Drawing.Point(493, 81);
            this.einkaufKontaktLabel.Name = "einkaufKontaktLabel";
            this.einkaufKontaktLabel.Size = new System.Drawing.Size(71, 13);
            this.einkaufKontaktLabel.TabIndex = 15;
            this.einkaufKontaktLabel.Text = "Einkauf: Nein";
            // 
            // kontaktLabel
            // 
            this.kontaktLabel.AutoSize = true;
            this.kontaktLabel.Location = new System.Drawing.Point(425, 81);
            this.kontaktLabel.Name = "kontaktLabel";
            this.kontaktLabel.Size = new System.Drawing.Size(47, 13);
            this.kontaktLabel.TabIndex = 14;
            this.kontaktLabel.Text = "Kontakt:";
            // 
            // emailVerkaufLabel
            // 
            this.emailVerkaufLabel.AutoSize = true;
            this.emailVerkaufLabel.Location = new System.Drawing.Point(95, 207);
            this.emailVerkaufLabel.Name = "emailVerkaufLabel";
            this.emailVerkaufLabel.Size = new System.Drawing.Size(93, 13);
            this.emailVerkaufLabel.TabIndex = 11;
            this.emailVerkaufLabel.Text = "verkauf@email.ch";
            // 
            // emailEinkaufLabel
            // 
            this.emailEinkaufLabel.AutoSize = true;
            this.emailEinkaufLabel.Location = new System.Drawing.Point(95, 190);
            this.emailEinkaufLabel.Name = "emailEinkaufLabel";
            this.emailEinkaufLabel.Size = new System.Drawing.Size(92, 13);
            this.emailEinkaufLabel.TabIndex = 10;
            this.emailEinkaufLabel.Text = "einkauf@email.ch";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(95, 173);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(116, 13);
            this.urlLabel.TabIndex = 9;
            this.urlLabel.Text = "http://www.website.ch";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(39, 156);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(39, 115);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(95, 98);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City";
            // 
            // companyChangeLabel
            // 
            this.companyChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.companyChangeLabel.Location = new System.Drawing.Point(42, 386);
            this.companyChangeLabel.Name = "companyChangeLabel";
            this.companyChangeLabel.Size = new System.Drawing.Size(90, 23);
            this.companyChangeLabel.TabIndex = 5;
            this.companyChangeLabel.Text = "Bearbeiten";
            this.companyChangeLabel.UseVisualStyleBackColor = true;
            this.companyChangeLabel.Click += new System.EventHandler(this.companyChangeLabel_Click);
            // 
            // plzLabel
            // 
            this.plzLabel.AutoSize = true;
            this.plzLabel.Location = new System.Drawing.Point(39, 98);
            this.plzLabel.Name = "plzLabel";
            this.plzLabel.Size = new System.Drawing.Size(27, 13);
            this.plzLabel.TabIndex = 4;
            this.plzLabel.Text = "PLZ";
            // 
            // poBoxLabel
            // 
            this.poBoxLabel.AutoSize = true;
            this.poBoxLabel.Location = new System.Drawing.Point(39, 81);
            this.poBoxLabel.Name = "poBoxLabel";
            this.poBoxLabel.Size = new System.Drawing.Size(49, 13);
            this.poBoxLabel.TabIndex = 3;
            this.poBoxLabel.Text = "P.O. Box";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(39, 64);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(35, 13);
            this.streetLabel.TabIndex = 2;
            this.streetLabel.Text = "Street";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(39, 47);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(10, 10);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.druckToolStripMenuItem,
            this.schliessenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // druckToolStripMenuItem
            // 
            this.druckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.druckvorschauToolStripMenuItem,
            this.druckenToolStripMenuItem});
            this.druckToolStripMenuItem.Name = "druckToolStripMenuItem";
            this.druckToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.druckToolStripMenuItem.Text = "Druck";
            // 
            // druckvorschauToolStripMenuItem
            // 
            this.druckvorschauToolStripMenuItem.Name = "druckvorschauToolStripMenuItem";
            this.druckvorschauToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.druckvorschauToolStripMenuItem.Text = "Druckvorschau";
            this.druckvorschauToolStripMenuItem.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            this.druckenToolStripMenuItem.Click += new System.EventHandler(this.druckenButton_Click);
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
            // schliessenToolStripMenuItem
            // 
            this.schliessenToolStripMenuItem.Name = "schliessenToolStripMenuItem";
            this.schliessenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.schliessenToolStripMenuItem.Text = "Schliessen";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // printIssues
            // 
            this.printIssues.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printIssues_BeginPrint);
            this.printIssues.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printIssues_PrintPage);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.infoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoLabel.Enabled = false;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(1030, 63);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(59, 13);
            this.infoLabel.TabIndex = 19;
            this.infoLabel.Text = "infoLabel";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.infoLabel.Visible = false;
            // 
            // issueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1102, 662);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.searchDropBox);
            this.Controls.Add(this.onOffButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "issueForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Pendenzen";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pendenzTab.ResumeLayout(false);
            this.companyTab.ResumeLayout(false);
            this.companyTab.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.Button onOffButton;
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
        private System.Windows.Forms.RichTextBox historyBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schliessenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuePendenzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueAdresseToolStripMenuItem;
        private System.Windows.Forms.Button openLinkButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label einkauferLabel;
        private System.Windows.Forms.Button einkaufEmailButton;
        private System.Windows.Forms.Button verkaufEmailButton;
        private System.Windows.Forms.Label verkaufLabel;
        private System.Windows.Forms.Label einkaufLabel;
        private System.Windows.Forms.Label webLabel;
        private System.Drawing.Printing.PrintDocument printIssues;
        private Label infoLabel;
        private ToolStripMenuItem druckToolStripMenuItem;
        private ToolStripMenuItem druckvorschauToolStripMenuItem;
        private ToolStripMenuItem druckenToolStripMenuItem;
    }
}

