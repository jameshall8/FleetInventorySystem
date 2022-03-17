namespace FleetInventorySystem
{
    partial class UC_NewUser
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
            this.lblLname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.lblNewUserTitle = new System.Windows.Forms.Label();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblNewUserInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(265, 135);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 0;
            this.lblLname.Text = "Last Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(242, 226);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Confirm Password";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(267, 265);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(346, 135);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(148, 20);
            this.txtLname.TabIndex = 3;
            this.txtLname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 262);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(346, 223);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(148, 20);
            this.txtPassConfirm.TabIndex = 5;
            // 
            // lblNewUserTitle
            // 
            this.lblNewUserTitle.AutoSize = true;
            this.lblNewUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUserTitle.Location = new System.Drawing.Point(287, 31);
            this.lblNewUserTitle.Name = "lblNewUserTitle";
            this.lblNewUserTitle.Size = new System.Drawing.Size(169, 25);
            this.lblNewUserTitle.TabIndex = 6;
            this.lblNewUserTitle.Text = "Create new user";
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateNewUser.Location = new System.Drawing.Point(326, 347);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewUser.TabIndex = 7;
            this.btnCreateNewUser.Text = "Create User";
            this.btnCreateNewUser.UseVisualStyleBackColor = false;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnCreateNewUser_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(346, 94);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(148, 20);
            this.txtFname.TabIndex = 10;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(265, 94);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 9;
            this.lblFname.Text = "First Name";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(346, 182);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(148, 20);
            this.txtPass.TabIndex = 12;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(265, 182);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(53, 13);
            this.lblFirstname.TabIndex = 11;
            this.lblFirstname.Text = "Password";
            // 
            // lblNewUserInfo
            // 
            this.lblNewUserInfo.AutoSize = true;
            this.lblNewUserInfo.Location = new System.Drawing.Point(242, 390);
            this.lblNewUserInfo.Name = "lblNewUserInfo";
            this.lblNewUserInfo.Size = new System.Drawing.Size(227, 13);
            this.lblNewUserInfo.TabIndex = 8;
            this.lblNewUserInfo.Text = "The new user will be emailed their log in details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Role";
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(346, 300);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(148, 21);
            this.comboRole.TabIndex = 14;
            // 
            // UC_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblNewUserInfo);
            this.Controls.Add(this.btnCreateNewUser);
            this.Controls.Add(this.lblNewUserTitle);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLname);
            this.Name = "UC_NewUser";
            this.Size = new System.Drawing.Size(569, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Label lblNewUserTitle;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblNewUserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRole;
    }
}
