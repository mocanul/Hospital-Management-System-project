namespace Hospital_Management
{
    partial class PasswordChange
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.confirmNewPassTxt = new System.Windows.Forms.TextBox();
            this.passChangeLbl2 = new System.Windows.Forms.Label();
            this.passChangeLbl = new System.Windows.Forms.Label();
            this.newPassTxt = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.changePassBtn);
            this.loginPanel.Controls.Add(this.confirmNewPassTxt);
            this.loginPanel.Controls.Add(this.passChangeLbl2);
            this.loginPanel.Controls.Add(this.passChangeLbl);
            this.loginPanel.Controls.Add(this.newPassTxt);
            this.loginPanel.Location = new System.Drawing.Point(369, 247);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(308, 250);
            this.loginPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "First time logging in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter a secure password";
            // 
            // changePassBtn
            // 
            this.changePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changePassBtn.Location = new System.Drawing.Point(27, 195);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(256, 35);
            this.changePassBtn.TabIndex = 4;
            this.changePassBtn.Text = "Change";
            this.changePassBtn.UseVisualStyleBackColor = false;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // confirmNewPassTxt
            // 
            this.confirmNewPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPassTxt.Location = new System.Drawing.Point(27, 160);
            this.confirmNewPassTxt.Name = "confirmNewPassTxt";
            this.confirmNewPassTxt.Size = new System.Drawing.Size(256, 29);
            this.confirmNewPassTxt.TabIndex = 3;
            this.confirmNewPassTxt.UseSystemPasswordChar = true;
            // 
            // passChangeLbl2
            // 
            this.passChangeLbl2.AutoSize = true;
            this.passChangeLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passChangeLbl2.Location = new System.Drawing.Point(23, 133);
            this.passChangeLbl2.Name = "passChangeLbl2";
            this.passChangeLbl2.Size = new System.Drawing.Size(162, 24);
            this.passChangeLbl2.TabIndex = 2;
            this.passChangeLbl2.Text = "Confirm Password";
            // 
            // passChangeLbl
            // 
            this.passChangeLbl.AutoSize = true;
            this.passChangeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passChangeLbl.Location = new System.Drawing.Point(23, 74);
            this.passChangeLbl.Name = "passChangeLbl";
            this.passChangeLbl.Size = new System.Drawing.Size(136, 24);
            this.passChangeLbl.TabIndex = 1;
            this.passChangeLbl.Text = "New Password";
            // 
            // newPassTxt
            // 
            this.newPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTxt.Location = new System.Drawing.Point(27, 101);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.Size = new System.Drawing.Size(256, 29);
            this.newPassTxt.TabIndex = 0;
            this.newPassTxt.UseSystemPasswordChar = true;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1038, 729);
            this.Controls.Add(this.loginPanel);
            this.Name = "PasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordChange";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.TextBox confirmNewPassTxt;
        private System.Windows.Forms.Label passChangeLbl2;
        private System.Windows.Forms.Label passChangeLbl;
        private System.Windows.Forms.TextBox newPassTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}