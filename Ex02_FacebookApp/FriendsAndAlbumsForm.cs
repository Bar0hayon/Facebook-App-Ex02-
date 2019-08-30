using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_FacebookApp
{
    public partial class FriendsAndAlbumsForm : FacebookForm
    {
        private ImageList m_ImageList = new ImageList();
        private List<string> m_ImageListUrls = new List<string>();

        public FriendsAndAlbumsForm()
        {
            InitializeComponent();
        }

        //public FriendsAndAlbumsForm(User i_LoggedInUser)
        //{
        //    InitializeComponent();
        //    LoggedInUser = i_LoggedInUser;
        //}
            //new Thread(fetchAlbumsList).Start();
            fetchAlbumsList();
        }

        public void fetchAlbumsList()
        {
            //listViewSelectedAlbumPhotos.ItemSelectionChanged += ListViewSelectedAlbumPhotos_ItemSelectionChanged;
            int albumIndex = 0;
            m_ImageList.ImageSize = new Size(40, 40);
            foreach (Album album in LoggedInUser.Albums)
            {
                m_ImageListUrls.Add(album.PictureSmallURL);

                WebClient fetchImageUsingUrl = new WebClient();
                byte[] imageByte = fetchImageUsingUrl.DownloadData(m_ImageListUrls[albumIndex]);
                MemoryStream stream = new MemoryStream(imageByte);

                Image newImage = Image.FromStream(stream);
                m_ImageList.Images.Add(newImage);

                listViewSelectedAlbumPhotos.Items.Add(album.Name, albumIndex);
                albumIndex++;
            }

            listViewSelectedAlbumPhotos.LargeImageList = m_ImageList;
        }

        private void listViewSelectedAlbumPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int albumIndex = 0;
            m_ImageList.ImageSize = new Size(40, 40);
            try
            {
                if (listViewSelectedAlbumPhotos.SelectedIndices.Count > 0)
                {
                    listView1.Clear();
                    int selectedIndex = listViewSelectedAlbumPhotos.SelectedIndices[0];
                    for (int i = 0; i < LoggedInUser.Albums[selectedIndex].Count; i++)
                    {
                        fetchAlbumData(selectedIndex);
                        m_ImageListUrls.Add(LoggedInUser.Albums[selectedIndex].PictureSmallURL);

                        WebClient fetchImageUsingUrl = new WebClient();
                        byte[] imageByte = fetchImageUsingUrl.DownloadData(m_ImageListUrls[albumIndex]);
                        MemoryStream stream = new MemoryStream(imageByte);

                        Image newImage = Image.FromStream(stream);
                        m_ImageList.Images.Add(newImage);

                        listView1.Items.Add(string.Empty, albumIndex);
                        albumIndex++;
                    }

                    listView1.LargeImageList = m_ImageList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchAlbumData(int i_AlbumIndex)
        {
            textBoxAlbumCommentsCount.Text =
                LoggedInUser.Albums[i_AlbumIndex].Comments.Count.ToString();
            textBoxAlbumCreationTime.Text =
                LoggedInUser.Albums[i_AlbumIndex].CreatedTime.ToString();
            textBoxAlbumLikesCount.Text =
                LoggedInUser.Albums[i_AlbumIndex].LikedBy.Count.ToString();
            textBoxAlbumOwner.Text =
                LoggedInUser.Albums[i_AlbumIndex].From.Name;
    }
}
