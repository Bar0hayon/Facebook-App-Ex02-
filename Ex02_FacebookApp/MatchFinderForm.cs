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
    public partial class MatchFinderForm : FacebookForm
    {
        private List<User> m_MatchesList = new List<User>();

        public MatchFinderForm()
        {
            InitializeComponent();
        }

        protected override void ButtonFriendsList_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            base.ButtonFriendsList_Click(sender, e);
        }

        protected override void ButtonProfile_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            base.ButtonProfile_Click(sender, e);
        }

        private void ButtonFindMatch_Click(object sender, EventArgs e)
        {
            findMatch();
        }

        private void findMatch()
        {
            if (findMatchRequestIsLegal())
            {
                m_MatchesList.Clear();
                try
                {
                    friendListBindingSource.DataSource = LoggedInUser.Friends;
                    foreach (User friend in LoggedInUser.Friends)
                    {
                        if (!isGenderMatch(friend) ||
                            !isRelationshipAvailable(friend) ||
                            !isAgeMatch(friend))
                        {
                             m_MatchesList.Remove(friend);
                             listBoxMatches.Items.Remove(friend.Name);
                        }
                    }

                    if (m_MatchesList.Count == 0)
                    {
                        MessageBox.Show("no matches were found :(", "MatchFinder Resault", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(
                    "Request is not legal! \n" +
                    "please make sure that all of the filds are filled\n" +
                    "and that the 'minimum age' <= 'maximum age'",
                    "MatchFinder Resault",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool findMatchRequestIsLegal()
        {
            return comboBoxMatchGender.SelectedItem != null
                &&
                numericUpDownMinAge.Value <= numericUpDownMaxAge.Value;
        }

        private bool isAgeMatch(User i_Friend)
        {
            bool isAgeMatches = false;
            if (i_Friend.Birthday != null)
            {
                int friendAge = getAgeFromBirthday(i_Friend.Birthday);
                isAgeMatches = friendAge >= numericUpDownMinAge.Value &&
                    friendAge <= numericUpDownMaxAge.Value;
            }

            return isAgeMatches;
        }

        private int getAgeFromBirthday(string i_Birthday)
        {
            const int amountOfDaysInAYear = 365;
            DateTime birthdayDateTime = DateTime.Parse(i_Birthday);
            DateTime currentTime = DateTime.Now;
            int ageInDays = (int)(currentTime - birthdayDateTime).TotalDays;
            int age = ageInDays / amountOfDaysInAYear;
            return age;
        }

        private bool isRelationshipAvailable(User i_Friend)
        {
            return i_Friend.RelationshipStatus == User.eRelationshipStatus.Widowed ||
                    i_Friend.RelationshipStatus == User.eRelationshipStatus.Single ||
                    i_Friend.RelationshipStatus == User.eRelationshipStatus.Separated ||
                    i_Friend.RelationshipStatus == User.eRelationshipStatus.Divorced;
        }

        private bool isGenderMatch(User i_Friend)
        {
            bool isFriendInterested = false;
            bool isFriendGenderMatch = false;
            if (i_Friend.InterestedIn != null)
            {
                foreach (User.eGender gender in i_Friend.InterestedIn)
                {
                    if (gender == LoggedInUser.Gender)
                    {
                        isFriendInterested = true;
                    }
                }
            }

            if (comboBoxMatchGender.SelectedItem.ToString().ToLower() == "both")
            {
                isFriendGenderMatch = true;
            }
            else if (i_Friend.Gender != null)
            {
                isFriendGenderMatch = i_Friend.Gender.ToString().ToLower() ==
                    comboBoxMatchGender.SelectedItem.ToString().ToLower();
            }

            return isFriendGenderMatch && isFriendInterested;
        }
    }
}