using PurchaseWinform.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PurchaseWinform.DB
{
    class PurchaseManager
    {
        #region 資料庫連動下拉式選單

        public static void ProductList(ref ComboBox Productlist)
        {

            using (var context = new DBModel.ContextModel())
            {
                var Query = from Product in context.ProductLists
                            select new
                            {
                                ProductInfo = Product.Product_ID + "," + Product.Price,
                                Name = Product.Product_Name
                            };

                Productlist.DataSource = Query.ToList();
                Productlist.DisplayMember = "Name";
                Productlist.ValueMember = "ProductInfo";
            }
        }

        #endregion

        #region MyRegion

        public static string checkPurchase_ID(string Purchase_ID)
        {
            string label;

            if (Purchase_ID == null || Purchase_ID.Length == 0)
                label = "單據編號不能為空";
            else if (Purchase_ID.Length != 8 || !Regex.IsMatch(Purchase_ID, @"^ASN[-]{1}[0-9]{4}$"))
                label = "單據編號格式不正確";
            else if (PurchaseCheck(Purchase_ID) != null)
                label = "進貨單號重覆，請再確認後修改";
            else
                label = string.Empty;
            return label;
        }

        #endregion

        #region Purchase_IDCheck

        public static PurchaseModels PurchaseCheck(string Purchase_ID)
        {
            string queryString = $@"SELECT Purchase_ID 
                                    FROM [PurchaseDetail]
                                    WHERE Purchase_ID = @Purchase_ID AND Isdelete = 'false'
                                    ";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Purchase_ID", Purchase_ID)
            };

            PurchaseModels model = null;
            var dt = DBbase.GetDataTable(queryString, parameters);

            if (dt.Rows.Count != 0)
            {
                model = new PurchaseModels();
                model.Purchase_ID = (string)dt.Rows[0]["Purchase_ID"];
            }
            return model;
        }
        #endregion

        #region 刪除
        public static DataTable Delete(string Purchase_ID)
        {
            string queryString =
                $@" 
                    UPDATE [PurchaseDetail]
                    SET Isdelete = @Isdelete
                    WHERE Purchase_ID = @Purchase_ID
                  ";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Purchase_ID", Purchase_ID),
                new SqlParameter("@Isdelete", true)
            };

            var dt = DBbase.GetDataTable(queryString, parameters);
            return dt;
        }
        #endregion
    }
}






