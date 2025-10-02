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
    public partial class AdminViewStaff : Form
    {
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;
        private bool isEditing = false;
        private DataTable staffTable; //temporary data table variable to store the information of staff, to then display on the data grid view
                                      //also used for the search function

        public AdminViewStaff()
        {
            InitializeComponent();
            DisplayLoggedInUser();
            LoadStaffData();          //loads data into the grid view
            SetFieldsEnabled(false);  //disables editing fields when opening form 
        }

        private void LoadStaffData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM Staff";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))  //adapts the data in the SQL to the data grid in vs
                {
                    staffTable = new DataTable();
                    adapter.Fill(staffTable);
                    staffGridView.DataSource = staffTable;
                    staffGridView.ClearSelection(); //disables automatic row selection
                }
            }

            //changes the column headers from their initial DB name
            staffGridView.Columns["staff_ID"].HeaderText = "Staff ID";
            staffGridView.Columns["staff_Fname"].HeaderText = "First Name";
            staffGridView.Columns["staff_Mname"].HeaderText = "Middle Name";
            staffGridView.Columns["staff_Lname"].HeaderText = "Last Name";
            staffGridView.Columns["staff_role"].HeaderText = "Role";
            staffGridView.Columns["staff_email"].HeaderText = "Email";
            staffGridView.Columns["staff_telNo"].HeaderText = "Phone Number";
            staffGridView.Columns["staff_DoB"].HeaderText = "Date of Birth";
            staffGridView.Columns["staff_startDate"].HeaderText = "Start Date";
        }
        private void searchTxt_TextChanged(object sender, EventArgs e)  //search function
        {
            string filterText = searchTxt.Text.Replace("'", "''"); //replaces ' with '' which handles potential errors

            if (staffTable != null)
            {
                if (searchComboBox.Text == "ID")
                    staffTable.DefaultView.RowFilter = $"staff_ID LIKE '%{filterText}%'";
                else if (searchComboBox.Text == "First Name")
                    staffTable.DefaultView.RowFilter = $"staff_Fname LIKE '%{filterText}%'";
                else if (searchComboBox.Text == "Last Name")
                    staffTable.DefaultView.RowFilter = $"staff_Lname LIKE '%{filterText}%'";
            }

            staffGridView.ClearSelection();
        }
        private void SetFieldsEnabled(bool enabled) //function used to enable or disable editing fields
        {
            fNameTxt.Enabled = enabled;
            mNameTxt.Enabled = enabled;
            lNameTxt.Enabled = enabled;
            emailTxt.Enabled = enabled;
            phoneNumTxt.Enabled = enabled;
            roleComboBox.Enabled = enabled;
            dobPicker.Enabled = enabled;
            startDatePicker.Enabled = enabled;
            applyBtn.Enabled = false; //fixes bug where apply button would be enabled before edit button would be pressed
        }

 
        private void staffGridView_SelectionChanged(object sender, EventArgs e) //event handler for when selecting the row, the editing text boxes fill with the corresponding data
        {
            if (staffGridView.CurrentRow != null)
            {
                fNameTxt.Text = staffGridView.CurrentRow.Cells["staff_Fname"].Value?.ToString();
                mNameTxt.Text = staffGridView.CurrentRow.Cells["staff_Mname"].Value?.ToString();
                lNameTxt.Text = staffGridView.CurrentRow.Cells["staff_Lname"].Value?.ToString();
                emailTxt.Text = staffGridView.CurrentRow.Cells["staff_email"].Value?.ToString();
                phoneNumTxt.Text = staffGridView.CurrentRow.Cells["staff_telNo"].Value?.ToString();
                roleComboBox.Text = staffGridView.CurrentRow.Cells["staff_role"].Value?.ToString();
                dobPicker.Value = Convert.ToDateTime(staffGridView.CurrentRow.Cells["staff_DoB"].Value);
                startDatePicker.Value = Convert.ToDateTime(staffGridView.CurrentRow.Cells["staff_startDate"].Value);
            }

            isEditing = false;        //when selecting a different row, disable editing
            SetFieldsEnabled(false); 
            editBtn.Text = "Edit";
            applyBtn.Enabled = false;
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!isEditing)   //toggles editing on and off, also changing the button from "edit" to "cancel edit"
            {
                isEditing = true;
                SetFieldsEnabled(true);
                editBtn.Text = "Cancel Edit";
                applyBtn.Enabled = true;
            }
            else
            {
                isEditing = false;
                SetFieldsEnabled(false);
                editBtn.Text = "Edit";
                applyBtn.Enabled = false;

                staffGridView_SelectionChanged(null, null); //resets the fields back to the original staff information when pressing cancel edit
            }
        }
        private void applyBtn_Click_1(object sender, EventArgs e)
        {
            string staffId = staffGridView.CurrentRow.Cells["staff_ID"].Value.ToString();

            if (staffGridView.CurrentRow != null)
            {
                bool noChanges =
                    fNameTxt.Text == staffGridView.CurrentRow.Cells["staff_Fname"].Value?.ToString() &&
                    mNameTxt.Text == staffGridView.CurrentRow.Cells["staff_Mname"].Value?.ToString() &&
                    lNameTxt.Text == staffGridView.CurrentRow.Cells["staff_Lname"].Value?.ToString() &&
                    emailTxt.Text == staffGridView.CurrentRow.Cells["staff_email"].Value?.ToString() &&
                    phoneNumTxt.Text == staffGridView.CurrentRow.Cells["staff_telNo"].Value?.ToString() &&
                    roleComboBox.Text == staffGridView.CurrentRow.Cells["staff_role"].Value?.ToString() &&
                    dobPicker.Value.Date == Convert.ToDateTime(staffGridView.CurrentRow.Cells["staff_DoB"].Value).Date &&
                    startDatePicker.Value.Date == Convert.ToDateTime(staffGridView.CurrentRow.Cells["staff_startDate"].Value).Date;

                if (noChanges)
                {
                    MessageBox.Show("No changes have been made.", "No Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to apply these changes?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult != DialogResult.Yes)
                    return;

                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();

                    string updateStaffQuery = @"UPDATE Staff SET
                        staff_Fname = @fName,
                        staff_Mname = @mName,
                        staff_Lname = @lName,
                        staff_email = @Email,
                        staff_telNo = @Phone,
                        staff_role = @Role,
                        staff_DoB = @Dob,
                        staff_startDate = @StartDate
                    WHERE staff_ID = @staffId";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateStaffQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@fName", fNameTxt.Text);
                        cmd.Parameters.AddWithValue("@mName", mNameTxt.Text);
                        cmd.Parameters.AddWithValue("@lName", lNameTxt.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTxt.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneNumTxt.Text);
                        cmd.Parameters.AddWithValue("@Role", roleComboBox.Text);
                        cmd.Parameters.AddWithValue("@Dob", dobPicker.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@StartDate", startDatePicker.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@staffId", staffId);
                        cmd.ExecuteNonQuery();
                    }

                    string fName = fNameTxt.Text.ToLower();
                    string lName = lNameTxt.Text.ToLower();
                    string userNum = staffId.Substring(1);

                    string newUser = $"{fName}.{lName}{userNum}";


                    UpdateAccountUsername(conn, staffId, newUser); // helper call
                }

                MessageBox.Show("Changes applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isEditing = false;
                SetFieldsEnabled(false);
                editBtn.Text = "Edit";
                applyBtn.Enabled = false;
                LoadStaffData();
            }
            else
            {
                MessageBox.Show("No staff member selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e) 
        {
            if (staffGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a staff member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); //if nothing is selected, display message
                return;
            }

            string staffId = staffGridView.CurrentRow.Cells["staff_ID"].Value.ToString(); //stores the staff id into a variable

            var confirm = MessageBox.Show("Are you sure you want to delete this staff member and their account?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string checkAdminQuery = "SELECT is_Admin FROM Accounts WHERE staff_ID = @staffId"; //if the selected staff is an admin, prevent from deleting
                using (SQLiteCommand cmd = new SQLiteCommand(checkAdminQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@staffId", staffId); //uses the stored staff id to find if the staff is an admin form the DB
                    var result = cmd.ExecuteScalar();
                    if (result != null && Convert.ToInt32(result) == 1)
                    {
                        MessageBox.Show("Cannot delete an admin account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                
                string deleteAccountQuery = "DELETE FROM Accounts WHERE staff_ID = @staffId"; //deletes the account of the selected staff using the staffID
                using (SQLiteCommand deleteAccountCmd = new SQLiteCommand(deleteAccountQuery, conn))
                {
                    deleteAccountCmd.Parameters.AddWithValue("@staffId", staffId);
                    deleteAccountCmd.ExecuteNonQuery();
                }

                
                string deleteStaffQuery = "DELETE FROM Staff WHERE staff_ID = @staffId"; //deletes the staff information from the staff table
                using (SQLiteCommand deleteStaffCmd = new SQLiteCommand(deleteStaffQuery, conn))
                {
                    deleteStaffCmd.Parameters.AddWithValue("@staffId", staffId);
                    int rowsAffected = deleteStaffCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Staff record and account deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Failed to delete staff record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadStaffData(); //refresh form
            ClearForm();
            SetFieldsEnabled(false);
            isEditing = false;
            editBtn.Text = "Edit";
            applyBtn.Enabled = false;
        }

       
        private void UpdateAccountUsername(SQLiteConnection conn, string staffId, string newUsername) //upon changing a staff's member name, update account username
        {
            string updateAccountQuery = "UPDATE Accounts SET account_username = @username WHERE staff_ID = @staffId";

            using (SQLiteCommand cmd = new SQLiteCommand(updateAccountQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", newUsername);
                cmd.Parameters.AddWithValue("@staffId", staffId);
                cmd.ExecuteNonQuery();
            }
        }
        private void ClearForm() //clears all editing fields
        {
            fNameTxt.Text = "";
            mNameTxt.Text = "";
            lNameTxt.Text = "";
            emailTxt.Text = "";
            phoneNumTxt.Text = "";
            roleComboBox.SelectedIndex = -1;
            dobPicker.Value = DateTime.Today;
            startDatePicker.Value = DateTime.Today;
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
        private void backBtn_Click(object sender, EventArgs e) //back to home page
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }
    }
}
