namespace Travel_Agency
{
    partial class ChangeShiftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeShiftForm));
            this.workersBox = new System.Windows.Forms.ComboBox();
            this.establishmentComboBox = new System.Windows.Forms.ComboBox();
            this.workerLabel = new System.Windows.Forms.Label();
            this.establishmentLabel = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workersBox
            // 
            this.workersBox.FormattingEnabled = true;
            this.workersBox.Location = new System.Drawing.Point(94, 12);
            this.workersBox.Name = "workersBox";
            this.workersBox.Size = new System.Drawing.Size(219, 21);
            this.workersBox.TabIndex = 0;
            // 
            // establishmentComboBox
            // 
            this.establishmentComboBox.FormattingEnabled = true;
            this.establishmentComboBox.Location = new System.Drawing.Point(94, 39);
            this.establishmentComboBox.Name = "establishmentComboBox";
            this.establishmentComboBox.Size = new System.Drawing.Size(219, 21);
            this.establishmentComboBox.TabIndex = 1;
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Location = new System.Drawing.Point(12, 15);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(45, 13);
            this.workerLabel.TabIndex = 2;
            this.workerLabel.Text = "Worker:";
            // 
            // establishmentLabel
            // 
            this.establishmentLabel.AutoSize = true;
            this.establishmentLabel.Location = new System.Drawing.Point(12, 42);
            this.establishmentLabel.Name = "establishmentLabel";
            this.establishmentLabel.Size = new System.Drawing.Size(75, 13);
            this.establishmentLabel.TabIndex = 3;
            this.establishmentLabel.Text = "Establishment:";
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.change.Location = new System.Drawing.Point(213, 66);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(100, 40);
            this.change.TabIndex = 11;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.Change_Click);
            // 
            // ChangeShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 113);
            this.Controls.Add(this.change);
            this.Controls.Add(this.establishmentLabel);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.establishmentComboBox);
            this.Controls.Add(this.workersBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeShiftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change worker\'s establishment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox workersBox;
        public System.Windows.Forms.ComboBox establishmentComboBox;
        public System.Windows.Forms.Label workerLabel;
        public System.Windows.Forms.Label establishmentLabel;
        private System.Windows.Forms.Button change;
    }
}