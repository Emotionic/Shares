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
            this.pinBox = new System.Windows.Forms.TextBox();
            this.get_token = new System.Windows.Forms.Button();
            this.pin_label = new System.Windows.Forms.Label();
            this.filename_label = new System.Windows.Forms.Label();
            this.share_img = new System.Windows.Forms.Button();
            this.tweet_box = new System.Windows.Forms.TextBox();
            this.tab_tw = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStatus_tw = new System.Windows.Forms.ToolStripStatusLabel();
            this.tw_acs = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._description = new System.Windows.Forms.Label();
            this.movie_description = new System.Windows.Forms.TextBox();
            this._title = new System.Windows.Forms.Label();
            this._file = new System.Windows.Forms.Label();
            this.movie_title = new System.Windows.Forms.TextBox();
            this.statusStripYT = new System.Windows.Forms.StatusStrip();
            this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.share_mv = new System.Windows.Forms.Button();
            this.moviefname = new System.Windows.Forms.TextBox();
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
            this.openFileDialog.Filter = "PNGファイル|*.png|JPEGファイル|*.jpeg;*.jpg|すべてのファイル|*.*";
            // 
            // file_open
            // 
            this.file_open.Location = new System.Drawing.Point(263, 74);
            this.file_open.Name = "file_open";
            this.file_open.Size = new System.Drawing.Size(75, 19);
            this.file_open.TabIndex = 1;
            this.file_open.Text = "参照";
            this.file_open.UseVisualStyleBackColor = true;
            this.file_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // open_filename
            // 
            this.open_filename.Location = new System.Drawing.Point(33, 74);
            this.open_filename.Name = "open_filename";
            this.open_filename.Size = new System.Drawing.Size(224, 19);
            this.open_filename.TabIndex = 2;
            // 
            // pinBox
            // 
            this.pinBox.Location = new System.Drawing.Point(33, 49);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(224, 19);
            this.pinBox.TabIndex = 3;
            // 
            // get_token
            // 
            this.get_token.Location = new System.Drawing.Point(263, 49);
            this.get_token.Name = "get_token";
            this.get_token.Size = new System.Drawing.Size(75, 19);
            this.get_token.TabIndex = 4;
            this.get_token.Text = "トークン取得!";
            this.get_token.UseVisualStyleBackColor = true;
            this.get_token.Click += new System.EventHandler(this.button2_Click);
            // 
            // pin_label
            // 
            this.pin_label.AutoSize = true;
            this.pin_label.Location = new System.Drawing.Point(6, 52);
            this.pin_label.Name = "pin_label";
            this.pin_label.Size = new System.Drawing.Size(23, 12);
            this.pin_label.TabIndex = 5;
            this.pin_label.Text = "PIN";
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Location = new System.Drawing.Point(3, 77);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(28, 12);
            this.filename_label.TabIndex = 6;
            this.filename_label.Text = "FILE";
            // 
            // share_img
            // 
            this.share_img.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.share_img.Location = new System.Drawing.Point(5, 155);
            this.share_img.Name = "share_img";
            this.share_img.Size = new System.Drawing.Size(332, 126);
            this.share_img.TabIndex = 8;
            this.share_img.Text = "Let\'s Share Photo !";
            this.share_img.UseVisualStyleBackColor = true;
            this.share_img.Click += new System.EventHandler(this.share_img_Click);
            // 
            // tweet_box
            // 
            this.tweet_box.Location = new System.Drawing.Point(5, 99);
            this.tweet_box.Multiline = true;
            this.tweet_box.Name = "tweet_box";
            this.tweet_box.Size = new System.Drawing.Size(330, 50);
            this.tweet_box.TabIndex = 9;
            // 
            // tab_tw
            // 
            this.tab_tw.Controls.Add(this.tabPage1);
            this.tab_tw.Controls.Add(this.tabPage2);
            this.tab_tw.Location = new System.Drawing.Point(3, 2);
            this.tab_tw.Name = "tab_tw";
            this.tab_tw.SelectedIndex = 0;
            this.tab_tw.Size = new System.Drawing.Size(352, 366);
            this.tab_tw.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip);
            this.tabPage1.Controls.Add(this.share_img);
            this.tabPage1.Controls.Add(this.tw_acs);
            this.tabPage1.Controls.Add(this.tweet_box);
            this.tabPage1.Controls.Add(this.file_open);
            this.tabPage1.Controls.Add(this.pin_label);
            this.tabPage1.Controls.Add(this.filename_label);
            this.tabPage1.Controls.Add(this.pinBox);
            this.tabPage1.Controls.Add(this.get_token);
            this.tabPage1.Controls.Add(this.open_filename);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Twitter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus_tw});
            this.statusStrip.Location = new System.Drawing.Point(3, 315);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(338, 22);
            this.statusStrip.TabIndex = 11;
            // 
            // toolStatus_tw
            // 
            this.toolStatus_tw.Name = "toolStatus_tw";
            this.toolStatus_tw.Size = new System.Drawing.Size(0, 17);
            // 
            // tw_acs
            // 
            this.tw_acs.Location = new System.Drawing.Point(6, 6);
            this.tw_acs.Name = "tw_acs";
            this.tw_acs.Size = new System.Drawing.Size(329, 37);
            this.tw_acs.TabIndex = 10;
            this.tw_acs.Text = "Twitterへ接続";
            this.tw_acs.UseVisualStyleBackColor = true;
            this.tw_acs.Click += new System.EventHandler(this.tw_acs_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._description);
            this.tabPage2.Controls.Add(this.movie_description);
            this.tabPage2.Controls.Add(this._title);
            this.tabPage2.Controls.Add(this._file);
            this.tabPage2.Controls.Add(this.movie_title);
            this.tabPage2.Controls.Add(this.statusStripYT);
            this.tabPage2.Controls.Add(this.share_mv);
            this.tabPage2.Controls.Add(this.moviefname);
            this.tabPage2.Controls.Add(this.open_moviefile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "YouTube";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _description
            // 
            this._description.AutoSize = true;
            this._description.Location = new System.Drawing.Point(1, 100);
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
            this.movie_description.Size = new System.Drawing.Size(293, 107);
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
            this.statusStripYT.Size = new System.Drawing.Size(338, 22);
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
            // moviefname
            // 
            this.moviefname.Location = new System.Drawing.Point(35, 8);
            this.moviefname.Name = "moviefname";
            this.moviefname.Size = new System.Drawing.Size(221, 19);
            this.moviefname.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(356, 365);
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
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.Button get_token;
        private System.Windows.Forms.Label pin_label;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Button share_img;
        private System.Windows.Forms.TextBox tweet_box;
        private System.Windows.Forms.TabControl tab_tw;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button tw_acs;
        private System.Windows.Forms.Button open_moviefile;
        private System.Windows.Forms.TextBox moviefname;
        private System.Windows.Forms.Button share_mv;
        private System.Windows.Forms.StatusStrip statusStripYT;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Label _file;
        private System.Windows.Forms.TextBox movie_title;
        private System.Windows.Forms.Label _description;
        private System.Windows.Forms.TextBox movie_description;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus_tw;
    }
}

