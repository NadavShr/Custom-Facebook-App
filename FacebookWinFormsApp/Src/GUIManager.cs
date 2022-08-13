using FacebookWrapper;
using System;
using System.Windows.Forms;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public class GUIManager
    {
        private LogicManager        m_LogicManager;
        private readonly FormLogin  r_FormLogin;
        private readonly FormMain   r_FormMain;
        private bool                m_UserLoggedIn;
        private bool                m_DoRetryApp;

        public GUIManager ()
        {
            this.m_LogicManager = new LogicManager();
            this.r_FormLogin = new FormLogin(m_LogicManager);
            this.r_FormMain = new FormMain(m_LogicManager);
            this.m_UserLoggedIn = false;
            this.m_DoRetryApp = true;
            initialForms();
        }

        private void initialForms ()
        {
            this.r_FormMain.LogOut += logout;
        }

        public void Start()
        {
            do
            {
                startApp();
            } while (m_DoRetryApp);
        }

        private void startApp()
        {
            login();
            if (m_UserLoggedIn)
            {
                this.r_FormMain.ShowDialog();
                onFormMainClosed();
            }
        }

        private void login()
        {
            if (!tryAutomaticLogin())
            {
                this.r_FormLogin.ShowDialog();
                if (this.r_FormLogin.DialogResult == DialogResult.OK)
                {
                    m_UserLoggedIn = true;
                }
                else if (this.r_FormLogin.DialogResult == DialogResult.Cancel)
                {
                    m_DoRetryApp = false;
                }
            }
            else
            {
                m_UserLoggedIn = true;
            }
        }

        private bool tryAutomaticLogin()
        {
            bool loginSuccessfully = false;

            if (m_LogicManager.TryAutomaticLogin())
            {
                loginSuccessfully = true;
            }
            else
            {
                resetApp();
            }

            return loginSuccessfully;
        }

        private void logout()
        {
            resetApp();
        }

        private void resetApp()
        {
            m_LogicManager.Reset();
            this.m_UserLoggedIn = false;
        }

        private void onFormMainClosed ()
        {
            if (this.r_FormMain.DialogResult == DialogResult.Retry)
            {
                this.m_DoRetryApp = true;
            } 
            else
            {
                this.m_DoRetryApp = false;
            }
        } 
    }
}
