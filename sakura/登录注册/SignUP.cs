using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Sakura;
namespace sakura.登录注册
{
    public partial class SignUPForm : Form
    {
        public SignUPForm()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string uid, pwd, emile, name, ypwd;
            TextBox uidTextBox;
            //使用循环生成随机数生成账号，在循环中判断随机数是否在数据库重复，重复则重新生成，不重复则输出
            //uid=随机数
            //string Ssql="select UserID from UserTable where Uid='"+uid+"';";
            //dt=DBHerlper.GetDataTable(sql);
            //if (dt.Rows.Count>0).
            //{

            //}
            //this.IDtext.Text=uid;
            //do
            //{
            //    Random suiji = new Random();
            //    uid = suiji.Next(111111,999999999).ToString();
            //    string Sqql = "select UserID from UserTable where Uid='" + uid + "'";
            //    dt = DBHerlper.GetDataTable(Sqql);
            //    if (dt.Rows.Count==0)
            //    {
            //        this.IDtext.Text = uid;
            //    }
            //} while (dt.Rows.Count>0);

            pwd = PwdText.Text;
            ypwd = YpwdText.Text;
            name = NameText.Text;
            emile = EmileText.Text;
            uid = zhlable.Text;
            uidTextBox = new TextBox();

            if (NameText.Text == "")
            {
                MessageBox.Show("请输入昵称！");
                NameText.Focus();
            }
            else if (PwdText.Text == "")
            {
                MessageBox.Show("请输入密码！");
                PwdText.Focus();
            }
            else if (YpwdText.Text == "")
            {
                MessageBox.Show("请确认密码！");
                YpwdText.Focus();
            }
            else if (pwd!=ypwd)
            {
                MessageBox.Show("两次输入密码不一致！", "提示");
                PwdText.Focus();
            }
            else if (EmileText.Text=="")
            {
                 MessageBox.Show("请输入邮箱！");
                 EmileText.Focus();
            }
            else
            {
                string sql = string.Format("insert into  UserTable(UserID,PassWord,UserName,Emile) values('{0}','{1}','{2}','{3}')",uid,pwd,name,emile);
                if (DBHerlper.ExecuteNonQuery(sql))
                {

                    MessageBox.Show("注册成功！账号已复制到粘贴板。");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("注册失败");
                }
            }

        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {



        }

        private void SignUPForm_Load(object sender, EventArgs e)
        {
            string uid;
            DataTable dt;
            do
            {
                Random suiji = new Random();
                uid = suiji.Next(111111, 999999999).ToString();
                string Sq1 = string.Format("select UserID from UserTable where UserID = '{0}'",uid);
                dt = DBHerlper.GetDataTable(Sq1);
                if (dt.Rows.Count == 0)
                {
                    this.zhlable.Text=uid;
                    this.uidTextBox.Text = this.zhlable.Text;
                    this.uidTextBox.SelectAll();
                    this.uidTextBox.Copy();
                }
            } while (dt.Rows.Count > 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
