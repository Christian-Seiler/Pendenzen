using System.Drawing;

namespace Pendenzen
{
    partial class Stats
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.offen = new System.Windows.Forms.Label();
            this.geschlossenLetzt = new System.Windows.Forms.Label();
            this.storniertLetzt = new System.Windows.Forms.Label();
            this.geschlossenAktuell = new System.Windows.Forms.Label();
            this.storniertAktuell = new System.Windows.Forms.Label();
            this.totalAktuell = new System.Windows.Forms.Label();
            this.totalLetzt = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(144, 210);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Schliessen";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // autoUpdate
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "autoUpdate";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Geschlossen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Storniert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aktueller Monat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Letzter Monat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total eröffnet";
            // 
            // offen
            // 
            this.offen.AutoSize = true;
            this.offen.Location = new System.Drawing.Point(141, 77);
            this.offen.Name = "offen";
            this.offen.Size = new System.Drawing.Size(33, 13);
            this.offen.TabIndex = 7;
            this.offen.Text = "Offen";
            // 
            // geschlossenLetzt
            // 
            this.geschlossenLetzt.AutoSize = true;
            this.geschlossenLetzt.Location = new System.Drawing.Point(259, 104);
            this.geschlossenLetzt.Name = "geschlossenLetzt";
            this.geschlossenLetzt.Size = new System.Drawing.Size(89, 13);
            this.geschlossenLetzt.TabIndex = 8;
            this.geschlossenLetzt.Text = "geschlossenLetzt";
            // 
            // storniertLetzt
            // 
            this.storniertLetzt.AutoSize = true;
            this.storniertLetzt.Location = new System.Drawing.Point(259, 131);
            this.storniertLetzt.Name = "storniertLetzt";
            this.storniertLetzt.Size = new System.Drawing.Size(67, 13);
            this.storniertLetzt.TabIndex = 9;
            this.storniertLetzt.Text = "storniertLetzt";
            // 
            // geschlossenAktuell
            // 
            this.geschlossenAktuell.AutoSize = true;
            this.geschlossenAktuell.Location = new System.Drawing.Point(141, 104);
            this.geschlossenAktuell.Name = "geschlossenAktuell";
            this.geschlossenAktuell.Size = new System.Drawing.Size(98, 13);
            this.geschlossenAktuell.TabIndex = 10;
            this.geschlossenAktuell.Text = "geschlossenAktuell";
            // 
            // storniertAktuell
            // 
            this.storniertAktuell.AutoSize = true;
            this.storniertAktuell.Location = new System.Drawing.Point(141, 131);
            this.storniertAktuell.Name = "storniertAktuell";
            this.storniertAktuell.Size = new System.Drawing.Size(76, 13);
            this.storniertAktuell.TabIndex = 11;
            this.storniertAktuell.Text = "storniertAktuell";
            // 
            // totalAktuell
            // 
            this.totalAktuell.AutoSize = true;
            this.totalAktuell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAktuell.Location = new System.Drawing.Point(141, 158);
            this.totalAktuell.Name = "totalAktuell";
            this.totalAktuell.Size = new System.Drawing.Size(71, 13);
            this.totalAktuell.TabIndex = 12;
            this.totalAktuell.Text = "totalAktuell";
            // 
            // totalLetzt
            // 
            this.totalLetzt.AutoSize = true;
            this.totalLetzt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLetzt.Location = new System.Drawing.Point(259, 158);
            this.totalLetzt.Name = "totalLetzt";
            this.totalLetzt.Size = new System.Drawing.Size(60, 13);
            this.totalLetzt.TabIndex = 13;
            this.totalLetzt.Text = "totalLetzt";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(13, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Statistik der Abteilung";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 244);
            this.Controls.Add(this.title);
            this.Controls.Add(this.totalLetzt);
            this.Controls.Add(this.totalAktuell);
            this.Controls.Add(this.storniertAktuell);
            this.Controls.Add(this.geschlossenAktuell);
            this.Controls.Add(this.storniertLetzt);
            this.Controls.Add(this.geschlossenLetzt);
            this.Controls.Add(this.offen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Icon = global::Pendenzen.Properties.Resources.favicon;
            this.Name = "Stats";
            this.Text = "Statistik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label offen;
        private System.Windows.Forms.Label geschlossenLetzt;
        private System.Windows.Forms.Label storniertLetzt;
        private System.Windows.Forms.Label geschlossenAktuell;
        private System.Windows.Forms.Label storniertAktuell;
        private System.Windows.Forms.Label totalAktuell;
        private System.Windows.Forms.Label totalLetzt;
        private System.Windows.Forms.Label title;
    }
}