using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PurchaseWinform.loginManager.LoginHelper;

namespace PurchaseWinform
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private DataTable _dtProducts;
        private void Product_Load(object sender, EventArgs e)
        {
            this.UserInfo.Text = "您好! 使用者:" + LoginInfo.UserNM;

            this.GetDataTable();
            this.dataGridView1.DataSource = this._dtProducts;
        }

        private void GetDataTable()
        {
            string ConnStr = System.Configuration.ConfigurationManager.ConnectionStrings["ContextModel"].ConnectionString;
            string commandStr = @"SELECT Product_ID,Product_Name,Product_Class,Price FROM ProductList
                                  ORDER BY Product_ID";


            DataSet dataSet = new DataSet();
            using (SqlDataAdapter adp = new SqlDataAdapter())
            {
                adp.SelectCommand = new SqlCommand(commandStr, new SqlConnection(ConnStr));
                adp.Fill(dataSet);

                this._dtProducts = dataSet.Tables[0];
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseList purchaseList = new PurchaseList();
            purchaseList.Show();

            this.Hide();
        }
    }
}
