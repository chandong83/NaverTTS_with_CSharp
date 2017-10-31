namespace NaverTTS
{
    partial class Form1
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
            this.ttsBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.OpenFolderBtn = new System.Windows.Forms.Button();
            this.clientIDTxt = new System.Windows.Forms.TextBox();
            this.clientKeyTxt = new System.Windows.Forms.TextBox();
            this.voiceSpeedTrack = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedVal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rKorean = new System.Windows.Forms.RadioButton();
            this.rEnglish = new System.Windows.Forms.RadioButton();
            this.rChinese = new System.Windows.Forms.RadioButton();
            this.rJapanese = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rGirl = new System.Windows.Forms.RadioButton();
            this.rMan = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rEspanol = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.voiceSpeedTrack)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttsBtn
            // 
            this.ttsBtn.Location = new System.Drawing.Point(12, 65);
            this.ttsBtn.Name = "ttsBtn";
            this.ttsBtn.Size = new System.Drawing.Size(82, 33);
            this.ttsBtn.TabIndex = 0;
            this.ttsBtn.Text = "생성하기";
            this.ttsBtn.UseVisualStyleBackColor = true;
            this.ttsBtn.Click += new System.EventHandler(this.ttsBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 34);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(608, 25);
            this.textBox.TabIndex = 1;
            // 
            // OpenFolderBtn
            // 
            this.OpenFolderBtn.Location = new System.Drawing.Point(12, 104);
            this.OpenFolderBtn.Name = "OpenFolderBtn";
            this.OpenFolderBtn.Size = new System.Drawing.Size(82, 34);
            this.OpenFolderBtn.TabIndex = 2;
            this.OpenFolderBtn.Text = "폴더열기";
            this.OpenFolderBtn.UseVisualStyleBackColor = true;
            this.OpenFolderBtn.Click += new System.EventHandler(this.OpenFolderBtn_Click);
            // 
            // clientIDTxt
            // 
            this.clientIDTxt.Location = new System.Drawing.Point(239, 66);
            this.clientIDTxt.Name = "clientIDTxt";
            this.clientIDTxt.Size = new System.Drawing.Size(381, 25);
            this.clientIDTxt.TabIndex = 5;
            // 
            // clientKeyTxt
            // 
            this.clientKeyTxt.Location = new System.Drawing.Point(239, 95);
            this.clientKeyTxt.Name = "clientKeyTxt";
            this.clientKeyTxt.Size = new System.Drawing.Size(381, 25);
            this.clientKeyTxt.TabIndex = 6;
            // 
            // voiceSpeedTrack
            // 
            this.voiceSpeedTrack.LargeChange = 2;
            this.voiceSpeedTrack.Location = new System.Drawing.Point(47, 39);
            this.voiceSpeedTrack.Minimum = -10;
            this.voiceSpeedTrack.Name = "voiceSpeedTrack";
            this.voiceSpeedTrack.Size = new System.Drawing.Size(492, 56);
            this.voiceSpeedTrack.TabIndex = 7;
            this.voiceSpeedTrack.ValueChanged += new System.EventHandler(this.voiceSpeedTrack_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speedVal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.voiceSpeedTrack);
            this.groupBox3.Location = new System.Drawing.Point(12, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 111);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "음성 옵션";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "음성 속도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "느리게";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "빠르게";
            // 
            // speedVal
            // 
            this.speedVal.AutoSize = true;
            this.speedVal.Location = new System.Drawing.Point(287, 80);
            this.speedVal.Name = "speedVal";
            this.speedVal.Size = new System.Drawing.Size(15, 15);
            this.speedVal.TabIndex = 11;
            this.speedVal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Client ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client Secret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "TEXT";
            // 
            // rKorean
            // 
            this.rKorean.AutoSize = true;
            this.rKorean.Checked = true;
            this.rKorean.Location = new System.Drawing.Point(9, 24);
            this.rKorean.Name = "rKorean";
            this.rKorean.Size = new System.Drawing.Size(73, 19);
            this.rKorean.TabIndex = 0;
            this.rKorean.TabStop = true;
            this.rKorean.Text = "한국어";
            this.rKorean.UseVisualStyleBackColor = true;
            this.rKorean.CheckedChanged += new System.EventHandler(this.rKorean_CheckedChanged);
            // 
            // rEnglish
            // 
            this.rEnglish.AutoSize = true;
            this.rEnglish.Location = new System.Drawing.Point(9, 49);
            this.rEnglish.Name = "rEnglish";
            this.rEnglish.Size = new System.Drawing.Size(58, 19);
            this.rEnglish.TabIndex = 1;
            this.rEnglish.Text = "영어";
            this.rEnglish.UseVisualStyleBackColor = true;
            this.rEnglish.CheckedChanged += new System.EventHandler(this.rEnglish_CheckedChanged);
            // 
            // rChinese
            // 
            this.rChinese.AutoSize = true;
            this.rChinese.Location = new System.Drawing.Point(9, 99);
            this.rChinese.Name = "rChinese";
            this.rChinese.Size = new System.Drawing.Size(73, 19);
            this.rChinese.TabIndex = 2;
            this.rChinese.Text = "중국어";
            this.rChinese.UseVisualStyleBackColor = true;
            this.rChinese.CheckedChanged += new System.EventHandler(this.rChinese_CheckedChanged);
            // 
            // rJapanese
            // 
            this.rJapanese.AutoSize = true;
            this.rJapanese.Location = new System.Drawing.Point(9, 73);
            this.rJapanese.Name = "rJapanese";
            this.rJapanese.Size = new System.Drawing.Size(73, 19);
            this.rJapanese.TabIndex = 3;
            this.rJapanese.Text = "일본어";
            this.rJapanese.UseVisualStyleBackColor = true;
            this.rJapanese.CheckedChanged += new System.EventHandler(this.rJapanese_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rMan);
            this.groupBox1.Controls.Add(this.rGirl);
            this.groupBox1.Location = new System.Drawing.Point(100, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성별";
            // 
            // rGirl
            // 
            this.rGirl.AutoSize = true;
            this.rGirl.Checked = true;
            this.rGirl.Location = new System.Drawing.Point(7, 25);
            this.rGirl.Name = "rGirl";
            this.rGirl.Size = new System.Drawing.Size(58, 19);
            this.rGirl.TabIndex = 0;
            this.rGirl.TabStop = true;
            this.rGirl.Text = "여성";
            this.rGirl.UseVisualStyleBackColor = true;
            this.rGirl.CheckedChanged += new System.EventHandler(this.rGirl_CheckedChanged);
            // 
            // rMan
            // 
            this.rMan.AutoSize = true;
            this.rMan.Location = new System.Drawing.Point(7, 49);
            this.rMan.Name = "rMan";
            this.rMan.Size = new System.Drawing.Size(58, 19);
            this.rMan.TabIndex = 1;
            this.rMan.Text = "남성";
            this.rMan.UseVisualStyleBackColor = true;
            this.rMan.CheckedChanged += new System.EventHandler(this.rMan_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rEspanol);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.rJapanese);
            this.groupBox2.Controls.Add(this.rChinese);
            this.groupBox2.Controls.Add(this.rEnglish);
            this.groupBox2.Controls.Add(this.rKorean);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 158);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "언어";
            // 
            // rEspanol
            // 
            this.rEspanol.AutoSize = true;
            this.rEspanol.Location = new System.Drawing.Point(9, 124);
            this.rEspanol.Name = "rEspanol";
            this.rEspanol.Size = new System.Drawing.Size(88, 19);
            this.rEspanol.TabIndex = 4;
            this.rEspanol.Text = "스페인어";
            this.rEspanol.UseVisualStyleBackColor = true;
            this.rEspanol.CheckedChanged += new System.EventHandler(this.rEspanol_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 452);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clientKeyTxt);
            this.Controls.Add(this.clientIDTxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OpenFolderBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ttsBtn);
            this.Name = "Form1";
            this.Text = "Naver TTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voiceSpeedTrack)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ttsBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button OpenFolderBtn;
        private System.Windows.Forms.TextBox clientIDTxt;
        private System.Windows.Forms.TextBox clientKeyTxt;
        private System.Windows.Forms.TrackBar voiceSpeedTrack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speedVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rKorean;
        private System.Windows.Forms.RadioButton rEnglish;
        private System.Windows.Forms.RadioButton rChinese;
        private System.Windows.Forms.RadioButton rJapanese;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rMan;
        private System.Windows.Forms.RadioButton rGirl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rEspanol;
    }
}

