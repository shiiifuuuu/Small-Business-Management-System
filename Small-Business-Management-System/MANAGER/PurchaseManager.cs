﻿using Small_Business_Management_System.MODEL;
using Small_Business_Management_System.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.MANAGER
{
    class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();
        internal List<Supplier> SupplierComboLoad()
        {
            return _purchaseRepository.SupplierComboLoad();
        }

        internal List<Category> CategoryComboLoad()
        {
            return _purchaseRepository.CategoryComboLoad();
        }

        internal List<Product> ProductComboLoad()
        {
            return _purchaseRepository.ProductComboLoad();
        }

        internal List<Product> SearchProducts(string category)
        {
            return _purchaseRepository.SearchProducts(category);
        }

        internal double GetPrevious(string columnName, Purchase purchase)
        {
            return _purchaseRepository.GetPrevious(columnName, purchase);
        }

        public int GetAvailableQuantity(string code)
        {
            return _purchaseRepository.GetAvailableQuantity(code);
        }

        public void CloseConnection()
        {
            _purchaseRepository.CloseConnection();
        }

        internal bool Add(Purchase purchase)
        {
            return _purchaseRepository.Add(purchase);
        }

        internal List<Purchase> GetRecords()
        {
            return _purchaseRepository.GetRecords();
        }
    }
}
