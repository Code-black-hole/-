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
    public partial class WTSBJM : Form
    {
        public static string strSQL;
        SqlConnection sqlConnection;
        DataTable dt;
        public WTSBJM()
        {
            InitializeComponent();
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select Id as '编号', ProductId AS '产品id',ProcessId AS '工序编号',Problem AS '问题描述',JobId as '登记人工号',Date as '日期',Annex AS '附件',SolveDate AS '解决时间',Memo AS '备注' from 质量问题表 ";
            SqlCommand order = new SqlCommand();
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlConnection);
            //创建数据集对象
            DataSet ds = new DataSet();
            //用SqlDataAdapter对象的Fill方法填充数据集
            da.Fill(ds, "质量问题表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                //绑定数据到DataGridView
            dt = ds.Tables["质量问题表"];
            dgvZLWTB.DataSource = dt.DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
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

                        string strSQL6 = string.Empty;
                        //DataRow.RowState用于判断改行的状态
                        
                        if (dr.RowState == DataRowState.Added)//增加
                        {
                            strSQL6 = @"insert into 质量问题表 (Id,ProductId,ProcessId,Problem,JobId,Date,Annex,SolveDate,Memo) " +
                                "values ('" + dr["编号"].ToString().Trim() + @"','" + dr["产品id"].ToString().Trim() + @"','" + dr["工序编号"].ToString().Trim() + @"','" + dr["问题描述"].ToString().Trim() + @"','" + dr["登记人工号"].ToString().Trim() + @"','" + DateTime.Now + @"','" + dr["附件"].ToString().Trim() + @"','" + dr["解决时间"].ToString().Trim()+ @"','" + dr["备注"].ToString().Trim() + @"')";
                            //'"+dr["此字段名为datagrideview里的字段名而非sql sever数据库中的"].ToString()+"'

                        }
                        else if (dr.RowState == DataRowState.Deleted)//删除
                        {
                            //已删除的行无法像上面那样获取
                            //以下用于获取已删除的行
                            // dr["ID", DataRowVersion.Original];
                            strSQL6 = @"delete from 质量问题表 where Id = '" + dr["编号", DataRowVersion.Original].ToString().Trim() + @"'";
                        }
                        else if (dr.RowState == DataRowState.Modified)//修改
                        {
                            strSQL6 = @"update 质量问题表 set ProcessId='" + dr["工序编号"].ToString().Trim() + @"', ProductId='" + dr["产品id"].ToString().Trim() + @"', Problem = '" + dr["问题描述"].ToString().Trim() + @"',JobId='" + dr["登记人工号"].ToString().Trim() + @"',Date='" + DateTime.Now + @"',Annex='" + dr["附件"].ToString().Trim() + @"',SolveDate='" + dr["解决时间"].ToString().Trim() + @"',Memo='" + dr["备注"].ToString().Trim() + @"'where Id='" + dr["编号"].ToString().Trim() + @"'";

                        }
                        SqlCommand comm = new SqlCommand(strSQL6, sqlConnection);
                        int count = comm.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                    this.Close();
                }
            }
        }
    }
}
