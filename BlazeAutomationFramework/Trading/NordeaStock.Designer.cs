
namespace BlazeAutomationFramework.Trading
{
    partial class NordeaStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NordeaStock));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpStockSettings = new System.Windows.Forms.GroupBox();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.mnuStockMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpStockSettings.SuspendLayout();
            this.mnuStockMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpStockSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 567);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpStockSettings
            // 
            this.grpStockSettings.Controls.Add(this.pnlStock);
            this.grpStockSettings.Controls.Add(this.mnuStockMain);
            this.grpStockSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStockSettings.Location = new System.Drawing.Point(0, 0);
            this.grpStockSettings.Name = "grpStockSettings";
            this.grpStockSettings.Size = new System.Drawing.Size(366, 567);
            this.grpStockSettings.TabIndex = 0;
            this.grpStockSettings.TabStop = false;
            this.grpStockSettings.Text = "Stock";
            // 
            // pnlStock
            // 
            this.pnlStock.AutoScroll = true;
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(3, 40);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(360, 524);
            this.pnlStock.TabIndex = 0;
            // 
            // mnuStockMain
            // 
            this.mnuStockMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuStockMain.Location = new System.Drawing.Point(3, 16);
            this.mnuStockMain.Name = "mnuStockMain";
            this.mnuStockMain.Size = new System.Drawing.Size(360, 24);
            this.mnuStockMain.TabIndex = 1;
            this.mnuStockMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowser.Location = new System.Drawing.Point(0, 0);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(730, 567);
            this.pnlBrowser.TabIndex = 0;
            // 
            // NordeaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 567);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStockMain;
            this.Name = "NordeaStock";
            this.Text = "NordeaStock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NordeaStock_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpStockSettings.ResumeLayout(false);
            this.grpStockSettings.PerformLayout();
            this.mnuStockMain.ResumeLayout(false);
            this.mnuStockMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpStockSettings;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.MenuStrip mnuStockMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}