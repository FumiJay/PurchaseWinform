using PurchaseWinform.DB;
using PurchaseWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static PurchaseWinform.loginManager.LoginHelper;

namespace PurchaseWinform
{
    public partial class PurchaseDetail : Form
    {
        public static PurchaseDetail purchaseDetail = new PurchaseDetail();
        public static BindingList<PurchaseModels> _DataMain = new BindingList<PurchaseModels>();
        public string ID;

        static int TotalPrice = 0;

        public PurchaseDetail()
        {
            InitializeComponent();

            purchaseDetail = this;
        }

        public void dtload()
        {
            var Query = from item in _DataMain
                        group item by new { item.Product_ID, item.Product_Name, item.Price } into Purchase_Class
                        select new
                        {
                            Product_ID = Purchase_Class.Key.Product_ID,
                            Product_Name = Purchase_Class.Key.Product_Name,
                            Price = Purchase_Class.Key.Price,
                            Product_Quantity = Purchase_Class.Sum(X => X.Product_Quantity)
                        };

            this.dataGridView1.DataSource = Query.ToList();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Purchase_Product_Insert PageInsert = new Purchase_Product_Insert();
            PageInsert.ShowDialog();
            this.dtload();
        }

        public void PurchaseDetail_Load(object sender, EventArgs e)
        {
            this.createInfo.Text = "建立者 : " + LoginInfo.UserNM.ToString() + " 建立時間" + $" {DateTime.Now}";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            _DataMain.Clear();
            this.dataGridView1.DataSource = _DataMain;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var Query = from item in _DataMain
                        group item by new { item.Purchase_ID, item.ArriveTime, item.Product_ID, item.Product_Name } into Purchase_Class
                        select new
                        {
                            Purchase_ID = this.txtPurchaseID.Text,
                            Product_ID = Purchase_Class.Key.Product_ID,
                            Product_Name = Purchase_Class.Key.Product_Name,
                            Price = Purchase_Class.Sum(X => X.Price * X.Product_Quantity),
                            ArriveTime = this.dateTimePicker1.Value,
                            Product_Quantity = Purchase_Class.Sum(X => X.Product_Quantity),
                            Purchase_Class = Purchase_Class.Key.Product_ID.Count()
                        };

            using (var context = new DBModel.ContextModel())
            {
                foreach (var item in Query)
                {
                    var NewOder = new DBModel.PurchaseDetail()
                    {
                        Purchase_ID = item.Purchase_ID,
                        ArriveTime = (DateTime)item.ArriveTime,
                        Product_ID = item.Product_ID,
                        Product_Quantity = item.Product_Quantity,
                        Purchase_Class = item.Purchase_Class,
                        Isdelete = false
                    };

                    context.PurchaseDetails.Add(NewOder);
                }
                context.SaveChanges();
                _DataMain.Clear();
            }
            this.Close();
        }

        private bool HasValue()
        {
            var Qty = this.txtPurchaseID.Text;
            if (Qty == null )
            {
                this.ErrMess.Text = "進貨單編號不能為空";
                return false;
            }
            else
            {
                return true;
            }
        }

        public string[] IDandTime
        {
            get
            {
                string[] IDandtime = { ID, this.dateTimePicker1.Value.ToString() };
                return IDandtime;
            }
            set { }
        }

        private void txtPurchaseID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPurchaseID_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.HasValue())
            {
                string IupuPurchase_ID = this.txtPurchaseID.Text;
                this.ErrMess.Text = PurchaseManager.checkPurchase_ID(IupuPurchase_ID);
            }
        }
    }
}

