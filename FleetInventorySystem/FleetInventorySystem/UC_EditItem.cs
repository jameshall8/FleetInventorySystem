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
    public partial class UC_EditItem : UserControl
    {
        String supplierEmail, partname;
        int maxStock, currentStock, restockTime, barcodeNumber;

        List<String> arrayRows = new List<String>();
        private SqlCommand sqlComm;

        public string Partname { get => partname; set => partname = value; }
        public int BarcodeNumber { get => barcodeNumber; set => barcodeNumber = value; }

        public UC_EditItem()
        {
            InitializeComponent();

        }

        public void refresh()
        {
            lblProductName.Text = partname;
            getValuesToVariables();

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            updatePart();
        }

        private void getValuesToVariables()
        {
            String stmt = "SELECT name, maxStock, currentStock, restockTime, supplierEmail FROM OfficeParts WHERE barcodeNumber = '" + barcodeNumber + "'";
            SqlDataAdapter sqlDa = new SqlDataAdapter(stmt, Form1.Conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                partname = (string)row["name"];
                maxStock = (int)(row["maxStock"]); 
                currentStock = (int)row["currentStock"];
                restockTime = (int)row["restockTime"];
                supplierEmail = (string)row["supplierEmail"];

                txtBarcode.Text = BarcodeNumber.ToString();
                txtCurrent.Text = row["currentStock"].ToString();
                txtEmail.Text = row["supplierEmail"].ToString();
                txtMax.Text = row["maxStock"].ToString(); 
                txtReorder.Text = row["restockTime"].ToString(); 
                txtName.Text = (string)row["name"]; 


            }
        }

        private void updatePart()
        {
            getNewValues();
            Form1.Conn.Open();
            sqlComm = new SqlCommand("UPDATE OfficeParts SET name=@partName, maxStock=@maxStock, currentStock=@currentStock, restockTime=@restockTime, supplierEmail=@supplierEmail WHERE barcodeNumber=@barcodeNumber", Form1.Conn);

            sqlComm.Parameters.AddWithValue("@partName", partname);
            sqlComm.Parameters.AddWithValue("@maxStock", maxStock);
            sqlComm.Parameters.AddWithValue("@currentStock", currentStock);
            sqlComm.Parameters.AddWithValue("@restockTime", restockTime);
            sqlComm.Parameters.AddWithValue("@supplierEmail", supplierEmail);
            sqlComm.Parameters.AddWithValue("@barcodeNumber", barcodeNumber);


            sqlComm.ExecuteNonQuery();

            Form1.Conn.Close();

        }

        private void getNewValues()
        {
            partname = txtName.Text;
            maxStock = Convert.ToInt32(txtMax.Text);
            currentStock = Convert.ToInt32(txtCurrent.Text);
            restockTime = Convert.ToInt32(txtReorder.Text);
            supplierEmail = txtEmail.Text;
            barcodeNumber = Convert.ToInt32(txtBarcode.Text);
        }








        private void UC_EditItem_Load(object sender, EventArgs e)
        {
            

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
