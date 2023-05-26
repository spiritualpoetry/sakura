using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using Sakura;

namespace sakura.登录注册
{
    public partial class lostform : Form
    {
        public lostform()
        {
            InitializeComponent();
        }

        private void lostform_Load(object sender, EventArgs e)
        {
            Random rd  = new Random();//生成随机数验证码
            YZM.Text=Convert.ToString(rd.Next(100000,999999));//声称随机数存放到YZM标签中，将验证码标签隐藏
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string Emile;
            Emile = EmileText.Text;
            DataTable dt = new DataTable();
            string sql = "select Emile from UserTable where Emile='" + Emile + "'";
            dt = DBHerlper.GetDataTable(sql);
            if (dt.Rows.Count>0)
            {
                MailMessage maillMessage = new MailMessage();
                maillMessage.From = new MailAddress("2095408981@qq.com");
                maillMessage.To.Add(new MailAddress(Emile));
                maillMessage.Subject = "你瞅啥来点餐";
                maillMessage.Body="您的验证码是"+YZM.Text;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "Smtp.qq.com ";
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("2095408981@qq.com", "anvrcoswtuuqbedj");
                smtpClient.Send(maillMessage);
                MessageBox.Show("发送成功");
                
            }
            else
            {
                MessageBox.Show("输入的邮箱不存在！","提示");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (YZMText.Text==YZM.Text) 
            {
                lostform ls1 = new lostform();
                this.Hide();
                lostform2 ls2 = new lostform2();
                ls2.ShowDialog();
            }
            else
            {
                MessageBox.Show("请输入正确的验证码");
            }
        }
    }
}
