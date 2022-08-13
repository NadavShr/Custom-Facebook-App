using System;
using System.Collections.Generic;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class LogicManager
    {
        private LoginResult           m_LoginResult;
        private User                  m_User;
        private ManagePageCategory    m_ManagePageCategory;
        private ManageAlbumSlideShow  m_ManageAlbumSlideShow;

        public LogicManager ()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = AppSetting.k_FacebookCollectionLimit;
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(AppSetting.AppId, AppSetting.RequestedPermission);
            if (!string.IsNullOrEmpty(this.m_LoginResult.AccessToken))
            {
                AppSetting.SaveAccessToken(this.m_LoginResult.AccessToken);
                initAfterLogin();
            } 
            else
            {
                throw new Exception("Failed to login");
            } 
        }

        public bool TryAutomaticLogin()
        {
            bool LoginSuccessfully = false;

            if (AppSetting.CheckIfHasAcessToken())
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(AppSetting.LoadAccessToken());
                    initAfterLogin();
                    LoginSuccessfully = true;
                }
                catch (Exception exception)
                {
                    LoginSuccessfully = false;
                }
            }

            return LoginSuccessfully;
        }

        private void initAfterLogin()
        {
            m_User = m_LoginResult.LoggedInUser;
            m_ManagePageCategory = new ManagePageCategory(m_User.LikedPages);
            m_ManageAlbumSlideShow = new ManageAlbumSlideShow(this);
        }

        public void Reset()
        {
            AppSetting.DeleteAccessToken();
            this.m_LoginResult = null;
        }

        public BasicUserDetailsDTO GetBasicUserDetails()
        {
            return new BasicUserDetailsDTO(m_User.PictureLargeURL, m_User.Name, m_User.Birthday, m_User.Location.Name);
        }

        public FacebookObjectCollection<Post> GetWallPosts()
        {
            return m_User.WallPosts;
        }

        public FacebookObjectCollection<Album> GetUserAlbums()
        {
            return m_User.Albums;
        }

        public FacebookObjectCollection<User> GetUserFriends()
        {
            return m_User.Friends;
        }

        public FacebookObjectCollection<Page> GetUserLikedPage()
        {
            return m_User.LikedPages;
        }

        public void PostStatus(String i_Text)
        {
            m_User.PostStatus(i_Text);
        }

        public void AddCategory(String i_NewCategory)
        {
            m_ManagePageCategory.AddCategory(i_NewCategory);
        }

        public void ChangePageCategory(Page i_Page, String i_Category)
        {
            m_ManagePageCategory.ChangePageCategory(i_Page, i_Category);
        }

        public HashSet<String> GetAllCategories()
        {
            HashSet<String> allCategories = new HashSet<String>();

            foreach (String category in m_ManagePageCategory.CategoryToIsActiveFilterMap.Keys)
            {
                allCategories.Add(category);
            }

            return allCategories;
        }

        public Dictionary<Page, String> GetPageToCategoryMap()
        {
            return m_ManagePageCategory.PageToCategoryMap;
        }

        public String GetPagCategory(Page i_Page)
        {
            return m_ManagePageCategory.GetPageCategory(i_Page);
        }

        public void UpdateCategoryActivationFilter(HashSet<String> i_ActivationFilters)
        {
            m_ManagePageCategory.UpdateCategoryActivationFilter(i_ActivationFilters);
        }

        public Dictionary<String, bool> GetCategoryToIsActiveFilterMap()
        {
            return m_ManagePageCategory.CategoryToIsActiveFilterMap;
        }

        public HashSet<String> GetActiveFilters()
        {
            HashSet<string> activeFilters = new HashSet<string>();

            foreach (KeyValuePair<String, bool> entry in GetCategoryToIsActiveFilterMap())
            {
                if (entry.Value == true)
                {
                    activeFilters.Add(entry.Key);
                }
            }
            
            return activeFilters;
        }

        public void SetSelectedAlbumSlideShow(String i_SelectedAlbumName)
        {
            m_ManageAlbumSlideShow.SetSelectedAlbum(i_SelectedAlbumName);
        }

        public String GetSelectedAlbumCoverPicSlideShow()
        {
            return m_ManageAlbumSlideShow.GetSelectedAlbumCoverPic();
        }

        public String BringTheNextPictureUrlSlideShow()
        {
            return m_ManageAlbumSlideShow.BringTheNextPictureUrl();
        }

        public void SetTimerIntervalSlideShow(int i_TimerInterval)
        {
            m_ManageAlbumSlideShow.TimerInterval = i_TimerInterval;
        }

        public int GetTimerIntervalSlideShow()
        {
            return m_ManageAlbumSlideShow.TimerInterval;
        }
    }
}

