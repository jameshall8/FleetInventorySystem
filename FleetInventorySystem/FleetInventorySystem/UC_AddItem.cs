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
using System.Collections;

namespace FleetInventorySystem
{
    public partial class UC_AddItem : UserControl
    {
        private SqlCommand sqlComm;
        bool added;

        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            if (CheckIfNull() == true)
            {
                addItem();
                EmptyTextBoxes();
            }
            else
            {
                added = false;

                MessageBox.Show("You must fill in every section");
            }
            
        }

        private void addItem()
        {
            try
            {
                Part part = getNewValues();
                if (part != null)
                {
                    Form1.Conn.Open();
                    sqlComm = new SqlCommand("INSERT INTO OfficeParts (name, maxStock, currentStock, restockTime, supplierEmail, barcodeNumber) VALUES (@partName, @maxStock, @currentStock, @restockTime, @supplierEmail, @barcodeNumber)", Form1.Conn);

                    sqlComm.Parameters.AddWithValue("@partName", part.Name);
                    sqlComm.Parameters.AddWithValue("@maxStock", part.MaxStock);
                    sqlComm.Parameters.AddWithValue("@currentStock", part.CurrentStock);
                    sqlComm.Parameters.AddWithValue("@restockTime", part.RestockTime);
                    sqlComm.Parameters.AddWithValue("@supplierEmail", part.SupplierEmail);
                    sqlComm.Parameters.AddWithValue("@barcodeNumber", part.Barcode);


                    sqlComm.ExecuteNonQuery();
                    added = true;

                    Form1.Conn.Close();

                    if (added == true)
                    {
                        MessageBox.Show("Successfully added item");
                    }
                }
                else
                {
                    added = false;
                }
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                added = false;
            }
            finally
            {

            }
        }

        private Part getNewValues()
        {
            try
            {
                Part part = new Part();

                part.Name = txtName.Text;
                part.MaxStock = Convert.ToInt32(txtMax.Text);
                part.CurrentStock = Convert.ToInt32(txtCurrent.Text);
                part.RestockTime = Convert.ToInt32(txtReorder.Text);
                part.SupplierEmail = txtEmail.Text;
                part.Barcode = Convert.ToInt32(txtBarcode.Text);

                return part;
            }
            catch (Exception e)
            {
                MessageBox.Show("Please check your inputs are the correct value type");
                added = false;

                return null;
            }
        }

        private void EmptyTextBoxes()
        {
            txtName.Text = "";
            txtMax.Text = "";
            txtCurrent.Text = "";
            txtReorder.Text = "";
            txtEmail.Text = "";
            txtBarcode.Text = "";
        }

        private bool CheckIfNull()
        {
            ArrayList arlist = new ArrayList();
            arlist.Add(txtName);
            arlist.Add(txtName);
            arlist.Add(txtMax);
            arlist.Add(txtCurrent);
            arlist.Add(txtReorder);
            arlist.Add(txtEmail);
            arlist.Add(txtBarcode);

            foreach (TextBox txt in arlist)
            {
                if (txt.Text == "")
                {
                    return false;
                }
            
            }

            return true;


        }

    }
    
}
