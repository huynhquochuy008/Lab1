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
            btnHaveAccount.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHaveAccount.Location = new Point(286, 327);
            btnHaveAccount.Name = "btnHaveAccount";
            btnHaveAccount.Size = new Size(264, 51);
            btnHaveAccount.TabIndex = 11;
            btnHaveAccount.Text = "Have Account ? Login Now";
            btnHaveAccount.UseVisualStyleBackColor = true;
            btnHaveAccount.Click += btnHaveAccount_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(307, 123);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(207, 23);
            txtpassword.TabIndex = 9;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(307, 81);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(207, 27);
            txtusername.TabIndex = 8;
            // 
            // lb_pwd
            // 
            lb_pwd.AutoSize = true;
            lb_pwd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pwd.Location = new Point(132, 127);
            lb_pwd.Name = "lb_pwd";
            lb_pwd.Size = new Size(136, 19);
            lb_pwd.TabIndex = 7;
            lb_pwd.Text = "Enter Password";
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_username.Location = new Point(132, 84);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(140, 19);
            lb_username.TabIndex = 6;
            lb_username.Text = "Enter Username\r\n";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(338, 256);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(153, 51);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Register Now";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Location = new Point(307, 169);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(207, 23);
            txtconfirmpassword.TabIndex = 13;
            txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 173);
            label1.Name = "label1";
            label1.Size = new Size(156, 19);
            label1.TabIndex = 12;
            label1.Text = "Confirm Password";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
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