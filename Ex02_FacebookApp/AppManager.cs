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
        private static MatchFinderForm m_MatchFinderForm;
        private static ProfileForm m_ProfileForm;
        private static FriendsAndAlbumsForm m_FriendsAndAlbumsForm;
        private static FacebookForm m_LoginForm;
        private static User m_LoggedInUser;
        private static bool v_LoggedIn = false;
        private static AppSettings m_AppSettings = new AppSettings();
        private static LoginResult m_LoginResult;

        public static void Start()
        {
            
            m_AppSettings.LoadData();
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

            m_LoginForm = new FacebookForm(m_AppSettings);
            m_LoginForm.OnFriendsAndAlbumsButtonClicked += onFriendsAndAlbumsButtonClicked;
            m_LoginForm.OnMatchFinderButtonClicked += onMatchFinderButtonClicked;
            m_LoginForm.OnProfileButtonClicked += onProfileButtonClicked;
            m_LoginForm.OnLoginLogoutButtonClicked += onLoginLogoutButtonClicked;
            m_LoginForm.ShowDialog();

            m_AppSettings.SaveToFile();
        }

        private static void onLoginLogoutButtonClicked(FacebookForm obj)
        {
            if (!v_LoggedIn)
            {
                login();
                loggedIn();
            }
            else
            {
                FacebookService.Logout(loggedOut);
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
            //buttonLoginLogout.Text = "Logout";
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                m_LoginForm.LoggedInUser = m_LoggedInUser;

                m_FriendsAndAlbumsForm = new FriendsAndAlbumsForm(m_LoggedInUser, m_AppSettings);
                m_MatchFinderForm = new MatchFinderForm(m_LoggedInUser, m_AppSettings);
                m_ProfileForm = new ProfileForm(m_LoggedInUser, m_AppSettings);
                connectNavigationButtonsToEvents();
                //fetchProfile();
                //fetchFriendsList();
                //fetchAlbumsList();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }
        private static void loggedOut()
        {
            v_LoggedIn = false;
            
        }

        private static void connectNavigationButtonsToEvents()
        {
            m_MatchFinderForm.OnProfileButtonClicked += onProfileButtonClicked;
            m_FriendsAndAlbumsForm.OnProfileButtonClicked += onProfileButtonClicked;
            m_ProfileForm.OnMatchFinderButtonClicked += onMatchFinderButtonClicked;
            m_FriendsAndAlbumsForm.OnMatchFinderButtonClicked += onMatchFinderButtonClicked;
            m_MatchFinderForm.OnFriendsAndAlbumsButtonClicked += onFriendsAndAlbumsButtonClicked;
            m_ProfileForm.OnFriendsAndAlbumsButtonClicked += onFriendsAndAlbumsButtonClicked;
        }

        private static void onFriendsAndAlbumsButtonClicked(FacebookForm obj)
        {
            obj.Close();
            new Thread(showFriendsAndAlbumsForm).Start();
        }

        private static void showFriendsAndAlbumsForm()
        {
            m_FriendsAndAlbumsForm.ShowDialog();
        }

        private static void onMatchFinderButtonClicked(FacebookForm obj)
        {
            obj.Close();
            new Thread(showMatchFinderForm).Start();
        }

        private static void showMatchFinderForm()
        {
            m_MatchFinderForm.ShowDialog();
        }

        private static void onProfileButtonClicked(FacebookForm i_FacebookForm)
        {
            i_FacebookForm.Close();
            new Thread(showProfileForm).Start();
        }

        private static void showProfileForm()
        {
            m_ProfileForm.ShowDialog();
        }
    }
}
