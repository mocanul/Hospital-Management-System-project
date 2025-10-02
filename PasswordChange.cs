using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Hospital_Management
{
    public partial class PasswordChange : Form
    {
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;


        public PasswordChange()
        {
            InitializeComponent();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            string newPass = newPassTxt.Text.Trim(); //places newly entered pass in var
            string confirmNewPass = confirmNewPassTxt.Text.Trim();
            string hashNewPass = HashPassword(newPass); //hashes new pass

            if (string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmNewPass))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else if (newPass != confirmNewPass)  
            {
                MessageBox.Show("Password was not confirmed properly, try again");  
            }                                                                       //validation checks for password change
            else if (newPass.Length < 8)
            {
                MessageBox.Show("Password must be longer than 8 characters.");
            }
            else if (newPass == "password")
            {
                MessageBox.Show("You cannot change your password to 'password'");
            }

            else //if new password is valid
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();

                    string query = "UPDATE Accounts SET account_password = @newPassword WHERE staff_ID = @userId"; //updates password in DB with the new pass

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("newPassword", hashNewPass); //hashed pass into parameter
                        cmd.Parameters.AddWithValue("userId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Login login = new Login(); //take user back to login page
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Update failed, user was not found");
                        }
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
