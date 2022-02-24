using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetInventorySystem
{
    class Part
    {
        private String partname;

        private int barcode;
        private int maxStock;
        private int currentStock;
        private int restockTime;
        private String supplierEmail;

        public string Name { get => partname; set => partname = value; }
        public int Barcode { get => barcode; set => barcode = value; }
        public int MaxStock { get => maxStock; set => maxStock = value; }
        public int CurrentStock { get => currentStock; set => currentStock = value; }
        public int RestockTime { get => restockTime; set => restockTime = value; }
        public string SupplierEmail { get => supplierEmail; set => supplierEmail = value; }



    }

}
