﻿namespace Travel_Agency
{
    partial class NearestDeparturesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NearestDeparturesForm));
            this.nearestDeparturesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // nearestDeparturesListView
            // 
            this.nearestDeparturesListView.Location = new System.Drawing.Point(12, 12);
            this.nearestDeparturesListView.Name = "nearestDeparturesListView";
            this.nearestDeparturesListView.Size = new System.Drawing.Size(669, 237);
            this.nearestDeparturesListView.TabIndex = 0;
            this.nearestDeparturesListView.UseCompatibleStateImageBehavior = false;
            // 
            // NearestDeparturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 261);
            this.Controls.Add(this.nearestDeparturesListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NearestDeparturesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nearest departures";
            this.Load += new System.EventHandler(this.NearestDeparturesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView nearestDeparturesListView;
    }
}