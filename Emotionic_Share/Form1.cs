using System;
using System.Windows.Forms;
using CoreTweet;
using static CoreTweet.OAuth;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Reflection;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Threading.Tasks;


namespace Emotionic_Share
{


    public partial class Form1 : Form
    {

        
        private static Tokens tokens = null;
        private string apikey = "rtiYCpTdotGuBlIUXycL4Qm3k";
        private string apisecret = "Hkmg6lBzUu3NHF37zcfVnvKYRNzjlIyz44S9W0SFNnzhCoh3Ip";
        private string pincode;
        private OAuthSession session;
        public Form1 fm;
        
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            webB_YTup.Navigate("https://www.youtube.com/upload");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //フォルダを開いて共有したい画像を選ぶ
                string filename = openFileDialog.FileName;
                open_filename.Text = filename;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pincode = pinBox.Text;
            //トークン取得
            tokens = OAuth.GetTokens(session, pincode);
            if (tokens != null) toolStatus_tw.Text = "Successful acquisition of token!";
        }



        //選択した画像の共有
        private async void share_img_Click(object sender, EventArgs e)
        {
            if (tokens == null)
            {
                //トークン取得できてないよ！
                toolStatus_tw.Text = "You are not authorized yet.";
                return;
            }

            MediaUploadResult img = new MediaUploadResult();

            img = tokens.Media.Upload(media: new FileInfo(open_filename.Text));
            //ついーと
            Status _status = await tokens.Statuses.UpdateAsync(status => tweet_box.Text + " _Tweet_Success!", media_ids => img);
        }

        private void tw_acs_Click(object sender, EventArgs e)
        {
            //PINコード取得
            session = OAuth.Authorize(apikey, apisecret);
            Process.Start(session.AuthorizeUri.AbsoluteUri);
        }




        private static string filename;
        private static string filePath;
        //以下つべ(未完成
        private void open_moviefile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //フォルダを開いて共有したい動画を選ぶ
                filename = openFileDialog.FileName;
                
                movieFname.Text = filename;
                
            }
        }

        private void share_mv_Click(object sender, EventArgs e)
        {
           try
            {

                new Form1().Run().Wait();
                
            }
            catch (AggregateException ex)
            {
                foreach (var exce in ex.InnerExceptions)
                {

                    toolStatus.Text = "Error : " + exce.Message;
                }
            }

        }

        private async Task Run()
        {

            UserCredential credential;

            
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "User",
                    CancellationToken.None
                    );
            }

            var ytService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            }
            );
                
            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = movie_title.Text;
            video.Snippet.Description = movie_description.Text;
            video.Snippet.Tags = new string[] { "tag1", "tag2" };
            video.Snippet.CategoryId = "22";
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "private";
            //filePath = movieFname.Text;
            filePath = filename;
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = ytService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                
                await videosInsertRequest.UploadAsync();
            }
            
            
        }
        
        void videosInsertRequest_ProgressChanged(IUploadProgress progress)
        {
            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    toolStatus.Text = progress.BytesSent + " bytes sent.";
                    break;

                case UploadStatus.Failed:
                    toolStatus.Text = "An error prevented the upload from completing." + progress.Exception;
                    break;
            }

        }

        void videosInsertRequest_ResponseReceived(Video video)
        {
            toolStatus.Text = "Video id " + video.Id + "was successfully uploaded.";
            Application.Exit();
        }
        

    }
    
}

    

        
 

   