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
            this.panelBG = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.登录lb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.syslb = new System.Windows.Forms.Label();
            this.panelBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Location = new System.Drawing.Point(370, 358);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(112, 34);
            this.Login.TabIndex = 0;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(507, 358);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 34);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // PWD
            // 
            this.PWD.Location = new System.Drawing.Point(517, 284);
            this.PWD.Margin = new System.Windows.Forms.Padding(4);
            this.PWD.Name = "PWD";
            this.PWD.PasswordChar = '*';
            this.PWD.Size = new System.Drawing.Size(102, 24);
            this.PWD.TabIndex = 2;
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(517, 231);
            this.UID.Margin = new System.Windows.Forms.Padding(4);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(102, 24);
            this.UID.TabIndex = 2;
            this.UID.TextChanged += new System.EventHandler(this.UID_TextChanged);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Location = new System.Drawing.Point(370, 400);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(112, 34);
            this.SignUp.TabIndex = 3;
            this.SignUp.Text = "注册";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // lostpwd
            // 
            this.lostpwd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lostpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lostpwd.Location = new System.Drawing.Point(507, 400);
            this.lostpwd.Margin = new System.Windows.Forms.Padding(4);
            this.lostpwd.Name = "lostpwd";
            this.lostpwd.Size = new System.Drawing.Size(112, 34);
            this.lostpwd.TabIndex = 4;
            this.lostpwd.Text = "忘记密码";
            this.lostpwd.UseVisualStyleBackColor = false;
            this.lostpwd.Click += new System.EventHandler(this.lostpwd_Click);
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelBG.Controls.Add(this.label5);
            this.panelBG.Controls.Add(this.pictureBox1);
            this.panelBG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBG.Location = new System.Drawing.Point(0, 0);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(336, 501);
            this.panelBG.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "What do you see Ordering system";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // 登录lb
            // 
            this.登录lb.AutoSize = true;
            this.登录lb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.登录lb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.登录lb.Location = new System.Drawing.Point(501, 119);
            this.登录lb.Name = "登录lb";
            this.登录lb.Size = new System.Drawing.Size(71, 33);
            this.登录lb.TabIndex = 6;
            this.登录lb.Text = "登录";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(417, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // syslb
            // 
            this.syslb.AutoSize = true;
            this.syslb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syslb.Location = new System.Drawing.Point(342, 9);
            this.syslb.Name = "syslb";
            this.syslb.Size = new System.Drawing.Size(120, 17);
            this.syslb.TabIndex = 7;
            this.syslb.Text = "你瞅啥点餐系统";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 501);
            this.Controls.Add(this.syslb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.登录lb);
            this.Controls.Add(this.panelBG);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelBG.ResumeLayout(false);
            this.panelBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label 登录lb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label syslb;
        private System.Windows.Forms.Label label5;
    }
}

