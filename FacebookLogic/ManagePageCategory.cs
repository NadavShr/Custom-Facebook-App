using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookLogic
{
    internal class ManagePageCategory
    {
        public Dictionary<String, bool>   CategoryToIsActiveFilterMap { get; private set; }
        public Dictionary<Page, String>   PageToCategoryMap { get; }
        private readonly String           r_DefualtCategory = "None";
        private readonly bool             r_DefaultActivation = false;

        public ManagePageCategory(FacebookObjectCollection<Page> i_Pages)
        {
            this.CategoryToIsActiveFilterMap = new Dictionary<String, bool>();
            this.PageToCategoryMap = new Dictionary<Page, string>();
            initPageToCategoryMap(i_Pages);
        }

        private void initPageToCategoryMap(FacebookObjectCollection<Page> i_Pages)
        {
            this.CategoryToIsActiveFilterMap.Add(r_DefualtCategory, r_DefaultActivation);
            foreach (Page page in i_Pages)
            {
                this.PageToCategoryMap.Add(page, r_DefualtCategory);
            }
        }

        public void AddCategory(String i_NewCategory)
        {
            if (CategoryToIsActiveFilterMap.ContainsKey(i_NewCategory)) {
                throw new ArgumentException(String.Format("Category named: {0} Already Exist.", i_NewCategory));
            }

            this.CategoryToIsActiveFilterMap.Add(i_NewCategory, r_DefaultActivation);
        }

        public void RemoveCategory(String i_Category)
        {
            if (!CategoryToIsActiveFilterMap.ContainsKey(i_Category))
            {
                throw new ArgumentException(String.Format("Category named: {0} does not Exist.", i_Category));
            }

            this.CategoryToIsActiveFilterMap.Remove(i_Category);
        }

        public void ChangePageCategory(Page i_Page, String i_Category)
        {
            if (!this.CategoryToIsActiveFilterMap.ContainsKey(i_Category))
            {
                AddCategory(i_Category);
            }

            if (!this.PageToCategoryMap.ContainsKey(i_Page))
            {
                throw new ArgumentException(String.Format("Page named: {0} does not Exist.", i_Page.Name));
            }

            this.PageToCategoryMap[i_Page] = i_Category;
        }

        public String GetPageCategory(Page i_Page)
        {
            if (!this.PageToCategoryMap.ContainsKey(i_Page))
            {
                throw new ArgumentException(String.Format("Page named: {0} does not Exist.", i_Page.Name));
            }

            this.PageToCategoryMap.TryGetValue(i_Page, out String pageCategory);

            return pageCategory;
        }

        public void UpdateCategoryActivationFilter(HashSet<String> i_ActivationFilters)
        {
            List<string> categories = new List<string>(CategoryToIsActiveFilterMap.Keys);

            foreach (String category in categories)
            {
                if (i_ActivationFilters.Contains(category))
                {
                    this.CategoryToIsActiveFilterMap[category] = true;
                }
                else
                {
                    this.CategoryToIsActiveFilterMap[category] = false;
                }
            }
        }
    }
}