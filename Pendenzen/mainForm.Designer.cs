using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pendenzen
{
    partial class mainForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.onOffButton = new System.Windows.Forms.Button();
            this.searchDropBox = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuePendenzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueAdresseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerStornogrundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckvorschauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheZurücksetzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reorganisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kennwortÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übergabeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printIssues = new System.Drawing.Printing.PrintDocument();
            this.infoLabel = new System.Windows.Forms.Label();
            this.searchStatusBox = new System.Windows.Forms.ComboBox();
            this.autoUpdate = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.pendenzTab = new System.Windows.Forms.TabPage();
            this.restoreLabel = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.Button();
            this.issueDataView = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.stornoTab = new System.Windows.Forms.TabPage();
            this.stornoDataView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.reasonBox = new System.Windows.Forms.ComboBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyBox = new System.Windows.Forms.ComboBox();
            this.credit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice = new System.Windows.Forms.TextBox();
            this.sendenButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.companyTab.SuspendLayout();
            this.pendenzTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.stornoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stornoDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea5.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea5.Area3DStyle.Enable3D = true;
            chartArea5.IsSameFontSizeForAllAxes = true;
            chartArea5.Name = "AmountChartArea";
            chartArea6.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea6.Area3DStyle.Enable3D = true;
            chartArea6.Name = "ReasonChartArea";
            chartArea7.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea7.Area3DStyle.Enable3D = true;
            chartArea7.Name = "CountChartArea";
            chartArea8.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea8.Area3DStyle.Enable3D = true;
            chartArea8.Name = "ReasonAmountChartArea";
            this.chart.ChartAreas.Add(chartArea5);
            this.chart.ChartAreas.Add(chartArea6);
            this.chart.ChartAreas.Add(chartArea7);
            this.chart.ChartAreas.Add(chartArea8);
            this.chart.Location = new System.Drawing.Point(642, 13);
            this.chart.Name = "chart";
            series5.ChartArea = "AmountChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Name = "Amount";
            series6.ChartArea = "ReasonChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Name = "Reason";
            series7.ChartArea = "CountChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Name = "Count";
            series8.ChartArea = "ReasonAmountChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Name = "ReasonAmount";
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Size = new System.Drawing.Size(440, 440);
            this.chart.TabIndex = 12;
            this.chart.TabStop = false;
            this.chart.Text = "AmountChart";
            title5.DockedToChartArea = "AmountChartArea";
            title5.DockingOffset = -5;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Firmen nach Betrag";
            title5.Text = "Firmen nach Betrag";
            title6.DockedToChartArea = "CountChartArea";
            title6.DockingOffset = -5;
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Firmen nach Anzahl";
            title6.Text = "Firmen nach Anzahl";
            title7.DockedToChartArea = "ReasonChartArea";
            title7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title7.DockingOffset = 6;
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Gründe nach Anzahl";
            title7.Text = "Gründe nach Anzahl";
            title8.DockedToChartArea = "ReasonAmountChartArea";
            title8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title8.DockingOffset = 6;
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Gründe nach Betrag";
            title8.Text = "Gründe nach Betrag";
            this.chart.Titles.Add(title5);
            this.chart.Titles.Add(title6);
            this.chart.Titles.Add(title7);
            this.chart.Titles.Add(title8);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 13);
            this.nameLabel.TabIndex = 102;
            this.nameLabel.Text = "Name: Bob Meierhans";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Pendenzen.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(17, 37);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(180, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 101;
            this.logoPictureBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 137);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(69, 25);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Neu";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(824, 145);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(108, 20);
            this.searchBox.TabIndex = 41;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_Enter);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(938, 143);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 42;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // onOffButton
            // 
            this.onOffButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onOffButton.AutoSize = true;
            this.onOffButton.BackColor = System.Drawing.Color.Lime;
            this.onOffButton.Location = new System.Drawing.Point(1054, 66);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.Size = new System.Drawing.Size(40, 23);
            this.onOffButton.TabIndex = 100;
            this.onOffButton.Text = "on";
            this.onOffButton.UseVisualStyleBackColor = false;
            this.onOffButton.Click += new System.EventHandler(this.onOffButton_Click);
            // 
            // searchDropBox
            // 
            this.searchDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDropBox.FormattingEnabled = true;
            this.searchDropBox.Location = new System.Drawing.Point(727, 145);
            this.searchDropBox.Name = "searchDropBox";
            this.searchDropBox.Size = new System.Drawing.Size(91, 21);
            this.searchDropBox.TabIndex = 40;
            this.searchDropBox.SelectedIndexChanged += new System.EventHandler(this.searchDropBox_SelectedIndexChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.editToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1102, 24);
            this.menuStrip.TabIndex = 60;
            this.menuStrip.Text = "menuStrip";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.druckToolStripMenuItem,
            this.schliessenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuePendenzToolStripMenuItem,
            this.neueAdresseToolStripMenuItem,
            this.neuerStornogrundToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // neuePendenzToolStripMenuItem
            // 
            this.neuePendenzToolStripMenuItem.Name = "neuePendenzToolStripMenuItem";
            this.neuePendenzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.neuePendenzToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.neuePendenzToolStripMenuItem.Text = "Neue Pendenz";
            this.neuePendenzToolStripMenuItem.Click += new System.EventHandler(this.neuePendenzToolStripMenuItem_Click);
            // 
            // neueAdresseToolStripMenuItem
            // 
            this.neueAdresseToolStripMenuItem.Name = "neueAdresseToolStripMenuItem";
            this.neueAdresseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.neueAdresseToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.neueAdresseToolStripMenuItem.Text = "Neue Adresse";
            this.neueAdresseToolStripMenuItem.Click += new System.EventHandler(this.neueAdresseToolStripMenuItem_Click);
            // 
            // neuerStornogrundToolStripMenuItem
            // 
            this.neuerStornogrundToolStripMenuItem.Name = "neuerStornogrundToolStripMenuItem";
            this.neuerStornogrundToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.neuerStornogrundToolStripMenuItem.Text = "Neuer Stornogrund";
            this.neuerStornogrundToolStripMenuItem.Click += new System.EventHandler(this.storniToolStripMenuItem_Click);
            // 
            // druckToolStripMenuItem
            // 
            this.druckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.druckvorschauToolStripMenuItem,
            this.druckenToolStripMenuItem});
            this.druckToolStripMenuItem.Name = "druckToolStripMenuItem";
            this.druckToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.druckToolStripMenuItem.Text = "Druck";
            // 
            // druckvorschauToolStripMenuItem
            // 
            this.druckvorschauToolStripMenuItem.Name = "druckvorschauToolStripMenuItem";
            this.druckvorschauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.druckvorschauToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.druckvorschauToolStripMenuItem.Text = "Druckvorschau";
            this.druckvorschauToolStripMenuItem.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            this.druckenToolStripMenuItem.Click += new System.EventHandler(this.druckenButton_Click);
            // 
            // schliessenToolStripMenuItem
            // 
            this.schliessenToolStripMenuItem.Name = "schliessenToolStripMenuItem";
            this.schliessenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.schliessenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.schliessenToolStripMenuItem.Text = "Schliessen";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoUpdateToolStripMenuItem,
            this.sucheZurücksetzenToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.editToolStripMenuItem.Text = "Bearbeiten";
            // 
            // autoUpdateToolStripMenuItem
            // 
            this.autoUpdateToolStripMenuItem.Name = "autoUpdateToolStripMenuItem";
            this.autoUpdateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.autoUpdateToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.autoUpdateToolStripMenuItem.Text = "AutoUpdate";
            this.autoUpdateToolStripMenuItem.Click += new System.EventHandler(this.onOffButton_Click);
            // 
            // sucheZurücksetzenToolStripMenuItem
            // 
            this.sucheZurücksetzenToolStripMenuItem.Name = "sucheZurücksetzenToolStripMenuItem";
            this.sucheZurücksetzenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.sucheZurücksetzenToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.sucheZurücksetzenToolStripMenuItem.Text = "Suche zurücksetzen";
            this.sucheZurücksetzenToolStripMenuItem.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reorganisationToolStripMenuItem,
            this.kennwortÄndernToolStripMenuItem,
            this.statistikToolStripMenuItem,
            this.übergabeToolStripMenuItem,
            this.storniToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // reorganisationToolStripMenuItem
            // 
            this.reorganisationToolStripMenuItem.Name = "reorganisationToolStripMenuItem";
            this.reorganisationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reorganisationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.reorganisationToolStripMenuItem.Text = "Reorganisation";
            this.reorganisationToolStripMenuItem.Click += new System.EventHandler(this.reorganisationToolStripMenuItem_Click);
            // 
            // kennwortÄndernToolStripMenuItem
            // 
            this.kennwortÄndernToolStripMenuItem.Name = "kennwortÄndernToolStripMenuItem";
            this.kennwortÄndernToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.kennwortÄndernToolStripMenuItem.Text = "Kennwort ändern";
            this.kennwortÄndernToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // statistikToolStripMenuItem
            // 
            this.statistikToolStripMenuItem.Name = "statistikToolStripMenuItem";
            this.statistikToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.statistikToolStripMenuItem.Text = "Statistik";
            this.statistikToolStripMenuItem.Click += new System.EventHandler(this.statistikToolStripMenuItem_Click);
            // 
            // übergabeToolStripMenuItem
            // 
            this.übergabeToolStripMenuItem.Name = "übergabeToolStripMenuItem";
            this.übergabeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.übergabeToolStripMenuItem.Text = "Übergabe";
            this.übergabeToolStripMenuItem.Click += new System.EventHandler(this.übergabeToolStripMenuItem_Click);
            // 
            // storniToolStripMenuItem
            // 
            this.storniToolStripMenuItem.Name = "storniToolStripMenuItem";
            this.storniToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.storniToolStripMenuItem.Text = "Storno-Gründe hinzufügen";
            this.storniToolStripMenuItem.Click += new System.EventHandler(this.storniToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // printIssues
            // 
            this.printIssues.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printIssues_BeginPrint);
            this.printIssues.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printIssues_EndPrint);
            this.printIssues.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printIssues_PrintPage);
            // 
            // infoLabel
            // 
            this.infoLabel.AllowDrop = true;
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.infoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(955, 92);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(139, 26);
            this.infoLabel.TabIndex = 45;
            this.infoLabel.Text = "AutoUpdate ist aus!\r\nDrücke F4 zum starten.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.infoLabel.Visible = false;
            // 
            // searchStatusBox
            // 
            this.searchStatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStatusBox.FormattingEnabled = true;
            this.searchStatusBox.Location = new System.Drawing.Point(825, 145);
            this.searchStatusBox.Name = "searchStatusBox";
            this.searchStatusBox.Size = new System.Drawing.Size(107, 21);
            this.searchStatusBox.TabIndex = 41;
            this.searchStatusBox.Visible = false;
            // 
            // autoUpdate
            // 
            this.autoUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoUpdate.AutoSize = true;
            this.autoUpdate.Location = new System.Drawing.Point(984, 71);
            this.autoUpdate.Name = "autoUpdate";
            this.autoUpdate.Size = new System.Drawing.Size(64, 13);
            this.autoUpdate.TabIndex = 44;
            this.autoUpdate.Text = "AutoUpdate";
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(1019, 144);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 43;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.reset_Click);
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
            this.companyTab.Controls.Add(this.menuStrip1);
            this.companyTab.Location = new System.Drawing.Point(4, 22);
            this.companyTab.Name = "companyTab";
            this.companyTab.Padding = new System.Windows.Forms.Padding(3);
            this.companyTab.Size = new System.Drawing.Size(1088, 459);
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
            this.verkaufLabel.TabIndex = 0;
            this.verkaufLabel.Text = "Verkauf: ";
            // 
            // einkaufLabel
            // 
            this.einkaufLabel.AutoSize = true;
            this.einkaufLabel.Location = new System.Drawing.Point(39, 190);
            this.einkaufLabel.Name = "einkaufLabel";
            this.einkaufLabel.Size = new System.Drawing.Size(49, 13);
            this.einkaufLabel.TabIndex = 1;
            this.einkaufLabel.Text = "Einkauf: ";
            // 
            // webLabel
            // 
            this.webLabel.AutoSize = true;
            this.webLabel.Location = new System.Drawing.Point(39, 173);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(33, 13);
            this.webLabel.TabIndex = 2;
            this.webLabel.Text = "Web:";
            // 
            // einkaufEmailButton
            // 
            this.einkaufEmailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.einkaufEmailButton.Location = new System.Drawing.Point(145, 357);
            this.einkaufEmailButton.Name = "einkaufEmailButton";
            this.einkaufEmailButton.Size = new System.Drawing.Size(90, 23);
            this.einkaufEmailButton.TabIndex = 31;
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
            this.verkaufEmailButton.TabIndex = 32;
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
            this.einkauferLabel.TabIndex = 33;
            this.einkauferLabel.Text = "Einkauf seit Jan. 1970";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportButton.Location = new System.Drawing.Point(145, 386);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(90, 23);
            this.exportButton.TabIndex = 34;
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
            this.nextButton.TabIndex = 36;
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
            this.previousButton.TabIndex = 35;
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
            this.countLabel.TabIndex = 37;
            this.countLabel.Text = "1 von 1";
            // 
            // openLinkButton
            // 
            this.openLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openLinkButton.Location = new System.Drawing.Point(42, 357);
            this.openLinkButton.Name = "openLinkButton";
            this.openLinkButton.Size = new System.Drawing.Size(90, 23);
            this.openLinkButton.TabIndex = 30;
            this.openLinkButton.Text = "Link öffnen";
            this.openLinkButton.UseVisualStyleBackColor = true;
            this.openLinkButton.Click += new System.EventHandler(this.openLinkButton_Click);
            // 
            // historyBox
            // 
            this.historyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyBox.Location = new System.Drawing.Point(774, 3);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(371, 423);
            this.historyBox.TabIndex = 38;
            this.historyBox.Text = "";
            // 
            // kundeLabel
            // 
            this.kundeLabel.AutoSize = true;
            this.kundeLabel.Location = new System.Drawing.Point(425, 30);
            this.kundeLabel.Name = "kundeLabel";
            this.kundeLabel.Size = new System.Drawing.Size(107, 13);
            this.kundeLabel.TabIndex = 39;
            this.kundeLabel.Text = "Kunde seit Jan. 1970";
            // 
            // verkaufBusproLabel
            // 
            this.verkaufBusproLabel.AutoSize = true;
            this.verkaufBusproLabel.Location = new System.Drawing.Point(492, 173);
            this.verkaufBusproLabel.Name = "verkaufBusproLabel";
            this.verkaufBusproLabel.Size = new System.Drawing.Size(72, 13);
            this.verkaufBusproLabel.TabIndex = 40;
            this.verkaufBusproLabel.Text = "Verkauf: Nein";
            // 
            // einkaufBusproLabel
            // 
            this.einkaufBusproLabel.AutoSize = true;
            this.einkaufBusproLabel.Location = new System.Drawing.Point(492, 156);
            this.einkaufBusproLabel.Name = "einkaufBusproLabel";
            this.einkaufBusproLabel.Size = new System.Drawing.Size(71, 13);
            this.einkaufBusproLabel.TabIndex = 41;
            this.einkaufBusproLabel.Text = "Einkauf: Nein";
            // 
            // busproLabel
            // 
            this.busproLabel.AutoSize = true;
            this.busproLabel.Location = new System.Drawing.Point(425, 156);
            this.busproLabel.Name = "busproLabel";
            this.busproLabel.Size = new System.Drawing.Size(61, 13);
            this.busproLabel.TabIndex = 42;
            this.busproLabel.Text = "Im BusPro?";
            // 
            // verkaufKontaktLabel
            // 
            this.verkaufKontaktLabel.AutoSize = true;
            this.verkaufKontaktLabel.Location = new System.Drawing.Point(492, 98);
            this.verkaufKontaktLabel.Name = "verkaufKontaktLabel";
            this.verkaufKontaktLabel.Size = new System.Drawing.Size(72, 13);
            this.verkaufKontaktLabel.TabIndex = 43;
            this.verkaufKontaktLabel.Text = "Verkauf: Nein";
            // 
            // einkaufKontaktLabel
            // 
            this.einkaufKontaktLabel.AutoSize = true;
            this.einkaufKontaktLabel.Location = new System.Drawing.Point(493, 81);
            this.einkaufKontaktLabel.Name = "einkaufKontaktLabel";
            this.einkaufKontaktLabel.Size = new System.Drawing.Size(71, 13);
            this.einkaufKontaktLabel.TabIndex = 44;
            this.einkaufKontaktLabel.Text = "Einkauf: Nein";
            // 
            // kontaktLabel
            // 
            this.kontaktLabel.AutoSize = true;
            this.kontaktLabel.Location = new System.Drawing.Point(425, 81);
            this.kontaktLabel.Name = "kontaktLabel";
            this.kontaktLabel.Size = new System.Drawing.Size(47, 13);
            this.kontaktLabel.TabIndex = 45;
            this.kontaktLabel.Text = "Kontakt:";
            // 
            // emailVerkaufLabel
            // 
            this.emailVerkaufLabel.AutoSize = true;
            this.emailVerkaufLabel.Location = new System.Drawing.Point(95, 207);
            this.emailVerkaufLabel.Name = "emailVerkaufLabel";
            this.emailVerkaufLabel.Size = new System.Drawing.Size(93, 13);
            this.emailVerkaufLabel.TabIndex = 46;
            this.emailVerkaufLabel.Text = "verkauf@email.ch";
            // 
            // emailEinkaufLabel
            // 
            this.emailEinkaufLabel.AutoSize = true;
            this.emailEinkaufLabel.Location = new System.Drawing.Point(95, 190);
            this.emailEinkaufLabel.Name = "emailEinkaufLabel";
            this.emailEinkaufLabel.Size = new System.Drawing.Size(92, 13);
            this.emailEinkaufLabel.TabIndex = 47;
            this.emailEinkaufLabel.Text = "einkauf@email.ch";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(95, 173);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(116, 13);
            this.urlLabel.TabIndex = 48;
            this.urlLabel.Text = "http://www.website.ch";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(39, 156);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 49;
            this.phoneLabel.Text = "Phone";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(39, 115);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 50;
            this.countryLabel.Text = "Country";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(95, 98);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 51;
            this.cityLabel.Text = "City";
            // 
            // companyChangeLabel
            // 
            this.companyChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.companyChangeLabel.Location = new System.Drawing.Point(42, 386);
            this.companyChangeLabel.Name = "companyChangeLabel";
            this.companyChangeLabel.Size = new System.Drawing.Size(90, 23);
            this.companyChangeLabel.TabIndex = 33;
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
            this.plzLabel.TabIndex = 52;
            this.plzLabel.Text = "PLZ";
            // 
            // poBoxLabel
            // 
            this.poBoxLabel.AutoSize = true;
            this.poBoxLabel.Location = new System.Drawing.Point(39, 81);
            this.poBoxLabel.Name = "poBoxLabel";
            this.poBoxLabel.Size = new System.Drawing.Size(49, 13);
            this.poBoxLabel.TabIndex = 53;
            this.poBoxLabel.Text = "P.O. Box";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(39, 64);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(35, 13);
            this.streetLabel.TabIndex = 54;
            this.streetLabel.Text = "Street";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(39, 47);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(51, 13);
            this.companyLabel.TabIndex = 55;
            this.companyLabel.Text = "Company";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(39, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 13);
            this.idLabel.TabIndex = 56;
            this.idLabel.Text = "APW";
            // 
            // pendenzTab
            // 
            this.pendenzTab.Controls.Add(this.restoreLabel);
            this.pendenzTab.Controls.Add(this.restoreButton);
            this.pendenzTab.Controls.Add(this.issueDataView);
            this.pendenzTab.Location = new System.Drawing.Point(4, 22);
            this.pendenzTab.Name = "pendenzTab";
            this.pendenzTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendenzTab.Size = new System.Drawing.Size(1088, 459);
            this.pendenzTab.TabIndex = 0;
            this.pendenzTab.Text = "Pendenzen";
            this.pendenzTab.UseVisualStyleBackColor = true;
            // 
            // restoreLabel
            // 
            this.restoreLabel.AutoSize = true;
            this.restoreLabel.Location = new System.Drawing.Point(288, 190);
            this.restoreLabel.Name = "restoreLabel";
            this.restoreLabel.Size = new System.Drawing.Size(559, 13);
            this.restoreLabel.TabIndex = 0;
            this.restoreLabel.Text = "Die Suche hat keine Einträge gefunden, bitte suche mittels anderen Keywords oder " +
    "setze die Suche zurück (Ctrl + Y).";
            this.restoreLabel.Visible = false;
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restoreButton.Location = new System.Drawing.Point(473, 226);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(119, 23);
            this.restoreButton.TabIndex = 20;
            this.restoreButton.Text = "Suche zurücksetzen";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Visible = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // issueDataView
            // 
            this.issueDataView.AllowUserToAddRows = false;
            this.issueDataView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.issueDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.issueDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.issueDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.issueDataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.issueDataView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.issueDataView.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.issueDataView.Size = new System.Drawing.Size(1087, 459);
            this.issueDataView.TabIndex = 21;
            this.issueDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueDataView_CellClick);
            this.issueDataView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.issueDataView_CellMouseClick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.pendenzTab);
            this.tabControl.Controls.Add(this.companyTab);
            this.tabControl.Controls.Add(this.stornoTab);
            this.tabControl.Location = new System.Drawing.Point(3, 173);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1096, 485);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // stornoTab
            // 
            this.stornoTab.Controls.Add(this.stornoDataView);
            this.stornoTab.Controls.Add(this.label6);
            this.stornoTab.Controls.Add(this.reasonBox);
            this.stornoTab.Controls.Add(this.amount);
            this.stornoTab.Controls.Add(this.label5);
            this.stornoTab.Controls.Add(this.label4);
            this.stornoTab.Controls.Add(this.companyBox);
            this.stornoTab.Controls.Add(this.credit);
            this.stornoTab.Controls.Add(this.label3);
            this.stornoTab.Controls.Add(this.label2);
            this.stornoTab.Controls.Add(this.invoice);
            this.stornoTab.Controls.Add(this.sendenButton);
            this.stornoTab.Controls.Add(this.chart);
            this.stornoTab.Location = new System.Drawing.Point(4, 22);
            this.stornoTab.Name = "stornoTab";
            this.stornoTab.Padding = new System.Windows.Forms.Padding(3);
            this.stornoTab.Size = new System.Drawing.Size(1088, 459);
            this.stornoTab.TabIndex = 2;
            this.stornoTab.Text = "Storni";
            this.stornoTab.UseVisualStyleBackColor = true;
            // 
            // stornoDataView
            // 
            this.stornoDataView.AllowUserToAddRows = false;
            this.stornoDataView.AllowUserToDeleteRows = false;
            this.stornoDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stornoDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stornoDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stornoDataView.Location = new System.Drawing.Point(10, 179);
            this.stornoDataView.Name = "stornoDataView";
            this.stornoDataView.ReadOnly = true;
            this.stornoDataView.RowHeadersVisible = false;
            this.stornoDataView.Size = new System.Drawing.Size(619, 274);
            this.stornoDataView.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stornogrund";
            // 
            // reasonBox
            // 
            this.reasonBox.FormattingEnabled = true;
            this.reasonBox.Location = new System.Drawing.Point(10, 123);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(206, 21);
            this.reasonBox.TabIndex = 9;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(116, 84);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Betrag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Firma";
            // 
            // companyBox
            // 
            this.companyBox.FormattingEnabled = true;
            this.companyBox.Location = new System.Drawing.Point(10, 83);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(100, 21);
            this.companyBox.TabIndex = 5;
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(116, 44);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(100, 20);
            this.credit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gutschrift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rechnung";
            // 
            // invoice
            // 
            this.invoice.Location = new System.Drawing.Point(10, 44);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(100, 20);
            this.invoice.TabIndex = 1;
            // 
            // sendenButton
            // 
            this.sendenButton.Location = new System.Drawing.Point(10, 150);
            this.sendenButton.Name = "sendenButton";
            this.sendenButton.Size = new System.Drawing.Size(75, 23);
            this.sendenButton.TabIndex = 0;
            this.sendenButton.Text = "Senden";
            this.sendenButton.UseVisualStyleBackColor = true;
            this.sendenButton.Click += new System.EventHandler(this.submitStorno);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(949, 37);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(145, 23);
            this.updateButton.TabIndex = 103;
            this.updateButton.Text = "Nach Updates Suchen";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(200, 140);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(121, 21);
            this.departmentBox.TabIndex = 104;
            this.departmentBox.Visible = false;
            this.departmentBox.SelectedIndexChanged += new System.EventHandler(this.departmentBox_SelectedIndexChanged);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(197, 124);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(51, 13);
            this.departmentLabel.TabIndex = 105;
            this.departmentLabel.Text = "Abteilung";
            this.departmentLabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1102, 662);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.autoUpdate);
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
            this.Controls.Add(this.searchStatusBox);
            this.HelpButton = true;
            this.Icon = global::Pendenzen.Properties.Resources.favicon;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "mainForm";
            this.Text = "Pendenzen";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.companyTab.ResumeLayout(false);
            this.companyTab.PerformLayout();
            this.pendenzTab.ResumeLayout(false);
            this.pendenzTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issueDataView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.stornoTab.ResumeLayout(false);
            this.stornoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stornoDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private PictureBox logoPictureBox;
        private Button addButton;
        private TextBox searchBox;
        private Button searchButton;
        private Button onOffButton;
        private ComboBox searchDropBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem schliessenToolStripMenuItem;
        private ToolStripMenuItem neuePendenzToolStripMenuItem;
        private ToolStripMenuItem neueAdresseToolStripMenuItem;
        private ToolStripMenuItem autoUpdateToolStripMenuItem;
        private ToolStripMenuItem reorganisationToolStripMenuItem;
        private PrintDocument printIssues;
        private Label infoLabel;
        private ToolStripMenuItem druckToolStripMenuItem;
        private ToolStripMenuItem druckvorschauToolStripMenuItem;
        private ToolStripMenuItem druckenToolStripMenuItem;
        private ComboBox searchStatusBox;
        private Label autoUpdate;
        private ToolStripMenuItem kennwortÄndernToolStripMenuItem;
        private Button resetButton;
        private ToolStripMenuItem sucheZurücksetzenToolStripMenuItem;
        private ToolStripMenuItem statistikToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolStripMenuItem übergabeToolStripMenuItem;
        private TabPage companyTab;
        private Label verkaufLabel;
        private Label einkaufLabel;
        private Label webLabel;
        private Button einkaufEmailButton;
        private Button verkaufEmailButton;
        private Label einkauferLabel;
        private Button exportButton;
        private Button nextButton;
        private Button previousButton;
        private Label countLabel;
        private Button openLinkButton;
        private RichTextBox historyBox;
        private Label kundeLabel;
        private Label verkaufBusproLabel;
        private Label einkaufBusproLabel;
        private Label busproLabel;
        private Label verkaufKontaktLabel;
        private Label einkaufKontaktLabel;
        private Label kontaktLabel;
        private Label emailVerkaufLabel;
        private Label emailEinkaufLabel;
        private Label urlLabel;
        private Label phoneLabel;
        private Label countryLabel;
        private Label cityLabel;
        private Button companyChangeLabel;
        private Label plzLabel;
        private Label poBoxLabel;
        private Label streetLabel;
        private Label companyLabel;
        private Label idLabel;
        private TabPage pendenzTab;
        private Label restoreLabel;
        private Button restoreButton;
        private DataGridView issueDataView;
        private TabControl tabControl;
        private TabPage stornoTab;
        private Label label3;
        private Label label2;
        private TextBox invoice;
        private Button sendenButton;
        private Label label6;
        private ComboBox reasonBox;
        private TextBox amount;
        private Label label5;
        private Label label4;
        private ComboBox companyBox;
        private TextBox credit;
        private Chart chart;
        private DataGridView stornoDataView;
        private ToolStripMenuItem storniToolStripMenuItem;
        private ToolStripMenuItem neuerStornogrundToolStripMenuItem;
        private Button updateButton;
        private ComboBox departmentBox;
        private Label departmentLabel;
        private MenuStrip menuStrip1;
    }
}