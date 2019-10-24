using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.MODEL
{
    public class Purchase
    {
        public int Id { set; get; }
        public DateTime PurchaseDate { set; get; }
        public string InvoiceNo { set; get; }
        public string Supplier { set; get; }
        public string Category { set; get; }
        public string Product { set; get; }
        public string ProductCode { set; get; }
        public Int64 AvailableQuantity { set; get; }
        public string ManufactureDate { set; get; }
        public string ExpireDate { set; get; }
        public Int64 Quantity { set; get; }
        public double UnitPrice { set; get; }
        public double TotalPrice { set; get; }
        public double PreviousUnitPrice { set; get; }
        public double PreviousMRP { set; get; }
        public double MRP { set; get; }
        public string Remarks { set; get; }
    }
}
