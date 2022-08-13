using BasicFacebookFeatures.Src.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Panels
{
    internal class PanelPage : BasePanel
    {
        private Page          m_Page; 
        private LogicManager  m_LogicManager;
        private Label         m_LabelPageCategory;

        public PanelPage(Page i_Page, String i_PageCategory, LogicManager i_LogicManager)
        {
            m_Page = i_Page;
            m_LogicManager = i_LogicManager;

            PictureBox pictureBoxPagePicture = WinFormControlsGenarator.CreatePictureBox(i_Page.PictureSmallURL);
            pictureBoxPagePicture.Location = new Point(10, 10);
            pictureBoxPagePicture.Size = new Size(40, 40);
            Controls.Add(pictureBoxPagePicture);

            Label labelPageName = WinFormControlsGenarator.CreateLabel(i_Page.Name);
            labelPageName.Location = new Point(60, 10);
            Controls.Add(labelPageName);

            m_LabelPageCategory = WinFormControlsGenarator.CreateLabel("Category:" + i_PageCategory);
            m_LabelPageCategory.Location = new Point(60, 50);
            Controls.Add(m_LabelPageCategory);

            LinkLabel linkLabelChangePageCategory = WinFormControlsGenarator.CreateLabelLink("change Category", 10);
            linkLabelChangePageCategory.Location = new Point(60, 75);
            linkLabelChangePageCategory.Click += ChangePageCategory_Click;
            Controls.Add(linkLabelChangePageCategory);
        }

        private void ChangePageCategory_Click(object sender, EventArgs e)
        {
            FormChangePageCategory formChangePageLabel = new FormChangePageCategory(m_Page, m_LogicManager);

            formChangePageLabel.ShowDialog();
            refreshPageCategory();
        }

        private void refreshPageCategory()
        {
            m_LabelPageCategory.Text = "Category:" + m_LogicManager.GetPagCategory(m_Page);
        }

        public String GetPageCategory()
        {
            return m_LogicManager.GetPagCategory(m_Page);
        }
    }
}


