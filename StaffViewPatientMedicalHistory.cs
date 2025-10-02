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
    public partial class StaffViewPatientMedicalHistory : Form
    {
        private int patientID;
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;
        private DataTable patientHistoryTable;
        private string staffRole;
        public StaffViewPatientMedicalHistory(int patientID, string staffRole)
        {
            this.patientID = patientID;
            this.staffRole = staffRole;

            InitializeComponent();
            DisplayLoggedInUser();
            PatientUpdateLabel();
            LoadPatientMedicalHistory();

            patientGridView.Columns["LabAction"].Visible = false;
            patientGridView.Columns["DiagnosisAction"].Visible = false;
        }

        private void LoadPatientMedicalHistory() //loads patient appointments, with lab result and diagnosis
        {
            patientHistoryTable = new DataTable();

            string query = "SELECT pmh.appointment_ID, d.patient_diagnosis, d.patient_condition, l.test_type, l.test_result " +
                           "FROM PatientMedicalHistory pmh LEFT JOIN Diagnosis d ON pmh.diagnosis_ID = d.diagnosis_ID " +
                           "LEFT JOIN LabTest l ON pmh.labTest_ID = l.labTest_ID WHERE pmh.patient_ID = @patientId";   //query which selects appointment_ID, joins Diagnosis and labtest tables
                                                                                                                       //selecting test_type, test_result, patient_diagnosis and patient_condition


            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("patientId", patientID);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd)) //adapter is used to convert a DB return value to a data table
                    {
                        adapter.Fill(patientHistoryTable); //datatable will then be used to fill a grid view
                    }
                }
            }
            //adds two new columns to the data grid, used for giving text to the button columns, they will be hidden
            patientHistoryTable.Columns.Add("LabAction", typeof(string));
            patientHistoryTable.Columns.Add("DiagnosisAction", typeof(string)); 

            foreach (DataRow row in patientHistoryTable.Rows) //loops through each row and applies the correct text to the last column
                                                              //example: if lab_test is null, last column text will be Add Lab test
            {
                row["LabAction"] = string.IsNullOrEmpty(row["test_type"]?.ToString()) ? "Add Lab Result" : "Edit Lab Result";
                row["DiagnosisAction"] = string.IsNullOrEmpty(row["patient_diagnosis"]?.ToString()) ? "Add Diagnosis" : "Edit Diagnosis";
            }

            patientGridView.DataSource = patientHistoryTable;

            patientGridView.Columns["appointment_ID"].HeaderText = "Appointment ID";
            patientGridView.Columns["test_type"].HeaderText = "Lab test";
            patientGridView.Columns["test_result"].HeaderText = "Lab Test result";
            patientGridView.Columns["patient_diagnosis"].HeaderText = "Diagnosis";
            patientGridView.Columns["patient_condition"].HeaderText = "Condition";

            
            DataGridViewButtonColumn labBtnCol = new DataGridViewButtonColumn //adds a lab result button column
            {
                HeaderText = "Lab Result",
                Name = "labBtn",
                Text = "",
                UseColumnTextForButtonValue = false
            };
            patientGridView.Columns.Add(labBtnCol);

            
            DataGridViewButtonColumn diagnosisBtnCol = new DataGridViewButtonColumn //adds a diagnosis button column
            {
                HeaderText = "Diagnosis",
                Name = "diagnosisBtn",
                Text = "",
                UseColumnTextForButtonValue = false
            };
            patientGridView.Columns.Add(diagnosisBtnCol);
        }
        private void PatientUpdateLabel()//displays patient First and Last name + (ID), above the grid
        {
            string fName = "", lName = "";

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string nameQuery = "SELECT patient_Fname, patient_Lname FROM Patients WHERE patient_ID = @patientId";
                using (SQLiteCommand cmd = new SQLiteCommand(nameQuery, conn))
                {
                    cmd.Parameters.AddWithValue("patientId", patientID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fName = reader["patient_Fname"].ToString();
                            lName = reader["patient_Lname"].ToString();
                        }
                    }
                }
            }

            patientLbl.Text = $"{fName} {lName}, ({patientID})";
        }
        private void patientGridView_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return; //ignores header rows

            if (patientGridView.Columns[e.ColumnIndex].Name == "labBtn")
            {
                e.Value = patientGridView.Rows[e.RowIndex].Cells["LabAction"].Value; //it sets the button text to the extra added columns, which are hidden
            }
            else if (patientGridView.Columns[e.ColumnIndex].Name == "diagnosisBtn")
            {
                e.Value = patientGridView.Rows[e.RowIndex].Cells["DiagnosisAction"].Value;
            }
        }
        private void patientGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e) //clicking on the grid button event lab/diagnosis
        {
            if (e.RowIndex < 0) return; //ignores header row

            string appointmentId = patientGridView.Rows[e.RowIndex].Cells["appointment_ID"].Value?.ToString(); //gets appointment ID of selected row

            if (patientGridView.Columns[e.ColumnIndex].Name == "labBtn") //if the clicked cell is the lab button
            {
                if (staffRole == "Nurse") //deny access to lab test add/edit if logged in as nurse  
                {
                    MessageBox.Show("You do not have permission to edit lab details.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    string type = patientGridView.Rows[e.RowIndex].Cells["test_type"]?.Value?.ToString() ?? "";
                    string labTestResult = patientGridView.Rows[e.RowIndex].Cells["test_result"]?.Value?.ToString() ?? ""; //store value of the lab_test and lab_result, to be filled in the lab form

                    StaffLabResult addLabresult = new StaffLabResult(patientID, appointmentId, type, labTestResult, staffRole); //constructor holding all variables to then be auto filled in the lab form
                    addLabresult.Show();
                    this.Hide();
                }
            }

            if (patientGridView.Columns[e.ColumnIndex].Name == "diagnosisBtn") //if the clicked cell is a diagnosis button
            {
                if (staffRole == "Nurse") //deny access to nurse
                {
                    MessageBox.Show("You do not have permission to edit diagnosis details.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string diagnosis = patientGridView.Rows[e.RowIndex].Cells["patient_diagnosis"]?.Value?.ToString() ?? "";
                    string condition = patientGridView.Rows[e.RowIndex].Cells["patient_condition"]?.Value?.ToString() ?? ""; //variables used in the next form

                    new StaffDiagnosisForm(patientID, appointmentId, diagnosis, condition, staffRole).Show(); //constructor holding all variables to then be auto filled in the diagnosis form
                    this.Hide();
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
                        {
                            loggedInLbl.Text = "Unknown user";
                        }
                    }
                }
            }
        }
        private void backbtn_Click_1(object sender, EventArgs e)
        {
            new StaffViewPatients(staffRole).Show();
            this.Hide();
        }
    }
}
