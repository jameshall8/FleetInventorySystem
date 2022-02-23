namespace FleetInventorySystem
{
    partial class UC_OfficeStock
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
            this.lblOfficeStockTitle = new System.Windows.Forms.Label();
            this.lblSelectEdit = new System.Windows.Forms.Label();
            this.comboSelectEdit = new System.Windows.Forms.ComboBox();
            this.btnSelectEdit = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAssignStockPage = new System.Windows.Forms.Button();
            this.dgvOfficeStock = new System.Windows.Forms.DataGridView();
            this.btnPopulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficeStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOfficeStockTitle
            // 
            this.lblOfficeStockTitle.AutoSize = true;
            this.lblOfficeStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficeStockTitle.Location = new System.Drawing.Point(381, 32);
            this.lblOfficeStockTitle.Name = "lblOfficeStockTitle";
            this.lblOfficeStockTitle.Size = new System.Drawing.Size(128, 25);
            this.lblOfficeStockTitle.TabIndex = 0;
            this.lblOfficeStockTitle.Text = "Office Stock";
            // 
            // lblSelectEdit
            // 
            this.lblSelectEdit.AutoSize = true;
            this.lblSelectEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectEdit.Location = new System.Drawing.Point(598, 117);
            this.lblSelectEdit.Name = "lblSelectEdit";
            this.lblSelectEdit.Size = new System.Drawing.Size(192, 25);
            this.lblSelectEdit.TabIndex = 1;
            this.lblSelectEdit.Text = "Select Item To Edit";
            // 
            // comboSelectEdit
            // 
            this.comboSelectEdit.FormattingEnabled = true;
            this.comboSelectEdit.Location = new System.Drawing.Point(631, 155);
            this.comboSelectEdit.Name = "comboSelectEdit";
            this.comboSelectEdit.Size = new System.Drawing.Size(121, 21);
            this.comboSelectEdit.TabIndex = 2;
            this.comboSelectEdit.SelectedIndexChanged += new System.EventHandler(this.comboSelectEdit_SelectedIndexChanged);
            // 
            // btnSelectEdit
            // 
            this.btnSelectEdit.Location = new System.Drawing.Point(656, 192);
            this.btnSelectEdit.Name = "btnSelectEdit";
            this.btnSelectEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSelectEdit.TabIndex = 3;
            this.btnSelectEdit.Text = "Edit";
            this.btnSelectEdit.UseVisualStyleBackColor = true;
            this.btnSelectEdit.Click += new System.EventHandler(this.btnSelectEdit_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(656, 286);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAssignStockPage
            // 
            this.btnAssignStockPage.Location = new System.Drawing.Point(603, 420);
            this.btnAssignStockPage.Name = "btnAssignStockPage";
            this.btnAssignStockPage.Size = new System.Drawing.Size(166, 23);
            this.btnAssignStockPage.TabIndex = 5;
            this.btnAssignStockPage.Text = "Go to assign stock page ";
            this.btnAssignStockPage.UseVisualStyleBackColor = true;
            this.btnAssignStockPage.Click += new System.EventHandler(this.btnAssignStockPage_Click);
            // 
            // dgvOfficeStock
            // 
            this.dgvOfficeStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficeStock.Location = new System.Drawing.Point(146, 117);
            this.dgvOfficeStock.Name = "dgvOfficeStock";
            this.dgvOfficeStock.Size = new System.Drawing.Size(401, 363);
            this.dgvOfficeStock.TabIndex = 6;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(272, 78);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(141, 23);
            this.btnPopulate.TabIndex = 7;
            this.btnPopulate.Text = "Refresh Table";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // UC_OfficeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.dgvOfficeStock);
            this.Controls.Add(this.btnAssignStockPage);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnSelectEdit);
            this.Controls.Add(this.comboSelectEdit);
            this.Controls.Add(this.lblSelectEdit);
            this.Controls.Add(this.lblOfficeStockTitle);
            this.Name = "UC_OfficeStock";
            this.Size = new System.Drawing.Size(934, 597);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficeStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOfficeStockTitle;
        private System.Windows.Forms.Label lblSelectEdit;
        private System.Windows.Forms.ComboBox comboSelectEdit;
        private System.Windows.Forms.Button btnSelectEdit;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAssignStockPage;
        private System.Windows.Forms.DataGridView dgvOfficeStock;
        private System.Windows.Forms.Button btnPopulate;
    }
}
