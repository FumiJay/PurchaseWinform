using PurchaseWinform.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PurchaseWinform.Models;
using System.Linq;
using System.ComponentModel;

namespace PurchaseWinform
{
    public partial class Purchase_Product_Insert : Form
    {
        
        static int TotalPrice = 0;
        private DataTable _dtProduct;
        static BindingList<PurchaseModels> PurchaseTemp = new BindingList<PurchaseModels>();

        public Purchase_Product_Insert()
        {
            InitializeComponent();
        }

        private void Purchase_Product_Insert_Load(object sender, EventArgs e)
        {
            PurchaseDetail detail = new PurchaseDetail();

            this.GetDataTable();

            PurchaseManager.ProductList(ref ProducrSelect);
            this.dataGridView1.DataSource = this._dtProduct;
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

                this._dtProduct = dataSet.Tables[0];
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var Qty = this.ProductQTY.Text;
            var Price = this.ProducrSelect.Text;

            int Number;

            if (this.HasValue())
            {
                PurchaseModels TempPurchase = new PurchaseModels();
                string[] product = this.ProducrSelect.SelectedValue.ToString().Split(',');
                TotalPrice = Convert.ToInt32(product[1]) * Convert.ToInt32(Qty);

                TempPurchase.Product_ID = product[0];
                TempPurchase.Product_Name = Price;
                TempPurchase.Price = Convert.ToDecimal(product[1]);
                TempPurchase.Product_Quantity = Convert.ToInt32(Qty);
                TempPurchase.Purchase_Price = TotalPrice;

                PurchaseTemp.Add(TempPurchase);
            }

            PurchaseDetail._DataMain = PurchaseTemp;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProducrSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.HasValue())
            {
                var Qty = this.ProductQTY.Text;
                var Product = this.ProducrSelect.SelectedValue;
                this.ErrMess.Text = string.Empty;
                string[] product = Product.ToString().Split(',');
                TotalPrice = Convert.ToInt32(product[1]) * Convert.ToInt32(Qty);
                this.Price_1.Text = $"總金額為:{TotalPrice}元";
            }
        }

        private void ProductQTY_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.HasValue())
            {
                var Qty = this.ProductQTY.Text;
                var Product = this.ProducrSelect.SelectedValue;
                this.ErrMess.Text = string.Empty;
                string[] product = Product.ToString().Split(',');
                TotalPrice = Convert.ToInt32(product[1]) * Convert.ToInt32(Qty);
                this.Price_1.Text = $"總金額為:{TotalPrice}元";
            }
        }

        private bool HasValue()
        {
            var Qty = this.ProductQTY.Text;

            int temp;

            if (Qty == null || !int.TryParse(Qty, out temp))
            {
                this.ErrMess.Text = "進貨數量欄位不能為空或不是數字";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
