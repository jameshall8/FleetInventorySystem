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
    public partial class UC_AssignStock : UserControl
    {

        String partname;
        String registration;

        int maxStock;
        int currentStock;
        int restockTime;
        String supplierEmail;
        int barcode;
        private SqlCommand sqlComm;

        public UC_AssignStock()
        {
            InitializeComponent();
        }

        public void refreshStock()
        {

            fillPartCombo();
            fillVanCombo();

        }

        private void fillPartCombo()
        {
            Form1.Conn.Open();

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT barcodeNumber FROM OfficeParts", Form1.Conn);
                SqlDataReader Sdr = cmd.ExecuteReader();

                while (Sdr.Read())
                {
                    for (int i = 0; i < Sdr.FieldCount; i++)
                    {
                        comboProducts.Items.Add(Sdr.GetValue(i));
                    }
                }
                Sdr.Close();
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
        private void fillVanCombo()
        {
            Form1.Conn.Open();

            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Registration FROM VansTable", Form1.Conn);
                SqlDataReader Sdr = cmd.ExecuteReader();

                while (Sdr.Read())
                {
                    for (int i = 0; i < Sdr.FieldCount; i++)
                    {
                        comboVans.Items.Add(Sdr.GetValue(i));
                    }
                }
                Sdr.Close();
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

        private void fillVariables()
        {
            String stmt = "SELECT barcodeNumber, maxStock, currentStock, name, restockTime, supplierEmail FROM OfficeParts WHERE barcodeNumber='" + barcode + "'";
            SqlDataAdapter sqlDa = new SqlDataAdapter(stmt, Form1.Conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                barcode = (int)row["barcodeNumber"];
                partname = (string)row["name"];
                maxStock = (int)(row["maxStock"]);
                currentStock = (int)row["currentStock"];
                restockTime = (int)row["restockTime"];
                supplierEmail = (string)row["supplierEmail"];
            }

        }
        
        private void deleteFromOffice()
        {
            Form1.Conn.Open();

            try
            {
                SqlCommand sql = new SqlCommand("DELETE FROM OfficeParts WHERE barcodeNumber=@barcode", Form1.Conn);



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

        private void addToVan()
        {
            Form1.Conn.Open();

            try
            {
              
                    sqlComm = new SqlCommand("INSERT INTO VanParts (name, maxStock, currentStock, restockTime, supplierEmail, barcode, registration) VALUES (@partName, @maxStock, @currentStock, @restockTime, @supplierEmail, @barcodeNumber, @registration)", Form1.Conn);

                    sqlComm.Parameters.AddWithValue("@partName", partname);
                    sqlComm.Parameters.AddWithValue("@maxStock", maxStock);
                    sqlComm.Parameters.AddWithValue("@currentStock", currentStock);
                    sqlComm.Parameters.AddWithValue("@restockTime", restockTime);
                    sqlComm.Parameters.AddWithValue("@supplierEmail", supplierEmail);
                    sqlComm.Parameters.AddWithValue("@barcodeNumber", barcode);
                    sqlComm.Parameters.AddWithValue("@registration", registration);



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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignStock_Click(object sender, EventArgs e)
        {
            try
            {
                barcode = Convert.ToInt32(comboProducts.SelectedItem);
                registration = (String)comboVans.SelectedItem;
                fillVariables();
                addToVan();
                deleteFromOffice();
                refreshStock();
                MessageBox.Show("Item successfully moved");

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }
    }
}
