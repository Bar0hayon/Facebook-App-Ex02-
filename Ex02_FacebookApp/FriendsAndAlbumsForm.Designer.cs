namespace Ex02_FacebookApp
{
    partial class FriendsAndAlbumsForm
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
            this.textBoxAlbumOwner = new System.Windows.Forms.TextBox();
            this.textBoxAlbumCreationTime = new System.Windows.Forms.TextBox();
            this.textBoxAlbumLikesCount = new System.Windows.Forms.TextBox();
            this.textBoxAlbumCommentsCount = new System.Windows.Forms.TextBox();
            this.textBoxCommentsCountReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxAlbumOwnerReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxCreationTimeReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxLikesCountReadOnly = new System.Windows.Forms.TextBox();
            this.textBoxPhotosTitle = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBoxFriendsListHeadLine = new System.Windows.Forms.TextBox();
            this.textBoxAlbumsHeadLine = new System.Windows.Forms.TextBox();
            this.listViewSelectedAlbumPhotos = new System.Windows.Forms.ListView();
            this.pictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.textBoxNumberOfFriends = new System.Windows.Forms.TextBox();
            this.textBoxFriendsCounter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAlbumOwner
            // 
            this.textBoxAlbumOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumOwner.Location = new System.Drawing.Point(785, 106);
            this.textBoxAlbumOwner.Name = "textBoxAlbumOwner";
            this.textBoxAlbumOwner.Size = new System.Drawing.Size(144, 16);
            this.textBoxAlbumOwner.TabIndex = 67;
            // 
            // textBoxAlbumCreationTime
            // 
            this.textBoxAlbumCreationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumCreationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumCreationTime.Location = new System.Drawing.Point(785, 130);
            this.textBoxAlbumCreationTime.Name = "textBoxAlbumCreationTime";
            this.textBoxAlbumCreationTime.Size = new System.Drawing.Size(144, 16);
            this.textBoxAlbumCreationTime.TabIndex = 66;
            // 
            // textBoxAlbumLikesCount
            // 
            this.textBoxAlbumLikesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumLikesCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumLikesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumLikesCount.Location = new System.Drawing.Point(785, 154);
            this.textBoxAlbumLikesCount.Name = "textBoxAlbumLikesCount";
            this.textBoxAlbumLikesCount.Size = new System.Drawing.Size(144, 16);
            this.textBoxAlbumLikesCount.TabIndex = 65;
            // 
            // textBoxAlbumCommentsCount
            // 
            this.textBoxAlbumCommentsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumCommentsCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumCommentsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumCommentsCount.Location = new System.Drawing.Point(785, 178);
            this.textBoxAlbumCommentsCount.Name = "textBoxAlbumCommentsCount";
            this.textBoxAlbumCommentsCount.Size = new System.Drawing.Size(144, 16);
            this.textBoxAlbumCommentsCount.TabIndex = 64;
            // 
            // textBoxCommentsCountReadOnly
            // 
            this.textBoxCommentsCountReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommentsCountReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCommentsCountReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCommentsCountReadOnly.Location = new System.Drawing.Point(636, 178);
            this.textBoxCommentsCountReadOnly.Name = "textBoxCommentsCountReadOnly";
            this.textBoxCommentsCountReadOnly.Size = new System.Drawing.Size(144, 16);
            this.textBoxCommentsCountReadOnly.TabIndex = 63;
            this.textBoxCommentsCountReadOnly.Text = "Number Of Comments:";
            // 
            // textBoxAlbumOwnerReadOnly
            // 
            this.textBoxAlbumOwnerReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumOwnerReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumOwnerReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumOwnerReadOnly.Location = new System.Drawing.Point(636, 106);
            this.textBoxAlbumOwnerReadOnly.Name = "textBoxAlbumOwnerReadOnly";
            this.textBoxAlbumOwnerReadOnly.Size = new System.Drawing.Size(144, 16);
            this.textBoxAlbumOwnerReadOnly.TabIndex = 62;
            this.textBoxAlbumOwnerReadOnly.Text = "Created By:";
            // 
            // textBoxCreationTimeReadOnly
            // 
            this.textBoxCreationTimeReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCreationTimeReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCreationTimeReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxCreationTimeReadOnly.Location = new System.Drawing.Point(636, 130);
            this.textBoxCreationTimeReadOnly.Name = "textBoxCreationTimeReadOnly";
            this.textBoxCreationTimeReadOnly.Size = new System.Drawing.Size(144, 16);
            this.textBoxCreationTimeReadOnly.TabIndex = 61;
            this.textBoxCreationTimeReadOnly.Text = "Creation Time:";
            // 
            // textBoxLikesCountReadOnly
            // 
            this.textBoxLikesCountReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLikesCountReadOnly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLikesCountReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxLikesCountReadOnly.Location = new System.Drawing.Point(636, 154);
            this.textBoxLikesCountReadOnly.Name = "textBoxLikesCountReadOnly";
            this.textBoxLikesCountReadOnly.Size = new System.Drawing.Size(144, 16);
            this.textBoxLikesCountReadOnly.TabIndex = 60;
            this.textBoxLikesCountReadOnly.Text = "Number Of Likes:";
            // 
            // textBoxPhotosTitle
            // 
            this.textBoxPhotosTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhotosTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhotosTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPhotosTitle.Location = new System.Drawing.Point(636, 206);
            this.textBoxPhotosTitle.Name = "textBoxPhotosTitle";
            this.textBoxPhotosTitle.Size = new System.Drawing.Size(191, 18);
            this.textBoxPhotosTitle.TabIndex = 59;
            this.textBoxPhotosTitle.Text = "Photos:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(636, 230);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 220);
            this.listView1.TabIndex = 58;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxFriendsListHeadLine
            // 
            this.textBoxFriendsListHeadLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendsListHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFriendsListHeadLine.Location = new System.Drawing.Point(115, 67);
            this.textBoxFriendsListHeadLine.Name = "textBoxFriendsListHeadLine";
            this.textBoxFriendsListHeadLine.Size = new System.Drawing.Size(219, 31);
            this.textBoxFriendsListHeadLine.TabIndex = 57;
            this.textBoxFriendsListHeadLine.Text = "Desig\'s Friends";
            this.textBoxFriendsListHeadLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAlbumsHeadLine
            // 
            this.textBoxAlbumsHeadLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlbumsHeadLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbumsHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxAlbumsHeadLine.Location = new System.Drawing.Point(598, 65);
            this.textBoxAlbumsHeadLine.Name = "textBoxAlbumsHeadLine";
            this.textBoxAlbumsHeadLine.Size = new System.Drawing.Size(219, 31);
            this.textBoxAlbumsHeadLine.TabIndex = 56;
            this.textBoxAlbumsHeadLine.Text = "Albums";
            this.textBoxAlbumsHeadLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewSelectedAlbumPhotos
            // 
            this.listViewSelectedAlbumPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSelectedAlbumPhotos.Location = new System.Drawing.Point(471, 103);
            this.listViewSelectedAlbumPhotos.Name = "listViewSelectedAlbumPhotos";
            this.listViewSelectedAlbumPhotos.Size = new System.Drawing.Size(143, 366);
            this.listViewSelectedAlbumPhotos.TabIndex = 55;
            this.listViewSelectedAlbumPhotos.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedAlbumPhotos.SelectedIndexChanged += new System.EventHandler(this.listViewSelectedAlbumPhotos_SelectedIndexChanged_1);
            // 
            // pictureBoxSelectedFriend
            // 
            this.pictureBoxSelectedFriend.Location = new System.Drawing.Point(304, 162);
            this.pictureBoxSelectedFriend.Name = "pictureBoxSelectedFriend";
            this.pictureBoxSelectedFriend.Size = new System.Drawing.Size(106, 88);
            this.pictureBoxSelectedFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSelectedFriend.TabIndex = 54;
            this.pictureBoxSelectedFriend.TabStop = false;
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.HorizontalExtent = 10;
            this.listBoxFriendsList.ItemHeight = 25;
            this.listBoxFriendsList.Location = new System.Drawing.Point(14, 162);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(284, 254);
            this.listBoxFriendsList.TabIndex = 53;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // textBoxNumberOfFriends
            // 
            this.textBoxNumberOfFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumberOfFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxNumberOfFriends.Location = new System.Drawing.Point(14, 120);
            this.textBoxNumberOfFriends.Name = "textBoxNumberOfFriends";
            this.textBoxNumberOfFriends.Size = new System.Drawing.Size(191, 18);
            this.textBoxNumberOfFriends.TabIndex = 52;
            this.textBoxNumberOfFriends.Text = "Total number of friends:";
            // 
            // textBoxFriendsCounter
            // 
            this.textBoxFriendsCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFriendsCounter.Location = new System.Drawing.Point(201, 120);
            this.textBoxFriendsCounter.Name = "textBoxFriendsCounter";
            this.textBoxFriendsCounter.Size = new System.Drawing.Size(39, 18);
            this.textBoxFriendsCounter.TabIndex = 51;
            this.textBoxFriendsCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FriendsAndAlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 534);
            this.Controls.Add(this.textBoxAlbumOwner);
            this.Controls.Add(this.textBoxAlbumCreationTime);
            this.Controls.Add(this.textBoxAlbumLikesCount);
            this.Controls.Add(this.textBoxAlbumCommentsCount);
            this.Controls.Add(this.textBoxCommentsCountReadOnly);
            this.Controls.Add(this.textBoxAlbumOwnerReadOnly);
            this.Controls.Add(this.textBoxCreationTimeReadOnly);
            this.Controls.Add(this.textBoxLikesCountReadOnly);
            this.Controls.Add(this.textBoxPhotosTitle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxFriendsListHeadLine);
            this.Controls.Add(this.textBoxAlbumsHeadLine);
            this.Controls.Add(this.listViewSelectedAlbumPhotos);
            this.Controls.Add(this.pictureBoxSelectedFriend);
            this.Controls.Add(this.listBoxFriendsList);
            this.Controls.Add(this.textBoxNumberOfFriends);
            this.Controls.Add(this.textBoxFriendsCounter);
            this.Name = "FriendsAndAlbumsForm";
            this.Text = "Friends And Albums";
            this.Controls.SetChildIndex(this.textBoxFriendsCounter, 0);
            this.Controls.SetChildIndex(this.textBoxNumberOfFriends, 0);
            this.Controls.SetChildIndex(this.listBoxFriendsList, 0);
            this.Controls.SetChildIndex(this.pictureBoxSelectedFriend, 0);
            this.Controls.SetChildIndex(this.listViewSelectedAlbumPhotos, 0);
            this.Controls.SetChildIndex(this.textBoxAlbumsHeadLine, 0);
            this.Controls.SetChildIndex(this.textBoxFriendsListHeadLine, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.textBoxPhotosTitle, 0);
            this.Controls.SetChildIndex(this.textBoxLikesCountReadOnly, 0);
            this.Controls.SetChildIndex(this.textBoxCreationTimeReadOnly, 0);
            this.Controls.SetChildIndex(this.textBoxAlbumOwnerReadOnly, 0);
            this.Controls.SetChildIndex(this.textBoxCommentsCountReadOnly, 0);
            this.Controls.SetChildIndex(this.textBoxAlbumCommentsCount, 0);
            this.Controls.SetChildIndex(this.textBoxAlbumLikesCount, 0);
            this.Controls.SetChildIndex(this.textBoxAlbumCreationTime, 0);
            this.Controls.SetChildIndex(this.textBoxAlbumOwner, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAlbumOwner;
        private System.Windows.Forms.TextBox textBoxAlbumCreationTime;
        private System.Windows.Forms.TextBox textBoxAlbumLikesCount;
        private System.Windows.Forms.TextBox textBoxAlbumCommentsCount;
        private System.Windows.Forms.TextBox textBoxCommentsCountReadOnly;
        private System.Windows.Forms.TextBox textBoxAlbumOwnerReadOnly;
        private System.Windows.Forms.TextBox textBoxCreationTimeReadOnly;
        private System.Windows.Forms.TextBox textBoxLikesCountReadOnly;
        private System.Windows.Forms.TextBox textBoxPhotosTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxFriendsListHeadLine;
        private System.Windows.Forms.TextBox textBoxAlbumsHeadLine;
        private System.Windows.Forms.ListView listViewSelectedAlbumPhotos;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFriend;
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.TextBox textBoxNumberOfFriends;
        private System.Windows.Forms.TextBox textBoxFriendsCounter;
    }
}