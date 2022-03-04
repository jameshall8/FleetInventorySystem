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
            this.dgvOfficeStock = new System.Windows.Forms.DataGridView();
            this.btnAssignStockPage = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblSelectAssign = new System.Windows.Forms.Label();
            this.lblVanName = new System.Windows.Forms.Label();
            this.comboSelectEdit = new System.Windows.Forms.ComboBox();
            this.btnSelectAssign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficeStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(197, 110);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(141, 23);
            this.btnPopulate.TabIndex = 15;
            this.btnPopulate.Text = "Refresh Table";
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // dgvOfficeStock
            // 
            this.dgvOfficeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficeStock.Location = new System.Drawing.Point(71, 149);
            this.dgvOfficeStock.Name = "dgvOfficeStock";
            this.dgvOfficeStock.Size = new System.Drawing.Size(401, 363);
            this.dgvOfficeStock.TabIndex = 14;
            // 
            // btnAssignStockPage
            // 
            this.btnAssignStockPage.Location = new System.Drawing.Point(528, 452);
            this.btnAssignStockPage.Name = "btnAssignStockPage";
            this.btnAssignStockPage.Size = new System.Drawing.Size(166, 23);
            this.btnAssignStockPage.TabIndex = 13;
            this.btnAssignStockPage.Text = "Go to assign stock page ";
            this.btnAssignStockPage.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(581, 318);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // lblSelectAssign
            // 
            this.lblSelectAssign.AutoSize = true;
            this.lblSelectAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAssign.Location = new System.Drawing.Point(523, 149);
            this.lblSelectAssign.Name = "lblSelectAssign";
            this.lblSelectAssign.Size = new System.Drawing.Size(220, 25);
            this.lblSelectAssign.TabIndex = 9;
            this.lblSelectAssign.Text = "Select Item To Assign";
            // 
            // lblVanName
            // 
            this.lblVanName.AutoSize = true;
            this.lblVanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanName.Location = new System.Drawing.Point(306, 64);
            this.lblVanName.Name = "lblVanName";
            this.lblVanName.Size = new System.Drawing.Size(128, 25);
            this.lblVanName.TabIndex = 8;
            this.lblVanName.Text = "Office Stock";
            // 
            // comboSelectEdit
            // 
            this.comboSelectEdit.FormattingEnabled = true;
            this.comboSelectEdit.Location = new System.Drawing.Point(556, 187);
            this.comboSelectEdit.Name = "comboSelectEdit";
            this.comboSelectEdit.Size = new System.Drawing.Size(121, 21);
            this.comboSelectEdit.TabIndex = 10;
            // 
            // btnSelectAssign
            // 
            this.btnSelectAssign.Location = new System.Drawing.Point(581, 224);
            this.btnSelectAssign.Name = "btnSelectAssign";
            this.btnSelectAssign.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAssign.TabIndex = 11;
            this.btnSelectAssign.Text = "Assign";
            this.btnSelectAssign.UseVisualStyleBackColor = true;
            this.btnSelectAssign.Click += new System.EventHandler(this.btnSelectAssign_Click);
            // 
            // UC_IndividualVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.dgvOfficeStock);
            this.Controls.Add(this.btnAssignStockPage);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnSelectAssign);
            this.Controls.Add(this.comboSelectEdit);
            this.Controls.Add(this.lblSelectAssign);
            this.Controls.Add(this.lblVanName);
            this.Name = "UC_IndividualVan";
            this.Size = new System.Drawing.Size(787, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficeStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.DataGridView dgvOfficeStock;
        private System.Windows.Forms.Button btnAssignStockPage;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblSelectAssign;
        private System.Windows.Forms.Label lblVanName;
        private System.Windows.Forms.ComboBox comboSelectEdit;
        private System.Windows.Forms.Button btnSelectAssign;
    }
}
