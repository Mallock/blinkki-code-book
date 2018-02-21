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
            this.lstSuggestions = new System.Windows.Forms.ListBox();
            this.browserContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openLinkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserTools = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.txtToolUrl = new System.Windows.Forms.ToolStripTextBox();
            this.pnlBrowser.SuspendLayout();
            this.browserContextMenu.SuspendLayout();
            this.browserTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBrowser.Controls.Add(this.lstSuggestions);
            this.pnlBrowser.Location = new System.Drawing.Point(0, 23);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(840, 374);
            this.pnlBrowser.TabIndex = 0;
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSuggestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuggestions.FormattingEnabled = true;
            this.lstSuggestions.ItemHeight = 21;
            this.lstSuggestions.Location = new System.Drawing.Point(70, -1);
            this.lstSuggestions.Name = "lstSuggestions";
            this.lstSuggestions.Size = new System.Drawing.Size(720, 149);
            this.lstSuggestions.TabIndex = 5;
            this.lstSuggestions.Visible = false;
            this.lstSuggestions.SelectedIndexChanged += new System.EventHandler(this.lstSuggestions_SelectedIndexChanged);
            this.lstSuggestions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstSuggestions_MouseDown);
            this.lstSuggestions.MouseHover += new System.EventHandler(this.lstSuggestions_MouseHover);
            this.lstSuggestions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstSuggestions_MouseMove);
            // 
            // browserContextMenu
            // 
            this.browserContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLinkInToolStripMenuItem});
            this.browserContextMenu.Name = "browserContextMenu";
            this.browserContextMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // openLinkInToolStripMenuItem
            // 
            this.openLinkInToolStripMenuItem.Name = "openLinkInToolStripMenuItem";
            this.openLinkInToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openLinkInToolStripMenuItem.Text = "&Avaa";
            this.openLinkInToolStripMenuItem.Click += new System.EventHandler(this.openLinkInToolStripMenuItem_Click);
            // 
            // browserTools
            // 
            this.browserTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.btnReload,
            this.txtToolUrl});
            this.browserTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.browserTools.Location = new System.Drawing.Point(0, 0);
            this.browserTools.Name = "browserTools";
            this.browserTools.Size = new System.Drawing.Size(840, 23);
            this.browserTools.TabIndex = 1;
            this.browserTools.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 20);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 20);
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(23, 20);
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtToolUrl
            // 
            this.txtToolUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolUrl.Name = "txtToolUrl";
            this.txtToolUrl.Size = new System.Drawing.Size(720, 22);
            this.txtToolUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtToolUrl_KeyUp);
            this.txtToolUrl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtToolUrl_MouseUp);
            this.txtToolUrl.TextChanged += new System.EventHandler(this.txtToolUrl_TextChanged);
            // 
            // web_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 395);
            this.Controls.Add(this.browserTools);
            this.Controls.Add(this.pnlBrowser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "web_view";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.web_view_Load);
            this.Shown += new System.EventHandler(this.web_view_Shown);
            this.pnlBrowser.ResumeLayout(false);
            this.browserContextMenu.ResumeLayout(false);
            this.browserTools.ResumeLayout(false);
            this.browserTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.ContextMenuStrip browserContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openLinkInToolStripMenuItem;
        private System.Windows.Forms.ToolStrip browserTools;
        private System.Windows.Forms.ToolStripTextBox txtToolUrl;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ListBox lstSuggestions;
    }
}

