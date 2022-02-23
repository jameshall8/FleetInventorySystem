namespace FleetInventorySystem
{
    partial class UC_Fleet
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
            this.btnPopulateVans = new System.Windows.Forms.Button();
            this.dgvVans = new System.Windows.Forms.DataGridView();
            this.btnSelectVan = new System.Windows.Forms.Button();
            this.comboSelectVan = new System.Windows.Forms.ComboBox();
            this.lblSelectVan = new System.Windows.Forms.Label();
            this.lblVanTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVans)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopulateVans
            // 
            this.btnPopulateVans.Location = new System.Drawing.Point(280, 82);
            this.btnPopulateVans.Name = "btnPopulateVans";
            this.btnPopulateVans.Size = new System.Drawing.Size(141, 23);
            this.btnPopulateVans.TabIndex = 15;
            this.btnPopulateVans.Text = "Refresh Table";
            this.btnPopulateVans.UseVisualStyleBackColor = true;
            this.btnPopulateVans.Click += new System.EventHandler(this.btnPopulateVans_Click);
            // 
            // dgvVans
            // 
            this.dgvVans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVans.Location = new System.Drawing.Point(154, 121);
            this.dgvVans.Name = "dgvVans";
            this.dgvVans.Size = new System.Drawing.Size(401, 363);
            this.dgvVans.TabIndex = 14;
            // 
            // btnSelectVan
            // 
            this.btnSelectVan.Location = new System.Drawing.Point(664, 196);
            this.btnSelectVan.Name = "btnSelectVan";
            this.btnSelectVan.Size = new System.Drawing.Size(75, 23);
            this.btnSelectVan.TabIndex = 11;
            this.btnSelectVan.Text = "View";
            this.btnSelectVan.UseVisualStyleBackColor = true;
            // 
            // comboSelectVan
            // 
            this.comboSelectVan.FormattingEnabled = true;
            this.comboSelectVan.Location = new System.Drawing.Point(639, 159);
            this.comboSelectVan.Name = "comboSelectVan";
            this.comboSelectVan.Size = new System.Drawing.Size(121, 21);
            this.comboSelectVan.TabIndex = 10;
            // 
            // lblSelectVan
            // 
            this.lblSelectVan.AutoSize = true;
            this.lblSelectVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectVan.Location = new System.Drawing.Point(606, 121);
            this.lblSelectVan.Name = "lblSelectVan";
            this.lblSelectVan.Size = new System.Drawing.Size(189, 25);
            this.lblSelectVan.TabIndex = 9;
            this.lblSelectVan.Text = "Select Van to view";
            // 
            // lblVanTitle
            // 
            this.lblVanTitle.AutoSize = true;
            this.lblVanTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanTitle.Location = new System.Drawing.Point(389, 36);
            this.lblVanTitle.Name = "lblVanTitle";
            this.lblVanTitle.Size = new System.Drawing.Size(61, 25);
            this.lblVanTitle.TabIndex = 8;
            this.lblVanTitle.Text = "Vans";
            // 
            // UC_Fleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPopulateVans);
            this.Controls.Add(this.dgvVans);
            this.Controls.Add(this.btnSelectVan);
            this.Controls.Add(this.comboSelectVan);
            this.Controls.Add(this.lblSelectVan);
            this.Controls.Add(this.lblVanTitle);
            this.Name = "UC_Fleet";
            this.Size = new System.Drawing.Size(905, 542);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopulateVans;
        private System.Windows.Forms.DataGridView dgvVans;
        private System.Windows.Forms.Button btnSelectVan;
        private System.Windows.Forms.ComboBox comboSelectVan;
        private System.Windows.Forms.Label lblSelectVan;
        private System.Windows.Forms.Label lblVanTitle;
    }
}
