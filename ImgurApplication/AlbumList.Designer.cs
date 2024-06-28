namespace ImgurApplication
{
    partial class AlbumList
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
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.imageFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // albumComboBox
            // 
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(39, 34);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(182, 23);
            this.albumComboBox.TabIndex = 0;
            this.albumComboBox.SelectedIndexChanged += new System.EventHandler(this.albumComboBox_SelectedIndexChanged);
            // 
            // imageFlowLayout
            // 
            this.imageFlowLayout.AutoScroll = true;
            this.imageFlowLayout.Location = new System.Drawing.Point(12, 76);
            this.imageFlowLayout.Name = "imageFlowLayout";
            this.imageFlowLayout.Size = new System.Drawing.Size(627, 421);
            this.imageFlowLayout.TabIndex = 1;
            // 
            // AlbumList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 509);
            this.Controls.Add(this.imageFlowLayout);
            this.Controls.Add(this.albumComboBox);
            this.Name = "AlbumList";
            this.Text = "AlbumList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.FlowLayoutPanel imageFlowLayout;
    }
}