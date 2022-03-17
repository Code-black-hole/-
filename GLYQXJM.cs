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
    public partial class GLYQXJM : Form
    {
        public static string strSQL, strSQL2;
        SqlConnection sqlConnection;

        private void button1_Click(object sender, EventArgs e)
        {
            //strSQL = "select * from 人员信息表 where Name='" + txtName.Text + "'and Password='" + txtPassword.Text + "'";
            SqlCommand order = new SqlCommand(PublicAnial.str, sqlConnection);
            int count1 = order.ExecuteNonQuery();
            SqlDataReader da = order.ExecuteReader();
            if (da.HasRows)//满足用户名密码与数据库相匹配
            {
                if (da.Read())
                {
                    if (da.GetValue(4).ToString().Trim() == "1")
                    {
                        string a = da.GetValue(2).ToString().Trim();//因为使用GetValue获取对应值多出了很多空格
                        if (a == "管理员")                           //所以先用Trim()去除空格
                        {
                            GRJSJM.glyqxClass.flag = 1;
                            this.Close();

                        }
                        else//显示工人界面
                        {
                            MessageBox.Show("权限有误！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("登录失败！");

                    }
                }
            }
        }

        public GLYQXJM()
        {
            InitializeComponent();
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
           
        }
    }
}
