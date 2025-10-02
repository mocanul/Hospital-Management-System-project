namespace Hospital_Management
{
    partial class AdminViewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBtn = new System.Windows.Forms.Button();
            this.loggedInLbl = new System.Windows.Forms.Label();
            this.userIconImg = new System.Windows.Forms.Panel();
            this.staffGridView = new System.Windows.Forms.DataGridView();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.mNameTxt = new System.Windows.Forms.TextBox();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.phoneNumTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.applyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.mNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneNumLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(878, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(148, 46);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // loggedInLbl
            // 
            this.loggedInLbl.AutoSize = true;
            this.loggedInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLbl.Location = new System.Drawing.Point(74, 21);
            this.loggedInLbl.Name = "loggedInLbl";
            this.loggedInLbl.Size = new System.Drawing.Size(139, 31);
            this.loggedInLbl.TabIndex = 10;
            this.loggedInLbl.Text = "Username";
            // 
            // userIconImg
            // 
            this.userIconImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIconImg.BackgroundImage")));
            this.userIconImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIconImg.Location = new System.Drawing.Point(12, 12);
            this.userIconImg.Name = "userIconImg";
            this.userIconImg.Size = new System.Drawing.Size(56, 52);
            this.userIconImg.TabIndex = 9;
            // 
            // staffGridView
            // 
            this.staffGridView.AllowUserToAddRows = false;
            this.staffGridView.AllowUserToDeleteRows = false;
            this.staffGridView.AllowUserToResizeRows = false;
            this.staffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.staffGridView.Location = new System.Drawing.Point(25, 134);
            this.staffGridView.Name = "staffGridView";
            this.staffGridView.ReadOnly = true;
            this.staffGridView.RowHeadersVisible = false;
            this.staffGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffGridView.Size = new System.Drawing.Size(985, 324);
            this.staffGridView.TabIndex = 11;
            this.staffGridView.SelectionChanged += new System.EventHandler(this.staffGridView_SelectionChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(80, 112);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(163, 20);
            this.searchTxt.TabIndex = 12;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "ID",
            "First Name",
            "Last Name"});
            this.searchComboBox.Location = new System.Drawing.Point(348, 111);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Search by:";
            // 
            // fNameTxt
            // 
            this.fNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTxt.Location = new System.Drawing.Point(25, 498);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(188, 22);
            this.fNameTxt.TabIndex = 16;
            // 
            // mNameTxt
            // 
            this.mNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNameTxt.Location = new System.Drawing.Point(25, 563);
            this.mNameTxt.Name = "mNameTxt";
            this.mNameTxt.Size = new System.Drawing.Size(188, 22);
            this.mNameTxt.TabIndex = 17;
            // 
            // lNameTxt
            // 
            this.lNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTxt.Location = new System.Drawing.Point(25, 636);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(188, 22);
            this.lNameTxt.TabIndex = 18;
            // 
            // phoneNumTxt
            // 
            this.phoneNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumTxt.Location = new System.Drawing.Point(638, 563);
            this.phoneNumTxt.Name = "phoneNumTxt";
            this.phoneNumTxt.Size = new System.Drawing.Size(188, 22);
            this.phoneNumTxt.TabIndex = 19;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(638, 498);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(188, 22);
            this.emailTxt.TabIndex = 21;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(303, 563);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(255, 22);
            this.startDatePicker.TabIndex = 22;
            // 
            // dobPicker
            // 
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Location = new System.Drawing.Point(303, 498);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(255, 22);
            this.dobPicker.TabIndex = 23;
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.applyBtn.FlatAppearance.BorderSize = 0;
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(855, 551);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(155, 43);
            this.applyBtn.TabIndex = 24;
            this.applyBtn.Text = "Apply changes";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(855, 624);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(155, 43);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(855, 479);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(155, 41);
            this.editBtn.TabIndex = 26;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(22, 479);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(72, 16);
            this.fNameLbl.TabIndex = 27;
            this.fNameLbl.Text = "First Name";
            // 
            // mNameLbl
            // 
            this.mNameLbl.AutoSize = true;
            this.mNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNameLbl.Location = new System.Drawing.Point(24, 544);
            this.mNameLbl.Name = "mNameLbl";
            this.mNameLbl.Size = new System.Drawing.Size(88, 16);
            this.mNameLbl.TabIndex = 28;
            this.mNameLbl.Text = "Middle Name";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(24, 617);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(72, 16);
            this.lNameLbl.TabIndex = 29;
            this.lNameLbl.Text = "Last Name";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(635, 479);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(94, 16);
            this.emailLbl.TabIndex = 30;
            this.emailLbl.Text = "Email address";
            // 
            // phoneNumLbl
            // 
            this.phoneNumLbl.AutoSize = true;
            this.phoneNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLbl.Location = new System.Drawing.Point(635, 544);
            this.phoneNumLbl.Name = "phoneNumLbl";
            this.phoneNumLbl.Size = new System.Drawing.Size(94, 16);
            this.phoneNumLbl.TabIndex = 31;
            this.phoneNumLbl.Text = "Phone number";
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(635, 617);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(62, 16);
            this.roleLbl.TabIndex = 32;
            this.roleLbl.Text = "Job Role";
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.Location = new System.Drawing.Point(300, 479);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(78, 16);
            this.dobLbl.TabIndex = 33;
            this.dobLbl.Text = "Date of birth";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLbl.Location = new System.Drawing.Point(300, 544);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(66, 16);
            this.startDateLbl.TabIndex = 34;
            this.startDateLbl.Text = "Start Date";
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Receptionist",
            "Nurse",
            "Doctor"});
            this.roleComboBox.Location = new System.Drawing.Point(638, 638);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(188, 24);
            this.roleComboBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "(Admin)";
            // 
            // AdminViewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.startDateLbl);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.phoneNumLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.lNameLbl);
            this.Controls.Add(this.mNameLbl);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.phoneNumTxt);
            this.Controls.Add(this.lNameTxt);
            this.Controls.Add(this.mNameTxt);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.staffGridView);
            this.Controls.Add(this.loggedInLbl);
            this.Controls.Add(this.userIconImg);
            this.Controls.Add(this.backBtn);
            this.Name = "AdminViewStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminViewStaff";
            ((System.ComponentModel.ISupportInitialize)(this.staffGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label loggedInLbl;
        private System.Windows.Forms.Panel userIconImg;
        private System.Windows.Forms.DataGridView staffGridView;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.TextBox mNameTxt;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.TextBox phoneNumTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label mNameLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneNumLbl;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label3;
    }
}