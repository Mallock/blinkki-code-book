
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NordeaStock));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mnuStockMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStockSettings = new System.Windows.Forms.GroupBox();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.grpBrokerData = new System.Windows.Forms.GroupBox();
            this.picRunning = new System.Windows.Forms.PictureBox();
            this.btnStopAutoTrade = new System.Windows.Forms.Button();
            this.btnStartAutoTrade = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.grpSellingPrice = new System.Windows.Forms.GroupBox();
            this.txtStockSellingPrice = new System.Windows.Forms.TextBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.grpStockValueChange = new System.Windows.Forms.GroupBox();
            this.txtStockValueChange = new System.Windows.Forms.TextBox();
            this.grpBuyingPrice = new System.Windows.Forms.GroupBox();
            this.txtByingPrice = new System.Windows.Forms.TextBox();
            this.grpOwnedValue = new System.Windows.Forms.GroupBox();
            this.txtCurrentStockValue = new System.Windows.Forms.TextBox();
            this.grpOwnedStock = new System.Windows.Forms.GroupBox();
            this.txtOwnedStocks = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.grpBalance = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.grpStockData = new System.Windows.Forms.GroupBox();
            this.btnLoadStockData = new System.Windows.Forms.Button();
            this.grpCurrentPrice = new System.Windows.Forms.GroupBox();
            this.txtCurrentStockPrice = new System.Windows.Forms.TextBox();
            this.grpStockDetails = new System.Windows.Forms.GroupBox();
            this.grpEnd = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.grpStart = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grpStockName = new System.Windows.Forms.GroupBox();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.openStockSettings = new System.Windows.Forms.OpenFileDialog();
            this.stockTimer = new System.Windows.Forms.Timer(this.components);
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mnuStockMain.SuspendLayout();
            this.grpStockSettings.SuspendLayout();
            this.pnlStock.SuspendLayout();
            this.grpBrokerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRunning)).BeginInit();
            this.grpSellingPrice.SuspendLayout();
            this.grpStockValueChange.SuspendLayout();
            this.grpBuyingPrice.SuspendLayout();
            this.grpOwnedValue.SuspendLayout();
            this.grpOwnedStock.SuspendLayout();
            this.grpBalance.SuspendLayout();
            this.grpStockData.SuspendLayout();
            this.grpCurrentPrice.SuspendLayout();
            this.grpStockDetails.SuspendLayout();
            this.grpEnd.SuspendLayout();
            this.grpStart.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpStockName.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.mnuStockMain);
            this.splitContainer1.Panel1.Controls.Add(this.grpStockSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtUrl);
            this.splitContainer1.Panel2.Controls.Add(this.pnlBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 863);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 0;
            // 
            // mnuStockMain
            // 
            this.mnuStockMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuStockMain.Location = new System.Drawing.Point(0, 0);
            this.mnuStockMain.Name = "mnuStockMain";
            this.mnuStockMain.Size = new System.Drawing.Size(420, 24);
            this.mnuStockMain.TabIndex = 2;
            this.mnuStockMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(43, 20);
            this.mnuFile.Text = "Data";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // grpStockSettings
            // 
            this.grpStockSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStockSettings.Controls.Add(this.pnlStock);
            this.grpStockSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStockSettings.Location = new System.Drawing.Point(0, 27);
            this.grpStockSettings.Name = "grpStockSettings";
            this.grpStockSettings.Size = new System.Drawing.Size(420, 836);
            this.grpStockSettings.TabIndex = 0;
            this.grpStockSettings.TabStop = false;
            this.grpStockSettings.Text = "Stock";
            // 
            // pnlStock
            // 
            this.pnlStock.AutoScroll = true;
            this.pnlStock.Controls.Add(this.grpBrokerData);
            this.pnlStock.Controls.Add(this.grpStockData);
            this.pnlStock.Controls.Add(this.grpStockDetails);
            this.pnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStock.Location = new System.Drawing.Point(3, 18);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(414, 815);
            this.pnlStock.TabIndex = 0;
            // 
            // grpBrokerData
            // 
            this.grpBrokerData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBrokerData.Controls.Add(this.picRunning);
            this.grpBrokerData.Controls.Add(this.btnStopAutoTrade);
            this.grpBrokerData.Controls.Add(this.btnStartAutoTrade);
            this.grpBrokerData.Controls.Add(this.btnValue);
            this.grpBrokerData.Controls.Add(this.grpSellingPrice);
            this.grpBrokerData.Controls.Add(this.btnSell);
            this.grpBrokerData.Controls.Add(this.grpStockValueChange);
            this.grpBrokerData.Controls.Add(this.grpBuyingPrice);
            this.grpBrokerData.Controls.Add(this.grpOwnedValue);
            this.grpBrokerData.Controls.Add(this.grpOwnedStock);
            this.grpBrokerData.Controls.Add(this.btnBuy);
            this.grpBrokerData.Controls.Add(this.grpBalance);
            this.grpBrokerData.Location = new System.Drawing.Point(9, 351);
            this.grpBrokerData.Name = "grpBrokerData";
            this.grpBrokerData.Size = new System.Drawing.Size(402, 455);
            this.grpBrokerData.TabIndex = 2;
            this.grpBrokerData.TabStop = false;
            this.grpBrokerData.Text = "Broker Data";
            // 
            // picRunning
            // 
            this.picRunning.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picRunning.ErrorImage")));
            this.picRunning.Image = ((System.Drawing.Image)(resources.GetObject("picRunning.Image")));
            this.picRunning.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRunning.InitialImage")));
            this.picRunning.Location = new System.Drawing.Point(285, 379);
            this.picRunning.Name = "picRunning";
            this.picRunning.Size = new System.Drawing.Size(70, 70);
            this.picRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRunning.TabIndex = 11;
            this.picRunning.TabStop = false;
            this.picRunning.Visible = false;
            // 
            // btnStopAutoTrade
            // 
            this.btnStopAutoTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopAutoTrade.Location = new System.Drawing.Point(157, 379);
            this.btnStopAutoTrade.Name = "btnStopAutoTrade";
            this.btnStopAutoTrade.Size = new System.Drawing.Size(122, 32);
            this.btnStopAutoTrade.TabIndex = 10;
            this.btnStopAutoTrade.Text = "Stop Auto Trade";
            this.btnStopAutoTrade.UseVisualStyleBackColor = true;
            this.btnStopAutoTrade.Click += new System.EventHandler(this.btnStopAutoTrade_Click);
            // 
            // btnStartAutoTrade
            // 
            this.btnStartAutoTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartAutoTrade.Location = new System.Drawing.Point(12, 379);
            this.btnStartAutoTrade.Name = "btnStartAutoTrade";
            this.btnStartAutoTrade.Size = new System.Drawing.Size(139, 32);
            this.btnStartAutoTrade.TabIndex = 9;
            this.btnStartAutoTrade.Text = "Start Auto Trade";
            this.btnStartAutoTrade.UseVisualStyleBackColor = true;
            this.btnStartAutoTrade.Click += new System.EventHandler(this.btnStartAutoTrade_Click);
            // 
            // btnValue
            // 
            this.btnValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnValue.Location = new System.Drawing.Point(174, 417);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(105, 32);
            this.btnValue.TabIndex = 8;
            this.btnValue.Text = "Value change";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // grpSellingPrice
            // 
            this.grpSellingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSellingPrice.Controls.Add(this.txtStockSellingPrice);
            this.grpSellingPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpSellingPrice.Location = new System.Drawing.Point(6, 306);
            this.grpSellingPrice.Name = "grpSellingPrice";
            this.grpSellingPrice.Size = new System.Drawing.Size(390, 54);
            this.grpSellingPrice.TabIndex = 7;
            this.grpSellingPrice.TabStop = false;
            this.grpSellingPrice.Text = "Stock selling price";
            // 
            // txtStockSellingPrice
            // 
            this.txtStockSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStockSellingPrice.Location = new System.Drawing.Point(3, 18);
            this.txtStockSellingPrice.Name = "txtStockSellingPrice";
            this.txtStockSellingPrice.Size = new System.Drawing.Size(384, 22);
            this.txtStockSellingPrice.TabIndex = 0;
            // 
            // btnSell
            // 
            this.btnSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSell.Location = new System.Drawing.Point(93, 417);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 32);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // grpStockValueChange
            // 
            this.grpStockValueChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStockValueChange.Controls.Add(this.txtStockValueChange);
            this.grpStockValueChange.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpStockValueChange.Location = new System.Drawing.Point(6, 246);
            this.grpStockValueChange.Name = "grpStockValueChange";
            this.grpStockValueChange.Size = new System.Drawing.Size(390, 54);
            this.grpStockValueChange.TabIndex = 5;
            this.grpStockValueChange.TabStop = false;
            this.grpStockValueChange.Text = "Stock value change";
            // 
            // txtStockValueChange
            // 
            this.txtStockValueChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStockValueChange.Location = new System.Drawing.Point(3, 18);
            this.txtStockValueChange.Name = "txtStockValueChange";
            this.txtStockValueChange.Size = new System.Drawing.Size(384, 22);
            this.txtStockValueChange.TabIndex = 0;
            // 
            // grpBuyingPrice
            // 
            this.grpBuyingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBuyingPrice.Controls.Add(this.txtByingPrice);
            this.grpBuyingPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBuyingPrice.Location = new System.Drawing.Point(6, 186);
            this.grpBuyingPrice.Name = "grpBuyingPrice";
            this.grpBuyingPrice.Size = new System.Drawing.Size(390, 54);
            this.grpBuyingPrice.TabIndex = 4;
            this.grpBuyingPrice.TabStop = false;
            this.grpBuyingPrice.Text = "Stock buying price";
            // 
            // txtByingPrice
            // 
            this.txtByingPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtByingPrice.Location = new System.Drawing.Point(3, 18);
            this.txtByingPrice.Name = "txtByingPrice";
            this.txtByingPrice.Size = new System.Drawing.Size(384, 22);
            this.txtByingPrice.TabIndex = 0;
            // 
            // grpOwnedValue
            // 
            this.grpOwnedValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOwnedValue.Controls.Add(this.txtCurrentStockValue);
            this.grpOwnedValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpOwnedValue.Location = new System.Drawing.Point(6, 126);
            this.grpOwnedValue.Name = "grpOwnedValue";
            this.grpOwnedValue.Size = new System.Drawing.Size(390, 54);
            this.grpOwnedValue.TabIndex = 3;
            this.grpOwnedValue.TabStop = false;
            this.grpOwnedValue.Text = "Current owned stock value";
            // 
            // txtCurrentStockValue
            // 
            this.txtCurrentStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentStockValue.Location = new System.Drawing.Point(3, 18);
            this.txtCurrentStockValue.Name = "txtCurrentStockValue";
            this.txtCurrentStockValue.Size = new System.Drawing.Size(384, 22);
            this.txtCurrentStockValue.TabIndex = 0;
            // 
            // grpOwnedStock
            // 
            this.grpOwnedStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOwnedStock.Controls.Add(this.txtOwnedStocks);
            this.grpOwnedStock.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpOwnedStock.Location = new System.Drawing.Point(6, 70);
            this.grpOwnedStock.Name = "grpOwnedStock";
            this.grpOwnedStock.Size = new System.Drawing.Size(390, 50);
            this.grpOwnedStock.TabIndex = 2;
            this.grpOwnedStock.TabStop = false;
            this.grpOwnedStock.Text = "Owned stock amount";
            // 
            // txtOwnedStocks
            // 
            this.txtOwnedStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOwnedStocks.Location = new System.Drawing.Point(3, 18);
            this.txtOwnedStocks.Name = "txtOwnedStocks";
            this.txtOwnedStocks.Size = new System.Drawing.Size(384, 22);
            this.txtOwnedStocks.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuy.Location = new System.Drawing.Point(12, 417);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 32);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // grpBalance
            // 
            this.grpBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBalance.Controls.Add(this.txtBalance);
            this.grpBalance.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBalance.Location = new System.Drawing.Point(6, 19);
            this.grpBalance.Name = "grpBalance";
            this.grpBalance.Size = new System.Drawing.Size(390, 45);
            this.grpBalance.TabIndex = 0;
            this.grpBalance.TabStop = false;
            this.grpBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBalance.Location = new System.Drawing.Point(3, 18);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(384, 22);
            this.txtBalance.TabIndex = 0;
            // 
            // grpStockData
            // 
            this.grpStockData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStockData.Controls.Add(this.btnLoadStockData);
            this.grpStockData.Controls.Add(this.grpCurrentPrice);
            this.grpStockData.Location = new System.Drawing.Point(9, 225);
            this.grpStockData.Name = "grpStockData";
            this.grpStockData.Size = new System.Drawing.Size(402, 120);
            this.grpStockData.TabIndex = 1;
            this.grpStockData.TabStop = false;
            this.grpStockData.Text = "Stock Data";
            // 
            // btnLoadStockData
            // 
            this.btnLoadStockData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadStockData.Location = new System.Drawing.Point(12, 91);
            this.btnLoadStockData.Name = "btnLoadStockData";
            this.btnLoadStockData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadStockData.TabIndex = 1;
            this.btnLoadStockData.Text = "Load";
            this.btnLoadStockData.UseVisualStyleBackColor = true;
            this.btnLoadStockData.Click += new System.EventHandler(this.btnLoadStockData_Click);
            // 
            // grpCurrentPrice
            // 
            this.grpCurrentPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCurrentPrice.Controls.Add(this.txtCurrentStockPrice);
            this.grpCurrentPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpCurrentPrice.Location = new System.Drawing.Point(6, 19);
            this.grpCurrentPrice.Name = "grpCurrentPrice";
            this.grpCurrentPrice.Size = new System.Drawing.Size(390, 58);
            this.grpCurrentPrice.TabIndex = 0;
            this.grpCurrentPrice.TabStop = false;
            this.grpCurrentPrice.Text = "Current price";
            // 
            // txtCurrentStockPrice
            // 
            this.txtCurrentStockPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentStockPrice.Location = new System.Drawing.Point(3, 18);
            this.txtCurrentStockPrice.Name = "txtCurrentStockPrice";
            this.txtCurrentStockPrice.Size = new System.Drawing.Size(384, 22);
            this.txtCurrentStockPrice.TabIndex = 0;
            // 
            // grpStockDetails
            // 
            this.grpStockDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStockDetails.Controls.Add(this.grpEnd);
            this.grpStockDetails.Controls.Add(this.grpStart);
            this.grpStockDetails.Controls.Add(this.grpAddress);
            this.grpStockDetails.Controls.Add(this.grpStockName);
            this.grpStockDetails.Location = new System.Drawing.Point(9, 3);
            this.grpStockDetails.Name = "grpStockDetails";
            this.grpStockDetails.Size = new System.Drawing.Size(402, 216);
            this.grpStockDetails.TabIndex = 0;
            this.grpStockDetails.TabStop = false;
            this.grpStockDetails.Text = "Stock Details";
            // 
            // grpEnd
            // 
            this.grpEnd.Controls.Add(this.dtpEnd);
            this.grpEnd.Location = new System.Drawing.Point(113, 147);
            this.grpEnd.Name = "grpEnd";
            this.grpEnd.Size = new System.Drawing.Size(98, 51);
            this.grpEnd.TabIndex = 3;
            this.grpEnd.TabStop = false;
            this.grpEnd.Text = "End";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(3, 18);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(92, 22);
            this.dtpEnd.TabIndex = 0;
            // 
            // grpStart
            // 
            this.grpStart.Controls.Add(this.dtpStart);
            this.grpStart.Location = new System.Drawing.Point(9, 147);
            this.grpStart.Name = "grpStart";
            this.grpStart.Size = new System.Drawing.Size(98, 51);
            this.grpStart.TabIndex = 2;
            this.grpStart.TabStop = false;
            this.grpStart.Text = "Start";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(3, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(92, 22);
            this.dtpStart.TabIndex = 0;
            // 
            // grpAddress
            // 
            this.grpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpAddress.Location = new System.Drawing.Point(6, 83);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(390, 58);
            this.grpAddress.TabIndex = 1;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(3, 18);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(384, 22);
            this.txtAddress.TabIndex = 0;
            // 
            // grpStockName
            // 
            this.grpStockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStockName.Controls.Add(this.txtStockName);
            this.grpStockName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpStockName.Location = new System.Drawing.Point(6, 19);
            this.grpStockName.Name = "grpStockName";
            this.grpStockName.Size = new System.Drawing.Size(390, 58);
            this.grpStockName.TabIndex = 0;
            this.grpStockName.TabStop = false;
            this.grpStockName.Text = "Name";
            // 
            // txtStockName
            // 
            this.txtStockName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStockName.Location = new System.Drawing.Point(3, 18);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(384, 22);
            this.txtStockName.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Location = new System.Drawing.Point(0, 0);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(676, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBrowser.Location = new System.Drawing.Point(0, 26);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(676, 837);
            this.pnlBrowser.TabIndex = 0;
            // 
            // openStockSettings
            // 
            this.openStockSettings.Filter = "INI Files |*.ini";
            // 
            // stockTimer
            // 
            this.stockTimer.Interval = 10000;
            this.stockTimer.Tick += new System.EventHandler(this.stockTimer_Tick);
            // 
            // testTimer
            // 
            this.testTimer.Interval = 10000;
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // NordeaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 863);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NordeaStock";
            this.Text = "NordeaStock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NordeaStock_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mnuStockMain.ResumeLayout(false);
            this.mnuStockMain.PerformLayout();
            this.grpStockSettings.ResumeLayout(false);
            this.pnlStock.ResumeLayout(false);
            this.grpBrokerData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRunning)).EndInit();
            this.grpSellingPrice.ResumeLayout(false);
            this.grpSellingPrice.PerformLayout();
            this.grpStockValueChange.ResumeLayout(false);
            this.grpStockValueChange.PerformLayout();
            this.grpBuyingPrice.ResumeLayout(false);
            this.grpBuyingPrice.PerformLayout();
            this.grpOwnedValue.ResumeLayout(false);
            this.grpOwnedValue.PerformLayout();
            this.grpOwnedStock.ResumeLayout(false);
            this.grpOwnedStock.PerformLayout();
            this.grpBalance.ResumeLayout(false);
            this.grpBalance.PerformLayout();
            this.grpStockData.ResumeLayout(false);
            this.grpCurrentPrice.ResumeLayout(false);
            this.grpCurrentPrice.PerformLayout();
            this.grpStockDetails.ResumeLayout(false);
            this.grpEnd.ResumeLayout(false);
            this.grpStart.ResumeLayout(false);
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpStockName.ResumeLayout(false);
            this.grpStockName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpStockSettings;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.GroupBox grpStockDetails;
        private System.Windows.Forms.GroupBox grpStockName;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.OpenFileDialog openStockSettings;
        private System.Windows.Forms.MenuStrip mnuStockMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox grpStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.GroupBox grpStockData;
        private System.Windows.Forms.GroupBox grpCurrentPrice;
        private System.Windows.Forms.TextBox txtCurrentStockPrice;
        private System.Windows.Forms.Button btnLoadStockData;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.GroupBox grpBrokerData;
        private System.Windows.Forms.GroupBox grpOwnedValue;
        private System.Windows.Forms.TextBox txtCurrentStockValue;
        private System.Windows.Forms.GroupBox grpOwnedStock;
        private System.Windows.Forms.TextBox txtOwnedStocks;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox grpBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.GroupBox grpBuyingPrice;
        private System.Windows.Forms.TextBox txtByingPrice;
        private System.Windows.Forms.GroupBox grpStockValueChange;
        private System.Windows.Forms.TextBox txtStockValueChange;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.GroupBox grpSellingPrice;
        private System.Windows.Forms.TextBox txtStockSellingPrice;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnStopAutoTrade;
        private System.Windows.Forms.Button btnStartAutoTrade;
        private System.Windows.Forms.PictureBox picRunning;
        private System.Windows.Forms.Timer stockTimer;
        private System.Windows.Forms.Timer testTimer;
    }
}