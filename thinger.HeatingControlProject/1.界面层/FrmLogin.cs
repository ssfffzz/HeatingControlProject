using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.HeatingControlProject
{
    public partial class FrmLogin : Form
    {
        #region 无边框拖动 
        private Point mPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        SysAdminService sysAdminService = new SysAdminService();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("确认关闭登录窗口吗", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确认关闭登录窗口吗", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
           
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //【1】验证数据
            if (this.txt_LoginId.Text.Trim().Length == 0 || this.txt_LoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("账号或密码不能为空", "错误提示");
                return;
            }
            //【2】封装对象
            SysAdmin sysAdmin = null;
            try
            {
                sysAdmin = new SysAdmin()
                {
                    LoginId = int.Parse(txt_LoginId.Text),
                    LoginPwd = txt_LoginPwd.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("登录账号必须是整数" + ex.Message, "错误提示");
                return;
            }
            //【3】用户查询
            sysAdmin = sysAdminService.AdminLogin(sysAdmin);
            //【4】判断登录
            if (sysAdmin == null)
            {
                MessageBox.Show("账户或密码不正确", "登录提示");
                return;
            }
            else
            {
                Program.currentAdmin = sysAdmin;//把登录用户对象赋值给静态字段，给主界面用
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
