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
        public UC_Reorder()
        {
            InitializeComponent();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtBranch.Text = "";
            txtManagerName.Text = "";

            MessageBox.Show("Form Sent Successfully");
        }
    }
}
