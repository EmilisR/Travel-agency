namespace Travel_Agency
{
    partial class FileInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileInput));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.clientsFileButton = new System.Windows.Forms.Button();
            this.offersFileButton = new System.Windows.Forms.Button();
            this.goNextButton = new System.Windows.Forms.Button();
            this.ordersFileButton = new System.Windows.Forms.Button();
            this.workersFileButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // clientsFileButton
            // 
            this.clientsFileButton.Location = new System.Drawing.Point(12, 41);
            this.clientsFileButton.Name = "clientsFileButton";
            this.clientsFileButton.Size = new System.Drawing.Size(117, 23);
            this.clientsFileButton.TabIndex = 2;
            this.clientsFileButton.Text = "Select clients file...";
            this.clientsFileButton.UseVisualStyleBackColor = true;
            this.clientsFileButton.Click += new System.EventHandler(this.ClientsFileButton_Click);
            // 
            // offersFileButton
            // 
            this.offersFileButton.Location = new System.Drawing.Point(12, 12);
            this.offersFileButton.Name = "offersFileButton";
            this.offersFileButton.Size = new System.Drawing.Size(117, 23);
            this.offersFileButton.TabIndex = 1;
            this.offersFileButton.Text = "Select offers file...";
            this.offersFileButton.UseVisualStyleBackColor = true;
            this.offersFileButton.Click += new System.EventHandler(this.OffersFileButton_Click);
            // 
            // goNextButton
            // 
            this.goNextButton.AutoEllipsis = true;
            this.goNextButton.Enabled = false;
            this.goNextButton.Location = new System.Drawing.Point(135, 12);
            this.goNextButton.Name = "goNextButton";
            this.goNextButton.Size = new System.Drawing.Size(88, 110);
            this.goNextButton.TabIndex = 4;
            this.goNextButton.Text = "Continue";
            this.goNextButton.UseVisualStyleBackColor = true;
            this.goNextButton.Click += new System.EventHandler(this.GoNextButton_Click);
            // 
            // ordersFileButton
            // 
            this.ordersFileButton.Location = new System.Drawing.Point(12, 70);
            this.ordersFileButton.Name = "ordersFileButton";
            this.ordersFileButton.Size = new System.Drawing.Size(117, 23);
            this.ordersFileButton.TabIndex = 3;
            this.ordersFileButton.Text = "Select orders file...";
            this.ordersFileButton.UseVisualStyleBackColor = true;
            this.ordersFileButton.Click += new System.EventHandler(this.OrdersFileButton_Click);
            // 
            // workersFileButton
            // 
            this.workersFileButton.Location = new System.Drawing.Point(12, 99);
            this.workersFileButton.Name = "workersFileButton";
            this.workersFileButton.Size = new System.Drawing.Size(117, 23);
            this.workersFileButton.TabIndex = 5;
            this.workersFileButton.Text = "Select workers file...";
            this.workersFileButton.UseVisualStyleBackColor = true;
            this.workersFileButton.Click += new System.EventHandler(this.WorkersFileButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 128);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(211, 23);
            this.progressBar.TabIndex = 6;
            // 
            // FileInput
            // 
            this.AcceptButton = this.goNextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 156);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.workersFileButton);
            this.Controls.Add(this.ordersFileButton);
            this.Controls.Add(this.goNextButton);
            this.Controls.Add(this.offersFileButton);
            this.Controls.Add(this.clientsFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File input";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileInput_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Button clientsFileButton;
        private System.Windows.Forms.Button offersFileButton;
        private System.Windows.Forms.Button goNextButton;
        private System.Windows.Forms.Button ordersFileButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button workersFileButton;
    }
}