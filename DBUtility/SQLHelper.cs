using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Common;


namespace DBUtility
{
    public class SQLHelper
    {
        //数据库连接字符串
        //public static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public static string connString = StringSecurity.DESDecrypt(ConfigurationManager.ConnectionStrings["connString"].ToString());
        //#region 封装格式化SQL语句执行
        ///// <summary>
        ///// 执行增删改方法
        ///// </summary>
        ///// <param name="sql">sql语句</param>
        ///// <returns>返回受影响的行数</returns>
        //public static int Update(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    try
        //    {
        //        conn.Open();
        //        return cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        //将异常信息写入日志
        //        //WriteLog(ex.Message);
        //        // throw new Exception("调用 public static int UpDate(string sql)方法时发生错误：" + ex.Message)
        //        string errorInfo = "调用 public static int Update(string sql)方法时发生错误：" + ex.Message;
        //        WriteLog(errorInfo);
        //        throw new Exception(errorInfo);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        ///// <summary>
        ///// 获取单一结果的查询
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public static object GetSingleResult(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    try
        //    {
        //        conn.Open();
        //        return cmd.ExecuteScalar();
        //    }
        //    catch (Exception ex)
        //    {
        //        //将异常信息写入日志
        //        string errorInfo = "调用 public static object GetSingleResult(string sql)方法时发生错误：" + ex.Message;
        //        WriteLog(errorInfo);
        //        throw new Exception(errorInfo);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        ///// <summary>
        ///// 获取一个结果集的查询
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public static SqlDataReader GetReader(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    try
        //    {
        //        conn.Open();
        //        return cmd.ExecuteReader(CommandBehavior.CloseConnection); //CommandBehavior.CloseConnection 执行完毕后，自动关闭对象，无须手动释放
        //    }
        //    catch (Exception ex)
        //    {
        //        conn.Close();
        //        //将异常信息写入日志
        //        string errorInfo = "调用 public static SqlDataReader GetReader(string sql)方法时发生错误：" + ex.Message;
        //        WriteLog(errorInfo);
        //        throw new Exception(errorInfo);
        //    }

        //}

        //public static DataSet GetDataSet(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();//创建内存数据集
        //    try
        //    {
        //        conn.Open();
        //        da.Fill(ds);
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {

        //        //将异常信息写入日志
        //        string errorInfo = "调用 public static DataSet GetDataSet(string sql)方法时发生错误：" + ex.Message;
        //        WriteLog(errorInfo);
        //        throw new Exception(errorInfo);
        //    }
        //}
        //#endregion

        #region 封装带参数的SQL语句
        public static int Update(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string errorInfo = "调用 public static int Update(string sql, SqlParameter[] param)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 单一结果的查询
        /// </summary>
        /// <param name="spName"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string errorInfo = "调用 public static object GetSingleResult(string sql, SqlParameter[] param)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }

        public static SqlDataReader GetReader(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection); //CommandBehavior.CloseConnection 执行完毕后，自动关闭对象，无须手动释放
            }
            catch (Exception ex)
            {
                conn.Close();
                //将异常信息写入日志
                string errorInfo = "调用 public static SqlDataReader GetReader(string sql, SqlParameter[] param)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }

        }

        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
               
                return cmd.ExecuteReader(CommandBehavior.CloseConnection); //CommandBehavior.CloseConnection 执行完毕后，自动关闭对象，无须手动释放
            }
            catch (Exception ex)
            {
                conn.Close();
                //将异常信息写入日志
                string errorInfo = "调用 public static SqlDataReader GetReader(string sql, SqlParameter[] param)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }

        }
        /// <summary>
        /// 启用事务提交多条带参数的SQL语句
        /// </summary>
        /// <param name="mainSql">主表SQL语句</param>
        /// <param name="mainParam">主表SQL语句对应的参数</param>
        /// <param name="detailSql">从表SQL语句</param>
        /// <param name="detailParam">从表SQL语句对应的参数数组集合</param>
        /// <returns>返回事务是否执行成功</returns>
        public static bool UpdateByTran(string mainSql,SqlParameter[] mainParam,
            string detailSql,List<SqlParameter[]> detailParam)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction(); //开始事务
                if(mainSql != null && mainSql.Length != 0)
                {
                    cmd.CommandText = mainSql;
                    cmd.Parameters.AddRange(mainParam);
                    cmd.ExecuteNonQuery();
                }

                foreach(SqlParameter[] param in detailParam)
                {
                    cmd.CommandText = detailSql;
                    cmd.Parameters.Clear();
                    cmd.ExecuteNonQuery();
                }

                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//回滚事务
                }
                string errorInfo = "调用 public static bool UpdateByTran(string mainSql,SqlParameter[] mainParam,string detailSql, List< SqlParameter[] > detailParam)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;//清空事务
                }
            }
        }
        #endregion

        #region 封装调用存储过程执行的各种方法

        /// <summary>
        /// 执行增删改，通过存储过程
        /// </summary>
        /// <param name="spName">存储过程名称</param>
        /// <param name="param">参数</param>
        /// <returns></returns>
        public static int UpdateByProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;//声明当前操作是存储过程
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string errorInfo = "调用 public static int UpdateByProcedure(string spName, SqlParameter[] param)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 单一结果的查询
        /// </summary>
        /// <param name="spName"></param>
        /// <returns></returns>
        public static object GetSingleResultByProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;//声明当前操作是存储过程
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string errorInfo = "调用 public static object GetSingleResult(string sql, SqlParameter[] param)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 通过调用存储过程获取一个结果集
        /// </summary>
        /// <param name="spName">存储过程名称</param>
        /// <param name="param">参数</param>
        /// <returns></returns>
        public static SqlDataReader GetReaderByProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;//声明当前操作是存储过程
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection); //CommandBehavior.CloseConnection 执行完毕后，自动关闭对象，无须手动释放
            }
            catch (Exception ex)
            {
                conn.Close();
                //将异常信息写入日志
                string errorInfo = "调用 public static SqlDataReader GetReader(string sql, SqlParameter[] param)方法时发生错误：" + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }

        }


        #endregion

        #region 其他方法
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="log"></param>
        private static void WriteLog(string log)
        {
            FileStream fs = new FileStream("sqlhelper.log", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now.ToString() + " " +log);
            sw.Close();
            fs.Close();
        }

        #endregion
    }
}
