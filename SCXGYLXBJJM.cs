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

    public partial class SCXGYLXBJJM : Form
    {
       
        DataTable dt;
        string strSQL2 =SCXJM.flagClass.strSQL;
        string strSQL3,strSQL4,strSQL5;
        public SCXGYLXBJJM()
        {
            InitializeComponent();
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            SqlConnection sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            SqlCommand order = new SqlCommand();
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataAdapter da = new SqlDataAdapter(strSQL2, sqlConnection);
            //创建数据集对象
            DataSet ds = new DataSet();
            //用SqlDataAdapter对象的Fill方法填充数据集
            da.Fill(ds, "001型遥控器");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                 //绑定数据到DataGridView
            dt = ds.Tables["001型遥控器"];
            dgvSCXGYLUJM.DataSource = dt.DefaultView;
            sqlConnection.Close();
        }
        public static string flag1 = null, flag2 = null, flag3 = null, flag4 = null, flag5 = null, flag6 = null
           , flag7=null, flag8 = null, flag9 = null;

        private void btnXG_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            SqlConnection sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            DataTable changeTable = dt.GetChanges();
            //使用循环逐行读取数据，以获取该DataTable中的行都被进行过哪些修改
            if(changeTable==null)
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
                        string a = SCXJM.x.Trim();
                        if (dr.RowState == DataRowState.Added)//增加
                        {
                            strSQL6 = @"insert into 工艺流程表 (ProductId,ProcessId,ProcessName,WorkUnit,ProcessingTime,ProcessingPersonnel,SortId) " +
                                "values ('" + dr["产品编号"].ToString().Trim() + @"','" + dr["工序编号"].ToString().Trim() + @"','" + dr["工序名称"].ToString().Trim() + @"','" + dr["工作单元"].ToString().Trim() + @"','" + dr["加工时间"].ToString().Trim() + @"','" + dr["加工人员"].ToString().Trim() + @"','" + dr["工序顺序序号"].ToString().Trim() + @"')";
                            //'"+dr["此字段名为datagrideview里的字段名而非sql sever数据库中的"].ToString()+"'

                        }
                        else if (dr.RowState == DataRowState.Deleted)//删除
                        {
                            //已删除的行无法像上面那样获取
                            //以下用于获取已删除的行
                            // dr["ID", DataRowVersion.Original];
                            strSQL6 = @"delete from 工艺流程表 where ProductId = '" + dr["产品编号", DataRowVersion.Original].ToString().Trim() + @"'";
                        }
                        else if (dr.RowState == DataRowState.Modified)//修改
                        {
                            strSQL6 = @"update 工艺流程表 set ProcessId='" + dr["工序编号"].ToString().Trim() + @"',WorkUnit='" + dr["工作单元"].ToString().Trim() + @"',ProcessingTime='" + dr["加工时间"].ToString().Trim() + @"',ProcessingPersonnel='" + dr["加工人员"].ToString().Trim() + @"',SortId='" + dr["工序顺序序号"].ToString().Trim() + @"',ProductId  = '" + dr["产品编号"].ToString().Trim() + @"'where ProcessName = '" + dr["工序名称"].ToString().Trim() + @"'";

                        }
                        SqlCommand comm = new SqlCommand(strSQL6, sqlConnection);
                        int count = comm.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                    this.Close();
                }
            }
        }

        int y = 0;
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    if(txtXCPBH.Text==null)
        //         MessageBox.Show("序号不可为空！");
        //    else
        //    {
        //       if( MessageBox.Show("确认要添加么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
        //        {
        //            string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
        //            SqlConnection sqlConnection = new SqlConnection(str);
        //            if (sqlConnection.State == System.Data.ConnectionState.Closed)
        //                sqlConnection.Open();
        //            strSQL4 = strSQL2;
        //            SqlCommand order = new SqlCommand();
        //            //参数一：SQL语句  ，参数二：连接对象
        //            //SqlDataAdapter对象用于获取到表格并填充到数据集
        //            SqlDataAdapter da = new SqlDataAdapter(strSQL4, sqlConnection);
        //            //创建数据集对象
        //            DataSet ds = new DataSet();
        //            //用SqlDataAdapter对象的Fill方法填充数据集
        //            da.Fill(ds, "所选生产线");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
        //                                 //绑定数据到DataGridView
        //            dt = ds.Tables["所选生产线"];
        //            for(int i=0;i<dt.Rows.Count;i++)//验证是否有重复的序号
        //            {
        //                if (txtXCPBH.Text == dt.Rows[i][0].ToString()&&y==0)
        //                    y = 1;
        //                if (y == 1)
        //                    strSQL5 = "update [dbo].[" + SCXJM.x.Trim() + "] set SerialNumber=";
        //            }
        //            strSQL3 = "insert into [dbo].[" + SCXJM.x.Trim() + "] (SerialNumber,OperationNumber,OperationName,WorkUnit,Date,ProcessingPersonnel,ProcessingTime,Inspector,Remarks) values" +
        //                " ('"+txtXCPBH.Text+"','"+ txtGXBH.Text + "','"+ txtGXMC.Text + "','"+ txtGZDY.Text + "','"+ txtJGRY.Text + "','"+ txtJGSJ.Text + "','"+ txtJYRY.Text + "')";
        //            SqlCommand order1 = new SqlCommand(strSQL3, sqlConnection);
        //            sqlConnection.Close();
        //        }
        //    }
        //}

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtXCPBH.Text == "" && txtGXBH.Text == "" && txtGXMC.Text == "" && txtGZDY.Text == "" &&  txtJGRY.Text == "" && txtJGSJ.Text == "" && txtJYRY.Text == "" )
                MessageBox.Show("查询信息不能为空！", "提示", MessageBoxButtons.OK);
            else
            {
               
                if (txtXCPBH.Text != "")
                    flag1 = "(SerialNumber='" + txtXCPBH.Text + "')and";
                if (txtGXBH.Text != "")
                    flag2 = "(OperationNumber='" + txtGXBH.Text + "')and";
                if (txtGXMC.Text != "")
                    flag3 = "(OperationName='" + txtGXMC.Text + "')and";
                if (txtGZDY.Text != "")
                    flag4 = "(WorkUnit='" + txtGZDY.Text + "')and";
                if (txtJGRY.Text != "")
                    flag6 = "(ProcessingPersonnel='" + txtJGRY.Text + "')and";
                if (txtJGSJ.Text != "")
                    flag7 = "(ProcessingTime='" + txtJGSJ.Text + "')and";
                if (txtJYRY.Text != "")
                    flag8 = "(Inspector='" + txtJYRY.Text + "')and";
               
                string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
                SqlConnection sqlConnection = new SqlConnection(str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL3 = "select * from [dbo].[" +SCXJM.x.Trim() + "] where" + flag1 + flag2 + flag3 + flag4 + flag5 + flag6+flag7+flag8+flag9;
                strSQL3 = strSQL3.Substring(0, strSQL3.Length - 3);
                SqlCommand order = new SqlCommand(strSQL3, sqlConnection);
                //参数一：SQL语句  ，参数二：连接对象
                //SqlDataAdapter对象用于获取到表格并填充到数据集
                SqlDataAdapter da = new SqlDataAdapter(strSQL3, sqlConnection);
                //创建数据集对象
                DataSet ds = new DataSet();
                //用SqlDataAdapter对象的Fill方法填充数据集
                da.Fill(ds, "所选生产线");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                     //绑定数据到DataGridView
                dt = ds.Tables["所选生产线"];
                SqlDataReader db = order.ExecuteReader();
                if (db.HasRows)
                {
                    dgvSCXGYLUJM.DataSource = dt.DefaultView;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("该数据不存在！");
                }
                sqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSCXGYLUJM.DataSource = dt.DefaultView;
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
