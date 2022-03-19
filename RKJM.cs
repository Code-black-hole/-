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
    public partial class RKJM : Form
    {
        public static string strSQL;
        SqlConnection sqlConnection;
        DataTable dt;
        public RKJM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select ProductId as '产品编号',FormId as '单号',ProductName as '产品名称',FinishedProductID as '成品Id',Date as '生产日期',WareHousingStatus as '入库状态'from 成品完成表 where FormId='"+txtFormId.Text.ToString().Trim()+ "'and WareHousingStatus='未入库' ";
            SqlCommand order = new SqlCommand();
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlConnection);
            //创建数据集对象
            DataSet ds = new DataSet();
            //用SqlDataAdapter对象的Fill方法填充数据集
            da.Fill(ds, "生产线表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                //绑定数据到DataGridView
            dt = ds.Tables["生产线表"];
            dgvRK.DataSource = dt.DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            SqlConnection sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            DataTable Table = dt;
            if (MessageBox.Show("确认要将当前表格中的成品入库么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (DataRow dr in Table.Rows)//DataTable.Rows是该表所有行所组成的一个集合
                {
                    //将成品完成表中的 入库状态 更改为已入库
                  string strSQL6 = @"update 成品完成表 set WareHousingStatus='已入库'";
                  SqlCommand comm = new SqlCommand(strSQL6, sqlConnection);
                    int count = comm.ExecuteNonQuery();
                   
                }
                //并在成品库存表中添加一条数据
               string strSQL7 = "insert into 成品库存表 (FormId,ProductName,Quantity) values ('"+dt.Rows[0][1].ToString()+"','"+dt.Rows[0][2].ToString()+"','"+dt.Rows.Count+"')";
                SqlCommand comm1 = new SqlCommand(strSQL7, sqlConnection);
               int count1 = comm1.ExecuteNonQuery();
                sqlConnection.Close();
                this.Close();
            }
        }
    } 
                   
               
                  
                       
                
}
