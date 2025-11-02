using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace thinger.HeatingControlProject
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmLogin = new FrmLogin();
            DialogResult result = frmLogin.ShowDialog();//登录界面点保存会返回一个DialogResult.OK
            if (result == DialogResult.OK)
            {

                Application.Run(new FrmMain());
            }
            else
                Application.Exit();//退出
        }
        //这是用来保存当前登录用户对象
        public static SysAdmin currentAdmin = null;
    }
}
