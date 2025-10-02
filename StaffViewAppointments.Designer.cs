namespace Hospital_Management
{
    partial class StaffViewAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffViewAppointments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backbtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.loggedInLbl = new System.Windows.Forms.Label();
            this.userIconImg = new System.Windows.Forms.Panel();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.searchByLbl = new System.Windows.Forms.Label();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.appointmentRecordGrid = new System.Windows.Forms.DataGridView();
            this.recordsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentRecordGrid)).BeginInit();
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
            // searchByComboBox
            // 
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "First name",
            "Last name"});
            this.searchByComboBox.Location = new System.Drawing.Point(336, 98);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchByComboBox.TabIndex = 47;
            // 
            // searchByLbl
            // 
            this.searchByLbl.AutoSize = true;
            this.searchByLbl.Location = new System.Drawing.Point(273, 101);
            this.searchByLbl.Name = "searchByLbl";
            this.searchByLbl.Size = new System.Drawing.Size(58, 13);
            this.searchByLbl.TabIndex = 46;
            this.searchByLbl.Text = "Search by:";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(13, 102);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(44, 13);
            this.searchLbl.TabIndex = 45;
            this.searchLbl.Text = "Search:";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(63, 97);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(167, 22);
            this.searchTxt.TabIndex = 44;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // appointmentRecordGrid
            // 
            this.appointmentRecordGrid.AllowUserToAddRows = false;
            this.appointmentRecordGrid.AllowUserToDeleteRows = false;
            this.appointmentRecordGrid.AllowUserToResizeRows = false;
            this.appointmentRecordGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentRecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentRecordGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentRecordGrid.Location = new System.Drawing.Point(12, 124);
            this.appointmentRecordGrid.Name = "appointmentRecordGrid";
            this.appointmentRecordGrid.ReadOnly = true;
            this.appointmentRecordGrid.RowHeadersVisible = false;
            this.appointmentRecordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentRecordGrid.Size = new System.Drawing.Size(1014, 593);
            this.appointmentRecordGrid.TabIndex = 43;
            // 
            // recordsLbl
            // 
            this.recordsLbl.AutoSize = true;
            this.recordsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsLbl.Location = new System.Drawing.Point(816, 92);
            this.recordsLbl.Name = "recordsLbl";
            this.recordsLbl.Size = new System.Drawing.Size(210, 25);
            this.recordsLbl.TabIndex = 48;
            this.recordsLbl.Text = "Appointment records";
            // 
            // StaffViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.recordsLbl);
            this.Controls.Add(this.searchByComboBox);
            this.Controls.Add(this.searchByLbl);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.appointmentRecordGrid);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.loggedInLbl);
            this.Controls.Add(this.userIconImg);
            this.Name = "StaffViewAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffViewAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentRecordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label loggedInLbl;
        private System.Windows.Forms.Panel userIconImg;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Label searchByLbl;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView appointmentRecordGrid;
        private System.Windows.Forms.Label recordsLbl;
    }
}