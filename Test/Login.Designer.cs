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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lb_username = new Label();
            lb_pwd = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnLogin = new Button();
            btnregister = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_username.Location = new Point(56, 73);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(136, 19);
            lb_username.TabIndex = 0;
            lb_username.Text = "Tên người dùng";
            // 
            // lb_pwd
            // 
            lb_pwd.AutoSize = true;
            lb_pwd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pwd.Location = new Point(56, 184);
            lb_pwd.Name = "lb_pwd";
            lb_pwd.Size = new Size(85, 19);
            lb_pwd.TabIndex = 1;
            lb_pwd.Text = "Mật khẩu";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(56, 103);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(332, 49);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(56, 218);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(332, 53);
            txtpassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = SystemColors.MenuBar;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(132, 299);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(165, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnregister
            // 
            btnregister.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnregister.ForeColor = SystemColors.MenuHighlight;
            btnregister.Location = new Point(95, 387);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(246, 44);
            btnregister.TabIndex = 5;
            btnregister.Text = "Chưa có tài khoản";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(524, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1134, 548);
            Controls.Add(pictureBox1);
            Controls.Add(btnregister);
            Controls.Add(btnLogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lb_pwd);
            Controls.Add(lb_username);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}