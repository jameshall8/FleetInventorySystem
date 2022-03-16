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
    public partial class UC_HomeDashboard : UserControl
    {
        int count50;
        int count20;
        int count5;

        public UC_HomeDashboard()
        {
            InitializeComponent();
            getBelow50();
            getBelow20();
            getBelow5();
            
            lblBelow50.Text = count50.ToString();
            lblBelow20.Text = count20.ToString();
            lblBelow5.Text = count5.ToString();
            
            
        }

        private void getBelow50()
        {
            Form1.Conn.Open();
            try
            {
                string stm = "SELECT COUNT(*) FROM OfficeParts WHERE stockPercentage<50";
                SqlCommand cmd = new SqlCommand(stm, Form1.Conn);
                count50 = Convert.ToInt32(cmd.ExecuteScalar());
                
            }
            catch
            {
                MessageBox.Show("Dashboard error");
            }
            finally
            {
                Form1.Conn.Close();
            }
        }

        private void getBelow20()
        {
            Form1.Conn.Open();
            try
            {
                string stm = "SELECT COUNT(*) FROM OfficeParts WHERE stockPercentage<20";
                SqlCommand cmd = new SqlCommand(stm, Form1.Conn);
                count20 = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {
                MessageBox.Show("Dashboard error");
            }
            finally
            {
                Form1.Conn.Close();
            }
        }
        private void getBelow5()
        {
            Form1.Conn.Open();
            try
            {
                string stm = "SELECT COUNT(*) FROM OfficeParts WHERE stockPercentage<5";
                SqlCommand cmd = new SqlCommand(stm, Form1.Conn);
                count5 = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {
                MessageBox.Show("Dashboard error");
            }
            finally
            {
                Form1.Conn.Close();
            }
        }



        private void lbl20_Click(object sender, EventArgs e)
        {

        }

        private void managementLbl_Click(object sender, EventArgs e)
        {

        }

        private void lbl50_Click(object sender, EventArgs e)
        {

        }
    }
}
