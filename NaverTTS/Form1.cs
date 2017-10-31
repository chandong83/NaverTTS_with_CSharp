using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace NaverTTS
{
    public partial class Form1 : Form
    {
        const int KOREAN = 0;
        const int ENGLISH = 1;
        const int JAPANESE = 2;
        const int CHINESE = 3;
        const int ESPANOL = 4;
        const int GIRL = 0;
        const int MAN = 1;
        string[,] sex = {   { "Mijin", "Jinho" },
                            { "Clara", "Matt" },
                            { "Yuri", "Shinji" },
                            { "Meimei", "Liangliang" },
                            { "Carmen", "Jose" },
                        };
        int nLanguage = KOREAN;
        int nSex = GIRL;
        public Form1()
        {
            InitializeComponent();
        }

        private void ttsBtn_Click(object sender, EventArgs e)
        {
            string text = textBox.Text; // 음성합성할 문자값
            string url = "https://openapi.naver.com/v1/voice/tts.bin";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", clientIDTxt.Text);
            request.Headers.Add("X-Naver-Client-Secret", clientKeyTxt.Text);
            try{
                request.Method = "POST";
                float voiceSpeed = (float)voiceSpeedTrack.Value / 2;
                string parm = "speaker=" + sex[nLanguage, nSex].ToLower() + "&speed=" + voiceSpeed.ToString() + "&text=" + text;
                byte[] byteDataParams = Encoding.UTF8.GetBytes(parm);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteDataParams.Length;
                Stream st = request.GetRequestStream();
                st.Write(byteDataParams, 0, byteDataParams.Length);
                st.Close();         

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    string status = response.StatusCode.ToString();
                    Console.WriteLine("status=" + status);
                    
                    string Name = Regex.Replace(text, @"[^a-zA-Z0-9가-힣_]", "", RegexOptions.Singleline);
                    string fileName = @".\" + Name + "_"+sex[nLanguage, nSex].ToLower() + "_"+ voiceSpeed.ToString() + ".mp3";
                    using (Stream output = File.OpenWrite(fileName))
                    using (Stream input = response.GetResponseStream())
                    {
                        input.CopyTo(output);
                        MessageBox.Show(Name + ".mp3" + " 생성!\n성공!");
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.Status == WebExceptionStatus.Timeout)
                {
                    // Handle timeout exception
                }
            }
            finally
            {               
          
            }
           
        }

        private void rKorean_CheckedChanged(object sender, EventArgs e)
        {
            nLanguage = KOREAN;
            refresh_sexModel();
        }

        private void rEnglish_CheckedChanged(object sender, EventArgs e)
        {
            nLanguage = ENGLISH;
            refresh_sexModel();
        }

        private void rChinese_CheckedChanged(object sender, EventArgs e)
        {
            nLanguage = CHINESE;
            refresh_sexModel();
        }

        private void rJapanese_CheckedChanged(object sender, EventArgs e)
        {
            nLanguage = JAPANESE;
            refresh_sexModel();
        }

        private void rEspanol_CheckedChanged(object sender, EventArgs e)
        {
            nLanguage = ESPANOL;
            refresh_sexModel();
        }

        void refresh_sexModel()
        {
            rGirl.Text = sex[nLanguage,0] + "(여성)";
            rMan.Text = sex[nLanguage, 1] + "(남성)";            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh_sexModel();         
        }

        private void voiceSpeedTrack_ValueChanged(object sender, EventArgs e)
        {
            float f = (float)voiceSpeedTrack.Value / 2;
            speedVal.Text = f.ToString();
        }

        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@".\");
        }

        private void rGirl_CheckedChanged(object sender, EventArgs e)
        {
            nSex = GIRL;
        }

        private void rMan_CheckedChanged(object sender, EventArgs e)
        {
            nSex = MAN;
        }
    }
}
