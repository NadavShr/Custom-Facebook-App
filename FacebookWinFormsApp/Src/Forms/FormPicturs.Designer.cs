namespace BasicFacebookFeatures
{
    partial class FormPicturs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPicturs));
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelPicturs = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxChoosenPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoosenPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddComment.BackgroundImage")));
            this.buttonAddComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddComment.Location = new System.Drawing.Point(903, 635);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(63, 63);
            this.buttonAddComment.TabIndex = 5;
            this.buttonAddComment.UseVisualStyleBackColor = true;
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(553, 635);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(344, 63);
            this.richTextBoxComment.TabIndex = 4;
            this.richTextBoxComment.Text = "";
            // 
            // flowLayoutPanelPicturs
            // 
            this.flowLayoutPanelPicturs.AutoScroll = true;
            this.flowLayoutPanelPicturs.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanelPicturs.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelPicturs.Name = "flowLayoutPanelPicturs";
            this.flowLayoutPanelPicturs.Size = new System.Drawing.Size(415, 133);
            this.flowLayoutPanelPicturs.TabIndex = 3;
            // 
            // pictureBoxChoosenPicture
            // 
            this.pictureBoxChoosenPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxChoosenPicture.Location = new System.Drawing.Point(12, 151);
            this.pictureBoxChoosenPicture.Name = "pictureBoxChoosenPicture";
            this.pictureBoxChoosenPicture.Size = new System.Drawing.Size(415, 415);
            this.pictureBoxChoosenPicture.TabIndex = 6;
            this.pictureBoxChoosenPicture.TabStop = false;
            // 
            // FormPicturs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 578);
            this.Controls.Add(this.pictureBoxChoosenPicture);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.flowLayoutPanelPicturs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPicturs";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPicturs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoosenPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPicturs;
        private System.Windows.Forms.PictureBox pictureBoxChoosenPicture;
    }
}