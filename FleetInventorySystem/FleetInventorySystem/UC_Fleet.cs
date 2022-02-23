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
    public partial class UC_Fleet : UserControl
    {
        public UC_Fleet()
        {
            InitializeComponent();

            Form1.Conn.Open();


            SqlDataAdapter VansTable = new SqlDataAdapter("SELECT * FROM VansTable", Form1.Conn);
            DataTable dbl = new DataTable();

            VansTable.Fill(dbl);

            dgvVans.DataSource = dbl;
            dgvVans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Form1.Conn.Close();
        }

        private void btnPopulateVans_Click(object sender, EventArgs e)
        {
            try
            {

                Form1.Conn.Open();


                SqlDataAdapter VansTable = new SqlDataAdapter("SELECT * FROM VansTable", Form1.Conn);
                DataTable dbl = new DataTable();

                VansTable.Fill(dbl);

                dgvVans.DataSource = dbl;
                dgvVans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Form1.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        }
    }

