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


        private String Registration = "";

        String partname;
        int maxStock;
        int currentStock;
        int restockTime;
        String supplierEmail;
        int barcode;
        private SqlCommand sqlComm;
        private bool added;

        public UC_IndividualVan()
        {
            InitializeComponent();


            

            
        }

        public string registration { get => Registration; set => Registration = value; }

        public void refreshTable()
        {

            try
            {
                comboSelectMove.SelectedIndex = -1;

                lblVanName.Text = registration;
                SqlDataAdapter VansTable = new SqlDataAdapter("SELECT * FROM VanParts WHERE registration=@registration", Form1.Conn);
                DataTable dbl = new DataTable();

                VansTable.SelectCommand.Parameters.Add("@registration", SqlDbType.VarChar).Value = Registration;
                VansTable.Fill(dbl);

                if (dbl != null)
                {
                    if (dbl.Rows.Count > 0)
                    {
                        dgvIndividual.DataSource = dbl;
                        dgvIndividual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        comboSelectMove.Items.Clear();
                        fillEditCombo();
                        lblVanName.Text = "Van Registration - " + Registration;
                    }
                    else
                    {
                        MessageBox.Show("This van has no stock attached, please assign some from office stock");
                        Form1.CloseUserControls(Form1.Array);
                        Form1.FleetUC.Show();
                    }
                }

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
            finally
            {
                Form1.Conn.Close();
            }

        }

        public void getValuesToVariables()
        {
            String stmt = "SELECT barcode, maxStock, currentStock, name, restockTime, supplierEmail FROM vanParts WHERE registration ='" + Registration + "'";
            SqlDataAdapter sqlDa = new SqlDataAdapter(stmt, Form1.Conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                barcode = (int)row["barcode"];
                partname = (string)row["name"];
                maxStock = (int)(row["maxStock"]);
                currentStock = (int)row["currentStock"];
                restockTime = (int)row["restockTime"];
                supplierEmail = (string)row["supplierEmail"];


            }
        }

        private void addToOffice()
        {

            try
            {
                Form1.Conn.Open();

                sqlComm = new SqlCommand("INSERT INTO OfficeParts (name, maxStock, currentStock, restockTime, supplierEmail, barcodeNumber) VALUES (@partName, @maxStock, @currentStock, @restockTime, @supplierEmail, @barcodeNumber)", Form1.Conn);

                sqlComm.Parameters.AddWithValue("@partName", partname);
                sqlComm.Parameters.AddWithValue("@maxStock", maxStock);
                sqlComm.Parameters.AddWithValue("@currentStock", currentStock);
                sqlComm.Parameters.AddWithValue("@restockTime", restockTime);
                sqlComm.Parameters.AddWithValue("@supplierEmail", supplierEmail);
                sqlComm.Parameters.AddWithValue("@barcodeNumber", barcode);


                sqlComm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                Form1.Conn.Close();

            }





        }


        private void deleteFromVan()
        {
                try
            {
                Form1.Conn.Open();

                SqlCommand sql = new SqlCommand("DELETE FROM VanParts WHERE barcode=@barcode", Form1.Conn);



                sql.Parameters.AddWithValue("@barcode", barcode);
                sql.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                Form1.Conn.Close();

            }

        }

        private void btnSelectAssign_Click(object sender, EventArgs e)
        {
            try
            {
                barcode = Convert.ToInt32(comboSelectMove.Text);
                getValuesToVariables();
                addToOffice();
                deleteFromVan();
                refreshTable();
                MessageBox.Show("Item successfully moved to the office");

            }
            catch (Exception p)
            {
                MessageBox.Show("You did not choose an item to move");
            }


        }

        



        private void dgvOfficeStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_IndividualVan_Load(object sender, EventArgs e)
        {

        }

        void fillEditCombo()
        {
            Form1.Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT barcode FROM VanParts WHERE registration=@registration", Form1.Conn);

            cmd.Parameters.Add("@registration", SqlDbType.VarChar).Value = Registration;

            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboSelectMove.Items.Add(Sdr.GetValue(i));
                }
            }
            Sdr.Close();
            Form1.Conn.Close();



        }
    }
}
