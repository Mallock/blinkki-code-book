namespace Blinkki_CB
{
    partial class web_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(web_view));
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.browserContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openLinkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowser.Location = new System.Drawing.Point(0, 0);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(545, 342);
            this.pnlBrowser.TabIndex = 0;
            // 
            // browserContextMenu
            // 
            this.browserContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLinkInToolStripMenuItem});
            this.browserContextMenu.Name = "browserContextMenu";
            this.browserContextMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // openLinkInToolStripMenuItem
            // 
            this.openLinkInToolStripMenuItem.Name = "openLinkInToolStripMenuItem";
            this.openLinkInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openLinkInToolStripMenuItem.Text = "&Avaa";
            this.openLinkInToolStripMenuItem.Click += new System.EventHandler(this.openLinkInToolStripMenuItem_Click);
            // 
            // web_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 342);
            this.Controls.Add(this.pnlBrowser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "web_view";
            this.Text = "Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.web_view_FormClosing);
            this.Load += new System.EventHandler(this.web_view_Load);
            this.Shown += new System.EventHandler(this.web_view_Shown);
            this.browserContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.ContextMenuStrip browserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openLinkInToolStripMenuItem;

    }
}

