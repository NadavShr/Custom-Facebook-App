using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookLogic
{
    internal class ManageAlbumSlideShow
    {
        private List<string>   m_AlbumPhotosUrl;
        private LogicManager   m_LogicManager;
        private int            m_Counter;
        private Album          m_SelectedAlbum;
        public int             TimerInterval { get; set; }
        private const int      k_defultTimerInterval = 3000;
        private const String   k_EmptyAlbumImage = "https://media.istockphoto.com/vectors/photo-images-simple-icon-image-album-thumbnail-sign-vector-vector-id1321648998?k=20&m=1321648998&s=170667a&w=0&h=ODapn9Pbk-p0tSckx66grYJw0M_89ez4QExKR7UjrHo=";

        public ManageAlbumSlideShow(LogicManager i_LogicManager)
        {
            m_AlbumPhotosUrl = new List<string>();
            m_Counter = 0;
            TimerInterval = k_defultTimerInterval;
            m_LogicManager = i_LogicManager;
        }

        public String BringTheNextPictureUrl()
        {
            String nextPictureUrl = k_EmptyAlbumImage;

            if (m_AlbumPhotosUrl.Count > 0)
            {
                if (m_Counter >= m_AlbumPhotosUrl.Count)
                {
                    m_Counter = 0;
                }

                nextPictureUrl = m_AlbumPhotosUrl[m_Counter++];
            }

            return nextPictureUrl;
        }

        public void SetSelectedAlbum(String i_SelectedAlbumName)
        {
            foreach (Album album in m_LogicManager.GetUserAlbums())
            {
                if (i_SelectedAlbumName.Equals(album.Name))
                {
                    m_SelectedAlbum = album;
                    break;
                }
            }

            InitAlbumPhotosUrl();
        }

        public void InitAlbumPhotosUrl()
        {
            if (m_SelectedAlbum != null)
            {
                m_AlbumPhotosUrl.Clear();
                foreach (Photo photo in m_SelectedAlbum.Photos)
                {
                    m_AlbumPhotosUrl.Add(photo.PictureNormalURL);
                }
            }
        }

        public String GetSelectedAlbumCoverPic()
        {
            return m_SelectedAlbum.PictureAlbumURL;
        }
    }
}
