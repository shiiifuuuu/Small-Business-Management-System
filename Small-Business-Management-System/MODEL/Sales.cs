﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.MODEL
{
    public class Sales
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public string Code { get; set; }
        public string Customer { get; set; }
        public string SelasDate { get; set; }
        public double LoyalityPoint { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public int AvabileQuantity { get; set; }
        public int Quantity { get; set; }
        public double MRP { get; set; }
        public double TotalMRP { get; set; }
        public double GrandTotal { get; set; }
        public double Discount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayableAmount { get; set; }
    }
}
