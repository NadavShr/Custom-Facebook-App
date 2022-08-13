using FacebookWrapper;
using System;
using FacebookLogic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        public LoginResult     LoginResult { get; private set; }
        private LogicManager   m_logicManager;

        public FormLogin(LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_logicManager = i_LogicManager;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                m_logicManager.Login();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception) 
            {
                this.DialogResult = DialogResult.Abort;
            }

            this.Close();
        }
    }
}


