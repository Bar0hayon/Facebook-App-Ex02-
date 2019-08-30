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
    public partial class ProfileForm : FacebookForm
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        public override void FetchData(User i_LoggedInUser)
        {
            base.FetchData(i_LoggedInUser);
            fetchProfile();
        }

        protected override void ButtonMatchFinder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            base.ButtonMatchFinder_Click(sender, e);
        }

        protected override void ButtonFriendsList_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            base.ButtonFriendsList_Click(sender, e);
        }

        private void ComboBoxStatusesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxStatusesSort.SelectedIndex)
                {
                    case 0:
                        fillStatusesListViewByDate();
                        break;
                    case 1:
                        fillStatusesListViewByLikesCount();
                        break;
                    case 2:
                        fillStatusesListViewByCommentsCount();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("an error accured while trying to sort your statuses...");
            }
        }

        private void fetchProfile()
        {
            pictureProfile.Visible = true;
            pictureProfile.LoadAsync(LoggedInUser.PictureNormalURL);
            fetchPersonalInformation();
            fetchUserStatuses();
        }

        private void fetchUserStatuses()
        {
            comboBoxStatusesSort.Visible = true;
            listViewUserStatuses.Visible = true;
            ColumnHeader onlyColumn = new ColumnHeader();
            onlyColumn.Text = string.Empty;
            onlyColumn.Width = listViewUserStatuses.Width - 20;
            listViewUserStatuses.Columns.Add(onlyColumn);
            try
            {
                fillStatusesListViewByDate();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "An error aqured while trying to download your statuses",
                    "Statuses Request Failure",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void fillStatusesListViewByDate()
        {
            listViewUserStatuses.Items.Clear();
            foreach (Status status in LoggedInUser.Statuses)
            {
                addStatusToStatusesListView(status);
            }
        }

        private void fillStatusesListViewByLikesCount()
        {
            listViewUserStatuses.Items.Clear();
            Status[] sortedStatuses =
                Sorter.GetStatusesSortedByLikesCount(LoggedInUser.Statuses);
            foreach (Status status in sortedStatuses)
            {
                addStatusToStatusesListView(status);
            }
        }

        private void fillStatusesListViewByCommentsCount()
        {
            listViewUserStatuses.Items.Clear();
            Status[] sortedStatuses =
                Sorter.GetStatusesSortedByCommentsCount(LoggedInUser.Statuses);
            foreach (Status status in sortedStatuses)
            {
                addStatusToStatusesListView(status);
            }
        }

        private void addStatusToStatusesListView(Status i_Status)
        {
            const int statusFontSize = 12;
            const int statusInfoFontSize = 8;
            ListViewItem lvStatus = new ListViewItem(i_Status.Message);
            Font statusFont = new Font(FontFamily.GenericSansSerif, statusFontSize);
            lvStatus.Font = statusFont;
            lvStatus.BackColor = Color.LightBlue;
            ListViewItem lvStatusInfo = new ListViewItem(
                string.Format(
                    "updated at {0} | {1} likes | {2} comments",
                    i_Status.CreatedTime.ToString(),
                    i_Status.LikedBy.Count.ToString(),
                    i_Status.Comments.Count.ToString()));
            Font statusInfoFont = new Font(
                                            FontFamily.GenericSansSerif,
                                            statusInfoFontSize,
                                            FontStyle.Italic);
            lvStatusInfo.Font = statusInfoFont;
            lvStatusInfo.BackColor = Color.LightBlue;
            ListViewItem lvSeparetor = new ListViewItem();
            listViewUserStatuses.Items.AddRange(new ListViewItem[] { lvStatus, lvStatusInfo, lvSeparetor });
            listViewUserStatuses.ItemSelectionChanged += listViewUserStatuses_ItemSelectionChanged;
        }

        private void listViewUserStatuses_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }

        private void fetchPersonalInformation()
        {
            textBirthDayReadOnly.Visible = true;
            textNameReadOnly.Visible = true;
            textEmailReadOnly.Visible = true;
            textGenderReadOnly.Visible = true;
            textUserFullName.Visible = true;
            textUserBirthDay.Visible = true;
            textUserEmail.Visible = true;
            textUserGender.Visible = true;
            comboBoxStatusesSort.Visible = true;

            textUserFullName.Text = LoggedInUser.Name;
            textUserBirthDay.Text = LoggedInUser.Birthday;
            textUserEmail.Text = LoggedInUser.Email;
            textUserGender.Text = LoggedInUser.Gender.ToString();
        }
    }
}
