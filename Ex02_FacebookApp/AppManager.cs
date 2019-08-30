using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_FacebookApp
{
    public static class AppManager
    {
        private static MatchFinderForm m_MatchFinderForm = new MatchFinderForm();
        private static ProfileForm m_ProfileForm = new ProfileForm();
        private static FriendsAndAlbumsForm m_FriendsAndAlbumsForm = new FriendsAndAlbumsForm();
        private static FacebookForm m_LoginForm = new FacebookForm();
        private static User m_LoggedInUser;
        private static bool v_LoggedIn = false;
        private static AppSettings m_AppSettings = new AppSettings();
        private static LoginResult m_LoginResult;

        public static void Start()
        {
            connectNavigationButtonsToEvents();
            m_AppSettings.LoadData();
            TryAutoConnectToFacebook();
            showDialogAccordingToAppSettings(m_LoginForm);
        }

        private static void showDialogAccordingToAppSettings(FacebookForm i_FacebookForm)
        {
            i_FacebookForm.SetSettings(m_AppSettings);
            i_FacebookForm.ShowDialog();
        }

        private static void TryAutoConnectToFacebook()
        {
            if (m_AppSettings.RememberUser &&
                            !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                    loggedIn();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: could not automaticlly connect to facebook");
                }
            }
            else
            {
                loggedOut();
            }
        }

        private static void onLoginLogoutButtonClicked(FacebookForm i_SenderForm)
        {
            if (!v_LoggedIn)
            {
                login();
                loggedIn();
            }
            else
            {
                FacebookService.Logout(loggedOut);/////////////need to make our func
            }
        }

        private static void login()
        {
            try
            {
                ////(desig patter's "Design Patterns Course App 2.4" app)
                m_LoginResult = FacebookService.Login(
                    "1450160541956417",
                    "public_profile",
                    "email",
                    "groups_access_member_info",
                    "publish_to_groups",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_tagged_places",
                    "user_videos");
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "An Error aqured while trying to connect to the facebook servers, please try again later",
                    "Login Request Failure",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private static void loggedIn()
        {
            v_LoggedIn = true;
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                m_LoginForm.LoggedInUser = m_LoggedInUser;
                new Thread(fetchProfileData).Start();
                //new Thread(fetchFriendsAndAlbumsData).Start();
                fetchFriendsAndAlbumsData();
                m_MatchFinderForm.LoggedInUser = m_LoggedInUser;
                m_LoginForm.EnableNavigationButtons(true);

                //fetchProfile();
                //fetchFriendsList();
                //fetchAlbumsList();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private static void fetchProfileData()
        {
            m_ProfileForm.FetchData(m_LoggedInUser);
        }

        private static void fetchFriendsAndAlbumsData()
        {
            m_FriendsAndAlbumsForm.FetchData(m_LoggedInUser);
        }

        private static void loggedOut()
        {
            v_LoggedIn = false;
            m_LoginForm.EnableNavigationButtons(false);
            m_LoginForm.LoggedInUser = null;
        }

        private static void connectNavigationButtonsToEvents()
        {
            m_LoginForm.OnFriendsAndAlbumsButtonClicked += onFriendsAndAlbumsButtonClicked;
            m_LoginForm.OnMatchFinderButtonClicked += onMatchFinderButtonClicked;
            m_LoginForm.OnProfileButtonClicked += onProfileButtonClicked;
            m_LoginForm.OnLoginLogoutButtonClicked += onLoginLogoutButtonClicked;

            m_MatchFinderForm.OnProfileButtonClicked += onProfileButtonClicked;
            m_FriendsAndAlbumsForm.OnProfileButtonClicked += onProfileButtonClicked;
            m_ProfileForm.OnMatchFinderButtonClicked += onMatchFinderButtonClicked;
            m_FriendsAndAlbumsForm.OnMatchFinderButtonClicked += onMatchFinderButtonClicked;
            m_MatchFinderForm.OnFriendsAndAlbumsButtonClicked += onFriendsAndAlbumsButtonClicked;
            m_ProfileForm.OnFriendsAndAlbumsButtonClicked += onFriendsAndAlbumsButtonClicked;
            m_FriendsAndAlbumsForm.OnLoginLogoutButtonClicked += onLoginLogoutButtonClicked;
            m_MatchFinderForm.OnLoginLogoutButtonClicked += onLoginLogoutButtonClicked;
            m_ProfileForm.OnLoginLogoutButtonClicked += onLoginLogoutButtonClicked;

            m_FriendsAndAlbumsForm.FormClosing += onFormClosing;
            m_LoginForm.FormClosing += onFormClosing;
            m_MatchFinderForm.FormClosing += onFormClosing;
            m_ProfileForm.FormClosing += onFormClosing;
        }

        private static void onFormClosing(object sender, FormClosingEventArgs e)
        {
            FacebookForm senderForm = sender as FacebookForm;
            senderForm.GetSettings(ref m_AppSettings);
            if(senderForm.DialogResult == DialogResult.Cancel)
            {
                m_AppSettings.SaveToFile();
            }
        }

        private static void onFriendsAndAlbumsButtonClicked(FacebookForm obj)
        {
            obj.Close();
            new Thread(showFriendsAndAlbumsForm).Start();
        }

        private static void showFriendsAndAlbumsForm()
        {
            showDialogAccordingToAppSettings(m_FriendsAndAlbumsForm);
        }

        private static void onMatchFinderButtonClicked(FacebookForm obj)
        {
            obj.Close();
            new Thread(showMatchFinderForm).Start();
        }

        private static void showMatchFinderForm()
        {
            showDialogAccordingToAppSettings(m_MatchFinderForm);
        }

        private static void onProfileButtonClicked(FacebookForm i_FacebookForm)
        {
            i_FacebookForm.Close();
            new Thread(showProfileForm).Start();
        }

        private static void showProfileForm()
        {
            showDialogAccordingToAppSettings(m_ProfileForm);
        }

        private static void showLoginForm()
        {
            showDialogAccordingToAppSettings(m_LoginForm);
        }
    }
}
