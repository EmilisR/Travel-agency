namespace Travel_Agency
{
    partial class SendInformationByEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendInformationByEmailForm));
            this.aboutOrderButton = new System.Windows.Forms.Button();
            this.aboutClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutOrderButton
            // 
            this.aboutOrderButton.Location = new System.Drawing.Point(12, 20);
            this.aboutOrderButton.Name = "aboutOrderButton";
            this.aboutOrderButton.Size = new System.Drawing.Size(153, 43);
            this.aboutOrderButton.TabIndex = 0;
            this.aboutOrderButton.Text = "About order";
            this.aboutOrderButton.UseVisualStyleBackColor = true;
            this.aboutOrderButton.Click += new System.EventHandler(this.AboutOrderButton_Click);
            // 
            // aboutClientButton
            // 
            this.aboutClientButton.Location = new System.Drawing.Point(181, 20);
            this.aboutClientButton.Name = "aboutClientButton";
            this.aboutClientButton.Size = new System.Drawing.Size(154, 43);
            this.aboutClientButton.TabIndex = 1;
            this.aboutClientButton.Text = "About client";
            this.aboutClientButton.UseVisualStyleBackColor = true;
            this.aboutClientButton.Click += new System.EventHandler(this.AboutClientButton_Click);
            // 
            // SendInformationByEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 75);
            this.Controls.Add(this.aboutClientButton);
            this.Controls.Add(this.aboutOrderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendInformationByEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send information by E-mail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aboutOrderButton;
        private System.Windows.Forms.Button aboutClientButton;
    }
}