﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3
{
    public partial class Form1 : Form
    {
        MP3Player mp3Player;

        //Track Bar 
        bool isScrolled = false;
        int trackBarBlankSize = 14;    // TrackBar 양옆 빈공간
        int trackBarLength = 0;        // TrackBar의 실제 길이
        int trackBarMouseX = 0;        // TrackBar에서 마우스 클릭 위치

        public Form1()
        {
            InitializeComponent();

            mp3Player = new MP3Player();
            trackBarLength = MP3TrackBar.Size.Width - (trackBarBlankSize * 2); // TrackBar의 실제 길이
        }

        // Timer Tick Event
        private void MP3Timer_Tick(object sender, EventArgs e) 
        {
            if (!mp3Player.isOpened)
                return;

            if (isScrolled == false)
                MP3TrackBar.Value = mp3Player.GetPosition();                     

            if (!mp3Player.loop && mp3Player.GetPosition() == mp3Player.GetLength())
                mp3Player.Stop();

            SetMusicTimer();
        }

        // 파일 열기
        private void Open_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Mp3 File|*.mp3";

                open.InitialDirectory = Environment.CurrentDirectory;

                if(open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = open.FileName;

                    mp3Player.Open(fileName);
                    MP3TrackBar.Maximum = mp3Player.GetLength();
                    MP3Timer.Enabled = true;
                }
            }
        }

        // 파일 닫기
        private void Close_Click(object sender, EventArgs e)
        {
            MP3Timer.Enabled = false;
            MP3TrackBar.Value = 0;
            mp3Player.Close();          
        }

        // 음악 재생 : ▶ Button
        private void Play_Click(object sender, EventArgs e)
        {        
            mp3Player.Play();                
        }

        // 음악 일시정지 : ∥ Button
        private void Pause_Click(object sender, EventArgs e)
        {
            mp3Player.Pause();
        }

        // 음악 정지 : ■ Button
        private void Stop_Click(object sender, EventArgs e)
        {
            mp3Player.Stop();
        }

        // TrackBar MouseDown Event
        private void MP3TrackBar_MouseDown(object sender, MouseEventArgs e) 
        {
            isScrolled = true;
            trackBarMouseX = e.X - trackBarBlankSize;     // 마우스 클릭 좌표
            SetPositionByMouse(trackBarMouseX);
        }

        // TrackBar MouseMove Event
        private void MP3TrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(isScrolled)
            {
                trackBarMouseX = e.X - trackBarBlankSize; // 마우스 클릭 좌표
                SetPositionByMouse(trackBarMouseX);
            }
        }

        // TrackBar MouseUp Event
        private void MP3TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if(mp3Player.isOpened)
            {
                string status = mp3Player.GetStatus();

                mp3Player.Seek(MP3TrackBar.Value);

                if (status == "playing")                   
                    mp3Player.Play();
                else
                    mp3Player.Pause();
            }

            isScrolled = false;
        }    

        // TrackBar ▼ 이렇게 생긴애(클릭해서 끌어당길 수 있는 애) 트랙바 클릭시 마우스 따라가게 하는 메소드
        private void SetPositionByMouse(int position)
        {
            if (position < 0 || position > trackBarLength)
                return;

            float rate = (float)position / (float)trackBarLength;
            MP3TrackBar.Value = (int)(rate * (float)(MP3TrackBar.Maximum - MP3TrackBar.Minimum));
        }


        //음악 타이머 메소드
        private void SetMusicTimer()
        {
            if (mp3Player.isOpened)
            {
                TimeSpan t = TimeSpan.FromMilliseconds(mp3Player.GetPosition());
                LB_MusicTimer.Text = string.Format("{0:D2}:{1:D2}:{2:D3}", t.Minutes, t.Seconds, t.Milliseconds);
            }
        }
    }
}
