namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.pictureBoxUserPicture = new System.Windows.Forms.PictureBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.buttonRefreshApp = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonPlaySlideShow = new System.Windows.Forms.Button();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.textBoxAddPost = new System.Windows.Forms.RichTextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkedListBoxCategoriesFilter = new System.Windows.Forms.CheckedListBox();
            this.buttonFilterPagesByCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.flowLayoutPanelPages = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1374, 952);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(128, 28);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelFacebook
            // 
            this.labelFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFacebook.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelFacebook.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.ForeColor = System.Drawing.Color.White;
            this.labelFacebook.Location = new System.Drawing.Point(-1, -6);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(1517, 137);
            this.labelFacebook.TabIndex = 0;
            this.labelFacebook.Text = "Facebook";
            this.labelFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxUserPicture
            // 
            this.pictureBoxUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserPicture.Location = new System.Drawing.Point(1262, 167);
            this.pictureBoxUserPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUserPicture.Name = "pictureBoxUserPicture";
            this.pictureBoxUserPicture.Size = new System.Drawing.Size(240, 228);
            this.pictureBoxUserPicture.TabIndex = 54;
            this.pictureBoxUserPicture.TabStop = false;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelFullName.Location = new System.Drawing.Point(1261, 421);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(114, 25);
            this.labelFullName.TabIndex = 55;
            this.labelFullName.Text = "Full Name";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelLocation.Location = new System.Drawing.Point(1262, 521);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(96, 25);
            this.labelLocation.TabIndex = 57;
            this.labelLocation.Text = "Location";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelBirthdate.Location = new System.Drawing.Point(1262, 473);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(106, 25);
            this.labelBirthdate.TabIndex = 59;
            this.labelBirthdate.Text = "Birthdate";
            // 
            // buttonRefreshApp
            // 
            this.buttonRefreshApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshApp.BackgroundImage")));
            this.buttonRefreshApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshApp.Location = new System.Drawing.Point(1266, 930);
            this.buttonRefreshApp.Name = "buttonRefreshApp";
            this.buttonRefreshApp.Size = new System.Drawing.Size(50, 50);
            this.buttonRefreshApp.TabIndex = 61;
            this.buttonRefreshApp.UseVisualStyleBackColor = false;
            this.buttonRefreshApp.Click += new System.EventHandler(this.buttonRefreshApp_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanelFriends);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1234, 809);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Friends";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelFriends
            // 
            this.flowLayoutPanelFriends.AutoScroll = true;
            this.flowLayoutPanelFriends.Location = new System.Drawing.Point(20, 21);
            this.flowLayoutPanelFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
            this.flowLayoutPanelFriends.Size = new System.Drawing.Size(1199, 737);
            this.flowLayoutPanelFriends.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonPlaySlideShow);
            this.tabPage2.Controls.Add(this.flowLayoutPanelAlbums);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1234, 809);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonPlaySlideShow
            // 
            this.buttonPlaySlideShow.Location = new System.Drawing.Point(26, 25);
            this.buttonPlaySlideShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlaySlideShow.Name = "buttonPlaySlideShow";
            this.buttonPlaySlideShow.Size = new System.Drawing.Size(368, 44);
            this.buttonPlaySlideShow.TabIndex = 2;
            this.buttonPlaySlideShow.Text = "Play Slide Show";
            this.buttonPlaySlideShow.UseVisualStyleBackColor = true;
            this.buttonPlaySlideShow.Click += new System.EventHandler(this.buttonPlaySlideShow_Click);
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(26, 96);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(1182, 689);
            this.flowLayoutPanelAlbums.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.flowPosts);
            this.tabPage1.Controls.Add(this.buttonAddPost);
            this.tabPage1.Controls.Add(this.textBoxAddPost);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(1234, 809);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Feed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowPosts
            // 
            this.flowPosts.AutoScroll = true;
            this.flowPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowPosts.Location = new System.Drawing.Point(19, 106);
            this.flowPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowPosts.Name = "flowPosts";
            this.flowPosts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowPosts.Size = new System.Drawing.Size(1193, 681);
            this.flowPosts.TabIndex = 2;
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.Font = new System.Drawing.Font("Verdana", 12F);
            this.buttonAddPost.Location = new System.Drawing.Point(922, 8);
            this.buttonAddPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(290, 86);
            this.buttonAddPost.TabIndex = 1;
            this.buttonAddPost.Text = "Add post";
            this.buttonAddPost.UseVisualStyleBackColor = false;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // textBoxAddPost
            // 
            this.textBoxAddPost.Location = new System.Drawing.Point(19, 8);
            this.textBoxAddPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddPost.Name = "textBoxAddPost";
            this.textBoxAddPost.Size = new System.Drawing.Size(897, 86);
            this.textBoxAddPost.TabIndex = 0;
            this.textBoxAddPost.Text = "";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(9, 133);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1242, 847);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkedListBoxCategoriesFilter);
            this.tabPage4.Controls.Add(this.buttonFilterPagesByCategory);
            this.tabPage4.Controls.Add(this.buttonAddCategory);
            this.tabPage4.Controls.Add(this.flowLayoutPanelPages);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1234, 809);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pages";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCategoriesFilter
            // 
            this.checkedListBoxCategoriesFilter.FormattingEnabled = true;
            this.checkedListBoxCategoriesFilter.Location = new System.Drawing.Point(483, 22);
            this.checkedListBoxCategoriesFilter.Name = "checkedListBoxCategoriesFilter";
            this.checkedListBoxCategoriesFilter.Size = new System.Drawing.Size(347, 247);
            this.checkedListBoxCategoriesFilter.TabIndex = 3;
            this.checkedListBoxCategoriesFilter.Visible = false;
            // 
            // buttonFilterPagesByCategory
            // 
            this.buttonFilterPagesByCategory.Location = new System.Drawing.Point(217, 22);
            this.buttonFilterPagesByCategory.Name = "buttonFilterPagesByCategory";
            this.buttonFilterPagesByCategory.Size = new System.Drawing.Size(252, 40);
            this.buttonFilterPagesByCategory.TabIndex = 4;
            this.buttonFilterPagesByCategory.Text = "Filter By Category";
            this.buttonFilterPagesByCategory.UseVisualStyleBackColor = true;
            this.buttonFilterPagesByCategory.Click += new System.EventHandler(this.buttonFilterPagesByCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(18, 22);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(174, 40);
            this.buttonAddCategory.TabIndex = 2;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // flowLayoutPanelPages
            // 
            this.flowLayoutPanelPages.AutoScroll = true;
            this.flowLayoutPanelPages.Location = new System.Drawing.Point(18, 86);
            this.flowLayoutPanelPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelPages.Name = "flowLayoutPanelPages";
            this.flowLayoutPanelPages.Size = new System.Drawing.Size(1192, 700);
            this.flowLayoutPanelPages.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 993);
            this.Controls.Add(this.buttonRefreshApp);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.pictureBoxUserPicture);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelFacebook);
            this.Controls.Add(this.buttonLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook app";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.PictureBox pictureBoxUserPicture;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Button buttonRefreshApp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFriends;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowPosts;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.RichTextBox textBoxAddPost;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPages;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategoriesFilter;
        private System.Windows.Forms.Button buttonFilterPagesByCategory;
        private System.Windows.Forms.Button buttonPlaySlideShow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
    }
}

