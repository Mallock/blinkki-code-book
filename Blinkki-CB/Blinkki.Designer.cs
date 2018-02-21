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
            this.mainTools = new System.Windows.Forms.ToolStrip();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.btnStackOveflow = new System.Windows.Forms.ToolStripButton();
            this.btnGoogle = new System.Windows.Forms.ToolStripButton();
            this.mnuMain.SuspendLayout();
            this.mainTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainTools
            // 
            this.mainTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoogle,
            this.btnStackOveflow});
            this.mainTools.Location = new System.Drawing.Point(0, 613);
            this.mainTools.Name = "mainTools";
            this.mainTools.Size = new System.Drawing.Size(1057, 25);
            this.mainTools.TabIndex = 5;
            this.mainTools.Text = "toolStrip2";
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1057, 589);
            this.dockPanel.TabIndex = 6;
            // 
            // btnStackOveflow
            // 
            this.btnStackOveflow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStackOveflow.Image = ((System.Drawing.Image)(resources.GetObject("btnStackOveflow.Image")));
            this.btnStackOveflow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStackOveflow.Name = "btnStackOveflow";
            this.btnStackOveflow.Size = new System.Drawing.Size(23, 22);
            this.btnStackOveflow.Text = "stack overflow";
            this.btnStackOveflow.Click += new System.EventHandler(this.btnStackOveflow_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoogle.Image = ((System.Drawing.Image)(resources.GetObject("btnGoogle.Image")));
            this.btnGoogle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(23, 22);
            this.btnGoogle.Text = "Google";
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // Blinkki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 638);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.mainTools);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Blinkki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blinkki - Code Book";
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
    }
}

