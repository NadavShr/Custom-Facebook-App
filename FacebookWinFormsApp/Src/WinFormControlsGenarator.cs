using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class WinFormControlsGenarator
    {
        public static Label CreateLabel(String i_Text)
        {
            Label label = new Label {
                Text = i_Text,
                Font = new System.Drawing.Font("Verdana", 12, FontStyle.Regular, GraphicsUnit.Point, 0),
                TextAlign = ContentAlignment.TopLeft,
                Margin = new Padding(3, 0, 3, 0),
                Padding = new Padding(0),
                AutoSize = true
            };

            return label;
        }

        public static PictureBox CreatePictureBox(String i_ImgUrl)
        {
            PictureBox pictureBox = new PictureBox { SizeMode = PictureBoxSizeMode.StretchImage };
            pictureBox.LoadAsync(i_ImgUrl);

            return pictureBox;
        }

        public static LinkLabel CreateLabelLink(string i_Text, float i_FontSize)
        {
            LinkLabel linkLabel = new LinkLabel
            {
                Text = i_Text,
                Font = new System.Drawing.Font("Verdana", i_FontSize, FontStyle.Regular, GraphicsUnit.Point, 0),
                LinkColor = System.Drawing.SystemColors.MenuHighlight,
                Margin = new Padding(3, 0, 3, 0),
                Padding = new Padding(0),
                AutoSize = true
            };

            linkLabel.Margin = new Padding(3, 0, 3, 0);
            linkLabel.Padding = new Padding(0);
            linkLabel.AutoSize = true;

            return linkLabel;
        }
    }
}
