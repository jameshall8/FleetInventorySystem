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


        private String Partname = "";
        public UC_IndividualVan()
        {
            InitializeComponent();

            refreshTable();

            

            
        }

        public string Partname1 { get => Partname; set => Partname = value; }

        public void refreshTable()
        {
            try
            {
                Form1.Conn.Open();


                SqlDataAdapter VansTable = new SqlDataAdapter("SELECT * FROM VanParts WHERE registration=@registration", Form1.Conn);
                DataTable dbl = new DataTable();

                VansTable.SelectCommand.Parameters.Add("@registration", SqlDbType.VarChar).Value = Partname;

                VansTable.Fill(dbl);

                dgvIndividual.DataSource = dbl;
                dgvIndividual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Form1.Conn.Close();

                lblVanName.Text = "Van Registration - " + Partname;



            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void btnSelectAssign_Click(object sender, EventArgs e)
        {

        }

        private void dgvOfficeStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_IndividualVan_Load(object sender, EventArgs e)
        {

        }
    }
}
