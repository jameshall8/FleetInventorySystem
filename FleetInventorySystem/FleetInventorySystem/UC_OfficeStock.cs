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


        public static string EditChoice { get => editChoice; set => editChoice = value; }

        
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
            if (Form1.Role != "Admin")
            {
                MessageBox.Show("You do not have access to this page");
            }
            else
            {
                if (comboSelectEdit.SelectedIndex != -1)
                {

                    editChoice = comboSelectEdit.Text;
                    setUpEditForm();
                }
                else
                {
                    MessageBox.Show("You need to select an item from the dropdown");
                }
                
                
            }


        }

        private void setUpEditForm()
        {
            Form1.EditItemUC.BarcodeNumber = Convert.ToInt32(editChoice);

            Form1.EditItemUC.refresh();

            Form1.CloseUserControls(Form1.Array);
            Form1.EditItemUC.Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (Form1.Role == "Admin")
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
            if (Form1.Role == "Admin")
            {

                Form1.CloseUserControls(Form1.Array);
                Form1.showPage(Form1.AssignStockUC);
                Form1.AssignStockUC.refreshStock();
            }
            else
            {
                MessageBox.Show("You do not have access to this page");
            }

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {

            refreshTable();
        }

        private void comboSelectEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void refreshTable()
        {
            try
            {
                comboSelectEdit.SelectedItem = null;

                Form1.Conn.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM OfficeParts", Form1.Conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgvOfficeStock.DataSource = dtbl;
                dgvOfficeStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Form1.Conn.Close();
                comboSelectEdit.Items.Clear();
                fillEditCombo();



            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }
    

        void fillEditCombo()
        {
            Form1.Conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT barcodeNumber FROM OfficeParts", Form1.Conn);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboSelectEdit.Items.Add(Sdr.GetValue(i));
                }
            }
            Sdr.Close();
            Form1.Conn.Close();



        }
    }
    }


