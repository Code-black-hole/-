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

namespace 中铁流水线管理端
{
    public partial class DLJM : Form
    {
        public static string strSQL;
        static SqlConnection sqlConnection;
        DataTable dt;

        DataBaseAccess dba = new DataBaseAccess();
        public static IdentityClass identityClass { get; set; } = new IdentityClass();
        public static WorkerProcessClass workerProcessClass { get; set; } = new WorkerProcessClass();
        public DLJM()
        {
            InitializeComponent();
            //string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            sqlConnection = DataBaseAccess.FormInit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSQL = "select * from 人员信息表 where Name='" + txtName.Text + "'and Password='" + txtPassword.Text + "'";
            SqlDataReader da = dba.Read(strSQL, sqlConnection);

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
                            strSQL = "select * from 工艺流程表 where ProcessingPersonnel='" + identityClass.Name + "' ";

                            dt = dba.Fill(strSQL, sqlConnection);
                            workerProcessClass.ProductId = dt.Rows[0][0].ToString().Trim();
                            workerProcessClass.ProcessName = dt.Rows[0][2].ToString().Trim();

                            sqlConnection = new SqlConnection(PublicAnial.str);
                            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                                sqlConnection.Open();
                            strSQL = "select * from 生产线表 where ProductId='" + workerProcessClass.ProductId + "' ";

                            dt = dba.Fill(strSQL, sqlConnection);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
