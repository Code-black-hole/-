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
    public partial class SCXKQJM : Form
    {
        public static string strSQL;
        SqlConnection sqlConnection;
        public SCXKQJM()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string str = "server=.;uid=sa;pwd=duyuhaoend111;database=中铁生产线人员信息;MultipleActiveResultSets=true";
            sqlConnection = new SqlConnection(PublicAnial.str);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            strSQL = "update 生产线表 set ProductionLineName ='"+txtProductionLineName.Text.ToString()+ "',ProductionWorkshop='"+txtProductionWorkshop.Text.ToString()+ "',ProductId='"+txtProductId.Text.ToString()+ "',ProductName='"+txtProductName.Text.ToString()+ "',Time='"+DateTime.Now+"',Memo='"+txtMemo.Text.ToString()+"'where ProductionLineId = '" + SCXJM.l + "'";
            SqlCommand order = new SqlCommand(strSQL, sqlConnection);
            int count = order.ExecuteNonQuery();
            this.Close();
        }
    }
}
