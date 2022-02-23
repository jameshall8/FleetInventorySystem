using System.Windows.Forms;

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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnFleet = new System.Windows.Forms.Button();
            this.btnOfficeStock = new System.Windows.Forms.Button();
            this.lblNav = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.uC_OfficeStock1 = new FleetInventorySystem.UC_OfficeStock();
            this.uC_Reorder1 = new FleetInventorySystem.UC_Reorder();
            this.uC_Fleet1 = new FleetInventorySystem.UC_Fleet();
            this.uC_NewUser1 = new FleetInventorySystem.UC_NewUser();
            this.uC_HomeDashboard1 = new FleetInventorySystem.UC_HomeDashboard();
            this.uC_AssignStock1 = new FleetInventorySystem.UC_AssignStock();
            this.uC_AddItem1 = new FleetInventorySystem.UC_AddItem();
            this.navPanel.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.btnHome);
            this.navPanel.Controls.Add(this.btnLogout);
            this.navPanel.Controls.Add(this.btnCreateAccount);
            this.navPanel.Controls.Add(this.btnFleet);
            this.navPanel.Controls.Add(this.btnOfficeStock);
            this.navPanel.Controls.Add(this.lblNav);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(102, 492);
            this.navPanel.TabIndex = 0;
            this.navPanel.Visible = false;
            this.navPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 72);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 456);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(0, 354);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(102, 23);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnFleet
            // 
            this.btnFleet.Location = new System.Drawing.Point(0, 235);
            this.btnFleet.Name = "btnFleet";
            this.btnFleet.Size = new System.Drawing.Size(102, 23);
            this.btnFleet.TabIndex = 2;
            this.btnFleet.Text = "Fleet";
            this.btnFleet.UseVisualStyleBackColor = true;
            this.btnFleet.Click += new System.EventHandler(this.btnFleet_Click);
            // 
            // btnOfficeStock
            // 
            this.btnOfficeStock.Location = new System.Drawing.Point(0, 143);
            this.btnOfficeStock.Name = "btnOfficeStock";
            this.btnOfficeStock.Size = new System.Drawing.Size(102, 23);
            this.btnOfficeStock.TabIndex = 1;
            this.btnOfficeStock.Text = "Office Stock";
            this.btnOfficeStock.UseVisualStyleBackColor = true;
            this.btnOfficeStock.Click += new System.EventHandler(this.btnOfficeStock_Click);
            // 
            // lblNav
            // 
            this.lblNav.AutoSize = true;
            this.lblNav.Location = new System.Drawing.Point(11, 20);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(88, 13);
            this.lblNav.TabIndex = 0;
            this.lblNav.Text = "Inventory System";
            this.lblNav.Click += new System.EventHandler(this.lblNav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(258, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Forgot Password?";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(265, 319);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 25;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(185, 178);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 24;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(185, 223);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 23;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(246, 220);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(135, 20);
            this.passwordTxt.TabIndex = 22;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(246, 175);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(135, 20);
            this.usernameTxt.TabIndex = 21;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(274, 107);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(62, 24);
            this.loginLbl.TabIndex = 20;
            this.loginLbl.Text = "Log in";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.uC_AddItem1);
            this.pnlLogin.Controls.Add(this.loginLbl);
            this.pnlLogin.Controls.Add(this.passwordTxt);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.usernameTxt);
            this.pnlLogin.Controls.Add(this.loginBtn);
            this.pnlLogin.Controls.Add(this.passwordLbl);
            this.pnlLogin.Controls.Add(this.usernameLbl);
            this.pnlLogin.Controls.Add(this.uC_OfficeStock1);
            this.pnlLogin.Controls.Add(this.uC_Reorder1);
            this.pnlLogin.Controls.Add(this.uC_Fleet1);
            this.pnlLogin.Controls.Add(this.uC_NewUser1);
            this.pnlLogin.Controls.Add(this.uC_HomeDashboard1);
            this.pnlLogin.Controls.Add(this.uC_AssignStock1);
            this.pnlLogin.Location = new System.Drawing.Point(108, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(727, 492);
            this.pnlLogin.TabIndex = 28;
            // 
            // uC_OfficeStock1
            // 
            this.uC_OfficeStock1.Location = new System.Drawing.Point(-4, 0);
            this.uC_OfficeStock1.Name = "uC_OfficeStock1";
            this.uC_OfficeStock1.Size = new System.Drawing.Size(727, 496);
            this.uC_OfficeStock1.TabIndex = 30;
            this.uC_OfficeStock1.Visible = false;
            // 
            // uC_Reorder1
            // 
            this.uC_Reorder1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reorder1.Name = "uC_Reorder1";
            this.uC_Reorder1.Size = new System.Drawing.Size(615, 500);
            this.uC_Reorder1.TabIndex = 35;
            this.uC_Reorder1.Visible = false;
            // 
            // uC_Fleet1
            // 
            this.uC_Fleet1.Location = new System.Drawing.Point(-3, 3);
            this.uC_Fleet1.Name = "uC_Fleet1";
            this.uC_Fleet1.Size = new System.Drawing.Size(706, 493);
            this.uC_Fleet1.TabIndex = 34;
            this.uC_Fleet1.Visible = false;
            // 
            // uC_NewUser1
            // 
            this.uC_NewUser1.Location = new System.Drawing.Point(-4, 8);
            this.uC_NewUser1.Name = "uC_NewUser1";
            this.uC_NewUser1.Size = new System.Drawing.Size(727, 492);
            this.uC_NewUser1.TabIndex = 29;
            this.uC_NewUser1.Visible = false;
            // 
            // uC_HomeDashboard1
            // 
            this.uC_HomeDashboard1.Location = new System.Drawing.Point(-14, 0);
            this.uC_HomeDashboard1.Name = "uC_HomeDashboard1";
            this.uC_HomeDashboard1.Size = new System.Drawing.Size(741, 492);
            this.uC_HomeDashboard1.TabIndex = 28;
            this.uC_HomeDashboard1.Visible = false;
            this.uC_HomeDashboard1.Load += new System.EventHandler(this.uC_HomeDashboard1_Load);
            // 
            // uC_AssignStock1
            // 
            this.uC_AssignStock1.Location = new System.Drawing.Point(-4, 0);
            this.uC_AssignStock1.Name = "uC_AssignStock1";
            this.uC_AssignStock1.Size = new System.Drawing.Size(707, 494);
            this.uC_AssignStock1.TabIndex = 32;
            this.uC_AssignStock1.Visible = false;
            // 
            // uC_AddItem1
            // 
            this.uC_AddItem1.Location = new System.Drawing.Point(-4, 0);
            this.uC_AddItem1.Name = "uC_AddItem1";
            this.uC_AddItem1.Size = new System.Drawing.Size(647, 472);
            this.uC_AddItem1.TabIndex = 36;
            this.uC_AddItem1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 491);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.navPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private UC_HomeDashboard uC_viewManagement1;
        private Control uC_HomeDashboard;
        private Button btnLogout;
        private Button btnCreateAccount;
        private Button btnFleet;
        private Button btnOfficeStock;
        private Label lblNav;
        private Label label1;
        private Button loginBtn;
        private Label usernameLbl;
        private Label passwordLbl;
        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private Label loginLbl;
        private Panel pnlLogin;
        private UC_HomeDashboard uC_HomeDashboard1;
        private UC_NewUser uC_NewUser1;
        private Button btnHome;
        private UC_OfficeStock uC_OfficeStock1;
        private UC_Reorder uC_Reorder1;
        private UC_Fleet uC_Fleet1;
        private UC_EditItem uC_EditItem1;
        private UC_AssignStock uC_AssignStock1;
        private UC_AddItem uC_AddItem1;
    }
}

