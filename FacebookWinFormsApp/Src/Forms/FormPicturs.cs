using BasicFacebookFeatures.Panels;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPicturs : Form
    {
        private Album m_Album;

        public FormPicturs(Album i_Album)
        {
            InitializeComponent();
            this.m_Album = i_Album;
            initPictures();
        }

        private void initPictures()
        {
            PanelPhoto panelPhoto;
            Photo firstPhoto;

            this.flowLayoutPanelPicturs.Controls.Clear();
            foreach (Photo photo in m_Album.Photos)
            {
                panelPhoto = new PanelPhoto(photo);
                panelPhoto.PictureClicked += PanelPhoto_pictureClicked;
                this.flowLayoutPanelPicturs.Controls.Add(panelPhoto);
            }

            firstPhoto = getAlbumFirstPhoto();
            if (firstPhoto != null)
            {
                loadChoosenPicture(firstPhoto);
            }
        }

        private void PanelPhoto_pictureClicked(Photo i_Photo)
        {
            loadChoosenPicture(i_Photo);
        }

        private void loadChoosenPicture(Photo i_Photo)
        {
            this.pictureBoxChoosenPicture.Load(i_Photo.PictureNormalURL);
            this.pictureBoxChoosenPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Photo getAlbumFirstPhoto ()
        {
            Photo photoResult = null;

            if (m_Album.Photos.Count != 0)
            {
                foreach (Photo photo in m_Album.Photos)
                {
                    photoResult = photo;
                    break;
                }
            }

            return photoResult;
        }
    }
}