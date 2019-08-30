namespace Ex02_FacebookApp
{
    partial class FacebookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookForm));
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonMatchFinder = new System.Windows.Forms.Button();
            this.buttonFriendsList = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.pictureBoxNavPanel = new System.Windows.Forms.PictureBox();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNavigation.Controls.Add(this.buttonMatchFinder);
            this.panelNavigation.Controls.Add(this.buttonFriendsList);
            this.panelNavigation.Controls.Add(this.buttonProfile);
            this.panelNavigation.Controls.Add(this.checkBoxRememberMe);
            this.panelNavigation.Controls.Add(this.buttonLoginLogout);
            this.panelNavigation.Controls.Add(this.pictureBoxNavPanel);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(800, 76);
            this.panelNavigation.TabIndex = 2;
            // 
            // buttonMatchFinder
            // 
            this.buttonMatchFinder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMatchFinder.Location = new System.Drawing.Point(671, 12);
            this.buttonMatchFinder.Name = "buttonMatchFinder";
            this.buttonMatchFinder.Size = new System.Drawing.Size(106, 54);
            this.buttonMatchFinder.TabIndex = 5;
            this.buttonMatchFinder.Text = "Match Finder";
            this.buttonMatchFinder.UseVisualStyleBackColor = true;
            this.buttonMatchFinder.Click += new System.EventHandler(this.ButtonMatchFinder_Click);
            // 
            // buttonFriendsList
            // 
            this.buttonFriendsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFriendsList.Location = new System.Drawing.Point(560, 12);
            this.buttonFriendsList.Name = "buttonFriendsList";
            this.buttonFriendsList.Size = new System.Drawing.Size(106, 54);
            this.buttonFriendsList.TabIndex = 4;
            this.buttonFriendsList.Text = "Friends and Albums";
            this.buttonFriendsList.UseVisualStyleBackColor = true;
            this.buttonFriendsList.Click += new System.EventHandler(this.ButtonFriendsList_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.Location = new System.Drawing.Point(449, 12);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(106, 54);
            this.buttonProfile.TabIndex = 3;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.ButtonProfile_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(81, 49);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(140, 24);
            this.checkBoxRememberMe.TabIndex = 2;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLoginLogout.Location = new System.Drawing.Point(79, 8);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(79, 35);
            this.buttonLoginLogout.TabIndex = 1;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = true;
            this.buttonLoginLogout.Click += new System.EventHandler(this.ButtonLoginLogout_Click);
            // 
            // pictureBoxNavPanel
            // 
            this.pictureBoxNavPanel.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxNavPanel.Name = "pictureBoxNavPanel";
            this.pictureBoxNavPanel.Size = new System.Drawing.Size(53, 50);
            this.pictureBoxNavPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNavPanel.TabIndex = 0;
            this.pictureBoxNavPanel.TabStop = false;
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelNavigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facebook";
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonMatchFinder;
        private System.Windows.Forms.Button buttonFriendsList;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.PictureBox pictureBoxNavPanel;
    }
}

