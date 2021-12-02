using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseWinform.Models
{
    public class PurchaseModels
    {
        public string Purchase_ID { get; set; }
        public int Product_Quantity { get; set; }
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? ArriveTime { get; set; }
        public decimal Purchase_Price { get; set; }
    }
}
