namespace Hospital_Management
{
    partial class StaffHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHome));
            this.patientListBtn = new System.Windows.Forms.Button();
            this.appointmentListBtn = new System.Windows.Forms.Button();
            this.userIconImg = new System.Windows.Forms.Panel();
            this.loggedInLbl = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.patientsLbl = new System.Windows.Forms.Label();
            this.appointmentsLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientListBtn
            // 
            this.patientListBtn.BackColor = System.Drawing.Color.Transparent;
            this.patientListBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patientListBtn.BackgroundImage")));
            this.patientListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patientListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientListBtn.FlatAppearance.BorderSize = 0;
            this.patientListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.patientListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.patientListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientListBtn.Location = new System.Drawing.Point(300, 293);
            this.patientListBtn.Name = "patientListBtn";
            this.patientListBtn.Size = new System.Drawing.Size(175, 175);
            this.patientListBtn.TabIndex = 0;
            this.patientListBtn.UseVisualStyleBackColor = false;
            this.patientListBtn.Click += new System.EventHandler(this.patientListBtn_Click);
            // 
            // appointmentListBtn
            // 
            this.appointmentListBtn.BackColor = System.Drawing.Color.Transparent;
            this.appointmentListBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appointmentListBtn.BackgroundImage")));
            this.appointmentListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appointmentListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointmentListBtn.FlatAppearance.BorderSize = 0;
            this.appointmentListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.appointmentListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.appointmentListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentListBtn.Location = new System.Drawing.Point(546, 293);
            this.appointmentListBtn.Name = "appointmentListBtn";
            this.appointmentListBtn.Size = new System.Drawing.Size(175, 175);
            this.appointmentListBtn.TabIndex = 2;
            this.appointmentListBtn.UseVisualStyleBackColor = false;
            this.appointmentListBtn.Click += new System.EventHandler(this.appointmentListBtn_Click);
            // 
            // userIconImg
            // 
            this.userIconImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIconImg.BackgroundImage")));
            this.userIconImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIconImg.Location = new System.Drawing.Point(12, 12);
            this.userIconImg.Name = "userIconImg";
            this.userIconImg.Size = new System.Drawing.Size(56, 52);
            this.userIconImg.TabIndex = 4;
            // 
            // loggedInLbl
            // 
            this.loggedInLbl.AutoSize = true;
            this.loggedInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLbl.Location = new System.Drawing.Point(74, 21);
            this.loggedInLbl.Name = "loggedInLbl";
            this.loggedInLbl.Size = new System.Drawing.Size(139, 31);
            this.loggedInLbl.TabIndex = 5;
            this.loggedInLbl.Text = "Username";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(878, 18);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(148, 46);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // patientsLbl
            // 
            this.patientsLbl.AutoSize = true;
            this.patientsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsLbl.Location = new System.Drawing.Point(344, 258);
            this.patientsLbl.Name = "patientsLbl";
            this.patientsLbl.Size = new System.Drawing.Size(67, 20);
            this.patientsLbl.TabIndex = 9;
            this.patientsLbl.Text = "Patients";
            // 
            // appointmentsLbl
            // 
            this.appointmentsLbl.AutoSize = true;
            this.appointmentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLbl.Location = new System.Drawing.Point(587, 258);
            this.appointmentsLbl.Name = "appointmentsLbl";
            this.appointmentsLbl.Size = new System.Drawing.Size(108, 20);
            this.appointmentsLbl.TabIndex = 10;
            this.appointmentsLbl.Text = "Appointments";
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(77, 5);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(44, 16);
            this.roleLbl.TabIndex = 12;
            this.roleLbl.Text = "(Role)";
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.appointmentsLbl);
            this.Controls.Add(this.patientsLbl);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.loggedInLbl);
            this.Controls.Add(this.userIconImg);
            this.Controls.Add(this.appointmentListBtn);
            this.Controls.Add(this.patientListBtn);
            this.Name = "StaffHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patientListBtn;
        private System.Windows.Forms.Button appointmentListBtn;
        private System.Windows.Forms.Panel userIconImg;
        private System.Windows.Forms.Label loggedInLbl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label patientsLbl;
        private System.Windows.Forms.Label appointmentsLbl;
        private System.Windows.Forms.Label roleLbl;
    }
}