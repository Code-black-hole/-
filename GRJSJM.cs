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
    public partial class GRJSJM : Form
    {
       // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
        System.DateTime TimeNow = new DateTime();//起始点
        System.DateTime TimeNow2 = new DateTime();//暂停点
        TimeSpan TimeCount = new TimeSpan();//单个工时
        TimeSpan AllTimeCount = new TimeSpan();//总工时
        public int flag = 0;//  暂停/继续切换标记
        public int p = 0;
        public static string strSQL, strSQL2;
        SqlConnection sqlConnection;
        int count = 0;//该工人生产进度
        int end = 0;//2为最后一道工序的标志,1为第一道工序
      
        DataTable dt;
        DateTime dd = DateTime.Now;
        public static GLYQXClass glyqxClass { get; set; } = new GLYQXClass();
        
        public GRJSJM()
        {
            InitializeComponent();
            labName.Text = DLJM.identityClass.Name;
            labProductionLineId.Text = DLJM.workerProcessClass.ProductionLineId;
            labProcessId.Text = DLJM.workerProcessClass.ProcessName;
            this.btnStop.Enabled = false;
            this.btnOver.Enabled = false;
            labState.Text = "未开始";
            

            //string PublicAnial.str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "select * from 工艺流程表 where ProductId='" +DLJM.workerProcessClass.ProductId + "'";
            SqlCommand order = new SqlCommand();           
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlConnection);           
            //创建数据集对象
            DataSet ds = new DataSet();
            //用SqlDataAdapter对象的Fill方法填充数据集
            da.Fill(ds, "工艺流程表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                 //绑定数据到DataGridView
            dt = ds.Tables["工艺流程表"];
            int RowCount = dt.Rows.Count;
            string f = dt.Rows[0][2].ToString().Trim();
            for (int i=0;i<RowCount;i++)//判定当前工序是否为最后一道工序
            {
                if (dt.Rows[i][2].ToString().Trim() == DLJM.workerProcessClass.ProcessName && dt.Rows[i][6].ToString() == RowCount.ToString())
                {
                   
                    end = 2;
                }
                else if (dt.Rows[i][2].ToString().Trim() == DLJM.workerProcessClass.ProcessName && dt.Rows[i][6].ToString() == "1")
                {
                   
                    end = 1;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
                timer1.Enabled = true;
                timer1.Start();
                TimeNow = DateTime.Now;
                this.btnStart.Enabled = false;
                this.btnStop.Enabled = true;
                this.btnOver.Enabled = true;
                 p = 1;
            //string PublicAnial.PublicAnial.str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "insert into 工时表 (JobId,Name,Date,Operation,ProductionLineId,ProcessName,SpeedOfProgress)values('"+DLJM.identityClass.JobId+"','"+ DLJM.identityClass.Name + "','"+DateTime.Now+"','开始','"+ DLJM.workerProcessClass.ProductionLineId+"','"+ DLJM.workerProcessClass.ProcessName + "','"+count+"') ";
            SqlCommand order = new SqlCommand(strSQL, sqlConnection);
            int count1 = order.ExecuteNonQuery();
        }

        private void btnStop_Click(object sender, EventArgs e)//暂停和继续是同一个按钮相互切换
        {
            GLYQXJM s = new GLYQXJM();
            s.ShowDialog();
            if (glyqxClass.flag == 1)
            {
                if (flag == 0)//
                {
                    TimeNow2 = DateTime.Now;
                    timer1.Enabled = false;
                    btnStop.Text = "继续";
                    flag = 1;
                    labState.Text = "暂停";
                    //string PublicAnial.str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
                    sqlConnection = new SqlConnection(PublicAnial.str);
                    if (sqlConnection.State == System.Data.ConnectionState.Closed)
                        sqlConnection.Open();
                    strSQL = "insert into 工时表 (JobId,Name,Date,Operation,ProductionLineId,ProcessName,SpeedOfProgress)values('" + DLJM.identityClass.JobId + "','" + DLJM.identityClass.Name + "','" + DateTime.Now + "','暂停','" + DLJM.workerProcessClass.ProductionLineId + "','" + DLJM.workerProcessClass.ProcessName + "','" + count + "') ";
                    SqlCommand order = new SqlCommand(strSQL, sqlConnection);
                    int count1 = order.ExecuteNonQuery();
                }
                else
                {
                    timer1.Enabled = true;
                    TimeNow += DateTime.Now - TimeNow2;
                    btnStop.Text = "暂停";
                    flag = 0;
                    //string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
                    sqlConnection = new SqlConnection(PublicAnial.str);
                    if (sqlConnection.State == System.Data.ConnectionState.Closed)
                        sqlConnection.Open();
                    strSQL = "insert into 工时表 (JobId,Name,Date,Operation,ProductionLineId,ProcessName,SpeedOfProgress)values('" + DLJM.identityClass.JobId + "','" + DLJM.identityClass.Name + "','" + DateTime.Now + "','继续','" + DLJM.workerProcessClass.ProductionLineId + "','" + DLJM.workerProcessClass.ProcessName + "','" + count + "') ";
                    SqlCommand order = new SqlCommand(strSQL, sqlConnection);
                    int count1 = order.ExecuteNonQuery();
                }
                glyqxClass.flag = 0;
            }
            
        }

        private void btnOver_Click(object sender, EventArgs e)
        {
            flag = 0;
            btnStop.Text = "暂停";
            labTime.Text = "0";
            labState.Text = "未开始";
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            this.btnOver.Enabled = false;
            timer1.Enabled = false;
            p = 0;
            AllTimeCount += TimeCount;
            labTotaltime.Text = AllTimeCount.ToString();
            count++;
            if (end == 2)//如果当前为最后一道工序，结束后将自动在成品完成表中添加一个数据
            {

                sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL = "select * from 工艺流程表 where ProcessName='" + DLJM.workerProcessClass.ProcessName + "'";
                SqlCommand order = new SqlCommand();
                //参数一：SQL语句  ，参数二：连接对象
                //SqlDataAdapter对象用于获取到表格并填充到数据集
                SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlConnection);
                //创建数据集对象
                DataSet ds = new DataSet();
                //用SqlDataAdapter对象的Fill方法填充数据集
                da.Fill(ds, "工艺流程表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                     //绑定数据到DataGridView
                dt = ds.Tables["工艺流程表"];
                //根据工艺流程表的工艺顺序序号，改变当前成品的进度
                sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL = "update 成品完成表 set SpeedOfProgress='" + dt.Rows[0][6] + "',Date='"+DateTime.Now+ "', WareHousingStatus='未入库' where SerialId='" + count + "' ";
                order = new SqlCommand(strSQL, sqlConnection);
                int count1 = order.ExecuteNonQuery();
            }
            else if(end == 1)//如果当前为第一道工序
            {
               
                sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL = "insert into 成品完成表 (ProductId,ProductName,FormId,SpeedOfProgress,SerialId)values('" + DLJM.workerProcessClass.ProductId + "','" + DLJM.workerProcessClass.ProductName + "','" + DLJM.workerProcessClass.ProductName + "','1','" + count + "') ";
                SqlCommand order = new SqlCommand(strSQL, sqlConnection);
                int count1 = order.ExecuteNonQuery();
            }
            else
            {
                sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL = "select * from 工艺流程表 where ProcessName='"+ DLJM.workerProcessClass.ProcessName+"'";
                SqlCommand order = new SqlCommand();
                //参数一：SQL语句  ，参数二：连接对象
                //SqlDataAdapter对象用于获取到表格并填充到数据集
                SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlConnection);
                //创建数据集对象
                DataSet ds = new DataSet();
                //用SqlDataAdapter对象的Fill方法填充数据集
                da.Fill(ds, "工艺流程表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                                    //绑定数据到DataGridView
                dt = ds.Tables["工艺流程表"];
                //根据工艺流程表的工艺顺序序号，改变当前成品的进度
                sqlConnection = new SqlConnection(PublicAnial.str);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                strSQL = "update 成品完成表 set SpeedOfProgress='"+dt.Rows[0][6]+ "'where SerialId='"+count+ "'and  WareHousingStatus='未入库'";
                 order = new SqlCommand(strSQL, sqlConnection);
                int count1 = order.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WTSBJM s = new WTSBJM();
            s.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (p == 0)
            {
                labTime.Text = "0";
                labState.Text = "未开始";
            }
            else
            {
                if (flag == 0)
                {
                    TimeCount = DateTime.Now - TimeNow;
                }
                labTime.Text = TimeCount.ToString();
                labState.Text = "开始";
            }
        }
    }
}
