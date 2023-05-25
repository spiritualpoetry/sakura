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
            this.SuspendLayout();
            // 
            // IDLable
            // 
            this.IDLable.AutoSize = true;
            this.IDLable.Location = new System.Drawing.Point(69, 58);
            this.IDLable.Name = "IDLable";
            this.IDLable.Size = new System.Drawing.Size(29, 12);
            this.IDLable.TabIndex = 0;
            this.IDLable.Text = "账号";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(69, 86);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(29, 12);
            this.NameLable.TabIndex = 0;
            this.NameLable.Text = "昵称";
            // 
            // PwdLable
            // 
            this.PwdLable.AutoSize = true;
            this.PwdLable.Location = new System.Drawing.Point(69, 114);
            this.PwdLable.Name = "PwdLable";
            this.PwdLable.Size = new System.Drawing.Size(29, 12);
            this.PwdLable.TabIndex = 0;
            this.PwdLable.Text = "密码";
            // 
            // YpwdLable
            // 
            this.YpwdLable.AutoSize = true;
            this.YpwdLable.Location = new System.Drawing.Point(69, 142);
            this.YpwdLable.Name = "YpwdLable";
            this.YpwdLable.Size = new System.Drawing.Size(53, 12);
            this.YpwdLable.TabIndex = 0;
            this.YpwdLable.Text = "确认密码";
            // 
            // EmileLable
            // 
            this.EmileLable.AutoSize = true;
            this.EmileLable.Location = new System.Drawing.Point(69, 170);
            this.EmileLable.Name = "EmileLable";
            this.EmileLable.Size = new System.Drawing.Size(29, 12);
            this.EmileLable.TabIndex = 0;
            this.EmileLable.Text = "邮箱";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(135, 77);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 21);
            this.NameText.TabIndex = 1;
            // 
            // PwdText
            // 
            this.PwdText.Location = new System.Drawing.Point(135, 105);
            this.PwdText.Name = "PwdText";
            this.PwdText.Size = new System.Drawing.Size(100, 21);
            this.PwdText.TabIndex = 1;
            // 
            // YpwdText
            // 
            this.YpwdText.Location = new System.Drawing.Point(135, 139);
            this.YpwdText.Name = "YpwdText";
            this.YpwdText.Size = new System.Drawing.Size(100, 21);
            this.YpwdText.TabIndex = 1;
            // 
            // EmileText
            // 
            this.EmileText.Location = new System.Drawing.Point(135, 167);
            this.EmileText.Name = "EmileText";
            this.EmileText.Size = new System.Drawing.Size(100, 21);
            this.EmileText.TabIndex = 1;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(98, 204);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "提交";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // zhlable
            // 
            this.zhlable.AutoSize = true;
            this.zhlable.Location = new System.Drawing.Point(175, 58);
            this.zhlable.Name = "zhlable";
            this.zhlable.Size = new System.Drawing.Size(29, 12);
            this.zhlable.TabIndex = 0;
            this.zhlable.Text = "账号";
            this.zhlable.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignUPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}