namespace MayınTarlası
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grpTarla = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ortaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblSn = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTarla
            // 
            this.grpTarla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTarla.Location = new System.Drawing.Point(12, 61);
            this.grpTarla.Name = "grpTarla";
            this.grpTarla.Size = new System.Drawing.Size(444, 369);
            this.grpTarla.TabIndex = 0;
            this.grpTarla.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem1
            // 
            this.dosyaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem1});
            this.dosyaToolStripMenuItem1.Name = "dosyaToolStripMenuItem1";
            this.dosyaToolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem1.Text = "Dosya";
            // 
            // yeniOyunToolStripMenuItem1
            // 
            this.yeniOyunToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolayToolStripMenuItem1,
            this.ortaToolStripMenuItem1,
            this.zorToolStripMenuItem1});
            this.yeniOyunToolStripMenuItem1.Name = "yeniOyunToolStripMenuItem1";
            this.yeniOyunToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yeniOyunToolStripMenuItem1.Text = "Yeni Oyun";
            // 
            // kolayToolStripMenuItem1
            // 
            this.kolayToolStripMenuItem1.Name = "kolayToolStripMenuItem1";
            this.kolayToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kolayToolStripMenuItem1.Text = "Kolay";
            this.kolayToolStripMenuItem1.Click += new System.EventHandler(this.kolayToolStripMenuItem1_Click);
            // 
            // ortaToolStripMenuItem1
            // 
            this.ortaToolStripMenuItem1.Name = "ortaToolStripMenuItem1";
            this.ortaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ortaToolStripMenuItem1.Text = "Orta";
            this.ortaToolStripMenuItem1.Click += new System.EventHandler(this.ortaToolStripMenuItem1_Click);
            // 
            // zorToolStripMenuItem1
            // 
            this.zorToolStripMenuItem1.Name = "zorToolStripMenuItem1";
            this.zorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zorToolStripMenuItem1.Text = "Zor";
            this.zorToolStripMenuItem1.Click += new System.EventHandler(this.zorToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Süre:";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Location = new System.Drawing.Point(401, 36);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(0, 13);
            this.lblSn.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 442);
            this.Controls.Add(this.lblSn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpTarla);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTarla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kolayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ortaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zorToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblSn;
    }
}

