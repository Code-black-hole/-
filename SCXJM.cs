﻿using System;
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
    public partial class SCXJM : Form
    {
        public static string strSQL;
        SqlConnection sqlConnection;
        DataTable dt;
        public SCXJM()
        {
            InitializeComponent();
          //  string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select ProductionLineId AS '生产线编号',ProductionLineName AS '生产线名称', ProductionWorkshop AS '生产车间',ProductId as '产品编号',ProductName as '产品名称',Time AS '时间', State AS '状态',Memo AS '备注' from 生产线表 ";
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
            dgvSCXJM.DataSource = dt.DefaultView;
        }
       public static string x,strSQL1;
       public string c;
        private void dgvSCXJM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            //先从产品表查找该生产线生产产品的编号
            int j = this.dgvSCXJM.CurrentRow.Index;
            x = dgvSCXJM.Rows[j].Cells[3].Value.ToString().Trim();
            strSQL1 = "select ProductId as'产品编号',ProcessId as'工序编号',ProcessName as'工序名称',WorkUnit as'工作单元',ProcessingTime as'加工时间',ProcessingPersonnel as'加工人员',SortId as '工序顺序序号' from 工艺流程表 where ProductId = '" + x + "'".Trim();
            SCXGYLXJM s = new SCXGYLXJM();
            s.ShowDialog();
           
        }
        public static string ProductionLineName;
        private void dgvSCXJM_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            //先从产品表查找该生产线生产产品的编号
            int j = this.dgvSCXJM.CurrentRow.Index;
            ProductionLineName= dgvSCXJM.Rows[j].Cells[1].Value.ToString().Trim();
            x = dgvSCXJM.Rows[j].Cells[3].Value.ToString().Trim();
            strSQL1 = "select ProductId as'产品编号',ProcessId as'工序编号',ProcessName as'工序名称',WorkUnit as'工作单元',ProcessingTime as'加工时间',ProcessingPersonnel as'加工人员',SortId as '工序顺序序号' from 工艺流程表 where ProductId = '" + x + "'".Trim();
            SCXGYLXJM s = new SCXGYLXJM();
            s.ShowDialog();
            

        }
        public static string l;//记录生产线编号
        private void dgvSCXJM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            int j = this.dgvSCXJM.CurrentRow.Index;
            l= dgvSCXJM.Rows[j].Cells[0].Value.ToString().Trim();
            x = dgvSCXJM.Rows[j].Cells[6].Value.ToString().Trim();
            if (x == "开启")
            {
                if (MessageBox.Show("确认要关闭该生产线么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //删除表中除生产线编号和状态外的其他信息
                    strSQL = "update 生产线表 set ProductionLineName=null , ProductionWorkshop=null , ProductId=null , ProductName=null , Memo=null where ProductionLineId='" + l + "' ";
                    SqlCommand order = new SqlCommand(strSQL, sqlConnection);
                    int count = order.ExecuteNonQuery();
                    //转换该生产线状态列
                    strSQL = "update 生产线表 set State = '关闭' where ProductionLineId = '"+ dgvSCXJM.Rows[j].Cells[0].Value.ToString().Trim() + "'";
                     order = new SqlCommand(strSQL, sqlConnection);
                     count = order.ExecuteNonQuery();
                    //删除对应工序中的加工人员
                    strSQL = "update 工艺流程表 set ProcessingPersonnel=null";
                    order = new SqlCommand(strSQL, sqlConnection);
                    count = order.ExecuteNonQuery();
                    //将该操作录入生产线状态表
                     strSQL = "insert into 生产线状态表 (ProductionLineId,State,OperationDate,Operator) values('"+ dgvSCXJM.Rows[j].Cells[0].Value.ToString().Trim() + "','关闭','"+DateTime.Now+"','"+DLJM.identityClass.Name+"')";
                    order = new SqlCommand(strSQL, sqlConnection);
                    int count1 = order.ExecuteNonQuery();
                }
            }
            else
            {
                if (MessageBox.Show("确认要开启该生产线么？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    strSQL = "update 生产线表 set State = '开启' where ProductionLineId = '" + dgvSCXJM.Rows[j].Cells[0].Value.ToString().Trim() + "'";
                    SqlCommand order = new SqlCommand(strSQL, sqlConnection);
                    int count = order.ExecuteNonQuery();
                   
                    strSQL = "insert into 生产线状态表 (ProductionLineId,State,OperationDate,Operator) values('" + dgvSCXJM.Rows[j].Cells[0].Value.ToString().Trim() + "','开启','" + DateTime.Now + "','" + DLJM.identityClass.Name + "')";
                    order = new SqlCommand(strSQL, sqlConnection);
                    int count1 = order.ExecuteNonQuery();
                    SCXKQJM s = new SCXKQJM();
                    s.ShowDialog();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select ProductionLineId AS '生产线编号',ProductionLineName AS '生产线名称', ProductionWorkshop AS '生产车间',ProductId as '产品编号',ProductName as '产品名称',Time AS '时间', State AS '状态',Memo AS '备注' from 生产线表 ";
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
            dgvSCXJM.DataSource = dt.DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RKJM S = new RKJM();
                S.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SCXBJJM v = new SCXBJJM();
            v.ShowDialog();
        }
    }
}
