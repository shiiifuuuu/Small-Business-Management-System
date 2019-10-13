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
        internal object SupplierComboLoad()
        {
            return _purchaseRepository.SupplierComboLoad();
        }
    }
}
