namespace Travel_Agency
{
    partial class AddWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkerForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.salaryTrackBar = new System.Windows.Forms.TrackBar();
            this.salaryValue = new System.Windows.Forms.Label();
            this.workingHoursLabel = new System.Windows.Forms.Label();
            this.workingHoursTrackBar = new System.Windows.Forms.TrackBar();
            this.workingHoursValue = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingHoursTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(37, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last name:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(37, 81);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 13);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "Position:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(37, 116);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 3;
            this.salaryLabel.Text = "Salary:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(169, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(169, 49);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(255, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Operations manager",
            "Quality control, safety, environmental manager",
            "Accountant, bookkeeper, controller",
            "Office manager",
            "Receptionist",
            "Foreperson, supervisor, lead person",
            "Marketing manager",
            "Purchasing manager",
            "Shipping and receiving person or manager",
            "Professional staff"});
            this.positionComboBox.Location = new System.Drawing.Point(169, 78);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(255, 21);
            this.positionComboBox.TabIndex = 6;
            // 
            // salaryTrackBar
            // 
            this.salaryTrackBar.LargeChange = 10;
            this.salaryTrackBar.Location = new System.Drawing.Point(169, 105);
            this.salaryTrackBar.Maximum = 2000;
            this.salaryTrackBar.Minimum = 350;
            this.salaryTrackBar.Name = "salaryTrackBar";
            this.salaryTrackBar.Size = new System.Drawing.Size(255, 45);
            this.salaryTrackBar.TabIndex = 7;
            this.salaryTrackBar.Value = 350;
            this.salaryTrackBar.ValueChanged += new System.EventHandler(this.salaryTrackBar_ValueChanged);
            // 
            // salaryValue
            // 
            this.salaryValue.AutoSize = true;
            this.salaryValue.Location = new System.Drawing.Point(430, 116);
            this.salaryValue.Name = "salaryValue";
            this.salaryValue.Size = new System.Drawing.Size(0, 13);
            this.salaryValue.TabIndex = 8;
            // 
            // workingHoursLabel
            // 
            this.workingHoursLabel.AutoSize = true;
            this.workingHoursLabel.Location = new System.Drawing.Point(37, 160);
            this.workingHoursLabel.Name = "workingHoursLabel";
            this.workingHoursLabel.Size = new System.Drawing.Size(126, 13);
            this.workingHoursLabel.TabIndex = 9;
            this.workingHoursLabel.Text = "Working hours per week:";
            // 
            // workingHoursTrackBar
            // 
            this.workingHoursTrackBar.LargeChange = 10;
            this.workingHoursTrackBar.Location = new System.Drawing.Point(169, 151);
            this.workingHoursTrackBar.Maximum = 48;
            this.workingHoursTrackBar.Minimum = 12;
            this.workingHoursTrackBar.Name = "workingHoursTrackBar";
            this.workingHoursTrackBar.Size = new System.Drawing.Size(255, 45);
            this.workingHoursTrackBar.TabIndex = 10;
            this.workingHoursTrackBar.Value = 12;
            this.workingHoursTrackBar.ValueChanged += new System.EventHandler(this.workingHoursTrackBar_ValueChanged);
            // 
            // workingHoursValue
            // 
            this.workingHoursValue.AutoSize = true;
            this.workingHoursValue.Location = new System.Drawing.Point(430, 160);
            this.workingHoursValue.Name = "workingHoursValue";
            this.workingHoursValue.Size = new System.Drawing.Size(0, 13);
            this.workingHoursValue.TabIndex = 11;
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.create.Location = new System.Drawing.Point(324, 202);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(100, 40);
            this.create.TabIndex = 12;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.create);
            this.Controls.Add(this.workingHoursValue);
            this.Controls.Add(this.workingHoursTrackBar);
            this.Controls.Add(this.workingHoursLabel);
            this.Controls.Add(this.salaryValue);
            this.Controls.Add(this.salaryTrackBar);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWorkerForm";
            this.Text = "Add worker";
            ((System.ComponentModel.ISupportInitialize)(this.salaryTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workingHoursTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private  System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.TrackBar salaryTrackBar;
        private System.Windows.Forms.Label salaryValue;
        private System.Windows.Forms.Label workingHoursLabel;
        private System.Windows.Forms.TrackBar workingHoursTrackBar;
        private System.Windows.Forms.Label workingHoursValue;
        private System.Windows.Forms.Button create;
    }
}