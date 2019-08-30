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
        private static LoginForm m_LoginForm = new LoginForm();
        private static User m_LoggedInUser;
        private static bool v_LoggedIn = false;
        private static AppSettings m_AppSettings = new AppSettings();
        private static LoginResult m_LoginResult;
        private static FormsFacade m_FormsFacade = new FormsFacade();

        public static void Start()
        {
            addFormsToFacade();
            m_FormsFacade.ConnectNavigationButtonsToEvents();
            m_AppSettings.LoadData();
            TryAutoConnectToFacebook();
            showDialogAccordingToAppSettings(m_LoginForm);
        }

        private static void addFormsToFacade()
        {
            m_FormsFacade.FormsList.Add(m_FriendsAndAlbumsForm);
            m_FormsFacade.FormsList.Add(m_MatchFinderForm);
            m_FormsFacade.FormsList.Add(m_ProfileForm);
            m_FormsFacade.FormsList.Add(m_LoginForm);
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

        public static void OnLoginLogoutButtonClicked(FacebookForm i_SenderForm)
        {
            if (!v_LoggedIn)
            {
                login();
                loggedIn();
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
                m_AppSettings.SaveToFile();
                System.Environment.Exit(1);
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
                m_FormsFacade.FetchData(m_LoggedInUser);
                m_LoginForm.EnableNavigationButtons(true);
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

        public static void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            FacebookForm senderForm = sender as FacebookForm;
            senderForm.GetSettings(ref m_AppSettings);
            if(senderForm.DialogResult == DialogResult.Cancel)
            {
                m_AppSettings.SaveToFile();
            }
        }

        public static void OnFriendsAndAlbumsButtonClicked(FacebookForm i_SenderForm)
        {
            if (i_SenderForm != m_FriendsAndAlbumsForm)
            {
                i_SenderForm.Close();
                new Thread(showFriendsAndAlbumsForm).Start();
            }
        }

        private static void showFriendsAndAlbumsForm()
        {
            showDialogAccordingToAppSettings(m_FriendsAndAlbumsForm);
        }

        public static void OnMatchFinderButtonClicked(FacebookForm i_SenderForm)
        {
            if (i_SenderForm != m_MatchFinderForm)
            {
                i_SenderForm.Close();
                new Thread(showMatchFinderForm).Start();
            }
        }

        private static void showMatchFinderForm()
        {
            showDialogAccordingToAppSettings(m_MatchFinderForm);
        }

        public static void OnProfileButtonClicked(FacebookForm i_FacebookForm)
        {
            if (i_FacebookForm != m_ProfileForm)
            {
                i_FacebookForm.Close();
                new Thread(showProfileForm).Start();
            }
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
