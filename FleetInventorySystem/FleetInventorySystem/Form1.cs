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
        private static UC_HomeDashboard home;
        private static UC_NewUser newUserUC;
        private static UC_EditItem editItemUC;
        private static UC_AddItem addItemUC;
        private static UC_AssignStock assignStockUC;
        private static UC_Fleet fleetUC;
        private static UC_OfficeStock officeStockUC;
        private static UC_Reorder reorderUC;
        private static UserControl[] array;
        private static UC_IndividualVan vanUC;
        private static String fname;
        private static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H5ACLIO\SQLEXPRESS;Initial Catalog=FleetInventory;Integrated Security=True");

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
        public static UC_IndividualVan VanUC { get => vanUC; set => vanUC = value; }
        public static string Fname { get => fname; set => fname = value; }

        public Form1()
        {
            InitializeComponent();
            passwordTxt.PasswordChar = '*';
            setColours();
           

        }

        private void setColours()
        {
            Button[] buttons = new Button[] {btnHome, btnOfficeStock, btnFleet, btnCreateAccount, btnLogout, loginBtn };

            foreach (Button button in buttons)
            {
                button.BackColor = ColorTranslator.FromHtml("#818589");
                button.Font = new Font("Microsoft YaHei", 9, FontStyle.Bold);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#818589");
                button.FlatAppearance.BorderSize = 1;
               

            }

            BackColor = ColorTranslator.FromHtml("#B7BEA1");
            navPanel.BackColor = ColorTranslator.FromHtml("#A9A9A9");
        


        }

            private void setButtonColors()
            {
                foreach (UserControl UC in array)
            {
                foreach (var button in UC.Controls.OfType<Button>())
                {
                    button.BackColor = ColorTranslator.FromHtml("#818589");
                    button.Font = new Font("Microsoft YaHei", 9, FontStyle.Bold);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#818589");
                    button.FlatAppearance.BorderSize = 1;

                }
            }

                
           
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


            loadUserControls();

            UserControl[] UCs = { NewUserUC, Home, editItemUC, AddItemUC, AssignStockUC, FleetUC, OfficeStockUC, ReorderUC, vanUC };
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

                    foreach (DataRow row in dtable.Rows)
                    {
                        role = (string)row["role"];
                        Fname = (string)row["first_name"];
                    }

                    username = usernameTxt.Text;
                    user_password = passwordTxt.Text;
                    lblUserDetails.Text = Fname + " (" + role + ")";
                    pnlLogin.Hide();
                    setButtonColors();
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
                MessageBox.Show("Account issue, please contact admin");
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
            if (role == "Admin")
            {
                CloseUserControls(Array);
                NewUserUC.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to do this");
            }

        }

        private void btnOfficeStock_Click(object sender, EventArgs e)
        {
            {
                officeStockUC.refreshTable();
                CloseUserControls(Array);
                OfficeStockUC.Show();

            }
        }

        private void btnFleet_Click(object sender, EventArgs e)
        {
            CloseUserControls(Array);
            FleetUC.Show();
            Form1.fleetUC.refreshTable();
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CloseUserControls(Array);
            Home.Show();
            Home.RefreshValues();
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

        private void loadUserControls()
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

            vanUC = new UC_IndividualVan();
            Controls.Add(vanUC);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseUserControls(Array);
            home.Show();
        }
    }
}
