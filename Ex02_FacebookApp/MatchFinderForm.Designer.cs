namespace Ex02_FacebookApp
{
    partial class MatchFinderForm
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
            this.labelMatchesTitleReadOnly = new System.Windows.Forms.Label();
            this.panelMatchDetails = new System.Windows.Forms.Panel();
            this.textBoxMatchFoundBday = new System.Windows.Forms.TextBox();
            this.textBoxMatchFoundGender = new System.Windows.Forms.TextBox();
            this.textBoxMatchFoundName = new System.Windows.Forms.TextBox();
            this.labelMatchFoundBday = new System.Windows.Forms.Label();
            this.labelMatchFoundGender = new System.Windows.Forms.Label();
            this.labelMatchFoundName = new System.Windows.Forms.Label();
            this.pictureBoxMatch = new System.Windows.Forms.PictureBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.labelMatchMaxAge = new System.Windows.Forms.Label();
            this.labelMatchMinAge = new System.Windows.Forms.Label();
            this.comboBoxMatchGender = new System.Windows.Forms.ComboBox();
            this.labelMatchGender = new System.Windows.Forms.Label();
            this.labelMatchQuestion = new System.Windows.Forms.Label();
            this.panelMatchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMatchesTitleReadOnly
            // 
            this.labelMatchesTitleReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMatchesTitleReadOnly.AutoSize = true;
            this.labelMatchesTitleReadOnly.Location = new System.Drawing.Point(552, 154);
            this.labelMatchesTitleReadOnly.Name = "labelMatchesTitleReadOnly";
            this.labelMatchesTitleReadOnly.Size = new System.Drawing.Size(74, 20);
            this.labelMatchesTitleReadOnly.TabIndex = 17;
            this.labelMatchesTitleReadOnly.Text = "Matches:";
            // 
            // panelMatchDetails
            // 
            this.panelMatchDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMatchDetails.Controls.Add(this.textBoxMatchFoundBday);
            this.panelMatchDetails.Controls.Add(this.textBoxMatchFoundGender);
            this.panelMatchDetails.Controls.Add(this.textBoxMatchFoundName);
            this.panelMatchDetails.Controls.Add(this.labelMatchFoundBday);
            this.panelMatchDetails.Controls.Add(this.labelMatchFoundGender);
            this.panelMatchDetails.Controls.Add(this.labelMatchFoundName);
            this.panelMatchDetails.Controls.Add(this.pictureBoxMatch);
            this.panelMatchDetails.Location = new System.Drawing.Point(900, 145);
            this.panelMatchDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMatchDetails.Name = "panelMatchDetails";
            this.panelMatchDetails.Size = new System.Drawing.Size(220, 245);
            this.panelMatchDetails.TabIndex = 20;
            // 
            // textBoxMatchFoundBday
            // 
            this.textBoxMatchFoundBday.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMatchFoundBday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundBday.Location = new System.Drawing.Point(93, 199);
            this.textBoxMatchFoundBday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatchFoundBday.Name = "textBoxMatchFoundBday";
            this.textBoxMatchFoundBday.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundBday.TabIndex = 6;
            // 
            // textBoxMatchFoundGender
            // 
            this.textBoxMatchFoundGender.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMatchFoundGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundGender.Location = new System.Drawing.Point(93, 162);
            this.textBoxMatchFoundGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatchFoundGender.Name = "textBoxMatchFoundGender";
            this.textBoxMatchFoundGender.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundGender.TabIndex = 5;
            // 
            // textBoxMatchFoundName
            // 
            this.textBoxMatchFoundName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxMatchFoundName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatchFoundName.Location = new System.Drawing.Point(93, 128);
            this.textBoxMatchFoundName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatchFoundName.Name = "textBoxMatchFoundName";
            this.textBoxMatchFoundName.Size = new System.Drawing.Size(124, 19);
            this.textBoxMatchFoundName.TabIndex = 4;
            // 
            // labelMatchFoundBday
            // 
            this.labelMatchFoundBday.AutoSize = true;
            this.labelMatchFoundBday.Location = new System.Drawing.Point(4, 199);
            this.labelMatchFoundBday.Name = "labelMatchFoundBday";
            this.labelMatchFoundBday.Size = new System.Drawing.Size(71, 20);
            this.labelMatchFoundBday.TabIndex = 3;
            this.labelMatchFoundBday.Text = "Birthday:";
            this.labelMatchFoundBday.Visible = false;
            // 
            // labelMatchFoundGender
            // 
            this.labelMatchFoundGender.AutoSize = true;
            this.labelMatchFoundGender.Location = new System.Drawing.Point(4, 162);
            this.labelMatchFoundGender.Name = "labelMatchFoundGender";
            this.labelMatchFoundGender.Size = new System.Drawing.Size(67, 20);
            this.labelMatchFoundGender.TabIndex = 2;
            this.labelMatchFoundGender.Text = "Gender:";
            this.labelMatchFoundGender.Visible = false;
            // 
            // labelMatchFoundName
            // 
            this.labelMatchFoundName.AutoSize = true;
            this.labelMatchFoundName.Location = new System.Drawing.Point(4, 128);
            this.labelMatchFoundName.Name = "labelMatchFoundName";
            this.labelMatchFoundName.Size = new System.Drawing.Size(55, 20);
            this.labelMatchFoundName.TabIndex = 1;
            this.labelMatchFoundName.Text = "Name:";
            this.labelMatchFoundName.Visible = false;
            // 
            // pictureBoxMatch
            // 
            this.pictureBoxMatch.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMatch.Name = "pictureBoxMatch";
            this.pictureBoxMatch.Size = new System.Drawing.Size(125, 110);
            this.pictureBoxMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMatch.TabIndex = 0;
            this.pictureBoxMatch.TabStop = false;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 20;
            this.listBoxMatches.Location = new System.Drawing.Point(474, 185);
            this.listBoxMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(234, 204);
            this.listBoxMatches.TabIndex = 19;
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.Location = new System.Drawing.Point(72, 349);
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
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(221, 284);
            this.numericUpDownMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownMaxAge.TabIndex = 16;
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(221, 239);
            this.numericUpDownMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(55, 26);
            this.numericUpDownMinAge.TabIndex = 15;
            // 
            // labelMatchMaxAge
            // 
            this.labelMatchMaxAge.AutoSize = true;
            this.labelMatchMaxAge.Location = new System.Drawing.Point(68, 284);
            this.labelMatchMaxAge.Name = "labelMatchMaxAge";
            this.labelMatchMaxAge.Size = new System.Drawing.Size(111, 20);
            this.labelMatchMaxAge.TabIndex = 14;
            this.labelMatchMaxAge.Text = "Maximum age:";
            // 
            // labelMatchMinAge
            // 
            this.labelMatchMinAge.AutoSize = true;
            this.labelMatchMinAge.Location = new System.Drawing.Point(68, 239);
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
            this.comboBoxMatchGender.Location = new System.Drawing.Point(156, 189);
            this.comboBoxMatchGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMatchGender.Name = "comboBoxMatchGender";
            this.comboBoxMatchGender.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMatchGender.TabIndex = 12;
            // 
            // labelMatchGender
            // 
            this.labelMatchGender.AutoSize = true;
            this.labelMatchGender.Location = new System.Drawing.Point(68, 192);
            this.labelMatchGender.Name = "labelMatchGender";
            this.labelMatchGender.Size = new System.Drawing.Size(67, 20);
            this.labelMatchGender.TabIndex = 11;
            this.labelMatchGender.Text = "Gender:";
            // 
            // labelMatchQuestion
            // 
            this.labelMatchQuestion.AutoSize = true;
            this.labelMatchQuestion.Location = new System.Drawing.Point(64, 145);
            this.labelMatchQuestion.Name = "labelMatchQuestion";
            this.labelMatchQuestion.Size = new System.Drawing.Size(213, 20);
            this.labelMatchQuestion.TabIndex = 10;
            this.labelMatchQuestion.Text = "What Are You Interested In?";
            // 
            // MatchFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 535);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMatchesTitleReadOnly;
        private System.Windows.Forms.Panel panelMatchDetails;
        private System.Windows.Forms.TextBox textBoxMatchFoundBday;
        private System.Windows.Forms.TextBox textBoxMatchFoundGender;
        private System.Windows.Forms.TextBox textBoxMatchFoundName;
        private System.Windows.Forms.Label labelMatchFoundBday;
        private System.Windows.Forms.Label labelMatchFoundGender;
        private System.Windows.Forms.Label labelMatchFoundName;
        private System.Windows.Forms.PictureBox pictureBoxMatch;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.Button buttonFindMatch;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAge;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAge;
        private System.Windows.Forms.Label labelMatchMaxAge;
        private System.Windows.Forms.Label labelMatchMinAge;
        private System.Windows.Forms.ComboBox comboBoxMatchGender;
        private System.Windows.Forms.Label labelMatchGender;
        private System.Windows.Forms.Label labelMatchQuestion;
    }
}