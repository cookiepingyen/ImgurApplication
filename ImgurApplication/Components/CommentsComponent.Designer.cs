namespace ImgurApplication.Components
{
    partial class CommentsComponent
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLab = new System.Windows.Forms.Label();
            this.upLab = new System.Windows.Forms.Label();
            this.downLab = new System.Windows.Forms.Label();
            this.pointsLab = new System.Windows.Forms.Label();
            this.replies = new System.Windows.Forms.Label();
            this.authorLab = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.reply = new System.Windows.Forms.Label();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Location = new System.Drawing.Point(3, 0);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(34, 15);
            this.titleLab.TabIndex = 0;
            this.titleLab.Text = "Title";
            // 
            // upLab
            // 
            this.upLab.AutoSize = true;
            this.upLab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.upLab.Location = new System.Drawing.Point(14, 100);
            this.upLab.Name = "upLab";
            this.upLab.Size = new System.Drawing.Size(28, 30);
            this.upLab.TabIndex = 1;
            this.upLab.Tag = "up";
            this.upLab.Text = "⬆";
            this.upLab.UseCompatibleTextRendering = true;
            this.upLab.Click += new System.EventHandler(this.CommentVote);
            // 
            // downLab
            // 
            this.downLab.AutoSize = true;
            this.downLab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.downLab.Location = new System.Drawing.Point(67, 100);
            this.downLab.Name = "downLab";
            this.downLab.Size = new System.Drawing.Size(28, 30);
            this.downLab.TabIndex = 2;
            this.downLab.Tag = "down";
            this.downLab.Text = "⬇";
            this.downLab.UseCompatibleTextRendering = true;
            this.downLab.Click += new System.EventHandler(this.CommentVote);
            // 
            // pointsLab
            // 
            this.pointsLab.AutoSize = true;
            this.pointsLab.Location = new System.Drawing.Point(41, 102);
            this.pointsLab.Name = "pointsLab";
            this.pointsLab.Size = new System.Drawing.Size(21, 15);
            this.pointsLab.TabIndex = 3;
            this.pointsLab.Text = "56";
            // 
            // replies
            // 
            this.replies.AutoSize = true;
            this.replies.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.replies.Location = new System.Drawing.Point(152, 100);
            this.replies.Name = "replies";
            this.replies.Size = new System.Drawing.Size(70, 18);
            this.replies.TabIndex = 5;
            this.replies.Text = "+ replies";
            this.replies.Click += new System.EventHandler(this.label6_Click);
            // 
            // authorLab
            // 
            this.authorLab.AutoSize = true;
            this.authorLab.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.authorLab.ForeColor = System.Drawing.Color.Green;
            this.authorLab.Location = new System.Drawing.Point(32, 15);
            this.authorLab.Name = "authorLab";
            this.authorLab.Size = new System.Drawing.Size(54, 17);
            this.authorLab.TabIndex = 6;
            this.authorLab.Text = "author";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 0);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.titleLab);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(35, 44);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(325, 42);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // reply
            // 
            this.reply.AutoSize = true;
            this.reply.BackColor = System.Drawing.Color.SpringGreen;
            this.reply.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.reply.Location = new System.Drawing.Point(295, 102);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(45, 17);
            this.reply.TabIndex = 9;
            this.reply.Text = "reply";
            this.reply.Click += new System.EventHandler(this.reply_Click);
            // 
            // CommentsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reply);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.authorLab);
            this.Controls.Add(this.replies);
            this.Controls.Add(this.pointsLab);
            this.Controls.Add(this.downLab);
            this.Controls.Add(this.upLab);
            this.Name = "CommentsComponent";
            this.Size = new System.Drawing.Size(391, 161);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLab;
        private System.Windows.Forms.Label upLab;
        private System.Windows.Forms.Label downLab;
        private System.Windows.Forms.Label pointsLab;
        private System.Windows.Forms.Label replies;
        private System.Windows.Forms.Label authorLab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label reply;
    }
}
