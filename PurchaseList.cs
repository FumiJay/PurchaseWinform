using PurchaseWinform.DB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static PurchaseWinform.loginManager.LoginHelper;

namespace PurchaseWinform
{
    public partial class PurchaseList : Form
    {
        public static PurchaseList purchaseList = null;
        private DataTable _dtPurchase;

        public PurchaseList()
        {
            InitializeComponent();

            purchaseList = this;
        }

        public void PurchaseList_Load(object sender, EventArgs e)
        {
            this.UserInfo.Text = "您好! 使用者:" + LoginInfo.UserNM;

            this.GetDataTable();
        }

        public void GetDataTable()
        {
            string ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["ContextModel"].ConnectionString;
            string commandStr = @"SELECT 
                                  Purchase_ID
                                  ,COUNT([PurchaseDetail].Product_ID) AS Purchase_Class
                                  ,SUM(Product_Quantity) AS Purchase_Quantity, ArriveTime
                                  ,SUM([ProductList].Price * [PurchaseDetail].Product_Quantity) AS Purchase_Price
                                  ,ROW_NUMBER() OVER(ORDER BY [PurchaseDetail].Purchase_ID DESC) AS ROWNUM
                                  ,[PurchaseDetail].Isdelete
                                  from PurchaseDetail
                                  JOIN [ProductList] ON [PurchaseDetail].Product_ID = [ProductList].Product_ID
                                  WHERE [PurchaseDetail].Isdelete='False'
                                  GROUP BY Purchase_ID, ArriveTime,[PurchaseDetail].Isdelete
                                  ";


            DataSet dataSet = new DataSet();
            using (SqlDataAdapter adp = new SqlDataAdapter())
            {
                adp.SelectCommand = new SqlCommand(commandStr, new SqlConnection(ConnStr));
                adp.Fill(dataSet);

                this._dtPurchase = dataSet.Tables[0];
            }

            this.dataGridView1.DataSource = this._dtPurchase;
            this.dataGridView1.Columns["Isdelete"].Visible = false;
            this.dataGridView1.Columns["ROWNUM"].Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Product product = new Product();
            product.Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            CrystalReportViewer Report = new CrystalReportViewer();
            Report.Show();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            PurchaseDetail purchaseDetail = new PurchaseDetail();
            purchaseDetail.ShowDialog();

            this.GetDataTable();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var index = this.dataGridView1.CurrentRow.Index;
            DataRow dr = this._dtPurchase.Rows[index];
            PurchaseManager.Delete(dr["Purchase_ID"].ToString());

            this.GetDataTable();
        }
    }
}
