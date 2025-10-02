using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
  


    public partial class AdminNewStaff : Form
    {
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;

        public AdminNewStaff()
        {
            InitializeComponent();
            DisplayLoggedInUser();
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fNameTxt.Text) || string.IsNullOrWhiteSpace(lNameTxt.Text) || string.IsNullOrWhiteSpace(emailTxt.Text) ||
                string.IsNullOrWhiteSpace(phoneNumTxt.Text))  //checks so no fields are left blank
            {
                MessageBox.Show("Please fill out all fields necessary");
            }

            else if (roleComboBox.Text != "Receptionist" && roleComboBox.Text != "Doctor" && roleComboBox.Text != "Nurse") //check if one of the correct Roles is selected
            {
                MessageBox.Show("Please select a valid job role");
            }

            else if(dobPicker.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Staff must be at least 18 years of age");
            }

            else if(startDatePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Start date selected is not valid");
            }
            else if (!phoneNumTxt.Text.All(char.IsDigit))  //checks for any non-digit values in the phone number textbox
            {
                MessageBox.Show("Phone number digits are invalid.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CreateNewStaff();
       

                fNameTxt.Clear();
                lNameTxt.Clear();
                mNameTxt.Clear();
                roleComboBox.Text = "";
                emailTxt.Clear();
                phoneNumTxt.Clear();

                MessageBox.Show("Staff created successfully");
            }
        }
        private void CreateNewStaff()
        {
            int nextNumber = 0; //will be number after the "S"
            string newStaffID;  //this variable will store the new ID that the function will generate

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "SELECT staff_ID FROM Staff ORDER BY CAST(SUBSTR(staff_ID, 2) AS INTEGER) DESC LIMIT 1;";  //retrieves the last ID in the Staff table
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result.ToString().StartsWith("S"))
                    {
                        string lastId = result.ToString();
                        int lastNumber = int.Parse(lastId.Substring(1));  //removes the "S" from the ID, and keeps only the numbers
                        nextNumber = lastNumber + 1; //adds 1 to the ID, making it unique

                        newStaffID = "S" + nextNumber.ToString();  //combines S and new number, creating a new unique ID
                    }

                    else
                    {
                        newStaffID = "S1";
                    }

                }


                string insertQuery = "INSERT INTO Staff(staff_ID, staff_Fname, staff_Mname, staff_Lname, staff_role, staff_email, staff_telNo, staff_DoB, staff_startDate)" +
                                   "VALUES(@staffId, @fName, @mName, @lName, @role, @email, @telNo, @dob, @startDate);";
                using (SQLiteCommand cmd2 = new SQLiteCommand(insertQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("staffId", newStaffID);
                    cmd2.Parameters.AddWithValue("fName", fNameTxt.Text.Trim());

                    if (string.IsNullOrWhiteSpace(mNameTxt.Text))   //solves issue where in the DB it would store blank spance instead of showing as "NULL"
                    {
                        cmd2.Parameters.AddWithValue("@mName", DBNull.Value);
                    }
                    else                                           
                    {
                        cmd2.Parameters.AddWithValue("@mName", mNameTxt.Text);
                    }

                    cmd2.Parameters.AddWithValue("lName", lNameTxt.Text.Trim());
                    cmd2.Parameters.AddWithValue("role", roleComboBox.Text.Trim());
                    cmd2.Parameters.AddWithValue("email", emailTxt.Text.Trim());
                    cmd2.Parameters.AddWithValue("telNo", phoneNumTxt.Text.Trim());
                    cmd2.Parameters.AddWithValue("dob", dobPicker.Value.ToString("yyyy-MM-dd").Trim());
                    cmd2.Parameters.AddWithValue("startDate", startDatePicker.Value.ToString("yyyy-MM-dd").Trim());
                 

                    cmd2.ExecuteNonQuery();

                    CreateStaffAccount(nextNumber, newStaffID);


                }
            }
        }
        private void CreateStaffAccount(int b, string a)   //function that automatically create an account upon addition of a new staff member, called inside the CreateNewStaff function
        {
            int newAccountId = 0;
            string fName;
            string lName;
            string newAccountUser;
            string newPass = HashPassword("password");



            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                Random rand = new Random();
                bool isUnique = false;

                while (!isUnique) //generates a random ID for the account_ID
                {
                    newAccountId = rand.Next(1000, 10000); // 1000–9999

                    string checkQuery = "SELECT COUNT(*) FROM Accounts WHERE account_ID = @id";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", newAccountId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        isUnique = count == 0;
                    }
                }

                string selectQuery = "SELECT staff_Fname FROM Staff WHERE staff_ID = @staffId;";

                using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("staffId", a);

                    object result = cmd.ExecuteScalar();
                    fName = result.ToString();               //gets the first name of the newly added staff member
                }

                string selectQuery2 = "SELECT staff_Lname FROM Staff WHERE staff_ID = @staffId;";

                using (SQLiteCommand cmd = new SQLiteCommand(selectQuery2, conn))
                {
                    cmd.Parameters.AddWithValue("staffId", a);

                    object result = cmd.ExecuteScalar();
                    lName = result.ToString();              //gets the last name of the newly added staff member
                }

                newAccountUser = $"{fName}.{lName}{b}"; //joins together both names and adds the digits from the staff ID at the end, creating the login username


                string insertQuery = "INSERT INTO Accounts (account_ID, staff_ID, account_username, account_password, is_Admin)" +
                                         "VALUES(@accountId, @staffId, @username, @password, @isAdmin);";

                using (SQLiteCommand cmd2 = new SQLiteCommand(insertQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("accountId", newAccountId);
                    cmd2.Parameters.AddWithValue("staffId", a);
                    cmd2.Parameters.AddWithValue("username", newAccountUser.ToLower());
                    cmd2.Parameters.AddWithValue("password", newPass);
                    cmd2.Parameters.AddWithValue("isAdmin", false); //no admin role choice, so is false by default

                    cmd2.ExecuteNonQuery();
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
        private void DisplayLoggedInUser()
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
        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}
