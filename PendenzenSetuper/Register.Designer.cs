namespace PendenzenSetuper
{
    partial class Register
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
            this.yesCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesCheck
            // 
            this.yesCheck.AutoSize = true;
            this.yesCheck.Location = new System.Drawing.Point(26, 92);
            this.yesCheck.Name = "yesCheck";
            this.yesCheck.Size = new System.Drawing.Size(37, 17);
            this.yesCheck.TabIndex = 0;
            this.yesCheck.Text = "Ja";
            this.yesCheck.UseVisualStyleBackColor = true;
            this.yesCheck.CheckedChanged += new System.EventHandler(this.weiterButtonTextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ich möchte die Applikation registrieren.";
            // 
            // weiter
            // 
            this.weiter.Location = new System.Drawing.Point(159, 230);
            this.weiter.Name = "weiter";
            this.weiter.Size = new System.Drawing.Size(75, 23);
            this.weiter.TabIndex = 2;
            this.weiter.Text = "Weiter";
            this.weiter.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 390);
            this.Controls.Add(this.weiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yesCheck);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox yesCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button weiter;
    }
}