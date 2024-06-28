namespace ImgurApplication
{
    partial class ImageUpload
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.desBox = new System.Windows.Forms.TextBox();
            this.titleLab = new System.Windows.Forms.Label();
            this.desLab = new System.Windows.Forms.Label();
            this.postBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLab = new System.Windows.Forms.Label();
            this.albumCheck = new System.Windows.Forms.CheckBox();
            this.albumLab = new System.Windows.Forms.Label();
            this.albumBox = new System.Windows.Forms.TextBox();
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(119, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.uploadImage);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(119, 25);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(264, 25);
            this.titleBox.TabIndex = 1;
            this.titleBox.Text = "測試圖片標題";
            // 
            // desBox
            // 
            this.desBox.Location = new System.Drawing.Point(119, 102);
            this.desBox.Multiline = true;
            this.desBox.Name = "desBox";
            this.desBox.Size = new System.Drawing.Size(264, 59);
            this.desBox.TabIndex = 2;
            this.desBox.Text = "測試圖片描述";
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Location = new System.Drawing.Point(67, 29);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(37, 15);
            this.titleLab.TabIndex = 3;
            this.titleLab.Text = "標題";
            // 
            // desLab
            // 
            this.desLab.AutoSize = true;
            this.desLab.Location = new System.Drawing.Point(70, 121);
            this.desLab.Name = "desLab";
            this.desLab.Size = new System.Drawing.Size(37, 15);
            this.desLab.TabIndex = 4;
            this.desLab.Text = "描述";
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(455, 25);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(103, 46);
            this.postBtn.TabIndex = 5;
            this.postBtn.Text = "上傳";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(119, 66);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(264, 25);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "測試圖片名稱";
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(67, 71);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(37, 15);
            this.nameLab.TabIndex = 7;
            this.nameLab.Text = "名稱";
            // 
            // albumCheck
            // 
            this.albumCheck.AutoSize = true;
            this.albumCheck.Location = new System.Drawing.Point(439, 102);
            this.albumCheck.Name = "albumCheck";
            this.albumCheck.Size = new System.Drawing.Size(119, 19);
            this.albumCheck.TabIndex = 8;
            this.albumCheck.Text = "是否建立相簿";
            this.albumCheck.UseVisualStyleBackColor = true;
            this.albumCheck.CheckedChanged += new System.EventHandler(this.albumCheck_CheckedChanged);
            // 
            // albumLab
            // 
            this.albumLab.AutoSize = true;
            this.albumLab.Location = new System.Drawing.Point(40, 180);
            this.albumLab.Name = "albumLab";
            this.albumLab.Size = new System.Drawing.Size(67, 15);
            this.albumLab.TabIndex = 9;
            this.albumLab.Text = "相簿名稱";
            // 
            // albumBox
            // 
            this.albumBox.Enabled = false;
            this.albumBox.Location = new System.Drawing.Point(430, 127);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(152, 25);
            this.albumBox.TabIndex = 10;
            this.albumBox.Text = "相簿名稱";
            // 
            // albumComboBox
            // 
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.Location = new System.Drawing.Point(119, 177);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(264, 23);
            this.albumComboBox.TabIndex = 11;
            // 
            // ImageUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 472);
            this.Controls.Add(this.albumComboBox);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.albumLab);
            this.Controls.Add(this.albumCheck);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.desLab);
            this.Controls.Add(this.titleLab);
            this.Controls.Add(this.desBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageUpload";
            this.Text = "ImageUpload";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox desBox;
        private System.Windows.Forms.Label titleLab;
        private System.Windows.Forms.Label desLab;
        private System.Windows.Forms.Button postBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.CheckBox albumCheck;
        private System.Windows.Forms.Label albumLab;
        private System.Windows.Forms.TextBox albumBox;
        private System.Windows.Forms.ComboBox albumComboBox;
    }
}