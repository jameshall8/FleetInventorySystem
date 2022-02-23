using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FleetInventorySystem
{
    public partial class Form1 : Form
    {
        static UC_HomeDashboard home;
        static UC_NewUser newUserUC;
        static UC_EditItem editItemUC;
        static UC_AddItem addItemUC;
        static UC_AssignStock assignStockUC;
        static UC_Fleet fleetUC;
        static UC_OfficeStock officeStockUC;
        static UC_Reorder reorderUC;
        static UserControl[] array;

        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H5ACLIO\SQLEXPRESS;Initial Catalog=FleetInventory;Integrated Security=True");

        static String role;

        public static UserControl[] Array { get => array; set => array = value; }
        public static UC_HomeDashboard Home { get => home; set => home = value; }
        public static UC_NewUser NewUserUC { get => newUserUC; set => newUserUC = value; }
        public static UC_EditItem EditItemUC { get => editItemUC; set => editItemUC = value; }
        public static UC_AddItem AddItemUC { get => addItemUC; set => addItemUC = value; }
        public static UC_AssignStock AssignStockUC { get => assignStockUC; set => assignStockUC = value; }
        public static UC_Fleet FleetUC { get => fleetUC; set => fleetUC = value; }
        public static UC_OfficeStock OfficeStockUC { get => officeStockUC; set => officeStockUC = value; }
        public static UC_Reorder ReorderUC { get => reorderUC; set => reorderUC = value; }
        public static string Role { get => role; set => role = value; }
        public static SqlConnection Conn { get => conn; set => conn = value; }

        public Form1()
        {
            InitializeComponent();

            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_Login1_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
        public static void showPage(UserControl t)
        {
            t.Show();
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            NewUserUC = new UC_NewUser();
            Controls.Add(NewUserUC);
            role = "Manager";

            Home = new UC_HomeDashboard();
            Controls.Add(Home);

            EditItemUC = new UC_EditItem();
            Controls.Add(EditItemUC);


            AddItemUC = new UC_AddItem();
            Controls.Add(AddItemUC);


            AssignStockUC = new UC_AssignStock();
            Controls.Add(AssignStockUC);


            FleetUC = new UC_Fleet();
            Controls.Add(FleetUC);


            OfficeStockUC = new UC_OfficeStock();
            Controls.Add(OfficeStockUC);


            ReorderUC = new UC_Reorder();
            Controls.Add(ReorderUC);

            UserControl[] UCs = { NewUserUC, Home, editItemUC, AddItemUC, AssignStockUC, FleetUC, OfficeStockUC, ReorderUC };
            Array = UCs;

            CloseUserControls(Array);

            String username, user_password;

            username = usernameTxt.Text;
            user_password = passwordTxt.Text;

            try
            {
                String query = "SELECT * FROM Login_new WHERE username = '" + username + "' AND password = '" + user_password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = usernameTxt.Text;
                    user_password = passwordTxt.Text;

                    pnlLogin.Hide();
                    navPanel.Show();
                    Home.Show();

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

        public static void CloseUserControls(UserControl[] array)
        {
            foreach (UserControl UC in array)
            {
                UC.Hide();
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            


        }



        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CloseUserControls(Array);
            NewUserUC.Show();

        }

        private void btnOfficeStock_Click(object sender, EventArgs e)
        {
            {
               

                CloseUserControls(Array);
                OfficeStockUC.Show();

            }
        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            CloseUserControls(Array);
            FleetUC.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CloseUserControls(Array);
            Home.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            {
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void lblNav_Click(object sender, EventArgs e)
        {
            CloseUserControls(Array);
            Home.Show();
        }

        private void uC_HomeDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
