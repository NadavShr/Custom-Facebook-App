using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PanelAlbum : BasePanel
    {
        private Album m_Album;

        public PanelAlbum(Album i_Album)
        {
            this.m_Album = i_Album;

            PictureBox pictureBoxAlbumCover = WinFormControlsGenarator.CreatePictureBox(i_Album.PictureAlbumURL);
            pictureBoxAlbumCover.Location = new Point(10, 10);
            pictureBoxAlbumCover.Size = new Size(100, 100);
            this.Controls.Add(pictureBoxAlbumCover);

            Label labelAlbumName = WinFormControlsGenarator.CreateLabel(i_Album.Name);
            labelAlbumName.Location = new Point(150, 10);
            this.Controls.Add(labelAlbumName);

            LinkLabel linkLabelpicturesLink = WinFormControlsGenarator.CreateLabelLink(String.Format("Pictures ({0})", i_Album.Photos.Count), 10);
            linkLabelpicturesLink.Location = new Point(150, 100);
            linkLabelpicturesLink.Click += PicturesLink_Click;
            Controls.Add(linkLabelpicturesLink);
        }

        private void PicturesLink_Click(object sender, EventArgs e)
        {
            if (m_Album.Photos.Count == 0)
            {
                MessageBox.Show("There is no pictures in this album");
            } 
            else
            {
                FormPicturs formPictures = new FormPicturs(m_Album);
                formPictures.ShowDialog();
            }
        }
    }
}
