using System;

namespace Pendenzen
{
    partial class info
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.logoPicturebox = new System.Windows.Forms.PictureBox();
            this.supportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(13, 80);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(105, 17);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "ProductName";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(13, 110);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(63, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version: 1.0";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(13, 140);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(50, 13);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "copyright";
            // 
            // logoPicturebox
            // 
            this.logoPicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPicturebox.Image = global::Pendenzen.Properties.Resources.logo;
            this.logoPicturebox.Location = new System.Drawing.Point(13, 13);
            this.logoPicturebox.Name = "logoPicturebox";
            this.logoPicturebox.Size = new System.Drawing.Size(214, 50);
            this.logoPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicturebox.TabIndex = 3;
            this.logoPicturebox.TabStop = false;
            // 
            // supportButton
            // 
            this.supportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supportButton.Location = new System.Drawing.Point(68, 180);
            this.supportButton.Name = "supportButton";
            this.supportButton.Size = new System.Drawing.Size(104, 23);
            this.supportButton.TabIndex = 4;
            this.supportButton.Text = "Support";
            this.supportButton.UseVisualStyleBackColor = true;
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(244, 217);
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.logoPicturebox);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.productNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "info";
            this.Icon = Properties.Resources.favicon;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox logoPicturebox;
        private System.Windows.Forms.Button supportButton;
    }
}