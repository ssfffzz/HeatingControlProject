using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thinger.HeatingControlProject
{
    /// <summary>
    /// 用户信息数据类
    /// </summary>
    public class SysAdminService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            //【1】封装查询语句
            string sql = "select LoginName,RoleName from SysAdmin where LoginId=@LoginId and LoginPwd=@LoginPwd";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@LoginId",admin.LoginId),
                new SqlParameter("@LoginPwd",admin.LoginPwd)
            };
            //【2】提交查询对象
            SqlDataReader reader = SqlHelper.ExecuteReader(sql, sp);
            //【3】封装对象
            if (reader.Read())
            {
                admin.LoginName = reader["LoginName"].ToString();
                admin.RoleName = reader["RoleName"].ToString();
            }
            else
            {
                admin = null;
            }
            reader.Close();
            return admin;
        }

        //查询显示所有的用户对象数据
        public List<SysAdmin> GetAdminList()
        {
            string sql = "select LoginId, LoginName, LoginPwd, RoleName from SysAdmin";
            SqlDataReader reader = SqlHelper.ExecuteReader(sql);
            List<SysAdmin> SysAdmins = new List<SysAdmin>();
            while (reader.Read())
            {
                SysAdmins.Add(new SysAdmin()
                {
                    LoginId = Convert.ToInt32(reader["LoginId"]),
                    LoginName = reader["LoginName"].ToString(),
                    LoginPwd = reader["LoginPwd"].ToString(),
                    RoleName = reader["RoleName"].ToString()
                });
            }
            reader.Close();
            return SysAdmins;
        }


        //添加用户
        public int AddSysAdmin(SysAdmin sysAdmin)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into SysAdmin(LoginName,LoginPwd,RoleName) ");
            stringBuilder.Append("values(@LoginName,@LoginPwd,@RoleName)");
            //这是正常的写法
            //SqlParameter sp1 = new SqlParameter("@LodinName", sysAdmin.LoginName);
            //SqlParameter sp2 = new SqlParameter("@LoginPwd", sysAdmin.LoginPwd);
            //SqlParameter[] sp = new SqlParameter[]
            //{
            //   sp1,sp2
            //};
            //下面这是简写
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@RoleName",sysAdmin.RoleName)
            };
            int count = SqlHelper.ExecuteNonQuery(stringBuilder.ToString(), sp);
            return count;
        }


        //修改用户
        public int ModifySysAdmin(SysAdmin sysAdmin)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("update SysAdmin set LoginName=@LoginName,LoginPwd=@LoginPwd");
            stringBuilder.Append(",RoleName=@RoleName where LoginId=@LoginId");
            //这是正常的写法
            //SqlParameter sp1 = new SqlParameter("@LodinName", sysAdmin.LoginName);
            //SqlParameter sp2 = new SqlParameter("@LoginPwd", sysAdmin.LoginPwd);
            //SqlParameter[] sp = new SqlParameter[]
            //{
            //   sp1,sp2
            //};
            //下面这是简写
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@LoginName",sysAdmin.LoginName),
                new SqlParameter("@LoginPwd",sysAdmin.LoginPwd),
                new SqlParameter("@RoleName",sysAdmin.RoleName),
                new SqlParameter("@LoginId",sysAdmin.LoginId),
            };
            int count = SqlHelper.ExecuteNonQuery(stringBuilder.ToString(), sp);
            return count;
        }

        //删除用户
        public int DeleteSysAdmin(int loginId)
        {
            string sql = "delete from SysAdmin where LoginId=@LoginId";
           
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@LoginId",loginId),
            };
            int count = SqlHelper.ExecuteNonQuery(sql, sp);
            return count;
        }



    }
}
