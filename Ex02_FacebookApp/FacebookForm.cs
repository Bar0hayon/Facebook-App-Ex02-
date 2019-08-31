using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex02_FacebookApp
{
    public partial class FacebookForm : Form
    {
        public event Action<FacebookForm> OnProfileButtonClicked;

        public event Action<FacebookForm> OnMatchFinderButtonClicked;

        public event Action<FacebookForm> OnFriendsAndAlbumsButtonClicked;

        public event Action<FacebookForm> OnLoginLogoutButtonClicked;

        public User LoggedInUser { get; set; }

        public FacebookForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 600);
        }

        public void SetSettings(AppSettings i_AppSettings)
        {
            this.Size = i_AppSettings.LastWindowSize;
            this.Location = i_AppSettings.LastWindowLocation;
            this.checkBoxRememberMe.Checked = i_AppSettings.RememberUser;
        }

        public void GetSettings(ref AppSettings i_AppSettings)
        {
            i_AppSettings.LastWindowLocation = this.Location;
            i_AppSettings.LastWindowSize = this.Size;
            i_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if(LoggedInUser != null)
            {
                buttonLoginLogout.Text = "Logout";
                if(pictureBoxNavPanel.ImageLocation == null)
                {
                    loadNavigationPicture();
                }
            }
        }

        public virtual void FetchData(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            loadNavigationPicture();
        }

        protected void loadNavigationPicture()
        {
            pictureBoxNavPanel.LoadAsync(LoggedInUser.PictureNormalURL);
        }

        protected virtual void ButtonProfile_Click(object sender, EventArgs e)
        {
            if (OnProfileButtonClicked != null)
            {
                OnProfileButtonClicked.Invoke(this);
            }
        }

        protected virtual void ButtonFriendsList_Click(object sender, EventArgs e)
        {
            if (OnFriendsAndAlbumsButtonClicked != null)
            {
                OnFriendsAndAlbumsButtonClicked.Invoke(this);
            }
        }

        protected virtual void ButtonMatchFinder_Click(object sender, EventArgs e)
        {
            if (OnMatchFinderButtonClicked != null)
            {
                OnMatchFinderButtonClicked.Invoke(this);
            }
        }

        protected virtual void ButtonLoginLogout_Click(object sender, EventArgs e)
        {
            if (buttonLoginLogout.Text == "Login")
            {
                buttonLoginLogout.Text = "Logout";
                OnLoginLogoutButtonClicked.Invoke(this);
                pictureBoxNavPanel.Visible = true;
                pictureBoxNavPanel.LoadAsync(LoggedInUser.PictureNormalURL);
            }
            else
            {
                buttonLoginLogout.Text = "Login";
                pictureBoxNavPanel.Visible = false;
                OnLoginLogoutButtonClicked.Invoke(this);
            }
        }

        public void EnableNavigationButtons(bool i_Enable)
        {
            this.buttonFriendsList.Enabled = i_Enable;
            this.buttonMatchFinder.Enabled = i_Enable;
            this.buttonProfile.Enabled = i_Enable;
        }
    }
}
