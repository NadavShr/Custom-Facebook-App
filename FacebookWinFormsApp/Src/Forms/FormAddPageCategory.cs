using FacebookLogic;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Src.Forms
{
    public partial class FormAddPageCategory : Form
    {
        private LogicManager m_LogicManager;

        public FormAddPageCategory(LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_LogicManager = i_LogicManager;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String newPageCategoryName = this.TextBoxCategoryName.Text;

            if (!string.IsNullOrEmpty(newPageCategoryName))
            {
                try
                {
                    m_LogicManager.AddCategory(newPageCategoryName);
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void TextBoxCategoryName_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = !string.IsNullOrEmpty(this.TextBoxCategoryName.Text);
        }
    }
}
