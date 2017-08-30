using System;
using System.Windows.Forms;
using CoreTweet;
using static CoreTweet.OAuth;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Threading.Tasks;


namespace Emotionic_Share
{


    public partial class Form1 : Form
    {

        public static Tokens tokens = null;
        public static string PINCode;
        public OAuthSession session;
        public static string twid, twps;
        private static string APIKEY = "rtiYCpTdotGuBlIUXycL4Qm3k";
        private static string APISECRET = "Hkmg6lBzUu3NHF37zcfVnvKYRNzjlIyz44S9W0SFNnzhCoh3Ip";
        private static string pin_URL;
        //private static string _pinsURL;
        private int tweet = 140;
        private bool  i = false;
        

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
            
            
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
            toolStatus_tw.Text = "Tweet Success";
        }

        private void tw_acs_Click(object sender, EventArgs e)
        {

            twid = twit_ID.Text;
            twps = twit_Pass.Text;
            session = Authorize(APIKEY, APISECRET);
            pin_URL = session.AuthorizeUri.AbsoluteUri;
            twitBrow.Navigate(pin_URL);

        }




        private static string filename, filePath, _mtitle, _mdiscre; 
        
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
        
        public void twitBrow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (i == false)
            {

                //テキストボックスにIDを設定                
                HtmlElement id_forms = twitBrow.Document.GetElementById("username_or_email");
                id_forms.SetAttribute("value", twid);
                //同じくパスを設定
                HtmlElement pass_forms = twitBrow.Document.GetElementById("password");
                pass_forms.SetAttribute("value", twps);


                //フォームのサブミット
                HtmlElement sub_forms = twitBrow.Document.GetElementById("oauth_form");
                sub_forms.InvokeMember("submit");


                i = true;
            }
            else if (i == true)
            {

                //PINの取得
                HtmlElement _pin = twitBrow.Document.GetElementById("oauth_pin");
                System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(_pin.InnerHtml.ToString(), @"<code>(.*?)</code>");
                foreach (System.Text.RegularExpressions.Match m in mc)
                {
                    PINCode = m.Groups[1].Value;
                }
                i = false;
                

                tokens = OAuth.GetTokens(session, PINCode);
                if (tokens != null) toolStatus_tw.Text = "Successful acquisition of token!";
            }
            
        }

        private void text_changed(object sender, EventArgs e)
        {
            tweet -= 1;
            TweLength.Text = (tweet).ToString();
            if (tweet < 0) TweLength.ForeColor = System.Drawing.Color.Red; 
        }

        private void share_mv_Click(object sender, EventArgs e)
        {
            _mtitle = movie_title.Text;
            _mdiscre = movie_description.Text;

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
            video.Snippet.Title = _mtitle;
            video.Snippet.Description = _mdiscre;
            video.Snippet.Tags = new string[] { "tag1", "tag2" };
            video.Snippet.CategoryId = "22";
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = comboBox2.Text;
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

    

        
 

   