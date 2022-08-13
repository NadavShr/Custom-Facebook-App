using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Panels
{
    internal class PanelComment : BasePanel
    {
        public PanelComment(Comment i_Comment)
        {
            PictureBox pictureBoxUserPicture = WinFormControlsGenarator.CreatePictureBox(i_Comment.From.PictureSmallURL);
            pictureBoxUserPicture.Location = new Point(10, 10);
            pictureBoxUserPicture.Size = new Size(40, 40);
            Controls.Add(pictureBoxUserPicture);

            Label labelUserName = WinFormControlsGenarator.CreateLabel(i_Comment.From.Name);
            labelUserName.Location = new Point(60, 10);
            Controls.Add(labelUserName);

            Label labelCommentText = WinFormControlsGenarator.CreateLabel(i_Comment.Message);
            labelCommentText.Location = new Point(60, 40);
            Controls.Add(labelCommentText);

            this.MinimumSize = new Size(430, 0);
            this.MaximumSize = new Size(430, 0);
        }
    }
}
