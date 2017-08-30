namespace Emotionic_Share
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.file_open = new System.Windows.Forms.Button();
            this.open_filename = new System.Windows.Forms.TextBox();
            this.filename_label = new System.Windows.Forms.Label();
            this.share_img = new System.Windows.Forms.Button();
            this.tweet_box = new System.Windows.Forms.TextBox();
            this.tab_tw = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TweLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.twitBrow = new System.Windows.Forms.WebBrowser();
            this.twit_Pass = new System.Windows.Forms.TextBox();
            this.twit_ID = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStatus_tw = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tw_acs = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this._description = new System.Windows.Forms.Label();
            this.movie_description = new System.Windows.Forms.TextBox();
            this._title = new System.Windows.Forms.Label();
            this._file = new System.Windows.Forms.Label();
            this.movie_title = new System.Windows.Forms.TextBox();
            this.statusStripYT = new System.Windows.Forms.StatusStrip();
            this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.share_mv = new System.Windows.Forms.Button();
            this.movieFname = new System.Windows.Forms.TextBox();
            this.open_moviefile = new System.Windows.Forms.Button();
            this.tab_tw.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStripYT.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "MP4ファイル|*.mp4|PNGファイル|*.png|JPEGファイル|*.jpeg;*.jpg|すべてのファイル|*.*";
            // 
            // file_open
            // 
            this.file_open.Location = new System.Drawing.Point(263, 99);
            this.file_open.Name = "file_open";
            this.file_open.Size = new System.Drawing.Size(75, 19);
            this.file_open.TabIndex = 1;
            this.file_open.Text = "参照";
            this.file_open.UseVisualStyleBackColor = true;
            this.file_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // open_filename
            // 
            this.open_filename.Location = new System.Drawing.Point(33, 99);
            this.open_filename.Name = "open_filename";
            this.open_filename.Size = new System.Drawing.Size(224, 19);
            this.open_filename.TabIndex = 2;
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Location = new System.Drawing.Point(4, 97);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(28, 12);
            this.filename_label.TabIndex = 6;
            this.filename_label.Text = "FILE";
            // 
            // share_img
            // 
            this.share_img.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.share_img.Location = new System.Drawing.Point(6, 203);
            this.share_img.Name = "share_img";
            this.share_img.Size = new System.Drawing.Size(332, 109);
            this.share_img.TabIndex = 8;
            this.share_img.Text = "Let\'s Share Tweet !";
            this.share_img.UseVisualStyleBackColor = true;
            this.share_img.Click += new System.EventHandler(this.share_img_Click);
            // 
            // tweet_box
            // 
            this.tweet_box.Location = new System.Drawing.Point(6, 135);
            this.tweet_box.Multiline = true;
            this.tweet_box.Name = "tweet_box";
            this.tweet_box.Size = new System.Drawing.Size(330, 62);
            this.tweet_box.TabIndex = 9;
            this.tweet_box.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // tab_tw
            // 
            this.tab_tw.Controls.Add(this.tabPage1);
            this.tab_tw.Controls.Add(this.tabPage2);
            this.tab_tw.Location = new System.Drawing.Point(3, 2);
            this.tab_tw.Name = "tab_tw";
            this.tab_tw.SelectedIndex = 0;
            this.tab_tw.Size = new System.Drawing.Size(353, 366);
            this.tab_tw.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TweLength);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.twitBrow);
            this.tabPage1.Controls.Add(this.twit_Pass);
            this.tabPage1.Controls.Add(this.twit_ID);
            this.tabPage1.Controls.Add(this.statusStrip);
            this.tabPage1.Controls.Add(this.share_img);
            this.tabPage1.Controls.Add(this.tw_acs);
            this.tabPage1.Controls.Add(this.tweet_box);
            this.tabPage1.Controls.Add(this.file_open);
            this.tabPage1.Controls.Add(this.filename_label);
            this.tabPage1.Controls.Add(this.open_filename);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Twitter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TweLength
            // 
            this.TweLength.AutoSize = true;
            this.TweLength.Location = new System.Drawing.Point(313, 185);
            this.TweLength.Name = "TweLength";
            this.TweLength.Size = new System.Drawing.Size(23, 12);
            this.TweLength.TabIndex = 18;
            this.TweLength.Text = "140";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "コメント";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // twitBrow
            // 
            this.twitBrow.Location = new System.Drawing.Point(347, 3);
            this.twitBrow.MinimumSize = new System.Drawing.Size(20, 20);
            this.twitBrow.Name = "twitBrow";
            this.twitBrow.Size = new System.Drawing.Size(215, 302);
            this.twitBrow.TabIndex = 14;
            this.twitBrow.Visible = false;
            this.twitBrow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.twitBrow_DocumentCompleted);
            // 
            // twit_Pass
            // 
            this.twit_Pass.Location = new System.Drawing.Point(33, 31);
            this.twit_Pass.Name = "twit_Pass";
            this.twit_Pass.Size = new System.Drawing.Size(224, 19);
            this.twit_Pass.TabIndex = 13;
            this.twit_Pass.UseSystemPasswordChar = true;
            // 
            // twit_ID
            // 
            this.twit_ID.Location = new System.Drawing.Point(33, 6);
            this.twit_ID.Name = "twit_ID";
            this.twit_ID.Size = new System.Drawing.Size(224, 19);
            this.twit_ID.TabIndex = 12;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus_tw,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(3, 315);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(339, 22);
            this.statusStrip.TabIndex = 11;
            // 
            // toolStatus_tw
            // 
            this.toolStatus_tw.Name = "toolStatus_tw";
            this.toolStatus_tw.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // tw_acs
            // 
            this.tw_acs.Location = new System.Drawing.Point(6, 53);
            this.tw_acs.Name = "tw_acs";
            this.tw_acs.Size = new System.Drawing.Size(330, 37);
            this.tw_acs.TabIndex = 10;
            this.tw_acs.Text = "Twitterへ接続";
            this.tw_acs.UseVisualStyleBackColor = true;
            this.tw_acs.Click += new System.EventHandler(this.tw_acs_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this._description);
            this.tabPage2.Controls.Add(this.movie_description);
            this.tabPage2.Controls.Add(this._title);
            this.tabPage2.Controls.Add(this._file);
            this.tabPage2.Controls.Add(this.movie_title);
            this.tabPage2.Controls.Add(this.statusStripYT);
            this.tabPage2.Controls.Add(this.share_mv);
            this.tabPage2.Controls.Add(this.movieFname);
            this.tabPage2.Controls.Add(this.open_moviefile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "YouTube";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "公開設定";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "public",
            "private",
            "unlisted"});
            this.comboBox2.Location = new System.Drawing.Point(71, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 20);
            this.comboBox2.TabIndex = 14;
            // 
            // _description
            // 
            this._description.AutoSize = true;
            this._description.Location = new System.Drawing.Point(1, 93);
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(41, 12);
            this._description.TabIndex = 8;
            this._description.Text = "説明文";
            // 
            // movie_description
            // 
            this.movie_description.Location = new System.Drawing.Point(44, 60);
            this.movie_description.Multiline = true;
            this.movie_description.Name = "movie_description";
            this.movie_description.Size = new System.Drawing.Size(293, 77);
            this.movie_description.TabIndex = 7;
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.Location = new System.Drawing.Point(3, 37);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(35, 12);
            this._title.TabIndex = 6;
            this._title.Text = "TITLE";
            // 
            // _file
            // 
            this._file.AutoSize = true;
            this._file.Location = new System.Drawing.Point(3, 11);
            this._file.Name = "_file";
            this._file.Size = new System.Drawing.Size(28, 12);
            this._file.TabIndex = 5;
            this._file.Text = "FILE";
            // 
            // movie_title
            // 
            this.movie_title.Location = new System.Drawing.Point(44, 34);
            this.movie_title.Name = "movie_title";
            this.movie_title.Size = new System.Drawing.Size(293, 19);
            this.movie_title.TabIndex = 4;
            // 
            // statusStripYT
            // 
            this.statusStripYT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus,
            this.toolStripStatusLabel1});
            this.statusStripYT.Location = new System.Drawing.Point(3, 315);
            this.statusStripYT.Name = "statusStripYT";
            this.statusStripYT.Size = new System.Drawing.Size(339, 22);
            this.statusStripYT.TabIndex = 3;
            this.statusStripYT.Text = "statusStrip1";
            // 
            // toolStatus
            // 
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // share_mv
            // 
            this.share_mv.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.share_mv.Location = new System.Drawing.Point(7, 173);
            this.share_mv.Name = "share_mv";
            this.share_mv.Size = new System.Drawing.Size(330, 139);
            this.share_mv.TabIndex = 2;
            this.share_mv.Text = "Let\'s Share Movie!";
            this.share_mv.UseVisualStyleBackColor = true;
            this.share_mv.Click += new System.EventHandler(this.share_mv_Click);
            // 
            // movieFname
            // 
            this.movieFname.Location = new System.Drawing.Point(35, 8);
            this.movieFname.Name = "movieFname";
            this.movieFname.Size = new System.Drawing.Size(221, 19);
            this.movieFname.TabIndex = 1;
            // 
            // open_moviefile
            // 
            this.open_moviefile.Location = new System.Drawing.Point(262, 8);
            this.open_moviefile.Name = "open_moviefile";
            this.open_moviefile.Size = new System.Drawing.Size(75, 19);
            this.open_moviefile.TabIndex = 0;
            this.open_moviefile.Text = "参照";
            this.open_moviefile.UseVisualStyleBackColor = true;
            this.open_moviefile.Click += new System.EventHandler(this.open_moviefile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(357, 365);
            this.Controls.Add(this.tab_tw);
            this.Name = "Form1";
            this.Text = "Share";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_tw.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStripYT.ResumeLayout(false);
            this.statusStripYT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button file_open;
        private System.Windows.Forms.TextBox open_filename;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Button share_img;
        private System.Windows.Forms.TextBox tweet_box;
        private System.Windows.Forms.TabControl tab_tw;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button tw_acs;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Label _file;
        private System.Windows.Forms.Label _description;
        private System.Windows.Forms.StatusStrip statusStrip;
        internal System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Button open_moviefile;
        internal System.Windows.Forms.Button share_mv;
        public System.Windows.Forms.TextBox movie_title;
        public System.Windows.Forms.TextBox movie_description;
        public System.Windows.Forms.StatusStrip statusStripYT;
        public System.Windows.Forms.ToolStripStatusLabel toolStatus;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.TextBox movieFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.WebBrowser twitBrow;
        public System.Windows.Forms.TextBox twit_Pass;
        public System.Windows.Forms.TextBox twit_ID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStatus_tw;
        private System.Windows.Forms.Label TweLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

