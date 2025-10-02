using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Hospital_Management
{
    //     logins:
    // user: staff.admin1         pass:12345678
    // user: staff.doctor2        pass:12345678
    // user: staff.nurse3         pass:12345678
    // user: staff.receptionist4 pass:12345678



    public partial class Login : Form
    {
        private string username = ""; //global variable, storing login username
        private string staffId = ""; //global variable, storing staff ID, used to find role of user
        private string staffRole = ""; //global variable, shared across all forms, used to identify role and manage restrictions
        string connection = ConnectionString.connectionString; //path to DB, stored in a class, used to connect to DB
        public Login()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            string hashedPassword = HashPassword(password); //hashes password using SHA-256

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) //checks user to fill all required fields
            {
                MessageBox.Show("Please enter both username and password."); 
                return;
            }
;

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "SELECT is_Admin FROM Accounts WHERE account_username = @username AND account_password = @password";
                string query2 = "SELECT staff_ID FROM Accounts WHERE account_username = @username AND account_password = @password";

                using (SQLiteCommand cmd2 = new SQLiteCommand(query2, conn)) //grab staff ID from the Accounts table
                {
                    cmd2.Parameters.AddWithValue("username", username);
                    cmd2.Parameters.AddWithValue("password", hashedPassword); //stores the hashed password in the parameter, matching with the one in the DB

                    object user = cmd2.ExecuteScalar();
                    GlobalUserId.userId = Convert.ToString(user);

                    if (user != null)
                    {
                        GlobalUserId.userId = user.ToString(); //calls global class userId and stores staff ID
                    }
                    else
                    {
                        MessageBox.Show("Incorrect credentials"); //if query doesn't return anything and object user is null, display message 
                        return;
                    }


                }

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) //check boolean in DB is_Admin
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        bool isAdmin = Convert.ToBoolean(result);
                        if (isAdmin) 
                        {
                            if (password == "password")
                            {
                                PasswordChange passwordChange = new PasswordChange();
                                passwordChange.Show();
                                this.Hide();
                            }
                            else    //if true open admin home page, if hashedPassword = password, take user to change password form
                            {
                                AdminHome adminHome = new AdminHome();
                                adminHome.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            if (password == "password")
                            {
                                GetUserRole();
                                PasswordChange passwordChange = new PasswordChange();
                                passwordChange.Show();
                                this.Hide();
                            }
                            else  //if is_Admin false, take user to staff home page
                            {
                                GetUserRole();
                                StaffHome staffHome = new StaffHome(staffRole);
                                staffHome.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Credentials");
                    }
                }
            }
        }

        private void GetUserRole()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "SELECT staff_ID FROM Accounts WHERE account_username = @username";

                string staffId = null;
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        staffId = result.ToString();  //store staffId in var
                    }

                }
                string selectQuery = "SELECT staff_role FROM Staff WHERE staff_ID = @staffId";
                using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@staffId", staffId);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        staffRole = result.ToString(); //store role in string variable, used across forms to manage restrictions
                    }
                }
            }
        }

        private string HashPassword(string password) //hashes the password entered in the text box, therefore matching with the one in the data base
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
