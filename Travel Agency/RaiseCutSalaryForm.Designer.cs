namespace Travel_Agency
{
    partial class RaiseCutSalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaiseCutSalaryForm));
            this.workersBox = new System.Windows.Forms.ComboBox();
            this.workerLabel = new System.Windows.Forms.Label();
            this.raiseButton = new System.Windows.Forms.Button();
            this.cutButton = new System.Windows.Forms.Button();
            this.moneyTrackBar = new System.Windows.Forms.TrackBar();
            this.amountLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // workersBox
            // 
            this.workersBox.FormattingEnabled = true;
            this.workersBox.Location = new System.Drawing.Point(75, 17);
            this.workersBox.Name = "workersBox";
            this.workersBox.Size = new System.Drawing.Size(229, 21);
            this.workersBox.TabIndex = 0;
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Location = new System.Drawing.Point(12, 20);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(45, 13);
            this.workerLabel.TabIndex = 1;
            this.workerLabel.Text = "Worker:";
            // 
            // raiseButton
            // 
            this.raiseButton.Location = new System.Drawing.Point(43, 95);
            this.raiseButton.Name = "raiseButton";
            this.raiseButton.Size = new System.Drawing.Size(75, 23);
            this.raiseButton.TabIndex = 2;
            this.raiseButton.Text = "Raise";
            this.raiseButton.UseVisualStyleBackColor = true;
            this.raiseButton.Click += new System.EventHandler(this.RaiseButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.Location = new System.Drawing.Point(229, 95);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(75, 23);
            this.cutButton.TabIndex = 3;
            this.cutButton.Text = "Cut";
            this.cutButton.UseVisualStyleBackColor = true;
            this.cutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // moneyTrackBar
            // 
            this.moneyTrackBar.Location = new System.Drawing.Point(75, 44);
            this.moneyTrackBar.Maximum = 1000;
            this.moneyTrackBar.Name = "moneyTrackBar";
            this.moneyTrackBar.Size = new System.Drawing.Size(197, 45);
            this.moneyTrackBar.SmallChange = 5;
            this.moneyTrackBar.TabIndex = 4;
            this.moneyTrackBar.ValueChanged += new System.EventHandler(this.MoneyTrackBar_ValueChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 53);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(279, 44);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(0, 13);
            this.valueLabel.TabIndex = 6;
            // 
            // RaiseCutSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 132);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.moneyTrackBar);
            this.Controls.Add(this.cutButton);
            this.Controls.Add(this.raiseButton);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.workersBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaiseCutSalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raise or cut salary";
            ((System.ComponentModel.ISupportInitialize)(this.moneyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workersBox;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Button raiseButton;
        private System.Windows.Forms.Button cutButton;
        private System.Windows.Forms.TrackBar moneyTrackBar;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label valueLabel;
    }
}