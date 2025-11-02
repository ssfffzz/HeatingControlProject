using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.HeatingControlProject
{
    public partial class FrmUserManage : Form
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //显示行号
        private void dgv_UserList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewHelper.DgvRowPostPaint(dgv_UserList, e);  //显示行号
        }

        private SysAdminService sysAdminService = new SysAdminService();
        List<SysAdmin> listAdmin = null;
        public FrmUserManage()
        {
            InitializeComponent();
            //禁止自动生成列
            this.dgv_UserList.AutoGenerateColumns = false;

            //查询所有用户
            this.listAdmin = sysAdminService.GetAdminList();
            if (listAdmin != null)
            {
                this.dgv_UserList.DataSource = listAdmin;
                SysAdmin sysAdmin = this.listAdmin.First();
                this.txt_LoginName.Text = sysAdmin.LoginName;
                this.txt_LoginPwd.Text = sysAdmin.LoginPwd;
                this.cmb_RoleName.Text = sysAdmin.RoleName;
            }
        }

        //单击单元格事件显示当前用户信息
        private void dgv_UserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SysAdmin sysAdmin = listAdmin[e.RowIndex];
                this.txt_LoginName.Text = sysAdmin.LoginName;
                this.txt_LoginPwd.Text = sysAdmin.LoginPwd;
                this.cmb_RoleName.Text = sysAdmin.RoleName;
            }
        }

        //添加用户
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //【1】用户名和密码非空判断
            if (this.txt_LoginName.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空", "错误提示");
                return;
            }
            if (this.txt_LoginPwd.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空", "错误提示");
                return;
            }
            //【2】判断用户是否存在
            foreach (SysAdmin item in listAdmin)
            {
                if (item.LoginName == this.txt_LoginName.Text.Trim())
                {
                    MessageBox.Show("用户名已存在", "错误提示");
                    return;
                }
            }
            //【3】封装用户信息          
            SysAdmin sysAdmin = new SysAdmin();
            sysAdmin.LoginName = this.txt_LoginName.Text;
            sysAdmin.LoginPwd = this.txt_LoginPwd.Text;
            sysAdmin.RoleName = this.cmb_RoleName.Text;
            //【4】添加用户到数据库
            try
            {
                sysAdminService.AddSysAdmin(sysAdmin);
                //下面是我自己想的方法（添加用户到集合）
                //this.listAdmin = sysAdminService.GetAdminList();//查询所有用户
                //this.dgv_UserList.DataSource = listAdmin;
                //下面是老师的方法，添加用户到集合
                this.listAdmin.Add(sysAdmin);
                this.dgv_UserList.DataSource = null;
                this.dgv_UserList.DataSource = listAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加用户信息失败，原因：" + ex.Message, "错误提示");
            }


        }

        //修改用户
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            //【1】用户名和密码非空判断
            if (this.txt_LoginName.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空", "错误提示");
                return;
            }
            if (this.txt_LoginPwd.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空", "错误提示");
                return;
            }
            //【2】判断用户是否存在（修改时不能和其他用户重名）
            int currentLoginId = Convert.ToInt32(this.dgv_UserList.CurrentRow.Cells["LoginId"].Value);//当前选中行用户ID
            foreach (SysAdmin item in listAdmin)
            {
                if (item.LoginName == this.txt_LoginName.Text.Trim() && item.LoginId != currentLoginId)
                {
                    MessageBox.Show("用户名已存在", "错误提示");
                    return;
                }
            }
            //【3】封装用户信息          
            SysAdmin sysAdmin = new SysAdmin();
            sysAdmin.LoginName = this.txt_LoginName.Text;
            sysAdmin.LoginPwd = this.txt_LoginPwd.Text;
            sysAdmin.RoleName = this.cmb_RoleName.Text;
            sysAdmin.LoginId = currentLoginId;
            //【4】修改用户到数据库
            try
            {
                sysAdminService.ModifySysAdmin(sysAdmin);
                //同步更新用户信息
                this.listAdmin = sysAdminService.GetAdminList();
                this.dgv_UserList.DataSource = null;
                this.dgv_UserList.DataSource = listAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show("更改用户失败，原因：" + ex.Message, "错误提示");
            }
        }
        //删除用户
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int currentLoginId = Convert.ToInt32(this.dgv_UserList.CurrentRow.Cells["LoginId"].Value);//当前选中行用户ID
            DialogResult result = MessageBox.Show("确定要删除用户信息吗？","删除提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            try
            {
                sysAdminService.DeleteSysAdmin(currentLoginId);
                //同步更新用户信息
                this.listAdmin = sysAdminService.GetAdminList();
                this.dgv_UserList.DataSource = null;
                this.dgv_UserList.DataSource = listAdmin;

            }
            catch (Exception ex)
            {
                MessageBox.Show("删除用户失败，原因：" + ex.Message, "错误提示");
            }


        }



    }
}
