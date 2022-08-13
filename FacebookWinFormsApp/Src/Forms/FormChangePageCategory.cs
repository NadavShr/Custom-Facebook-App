using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Src.Forms
{
    public partial class FormChangePageCategory : Form
    {
        private Page          m_ChoosenPage;
        private LogicManager  m_LogicManager;

        public FormChangePageCategory(Page i_Page, LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_ChoosenPage = i_Page;
            m_LogicManager = i_LogicManager;
            initCategoriesList();
        }

        private void initCategoriesList()
        {
            this.comboBoxAllCategory.Items.Clear();
            foreach (String pageCategory in m_LogicManager.GetAllCategories())
            {
                this.comboBoxAllCategory.Items.Add(pageCategory);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (this.comboBoxAllCategory.SelectedItem != null)
            {
                m_LogicManager.ChangePageCategory(m_ChoosenPage, this.comboBoxAllCategory.SelectedItem.ToString());
            }

            this.Close();
        }

        private void comboBoxAllCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonSaveChanges.Enabled = this.comboBoxAllCategory.SelectedItem != null;
        }
    }
}
