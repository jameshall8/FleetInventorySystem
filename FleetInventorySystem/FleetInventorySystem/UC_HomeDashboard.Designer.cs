namespace FleetInventorySystem
{
    partial class UC_HomeDashboard
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
            this.lblBelow5 = new System.Windows.Forms.Label();
            this.lblBelow20 = new System.Windows.Forms.Label();
            this.lblBelow50 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.managementLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBelow5
            // 
            this.lblBelow5.AutoSize = true;
            this.lblBelow5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelow5.Location = new System.Drawing.Point(615, 193);
            this.lblBelow5.Name = "lblBelow5";
            this.lblBelow5.Size = new System.Drawing.Size(76, 25);
            this.lblBelow5.TabIndex = 13;
            this.lblBelow5.Text = "label6";
            // 
            // lblBelow20
            // 
            this.lblBelow20.AutoSize = true;
            this.lblBelow20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelow20.Location = new System.Drawing.Point(428, 193);
            this.lblBelow20.Name = "lblBelow20";
            this.lblBelow20.Size = new System.Drawing.Size(76, 25);
            this.lblBelow20.TabIndex = 12;
            this.lblBelow20.Text = "label5";
            // 
            // lblBelow50
            // 
            this.lblBelow50.AutoSize = true;
            this.lblBelow50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelow50.Location = new System.Drawing.Point(234, 193);
            this.lblBelow50.Name = "lblBelow50";
            this.lblBelow50.Size = new System.Drawing.Size(76, 25);
            this.lblBelow50.TabIndex = 11;
            this.lblBelow50.Text = "label4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(611, 162);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(80, 13);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Items below 5%";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(418, 162);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(86, 13);
            this.lbl20.TabIndex = 9;
            this.lbl20.Text = "Items below 20%";
            this.lbl20.Click += new System.EventHandler(this.lbl20_Click);
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Location = new System.Drawing.Point(224, 162);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(86, 13);
            this.lbl50.TabIndex = 8;
            this.lbl50.Text = "Items below 50%";
            this.lbl50.Click += new System.EventHandler(this.lbl50_Click);
            // 
            // managementLbl
            // 
            this.managementLbl.AutoSize = true;
            this.managementLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementLbl.Location = new System.Drawing.Point(377, 63);
            this.managementLbl.Name = "managementLbl";
            this.managementLbl.Size = new System.Drawing.Size(179, 25);
            this.managementLbl.TabIndex = 7;
            this.managementLbl.Text = "Office Dashboard";
            this.managementLbl.Click += new System.EventHandler(this.managementLbl_Click);
            // 
            // UC_HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBelow5);
            this.Controls.Add(this.lblBelow20);
            this.Controls.Add(this.lblBelow50);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.managementLbl);
            this.Name = "UC_HomeDashboard";
            this.Size = new System.Drawing.Size(783, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBelow5;
        private System.Windows.Forms.Label lblBelow20;
        private System.Windows.Forms.Label lblBelow50;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label managementLbl;
    }
}
