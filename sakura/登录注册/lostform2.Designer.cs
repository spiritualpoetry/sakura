namespace sakura.登录注册
{
    partial class lostform2
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
            this.NewpwdLabel = new System.Windows.Forms.Label();
            this.NewpwdTextbox = new System.Windows.Forms.TextBox();
            this.QRLabel = new System.Windows.Forms.Label();
            this.QRtextBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewpwdLabel
            // 
            this.NewpwdLabel.AutoSize = true;
            this.NewpwdLabel.Location = new System.Drawing.Point(185, 169);
            this.NewpwdLabel.Name = "NewpwdLabel";
            this.NewpwdLabel.Size = new System.Drawing.Size(89, 12);
            this.NewpwdLabel.TabIndex = 0;
            this.NewpwdLabel.Text = "请输入新的密码";
            // 
            // NewpwdTextbox
            // 
            this.NewpwdTextbox.Location = new System.Drawing.Point(323, 164);
            this.NewpwdTextbox.Name = "NewpwdTextbox";
            this.NewpwdTextbox.PasswordChar = '*';
            this.NewpwdTextbox.Size = new System.Drawing.Size(100, 21);
            this.NewpwdTextbox.TabIndex = 1;
            // 
            // QRLabel
            // 
            this.QRLabel.AutoSize = true;
            this.QRLabel.Location = new System.Drawing.Point(185, 218);
            this.QRLabel.Name = "QRLabel";
            this.QRLabel.Size = new System.Drawing.Size(89, 12);
            this.QRLabel.TabIndex = 0;
            this.QRLabel.Text = "请输入新的密码";
            // 
            // QRtextBox
            // 
            this.QRtextBox.Location = new System.Drawing.Point(323, 215);
            this.QRtextBox.Name = "QRtextBox";
            this.QRtextBox.PasswordChar = '*';
            this.QRtextBox.Size = new System.Drawing.Size(100, 21);
            this.QRtextBox.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(254, 277);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // lostform2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(671, 494);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.QRtextBox);
            this.Controls.Add(this.NewpwdTextbox);
            this.Controls.Add(this.QRLabel);
            this.Controls.Add(this.NewpwdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lostform2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lostform2";
            this.Load += new System.EventHandler(this.lostform2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewpwdLabel;
        private System.Windows.Forms.TextBox NewpwdTextbox;
        private System.Windows.Forms.Label QRLabel;
        private System.Windows.Forms.TextBox QRtextBox;
        private System.Windows.Forms.Button submit;
    }
}