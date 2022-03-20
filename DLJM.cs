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

namespace 中铁流水线管理端
{
    public partial class DLJM : Form
    {
        public static string strSQL;
        SqlConnection sqlConnection;
        DataTable dt;
        public static IdentityClass identityClass { get; set; } = new IdentityClass();
        public static WorkerProcessClass workerProcessClass { get; set; } = new WorkerProcessClass();
        public DLJM()
        {
            InitializeComponent();
            //string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSQL = "select * from 人员信息表 where Name='"+txtName.Text+"'and Password='"+txtPassword.Text+"'";
            SqlCommand order = new SqlCommand(strSQL, sqlConnection);
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataReader da =order.ExecuteReader();

            
            if (da.HasRows)//满足用户名密码与数据库相匹配
            {
                if (da.Read())
                {
                    if (da.GetValue(4).ToString().Trim() == "1")
                    {
                        string a = da.GetValue(2).ToString().Trim();//因为使用GetValue获取对应值多出了很多空格
                        if (a == "管理员")                           //所以先用Trim()去除空格
                        {
                            identityClass.JobId = da.GetValue(0).ToString().Trim();
                            identityClass.Name = da.GetValue(1).ToString().Trim();
                            identityClass.Identity = da.GetValue(2).ToString().Trim();
                            identityClass.Password = da.GetValue(3).ToString().Trim();
                            identityClass.State = da.GetValue(4).ToString().Trim();
                            SCXJM s = new SCXJM();
                            s.ShowDialog();
                            this.Hide();
                        }
                        else//显示工人界面
                        {
                            identityClass.JobId = da.GetValue(0).ToString().Trim();
                            identityClass.Name = da.GetValue(1).ToString().Trim();
                            identityClass.Identity = da.GetValue(2).ToString().Trim();
                            identityClass.Password = da.GetValue(3).ToString().Trim();
                            identityClass.State = da.GetValue(4).ToString().Trim();
                            sqlConnection = new SqlConnection(PublicAnial.str);
                            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                                sqlConnection.Open();
                            strSQL = "select * from 工艺流程表 where ProcessingPersonnel='"+ identityClass.Name + "' ";
                           order = new SqlCommand();
                            //参数一：SQL语句  ，参数二：连接对象
                            //SqlDataAdapter对象用于获取到表格并填充到数据集
                            SqlDataAdapter da1 = new SqlDataAdapter(strSQL, sqlConnection);
                            //创建数据集对象
                            DataSet ds = new DataSet();
                            //用SqlDataAdapter对象的Fill方法填充数据集
                            da1.Fill(ds, "工艺流程表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                                 //绑定数据到DataGridView
                            dt = ds.Tables["工艺流程表"];
                            workerProcessClass.ProductId = dt.Rows[0][0].ToString().Trim();
                            workerProcessClass.ProcessName = dt.Rows[0][2].ToString().Trim();

                            sqlConnection = new SqlConnection(PublicAnial.str);
                            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                                sqlConnection.Open();
                            strSQL = "select * from 生产线表 where ProductId='" + workerProcessClass.ProductId + "' ";
                            order = new SqlCommand();
                            //参数一：SQL语句  ，参数二：连接对象
                            //SqlDataAdapter对象用于获取到表格并填充到数据集
                             da1 = new SqlDataAdapter(strSQL, sqlConnection);
                            //创建数据集对象
                             ds = new DataSet();
                            //用SqlDataAdapter对象的Fill方法填充数据集
                            da1.Fill(ds, "生产线表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                                  //绑定数据到DataGridView
                            dt = ds.Tables["生产线表"];
                            workerProcessClass.ProductName = dt.Rows[0][4].ToString().Trim();
                            workerProcessClass.ProductionLineId = dt.Rows[0][0].ToString().Trim();
                           GRJSJM s = new GRJSJM();
                            s.ShowDialog();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("登录失败！");

                    }
                }
            }
            else
            {
                MessageBox.Show("登录失败！");
                
            }
        }
    }
}
