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
    public partial class SCXBJJM : Form
    {
        public static string strSQL;
        SqlConnection sqlConnection;
        DataTable dt;
        string strSQL6;
        public SCXBJJM()
        {
            InitializeComponent();
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select ProductionLineId AS '生产线编号', ProductionLineName AS '生产线名称',ProductionWorkshop AS '生产车间',ProductId AS '产品编号',ProductName as '产品名称', Time AS '时间', State AS '状态',Memo AS '备注' from 生产线表 ";
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
            dgvSCXBJJM.DataSource = dt.DefaultView;
        }
        public static string flag1 = null, flag2 = null, flag3 = null, flag4 = null, flag5 = null, flag6 = null
          , flag7 = null, flag8 = null, flag9 = null;

        private void dgvSCXBJJM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int k = 0;
            //string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            SqlConnection sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            DataTable changeTable = dt.GetChanges();
            //使用循环逐行读取数据，以获取该DataTable中的行都被进行过哪些修改
            if (changeTable == null)
            {
                MessageBox.Show("您并未进行任何修改！");
            }
            else
            {
                if (MessageBox.Show("确认要保存所有修改么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (DataRow dr in changeTable.Rows)//DataTable.Rows是该表所有行所组成的一个集合
                    {

                        string strSQL7 = string.Empty;
                        //DataRow.RowState用于判断改行的状态
                       
                        if (dr.RowState == DataRowState.Added)//增加
                        {
                            k = 1;
                            strSQL7= @"insert into [dbo].[生产线表] (ProductionLineId,ProductionLineName,ProductionWorkshop,ProductId,ProductName,Time,State,Memo) " +
                                "values ('" + dr["生产线编号"].ToString().Trim() + @"','" + dr["生产线名称"].ToString().Trim() + @"','" + dr["生产车间"].ToString().Trim() + @"','" + dr["产品编号"].ToString().Trim() + @"','" + dr["产品名称"].ToString().Trim() + @"','"+dr["时间"].ToString().Trim()+"','开启','" + dr["备注"].ToString().Trim() + @"')";
                            //'"+dr["此字段名为datagrideview里的字段名而非sql sever数据库中的"].ToString()+"'

                        }
                        
                        else if (dr.RowState == DataRowState.Modified)//修改
                        {
                            strSQL7 = @"update [dbo].[生产线表] set ProductionLineName='" + dr["生产线名称"].ToString().Trim() + @"',ProductionWorkshop = '" + dr["生产车间"].ToString().Trim() + @"',ProductId='" + dr["产品编号"].ToString().Trim() + @"',ProductName='" + dr["产品名称"].ToString().Trim() + @"',Time='"+dr["时间"].ToString().Trim()+@"',Memo='" + dr["备注"].ToString().Trim() + @"'where ProductionLineId  = '" + dr["生产线编号"].ToString().Trim() + @"'";

                        }
                       SqlCommand comm = new SqlCommand(strSQL7, sqlConnection);
                            int count = comm.ExecuteNonQuery();
                     }
                    sqlConnection.Close();
                    this.Close();
                }
            }
        }   
                        
                           
                   
                      


        private void button1_Click(object sender, EventArgs e)
        {
            //string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select SerialNumber AS '序号', ProductionLineNumber AS '生产线编号',Name AS '名称', ProductionWorkshop AS '生产车间', Time AS '时间', State AS '状态',Remarks AS '备注' from 生产线总表 ";
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
            dgvSCXBJJM.DataSource = dt.DefaultView;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtXH.Text == "" && txtGXBH.Text == "" && txtGXMC.Text == "" && txtGZDY.Text == "" && txtRQ.Text == "" && txtJGRY.Text == "" && txtJGSJ.Text == "" && txtJYRY.Text == "" && txtBZ.Text == "")
                MessageBox.Show("查询信息不能为空！", "提示", MessageBoxButtons.OK);
            else
            {

                if (txtXH.Text != "")
                    flag1 = "(SerialNumber='" + txtXH.Text + "')and";
                if (txtGXBH.Text != "")
                    flag2 = "(OperationNumber='" + txtGXBH.Text + "')and";
                if (txtGXMC.Text != "")
                    flag3 = "(OperationName='" + txtGXMC.Text + "')and";
                if (txtGZDY.Text != "")
                    flag4 = "(WorkUnit='" + txtGZDY.Text + "')and";
                if (txtRQ.Text != "")
                    flag5 = "(Date='" + txtRQ.Text + "')and";
                if (txtJGRY.Text != "")
                    flag6 = "(ProcessingPersonnel='" + txtJGRY.Text + "')and";
                if (txtJGSJ.Text != "")
                    flag7 = "(ProcessingTime='" + txtJGSJ.Text + "')and";
                if (txtJYRY.Text != "")
                    flag8 = "(Inspector='" + txtJYRY.Text + "')and";
                if (txtBZ.Text != "")
                    flag9 = "(Remarks='" + txtBZ.Text + "')and";
               // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
                SqlConnection sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL6 = "select * from [dbo].[" + SCXJM.x.Trim() + "] where" + flag1 + flag2 + flag3 + flag4 + flag5 + flag6 + flag7 + flag8 + flag9;
                strSQL6 = strSQL6.Substring(0, strSQL6.Length - 3);
                SqlCommand order = new SqlCommand(strSQL6, sqlConnection);
                //参数一：SQL语句  ，参数二：连接对象
                //SqlDataAdapter对象用于获取到表格并填充到数据集
                SqlDataAdapter da = new SqlDataAdapter(strSQL6, sqlConnection);
                //创建数据集对象
                DataSet ds = new DataSet();
                //用SqlDataAdapter对象的Fill方法填充数据集
                da.Fill(ds, "所选生产线");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                     //绑定数据到DataGridView
                dt = ds.Tables["所选生产线"];
                SqlDataReader db = order.ExecuteReader();
                if (db.HasRows)
                {
                    dgvSCXBJJM.DataSource = dt.DefaultView;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("该数据不存在！");
                }
                sqlConnection.Close();
            }
        }
    }
}
