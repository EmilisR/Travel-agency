namespace Travel_Agency
{
    partial class AddOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.startDate = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.clientsBox = new System.Windows.Forms.ComboBox();
            this.offerLabel = new System.Windows.Forms.Label();
            this.offerBox = new System.Windows.Forms.ComboBox();
            this.workerLabel = new System.Windows.Forms.Label();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.travellersAmount = new System.Windows.Forms.Label();
            this.travellersAmountTrackBar = new System.Windows.Forms.TrackBar();
            this.travellersAmountValue = new System.Windows.Forms.Label();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.emailConfirmationCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.travellersAmountTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(388, 18);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(279, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(87, 13);
            this.startDate.TabIndex = 1;
            this.startDate.Text = "Travel start date:";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.create.Location = new System.Drawing.Point(466, 192);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(100, 40);
            this.create.TabIndex = 10;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // clientsLabel
            // 
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(12, 57);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(36, 13);
            this.clientsLabel.TabIndex = 11;
            this.clientsLabel.Text = "Client:";
            // 
            // clientsBox
            // 
            this.clientsBox.FormattingEnabled = true;
            this.clientsBox.Location = new System.Drawing.Point(112, 54);
            this.clientsBox.Name = "clientsBox";
            this.clientsBox.Size = new System.Drawing.Size(254, 21);
            this.clientsBox.TabIndex = 12;
            this.clientsBox.DropDown += new System.EventHandler(this.ClientsBox_DropDown);
            // 
            // offerLabel
            // 
            this.offerLabel.AutoSize = true;
            this.offerLabel.Location = new System.Drawing.Point(12, 97);
            this.offerLabel.Name = "offerLabel";
            this.offerLabel.Size = new System.Drawing.Size(33, 13);
            this.offerLabel.TabIndex = 13;
            this.offerLabel.Text = "Offer:";
            // 
            // offerBox
            // 
            this.offerBox.FormattingEnabled = true;
            this.offerBox.Location = new System.Drawing.Point(112, 94);
            this.offerBox.Name = "offerBox";
            this.offerBox.Size = new System.Drawing.Size(254, 21);
            this.offerBox.TabIndex = 14;
            this.offerBox.DropDown += new System.EventHandler(this.OfferBox_DropDown);
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Location = new System.Drawing.Point(12, 137);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(45, 13);
            this.workerLabel.TabIndex = 15;
            this.workerLabel.Text = "Worker:";
            // 
            // workerComboBox
            // 
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(112, 134);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(254, 21);
            this.workerComboBox.TabIndex = 16;
            this.workerComboBox.DropDown += new System.EventHandler(this.WorkerComboBox_DropDown);
            // 
            // travellersAmount
            // 
            this.travellersAmount.AutoSize = true;
            this.travellersAmount.Location = new System.Drawing.Point(12, 177);
            this.travellersAmount.Name = "travellersAmount";
            this.travellersAmount.Size = new System.Drawing.Size(94, 13);
            this.travellersAmount.TabIndex = 17;
            this.travellersAmount.Text = "Travellers amount:";
            // 
            // travellersAmountTrackBar
            // 
            this.travellersAmountTrackBar.Location = new System.Drawing.Point(112, 161);
            this.travellersAmountTrackBar.Minimum = 1;
            this.travellersAmountTrackBar.Name = "travellersAmountTrackBar";
            this.travellersAmountTrackBar.Size = new System.Drawing.Size(222, 45);
            this.travellersAmountTrackBar.TabIndex = 18;
            this.travellersAmountTrackBar.Value = 1;
            this.travellersAmountTrackBar.ValueChanged += new System.EventHandler(this.TravellersAmountTrackBar_ValueChanged);
            // 
            // travellersAmountValue
            // 
            this.travellersAmountValue.AutoSize = true;
            this.travellersAmountValue.Location = new System.Drawing.Point(341, 166);
            this.travellersAmountValue.Name = "travellersAmountValue";
            this.travellersAmountValue.Size = new System.Drawing.Size(0, 13);
            this.travellersAmountValue.TabIndex = 19;
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Location = new System.Drawing.Point(12, 209);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(158, 13);
            this.confirmationLabel.TabIndex = 20;
            this.confirmationLabel.Text = "Receive confirmation by E-mail?";
            // 
            // emailConfirmationCheckBox
            // 
            this.emailConfirmationCheckBox.AutoSize = true;
            this.emailConfirmationCheckBox.Location = new System.Drawing.Point(197, 209);
            this.emailConfirmationCheckBox.Name = "emailConfirmationCheckBox";
            this.emailConfirmationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.emailConfirmationCheckBox.TabIndex = 21;
            this.emailConfirmationCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddOrderForm
            // 
            this.AcceptButton = this.create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 248);
            this.Controls.Add(this.emailConfirmationCheckBox);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.travellersAmountValue);
            this.Controls.Add(this.travellersAmountTrackBar);
            this.Controls.Add(this.travellersAmount);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.offerBox);
            this.Controls.Add(this.offerLabel);
            this.Controls.Add(this.clientsBox);
            this.Controls.Add(this.clientsLabel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.monthCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add order";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travellersAmountTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.ComboBox clientsBox;
        private System.Windows.Forms.Label offerLabel;
        private System.Windows.Forms.ComboBox offerBox;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.Label travellersAmount;
        private System.Windows.Forms.TrackBar travellersAmountTrackBar;
        private System.Windows.Forms.Label travellersAmountValue;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.CheckBox emailConfirmationCheckBox;
    }
}