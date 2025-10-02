namespace Hospital_Management
{
    partial class StaffViewPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffViewPatients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roleLbl = new System.Windows.Forms.Label();
            this.loggedInLbl = new System.Windows.Forms.Label();
            this.userIconImg = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.mNameTxt = new System.Windows.Forms.TextBox();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.mNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchByLbl = new System.Windows.Forms.Label();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.applyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(77, 5);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(44, 16);
            this.roleLbl.TabIndex = 15;
            this.roleLbl.Text = "(Role)";
            // 
            // loggedInLbl
            // 
            this.loggedInLbl.AutoSize = true;
            this.loggedInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLbl.Location = new System.Drawing.Point(74, 21);
            this.loggedInLbl.Name = "loggedInLbl";
            this.loggedInLbl.Size = new System.Drawing.Size(139, 31);
            this.loggedInLbl.TabIndex = 14;
            this.loggedInLbl.Text = "Username";
            // 
            // userIconImg
            // 
            this.userIconImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIconImg.BackgroundImage")));
            this.userIconImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIconImg.Location = new System.Drawing.Point(12, 12);
            this.userIconImg.Name = "userIconImg";
            this.userIconImg.Size = new System.Drawing.Size(56, 52);
            this.userIconImg.TabIndex = 13;
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
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
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
            this.patientGridView.Location = new System.Drawing.Point(12, 95);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.ReadOnly = true;
            this.patientGridView.RowHeadersVisible = false;
            this.patientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientGridView.Size = new System.Drawing.Size(770, 593);
            this.patientGridView.TabIndex = 17;
            this.patientGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientGridView_CellContentDoubleClick);
            this.patientGridView.SelectionChanged += new System.EventHandler(this.patientGridView_SelectionChanged);
            // 
            // fNameTxt
            // 
            this.fNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTxt.Location = new System.Drawing.Point(816, 134);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(188, 22);
            this.fNameTxt.TabIndex = 18;
            // 
            // mNameTxt
            // 
            this.mNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNameTxt.Location = new System.Drawing.Point(816, 190);
            this.mNameTxt.Name = "mNameTxt";
            this.mNameTxt.Size = new System.Drawing.Size(188, 22);
            this.mNameTxt.TabIndex = 19;
            // 
            // lNameTxt
            // 
            this.lNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTxt.Location = new System.Drawing.Point(816, 246);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(188, 22);
            this.lNameTxt.TabIndex = 21;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(816, 411);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(188, 22);
            this.phoneTxt.TabIndex = 24;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(816, 464);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(188, 22);
            this.emailTxt.TabIndex = 25;
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(812, 111);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(86, 20);
            this.fNameLbl.TabIndex = 26;
            this.fNameLbl.Text = "First Name";
            // 
            // mNameLbl
            // 
            this.mNameLbl.AutoSize = true;
            this.mNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNameLbl.Location = new System.Drawing.Point(812, 167);
            this.mNameLbl.Name = "mNameLbl";
            this.mNameLbl.Size = new System.Drawing.Size(200, 20);
            this.mNameLbl.TabIndex = 27;
            this.mNameLbl.Text = "Middle Name (If applicable)";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(812, 223);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(86, 20);
            this.lNameLbl.TabIndex = 28;
            this.lNameLbl.Text = "Last Name";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(812, 277);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(63, 20);
            this.genderLbl.TabIndex = 29;
            this.genderLbl.Text = "Gender";
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.Location = new System.Drawing.Point(812, 329);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(97, 20);
            this.dobLbl.TabIndex = 30;
            this.dobLbl.Text = "Date of birth";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(812, 388);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(142, 20);
            this.phoneLbl.TabIndex = 31;
            this.phoneLbl.Text = "Telephone number";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(812, 441);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(48, 20);
            this.emailLbl.TabIndex = 32;
            this.emailLbl.Text = "Email";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderComboBox.Location = new System.Drawing.Point(816, 300);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(188, 21);
            this.genderComboBox.TabIndex = 34;
            // 
            // dobPicker
            // 
            this.dobPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.CustomFormat = "dd/MM/yyyy";
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobPicker.Location = new System.Drawing.Point(816, 352);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(188, 22);
            this.dobPicker.TabIndex = 35;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(854, 655);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(114, 33);
            this.deleteBtn.TabIndex = 36;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(854, 556);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(114, 33);
            this.editBtn.TabIndex = 37;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(854, 504);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(114, 33);
            this.addBtn.TabIndex = 38;
            this.addBtn.Text = "New";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(339, 67);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(167, 22);
            this.searchTxt.TabIndex = 39;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(289, 72);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(44, 13);
            this.searchLbl.TabIndex = 40;
            this.searchLbl.Text = "Search:";
            // 
            // searchByLbl
            // 
            this.searchByLbl.AutoSize = true;
            this.searchByLbl.Location = new System.Drawing.Point(540, 72);
            this.searchByLbl.Name = "searchByLbl";
            this.searchByLbl.Size = new System.Drawing.Size(58, 13);
            this.searchByLbl.TabIndex = 41;
            this.searchByLbl.Text = "Search by:";
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "ID",
            "First name",
            "Last name"});
            this.searchByComboBox.Location = new System.Drawing.Point(603, 69);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchByComboBox.TabIndex = 42;
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.applyBtn.FlatAppearance.BorderSize = 0;
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(854, 606);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(114, 33);
            this.applyBtn.TabIndex = 43;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // StaffViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.searchByComboBox);
            this.Controls.Add(this.searchByLbl);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.lNameLbl);
            this.Controls.Add(this.mNameLbl);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.lNameTxt);
            this.Controls.Add(this.mNameTxt);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.patientGridView);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.loggedInLbl);
            this.Controls.Add(this.userIconImg);
            this.Name = "StaffViewPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffViewPatients";
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label loggedInLbl;
        private System.Windows.Forms.Panel userIconImg;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.TextBox mNameTxt;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label mNameLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label searchByLbl;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Button applyBtn;
    }
}