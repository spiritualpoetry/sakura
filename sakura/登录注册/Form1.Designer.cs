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
            this.Login.Location = new System.Drawing.Point(57, 146);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(162, 146);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // PWD
            // 
            this.PWD.Location = new System.Drawing.Point(137, 91);
            this.PWD.Name = "PWD";
            this.PWD.PasswordChar = '*';
            this.PWD.Size = new System.Drawing.Size(100, 21);
            this.PWD.TabIndex = 2;
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(137, 52);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(100, 21);
            this.UID.TabIndex = 2;
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(57, 174);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 23);
            this.SignUp.TabIndex = 3;
            this.SignUp.Text = "注册";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // lostpwd
            // 
            this.lostpwd.Location = new System.Drawing.Point(161, 174);
            this.lostpwd.Name = "lostpwd";
            this.lostpwd.Size = new System.Drawing.Size(75, 23);
            this.lostpwd.TabIndex = 4;
            this.lostpwd.Text = "忘记密码";
            this.lostpwd.UseVisualStyleBackColor = true;
            this.lostpwd.Click += new System.EventHandler(this.lostpwd_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lostpwd);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.PWD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Form1";
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

