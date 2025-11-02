using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace thinger.HeatingControlProject
{
    //数据库通用数据访问类
    public  class SqlHelper
    {
        //读取配置文件获得连接字符串
        private static string connString =
            ConfigurationManager.ConnectionStrings["connString1"].ToString();

        /// <summary>
        /// 执行非查询操作
        /// </summary>
        /// <param name="cmdText">sql语句</param>
        /// <param name="param">Sql语句参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText,SqlParameter[] param=null)
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
                throw new Exception("ExecuteNonQuery()异常：" + ex.Message);
            }
            finally   //以上不管是否发生异常，都会执行的代码
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 返回单一结果查询
        /// </summary>
        /// <param name="cmdText">SQL语句或存储过程名称</param>
        ///    /// <param name="param">Sql语句参数</param>
        /// <returns>返回单行单列</returns>
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
                throw new Exception("ExecuteScalar()异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 返回只读结果集的查询
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="param">Sql语句参数</param>
        /// <returns></returns>

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
                //必须添加这个枚举
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("ExecuteReader()异常：" + ex.Message);
            }
        }
        /// <summary>
        /// 返回一个DataSet内存数据集的查询
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="tableName">数据表名称</param>
        /// <param name="param">Sql语句参数</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, string tableName = null, SqlParameter[] param = null)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                if (tableName == null)
                    da.Fill(ds);
                else
                    da.Fill(ds, tableName);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("GetDataSet（）异常：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
