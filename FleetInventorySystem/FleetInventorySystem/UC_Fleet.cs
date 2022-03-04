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
            refreshTable();
            fillEditCombo();
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

        void fillEditCombo()
        {
            Form1.Conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Registration FROM VansTable", Form1.Conn);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboSelectVan.Items.Add(Sdr.GetValue(i));
                }
            }
            Sdr.Close();
            Form1.Conn.Close();



        }

        public void refreshTable()
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
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void comboSelectVan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

