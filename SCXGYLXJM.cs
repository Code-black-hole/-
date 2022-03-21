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
    public partial class SCXGYLXJM : Form
    {
       
        
        SqlConnection sqlConnection;
        DataTable dt;
        public SCXGYLXJM()
        {
            InitializeComponent();
            string strSQL2 = SCXJM.flagClass.strSQL;
            // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            SqlCommand order = new SqlCommand();
            //参数一：SQL语句  ，参数二：连接对象
            //SqlDataAdapter对象用于获取到表格并填充到数据集
            SqlDataAdapter da = new SqlDataAdapter(strSQL2, sqlConnection);
            //创建数据集对象
            DataSet ds = new DataSet();
            //用SqlDataAdapter对象的Fill方法填充数据集
            da.Fill(ds, "工艺流程表");//参数1：DataSet对象 参数2：表名（不需要和查询的表名一致）
                              //绑定数据到DataGridView
            dt = ds.Tables["工艺流程表"];
            dgvSCXGYLXJM.DataSource = dt.DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SCXGYLXBJJM L = new SCXGYLXBJJM();
            L.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            if (dt2csv(dt, path, "" + SCXJM.ProductionLineName + "", "产品编号,工序编号,工序名称,工作单元,加工时间,加工人员,工序顺序序号"))
            {
                MessageBox.Show("导出成功,文件位置:" + path);
            }
            else
            {
                MessageBox.Show("导出失败");
            }
        }
        /// <summary>
        /// Excel导出
        /// </summary>
        ///<param name="dt">DataTable</param>
        /// <param name="strFilePath">物理路径</param>
        /// <param name="tableheader">表头</param>
        /// <param name="columname">字段标题,逗号分隔</param>
        /// <returns></returns>
        public static bool dt2csv(DataTable dt, string strFilePath, string tableheader, string columname)
        {
            try
            {
                string strBufferLine = "";
                StreamWriter strmWriterObj = new StreamWriter(strFilePath, false, System.Text.Encoding.UTF8);
                strmWriterObj.WriteLine(tableheader);
                strmWriterObj.WriteLine(columname);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    strBufferLine = "";
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j > 0)
                            strBufferLine += ",";
                        strBufferLine += dt.Rows[i][j].ToString();
                    }
                    strmWriterObj.WriteLine(strBufferLine);
                }
                strmWriterObj.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SCXGYLXJM_Load(object sender, EventArgs e)
        {

        }
    }
}
