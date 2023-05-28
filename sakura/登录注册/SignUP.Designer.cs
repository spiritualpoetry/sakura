namespace sakura.登录注册
{
    partial class SignUPForm
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
            this.IDLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.PwdLable = new System.Windows.Forms.Label();
            this.YpwdLable = new System.Windows.Forms.Label();
            this.EmileLable = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PwdText = new System.Windows.Forms.TextBox();
            this.YpwdText = new System.Windows.Forms.TextBox();
            this.EmileText = new System.Windows.Forms.TextBox();
            this.YesButton = new System.Windows.Forms.Button();
            this.zhlable = new System.Windows.Forms.Label();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(90, 64);
            this.IDLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(36, 17);
            this.IDLable.TabIndex = 0;
            this.IDLable.Text = "账号";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(90, 106);
            this.NameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(36, 17);
            this.NameLable.TabIndex = 0;
            this.NameLable.Text = "昵称";
            // 
            // PwdLable
            // 
            this.PwdLable.AutoSize = true;
            this.PwdLable.Location = new System.Drawing.Point(90, 148);
            this.PwdLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PwdLable.Name = "PwdLable";
            this.PwdLable.Size = new System.Drawing.Size(36, 17);
            this.PwdLable.TabIndex = 0;
            this.PwdLable.Text = "密码";
            // 
            // YpwdLable
            // 
            this.YpwdLable.AutoSize = true;
            this.YpwdLable.Location = new System.Drawing.Point(90, 190);
            this.YpwdLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YpwdLable.Name = "YpwdLable";
            this.YpwdLable.Size = new System.Drawing.Size(64, 17);
            this.YpwdLable.TabIndex = 0;
            this.YpwdLable.Text = "确认密码";
            // 
            // EmileLable
            // 
            this.EmileLable.AutoSize = true;
            this.EmileLable.Location = new System.Drawing.Point(90, 232);
            this.EmileLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmileLable.Name = "EmileLable";
            this.EmileLable.Size = new System.Drawing.Size(36, 17);
            this.EmileLable.TabIndex = 0;
            this.EmileLable.Text = "邮箱";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(188, 93);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(148, 24);
            this.NameText.TabIndex = 1;
            // 
            // PwdText
            // 
            this.PwdText.Location = new System.Drawing.Point(188, 135);
            this.PwdText.Margin = new System.Windows.Forms.Padding(4);
            this.PwdText.Name = "PwdText";
            this.PwdText.PasswordChar = '*';
            this.PwdText.Size = new System.Drawing.Size(148, 24);
            this.PwdText.TabIndex = 1;
            // 
            // YpwdText
            // 
            this.YpwdText.Location = new System.Drawing.Point(188, 185);
            this.YpwdText.Margin = new System.Windows.Forms.Padding(4);
            this.YpwdText.Name = "YpwdText";
            this.YpwdText.PasswordChar = '*';
            this.YpwdText.Size = new System.Drawing.Size(148, 24);
            this.YpwdText.TabIndex = 1;
            // 
            // EmileText
            // 
            this.EmileText.Location = new System.Drawing.Point(188, 227);
            this.EmileText.Margin = new System.Windows.Forms.Padding(4);
            this.EmileText.Name = "EmileText";
            this.EmileText.Size = new System.Drawing.Size(148, 24);
            this.EmileText.TabIndex = 1;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(133, 283);
            this.YesButton.Margin = new System.Windows.Forms.Padding(4);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(112, 34);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "提交";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // zhlable
            // 
            this.zhlable.AutoSize = true;
            this.zhlable.Location = new System.Drawing.Point(248, 64);
            this.zhlable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zhlable.Name = "zhlable";
            this.zhlable.Size = new System.Drawing.Size(36, 17);
            this.zhlable.TabIndex = 0;
            this.zhlable.Text = "账号";
            this.zhlable.Click += new System.EventHandler(this.label1_Click);
            // 
            // uidTextBox
            // 
            this.uidTextBox.Enabled = false;
            this.uidTextBox.Location = new System.Drawing.Point(0, 0);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(100, 21);
            this.uidTextBox.TabIndex = 3;
            this.uidTextBox.Visible = false;
            // 
            // SignUPForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(426, 393);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.EmileText);
            this.Controls.Add(this.YpwdText);
            this.Controls.Add(this.PwdText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.EmileLable);
            this.Controls.Add(this.YpwdLable);
            this.Controls.Add(this.PwdLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.zhlable);
            this.Controls.Add(this.IDLable);
            this.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUPForm";
            this.Load += new System.EventHandler(this.SignUPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label PwdLable;
        private System.Windows.Forms.Label YpwdLable;
        private System.Windows.Forms.Label EmileLable;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PwdText;
        private System.Windows.Forms.TextBox YpwdText;
        private System.Windows.Forms.TextBox EmileText;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label zhlable;
        private System.Windows.Forms.TextBox uidTextBox;
    }
}