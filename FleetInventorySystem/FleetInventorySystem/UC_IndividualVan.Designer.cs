namespace FleetInventorySystem
{
    partial class UC_IndividualVan
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.dgvIndividual = new System.Windows.Forms.DataGridView();
            this.lblSelectAssign = new System.Windows.Forms.Label();
            this.lblVanName = new System.Windows.Forms.Label();
            this.comboSelectMove = new System.Windows.Forms.ComboBox();
            this.btnSelectAssign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(544, 447);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(171, 23);
            this.btnPopulate.TabIndex = 15;
            this.btnPopulate.Text = "Refresh Table";
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // dgvIndividual
            // 
            this.dgvIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividual.Location = new System.Drawing.Point(130, 107);
            this.dgvIndividual.Name = "dgvIndividual";
            this.dgvIndividual.Size = new System.Drawing.Size(401, 363);
            this.dgvIndividual.TabIndex = 14;
            this.dgvIndividual.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfficeStock_CellContentClick);
            // 
            // lblSelectAssign
            // 
            this.lblSelectAssign.AutoSize = true;
            this.lblSelectAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAssign.Location = new System.Drawing.Point(539, 117);
            this.lblSelectAssign.Name = "lblSelectAssign";
            this.lblSelectAssign.Size = new System.Drawing.Size(245, 25);
            this.lblSelectAssign.TabIndex = 9;
            this.lblSelectAssign.Text = "Move item back to office";
            // 
            // lblVanName
            // 
            this.lblVanName.AutoSize = true;
            this.lblVanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanName.Location = new System.Drawing.Point(332, 22);
            this.lblVanName.Name = "lblVanName";
            this.lblVanName.Size = new System.Drawing.Size(128, 25);
            this.lblVanName.TabIndex = 8;
            this.lblVanName.Text = "Office Stock";
            this.lblVanName.Click += new System.EventHandler(this.lblVanName_Click);
            // 
            // comboSelectMove
            // 
            this.comboSelectMove.FormattingEnabled = true;
            this.comboSelectMove.Location = new System.Drawing.Point(544, 155);
            this.comboSelectMove.Name = "comboSelectMove";
            this.comboSelectMove.Size = new System.Drawing.Size(171, 21);
            this.comboSelectMove.TabIndex = 10;
            // 
            // btnSelectAssign
            // 
            this.btnSelectAssign.Location = new System.Drawing.Point(544, 182);
            this.btnSelectAssign.Name = "btnSelectAssign";
            this.btnSelectAssign.Size = new System.Drawing.Size(171, 23);
            this.btnSelectAssign.TabIndex = 11;
            this.btnSelectAssign.Text = "Move";
            this.btnSelectAssign.UseVisualStyleBackColor = true;
            this.btnSelectAssign.Click += new System.EventHandler(this.btnSelectAssign_Click);
            // 
            // UC_IndividualVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.dgvIndividual);
            this.Controls.Add(this.btnSelectAssign);
            this.Controls.Add(this.comboSelectMove);
            this.Controls.Add(this.lblSelectAssign);
            this.Controls.Add(this.lblVanName);
            this.Name = "UC_IndividualVan";
            this.Size = new System.Drawing.Size(787, 577);
            this.Load += new System.EventHandler(this.UC_IndividualVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.DataGridView dgvIndividual;
        private System.Windows.Forms.Label lblSelectAssign;
        private System.Windows.Forms.Label lblVanName;
        private System.Windows.Forms.ComboBox comboSelectMove;
        private System.Windows.Forms.Button btnSelectAssign;
    }
}
