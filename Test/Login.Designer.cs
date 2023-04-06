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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            btnregister = new Button();
            btnLogin = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            lb_pwd = new Label();
            lb_username = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            txtconfirmpassword = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(2, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2052, 1179);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnregister);
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(txtpassword);
            tabPage1.Controls.Add(txtusername);
            tabPage1.Controls.Add(lb_pwd);
            tabPage1.Controls.Add(lb_username);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2036, 1125);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1001, 98);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(903, 928);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnregister
            // 
            btnregister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnregister.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnregister.ForeColor = SystemColors.MenuHighlight;
            btnregister.Location = new Point(204, 790);
            btnregister.Margin = new Padding(6);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(405, 109);
            btnregister.TabIndex = 12;
            btnregister.Text = "Chưa có tài khoản";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click_2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = SystemColors.MenuBar;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(273, 602);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(254, 111);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_2;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.Location = new Point(132, 429);
            txtpassword.Margin = new Padding(6);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(561, 123);
            txtpassword.TabIndex = 10;
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtusername.Location = new Point(132, 184);
            txtusername.Margin = new Padding(6);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(561, 115);
            txtusername.TabIndex = 9;
            // 
            // lb_pwd
            // 
            lb_pwd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_pwd.AutoSize = true;
            lb_pwd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pwd.Location = new Point(132, 357);
            lb_pwd.Margin = new Padding(6, 0, 6, 0);
            lb_pwd.Name = "lb_pwd";
            lb_pwd.Size = new Size(165, 39);
            lb_pwd.TabIndex = 8;
            lb_pwd.Text = "Mật khẩu";
            // 
            // lb_username
            // 
            lb_username.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_username.AutoSize = true;
            lb_username.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_username.Location = new Point(132, 120);
            lb_username.Margin = new Padding(6, 0, 6, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(267, 39);
            lb_username.TabIndex = 7;
            lb_username.Text = "Tên người dùng";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txtconfirmpassword);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2036, 1125);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(886, 640);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(312, 100);
            button1.TabIndex = 21;
            button1.Text = "Đăng ký ngay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtconfirmpassword.Location = new Point(930, 546);
            txtconfirmpassword.Margin = new Padding(6);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(409, 40);
            txtconfirmpassword.TabIndex = 20;
            txtconfirmpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(605, 557);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 39);
            label1.TabIndex = 19;
            label1.Text = "Xác nhận mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(930, 450);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 40);
            textBox1.TabIndex = 18;
            textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(930, 361);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 46);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(605, 457);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 39);
            label2.TabIndex = 16;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(605, 365);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(252, 39);
            label3.TabIndex = 15;
            label3.Text = "Tên đăng nhập";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(2054, 1184);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Button btnregister;
        private Button btnLogin;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Label lb_pwd;
        private Label lb_username;
        private TabPage tabPage2;
        private Button button1;
        private TextBox txtconfirmpassword;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}