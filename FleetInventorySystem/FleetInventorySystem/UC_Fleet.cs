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

        static string viewChoice = "";

        public static string AssignChoice { get => viewChoice; set => viewChoice = value; }

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
                comboSelectVan.SelectedIndex = -1;
                


            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void comboSelectVan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectVan_Click(object sender, EventArgs e)
        {
            if (Form1.Role != "Manager")
            {
                MessageBox.Show("You do not have access to this page");
            }
            else
            {
                if (comboSelectVan.SelectedIndex != -1)
                {

                    viewChoice = comboSelectVan.Text;
                    SetUpVanPage();
                    Form1.VanUC.refreshTable();
                }
                else
                {
                    MessageBox.Show("You need to select an item from the dropdown");
                }


            }


        }

        private void SetUpVanPage()
        {
            Form1.CloseUserControls(Form1.Array);
            Form1.VanUC.Show();
            Form1.VanUC.registration = comboSelectVan.Text;

        }

        private void UC_Fleet_Load(object sender, EventArgs e)
        {

        }
    }
    }

