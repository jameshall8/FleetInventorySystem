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
        }

        private  void btnSelectEdit_Click(object sender, EventArgs e)
        {
            if (Form1.Role != "Manager")
            {
                MessageBox.Show("You do not have access to this page");
            }
            else
            {
                Form1.CloseUserControls(Form1.Array);
                Form1.showPage(Form1.EditItemUC);
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
    }
    }

