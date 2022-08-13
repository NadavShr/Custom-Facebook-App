using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures.Panels;
using BasicFacebookFeatures.Src.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public delegate void LogOut();

    public partial class FormMain : Form
    {
        public event LogOut    LogOut;
        private LogicManager   m_LogicManager;
        private bool           m_fetchPosts;   
        
        public FormMain(LogicManager i_LogicManager)
        {
            InitializeComponent();
            this.m_LogicManager = i_LogicManager;
            m_fetchPosts = false;
        }

        protected override void OnShown(EventArgs e)
        {
            initUserInfo();
            initPostFeed();
            initAlbumFeed();
            initFriendsFeed();
            initPagesFeed();
        }

        private void initUserInfo()
        {
            BasicUserDetailsDTO basicUserDetails = m_LogicManager.GetBasicUserDetails();

            pictureBoxUserPicture.LoadAsync(basicUserDetails.ProfilePictureUrl);
            pictureBoxUserPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            labelFullName.Text = basicUserDetails.FullName;
            labelBirthdate.Text = basicUserDetails.BirthDay;
            labelLocation.Text = basicUserDetails.Location;
        }

        private void initPostFeed()
        {
            this.flowPosts.Controls.Clear();
            foreach (Post post in m_LogicManager.GetWallPosts())
            {
                this.flowPosts.Controls.Add(new PanelPost(post));
            }

            if (flowPosts.Controls.Count == 0)
            {
                MessageBox.Show("There are no posts to display.");
            }
        }

        private void initAlbumFeed()
        {
            flowLayoutPanelAlbums.Controls.Clear();
            foreach (Album album in m_LogicManager.GetUserAlbums())
            {
                this.flowLayoutPanelAlbums.Controls.Add(new PanelAlbum(album));
            }

            if (flowLayoutPanelAlbums.Controls.Count == 0)
            {
                MessageBox.Show("There are no albums to display.");
            }
        }

        private void initFriendsFeed()
        {
            this.flowLayoutPanelFriends.Controls.Clear();
            foreach (User friend in m_LogicManager.GetUserFriends())
            {
                this.flowLayoutPanelFriends.Controls.Add(new PanelFriend(friend));
            }

            if (flowLayoutPanelFriends.Controls.Count == 0)
            {
                MessageBox.Show("There are no friend to display.");
            }
        }

        private void initPagesFeed()
        {
            this.flowLayoutPanelPages.Controls.Clear();
            foreach (KeyValuePair<Page, string> entry in m_LogicManager.GetPageToCategoryMap())
            {
                this.flowLayoutPanelPages.Controls.Add(new PanelPage(entry.Key, entry.Value, m_LogicManager));
            }

            if (flowLayoutPanelPages.Controls.Count == 0)
            {
                MessageBox.Show("There are no pages to display.");
            }

            filterPagesByCategory();
        }

        private void filterPagesByCategory()
        {
            HashSet<String> activeFilters = m_LogicManager.GetActiveFilters();

            if (activeFilters.Count > 0)
            {
                foreach (PanelPage panelPage in flowLayoutPanelPages.Controls)
                {
                    panelPage.Visible = activeFilters.Contains(panelPage.GetPageCategory());
                }
            }
            else
            {
                foreach (PanelPage panelPage in flowLayoutPanelPages.Controls)
                {
                    panelPage.Visible = true;
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogOut();
            DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void buttonRefreshApp_Click(object sender, EventArgs e)
        {
            reloadApp();
        }

        private void reloadApp()
        {
            if (m_fetchPosts)
            {
                initPostFeed();
                m_fetchPosts = false;
            }
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        { 
            try
            {
                m_LogicManager.PostStatus(textBoxAddPost.Text);
                m_fetchPosts = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Post status no longer supported.");
            }

            textBoxAddPost.Clear();
        }

        private void buttonFilterPagesByCategory_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCategoriesFilter.Visible)
            {
                checkedListBoxCategoriesFilter.Visible = false;
                buttonFilterPagesByCategory.Text = "Filter By Category";
                updateActivationFilters();
                filterPagesByCategory();
            }
            else
            {
                initCheckedListBoxFilters();
                checkedListBoxCategoriesFilter.Visible = true;
                buttonFilterPagesByCategory.Text = "Filter and Close";
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddPageCategory formAddPageCaregory = new FormAddPageCategory(m_LogicManager);

            formAddPageCaregory.ShowDialog();
        }

        private void initCheckedListBoxFilters()
        {
            this.checkedListBoxCategoriesFilter.Items.Clear();
            foreach (KeyValuePair<String, bool> entry in m_LogicManager.GetCategoryToIsActiveFilterMap())
            {
                this.checkedListBoxCategoriesFilter.Items.Add(entry.Key, entry.Value);
            }
        }

        private void updateActivationFilters()
        {
            HashSet<String> activationFilters = new HashSet<String>();

            foreach (String activationFilter in checkedListBoxCategoriesFilter.CheckedItems)
            {
                activationFilters.Add(activationFilter);
            }

            m_LogicManager.UpdateCategoryActivationFilter(activationFilters);
        }

        private void buttonPlaySlideShow_Click(object sender, EventArgs e)
        {
            FormAlbumSlideShow formSlideShow = new FormAlbumSlideShow(m_LogicManager);
            formSlideShow.ShowDialog();
        }
    }
}
