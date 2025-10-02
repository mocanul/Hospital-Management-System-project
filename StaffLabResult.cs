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
    public partial class StaffLabResult : Form
    {
        private int patientID;
        private string appointmentID;
        private string type;
        private string testResult;
        private string staffRole;

        private string testType = "";
        private string labTestResult = "";

        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;

        public StaffLabResult(int patientID, string appointmentID, string type, string labTestResult, string staffRole)
        {
            this.patientID = patientID;
            this.appointmentID = appointmentID;
            this.type = type;
            this.labTestResult = labTestResult;
            this.staffRole = staffRole;

            InitializeComponent();
            LoadPatientDetails();
            DisableTextBoxes();
            DisplayLoggedInUser();

            typeTxt.Text = type;
            resultTxt.Text = labTestResult;
            ApplyEventHandler();
        }

        private void LoadPatientDetails() //loads patient details in the disabled text boxes
        {
            string fName = "";
            string mName = "";
            string lName = "";


            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string fNameQuery = "SELECT patient_Fname FROM Patients WHERE patient_ID = @patientId;";
                string mNameQuery = "SELECT patient_Mname FROM Patients WHERE patient_ID = @patientId;";
                string lNameQuery = "SELECT patient_Lname FROM Patients WHERE patient_ID = @patientId;";

                using (SQLiteCommand cmd = new SQLiteCommand(fNameQuery, conn))
                {
                    cmd.Parameters.AddWithValue("patientId", patientID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        fName = result.ToString();
                    }
                }

                using (SQLiteCommand cmd = new SQLiteCommand(mNameQuery, conn))
                {
                    cmd.Parameters.AddWithValue("patientId", patientID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        mName = result.ToString();
                    }
                    else
                    {
                        mName = "N/A";
                    }
                }

                using (SQLiteCommand cmd = new SQLiteCommand(lNameQuery, conn))
                {
                    cmd.Parameters.AddWithValue("patientId", patientID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lName = result.ToString();
                    }
                }
            }

            patientIdTxt.Text = patientID.ToString();
            appointmentIdTxt.Text = appointmentID.ToString();
            fNameTxt.Text = fName.ToString();
            mNameTxt.Text = mName.ToString();
            lNametxt.Text = lName.ToString();
        }
        private void DisableTextBoxes()
        {
            patientIdTxt.Enabled = false;
            appointmentIdTxt.Enabled = false;
            fNameTxt.Enabled = false;
            mNameTxt.Enabled = false;
            lNametxt.Enabled = false;
        }


        private void ApplyEventHandler()//changes event handler of the save button
        {
            saveBtn.Click -= saveBtn_Click;
            saveBtn.Click -= EditLabTestEventHandler;

            if (!string.IsNullOrWhiteSpace(typeTxt.Text))
            {
                saveBtn.Click += EditLabTestEventHandler;
            }
            else
            {
                saveBtn.Click += saveBtn_Click;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTxt.Text.Trim()) || string.IsNullOrWhiteSpace(resultTxt.Text.Trim()))
            {
                MessageBox.Show("Please fill out both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddLabTest();
            DialogResult result = MessageBox.Show("Lab test information added successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK) //nicer transition back to the patient medical history form
            {
                StaffViewPatientMedicalHistory patientHistory = new StaffViewPatientMedicalHistory(patientID, staffRole);
                patientHistory.Show();
                this.Hide();
            }
        }
        private void EditLabTestEventHandler(object sender, EventArgs e)    
        {
            if (string.IsNullOrWhiteSpace(typeTxt.Text.Trim()) || string.IsNullOrWhiteSpace(resultTxt.Text.Trim()))
            {
                MessageBox.Show("Please fill out both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (typeTxt.Text == type && resultTxt.Text == labTestResult)
            {
                MessageBox.Show("No changes have been made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "UPDATE LabTest " +
                               "SET test_type = @type, test_result = @result " +
                               "WHERE patient_ID = @patientId AND appointment_ID = @appointmentId;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("type", typeTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("result", resultTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("patientId", patientID);
                    cmd.Parameters.AddWithValue("appointmentId", appointmentID);

                    cmd.ExecuteNonQuery();
                }
            }

            DialogResult result = MessageBox.Show("Lab test updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK) //nicer transition back to the patient medical history form
            {
                StaffViewPatientMedicalHistory patientHistory = new StaffViewPatientMedicalHistory(patientID, staffRole);
                patientHistory.Show();
                this.Hide();
            }
        }
        private void AddLabTest()//adds new lab test to the labTest Table
        {
            string newLabId = "";
            bool isUnique = false;
            List<string> labId = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "SELECT diagnosis_ID FROM Diagnosis";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        labId.Add(reader.GetString(0));
                }

                while (!isUnique)
                {
                    newLabId = "LAB" + Guid.NewGuid().ToString("N").Substring(0, 6);
                    isUnique = !labId.Contains(newLabId);
                }

                string insertQuery = "INSERT INTO LabTest (labTest_ID, appointment_ID, patient_ID, test_type, test_result)" +
                                     "VALUES(@labId, @appointmentId, @patientId, @type, @result);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("labId", newLabId);
                    cmd.Parameters.AddWithValue("appointmentId", appointmentID);
                    cmd.Parameters.AddWithValue("patientId", patientID);
                    cmd.Parameters.AddWithValue("type", typeTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("result", resultTxt.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                string updateQuery = "UPDATE PatientMedicalHistory " +
                                     "SET labTest_ID = @labId " +
                                     "WHERE patient_ID = @patientId AND appointment_ID = @appointmentId;";


                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("labId", newLabId);
                    cmd.Parameters.AddWithValue("patientId", patientID);
                    cmd.Parameters.AddWithValue("appointmentId", appointmentID);

                    cmd.ExecuteNonQuery();
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
                            roleLbl.Text = staffRole;
                            loggedInLbl.Text = reader["staff_Fname"] + " " + reader["staff_Lname"];
                        }
                        else
                            loggedInLbl.Text = "Unknown user";
                    }
                }
            }
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            StaffViewPatientMedicalHistory patientHistory = new StaffViewPatientMedicalHistory(patientID, staffRole);
            patientHistory.Show();
            this.Hide();
        }
    }
}
