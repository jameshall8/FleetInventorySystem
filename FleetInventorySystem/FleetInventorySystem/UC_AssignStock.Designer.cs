namespace FleetInventorySystem
{
    partial class UC_AssignStock
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
            this.btnAssignStock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProducts = new System.Windows.Forms.ComboBox();
            this.comboVans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssignStock
            // 
            this.btnAssignStock.Location = new System.Drawing.Point(305, 234);
            this.btnAssignStock.Name = "btnAssignStock";
            this.btnAssignStock.Size = new System.Drawing.Size(75, 23);
            this.btnAssignStock.TabIndex = 7;
            this.btnAssignStock.Text = "Assign";
            this.btnAssignStock.UseVisualStyleBackColor = true;
            this.btnAssignStock.Click += new System.EventHandler(this.btnAssignStock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Van List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assign Stock To Vans";
            // 
            // comboProducts
            // 
            this.comboProducts.FormattingEnabled = true;
            this.comboProducts.Location = new System.Drawing.Point(150, 146);
            this.comboProducts.Name = "comboProducts";
            this.comboProducts.Size = new System.Drawing.Size(121, 21);
            this.comboProducts.TabIndex = 8;
            // 
            // comboVans
            // 
            this.comboVans.FormattingEnabled = true;
            this.comboVans.Location = new System.Drawing.Point(416, 146);
            this.comboVans.Name = "comboVans";
            this.comboVans.Size = new System.Drawing.Size(121, 21);
            this.comboVans.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Products will automatically be added to vans database and removed from office sto" +
    "ck";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UC_AssignStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboVans);
            this.Controls.Add(this.comboProducts);
            this.Controls.Add(this.btnAssignStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AssignStock";
            this.Size = new System.Drawing.Size(707, 494);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssignStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProducts;
        private System.Windows.Forms.ComboBox comboVans;
        private System.Windows.Forms.Label label4;
    }
}
