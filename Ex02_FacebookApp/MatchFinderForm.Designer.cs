namespace Ex02_FacebookApp
{
    public partial class MatchFinderForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label nameLabel;
            this.labelMatchesTitleReadOnly = new System.Windows.Forms.Label();
            this.panelMatchDetails = new System.Windows.Forms.Panel();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.labelMatchMaxAge = new System.Windows.Forms.Label();
            this.labelMatchMinAge = new System.Windows.Forms.Label();
            this.comboBoxMatchGender = new System.Windows.Forms.ComboBox();
            this.labelMatchGender = new System.Windows.Forms.Label();
            this.labelMatchQuestion = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panelMatchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(11, 172);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(11, 136);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // labelMatchesTitleReadOnly
            // 
            this.labelMatchesTitleReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMatchesTitleReadOnly.AutoSize = true;
            this.labelMatchesTitleReadOnly.Location = new System.Drawing.Point(403, 154);
            this.labelMatchesTitleReadOnly.Name = "labelMatchesTitleReadOnly";
            this.labelMatchesTitleReadOnly.Size = new System.Drawing.Size(74, 20);
            this.labelMatchesTitleReadOnly.TabIndex = 17;
            this.labelMatchesTitleReadOnly.Text = "Matches:";
            // 
            // panelMatchDetails
            // 
            this.panelMatchDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMatchDetails.Controls.Add(birthdayLabel);
            this.panelMatchDetails.Controls.Add(this.birthdayTextBox);
            this.panelMatchDetails.Controls.Add(nameLabel);
            this.panelMatchDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelMatchDetails.Controls.Add(this.nameTextBox);
            this.panelMatchDetails.Location = new System.Drawing.Point(631, 185);
            this.panelMatchDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMatchDetails.Name = "panelMatchDetails";
            this.panelMatchDetails.Size = new System.Drawing.Size(306, 205);
            this.panelMatchDetails.TabIndex = 20;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(129, 169);
            this.birthdayTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(163, 26);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.friendListBindingSource;
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.membersBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(24, 10);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(112, 101);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(129, 132);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(163, 26);
            this.nameTextBox.TabIndex = 5;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxMatches.DataSource = this.friendListBindingSource;
            this.listBoxMatches.DisplayMember = "Name";
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 20;
            this.listBoxMatches.Location = new System.Drawing.Point(324, 185);
            this.listBoxMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(234, 204);
            this.listBoxMatches.TabIndex = 19;
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.Location = new System.Drawing.Point(53, 349);
            this.buttonFindMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindMatch.Name = "buttonFindMatch";
            this.buttonFindMatch.Size = new System.Drawing.Size(205, 41);
            this.buttonFindMatch.TabIndex = 18;
            this.buttonFindMatch.Text = "Find me a match";
            this.buttonFindMatch.UseVisualStyleBackColor = true;
            this.buttonFindMatch.Click += new System.EventHandler(this.ButtonFindMatch_Click);
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(201, 284);
            this.numericUpDownMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownMaxAge.TabIndex = 16;
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(201, 239);
            this.numericUpDownMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownMinAge.TabIndex = 15;
            // 
            // labelMatchMaxAge
            // 
            this.labelMatchMaxAge.AutoSize = true;
            this.labelMatchMaxAge.Location = new System.Drawing.Point(49, 284);
            this.labelMatchMaxAge.Name = "labelMatchMaxAge";
            this.labelMatchMaxAge.Size = new System.Drawing.Size(111, 20);
            this.labelMatchMaxAge.TabIndex = 14;
            this.labelMatchMaxAge.Text = "Maximum age:";
            // 
            // labelMatchMinAge
            // 
            this.labelMatchMinAge.AutoSize = true;
            this.labelMatchMinAge.Location = new System.Drawing.Point(49, 239);
            this.labelMatchMinAge.Name = "labelMatchMinAge";
            this.labelMatchMinAge.Size = new System.Drawing.Size(107, 20);
            this.labelMatchMinAge.TabIndex = 13;
            this.labelMatchMinAge.Text = "Minimum age:";
            // 
            // comboBoxMatchGender
            // 
            this.comboBoxMatchGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatchGender.FormattingEnabled = true;
            this.comboBoxMatchGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.comboBoxMatchGender.Location = new System.Drawing.Point(137, 189);
            this.comboBoxMatchGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMatchGender.Name = "comboBoxMatchGender";
            this.comboBoxMatchGender.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMatchGender.TabIndex = 12;
            // 
            // labelMatchGender
            // 
            this.labelMatchGender.AutoSize = true;
            this.labelMatchGender.Location = new System.Drawing.Point(49, 192);
            this.labelMatchGender.Name = "labelMatchGender";
            this.labelMatchGender.Size = new System.Drawing.Size(67, 20);
            this.labelMatchGender.TabIndex = 11;
            this.labelMatchGender.Text = "Gender:";
            // 
            // labelMatchQuestion
            // 
            this.labelMatchQuestion.AutoSize = true;
            this.labelMatchQuestion.Location = new System.Drawing.Point(45, 145);
            this.labelMatchQuestion.Name = "labelMatchQuestion";
            this.labelMatchQuestion.Size = new System.Drawing.Size(213, 20);
            this.labelMatchQuestion.TabIndex = 10;
            this.labelMatchQuestion.Text = "What Are You Interested In?";
            // 
            // MatchFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 548);
            this.Controls.Add(this.labelMatchesTitleReadOnly);
            this.Controls.Add(this.panelMatchDetails);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.buttonFindMatch);
            this.Controls.Add(this.numericUpDownMaxAge);
            this.Controls.Add(this.numericUpDownMinAge);
            this.Controls.Add(this.labelMatchMaxAge);
            this.Controls.Add(this.labelMatchMinAge);
            this.Controls.Add(this.comboBoxMatchGender);
            this.Controls.Add(this.labelMatchGender);
            this.Controls.Add(this.labelMatchQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MatchFinderForm";
            this.Text = "Match Finder";
            this.Controls.SetChildIndex(this.labelMatchQuestion, 0);
            this.Controls.SetChildIndex(this.labelMatchGender, 0);
            this.Controls.SetChildIndex(this.comboBoxMatchGender, 0);
            this.Controls.SetChildIndex(this.labelMatchMinAge, 0);
            this.Controls.SetChildIndex(this.labelMatchMaxAge, 0);
            this.Controls.SetChildIndex(this.numericUpDownMinAge, 0);
            this.Controls.SetChildIndex(this.numericUpDownMaxAge, 0);
            this.Controls.SetChildIndex(this.buttonFindMatch, 0);
            this.Controls.SetChildIndex(this.listBoxMatches, 0);
            this.Controls.SetChildIndex(this.panelMatchDetails, 0);
            this.Controls.SetChildIndex(this.labelMatchesTitleReadOnly, 0);
            this.panelMatchDetails.ResumeLayout(false);
            this.panelMatchDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMatchesTitleReadOnly;
        private System.Windows.Forms.Panel panelMatchDetails;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.Button buttonFindMatch;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAge;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAge;
        private System.Windows.Forms.Label labelMatchMaxAge;
        private System.Windows.Forms.Label labelMatchMinAge;
        private System.Windows.Forms.ComboBox comboBoxMatchGender;
        private System.Windows.Forms.Label labelMatchGender;
        private System.Windows.Forms.Label labelMatchQuestion;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.BindingSource friendListBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}