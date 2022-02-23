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
    public partial class UC_OfficeStock : UserControl
    {
        static string editChoice = "";
        UserControl EditItemUC = null;

        public static string EditChoice { get => editChoice; set => editChoice = value; }

        public UC_OfficeStock(string lastName, string firstName)
        {

        }
        public UC_OfficeStock()
        {
            InitializeComponent();

            Form1.Conn.Open();


            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM OfficeParts", Form1.Conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dgvOfficeStock.DataSource = dtbl;
            dgvOfficeStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Form1.Conn.Close();

            fillEditCombo();
        }

        private  void btnSelectEdit_Click(object sender, EventArgs e)
        {
            if (Form1.Role != "Manager")
            {
                MessageBox.Show("You do not have access to this page");
            }
            else
            {
                if (comboSelectEdit != null)
                {
                    EditChoice = comboSelectEdit.Text;
                    
                    
                    Form1.CloseUserControls(Form1.Array);
                    Form1.EditItemUC.Show();
                }
                
            }


        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (Form1.Role == "Manager")
            {

                Form1.CloseUserControls(Form1.Array);
                Form1.showPage(Form1.AddItemUC);
            }
            else
            {
                MessageBox.Show("You do not have access to this page");
            }

        }

        private void btnAssignStockPage_Click(object sender, EventArgs e)
        {
            if (Form1.Role == "Manager")
            {

                Form1.CloseUserControls(Form1.Array);
                Form1.showPage(Form1.AssignStockUC);
            }
            else
            {
                MessageBox.Show("You do not have access to this page");
            }

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {

            try
            {
                    Form1.Conn.Open();

                    
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM OfficeParts", Form1.Conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgvOfficeStock.DataSource = dtbl;
                    dgvOfficeStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    Form1.Conn.Close();



            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void comboSelectEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void fillEditCombo()
        {
            Form1.Conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT name FROM OfficeParts", Form1.Conn);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboSelectEdit.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            Form1.Conn.Close();



        }
    }
    }

