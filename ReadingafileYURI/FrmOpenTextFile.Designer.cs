namespace ReadingafileYURI
{
    partial class FrmOpenTextFile
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
            this.btnFinder = new System.Windows.Forms.Button();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinder
            // 
            this.btnFinder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFinder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinder.Location = new System.Drawing.Point(597, 123);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(101, 205);
            this.btnFinder.TabIndex = 9;
            this.btnFinder.Text = "Finder";
            this.btnFinder.UseVisualStyleBackColor = false;
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(210, 123);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(377, 205);
            this.lvShowText.TabIndex = 8;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpen.Location = new System.Drawing.Point(102, 123);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(102, 205);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinder);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinder;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnOpen;
    }
}

