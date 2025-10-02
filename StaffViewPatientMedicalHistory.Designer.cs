namespace Hospital_Management
{
    partial class StaffViewPatientMedicalHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffViewPatientMedicalHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backbtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.loggedInLbl = new System.Windows.Forms.Label();
            this.userIconImg = new System.Windows.Forms.Panel();
            this.patientLbl = new System.Windows.Forms.Label();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(878, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(148, 46);
            this.backbtn.TabIndex = 20;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(77, 5);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(44, 16);
            this.roleLbl.TabIndex = 19;
            this.roleLbl.Text = "(Role)";
            // 
            // loggedInLbl
            // 
            this.loggedInLbl.AutoSize = true;
            this.loggedInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLbl.Location = new System.Drawing.Point(74, 21);
            this.loggedInLbl.Name = "loggedInLbl";
            this.loggedInLbl.Size = new System.Drawing.Size(139, 31);
            this.loggedInLbl.TabIndex = 18;
            this.loggedInLbl.Text = "Username";
            // 
            // userIconImg
            // 
            this.userIconImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIconImg.BackgroundImage")));
            this.userIconImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIconImg.Location = new System.Drawing.Point(12, 12);
            this.userIconImg.Name = "userIconImg";
            this.userIconImg.Size = new System.Drawing.Size(56, 52);
            this.userIconImg.TabIndex = 17;
            // 
            // patientLbl
            // 
            this.patientLbl.AutoSize = true;
            this.patientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLbl.Location = new System.Drawing.Point(12, 137);
            this.patientLbl.Name = "patientLbl";
            this.patientLbl.Size = new System.Drawing.Size(177, 24);
            this.patientLbl.TabIndex = 22;
            this.patientLbl.Text = "Fname, Lname, (ID)";
            // 
            // patientGridView
            // 
            this.patientGridView.AllowUserToAddRows = false;
            this.patientGridView.AllowUserToDeleteRows = false;
            this.patientGridView.AllowUserToResizeRows = false;
            this.patientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.patientGridView.Location = new System.Drawing.Point(12, 164);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.ReadOnly = true;
            this.patientGridView.RowHeadersVisible = false;
            this.patientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientGridView.Size = new System.Drawing.Size(1014, 553);
            this.patientGridView.TabIndex = 23;
            this.patientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientGridView_CellContentClick_1);
            this.patientGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.patientGridView_CellFormatting_1);
            // 
            // StaffViewPatientMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.patientGridView);
            this.Controls.Add(this.patientLbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.loggedInLbl);
            this.Controls.Add(this.userIconImg);
            this.Name = "StaffViewPatientMedicalHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffViewPatientMedicalHistory";
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label loggedInLbl;
        private System.Windows.Forms.Panel userIconImg;
        private System.Windows.Forms.Label patientLbl;
        private System.Windows.Forms.DataGridView patientGridView;
    }
}