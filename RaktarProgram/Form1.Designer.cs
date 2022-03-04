
namespace RaktarProgram
{
    partial class Storage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékekToolStripMenuItem,
            this.eladásToolStripMenuItem,
            this.statisztikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékekToolStripMenuItem
            // 
            this.termékekToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.termékekToolStripMenuItem.Name = "termékekToolStripMenuItem";
            this.termékekToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.termékekToolStripMenuItem.Text = "Termékek";
            this.termékekToolStripMenuItem.Visible = false;
            this.termékekToolStripMenuItem.Click += new System.EventHandler(this.TermékekToolStripMenuItem_Click);
            // 
            // eladásToolStripMenuItem
            // 
            this.eladásToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eladásToolStripMenuItem.Name = "eladásToolStripMenuItem";
            this.eladásToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.eladásToolStripMenuItem.Text = "Eladás";
            this.eladásToolStripMenuItem.Visible = false;
            this.eladásToolStripMenuItem.Click += new System.EventHandler(this.EladásToolStripMenuItem_Click);
            // 
            // statisztikaToolStripMenuItem
            // 
            this.statisztikaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statisztikaToolStripMenuItem.Name = "statisztikaToolStripMenuItem";
            this.statisztikaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.statisztikaToolStripMenuItem.Text = "Statisztika";
            this.statisztikaToolStripMenuItem.Visible = false;
            this.statisztikaToolStripMenuItem.Click += new System.EventHandler(this.StatisztikaToolStripMenuItem_Click);
            // 
            // myPanel
            // 
            this.myPanel.Location = new System.Drawing.Point(12, 27);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(474, 265);
            this.myPanel.TabIndex = 2;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(498, 304);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Storage";
            this.Text = "Szertár";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eladásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisztikaToolStripMenuItem;
        private System.Windows.Forms.Panel myPanel;
    }
}

