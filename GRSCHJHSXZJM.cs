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
    public partial class GRSCHJHSXZJM : Form
    {

        public static string strSQL,strSQL2;
        SqlConnection sqlConnection;
        DataTable dt,dt1;
        public string flag, ProductionLineId, ProcessId;
        public static WorkerProcessClass workerProcessClass { get; set; } = new WorkerProcessClass();

      

        public GRSCHJHSXZJM()
        {
            InitializeComponent();
            cbxXZGX.Text = "";
            cbxXZSCX.Text = "";
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select * from 生产线表 ";
            SqlCommand order = new SqlCommand();
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlConnection);
            //创建数据集对象
            DataSet ds = new DataSet();
            //用SqlDataAdapter对象的Fill方法填充数据集
            da.Fill(ds, "生产线总表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                 //绑定数据到DataGridView
            dt = ds.Tables["生产线总表"];
            cbxXZSCX.DataSource = dt;
            
            cbxXZSCX.DisplayMember = "ProductionLineName";
            
        }

        private void cbxXZSCX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxXZSCX.Text != "System.Data.DataRowView")
            {
                //通过选取的生产线名称查询生产线表，获得对应的产品编号 
               // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
                sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL = "select * from 生产线表 where ProductionLineName='" + cbxXZSCX.Text.ToString().Trim() + "'";
                ProductionLineId = cbxXZSCX.SelectedText.ToString().Trim();
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

                //通过获取到的产品编号查询对应的工序流程
                //string str1 = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
                sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL2 = "select * from 工艺流程表 where ProductId='" + dt.Rows[0][3].ToString().Trim() + "'";
                SqlCommand order1 = new SqlCommand();
                //参数一：SQL语句  ，参数二：连接对象
                //SqlDataAdapter对象用于获取到表格并填充到数据集
                SqlDataAdapter da1 = new SqlDataAdapter(strSQL2, sqlConnection);
                //创建数据集对象
                DataSet ds1 = new DataSet();
                //用SqlDataAdapter对象的Fill方法填充数据集
                da1.Fill(ds1, "工艺流程表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                       //绑定数据到DataGridView
                dt1 = ds1.Tables["工艺流程表"];
                cbxXZGX.DataSource = dt1;
                cbxXZGX.DisplayMember = "ProcessName";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxXZGX.Text == "" ||cbxXZSCX.Text == "")
            {
                MessageBox.Show("生产线或工序未选择！");
            }
            else
            {
                workerProcessClass.ProductName = dt.Rows[0][4].ToString().Trim();
                workerProcessClass.ProductId = dt1.Rows[0][0].ToString().Trim();
                workerProcessClass.ProductionLineId = cbxXZSCX.Text.ToString().Trim();
                workerProcessClass.ProcessName = cbxXZGX.Text.ToString().Trim();
                GRJSJM s = new GRJSJM();
                s.ShowDialog();
                this.Close();
            }
        }
    }
}
