namespace Travel_Agency
{
    partial class AddClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.telNumberBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.telNumberLabel = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailConfirmationCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(144, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 20);
            this.nameBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(144, 60);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(132, 20);
            this.lastNameBox.TabIndex = 2;
            // 
            // telNumberBox
            // 
            this.telNumberBox.Location = new System.Drawing.Point(144, 100);
            this.telNumberBox.Name = "telNumberBox";
            this.telNumberBox.Size = new System.Drawing.Size(132, 20);
            this.telNumberBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(21, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last name:";
            // 
            // telNumberLabel
            // 
            this.telNumberLabel.AutoSize = true;
            this.telNumberLabel.Location = new System.Drawing.Point(21, 103);
            this.telNumberLabel.Name = "telNumberLabel";
            this.telNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.telNumberLabel.TabIndex = 8;
            this.telNumberLabel.Text = "Mobile number:";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.create.Location = new System.Drawing.Point(144, 219);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(132, 40);
            this.create.TabIndex = 5;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(22, 143);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "E-mail address:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(144, 140);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(132, 20);
            this.emailBox.TabIndex = 4;
            // 
            // emailConfirmationCheckBox
            // 
            this.emailConfirmationCheckBox.AutoSize = true;
            this.emailConfirmationCheckBox.Location = new System.Drawing.Point(261, 179);
            this.emailConfirmationCheckBox.Name = "emailConfirmationCheckBox";
            this.emailConfirmationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.emailConfirmationCheckBox.TabIndex = 10;
            this.emailConfirmationCheckBox.UseVisualStyleBackColor = true;
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Location = new System.Drawing.Point(22, 180);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(158, 13);
            this.confirmationLabel.TabIndex = 11;
            this.confirmationLabel.Text = "Receive confirmation by E-mail?";
            // 
            // AddClientForm
            // 
            this.AcceptButton = this.create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 271);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.emailConfirmationCheckBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.telNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.telNumberBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.nameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox telNumberBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label telNumberLabel;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.CheckBox emailConfirmationCheckBox;
        private System.Windows.Forms.Label confirmationLabel;
    }
}