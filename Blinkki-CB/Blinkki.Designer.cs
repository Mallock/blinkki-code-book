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
            this.btnFavs = new System.Windows.Forms.ToolStripButton();
            this.btnBlinkki = new System.Windows.Forms.ToolStripButton();
            this.btnChat = new System.Windows.Forms.ToolStripButton();
            this.btnGoogle = new System.Windows.Forms.ToolStripButton();
            this.btnStackOveflow = new System.Windows.Forms.ToolStripButton();
            this.btnGitHub = new System.Windows.Forms.ToolStripButton();
            this.btnIconFinder = new System.Windows.Forms.ToolStripButton();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
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
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1409, 28);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcToolStripMenuItem,
            this.microsoftMangementConsoleToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // calcToolStripMenuItem
            // 
            this.calcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calcToolStripMenuItem.Image")));
            this.calcToolStripMenuItem.Name = "calcToolStripMenuItem";
            this.calcToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.calcToolStripMenuItem.Text = "Calculator";
            this.calcToolStripMenuItem.Click += new System.EventHandler(this.calcToolStripMenuItem_Click);
            // 
            // microsoftMangementConsoleToolStripMenuItem
            // 
            this.microsoftMangementConsoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("microsoftMangementConsoleToolStripMenuItem.Image")));
            this.microsoftMangementConsoleToolStripMenuItem.Name = "microsoftMangementConsoleToolStripMenuItem";
            this.microsoftMangementConsoleToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.microsoftMangementConsoleToolStripMenuItem.Text = "Microsoft Mangement Console";
            this.microsoftMangementConsoleToolStripMenuItem.Click += new System.EventHandler(this.microsoftMangementConsoleToolStripMenuItem_Click);
            // 
            // mainTools
            // 
            this.mainTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFavs,
            this.btnBlinkki,
            this.btnChat,
            this.btnGoogle,
            this.btnStackOveflow,
            this.btnGitHub,
            this.btnIconFinder});
            this.mainTools.Location = new System.Drawing.Point(0, 28);
            this.mainTools.Name = "mainTools";
            this.mainTools.Size = new System.Drawing.Size(1409, 27);
            this.mainTools.TabIndex = 5;
            this.mainTools.Text = "toolStrip2";
            // 
            // btnFavs
            // 
            this.btnFavs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavs.Image = global::Blinkki_CB.Properties.Resources.no_fav;
            this.btnFavs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavs.Name = "btnFavs";
            this.btnFavs.Size = new System.Drawing.Size(24, 24);
            this.btnFavs.Click += new System.EventHandler(this.btnFavs_Click);
            // 
            // btnBlinkki
            // 
            this.btnBlinkki.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBlinkki.Image = ((System.Drawing.Image)(resources.GetObject("btnBlinkki.Image")));
            this.btnBlinkki.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlinkki.Name = "btnBlinkki";
            this.btnBlinkki.Size = new System.Drawing.Size(24, 24);
            this.btnBlinkki.Click += new System.EventHandler(this.btnBlinkki_Click);
            // 
            // btnChat
            // 
            this.btnChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(24, 24);
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(24, 24);
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnStackOveflow
            // 
            this.btnStackOveflow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStackOveflow.Image = ((System.Drawing.Image)(resources.GetObject("btnStackOveflow.Image")));
            this.btnStackOveflow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStackOveflow.Name = "btnStackOveflow";
            this.btnStackOveflow.Size = new System.Drawing.Size(24, 24);
            this.btnStackOveflow.Click += new System.EventHandler(this.btnStackOveflow_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(24, 24);
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnIconFinder
            // 
            this.btnIconFinder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIconFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnIconFinder.Image")));
            this.btnIconFinder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIconFinder.Name = "btnIconFinder";
            this.btnIconFinder.Size = new System.Drawing.Size(24, 24);
            this.btnIconFinder.Click += new System.EventHandler(this.btnIconFinder_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 55);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1409, 528);
            this.dockPanel.TabIndex = 6;
            // 
            // Blinkki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 583);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.mainTools);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripButton btnStackOveflow;
        private System.Windows.Forms.ToolStripButton btnGoogle;
        private System.Windows.Forms.ToolStripButton btnGitHub;
        private System.Windows.Forms.ToolStripButton btnIconFinder;
        private System.Windows.Forms.ToolStripButton btnChat;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftMangementConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBlinkki;
        private System.Windows.Forms.ToolStripButton btnFavs;
    }
}

