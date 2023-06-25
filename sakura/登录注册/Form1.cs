using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sakura;
using System.Data;
using System.Data.SqlClient;

namespace sakura
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            string UserID, PassWord;
            UserID = this.UID.Text;
            PassWord = this.PWD.Text;
            string SQL="select UserID,PassWord from UserTable where UserID='"+UserID+"'and PassWord='"+PassWord+"'";
            DataTable Logindt = DBHerlper.GetDataTable(SQL);
            if (Logindt.Rows.Count>0)
            {
                MainForm mform = new MainForm();
                mform.Show();
                LoginForm lgform = new LoginForm();
                this.Hide();//由于program.cs文件下的Application.Run(new LoginForm());---将LoginForm窗体设置为主窗体          使用Close或application.exit()会导致主窗体关闭而结束程序
            }
            else
            {
                MessageBox.Show("密码错误", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            sakura.登录注册.SignUPForm SNForm = new 登录注册.SignUPForm();
            SNForm.ShowDialog();
        }

        private void lostpwd_Click(object sender, EventArgs e)
        {
            登录注册.lostform lsform = new 登录注册.lostform();
            lsform.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
