using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetInventorySystem
{
    class Part
    {
        private String name;

        private int barcode;
        private int maxStockLevel;
        private int currentStock;
        private int restockTime;
        private String SupplierEmail;

        public string Name { get => name; set => name = value; }
        public int Barcode { get => barcode; set => barcode = value; }
        public int MaxStockLevel { get => maxStockLevel; set => maxStockLevel = value; }
        public int CurrentStock { get => currentStock; set => currentStock = value; }
        public int RestockTime { get => restockTime; set => restockTime = value; }
        public string SupplierEmail1 { get => SupplierEmail; set => SupplierEmail = value; }
    }
}
