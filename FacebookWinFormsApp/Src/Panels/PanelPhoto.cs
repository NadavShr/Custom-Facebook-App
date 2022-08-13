using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Panels
{
    public delegate void PictureClicked(Photo i_Photo);

    internal class PanelPhoto : BasePanel
    {
        public event PictureClicked  PictureClicked;
        public Photo                 Photo { get; private set; }

        public PanelPhoto(Photo photo)
        {
            this.Photo = photo;

            this.MinimumSize = new Size(80, 80);
            this.MaximumSize = new Size(80, 80);

            PictureBox picture = WinFormControlsGenarator.CreatePictureBox(photo.PictureNormalURL);
            picture.Size = new Size(60, 60);
            picture.Location = new Point(10, 10);
            picture.Click += Picture_Click;
            this.Controls.Add(picture);
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureClicked(this.Photo);
        }
    }
}
