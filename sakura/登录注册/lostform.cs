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
                lostform ls1 = new lostform();
                this.Hide();
                lostform2 ls2 = new lostform2();
                ls2.ShowDialog();
            }
            else
            {
                MessageBox.Show("输入的邮箱不存在！","提示");
            }
        }
    }
}
