using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FleetInventorySystem
{
    public partial class UC_IndividualVan : UserControl
    {
        public UC_IndividualVan()
        {
            InitializeComponent();

            Form1.Conn.Open();


            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM OfficeParts", Form1.Conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvOfficeStock.DataSource = dtbl;
            dgvOfficeStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Form1.Conn.Close();

            
        }

        private void btnSelectAssign_Click(object sender, EventArgs e)
        {

        }
    }
}
