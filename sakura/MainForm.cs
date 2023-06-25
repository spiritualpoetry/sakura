using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sakura
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            VBpanel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VBpanel()//隐藏子菜单方法
        {
            DDpanel.Visible = false;
            SETpanel.Visible = false;
            DCpanel.Visible = false;
        }
        private void hidesubmenu()
        {
            if (DDpanel.Visible==true) 
            {
                DDpanel.Visible = false;
            }
            if (SETpanel.Visible == true)
            {
                SETpanel.Visible = false;
            }
            if (DCpanel.Visible == true)
            {
                DCpanel.Visible = false;
            }
        }
        private void showsubmenu(Panel submenu) //显示子菜单方法
        {
            if (submenu.Visible==false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Form activeForm = null;//添加变量存放当前显示窗体
        private void openchildform(Form childform)
        {
            if (activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;// 去边框
            childform.Dock= DockStyle.Fill;
            childpanel.Controls.Add(childform);//窗体填充容器控件
            childpanel.Tag = childform;
            childform.Show();
        }
        #region 点餐
        private void button2_Click(object sender, EventArgs e)
        {
            showsubmenu(DCpanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidesubmenu();
            openchildform(new Form1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        #endregion
        #region 订单
        private void button5_Click_1(object sender, EventArgs e)
        {
            showsubmenu(DDpanel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        #endregion
        #region 设置
        private void button8_Click(object sender, EventArgs e)
        {
            showsubmenu(SETpanel);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }
        #endregion  
    }
}
