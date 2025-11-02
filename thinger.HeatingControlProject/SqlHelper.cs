using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//添加配置文件命名空间
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace thinger.ADO.NETDemo2
{
    /// <summary>
    /// 通用数据访问类
    /// 
    /// 静态方法（insert,delete,update）
    /// </summary>
    internal class SqlHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connstring1"].ToString();

        /// <summary>
        /// 执行insert,delete,update类型的SQL语句方法
        /// </summary>
        /// <param name="cmdText">具体的查询语句</param>
        /// <returns>受影响的行数</returns>
        /// <exception cref="Exception"></exception>
        public static int ExecuteNonQuery(string cmdText, SqlParameter[] param = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("执行ExecuteNonQuery()方法报错" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 执行select单一查询的方法
        /// </summary>
        /// <param name="cmdText">具体的sql语句查询</param>
        /// <returns>返回受影响的行数</returns>
        /// <exception cref="Exception"></exception>
        public static object ExecuteScalar(string cmdText, SqlParameter[] param = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("执行ExecuteScalar()方法报错" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行select返回只读结果集
        /// </summary>
        /// <param name="cmdText">具体的sql语句查询</param>
        /// <returns>返回SqlDataReader对象</returns>
        /// <exception cref="Exception"></exception>
        public static SqlDataReader ExecuteReader(string cmdText, SqlParameter[] param = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            try
            {
                conn.Open();
                //当从外面关闭DataReader对象的时候，同时自动关闭所连接的连接对象
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("执行ExecuteReader()方法报错" + ex.Message);
            }
        }

        /// <summary>
        /// 返回DataSet数据集的方法
        /// </summary>
        /// <param name="cmdText">具体的sql语句</param>
        /// <param name="stringName">数据表名称（可选项）</param>
        /// <returns>返回DataSet对象</returns>
        /// <exception cref="Exception"></exception>
        public static DataSet GetDataSet(string cmdText,string tableName = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                if (tableName != null && tableName != "" )
                {
                    da.Fill(ds, tableName);
                }
                else
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("执行GetDataSet()方法报错" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
