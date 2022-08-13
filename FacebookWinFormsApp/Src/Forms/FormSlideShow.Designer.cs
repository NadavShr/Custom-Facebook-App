
namespace BasicFacebookFeatures.Src.Forms
{
    partial class FormAlbumSlideShow
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
            this.components = new System.ComponentModel.Container();
            this.buttonPlayStop = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelChooseAlbum = new System.Windows.Forms.Label();
            this.comboBoxChooseAlbum = new System.Windows.Forms.ComboBox();
            this.pictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
            this.radioButtonX1 = new System.Windows.Forms.RadioButton();
            this.radioButtonX2 = new System.Windows.Forms.RadioButton();
            this.radioButtonX3 = new System.Windows.Forms.RadioButton();
            this.pictureBoxSlideShow = new System.Windows.Forms.PictureBox();
            this.SlideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonLoadAlbum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlayStop
            // 
            this.buttonPlayStop.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonPlayStop.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayStop.Location = new System.Drawing.Point(28, 106);
            this.buttonPlayStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlayStop.Name = "buttonPlayStop";
            this.buttonPlayStop.Size = new System.Drawing.Size(148, 42);
            this.buttonPlayStop.TabIndex = 0;
            this.buttonPlayStop.Text = "Play";
            this.buttonPlayStop.UseVisualStyleBackColor = true;
            this.buttonPlayStop.Visible = false;
            this.buttonPlayStop.Click += new System.EventHandler(this.buttonPlayStop_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(23, 65);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(83, 25);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Speed:";
            // 
            // labelChooseAlbum
            // 
            this.labelChooseAlbum.AutoSize = true;
            this.labelChooseAlbum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseAlbum.Location = new System.Drawing.Point(23, 23);
            this.labelChooseAlbum.Name = "labelChooseAlbum";
            this.labelChooseAlbum.Size = new System.Drawing.Size(163, 25);
            this.labelChooseAlbum.TabIndex = 3;
            this.labelChooseAlbum.Text = "Choose album:";
            // 
            // comboBoxChooseAlbum
            // 
            this.comboBoxChooseAlbum.FormattingEnabled = true;
            this.comboBoxChooseAlbum.Location = new System.Drawing.Point(208, 23);
            this.comboBoxChooseAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChooseAlbum.MaximumSize = new System.Drawing.Size(150, 0);
            this.comboBoxChooseAlbum.MinimumSize = new System.Drawing.Size(150, 0);
            this.comboBoxChooseAlbum.Name = "comboBoxChooseAlbum";
            this.comboBoxChooseAlbum.Size = new System.Drawing.Size(150, 24);
            this.comboBoxChooseAlbum.TabIndex = 4;
            // 
            // pictureBoxAlbumCover
            // 
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(588, 14);
            this.pictureBoxAlbumCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(143, 134);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlbumCover.TabIndex = 5;
            this.pictureBoxAlbumCover.TabStop = false;
            // 
            // radioButtonX1
            // 
            this.radioButtonX1.AutoSize = true;
            this.radioButtonX1.Location = new System.Drawing.Point(208, 65);
            this.radioButtonX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonX1.Name = "radioButtonX1";
            this.radioButtonX1.Size = new System.Drawing.Size(43, 21);
            this.radioButtonX1.TabIndex = 6;
            this.radioButtonX1.TabStop = true;
            this.radioButtonX1.Text = "1x";
            this.radioButtonX1.UseVisualStyleBackColor = true;
            this.radioButtonX1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonX2
            // 
            this.radioButtonX2.AutoSize = true;
            this.radioButtonX2.Location = new System.Drawing.Point(256, 65);
            this.radioButtonX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonX2.Name = "radioButtonX2";
            this.radioButtonX2.Size = new System.Drawing.Size(43, 21);
            this.radioButtonX2.TabIndex = 7;
            this.radioButtonX2.TabStop = true;
            this.radioButtonX2.Text = "2x";
            this.radioButtonX2.UseVisualStyleBackColor = true;
            this.radioButtonX2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonX3
            // 
            this.radioButtonX3.AutoSize = true;
            this.radioButtonX3.Location = new System.Drawing.Point(307, 65);
            this.radioButtonX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonX3.Name = "radioButtonX3";
            this.radioButtonX3.Size = new System.Drawing.Size(43, 21);
            this.radioButtonX3.TabIndex = 8;
            this.radioButtonX3.TabStop = true;
            this.radioButtonX3.Text = "3x";
            this.radioButtonX3.UseVisualStyleBackColor = true;
            this.radioButtonX3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // pictureBoxSlideShow
            // 
            this.pictureBoxSlideShow.Location = new System.Drawing.Point(14, 161);
            this.pictureBoxSlideShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSlideShow.Name = "pictureBoxSlideShow";
            this.pictureBoxSlideShow.Padding = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.pictureBoxSlideShow.Size = new System.Drawing.Size(717, 716);
            this.pictureBoxSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlideShow.TabIndex = 9;
            this.pictureBoxSlideShow.TabStop = false;
            // 
            // SlideShowTimer
            // 
            this.SlideShowTimer.Tick += new System.EventHandler(this.slideShowTimer_Tick);
            // 
            // buttonLoadAlbum
            // 
            this.buttonLoadAlbum.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadAlbum.Location = new System.Drawing.Point(376, 11);
            this.buttonLoadAlbum.Name = "buttonLoadAlbum";
            this.buttonLoadAlbum.Size = new System.Drawing.Size(149, 36);
            this.buttonLoadAlbum.TabIndex = 10;
            this.buttonLoadAlbum.Text = "Load Album";
            this.buttonLoadAlbum.UseVisualStyleBackColor = true;
            this.buttonLoadAlbum.Click += new System.EventHandler(this.buttonLoadAlbum_Click);
            // 
            // FormAlbumSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(760, 902);
            this.Controls.Add(this.buttonLoadAlbum);
            this.Controls.Add(this.pictureBoxSlideShow);
            this.Controls.Add(this.radioButtonX3);
            this.Controls.Add(this.radioButtonX2);
            this.Controls.Add(this.radioButtonX1);
            this.Controls.Add(this.pictureBoxAlbumCover);
            this.Controls.Add(this.comboBoxChooseAlbum);
            this.Controls.Add(this.labelChooseAlbum);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonPlayStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbumSlideShow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Slide Show";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayStop;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelChooseAlbum;
        private System.Windows.Forms.ComboBox comboBoxChooseAlbum;
        private System.Windows.Forms.PictureBox pictureBoxAlbumCover;
        private System.Windows.Forms.RadioButton radioButtonX1;
        private System.Windows.Forms.RadioButton radioButtonX2;
        private System.Windows.Forms.RadioButton radioButtonX3;
        private System.Windows.Forms.PictureBox pictureBoxSlideShow;
        private System.Windows.Forms.Timer SlideShowTimer;
        private System.Windows.Forms.Button buttonLoadAlbum;
    }
}