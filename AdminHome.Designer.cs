namespace Hospital_Management
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.addStaffBtn = new System.Windows.Forms.Button();
            this.editStaffBtn = new System.Windows.Forms.Button();
            this.userIconImg = new System.Windows.Forms.Panel();
            this.loggedInLbl = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editStaffLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStaffBtn
            // 
            this.addStaffBtn.BackColor = System.Drawing.Color.Transparent;
            this.addStaffBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addStaffBtn.BackgroundImage")));
            this.addStaffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStaffBtn.FlatAppearance.BorderSize = 0;
            this.addStaffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addStaffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaffBtn.Location = new System.Drawing.Point(231, 278);
            this.addStaffBtn.Name = "addStaffBtn";
            this.addStaffBtn.Size = new System.Drawing.Size(200, 200);
            this.addStaffBtn.TabIndex = 0;
            this.addStaffBtn.UseVisualStyleBackColor = false;
            this.addStaffBtn.Click += new System.EventHandler(this.addStaffBtn_Click);
            // 
            // editStaffBtn
            // 
            this.editStaffBtn.BackColor = System.Drawing.Color.Transparent;
            this.editStaffBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editStaffBtn.BackgroundImage")));
            this.editStaffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editStaffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editStaffBtn.FlatAppearance.BorderSize = 0;
            this.editStaffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editStaffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStaffBtn.Location = new System.Drawing.Point(605, 278);
            this.editStaffBtn.Name = "editStaffBtn";
            this.editStaffBtn.Size = new System.Drawing.Size(200, 200);
            this.editStaffBtn.TabIndex = 1;
            this.editStaffBtn.UseVisualStyleBackColor = false;
            this.editStaffBtn.Click += new System.EventHandler(this.editStaffBtn_Click);
            // 
            // userIconImg
            // 
            this.userIconImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIconImg.BackgroundImage")));
            this.userIconImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIconImg.Location = new System.Drawing.Point(12, 12);
            this.userIconImg.Name = "userIconImg";
            this.userIconImg.Size = new System.Drawing.Size(56, 52);
            this.userIconImg.TabIndex = 5;
            // 
            // loggedInLbl
            // 
            this.loggedInLbl.AutoSize = true;
            this.loggedInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLbl.Location = new System.Drawing.Point(74, 21);
            this.loggedInLbl.Name = "loggedInLbl";
            this.loggedInLbl.Size = new System.Drawing.Size(139, 31);
            this.loggedInLbl.TabIndex = 6;
            this.loggedInLbl.Text = "Username";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(878, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(148, 46);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add new staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "(Admin)";
            // 
            // editStaffLbl
            // 
            this.editStaffLbl.AutoSize = true;
            this.editStaffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStaffLbl.Location = new System.Drawing.Point(660, 255);
            this.editStaffLbl.Name = "editStaffLbl";
            this.editStaffLbl.Size = new System.Drawing.Size(79, 20);
            this.editStaffLbl.TabIndex = 11;
            this.editStaffLbl.Text = "View staff";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.editStaffLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.loggedInLbl);
            this.Controls.Add(this.userIconImg);
            this.Controls.Add(this.editStaffBtn);
            this.Controls.Add(this.addStaffBtn);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStaffBtn;
        private System.Windows.Forms.Button editStaffBtn;
        private System.Windows.Forms.Panel userIconImg;
        private System.Windows.Forms.Label loggedInLbl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label editStaffLbl;
    }
}