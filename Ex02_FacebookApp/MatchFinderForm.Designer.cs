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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchFinderForm));
            this.labelMatchesTitleReadOnly = new System.Windows.Forms.Label();
            this.panelMatchDetails = new System.Windows.Forms.Panel();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.labelMatchMaxAge = new System.Windows.Forms.Label();
            this.labelMatchMinAge = new System.Windows.Forms.Label();
            this.comboBoxMatchGender = new System.Windows.Forms.ComboBox();
            this.labelMatchGender = new System.Windows.Forms.Label();
            this.labelMatchQuestion = new System.Windows.Forms.Label();
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.friendListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.friendListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            birthdayLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panelMatchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingNavigator)).BeginInit();
            this.friendListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMatchesTitleReadOnly
            // 
            this.labelMatchesTitleReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMatchesTitleReadOnly.AutoSize = true;
            this.labelMatchesTitleReadOnly.Location = new System.Drawing.Point(633, 123);
            this.labelMatchesTitleReadOnly.Name = "labelMatchesTitleReadOnly";
            this.labelMatchesTitleReadOnly.Size = new System.Drawing.Size(65, 17);
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
            this.panelMatchDetails.Location = new System.Drawing.Point(805, 148);
            this.panelMatchDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMatchDetails.Name = "panelMatchDetails";
            this.panelMatchDetails.Size = new System.Drawing.Size(272, 164);
            this.panelMatchDetails.TabIndex = 20;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxMatches.DataSource = this.friendListBindingSource;
            this.listBoxMatches.DisplayMember = "Name";
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 16;
            this.listBoxMatches.Location = new System.Drawing.Point(563, 148);
            this.listBoxMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(208, 164);
            this.listBoxMatches.TabIndex = 19;
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.Location = new System.Drawing.Point(64, 279);
            this.buttonFindMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindMatch.Name = "buttonFindMatch";
            this.buttonFindMatch.Size = new System.Drawing.Size(182, 33);
            this.buttonFindMatch.TabIndex = 18;
            this.buttonFindMatch.Text = "Find me a match";
            this.buttonFindMatch.UseVisualStyleBackColor = true;
            this.buttonFindMatch.Click += new System.EventHandler(this.ButtonFindMatch_Click);
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(196, 227);
            this.numericUpDownMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownMaxAge.TabIndex = 16;
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(196, 191);
            this.numericUpDownMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownMinAge.TabIndex = 15;
            // 
            // labelMatchMaxAge
            // 
            this.labelMatchMaxAge.AutoSize = true;
            this.labelMatchMaxAge.Location = new System.Drawing.Point(60, 227);
            this.labelMatchMaxAge.Name = "labelMatchMaxAge";
            this.labelMatchMaxAge.Size = new System.Drawing.Size(98, 17);
            this.labelMatchMaxAge.TabIndex = 14;
            this.labelMatchMaxAge.Text = "Maximum age:";
            // 
            // labelMatchMinAge
            // 
            this.labelMatchMinAge.AutoSize = true;
            this.labelMatchMinAge.Location = new System.Drawing.Point(60, 191);
            this.labelMatchMinAge.Name = "labelMatchMinAge";
            this.labelMatchMinAge.Size = new System.Drawing.Size(95, 17);
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
            this.comboBoxMatchGender.Location = new System.Drawing.Point(139, 151);
            this.comboBoxMatchGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMatchGender.Name = "comboBoxMatchGender";
            this.comboBoxMatchGender.Size = new System.Drawing.Size(108, 24);
            this.comboBoxMatchGender.TabIndex = 12;
            // 
            // labelMatchGender
            // 
            this.labelMatchGender.AutoSize = true;
            this.labelMatchGender.Location = new System.Drawing.Point(60, 154);
            this.labelMatchGender.Name = "labelMatchGender";
            this.labelMatchGender.Size = new System.Drawing.Size(60, 17);
            this.labelMatchGender.TabIndex = 11;
            this.labelMatchGender.Text = "Gender:";
            // 
            // labelMatchQuestion
            // 
            this.labelMatchQuestion.AutoSize = true;
            this.labelMatchQuestion.Location = new System.Drawing.Point(57, 116);
            this.labelMatchQuestion.Name = "labelMatchQuestion";
            this.labelMatchQuestion.Size = new System.Drawing.Size(186, 17);
            this.labelMatchQuestion.TabIndex = 10;
            this.labelMatchQuestion.Text = "What Are You Interested In?";
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.friendListBindingSource;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(10, 138);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(115, 135);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(145, 22);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(10, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(115, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(145, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // friendListBindingNavigatorSaveItem
            // 
            this.friendListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.friendListBindingNavigatorSaveItem.Enabled = false;
            this.friendListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("friendListBindingNavigatorSaveItem.Image")));
            this.friendListBindingNavigatorSaveItem.Name = "friendListBindingNavigatorSaveItem";
            this.friendListBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.friendListBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // friendListBindingNavigator
            // 
            this.friendListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.friendListBindingNavigator.BindingSource = this.friendListBindingSource;
            this.friendListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.friendListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.friendListBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.friendListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.friendListBindingNavigatorSaveItem});
            this.friendListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.friendListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.friendListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.friendListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.friendListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.friendListBindingNavigator.Name = "friendListBindingNavigator";
            this.friendListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.friendListBindingNavigator.Size = new System.Drawing.Size(1337, 27);
            this.friendListBindingNavigator.TabIndex = 21;
            this.friendListBindingNavigator.Text = "bindingNavigator1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.membersBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(21, 8);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 81);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // MatchFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 438);
            this.Controls.Add(this.friendListBindingNavigator);
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
            this.Controls.SetChildIndex(this.friendListBindingNavigator, 0);
            this.panelMatchDetails.ResumeLayout(false);
            this.panelMatchDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingNavigator)).EndInit();
            this.friendListBindingNavigator.ResumeLayout(false);
            this.friendListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton friendListBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator friendListBindingNavigator;
    }
}