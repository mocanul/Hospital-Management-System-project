namespace Hospital_Management
{
    partial class StaffDiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDiagnosisForm));
            this.backbtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.loggedInLbl = new System.Windows.Forms.Label();
            this.userIconImg = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diagnosisLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conditionTxt = new System.Windows.Forms.RichTextBox();
            this.diagnosisTxt = new System.Windows.Forms.RichTextBox();
            this.userImg = new System.Windows.Forms.Panel();
            this.appointmentLbl = new System.Windows.Forms.Label();
            this.appointmentIdTxt = new System.Windows.Forms.TextBox();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.mName = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.lNametxt = new System.Windows.Forms.TextBox();
            this.mNameTxt = new System.Windows.Forms.TextBox();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.patientIdTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.diagnosisTitleLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.backbtn.TabIndex = 24;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(77, 5);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(44, 16);
            this.roleLbl.TabIndex = 23;
            this.roleLbl.Text = "(Role)";
            // 
            // loggedInLbl
            // 
            this.loggedInLbl.AutoSize = true;
            this.loggedInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLbl.Location = new System.Drawing.Point(74, 21);
            this.loggedInLbl.Name = "loggedInLbl";
            this.loggedInLbl.Size = new System.Drawing.Size(139, 31);
            this.loggedInLbl.TabIndex = 22;
            this.loggedInLbl.Text = "Username";
            // 
            // userIconImg
            // 
            this.userIconImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIconImg.BackgroundImage")));
            this.userIconImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIconImg.Location = new System.Drawing.Point(12, 12);
            this.userIconImg.Name = "userIconImg";
            this.userIconImg.Size = new System.Drawing.Size(56, 52);
            this.userIconImg.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.diagnosisLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.conditionTxt);
            this.panel1.Controls.Add(this.diagnosisTxt);
            this.panel1.Controls.Add(this.userImg);
            this.panel1.Controls.Add(this.appointmentLbl);
            this.panel1.Controls.Add(this.appointmentIdTxt);
            this.panel1.Controls.Add(this.lNameLbl);
            this.panel1.Controls.Add(this.mName);
            this.panel1.Controls.Add(this.fNameLbl);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.lNametxt);
            this.panel1.Controls.Add(this.mNameTxt);
            this.panel1.Controls.Add(this.fNameTxt);
            this.panel1.Controls.Add(this.patientIdTxt);
            this.panel1.Location = new System.Drawing.Point(159, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 403);
            this.panel1.TabIndex = 25;
            // 
            // diagnosisLbl
            // 
            this.diagnosisLbl.AutoSize = true;
            this.diagnosisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisLbl.Location = new System.Drawing.Point(33, 242);
            this.diagnosisLbl.Name = "diagnosisLbl";
            this.diagnosisLbl.Size = new System.Drawing.Size(68, 16);
            this.diagnosisLbl.TabIndex = 26;
            this.diagnosisLbl.Text = "Diagnosis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Condition";
            // 
            // conditionTxt
            // 
            this.conditionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionTxt.Location = new System.Drawing.Point(373, 261);
            this.conditionTxt.Name = "conditionTxt";
            this.conditionTxt.Size = new System.Drawing.Size(281, 96);
            this.conditionTxt.TabIndex = 24;
            this.conditionTxt.Text = "";
            // 
            // diagnosisTxt
            // 
            this.diagnosisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisTxt.Location = new System.Drawing.Point(36, 261);
            this.diagnosisTxt.Name = "diagnosisTxt";
            this.diagnosisTxt.Size = new System.Drawing.Size(281, 96);
            this.diagnosisTxt.TabIndex = 23;
            this.diagnosisTxt.Text = "";
            // 
            // userImg
            // 
            this.userImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userImg.BackgroundImage")));
            this.userImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userImg.Location = new System.Drawing.Point(512, 22);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(124, 109);
            this.userImg.TabIndex = 22;
            // 
            // appointmentLbl
            // 
            this.appointmentLbl.AutoSize = true;
            this.appointmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLbl.Location = new System.Drawing.Point(253, 67);
            this.appointmentLbl.Name = "appointmentLbl";
            this.appointmentLbl.Size = new System.Drawing.Size(98, 16);
            this.appointmentLbl.TabIndex = 9;
            this.appointmentLbl.Text = "Appointment ID";
            // 
            // appointmentIdTxt
            // 
            this.appointmentIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIdTxt.Location = new System.Drawing.Point(256, 86);
            this.appointmentIdTxt.Name = "appointmentIdTxt";
            this.appointmentIdTxt.Size = new System.Drawing.Size(176, 26);
            this.appointmentIdTxt.TabIndex = 8;
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(475, 158);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(72, 16);
            this.lNameLbl.TabIndex = 7;
            this.lNameLbl.Text = "Last Name";
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mName.Location = new System.Drawing.Point(253, 158);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(88, 16);
            this.mName.TabIndex = 6;
            this.mName.Text = "Middle Name";
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(33, 158);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(72, 16);
            this.fNameLbl.TabIndex = 5;
            this.fNameLbl.Text = "First Name";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.Location = new System.Drawing.Point(33, 67);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(64, 16);
            this.idLbl.TabIndex = 4;
            this.idLbl.Text = "Patient ID";
            // 
            // lNametxt
            // 
            this.lNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNametxt.Location = new System.Drawing.Point(478, 177);
            this.lNametxt.Name = "lNametxt";
            this.lNametxt.Size = new System.Drawing.Size(176, 26);
            this.lNametxt.TabIndex = 3;
            // 
            // mNameTxt
            // 
            this.mNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNameTxt.Location = new System.Drawing.Point(256, 177);
            this.mNameTxt.Name = "mNameTxt";
            this.mNameTxt.Size = new System.Drawing.Size(176, 26);
            this.mNameTxt.TabIndex = 2;
            // 
            // fNameTxt
            // 
            this.fNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTxt.Location = new System.Drawing.Point(36, 177);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(176, 26);
            this.fNameTxt.TabIndex = 1;
            // 
            // patientIdTxt
            // 
            this.patientIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTxt.Location = new System.Drawing.Point(36, 86);
            this.patientIdTxt.Name = "patientIdTxt";
            this.patientIdTxt.Size = new System.Drawing.Size(176, 26);
            this.patientIdTxt.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(431, 556);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(148, 46);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // diagnosisTitleLbl
            // 
            this.diagnosisTitleLbl.AutoSize = true;
            this.diagnosisTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosisTitleLbl.Location = new System.Drawing.Point(449, 115);
            this.diagnosisTitleLbl.Name = "diagnosisTitleLbl";
            this.diagnosisTitleLbl.Size = new System.Drawing.Size(120, 29);
            this.diagnosisTitleLbl.TabIndex = 27;
            this.diagnosisTitleLbl.Text = "Diagnosis";
            // 
            // StaffDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.diagnosisTitleLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.loggedInLbl);
            this.Controls.Add(this.userIconImg);
            this.Name = "StaffDiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDiagnosisForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label loggedInLbl;
        private System.Windows.Forms.Panel userIconImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label mName;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox lNametxt;
        private System.Windows.Forms.TextBox mNameTxt;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.TextBox patientIdTxt;
        private System.Windows.Forms.Label appointmentLbl;
        private System.Windows.Forms.TextBox appointmentIdTxt;
        private System.Windows.Forms.Label diagnosisLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox conditionTxt;
        private System.Windows.Forms.RichTextBox diagnosisTxt;
        private System.Windows.Forms.Panel userImg;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label diagnosisTitleLbl;
    }
}