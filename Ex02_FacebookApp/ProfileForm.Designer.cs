namespace Ex02_FacebookApp
{
    partial class ProfileForm
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
            this.comboBoxStatusesSort = new System.Windows.Forms.ComboBox();
            this.listViewUserStatuses = new System.Windows.Forms.ListView();
            this.textUserGender = new System.Windows.Forms.TextBox();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.textGenderReadOnly = new System.Windows.Forms.TextBox();
            this.textEmailReadOnly = new System.Windows.Forms.TextBox();
            this.textUserEmail = new System.Windows.Forms.TextBox();
            this.textUserFullName = new System.Windows.Forms.TextBox();
            this.textNameReadOnly = new System.Windows.Forms.TextBox();
            this.textBirthDayReadOnly = new System.Windows.Forms.TextBox();
            this.textUserBirthDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStatusesSort
            // 
            this.comboBoxStatusesSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxStatusesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusesSort.Items.AddRange(new object[] {
            "Upload Date - most recent",
            "Number of likes",
            "Number of comments"});
            this.comboBoxStatusesSort.Location = new System.Drawing.Point(29, 302);
            this.comboBoxStatusesSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatusesSort.Name = "comboBoxStatusesSort";
            this.comboBoxStatusesSort.Size = new System.Drawing.Size(221, 28);
            this.comboBoxStatusesSort.TabIndex = 26;
            this.comboBoxStatusesSort.Visible = false;
            // 
            // listViewUserStatuses
            // 
            this.listViewUserStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewUserStatuses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewUserStatuses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewUserStatuses.HideSelection = false;
            this.listViewUserStatuses.Location = new System.Drawing.Point(0, 317);
            this.listViewUserStatuses.Margin = new System.Windows.Forms.Padding(0);
            this.listViewUserStatuses.Name = "listViewUserStatuses";
            this.listViewUserStatuses.Size = new System.Drawing.Size(1152, 284);
            this.listViewUserStatuses.TabIndex = 24;
            this.listViewUserStatuses.UseCompatibleStateImageBehavior = false;
            this.listViewUserStatuses.View = System.Windows.Forms.View.Details;
            // 
            // textUserGender
            // 
            this.textUserGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserGender.Location = new System.Drawing.Point(323, 232);
            this.textUserGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserGender.Name = "textUserGender";
            this.textUserGender.Size = new System.Drawing.Size(256, 19);
            this.textUserGender.TabIndex = 23;
            this.textUserGender.Visible = false;
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(29, 105);
            this.pictureProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(147, 159);
            this.pictureProfile.TabIndex = 15;
            this.pictureProfile.TabStop = false;
            this.pictureProfile.Visible = false;
            // 
            // textGenderReadOnly
            // 
            this.textGenderReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textGenderReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGenderReadOnly.Location = new System.Drawing.Point(203, 232);
            this.textGenderReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textGenderReadOnly.Name = "textGenderReadOnly";
            this.textGenderReadOnly.ReadOnly = true;
            this.textGenderReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textGenderReadOnly.TabIndex = 22;
            this.textGenderReadOnly.Text = "Gender:";
            this.textGenderReadOnly.Visible = false;
            // 
            // textEmailReadOnly
            // 
            this.textEmailReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textEmailReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailReadOnly.Location = new System.Drawing.Point(203, 192);
            this.textEmailReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmailReadOnly.Name = "textEmailReadOnly";
            this.textEmailReadOnly.ReadOnly = true;
            this.textEmailReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textEmailReadOnly.TabIndex = 18;
            this.textEmailReadOnly.Text = "Email:";
            this.textEmailReadOnly.Visible = false;
            // 
            // textUserEmail
            // 
            this.textUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserEmail.Location = new System.Drawing.Point(323, 192);
            this.textUserEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(256, 19);
            this.textUserEmail.TabIndex = 21;
            this.textUserEmail.Visible = false;
            // 
            // textUserFullName
            // 
            this.textUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserFullName.Location = new System.Drawing.Point(323, 115);
            this.textUserFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserFullName.Name = "textUserFullName";
            this.textUserFullName.Size = new System.Drawing.Size(256, 19);
            this.textUserFullName.TabIndex = 19;
            this.textUserFullName.Visible = false;
            // 
            // textNameReadOnly
            // 
            this.textNameReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textNameReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNameReadOnly.Location = new System.Drawing.Point(203, 115);
            this.textNameReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNameReadOnly.Name = "textNameReadOnly";
            this.textNameReadOnly.ReadOnly = true;
            this.textNameReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textNameReadOnly.TabIndex = 16;
            this.textNameReadOnly.Text = "Name:";
            this.textNameReadOnly.Visible = false;
            // 
            // textBirthDayReadOnly
            // 
            this.textBirthDayReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.textBirthDayReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBirthDayReadOnly.Location = new System.Drawing.Point(203, 152);
            this.textBirthDayReadOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBirthDayReadOnly.Name = "textBirthDayReadOnly";
            this.textBirthDayReadOnly.ReadOnly = true;
            this.textBirthDayReadOnly.Size = new System.Drawing.Size(100, 19);
            this.textBirthDayReadOnly.TabIndex = 17;
            this.textBirthDayReadOnly.Text = "Date Of Birth:";
            this.textBirthDayReadOnly.Visible = false;
            // 
            // textUserBirthDay
            // 
            this.textUserBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserBirthDay.Location = new System.Drawing.Point(323, 152);
            this.textUserBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUserBirthDay.Name = "textUserBirthDay";
            this.textUserBirthDay.Size = new System.Drawing.Size(256, 19);
            this.textUserBirthDay.TabIndex = 20;
            this.textUserBirthDay.Visible = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 602);
            this.Controls.Add(this.comboBoxStatusesSort);
            this.Controls.Add(this.listViewUserStatuses);
            this.Controls.Add(this.textUserGender);
            this.Controls.Add(this.pictureProfile);
            this.Controls.Add(this.textGenderReadOnly);
            this.Controls.Add(this.textEmailReadOnly);
            this.Controls.Add(this.textUserEmail);
            this.Controls.Add(this.textUserFullName);
            this.Controls.Add(this.textNameReadOnly);
            this.Controls.Add(this.textBirthDayReadOnly);
            this.Controls.Add(this.textUserBirthDay);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Controls.SetChildIndex(this.textUserBirthDay, 0);
            this.Controls.SetChildIndex(this.textBirthDayReadOnly, 0);
            this.Controls.SetChildIndex(this.textNameReadOnly, 0);
            this.Controls.SetChildIndex(this.textUserFullName, 0);
            this.Controls.SetChildIndex(this.textUserEmail, 0);
            this.Controls.SetChildIndex(this.textEmailReadOnly, 0);
            this.Controls.SetChildIndex(this.textGenderReadOnly, 0);
            this.Controls.SetChildIndex(this.pictureProfile, 0);
            this.Controls.SetChildIndex(this.textUserGender, 0);
            this.Controls.SetChildIndex(this.listViewUserStatuses, 0);
            this.Controls.SetChildIndex(this.comboBoxStatusesSort, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStatusesSort;
        private System.Windows.Forms.ListView listViewUserStatuses;
        private System.Windows.Forms.TextBox textUserGender;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.TextBox textGenderReadOnly;
        private System.Windows.Forms.TextBox textEmailReadOnly;
        private System.Windows.Forms.TextBox textUserEmail;
        private System.Windows.Forms.TextBox textUserFullName;
        private System.Windows.Forms.TextBox textNameReadOnly;
        private System.Windows.Forms.TextBox textBirthDayReadOnly;
        private System.Windows.Forms.TextBox textUserBirthDay;
    }
}