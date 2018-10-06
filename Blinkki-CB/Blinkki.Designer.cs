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
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.applicationsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
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
            this.microsoftMangementConsoleToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // calcToolStripMenuItem
            // 
            this.calcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calcToolStripMenuItem.Image")));
            this.calcToolStripMenuItem.Name = "calcToolStripMenuItem";
            this.calcToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.calcToolStripMenuItem.Text = "Calculator";
            this.calcToolStripMenuItem.Click += new System.EventHandler(this.calcToolStripMenuItem_Click);
            // 
            // microsoftMangementConsoleToolStripMenuItem
            // 
            this.microsoftMangementConsoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("microsoftMangementConsoleToolStripMenuItem.Image")));
            this.microsoftMangementConsoleToolStripMenuItem.Name = "microsoftMangementConsoleToolStripMenuItem";
            this.microsoftMangementConsoleToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.microsoftMangementConsoleToolStripMenuItem.Text = "Microsoft Mangement Console";
            this.microsoftMangementConsoleToolStripMenuItem.Click += new System.EventHandler(this.microsoftMangementConsoleToolStripMenuItem_Click);
            // 
            // mainTools
            // 
            this.mainTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChat,
            this.btnGoogle,
            this.btnStackOveflow,
            this.btnGitHub,
            this.btnIconFinder});
            this.mainTools.Location = new System.Drawing.Point(0, 449);
            this.mainTools.Name = "mainTools";
            this.mainTools.Size = new System.Drawing.Size(1057, 25);
            this.mainTools.TabIndex = 5;
            this.mainTools.Text = "toolStrip2";
            // 
            // btnChat
            // 
            this.btnChat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(23, 22);
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(23, 22);
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnStackOveflow
            // 
            this.btnStackOveflow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStackOveflow.Image = ((System.Drawing.Image)(resources.GetObject("btnStackOveflow.Image")));
            this.btnStackOveflow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStackOveflow.Name = "btnStackOveflow";
            this.btnStackOveflow.Size = new System.Drawing.Size(23, 22);
            this.btnStackOveflow.Click += new System.EventHandler(this.btnStackOveflow_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(23, 22);
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnIconFinder
            // 
            this.btnIconFinder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIconFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnIconFinder.Image")));
            this.btnIconFinder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIconFinder.Name = "btnIconFinder";
            this.btnIconFinder.Size = new System.Drawing.Size(23, 22);
            this.btnIconFinder.Click += new System.EventHandler(this.btnIconFinder_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1057, 425);
            this.dockPanel.TabIndex = 6;
            // 
            // Blinkki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 474);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.mainTools);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
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
    }
}

