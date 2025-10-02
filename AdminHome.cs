using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class AdminHome : Form
    {
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;

        public AdminHome()
        {
            InitializeComponent();
            DisplayLoggedInUser();
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            AdminNewStaff adminNewStaff = new AdminNewStaff();
            adminNewStaff.Show();
            this.Hide();
        }
        private void editStaffBtn_Click(object sender, EventArgs e)
        {
            AdminViewStaff adminViewStaff = new AdminViewStaff();   
            adminViewStaff.Show();
            this.Hide();
        }


        private void DisplayLoggedInUser() //displays logged in user and role in top left of screen
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "SELECT staff_Fname, staff_Lname FROM Staff WHERE staff_ID = @staffId";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("staffId", userId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["staff_Fname"].ToString();
                            string lastName = reader["staff_Lname"].ToString();

                            loggedInLbl.Text = firstName + " " + lastName;
                        }
                        else
                        {
                            loggedInLbl.Text = "Unknown user";
                        }
                    }
                }
            }
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login(); //takes user to login page
            login.Show();
            this.Hide();
        }
    }
}
