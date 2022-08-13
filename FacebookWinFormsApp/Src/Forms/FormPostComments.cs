using BasicFacebookFeatures.Panels;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPostComments : Form
    {
        private Post m_Post;

        public FormPostComments(Post i_Post)
        {
            InitializeComponent();
            this.m_Post = i_Post;
            fetchComments();
        }

        private void fetchComments()
        {
            this.flowLayoutPanelComments.Controls.Clear();
            foreach (Comment comment in m_Post.Comments) {
                this.flowLayoutPanelComments.Controls.Add(new PanelComment(comment));
            }
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.richTextBoxComment.Text))
            {
                richTextBoxComment.Text = String.Empty;
                try
                {
                    m_Post.Comment(this.richTextBoxComment.Text);
                    fetchComments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("add a comment is no longer supported");
                }
            }
        }

        private void richTextBoxComment_TextChanged(object sender, EventArgs e)
        {
            this.buttonAddComment.Enabled = !string.IsNullOrEmpty(this.richTextBoxComment.Text);
        }
    }
}
