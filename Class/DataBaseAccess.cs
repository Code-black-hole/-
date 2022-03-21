using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using 中铁流水线管理端.Class;


namespace 中铁流水线管理端.Class
{
    public class DataBaseAccess
    {
        public DataBaseAccess()
        {

        }
        #region 初始连接
        /// <summary>
        /// 初始连接
        /// </summary>
        /// <returns></returns>
        public static SqlConnection FormInit()
        {
            SqlConnection SqlConnection = new SqlConnection(PublicAnial.str);
            SqlConnection.Open();
            return SqlConnection;
        }
        #endregion

        #region Read
        /// <summary>
        /// 读取并返回数据集
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="sqlConnection"></param>
        /// <returns></returns>
        public SqlDataReader Read(string strSQL, SqlConnection sqlConnection)
        {
            SqlCommand order = new SqlCommand(strSQL, sqlConnection);
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataReader da = order.ExecuteReader();
            return da;
        }
        #endregion

        #region
        /// <summary>
        /// 将查询到的数据填充到DataTable并返回
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="sqlConnection"></param>
        /// <returns></returns>
        public DataTable Fill(string strSQL, SqlConnection sqlConnection)
        {

            SqlCommand order = new SqlCommand();
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataAdapter da1 = new SqlDataAdapter(strSQL, sqlConnection);
            //创建数据集对象
            DataSet ds = new DataSet();
            //用SqlDataAdapter对象的Fill方法填充数据集
            da1.Fill(ds, "工艺流程表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                  //绑定数据到DataGridView
            DataTable dt = ds.Tables["工艺流程表"];
            return dt;
        }
        #endregion

        #region
        /// <summary>
        /// 执行当前SQL语句
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="sqlConnection"></param>
        public void Implement(string strSQL)
        {
            SqlConnection sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            SqlCommand order = new SqlCommand(strSQL, sqlConnection);
            int count1 = order.ExecuteNonQuery();
        }
        #endregion
    }
}
