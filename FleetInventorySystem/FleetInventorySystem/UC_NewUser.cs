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
using System.ComponentModel.DataAnnotations;

namespace FleetInventorySystem
{
    public partial class UC_NewUser : UserControl
    {
        private string username, password, passConfirm, role, fname, lname, email;
        private SqlCommand sqlComm;
        String[] roles = new String[] { "Admin", "Engineer", "AllocationStaff"};

        public UC_NewUser()
        {
            InitializeComponent();
            fillCombo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillCombo()
        {
            foreach (String role in roles)
            {
                comboRole.Items.Add(role);
            }
            comboRole.SelectedIndex = 0;
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (notNull())
                {
                    getVariables();
                    if (checkPassword(password, passConfirm))
                    {
                        if (checkEmail(email))
                        {
                            addToDB();
                            MessageBox.Show("User Successfully created");
                            clearBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Email Address is not valid");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                    }
                }
                else
                {
                    MessageBox.Show("You must fill in all text boxes");

                }


            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }

        }

        private void getVariables()
        {
            try
            {
                password = txtPass.Text;
                role = comboRole.SelectedItem.ToString();
                fname = txtFname.Text;
                lname = txtLname.Text;
                email = txtEmail.Text;
                passConfirm = txtPassConfirm.Text;
                username = createUsername();
            }
            catch
            {
                MessageBox.Show("Please check your inputs and try again");
            }

            
        }

        private void addToDB()
        {
            Form1.Conn.Open();

            try
            {
                    sqlComm = new SqlCommand("INSERT INTO Login_new (username, password, role, first_name, last_name, email_address) VALUES (@username, @password, @role, @firstname, @lastname, @email)", Form1.Conn);

                    sqlComm.Parameters.AddWithValue("@username", username);
                    sqlComm.Parameters.AddWithValue("@password", password);
                    sqlComm.Parameters.AddWithValue("@role", role);
                    sqlComm.Parameters.AddWithValue("@firstName", fname);
                    sqlComm.Parameters.AddWithValue("@lastName", lname);
                    sqlComm.Parameters.AddWithValue("@email", email);


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

        private String createUsername()
        {
            string str = fname.Substring(0, 3);
            String uname = str;
            str = lname.Substring(0, 3);
            uname = uname + str;

            Random rand = new Random();
            int randNumber = rand.Next(1, 5000);
            uname = uname + randNumber.ToString();
            return uname;
        }

        private bool checkPassword(String password, String passwordConfirm)
        {
            return password == passConfirm;
        }

        private bool checkEmail(String email)
        {
            return new EmailAddressAttribute().IsValid(email);

        }

        private bool notNull()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textbox = c as TextBox;
                    if (textbox.Text == string.Empty)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        private void clearBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textbox = c as TextBox;
                    textbox.Text = "";

                }
            }
            comboRole.SelectedIndex = -1;
            
        }

    }
}
