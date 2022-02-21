namespace FleetInventorySystem
{
    partial class Form1
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.uC_Login1 = new FleetInventorySystem.UC_Login();
            this.uC_viewManagement1 = new FleetInventorySystem.UC_viewManagement();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(200, 492);
            this.navPanel.TabIndex = 0;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // uC_Login1
            // 
            this.uC_Login1.Location = new System.Drawing.Point(196, 3);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(620, 492);
            this.uC_Login1.TabIndex = 1;
            this.uC_Login1.Load += new System.EventHandler(this.uC_Login1_Load);
            // 
            // uC_viewManagement1
            // 
            this.uC_viewManagement1.Location = new System.Drawing.Point(196, 0);
            this.uC_viewManagement1.Name = "uC_viewManagement1";
            this.uC_viewManagement1.Size = new System.Drawing.Size(630, 489);
            this.uC_viewManagement1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 491);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.uC_Login1);
            this.Controls.Add(this.uC_viewManagement1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private UC_Login uC_Login1;
        private UC_viewManagement uC_viewManagement1;
    }
}

