using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Src.Forms
{
    public partial class FormAlbumSlideShow : Form
    {
        private LogicManager     m_LogicManager;
        private bool             m_IsPlaying;

        public FormAlbumSlideShow(LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_LogicManager = i_LogicManager;
            radioButtonX1.Checked = true;
            m_IsPlaying = false;
            resetSlideShowPictures();
            initComboBoxAlbumsNames();
        }

        private void resetSlideShowPictures()
        {
            this.pictureBoxAlbumCover.Image = null;
            this.pictureBoxSlideShow.Image = null; 
        }

        private void initComboBoxAlbumsNames()
        {
            comboBoxChooseAlbum.Items.Clear();
            foreach (Album album in m_LogicManager.GetUserAlbums())
            {
                comboBoxChooseAlbum.Items.Add(album.Name);
            }
        }

        private void buttonLoadAlbum_Click(object sender, EventArgs e)
        {
            if (this.comboBoxChooseAlbum.SelectedItem != null)
            {
                String selectedAlbumName = this.comboBoxChooseAlbum.SelectedItem.ToString();
                initAlbumSlideShow(selectedAlbumName);
            }
            else
            {
                MessageBox.Show("Please choose an album from list.");
            }
        }

        private void initAlbumSlideShow(String i_SelectedAlbumName)
        {
            m_LogicManager.SetSelectedAlbumSlideShow(i_SelectedAlbumName);
            resetSlideShowPictures();
            this.pictureBoxAlbumCover.Load(m_LogicManager.GetSelectedAlbumCoverPicSlideShow());
            this.pictureBoxAlbumCover.SizeMode = PictureBoxSizeMode.StretchImage;
            this.buttonPlayStop.Visible = true;
        }

        private void buttonPlayStop_Click(object sender, EventArgs e)
        {
            if (m_IsPlaying)
            {
                buttonPlayStop.Text = "Play";
                SlideShowTimer.Stop();
                m_IsPlaying = false;
            }
            else
            {
                buttonPlayStop.Text = "Stop";
                SlideShowTimer.Start();
                m_IsPlaying = true;
            }
        }

        private void slideShowTimer_Tick(object sender, EventArgs e)
        {
            this.pictureBoxSlideShow.Load(m_LogicManager.BringTheNextPictureUrlSlideShow());
            this.pictureBoxSlideShow.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            int timerInterval = 0;

            switch (radioButton.Text.ToString())
            {
                case "1x":
                    timerInterval = 3000;
                    break;
                case "2x":
                    timerInterval = 1500;
                    break;
                case "3x":
                    timerInterval = 1000;
                    break;
            }

            m_LogicManager.SetTimerIntervalSlideShow(timerInterval);
            this.SlideShowTimer.Interval = timerInterval;
        }       
    }
}