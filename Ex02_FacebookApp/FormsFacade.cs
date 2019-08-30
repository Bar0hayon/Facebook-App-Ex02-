using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex02_FacebookApp
{
    class FormsFacade
    {
        public List<FacebookForm> FormsList;
        public FormsFacade()
        {
            FormsList = new List<FacebookForm>();
        }

        public void FetchData(User i_LoggedInUser)
        {
            foreach(FacebookForm facebookForm in FormsList)
            {
                new Thread(() => { facebookForm.FetchData(i_LoggedInUser); }).Start();
            }
        }

        public void ConnectNavigationButtonsToEvents()
        {
            foreach(FacebookForm facebookForm in FormsList)
            {
                facebookForm.OnFriendsAndAlbumsButtonClicked += AppManager.OnFriendsAndAlbumsButtonClicked;
                facebookForm.OnLoginLogoutButtonClicked += AppManager.OnLoginLogoutButtonClicked;
                facebookForm.OnMatchFinderButtonClicked += AppManager.OnMatchFinderButtonClicked;
                facebookForm.OnProfileButtonClicked += AppManager.OnProfileButtonClicked;
                facebookForm.FormClosing += AppManager.OnFormClosing;
            }
        }
    }
}
