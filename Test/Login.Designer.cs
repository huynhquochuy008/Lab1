namespace Test
{
    partial class Login
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
            lb_username = new Label();
            lb_pwd = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnLogin = new Button();
            btnregister = new Button();
            SuspendLayout();
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(24, 37);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(90, 15);
            lb_username.TabIndex = 0;
            lb_username.Text = "Enter Username\r\n";
            lb_username.Click += lb_username_Click;
            // 
            // lb_pwd
            // 
            lb_pwd.AutoSize = true;
            lb_pwd.Location = new Point(24, 77);
            lb_pwd.Name = "lb_pwd";
            lb_pwd.Size = new Size(87, 15);
            lb_pwd.TabIndex = 1;
            lb_pwd.Text = "Enter Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(169, 34);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(207, 23);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(169, 74);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(207, 23);
            txtpassword.TabIndex = 3;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(224, 125);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnregister
            // 
            btnregister.Location = new Point(152, 173);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(224, 23);
            btnregister.TabIndex = 5;
            btnregister.Text = "Don't Have Account ? Create Now";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 548);
            Controls.Add(btnregister);
            Controls.Add(btnLogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lb_pwd);
            Controls.Add(lb_username);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_username;
        private Label lb_pwd;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnLogin;
        private Button btnregister;
    }
}