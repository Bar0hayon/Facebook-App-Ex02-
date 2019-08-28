using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_FacebookApp
{
    public partial class FacebookForm : Form
    {
        public event Action<FacebookForm> OnProfileButtonClicked;
        public event Action<FacebookForm> OnMatchFinderButtonClicked;
        public event Action<FacebookForm> OnFriendsAndAlbumsButtonClicked;
        public event Action<FacebookForm> OnLoginLogoutButtonClicked;
        public User LoggedInUser { get; set; }
        private AppSettings m_AppSettings;
        public FacebookForm(AppSettings i_AppSettings)
        {
            InitializeComponent();
            m_AppSettings = i_AppSettings;
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberMe.Checked = m_AppSettings.RememberUser;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if(LoggedInUser != null)
            {
                pictureBoxNavPanel.LoadAsync(LoggedInUser.PictureNormalURL);
                buttonLoginLogout.Text = "Logout";
            }

        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            if (OnProfileButtonClicked != null)
            {
                OnProfileButtonClicked.Invoke(this);
            }
        }

        private void ButtonFriendsList_Click(object sender, EventArgs e)
        {
            if (OnFriendsAndAlbumsButtonClicked != null)
            {
                OnFriendsAndAlbumsButtonClicked.Invoke(this);
            }
        }

        private void ButtonMatchFinder_Click(object sender, EventArgs e)
        {
            if (OnMatchFinderButtonClicked != null)
            {
                OnMatchFinderButtonClicked.Invoke(this);
            }
        }

        private void ButtonLoginLogout_Click(object sender, EventArgs e)
        {
            OnLoginLogoutButtonClicked.Invoke(this);
            if (buttonLoginLogout.Text == "Login")
            {
                buttonLoginLogout.Text = "Logout";
                pictureBoxNavPanel.Visible = true;
                pictureBoxNavPanel.LoadAsync(LoggedInUser.PictureNormalURL);
            }
            else
            {
                buttonLoginLogout.Text = "Login";
                pictureBoxNavPanel.Visible = false;
            }

            
        }
    }
}
