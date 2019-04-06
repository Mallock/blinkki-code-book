namespace Blinkki_CB
{
    partial class Blinkki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blinkki));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftMangementConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTools = new System.Windows.Forms.ToolStrip();
            this.btnBlinkki = new System.Windows.Forms.ToolStripButton();
            this.btnFavs = new System.Windows.Forms.ToolStripButton();
            this.btnChat = new System.Windows.Forms.ToolStripButton();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.registryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.mainTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.applicationsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(1057, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcToolStripMenuItem,
            this.microsoftMangementConsoleToolStripMenuItem,
            this.registryEditorToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // calcToolStripMenuItem
            // 
            this.calcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calcToolStripMenuItem.Image")));
            this.calcToolStripMenuItem.Name = "calcToolStripMenuItem";
            this.calcToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.calcToolStripMenuItem.Text = "Calculator";
            this.calcToolStripMenuItem.Click += new System.EventHandler(this.calcToolStripMenuItem_Click);
            // 
            // microsoftMangementConsoleToolStripMenuItem
            // 
            this.microsoftMangementConsoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("microsoftMangementConsoleToolStripMenuItem.Image")));
            this.microsoftMangementConsoleToolStripMenuItem.Name = "microsoftMangementConsoleToolStripMenuItem";
            this.microsoftMangementConsoleToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.microsoftMangementConsoleToolStripMenuItem.Text = "Microsoft Mangement Console";
            this.microsoftMangementConsoleToolStripMenuItem.Click += new System.EventHandler(this.microsoftMangementConsoleToolStripMenuItem_Click);
            // 
            // mainTools
            // 
            this.mainTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTools.GripMargin = new System.Windows.Forms.Padding(0);
            this.mainTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainTools.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.mainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBlinkki,
            this.btnFavs,
            this.btnChat});
            this.mainTools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainTools.Location = new System.Drawing.Point(0, 563);
            this.mainTools.Name = "mainTools";
            this.mainTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainTools.ShowItemToolTips = false;
            this.mainTools.Size = new System.Drawing.Size(1057, 33);
            this.mainTools.TabIndex = 5;
            // 
            // btnBlinkki
            // 
            this.btnBlinkki.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBlinkki.Image = ((System.Drawing.Image)(resources.GetObject("btnBlinkki.Image")));
            this.btnBlinkki.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlinkki.Name = "btnBlinkki";
            this.btnBlinkki.Size = new System.Drawing.Size(30, 30);
            this.btnBlinkki.Click += new System.EventHandler(this.btnBlinkki_Click);
            // 
            // btnFavs
            // 
            this.btnFavs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavs.Image = ((System.Drawing.Image)(resources.GetObject("btnFavs.Image")));
            this.btnFavs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavs.Name = "btnFavs";
            this.btnFavs.Size = new System.Drawing.Size(30, 30);
            this.btnFavs.Click += new System.EventHandler(this.btnFavs_Click);
            // 
            // btnChat
            // 
            this.btnChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(30, 30);
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1057, 539);
            this.dockPanel.TabIndex = 6;
            // 
            // registryEditorToolStripMenuItem
            // 
            this.registryEditorToolStripMenuItem.Name = "registryEditorToolStripMenuItem";
            this.registryEditorToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.registryEditorToolStripMenuItem.Text = "Registry Editor";
            this.registryEditorToolStripMenuItem.Click += new System.EventHandler(this.registryEditorToolStripMenuItem_Click);
            // 
            // Blinkki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 596);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.mainTools);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(42, 39);
            this.Name = "Blinkki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blinkki - Code Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blinkki_FormClosing);
            this.Shown += new System.EventHandler(this.Blinkki_Shown);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.mainTools.ResumeLayout(false);
            this.mainTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainTools;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripButton btnChat;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftMangementConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBlinkki;
        private System.Windows.Forms.ToolStripButton btnFavs;
        private System.Windows.Forms.ToolStripMenuItem registryEditorToolStripMenuItem;
    }
}

