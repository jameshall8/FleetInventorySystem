using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetInventorySystem
{
    public partial class UC_Reorder : UserControl
    {
        private int barcode;
        private String partname;
        private int currentStock, updatedCurrentStock, maxStock;
        public UC_Reorder()
        {
            InitializeComponent();
        }

        public int Barcode { get => barcode; set => barcode = value; }
        public string Partname { get => partname; set => partname = value; }
        public int MaxStock { get => maxStock; set => maxStock = value; }
        public int CurrentStock { get => currentStock; set => currentStock = value; }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            try
            {
                updateStock();
                txtAmount.Text = "";
                txtBranch.Text = "";
                txtManagerName.Text = "";

                MessageBox.Show("Form Sent Successfully");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            
        }
        public void refreshForm()
        {
            lblReorderName.Text = partname + "- Reorder Form";
            txtManagerName.Text = Form1.Fname;
        }

        public void updateStock()
        {
            currentStock = Form1.EditItemUC.getCurrentStock(barcode);

            updatedCurrentStock = currentStock + Convert.ToInt32(txtAmount.Text);

            Form1.EditItemUC.updatePercentageAndCurrent(updatedCurrentStock, maxStock, Barcode);
        }
    }
}
