using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace Hospital_Management
{
    public partial class StaffViewPatients : Form
    {
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;

        private DataTable patientTable; //dataTable variable, used to store the return of a query from DB, to then be displayed on the GridView
        private bool isEditing = false; //boolean var, used to enable and disable editing of patient information
        private string staffRole;
        DataGridViewButtonColumn viewDetailsBtn = new DataGridViewButtonColumn(); //column of buttons, each corresponding to the patient information on their row
                                                                                  //opens new form, to view a patient's details


        public StaffViewPatients(string staffRole)
        {
            this.staffRole = staffRole;

            InitializeComponent();
            DisplayLoggedInUser();
            LoadPatientData();       //load data on grid
            SetFieldsEnabled(false); //disables editing

            CheckStaffRole(); //apply restrictions
        }

        private void LoadPatientData() //loads data on the Grid View 
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "SELECT * FROM Patients;";

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    patientTable = new DataTable();
                    adapter.Fill(patientTable);
                    patientGridView.DataSource = patientTable;
                    patientGridView.ClearSelection();
                }
            }
            patientGridView.Columns["patient_ID"].HeaderText = "Patient ID";     //changes column names
            patientGridView.Columns["patient_Fname"].HeaderText = "First Name";
            patientGridView.Columns["patient_Mname"].HeaderText = "Middle Name";
            patientGridView.Columns["patient_Lname"].HeaderText = "Last Name";
            patientGridView.Columns["patient_gender"].HeaderText = "Gender";
            patientGridView.Columns["patient_dob"].HeaderText = "Date of birth";
            patientGridView.Columns["patient_telNo"].HeaderText = "Phone Number";
            patientGridView.Columns["patient_email"].HeaderText = "Email";

            if (!patientGridView.Columns.Contains("viewDetails"))  //conditional statement, preventing multiple button columns to be created
            {
                viewDetailsBtn.Name = "viewDetails";
                viewDetailsBtn.HeaderText = "Actions";
                viewDetailsBtn.Text = "Details";         
                viewDetailsBtn.UseColumnTextForButtonValue = true;
                patientGridView.Columns.Add(viewDetailsBtn);
            }

        }
        private void SetFieldsEnabled(bool enabled) //function used to enable or disable editing fields
        {
            fNameTxt.Enabled = enabled;
            mNameTxt.Enabled = enabled;
            lNameTxt.Enabled = enabled;
            emailTxt.Enabled = enabled;
            phoneTxt.Enabled = enabled;
            genderComboBox.Enabled = enabled;
            dobPicker.Enabled = enabled;
            applyBtn.Enabled = enabled; //fixes bug where apply button would be enabled before the edit button is clicked
        }
        private void patientGridView_SelectionChanged(object sender, EventArgs e) //fills fields with the patient's information
        {
            if (patientGridView.CurrentRow != null)
            {
                fNameTxt.Text = patientGridView.CurrentRow.Cells["patient_Fname"].Value?.ToString();
                mNameTxt.Text = patientGridView.CurrentRow.Cells["patient_Mname"].Value?.ToString();
                lNameTxt.Text = patientGridView.CurrentRow.Cells["patient_Lname"].Value?.ToString();
                genderComboBox.Text = patientGridView.CurrentRow.Cells["patient_gender"].Value?.ToString();
                dobPicker.Value = Convert.ToDateTime(patientGridView.CurrentRow.Cells["patient_dob"].Value);
                phoneTxt.Text = patientGridView.CurrentRow.Cells["patient_telNo"].Value?.ToString();
                emailTxt.Text = patientGridView.CurrentRow.Cells["patient_email"].Value?.ToString();
            }
        }
        private void AddNewPatient()//add patient logic
        {
            bool isUnique = false;
            int newPatientId = 0; //variable where the new ID will be stored
            Random rand = new Random(); //used to generate a new ID
            List<int> patientIds = new List<int>(); //used to store all existing IDs, then checked with the randomly generated ID 

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string query = "SELECT patient_ID FROM Patients";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patientIds.Add(reader.GetInt32(0)); //read all patient IDs from DB into list
                        }
                    }
                }

                while (!isUnique)
                {
                    newPatientId = rand.Next(1000, 10000); //generates a random ID
                    isUnique = true;

                    foreach (int patientId in patientIds) //checks if matches with existing IDs
                    {
                        if (patientId == newPatientId)
                        {
                            isUnique = false; break;  //if yes, continue loop and break foreach
                        }
                    }
                }


                string insertQuery = "INSERT INTO Patients (patient_ID, patient_Fname, patient_Mname, patient_Lname, patient_gender, patient_dob, patient_telNo, patient_email) " +
                                         "VALUES (@id, @fname, @mname, @lname, @gender, @dob, @tel, @email)";

                using (SQLiteCommand cmd2 = new SQLiteCommand(insertQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("id", newPatientId);
                    cmd2.Parameters.AddWithValue("fname", fNameTxt.Text.Trim());
                    if (string.IsNullOrWhiteSpace(mNameTxt.Text))   //solves issue where in the DB it would store blank spance instead of showing as "NULL"
                    {
                        cmd2.Parameters.AddWithValue("@mname", DBNull.Value);
                    }
                    else
                    {
                        cmd2.Parameters.AddWithValue("@mname", mNameTxt.Text);
                    }
                    cmd2.Parameters.AddWithValue("lname", lNameTxt.Text.Trim());
                    cmd2.Parameters.AddWithValue("gender", genderComboBox.Text.Trim());
                    cmd2.Parameters.AddWithValue("dob", dobPicker.Value.ToString("yyyy-MM-dd").Trim());
                    cmd2.Parameters.AddWithValue("tel", phoneTxt.Text.Trim());
                    cmd2.Parameters.AddWithValue("email", emailTxt.Text.Trim());

                    cmd2.ExecuteNonQuery();
                }
            }
        }
        private void searchTxt_TextChanged(object sender, EventArgs e)//search function
        {
            string filterText = searchTxt.Text.Replace("'", "''"); //replaces ' with '' which handles error when entering it in the search text box 

            if (patientTable != null)
            {
                if (searchByComboBox.Text == "ID")
                    patientTable.DefaultView.RowFilter = $"Convert(patient_ID, 'System.String') LIKE '%{filterText}%'"; //convert is used because patient_ID is an integer in the DB
                else if (searchByComboBox.Text == "First name")
                    patientTable.DefaultView.RowFilter = $"patient_Fname LIKE '%{filterText}%'";
                else if (searchByComboBox.Text == "Last name")
                    patientTable.DefaultView.RowFilter = $"patient_Lname LIKE '%{filterText}%'";
            }

            patientGridView.ClearSelection();
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (addBtn.Text == "New")
            {

                patientGridView.ClearSelection();
                patientGridView.Enabled = false;  //disables data grid, so you can't select it while adding, preventing fields to auto fill with existing patient data

                SetFieldsEnabled(true);

                fNameTxt.Clear();
                mNameTxt.Clear();
                lNameTxt.Clear();
                emailTxt.Clear();
                phoneTxt.Clear();
                genderComboBox.SelectedIndex = -1;
                dobPicker.Value = DateTime.Today;
                addBtn.Text = "Add";
                editBtn.Text = "Cancel"; //using edit button in order to be able to cancel this action
            }

            else if (addBtn.Text == "Add")
            {
                if (string.IsNullOrWhiteSpace(fNameTxt.Text.Trim()) ||   //checks all fields are filled
                    string.IsNullOrWhiteSpace(lNameTxt.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(phoneTxt.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(emailTxt.Text.Trim()) ||
                    genderComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (genderComboBox.Text != "Male" && genderComboBox.Text != "Female" && genderComboBox.Text != "Other")   //checks if gender combo box matches a valid value
                {
                    MessageBox.Show("Gender value is invalid.", "Invalid Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!phoneTxt.Text.All(char.IsDigit))  //checks for any non-digit values in the phone number textbox
                {
                    MessageBox.Show("Phone number digits are invalid.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AddNewPatient(); //calls function to add a new patient

                    //clears and disables fields
                    fNameTxt.Clear();
                    mNameTxt.Clear();
                    lNameTxt.Clear();
                    emailTxt.Clear();
                    phoneTxt.Clear();
                    genderComboBox.SelectedIndex = -1;
                    dobPicker.Value = DateTime.Today;
                    addBtn.Text = "New";

                    SetFieldsEnabled(false);
                    patientGridView.Enabled = true; //re-enables data grid
                    editBtn.Text = "Edit";

                    MessageBox.Show("Patient added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPatientData(); //refresh grid
                    CheckStaffRole();  //prevent restrictions bug
                }

            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (editBtn.Text == "Cancel") //else if statement, used when adding patient action to be canceled
            {
                fNameTxt.Clear();
                mNameTxt.Clear();
                lNameTxt.Clear();
                emailTxt.Clear();
                phoneTxt.Clear();
                genderComboBox.SelectedIndex = -1;
                dobPicker.Value = DateTime.Today;
                addBtn.Text = "New";
                editBtn.Text = "Edit";

                patientGridView.Enabled = true; //re-enables data grid
                SetFieldsEnabled(false);
                return;
            }

            else if (!isEditing)   //toggles editing on and off, also changing the button from "edit" to "cancel edit"
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

                patientGridView_SelectionChanged(null, null); //resets the fields back to the original staff information when pressing cancel edit
            }
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (patientGridView.CurrentRow != null)
            {

                string patientId = patientGridView.CurrentRow.Cells["patient_ID"].Value.ToString(); //stores patient ID of the selected row

                bool noChanges = //boolean used to check if changes have been made
                    fNameTxt.Text == patientGridView.CurrentRow.Cells["patient_Fname"].Value?.ToString() &&
                    mNameTxt.Text == patientGridView.CurrentRow.Cells["patient_Mname"].Value?.ToString() &&
                    lNameTxt.Text == patientGridView.CurrentRow.Cells["patient_Lname"].Value?.ToString() &&
                    emailTxt.Text == patientGridView.CurrentRow.Cells["patient_email"].Value?.ToString() &&
                    phoneTxt.Text == patientGridView.CurrentRow.Cells["patient_telNo"].Value?.ToString() &&
                    genderComboBox.Text == patientGridView.CurrentRow.Cells["patient_role"].Value?.ToString() &&
                    dobPicker.Value.Date == Convert.ToDateTime(patientGridView.CurrentRow.Cells["patient_dob"].Value).Date;


                if (noChanges)  //if no changes have been made, nothing happens
                {
                    MessageBox.Show("No changes have been made.", "No Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                var confirmResult = MessageBox.Show(
                    "Are you sure you want to apply these changes?", //display a confirm changes pop-up
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult != DialogResult.Yes)
                {
                    return; //if no return
                } //if yes continue


                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();

                    string query = @"UPDATE Patients SET
                                patient_Fname = @fName,
                                patient_Mname = @mName,
                                patient_Lname = @lName,
                                patient_email = @Email,
                                patient_telNo = @Phone,
                                patient_gender = @Gender,
                                patient_dob = @Dob,
                            WHERE patient_ID = @patientId";  //query which will update the information inside the DB

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fName", fNameTxt.Text);  //places the information in the editing boxes inside the parameters from the query
                        cmd.Parameters.AddWithValue("@mName", mNameTxt.Text);
                        cmd.Parameters.AddWithValue("@lName", lNameTxt.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTxt.Text);
                        cmd.Parameters.AddWithValue("@Phone", phoneTxt.Text);
                        cmd.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                        cmd.Parameters.AddWithValue("@Dob", dobPicker.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@patientId", patientId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Changes applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to apply changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Exit edit mode
                isEditing = false;
                SetFieldsEnabled(false);
                editBtn.Text = "Edit";
                applyBtn.Enabled = false;

                LoadPatientData(); //reloads the data grid view
                CheckStaffRole();
            }
            else
            {
                MessageBox.Show("No patient selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string patientId = patientGridView.CurrentRow.Cells["patient_ID"].Value.ToString(); //grabs patient ID of currently selected row


            var confirm = MessageBox.Show("Are you sure you want to delete this patient?",  
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) //conditional statement
            {
                return;  //if no, return
            }

            else  //if user chooses yes, delete patient
            {
                if (patientGridView.CurrentRow == null) //if no row is selected
                {
                    MessageBox.Show("Please select a patient to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); //if nothing is selected, display message
                    return;
                }

                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();

                    string deletePatientQuery = "DELETE FROM Patients WHERE patient_ID = @patientId"; //deletes the patient information from the patient table
                    using (SQLiteCommand cmd = new SQLiteCommand(deletePatientQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientId", patientId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Patient record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Failed to delete patient record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadPatientData(); //refreshes data grid
                    CheckStaffRole(); //prevents issue, where after refresh, restrictions would be removed
                }
            }
        }


        private void patientGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) //when clicking details button, takes you to a form dedicated to the patient 
        {
            

            if (e.RowIndex >= 0 && patientGridView.Columns[e.ColumnIndex].Name == "viewDetails") //checks if is not the header row selected, and that the buttons column is selected
            {
                if (staffRole == "Receptionist") //extra measure for receptionist role, not being able to view patient details
                {
                    MessageBox.Show("You do not have permission to view patient details.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    int patientID = Convert.ToInt32(patientGridView.Rows[e.RowIndex].Cells["patient_ID"].Value); //saves patient ID in variable

                    StaffViewPatientMedicalHistory staffViewPatientMedicalHistory = new StaffViewPatientMedicalHistory(patientID, staffRole); //transfers over patientID to the other form
                    staffViewPatientMedicalHistory.Show();
                    this.Hide();
                }
            }
        }
        private void CheckStaffRole() //check role function, uses staffRole variable to change permissions, depending on who's logged in
        {
            if (staffRole == "Doctor")
            {
                //only view list for doctor
                SetFieldsEnabled(false);
                addBtn.Enabled = false;
                editBtn.Enabled = false;
                applyBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
            else if (staffRole == "Nurse")
            {
                //full access for nurse
            }
            else if (staffRole == "Receptionist") //view details of patients restricted for nurse
            {
                foreach (DataGridViewRow row in patientGridView.Rows)
                {
                    row.Cells["viewDetails"].Style.ForeColor = Color.Gray;
                    row.Cells["viewDetails"].Value = "Restricted";
                }
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

                            roleLbl.Text = staffRole;
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
        private void backbtn_Click(object sender, EventArgs e)
        {
            StaffHome staffHome = new StaffHome(staffRole);  
            staffHome.Show();
            this.Hide();
        }
    }
}
