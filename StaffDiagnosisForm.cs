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
    public partial class StaffDiagnosisForm : Form
    {
        private int patientID;
        private string appointmentID;
        private string diagnosis;
        private string condition;
        private string staffRole;
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;

        public StaffDiagnosisForm(int patientID, string appointmentID, string diagnosis, string condition, string staffRole)
        {
            this.patientID = patientID;
            this.appointmentID = appointmentID;
            this.diagnosis = diagnosis;
            this.condition = condition;
            this.staffRole = staffRole;   //calling all variables from the medical history form

            InitializeComponent();
            DisplayLoggedInUser();
            DisableTextBoxes();
            LoadPatientDetails();

            diagnosisTxt.Text = diagnosis;
            conditionTxt.Text = condition; //if diagnosis and condition were already filled, auto fill them again, to then be edited
            ApplyEventHandler();
        }

        private void LoadPatientDetails() //loads patient data in the disabled boxes, which are not meant to be edited
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
                        fName = result.ToString(); //gets patient first name
                    }
                }

                using (SQLiteCommand cmd = new SQLiteCommand(mNameQuery, conn))
                {
                    cmd.Parameters.AddWithValue("patientId", patientID);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        mName = result.ToString(); //gets patient middle name(if has)
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
                        lName = result.ToString(); //gets patient last name
                    }
                }
            }

            patientIdTxt.Text = patientID.ToString();
            appointmentIdTxt.Text = appointmentID.ToString();   //fills disabled textboxes with the patient information
            fNameTxt.Text = fName.ToString();
            mNameTxt.Text = mName.ToString();
            lNametxt.Text = lName.ToString();
        }
        private void DisableTextBoxes() //disables text boxes that are not meant to be changed
        {
            patientIdTxt.Enabled = false;
            appointmentIdTxt.Enabled = false;
            fNameTxt.Enabled = false;
            mNameTxt.Enabled = false;
            lNametxt.Enabled = false;
        }

        

        private void ApplyEventHandler() //changes the event handler of the save button depending on two conditions
        {
            saveBtn.Click -= saveBtn_Click;
            saveBtn.Click -= EditDiagnosisEventHandler;

            if (!string.IsNullOrWhiteSpace(diagnosisTxt.Text))
            {
                saveBtn.Click += EditDiagnosisEventHandler; //if the diagnosis and condition fields were already filled, enable editing handler
            }
            else
            {
                saveBtn.Click += saveBtn_Click; //if they were empty, enable adding handler
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(diagnosisTxt.Text.Trim()) || string.IsNullOrWhiteSpace(conditionTxt.Text.Trim())) //checks if user filled all required fields
            {
                MessageBox.Show("Please fill out both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //function, which creates a new diagnosis
            AddDiagnosis(); 


            DialogResult result = MessageBox.Show("Diagnosis added successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(result == DialogResult.OK) //nicer transition back to the patient medical history form
            {
                StaffViewPatientMedicalHistory patientHistory = new StaffViewPatientMedicalHistory(patientID, staffRole);
                patientHistory.Show();
                this.Hide();
            }
        }
        private void EditDiagnosisEventHandler(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(diagnosisTxt.Text.Trim()) || string.IsNullOrWhiteSpace(conditionTxt.Text.Trim()))
            {
                MessageBox.Show("Please fill out both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //checks if user filled all required boxes
                return;
            }

            else if(diagnosisTxt.Text == diagnosis && conditionTxt.Text == condition) //if boxes remain the same
            {
                MessageBox.Show("No changes have been made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "UPDATE Diagnosis " +
                               "SET patient_diagnosis = @diagnosis, patient_condition = @condition " +
                               "WHERE patient_ID = @patientId AND appointment_ID = @appointmentId;"; //updates changes made to the diagnosis

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("diagnosis", diagnosisTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("condition", conditionTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("patientId", patientID);
                    cmd.Parameters.AddWithValue("appointmentId", appointmentID);

                    cmd.ExecuteNonQuery();
                }
            }

            DialogResult result = MessageBox.Show("Diagnosis updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK) //nicer transition back to the patient medical history form
            {
                StaffViewPatientMedicalHistory patientHistory = new StaffViewPatientMedicalHistory(patientID, staffRole);
                patientHistory.Show();
                this.Hide();
            }
        }
        private void AddDiagnosis() //adds the diagnosis to the Diagnosis table in the DB
        {
            string newDiagnosisId = "";
            bool isUnique = false;
            List<string> diagnosisId = new List<string>();

            //since PatientMedicalHistory table has the diagnosis_ID FK as Non-Null
            //it doesn't need to have a diagnosis necessarily

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "SELECT diagnosis_ID FROM Diagnosis";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        diagnosisId.Add(reader.GetString(0));  //reads all diagnosis IDs from the Diagnosis table in the list
                }

                while (!isUnique)
                {
                    newDiagnosisId = "DIA" + Guid.NewGuid().ToString("N").Substring(0, 6); //generates new ID
                    isUnique = !diagnosisId.Contains(newDiagnosisId); //checks if ID already exists, if not, break loop
                }

                string insertQuery = "INSERT INTO Diagnosis (diagnosis_ID, patient_ID, appointment_ID, patient_diagnosis, patient_condition)" +
                                     "VALUES(@diagnosisId, @patientId, @appointmentId, @diagnosis, @condition);";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("diagnosisId", newDiagnosisId); //newly generated ID
                    cmd.Parameters.AddWithValue("patientId", patientID);   //stored patient and appointment ID from the Medical History form
                    cmd.Parameters.AddWithValue("appointmentId", appointmentID);
                    cmd.Parameters.AddWithValue("diagnosis", diagnosisTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("condition", conditionTxt.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                string updateQuery = "UPDATE PatientMedicalHistory " +
                                     "SET diagnosis_ID = @diagnosisId " +
                                     "WHERE patient_ID = @patientId AND appointment_ID = @appointmentId;"; //after diagnosis is created
                                                                                                           //update PatientMedicalHistory table

                using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("diagnosisId", newDiagnosisId);
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
