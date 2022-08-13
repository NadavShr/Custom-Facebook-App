using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PanelPost : BasePanel
    {
        private Post m_Post;

        public PanelPost(Post i_Post)
        {
            this.m_Post = i_Post;

            PictureBox pictureBoxuserPicture = WinFormControlsGenarator.CreatePictureBox(i_Post.From.PictureSmallURL);
            pictureBoxuserPicture.Location = new Point(10, 10);
            pictureBoxuserPicture.Size = new Size(40, 40);
            Controls.Add(pictureBoxuserPicture);

            Label labelUserName = WinFormControlsGenarator.CreateLabel(i_Post.From.Name);
            labelUserName.Location = new Point(60, 10);
            Controls.Add(labelUserName);

            Label labelDate = WinFormControlsGenarator.CreateLabel(i_Post.UpdateTime.ToString());
            labelDate.Location = new Point(60, 40);
            Controls.Add(labelDate);

            Label labelStatus = null;
            if (!String.IsNullOrEmpty(i_Post.Message))
            {
                labelStatus = WinFormControlsGenarator.CreateLabel( Text = i_Post.Message);
                labelStatus.Location = new Point(60, 70);
                Controls.Add(labelStatus);
            }

            PictureBox pictureBoxStatusPicture = null;
            if (!String.IsNullOrEmpty(i_Post.PictureURL))
            {
                pictureBoxStatusPicture = WinFormControlsGenarator.CreatePictureBox(i_Post.PictureURL);
                pictureBoxStatusPicture.Location = String.IsNullOrEmpty(i_Post.Message) ? new Point(60, 70) : new Point(60, 100);
                pictureBoxStatusPicture.Size = new Size(110, 110);
                Controls.Add(pictureBoxStatusPicture);
            }

            LinkLabel linkLabelCommentsLink = WinFormControlsGenarator.CreateLabelLink(String.Format("Comments ({0})", i_Post.Comments.Count), 10);
            linkLabelCommentsLink.Location = calcCommentsLabelLocation(labelStatus, pictureBoxStatusPicture);
            linkLabelCommentsLink.Click += CommentsLink_Click;
            Controls.Add(linkLabelCommentsLink);
        }

        private void CommentsLink_Click(object sender, EventArgs e)
        {
            FormPostComments formPostComments = new FormPostComments(m_Post);
            formPostComments.ShowDialog();
        }

        private Point calcCommentsLabelLocation(Label i_LabelStatusText, PictureBox i_PictureBoxStatusPicture)
        {
            Point location = new Point(60, 70);

            if (i_PictureBoxStatusPicture != null)
            {
                location.Y = i_PictureBoxStatusPicture.Bottom + 20;
            } 
            else if(i_LabelStatusText != null)
            {
                location.Y = i_LabelStatusText.Bottom + 20;
            }

            return location;
        }
    }


}

