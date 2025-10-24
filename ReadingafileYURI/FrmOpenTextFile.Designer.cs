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
            this.btnFinder.Location = new System.Drawing.Point(314, 355);
            this.btnFinder.Name = "btnFinder";
            this.btnFinder.Size = new System.Drawing.Size(101, 45);
            this.btnFinder.TabIndex = 9;
            this.btnFinder.Text = "Finder";
            this.btnFinder.UseVisualStyleBackColor = false;
            this.btnFinder.Click += new System.EventHandler(this.btnFinder_Click);
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(38, 79);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(377, 205);
            this.lvShowText.TabIndex = 8;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.SelectedIndexChanged += new System.EventHandler(this.lvShowText_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpen.Location = new System.Drawing.Point(38, 355);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 48);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.btnFinder);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.btnOpen);
            this.Name = "FrmOpenTextFile";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinder;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnOpen;
    }
}

