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
    internal class PanelFriend : BasePanel
    {
        public PanelFriend(User i_Friend)
        {
            PictureBox pictureBoxUserPicture = WinFormControlsGenarator.CreatePictureBox(i_Friend.PictureSmallURL);
            pictureBoxUserPicture.Location = new Point(10, 10);
            pictureBoxUserPicture.Size = new Size(40, 40);
            Controls.Add(pictureBoxUserPicture);

            Label labelUserName = WinFormControlsGenarator.CreateLabel(i_Friend.Name);
            labelUserName.Location = new Point(60, 10);
            Controls.Add(labelUserName);
        }
    }
}
