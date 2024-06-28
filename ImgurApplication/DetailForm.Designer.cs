namespace ImgurApplication
{
    partial class DetailForm
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
            this.labelUp = new System.Windows.Forms.Label();
            this.labelDown = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelViews = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.postBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelUp.Location = new System.Drawing.Point(29, 153);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(33, 40);
            this.labelUp.TabIndex = 0;
            this.labelUp.Tag = "up";
            this.labelUp.Text = "⬆";
            this.labelUp.Click += new System.EventHandler(this.vote_Click);
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDown.Location = new System.Drawing.Point(29, 282);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(33, 40);
            this.labelDown.TabIndex = 1;
            this.labelDown.Tag = "down";
            this.labelDown.Text = "⬇";
            this.labelDown.Click += new System.EventHandler(this.vote_Click);
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPoint.Location = new System.Drawing.Point(21, 232);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(51, 28);
            this.labelPoint.TabIndex = 2;
            this.labelPoint.Text = "282";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(21, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "👁️‍🗨️";
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelViews.Location = new System.Drawing.Point(12, 471);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(64, 28);
            this.labelViews.TabIndex = 4;
            this.labelViews.Text = "5000";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(142, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 582);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(533, 136);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(513, 582);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(139, 40);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(53, 20);
            this.title.TabIndex = 8;
            this.title.Text = "label6";
            this.title.Click += new System.EventHandler(this.label6_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(5, 3);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(469, 61);
            this.commentBox.TabIndex = 9;
            // 
            // postBtn
            // 
            this.postBtn.AutoSize = true;
            this.postBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.postBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.postBtn.Location = new System.Drawing.Point(423, 69);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(41, 19);
            this.postBtn.TabIndex = 10;
            this.postBtn.Text = "Post";
            this.postBtn.Click += new System.EventHandler(this.postBtnClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentID);
            this.panel1.Controls.Add(this.commentBox);
            this.panel1.Controls.Add(this.postBtn);
            this.panel1.Location = new System.Drawing.Point(554, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 94);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.commentID.AutoSize = true;
            this.commentID.Location = new System.Drawing.Point(14, 69);
            this.commentID.Name = "commentID";
            this.commentID.Size = new System.Drawing.Size(0, 15);
            this.commentID.TabIndex = 11;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelViews);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelDown);
            this.Controls.Add(this.labelUp);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label postBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label commentID;
    }
}