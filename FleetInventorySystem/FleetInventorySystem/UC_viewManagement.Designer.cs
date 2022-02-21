namespace FleetInventorySystem
{
    partial class UC_viewManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.managementLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // managementLbl
            // 
            this.managementLbl.AutoSize = true;
            this.managementLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementLbl.Location = new System.Drawing.Point(228, 55);
            this.managementLbl.Name = "managementLbl";
            this.managementLbl.Size = new System.Drawing.Size(143, 25);
            this.managementLbl.TabIndex = 0;
            this.managementLbl.Text = "Management ";
            // 
            // UC_viewManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managementLbl);
            this.Name = "UC_viewManagement";
            this.Size = new System.Drawing.Size(647, 444);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managementLbl;
    }
}
