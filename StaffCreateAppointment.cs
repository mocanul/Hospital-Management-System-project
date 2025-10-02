using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Hospital_Management
{
    public partial class StaffCreateAppointment : Form
    {
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;
        private DataTable appointmentsTable;
        private string staffRole;

        public StaffCreateAppointment(string staffRole)
        {
            this.staffRole = staffRole;

            InitializeComponent();
            LoadAppointments();
            DisplayLoggedInUser();
            SetFieldsEnabled(false);

            CheckStaffRole();
        }


        private void LoadAppointments()
        {
            string query = "SELECT a.appointment_ID, p.patient_Fname, p.patient_Lname, a.appointment_date, a.appointment_time, a.appointment_reason " +
                           "FROM Appointments a " +
                           "JOIN Patients p ON a.patient_ID = p.patient_ID " +
                           "WHERE datetime(a.appointment_date || ' ' || a.appointment_time) > datetime('now', 'localtime');";  //appointment table query requesting the following columns
                                                                                                                               //appointmentID, patient First and last name, date, time and reason of appointment
                                                                                                                              


            using (SQLiteConnection conn = new SQLiteConnection(connection))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                conn.Open();

                appointmentsTable = new DataTable(); //dataTable used to store information from the DB, to then be displayed on the grid view
                adapter.Fill(appointmentsTable); //adapter fills Data table
                appointmentGridView.DataSource = appointmentsTable; //dataTable is the source of data for the grid view
                appointmentGridView.ClearSelection(); //clears selected row
            }

            if (appointmentGridView.Columns.Contains("appointment_time"))
            {
                appointmentGridView.Columns["appointment_time"].DefaultCellStyle.Format = "hh:mm tt"; //changes the format of the time displayed on the grid
            }

            appointmentGridView.Columns["appointment_ID"].HeaderText = "Appointment ID";
            appointmentGridView.Columns["patient_Fname"].HeaderText = "First Name";
            appointmentGridView.Columns["patient_Lname"].HeaderText = "Last Name";
            appointmentGridView.Columns["appointment_date"].HeaderText = "Date";     //changes column names
            appointmentGridView.Columns["appointment_time"].HeaderText = "Time";
            appointmentGridView.Columns["appointment_reason"].HeaderText = "Reason of appointment";
        }
        private void SetFieldsEnabled(bool enabled) //function used to enable or disable editing fields
        {
            fNameTxt.Enabled = enabled;
            mNameTxt.Enabled = enabled;
            lNameTxt.Enabled = enabled;
            datePicker.Enabled = enabled;
            timePicker.Enabled = enabled;
            reasonTxt.Enabled = enabled;  //fixes bug where apply button would be enabled before the edit button is clicked
        }
        private void searchTxt_TextChanged(object sender, EventArgs e)//search function
        {
            string filterText = searchTxt.Text.Replace("'", "''"); //fixes a bug, where if entering ' in the search, SQL would crash

            if (appointmentsTable != null)
            {
                if (searchByComboBox.Text == "First name")
                {
                    appointmentsTable.DefaultView.RowFilter = $"patient_Fname LIKE '%{filterText}%'";
                }
                else if (searchByComboBox.Text == "Last name")
                {
                    appointmentsTable.DefaultView.RowFilter = $"patient_Lname LIKE '%{filterText}%'";
                }
                else
                {
                    appointmentsTable.DefaultView.RowFilter = "";
                }

                appointmentGridView.ClearSelection();
            }
        }


        private void AddNewAppointment()
        {
            string firstName = fNameTxt.Text.Trim();
            string lastName = lNameTxt.Text.Trim();
            string reason = reasonTxt.Text.Trim();
            bool isUnique = false;
            string newAppointmentId = "";
            List<string> appointmentsId = new List<string>(); //list used to store all existing appointment IDs

            DateTime date = datePicker.Value.Date;
            DateTime time = timePicker.Value;

            string patientId = null;

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                
                string getIdQuery = "SELECT patient_ID FROM Patients WHERE patient_Fname = @fname AND patient_Lname = @lname";

                using (SQLiteCommand cmd = new SQLiteCommand(getIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        patientId = result.ToString(); //stores patient ID
                    else
                    {
                        MessageBox.Show("Patient not found. Please check the name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SetFieldsEnabled(true);
                        return;
                    }
                }

                string query = "SELECT appointment_ID FROM Appointments";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        appointmentsId.Add(reader.GetString(0)); //stores appointment IDs into list
                }


                while (!isUnique)
                {
                    newAppointmentId = "APT" + Guid.NewGuid().ToString("N").Substring(0, 6); //generates random ID 
                    isUnique = !appointmentsId.Contains(newAppointmentId); //checks if IDs match, if not break loop
                }

                string insertQuery = @"INSERT INTO Appointments (appointment_ID, patient_ID, appointment_date, appointment_time, appointment_reason)
                               VALUES (@id, @patientId, @date, @time, @reason)";
                using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@id", newAppointmentId);
                    insertCmd.Parameters.AddWithValue("@patientId", patientId);
                    insertCmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));  //all the data in the text boxes gets inserted into the appointments table
                    insertCmd.Parameters.AddWithValue("@time", time.ToString("HH:mm"));
                    insertCmd.Parameters.AddWithValue("@reason", reason);
                    insertCmd.ExecuteNonQuery();
                }

                string insertHistoryQuery = @"INSERT INTO PatientMedicalHistory (patient_ID, appointment_ID)
                                      VALUES (@patientId, @appointmentId)";
                using (SQLiteCommand historyCmd = new SQLiteCommand(insertHistoryQuery, conn))
                {
                    historyCmd.Parameters.AddWithValue("@patientId", patientId);
                    historyCmd.Parameters.AddWithValue("@appointmentId", newAppointmentId);
                    historyCmd.ExecuteNonQuery();  //appointment ID also gets added to the PatientMedicalHistory table
                }

                MessageBox.Show("Appointment created and added to medical history.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadAppointments(); //refresh grid
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (addBtn.Text == "New")  //enables Adding 
            {

                appointmentGridView.ClearSelection();
                SetFieldsEnabled(true); //sets all fields to enabled

                fNameTxt.Clear();
                mNameTxt.Clear();
                lNameTxt.Clear();
                datePicker.Value = DateTime.Now;
                timePicker.Value = DateTime.Now;
                reasonTxt.Clear();
                addBtn.Text = "Add";
                deleteBtn.Text = "Cancel";  //using delete button as a cancel button
            }

            else if (addBtn.Text == "Add")
            {
                if (string.IsNullOrWhiteSpace(fNameTxt.Text.Trim()) ||   //checks all fields are filled
                    string.IsNullOrWhiteSpace(lNameTxt.Text.Trim()) ||
                    string.IsNullOrWhiteSpace(reasonTxt.Text.Trim()))
                {
                    MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    DateTime selectedDateTime = datePicker.Value.Date + timePicker.Value.TimeOfDay;

                    if (selectedDateTime < DateTime.Now)
                    {
                        MessageBox.Show("Please enter a valid date and time", "Invalid date and time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SetFieldsEnabled(false);

                    AddNewAppointment(); //calls function to add a new appointment

                    //clears and disables fields
                    fNameTxt.Clear();
                    mNameTxt.Clear();
                    lNameTxt.Clear();
                    reasonTxt.Clear();
                    datePicker.Value = DateTime.Now;
                    timePicker.Value = DateTime.Now;
           
                    addBtn.Text = "New";
                    deleteBtn.Text = "Delete"; //changes Cancel button back to Delete
                }
            }
        }
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (deleteBtn.Text == "Cancel")
            {
                fNameTxt.Clear();
                mNameTxt.Clear();
                lNameTxt.Clear();
                reasonTxt.Clear();
                datePicker.Value = DateTime.Now;
                timePicker.Value = DateTime.Now;
                SetFieldsEnabled(false);

                addBtn.Text = "New";
                deleteBtn.Text = "Delete";
            }

            else
            {
                if (appointmentGridView.SelectedRows.Count == 0) //ignores header row
                {
                    MessageBox.Show("Please select an appointment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string appointmentId = appointmentGridView.SelectedRows[0].Cells["appointment_ID"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)  //if pressing no, deletion will be canceled
                    return;

                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();

                    using (SQLiteTransaction transaction = conn.BeginTransaction())
                    {
                        string deleteDiagnosis = "DELETE FROM Diagnosis WHERE appointment_ID = @appointmentId";  //delete from diagnosis table
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteDiagnosis, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteLabTest = "DELETE FROM LabTest WHERE appointment_ID = @appointmentId";  //delete from labTest table
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteLabTest, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteHistory = "DELETE FROM PatientMedicalHistory WHERE appointment_ID = @appointmentId"; //delete from PatiendMedicalHistory table
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteHistory, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteAppointment = "DELETE FROM Appointments WHERE appointment_ID = @appointmentId";  //delete from Appointments table
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteAppointment, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Appointment deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointments(); //refresh the data grid
                    }
                }
            }
        }
        private void recordsBtn_Click(object sender, EventArgs e)
        {
            StaffViewAppointments viewPastAppointments = new StaffViewAppointments(staffRole); //takes user to appointment records
            viewPastAppointments.Show();                                                       //which stores all appointments from the past
            this.Hide();                                                                       //whereas, this form only display future appointments, from present Date/Time
        }


        private void CheckStaffRole()
        {
            if (staffRole == "Doctor")
            {
                SetFieldsEnabled(false);
                addBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
            else if (staffRole == "Nurse")
            {
                SetFieldsEnabled(false);
                addBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
            else if (staffRole == "Receptionist")
            {
                //full access for receptionist
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
        private void backBtn_Click_1(object sender, EventArgs e)
        {
            StaffHome staffHome = new StaffHome(staffRole);
            staffHome.Show();
            this.Hide();
        }
    }
}
