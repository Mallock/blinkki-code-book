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
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnFav = new System.Windows.Forms.ToolStripDropDownButton();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnNewTab = new System.Windows.Forms.ToolStripButton();
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
            this.pnlBrowser.Size = new System.Drawing.Size(1224, 606);
            this.pnlBrowser.TabIndex = 0;
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSuggestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuggestions.FormattingEnabled = true;
            this.lstSuggestions.ItemHeight = 21;
            this.lstSuggestions.Location = new System.Drawing.Point(111, 0);
            this.lstSuggestions.Name = "lstSuggestions";
            this.lstSuggestions.Size = new System.Drawing.Size(782, 149);
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
            this.btnNewTab,
            this.btnBack,
            this.btnForward,
            this.btnReload,
            this.btnHome,
            this.btnFav,
            this.txtToolUrl});
            this.browserTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.browserTools.Location = new System.Drawing.Point(0, 0);
            this.browserTools.Name = "browserTools";
            this.browserTools.Size = new System.Drawing.Size(1224, 23);
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
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(23, 20);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFav
            // 
            this.btnFav.BackColor = System.Drawing.Color.Transparent;
            this.btnFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFav.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkToolStripMenuItem});
            this.btnFav.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFav.Image = ((System.Drawing.Image)(resources.GetObject("btnFav.Image")));
            this.btnFav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFav.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnFav.Name = "btnFav";
            this.btnFav.ShowDropDownArrow = false;
            this.btnFav.Size = new System.Drawing.Size(20, 20);
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            this.btnFav.MouseHover += new System.EventHandler(this.btnFav_MouseHover);
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.linkToolStripMenuItem.Text = "link";
            // 
            // txtToolUrl
            // 
            this.txtToolUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToolUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolUrl.Name = "txtToolUrl";
            this.txtToolUrl.Size = new System.Drawing.Size(780, 22);
            // 
            // btnNewTab
            // 
            this.btnNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewTab.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTab.Image")));
            this.btnNewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(23, 20);
            this.btnNewTab.Text = "toolStripButton1";
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // web_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 627);
            this.Controls.Add(this.browserTools);
            this.Controls.Add(this.pnlBrowser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "web_view";
            this.Text = "Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.web_view_FormClosing);
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
        private System.Windows.Forms.ToolStripDropDownButton btnFav;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnNewTab;
    }
}

