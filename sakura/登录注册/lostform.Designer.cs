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
            this.SuspendLayout();
            // 
            // EmileText
            // 
            this.EmileText.Location = new System.Drawing.Point(124, 74);
            this.EmileText.Name = "EmileText";
            this.EmileText.Size = new System.Drawing.Size(100, 21);
            this.EmileText.TabIndex = 0;
            // 
            // emilelable
            // 
            this.emilelable.AutoSize = true;
            this.emilelable.Location = new System.Drawing.Point(60, 83);
            this.emilelable.Name = "emilelable";
            this.emilelable.Size = new System.Drawing.Size(29, 12);
            this.emilelable.TabIndex = 1;
            this.emilelable.Text = "邮箱";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 137);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "提交";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // lostform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.emilelable);
            this.Controls.Add(this.EmileText);
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
    }
}