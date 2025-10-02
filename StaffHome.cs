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

namespace Hospital_Management
{
    public partial class StaffHome : Form
    {
        private string staffRole;
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;

        public StaffHome(string staffRole)
        {
            this.staffRole = staffRole; //calls variable which holds the logged in user role

            InitializeComponent();
            DisplayLoggedInUser(); 
        }


        private void patientListBtn_Click(object sender, EventArgs e)
        {
            StaffViewPatients staffViewPatients = new StaffViewPatients(staffRole); //go to patients form
            staffViewPatients.Show();
            this.Hide();
        }

        private void appointmentListBtn_Click(object sender, EventArgs e)
        {
            StaffCreateAppointment staffViewAppointments = new StaffCreateAppointment(staffRole); //go to appointments form
            staffViewAppointments.Show();
            this.Hide();
        }

        private void DisplayLoggedInUser() //function called in the form constructor, displaying name and role of the logged in user, top left screen
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
                            //reads fname and lName in their corresponding string variables, using the read SQLite function
                            string firstName = reader["staff_Fname"].ToString();  
                            string lastName = reader["staff_Lname"].ToString();

                            roleLbl.Text = staffRole; //uses staffRole var to displat role
                            loggedInLbl.Text = firstName + " " + lastName; //forms label
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
            Login login = new Login(); //back to login
            login.Show();
            this.Hide();
        }
    }
}
