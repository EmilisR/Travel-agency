namespace Travel_Agency
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addWorker = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.clientsQuantity = new System.Windows.Forms.Label();
            this.offersQuantity = new System.Windows.Forms.Label();
            this.ordersQuantity = new System.Windows.Forms.Label();
            this.addOffer = new System.Windows.Forms.Button();
            this.showWorkersButton = new System.Windows.Forms.Button();
            this.showOrdersButton = new System.Windows.Forms.Button();
            this.showClientsButton = new System.Windows.Forms.Button();
            this.activeOrders = new System.Windows.Forms.Label();
            this.nearestReturnsButton = new System.Windows.Forms.Button();
            this.showOffersButton = new System.Windows.Forms.Button();
            this.workersQuantity = new System.Windows.Forms.Label();
            this.budgetBalance = new System.Windows.Forms.Label();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.payOutSalaryButton = new System.Windows.Forms.Button();
            this.changeWorkerPositionButton = new System.Windows.Forms.Button();
            this.raiseCutSalaryButton = new System.Windows.Forms.Button();
            this.showWorkerOrdersbutton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.addDeleteTab = new System.Windows.Forms.TabPage();
            this.workerTab = new System.Windows.Forms.TabPage();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.chartsTab = new System.Windows.Forms.TabControl();
            this.positionsTab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.maxSalariesTab = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.emailTab = new System.Windows.Forms.TabPage();
            this.minSalariesTab = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datesPricesTab = new System.Windows.Forms.TabPage();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.addDeleteTab.SuspendLayout();
            this.workerTab.SuspendLayout();
            this.statisticsTab.SuspendLayout();
            this.chartsTab.SuspendLayout();
            this.positionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.maxSalariesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.emailTab.SuspendLayout();
            this.minSalariesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.datesPricesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // addWorker
            // 
            this.addWorker.Location = new System.Drawing.Point(6, 6);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(321, 55);
            this.addWorker.TabIndex = 1;
            this.addWorker.Text = "Add worker";
            this.addWorker.UseVisualStyleBackColor = true;
            this.addWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(6, 128);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(321, 55);
            this.addClient.TabIndex = 3;
            this.addClient.Text = "Add client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(6, 67);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(321, 55);
            this.addOrder.TabIndex = 2;
            this.addOrder.Text = "Add order";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // clientsQuantity
            // 
            this.clientsQuantity.AutoSize = true;
            this.clientsQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.clientsQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientsQuantity.Location = new System.Drawing.Point(605, 96);
            this.clientsQuantity.Name = "clientsQuantity";
            this.clientsQuantity.Size = new System.Drawing.Size(2, 31);
            this.clientsQuantity.TabIndex = 4;
            // 
            // offersQuantity
            // 
            this.offersQuantity.AutoSize = true;
            this.offersQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.offersQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offersQuantity.Location = new System.Drawing.Point(605, 38);
            this.offersQuantity.Name = "offersQuantity";
            this.offersQuantity.Size = new System.Drawing.Size(2, 31);
            this.offersQuantity.TabIndex = 5;
            // 
            // ordersQuantity
            // 
            this.ordersQuantity.AutoSize = true;
            this.ordersQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.ordersQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersQuantity.Location = new System.Drawing.Point(605, 67);
            this.ordersQuantity.Name = "ordersQuantity";
            this.ordersQuantity.Size = new System.Drawing.Size(2, 31);
            this.ordersQuantity.TabIndex = 6;
            // 
            // addOffer
            // 
            this.addOffer.Location = new System.Drawing.Point(6, 189);
            this.addOffer.Name = "addOffer";
            this.addOffer.Size = new System.Drawing.Size(321, 55);
            this.addOffer.TabIndex = 4;
            this.addOffer.Text = "Add offer";
            this.addOffer.UseVisualStyleBackColor = true;
            this.addOffer.Click += new System.EventHandler(this.AddOffer_Click);
            // 
            // showWorkersButton
            // 
            this.showWorkersButton.Location = new System.Drawing.Point(333, 6);
            this.showWorkersButton.Name = "showWorkersButton";
            this.showWorkersButton.Size = new System.Drawing.Size(404, 55);
            this.showWorkersButton.TabIndex = 5;
            this.showWorkersButton.Text = "Show/delete workers";
            this.showWorkersButton.UseVisualStyleBackColor = true;
            this.showWorkersButton.Click += new System.EventHandler(this.ShowWorkersButton_Click);
            // 
            // showOrdersButton
            // 
            this.showOrdersButton.Location = new System.Drawing.Point(333, 67);
            this.showOrdersButton.Name = "showOrdersButton";
            this.showOrdersButton.Size = new System.Drawing.Size(404, 55);
            this.showOrdersButton.TabIndex = 6;
            this.showOrdersButton.Text = "Show/delete orders";
            this.showOrdersButton.UseVisualStyleBackColor = true;
            this.showOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // showClientsButton
            // 
            this.showClientsButton.Location = new System.Drawing.Point(333, 127);
            this.showClientsButton.Name = "showClientsButton";
            this.showClientsButton.Size = new System.Drawing.Size(404, 56);
            this.showClientsButton.TabIndex = 7;
            this.showClientsButton.Text = "Show/delete clients";
            this.showClientsButton.UseVisualStyleBackColor = true;
            this.showClientsButton.Click += new System.EventHandler(this.ShowClientsButton_Click);
            // 
            // activeOrders
            // 
            this.activeOrders.AutoSize = true;
            this.activeOrders.BackColor = System.Drawing.SystemColors.Control;
            this.activeOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeOrders.Location = new System.Drawing.Point(605, 154);
            this.activeOrders.Name = "activeOrders";
            this.activeOrders.Size = new System.Drawing.Size(2, 31);
            this.activeOrders.TabIndex = 11;
            // 
            // nearestReturnsButton
            // 
            this.nearestReturnsButton.Location = new System.Drawing.Point(6, 250);
            this.nearestReturnsButton.Name = "nearestReturnsButton";
            this.nearestReturnsButton.Size = new System.Drawing.Size(731, 90);
            this.nearestReturnsButton.TabIndex = 9;
            this.nearestReturnsButton.Text = "Show nearest departures";
            this.nearestReturnsButton.UseVisualStyleBackColor = true;
            this.nearestReturnsButton.Click += new System.EventHandler(this.NearestDeparturesButton_Click);
            // 
            // showOffersButton
            // 
            this.showOffersButton.Location = new System.Drawing.Point(333, 189);
            this.showOffersButton.Name = "showOffersButton";
            this.showOffersButton.Size = new System.Drawing.Size(404, 55);
            this.showOffersButton.TabIndex = 8;
            this.showOffersButton.Text = "Show/delete offers";
            this.showOffersButton.UseVisualStyleBackColor = true;
            this.showOffersButton.Click += new System.EventHandler(this.ShowOffersButton_Click);
            // 
            // workersQuantity
            // 
            this.workersQuantity.AutoSize = true;
            this.workersQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.workersQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workersQuantity.Location = new System.Drawing.Point(605, 125);
            this.workersQuantity.Name = "workersQuantity";
            this.workersQuantity.Size = new System.Drawing.Size(2, 31);
            this.workersQuantity.TabIndex = 13;
            // 
            // budgetBalance
            // 
            this.budgetBalance.AutoSize = true;
            this.budgetBalance.Location = new System.Drawing.Point(605, 179);
            this.budgetBalance.Name = "budgetBalance";
            this.budgetBalance.Size = new System.Drawing.Size(0, 29);
            this.budgetBalance.TabIndex = 14;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(16, 12);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(711, 315);
            this.sendEmailButton.TabIndex = 15;
            this.sendEmailButton.Text = "Send information by E-mail";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // payOutSalaryButton
            // 
            this.payOutSalaryButton.Location = new System.Drawing.Point(6, 6);
            this.payOutSalaryButton.Name = "payOutSalaryButton";
            this.payOutSalaryButton.Size = new System.Drawing.Size(731, 78);
            this.payOutSalaryButton.TabIndex = 16;
            this.payOutSalaryButton.Text = "Pay out salary to worker";
            this.payOutSalaryButton.UseVisualStyleBackColor = true;
            this.payOutSalaryButton.Click += new System.EventHandler(this.PayOutSalaryButton_Click);
            // 
            // changeWorkerPositionButton
            // 
            this.changeWorkerPositionButton.Location = new System.Drawing.Point(6, 90);
            this.changeWorkerPositionButton.Name = "changeWorkerPositionButton";
            this.changeWorkerPositionButton.Size = new System.Drawing.Size(731, 78);
            this.changeWorkerPositionButton.TabIndex = 18;
            this.changeWorkerPositionButton.Text = "Change worker\'s position";
            this.changeWorkerPositionButton.UseVisualStyleBackColor = true;
            this.changeWorkerPositionButton.Click += new System.EventHandler(this.ChangeWorkerPositionButton_Click);
            // 
            // raiseCutSalaryButton
            // 
            this.raiseCutSalaryButton.Location = new System.Drawing.Point(6, 174);
            this.raiseCutSalaryButton.Name = "raiseCutSalaryButton";
            this.raiseCutSalaryButton.Size = new System.Drawing.Size(731, 78);
            this.raiseCutSalaryButton.TabIndex = 19;
            this.raiseCutSalaryButton.Text = "Raise/cut salary";
            this.raiseCutSalaryButton.UseVisualStyleBackColor = true;
            this.raiseCutSalaryButton.Click += new System.EventHandler(this.RaiseCutSalaryButton_Click);
            // 
            // showWorkerOrdersbutton
            // 
            this.showWorkerOrdersbutton.Location = new System.Drawing.Point(6, 258);
            this.showWorkerOrdersbutton.Name = "showWorkerOrdersbutton";
            this.showWorkerOrdersbutton.Size = new System.Drawing.Size(731, 78);
            this.showWorkerOrdersbutton.TabIndex = 20;
            this.showWorkerOrdersbutton.Text = "Show worker\'s orders";
            this.showWorkerOrdersbutton.UseVisualStyleBackColor = true;
            this.showWorkerOrdersbutton.Click += new System.EventHandler(this.ShowWorkerOrdersbutton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addDeleteTab);
            this.tabControl.Controls.Add(this.workerTab);
            this.tabControl.Controls.Add(this.statisticsTab);
            this.tabControl.Controls.Add(this.emailTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(763, 403);
            this.tabControl.TabIndex = 21;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // addDeleteTab
            // 
            this.addDeleteTab.Controls.Add(this.showOrdersButton);
            this.addDeleteTab.Controls.Add(this.addWorker);
            this.addDeleteTab.Controls.Add(this.addClient);
            this.addDeleteTab.Controls.Add(this.addOrder);
            this.addDeleteTab.Controls.Add(this.nearestReturnsButton);
            this.addDeleteTab.Controls.Add(this.addOffer);
            this.addDeleteTab.Controls.Add(this.showWorkersButton);
            this.addDeleteTab.Controls.Add(this.showClientsButton);
            this.addDeleteTab.Controls.Add(this.showOffersButton);
            this.addDeleteTab.Location = new System.Drawing.Point(10, 47);
            this.addDeleteTab.Name = "addDeleteTab";
            this.addDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.addDeleteTab.Size = new System.Drawing.Size(743, 346);
            this.addDeleteTab.TabIndex = 0;
            this.addDeleteTab.Text = "Add/show/delete";
            this.addDeleteTab.UseVisualStyleBackColor = true;
            // 
            // workerTab
            // 
            this.workerTab.Controls.Add(this.payOutSalaryButton);
            this.workerTab.Controls.Add(this.showWorkerOrdersbutton);
            this.workerTab.Controls.Add(this.changeWorkerPositionButton);
            this.workerTab.Controls.Add(this.raiseCutSalaryButton);
            this.workerTab.Location = new System.Drawing.Point(10, 47);
            this.workerTab.Name = "workerTab";
            this.workerTab.Padding = new System.Windows.Forms.Padding(3);
            this.workerTab.Size = new System.Drawing.Size(743, 346);
            this.workerTab.TabIndex = 1;
            this.workerTab.Text = "Worker\'s management";
            this.workerTab.UseVisualStyleBackColor = true;
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.chartsTab);
            this.statisticsTab.Controls.Add(this.clientsQuantity);
            this.statisticsTab.Controls.Add(this.offersQuantity);
            this.statisticsTab.Controls.Add(this.budgetBalance);
            this.statisticsTab.Controls.Add(this.ordersQuantity);
            this.statisticsTab.Controls.Add(this.workersQuantity);
            this.statisticsTab.Controls.Add(this.activeOrders);
            this.statisticsTab.Location = new System.Drawing.Point(10, 47);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Size = new System.Drawing.Size(743, 346);
            this.statisticsTab.TabIndex = 2;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            // 
            // chartsTab
            // 
            this.chartsTab.Controls.Add(this.positionsTab);
            this.chartsTab.Controls.Add(this.maxSalariesTab);
            this.chartsTab.Controls.Add(this.minSalariesTab);
            this.chartsTab.Controls.Add(this.datesPricesTab);
            this.chartsTab.Location = new System.Drawing.Point(12, 16);
            this.chartsTab.Name = "chartsTab";
            this.chartsTab.SelectedIndex = 0;
            this.chartsTab.Size = new System.Drawing.Size(587, 327);
            this.chartsTab.TabIndex = 15;
            this.chartsTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.chartsTab_Selected);
            // 
            // positionsTab
            // 
            this.positionsTab.Controls.Add(this.chart1);
            this.positionsTab.Location = new System.Drawing.Point(10, 47);
            this.positionsTab.Name = "positionsTab";
            this.positionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.positionsTab.Size = new System.Drawing.Size(567, 270);
            this.positionsTab.TabIndex = 0;
            this.positionsTab.Text = "Positions";
            this.positionsTab.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(555, 258);
            this.chart1.TabIndex = 16;
            // 
            // maxSalariesTab
            // 
            this.maxSalariesTab.Controls.Add(this.chart2);
            this.maxSalariesTab.Location = new System.Drawing.Point(10, 47);
            this.maxSalariesTab.Name = "maxSalariesTab";
            this.maxSalariesTab.Padding = new System.Windows.Forms.Padding(3);
            this.maxSalariesTab.Size = new System.Drawing.Size(567, 270);
            this.maxSalariesTab.TabIndex = 1;
            this.maxSalariesTab.Text = "Highest salaries";
            this.maxSalariesTab.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 6);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(555, 258);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            // 
            // emailTab
            // 
            this.emailTab.Controls.Add(this.sendEmailButton);
            this.emailTab.Location = new System.Drawing.Point(10, 47);
            this.emailTab.Name = "emailTab";
            this.emailTab.Size = new System.Drawing.Size(743, 346);
            this.emailTab.TabIndex = 3;
            this.emailTab.Text = "Send e-mail";
            this.emailTab.UseVisualStyleBackColor = true;
            // 
            // minSalariesTab
            // 
            this.minSalariesTab.Controls.Add(this.chart3);
            this.minSalariesTab.Location = new System.Drawing.Point(10, 47);
            this.minSalariesTab.Name = "minSalariesTab";
            this.minSalariesTab.Padding = new System.Windows.Forms.Padding(3);
            this.minSalariesTab.Size = new System.Drawing.Size(567, 270);
            this.minSalariesTab.TabIndex = 2;
            this.minSalariesTab.Text = "Lowest salaries";
            this.minSalariesTab.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(6, 6);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(555, 258);
            this.chart3.TabIndex = 17;
            // 
            // datesPricesTab
            // 
            this.datesPricesTab.Controls.Add(this.chart4);
            this.datesPricesTab.Location = new System.Drawing.Point(10, 47);
            this.datesPricesTab.Name = "datesPricesTab";
            this.datesPricesTab.Size = new System.Drawing.Size(567, 270);
            this.datesPricesTab.TabIndex = 3;
            this.datesPricesTab.Text = "Travel dates and prices";
            this.datesPricesTab.UseVisualStyleBackColor = true;
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(6, 6);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(555, 258);
            this.chart4.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 429);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Agency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GUI_FormClosed);
            this.Load += new System.EventHandler(this.GUI_Load);
            this.tabControl.ResumeLayout(false);
            this.addDeleteTab.ResumeLayout(false);
            this.workerTab.ResumeLayout(false);
            this.statisticsTab.ResumeLayout(false);
            this.statisticsTab.PerformLayout();
            this.chartsTab.ResumeLayout(false);
            this.positionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.maxSalariesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.emailTab.ResumeLayout(false);
            this.minSalariesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.datesPricesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addWorker;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Label clientsQuantity;
        private System.Windows.Forms.Label offersQuantity;
        private System.Windows.Forms.Label ordersQuantity;
        private System.Windows.Forms.Button addOffer;
        private System.Windows.Forms.Button showWorkersButton;
        private System.Windows.Forms.Button showOrdersButton;
        private System.Windows.Forms.Button showClientsButton;
        private System.Windows.Forms.Label activeOrders;
        private System.Windows.Forms.Button nearestReturnsButton;
        private System.Windows.Forms.Button showOffersButton;
        private System.Windows.Forms.Label workersQuantity;
        private System.Windows.Forms.Label budgetBalance;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Button payOutSalaryButton;
        private System.Windows.Forms.Button changeWorkerPositionButton;
        private System.Windows.Forms.Button raiseCutSalaryButton;
        private System.Windows.Forms.Button showWorkerOrdersbutton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage addDeleteTab;
        private System.Windows.Forms.TabPage workerTab;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.TabPage emailTab;
        private System.Windows.Forms.TabControl chartsTab;
        private System.Windows.Forms.TabPage maxSalariesTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabPage positionsTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage minSalariesTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TabPage datesPricesTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}

