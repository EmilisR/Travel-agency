namespace Travel_Agency
{
    partial class ShowObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowObject));
            this.objectBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // objectBox
            // 
            this.objectBox.FormattingEnabled = true;
            this.objectBox.Location = new System.Drawing.Point(28, 27);
            this.objectBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.objectBox.Name = "objectBox";
            this.objectBox.Size = new System.Drawing.Size(564, 37);
            this.objectBox.TabIndex = 16;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(28, 103);
            this.showButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(268, 51);
            this.showButton.TabIndex = 17;
            this.showButton.Text = "Show information";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(336, 103);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(261, 51);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShowObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 181);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.objectBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ShowObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "showObject";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox objectBox;
        public System.Windows.Forms.Button showButton;
        public System.Windows.Forms.Button deleteButton;
    }
}