namespace BasicFacebookFeatures
{
    partial class FormPostComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostComments));
            this.flowLayoutPanelComments = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelComments
            // 
            this.flowLayoutPanelComments.AutoScroll = true;
            this.flowLayoutPanelComments.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanelComments.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            this.flowLayoutPanelComments.Size = new System.Drawing.Size(624, 395);
            this.flowLayoutPanelComments.TabIndex = 0;
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Location = new System.Drawing.Point(12, 413);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(555, 63);
            this.richTextBoxComment.TabIndex = 1;
            this.richTextBoxComment.Text = "";
            this.richTextBoxComment.TextChanged += new System.EventHandler(this.richTextBoxComment_TextChanged);
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddComment.BackgroundImage")));
            this.buttonAddComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddComment.Enabled = false;
            this.buttonAddComment.Location = new System.Drawing.Point(573, 413);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(63, 63);
            this.buttonAddComment.TabIndex = 2;
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // FormPostComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 483);
            this.Controls.Add(this.buttonAddComment);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.flowLayoutPanelComments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPostComments";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPostComments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComments;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Button buttonAddComment;
    }
}