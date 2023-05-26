namespace sakura
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PWD = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.lostpwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(187, 281);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(112, 34);
            this.Login.TabIndex = 0;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(344, 281);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 34);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // PWD
            // 
            this.PWD.Location = new System.Drawing.Point(307, 198);
            this.PWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PWD.Name = "PWD";
            this.PWD.PasswordChar = '*';
            this.PWD.Size = new System.Drawing.Size(148, 32);
            this.PWD.TabIndex = 2;
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(307, 140);
            this.UID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(148, 32);
            this.UID.TabIndex = 2;
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(187, 323);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(112, 34);
            this.SignUp.TabIndex = 3;
            this.SignUp.Text = "注册";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // lostpwd
            // 
            this.lostpwd.Location = new System.Drawing.Point(343, 323);
            this.lostpwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lostpwd.Name = "lostpwd";
            this.lostpwd.Size = new System.Drawing.Size(112, 34);
            this.lostpwd.TabIndex = 4;
            this.lostpwd.Text = "忘记密码";
            this.lostpwd.UseVisualStyleBackColor = true;
            this.lostpwd.Click += new System.EventHandler(this.lostpwd_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(670, 501);
            this.Controls.Add(this.lostpwd);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.PWD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PWD;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button lostpwd;
    }
}

