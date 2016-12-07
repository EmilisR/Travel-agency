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
            this.changeWorkerShiftButton = new System.Windows.Forms.Button();
            this.changeWorkerPositionButton = new System.Windows.Forms.Button();
            this.raiseCutSalaryButton = new System.Windows.Forms.Button();
            this.showWorkerOrdersbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addWorker
            // 
            this.addWorker.Location = new System.Drawing.Point(12, 16);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(116, 23);
            this.addWorker.TabIndex = 1;
            this.addWorker.Text = "Add worker";
            this.addWorker.UseVisualStyleBackColor = true;
            this.addWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(12, 74);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(116, 23);
            this.addClient.TabIndex = 3;
            this.addClient.Text = "Add client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(12, 45);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(116, 23);
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
            this.clientsQuantity.Location = new System.Drawing.Point(282, 79);
            this.clientsQuantity.Name = "clientsQuantity";
            this.clientsQuantity.Size = new System.Drawing.Size(2, 15);
            this.clientsQuantity.TabIndex = 4;
            // 
            // offersQuantity
            // 
            this.offersQuantity.AutoSize = true;
            this.offersQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.offersQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offersQuantity.Location = new System.Drawing.Point(282, 21);
            this.offersQuantity.Name = "offersQuantity";
            this.offersQuantity.Size = new System.Drawing.Size(2, 15);
            this.offersQuantity.TabIndex = 5;
            // 
            // ordersQuantity
            // 
            this.ordersQuantity.AutoSize = true;
            this.ordersQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.ordersQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersQuantity.Location = new System.Drawing.Point(282, 50);
            this.ordersQuantity.Name = "ordersQuantity";
            this.ordersQuantity.Size = new System.Drawing.Size(2, 15);
            this.ordersQuantity.TabIndex = 6;
            // 
            // addOffer
            // 
            this.addOffer.Location = new System.Drawing.Point(12, 103);
            this.addOffer.Name = "addOffer";
            this.addOffer.Size = new System.Drawing.Size(116, 23);
            this.addOffer.TabIndex = 4;
            this.addOffer.Text = "Add offer";
            this.addOffer.UseVisualStyleBackColor = true;
            this.addOffer.Click += new System.EventHandler(this.AddOffer_Click);
            // 
            // showWorkersButton
            // 
            this.showWorkersButton.Location = new System.Drawing.Point(134, 16);
            this.showWorkersButton.Name = "showWorkersButton";
            this.showWorkersButton.Size = new System.Drawing.Size(142, 23);
            this.showWorkersButton.TabIndex = 5;
            this.showWorkersButton.Text = "Show/delete workers";
            this.showWorkersButton.UseVisualStyleBackColor = true;
            this.showWorkersButton.Click += new System.EventHandler(this.ShowWorkersButton_Click);
            // 
            // showOrdersButton
            // 
            this.showOrdersButton.Location = new System.Drawing.Point(134, 45);
            this.showOrdersButton.Name = "showOrdersButton";
            this.showOrdersButton.Size = new System.Drawing.Size(142, 23);
            this.showOrdersButton.TabIndex = 6;
            this.showOrdersButton.Text = "Show/delete orders";
            this.showOrdersButton.UseVisualStyleBackColor = true;
            this.showOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // showClientsButton
            // 
            this.showClientsButton.Location = new System.Drawing.Point(134, 74);
            this.showClientsButton.Name = "showClientsButton";
            this.showClientsButton.Size = new System.Drawing.Size(142, 23);
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
            this.activeOrders.Location = new System.Drawing.Point(282, 137);
            this.activeOrders.Name = "activeOrders";
            this.activeOrders.Size = new System.Drawing.Size(2, 15);
            this.activeOrders.TabIndex = 11;
            // 
            // nearestReturnsButton
            // 
            this.nearestReturnsButton.Location = new System.Drawing.Point(12, 132);
            this.nearestReturnsButton.Name = "nearestReturnsButton";
            this.nearestReturnsButton.Size = new System.Drawing.Size(264, 23);
            this.nearestReturnsButton.TabIndex = 9;
            this.nearestReturnsButton.Text = "Show nearest departures";
            this.nearestReturnsButton.UseVisualStyleBackColor = true;
            this.nearestReturnsButton.Click += new System.EventHandler(this.NearestDeparturesButton_Click);
            // 
            // showOffersButton
            // 
            this.showOffersButton.Location = new System.Drawing.Point(134, 103);
            this.showOffersButton.Name = "showOffersButton";
            this.showOffersButton.Size = new System.Drawing.Size(142, 23);
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
            this.workersQuantity.Location = new System.Drawing.Point(282, 108);
            this.workersQuantity.Name = "workersQuantity";
            this.workersQuantity.Size = new System.Drawing.Size(2, 15);
            this.workersQuantity.TabIndex = 13;
            // 
            // budgetBalance
            // 
            this.budgetBalance.AutoSize = true;
            this.budgetBalance.Location = new System.Drawing.Point(282, 162);
            this.budgetBalance.Name = "budgetBalance";
            this.budgetBalance.Size = new System.Drawing.Size(0, 13);
            this.budgetBalance.TabIndex = 14;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(12, 162);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(264, 23);
            this.sendEmailButton.TabIndex = 15;
            this.sendEmailButton.Text = "Send information by E-mail";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // payOutSalaryButton
            // 
            this.payOutSalaryButton.Location = new System.Drawing.Point(12, 191);
            this.payOutSalaryButton.Name = "payOutSalaryButton";
            this.payOutSalaryButton.Size = new System.Drawing.Size(264, 23);
            this.payOutSalaryButton.TabIndex = 16;
            this.payOutSalaryButton.Text = "Pay out salary to worker";
            this.payOutSalaryButton.UseVisualStyleBackColor = true;
            this.payOutSalaryButton.Click += new System.EventHandler(this.PayOutSalaryButton_Click);
            // 
            // changeWorkerShiftButton
            // 
            this.changeWorkerShiftButton.Location = new System.Drawing.Point(12, 220);
            this.changeWorkerShiftButton.Name = "changeWorkerShiftButton";
            this.changeWorkerShiftButton.Size = new System.Drawing.Size(264, 23);
            this.changeWorkerShiftButton.TabIndex = 17;
            this.changeWorkerShiftButton.Text = "Change worker\'s establishment";
            this.changeWorkerShiftButton.UseVisualStyleBackColor = true;
            this.changeWorkerShiftButton.Click += new System.EventHandler(this.ChangeWorkerShiftButton_Click);
            // 
            // changeWorkerPositionButton
            // 
            this.changeWorkerPositionButton.Location = new System.Drawing.Point(12, 249);
            this.changeWorkerPositionButton.Name = "changeWorkerPositionButton";
            this.changeWorkerPositionButton.Size = new System.Drawing.Size(264, 23);
            this.changeWorkerPositionButton.TabIndex = 18;
            this.changeWorkerPositionButton.Text = "Change worker\'s position";
            this.changeWorkerPositionButton.UseVisualStyleBackColor = true;
            this.changeWorkerPositionButton.Click += new System.EventHandler(this.ChangeWorkerPositionButton_Click);
            // 
            // raiseCutSalaryButton
            // 
            this.raiseCutSalaryButton.Location = new System.Drawing.Point(12, 277);
            this.raiseCutSalaryButton.Name = "raiseCutSalaryButton";
            this.raiseCutSalaryButton.Size = new System.Drawing.Size(264, 23);
            this.raiseCutSalaryButton.TabIndex = 19;
            this.raiseCutSalaryButton.Text = "Raise/cut salary";
            this.raiseCutSalaryButton.UseVisualStyleBackColor = true;
            this.raiseCutSalaryButton.Click += new System.EventHandler(this.RaiseCutSalaryButton_Click);
            // 
            // showWorkerOrdersbutton
            // 
            this.showWorkerOrdersbutton.Location = new System.Drawing.Point(12, 306);
            this.showWorkerOrdersbutton.Name = "showWorkerOrdersbutton";
            this.showWorkerOrdersbutton.Size = new System.Drawing.Size(264, 23);
            this.showWorkerOrdersbutton.TabIndex = 20;
            this.showWorkerOrdersbutton.Text = "Show worker\'s orders";
            this.showWorkerOrdersbutton.UseVisualStyleBackColor = true;
            this.showWorkerOrdersbutton.Click += new System.EventHandler(this.ShowWorkerOrdersbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 351);
            this.Controls.Add(this.showWorkerOrdersbutton);
            this.Controls.Add(this.raiseCutSalaryButton);
            this.Controls.Add(this.changeWorkerPositionButton);
            this.Controls.Add(this.changeWorkerShiftButton);
            this.Controls.Add(this.payOutSalaryButton);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.budgetBalance);
            this.Controls.Add(this.workersQuantity);
            this.Controls.Add(this.showOffersButton);
            this.Controls.Add(this.nearestReturnsButton);
            this.Controls.Add(this.activeOrders);
            this.Controls.Add(this.showClientsButton);
            this.Controls.Add(this.showOrdersButton);
            this.Controls.Add(this.showWorkersButton);
            this.Controls.Add(this.addOffer);
            this.Controls.Add(this.ordersQuantity);
            this.Controls.Add(this.offersQuantity);
            this.Controls.Add(this.clientsQuantity);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.addWorker);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button changeWorkerShiftButton;
        private System.Windows.Forms.Button changeWorkerPositionButton;
        private System.Windows.Forms.Button raiseCutSalaryButton;
        private System.Windows.Forms.Button showWorkerOrdersbutton;
    }
}

