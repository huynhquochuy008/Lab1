namespace Test
{
    partial class Registration
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
            btnHaveAccount = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            lb_pwd = new Label();
            lb_username = new Label();
            btnRegister = new Button();
            txtconfirmpassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHaveAccount
            // 
            btnHaveAccount.Location = new Point(174, 217);
            btnHaveAccount.Name = "btnHaveAccount";
            btnHaveAccount.Size = new Size(224, 23);
            btnHaveAccount.TabIndex = 11;
            btnHaveAccount.Text = "Have Account ? Login Now";
            btnHaveAccount.UseVisualStyleBackColor = true;
            btnHaveAccount.Click += btnHaveAccount_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(191, 91);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(207, 23);
            txtpassword.TabIndex = 9;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(191, 49);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(207, 23);
            txtusername.TabIndex = 8;
            // 
            // lb_pwd
            // 
            lb_pwd.AutoSize = true;
            lb_pwd.Location = new Point(46, 94);
            lb_pwd.Name = "lb_pwd";
            lb_pwd.Size = new Size(87, 15);
            lb_pwd.TabIndex = 7;
            lb_pwd.Text = "Enter Password";
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(46, 52);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(90, 15);
            lb_username.TabIndex = 6;
            lb_username.Text = "Enter Username\r\n";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(232, 178);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(113, 23);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register Now";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Location = new Point(191, 137);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(207, 23);
            txtconfirmpassword.TabIndex = 13;
            txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 140);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 12;
            label1.Text = "Confirm Password";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(txtconfirmpassword);
            Controls.Add(label1);
            Controls.Add(btnHaveAccount);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lb_pwd);
            Controls.Add(lb_username);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHaveAccount;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label lb_pwd;
        private Label lb_username;
        private Button btnRegister;
        private TextBox txtconfirmpassword;
        private Label label1;
    }
}