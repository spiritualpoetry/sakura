namespace sakura.登录注册
{
    partial class lostform
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
            this.EmileText = new System.Windows.Forms.TextBox();
            this.emilelable = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.YZM = new System.Windows.Forms.Label();
            this.YZMText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmileText
            // 
            this.EmileText.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmileText.Location = new System.Drawing.Point(138, 120);
            this.EmileText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmileText.Name = "EmileText";
            this.EmileText.Size = new System.Drawing.Size(148, 32);
            this.EmileText.TabIndex = 0;
            // 
            // emilelable
            // 
            this.emilelable.AutoSize = true;
            this.emilelable.Location = new System.Drawing.Point(51, 127);
            this.emilelable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emilelable.Name = "emilelable";
            this.emilelable.Size = new System.Drawing.Size(44, 18);
            this.emilelable.TabIndex = 1;
            this.emilelable.Text = "邮箱";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(294, 120);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 34);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "发送";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // YZM
            // 
            this.YZM.AutoSize = true;
            this.YZM.Location = new System.Drawing.Point(312, 82);
            this.YZM.Name = "YZM";
            this.YZM.Size = new System.Drawing.Size(62, 18);
            this.YZM.TabIndex = 3;
            this.YZM.Text = "label1";
            this.YZM.Visible = false;
            // 
            // YZMText
            // 
            this.YZMText.Location = new System.Drawing.Point(138, 179);
            this.YZMText.Name = "YZMText";
            this.YZMText.Size = new System.Drawing.Size(100, 28);
            this.YZMText.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lostform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(426, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YZMText);
            this.Controls.Add(this.YZM);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.emilelable);
            this.Controls.Add(this.EmileText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "lostform";
            this.Text = "lostform";
            this.Load += new System.EventHandler(this.lostform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmileText;
        private System.Windows.Forms.Label emilelable;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label YZM;
        private System.Windows.Forms.TextBox YZMText;
        private System.Windows.Forms.Button button1;
    }
}