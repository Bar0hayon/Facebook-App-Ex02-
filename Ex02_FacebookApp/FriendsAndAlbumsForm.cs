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
    public partial class FriendsAndAlbumsForm : FacebookForm
    {
        public FriendsAndAlbumsForm()
        {
            InitializeComponent();
        }

        public FriendsAndAlbumsForm(User i_LoggedInUser, AppSettings i_AppSettings) :
            base(i_AppSettings)
        {
            InitializeComponent();
            LoggedInUser = i_LoggedInUser;
        }
    }
}
