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
    public partial class StaffViewAppointments : Form
    {
        string connection = ConnectionString.connectionString;
        string userId = GlobalUserId.userId;
        private DataTable appointmentsTable;
        private string staffRole;

        public StaffViewAppointments(string staffRole)
        {
            this.staffRole = staffRole;

            InitializeComponent();
            LoadAppointmentRecord();
            DisplayLoggedInUser();
        }



        private void LoadAppointmentRecord() //loads past appointments on the grid view
        {
            string query = "SELECT a.appointment_ID, p.patient_Fname, p.patient_Lname, a.appointment_date, a.appointment_time, a.appointment_reason " +
                           "FROM Appointments a " +
                           "JOIN Patients p ON a.patient_ID = p.patient_ID " +
                           "WHERE datetime(a.appointment_date || ' ' || a.appointment_time) < datetime('now', 'localtime');";


            using (SQLiteConnection conn = new SQLiteConnection(connection))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                conn.Open();

                appointmentsTable = new DataTable();
                adapter.Fill(appointmentsTable);
                appointmentRecordGrid.DataSource = appointmentsTable;
                appointmentRecordGrid.ClearSelection();
            }

            if (appointmentRecordGrid.Columns.Contains("appointment_time"))
            {
                appointmentRecordGrid.Columns["appointment_time"].DefaultCellStyle.Format = "hh:mm tt";
            }

            appointmentRecordGrid.Columns["appointment_ID"].HeaderText = "Appointment ID";
            appointmentRecordGrid.Columns["patient_Fname"].HeaderText = "First Name";
            appointmentRecordGrid.Columns["patient_Lname"].HeaderText = "Last Name";
            appointmentRecordGrid.Columns["appointment_date"].HeaderText = "Date";
            appointmentRecordGrid.Columns["appointment_time"].HeaderText = "Time";
            appointmentRecordGrid.Columns["appointment_reason"].HeaderText = "Reason of appointment";
        }
        private void searchTxt_TextChanged(object sender, EventArgs e)//search function
        {
            string filterText = searchTxt.Text.Replace("'", "''"); // Escape single quotes

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

                appointmentRecordGrid.ClearSelection();
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
        private void backbtn_Click_1(object sender, EventArgs e)
        {
            StaffCreateAppointment staffCreateAppointment = new StaffCreateAppointment(staffRole);
            staffCreateAppointment.Show();
            this.Hide();
        }
    }
}
