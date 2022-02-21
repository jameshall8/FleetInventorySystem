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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void UC_Login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username, user_password;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H5ACLIO\SQLEXPRESS;Initial Catalog=FleetInventory;Integrated Security=True");

            username = usernameTxt.Text;
            user_password = passwordTxt.Text;

            try
            {
                String query = "SELECT * FROM Login_new WHERE username = '"+username + "' AND password = '" +user_password+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = usernameTxt.Text;
                    user_password = passwordTxt.Text;



                    
                }
                else
                {
                    MessageBox.Show("Invalid Details");
                }


            }
            catch
            {
                MessageBox.Show("Error");
            }
            

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
