using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.songLists;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public List<Song> SongLists = new List<Song>();
        public Form1()
        {
            InitializeComponent();
            SongLists.Add(new Song1());
            SongLists.Add(new Song2());
            SongLists.Add(new Song3());
            SongLists.Add(new Song4());
            SongLists.Add(new Song5());

            //set image
            this.pictureBoxSong1.Image = SongLists[0].songImage;
            this.pictureBoxSong2.Image = SongLists[1].songImage;
            this.pictureBoxSong3.Image = SongLists[2].songImage;
            this.pictureBoxSong4.Image = SongLists[3].songImage;
            this.pictureBoxSong5.Image = SongLists[4].songImage;

            //set name song
            this.labelNameSong1.Text = SongLists[0].songName;
            this.labelNameSong2.Text = SongLists[1].songName;
            this.labelNameSong3.Text = SongLists[2].songName;
            this.labelNameSong4.Text = SongLists[3].songName;
            this.labelNameSong5.Text = SongLists[4].songName;

            //set name singer
            this.labelSinger1.Text = SongLists[0].songSingerName;
            this.labelSinger2.Text = SongLists[1].songSingerName;
            this.labelSinger3.Text = SongLists[2].songSingerName;
            this.labelSinger4.Text = SongLists[3].songSingerName;
            this.labelSinger5.Text = SongLists[4].songSingerName;

            //hide media player
            this.MediaPlayer.Visible = false;
        }
        private void Songhover(object sender, EventArgs e)
        {
            Panel songItems = (Panel)sender;
            if (songItems.Name == "SongItem1")
            {
                this.SongItem1.BackColor = Color.Gainsboro;
                this.labelSinger1.BackColor = Color.Gainsboro;
                this.SongItem1.Cursor = Cursors.Hand;
            }
            if (songItems.Name == "SongItem2")
            {
                this.SongItem2.BackColor = Color.Gainsboro;
                this.labelSinger2.BackColor = Color.Gainsboro;
                this.SongItem2.Cursor = Cursors.Hand;
            }
            if (songItems.Name == "SongItem3")
            {
                this.SongItem3.BackColor = Color.Gainsboro;
                this.labelSinger3.BackColor = Color.Gainsboro;
                this.SongItem3.Cursor = Cursors.Hand;
            }
            if (songItems.Name == "SongItem4")
            {
                this.SongItem4.BackColor = Color.Gainsboro;
                this.labelSinger4.BackColor = Color.Gainsboro;
                this.SongItem4.Cursor = Cursors.Hand;
            }
            if (songItems.Name == "SongItem5")
            {
                this.SongItem5.BackColor = Color.Gainsboro;
                this.labelSinger5.BackColor = Color.Gainsboro;
                this.SongItem5.Cursor = Cursors.Hand;
            }
        }

        private void Songleave(object sender, EventArgs e)
        {
            Panel songItems = (Panel)sender;
            if (songItems.Name == "SongItem1")
            {
                this.SongItem1.BackColor = Color.White;
                this.labelSinger1.BackColor = Color.White;
                this.SongItem1.Cursor = Cursors.Default;

            }
            if (songItems.Name == "SongItem2")
            {
                this.SongItem2.BackColor = Color.White;
                this.labelSinger2.BackColor = Color.White;
                this.SongItem2.Cursor = Cursors.Default;

            }
            if (songItems.Name == "SongItem3")
            {
                this.SongItem3.BackColor = Color.White;
                this.labelSinger3.BackColor = Color.White;
                this.SongItem3.Cursor = Cursors.Default;

            }
            if (songItems.Name == "SongItem4")
            {
                this.SongItem4.BackColor = Color.White;
                this.labelSinger4.BackColor = Color.White;
                this.SongItem4.Cursor = Cursors.Default;
            }
            if (songItems.Name == "SongItem5")
            {
                this.SongItem5.BackColor = Color.White;
                this.labelSinger5.BackColor = Color.White;
                this.SongItem5.Cursor = Cursors.Default;
            }
        }

        public string playIng = "";

        private void Songclicks(object sender, EventArgs e)
        {
            Panel songItems = (Panel)sender;
            this.playIng = "play";
            if (songItems.Name == "SongItem1")
            {
                this.MediaPlayer.URL = SongLists[0].songAudio;
                this.MainPictureBox.Image = SongLists[0].songImage;
                this.MainSongName.Text = SongLists[0].songName;
                this.MainSingerName.Text = SongLists[0].songSingerName;
                this.MainPlayer.Image = Properties.Resources.pasueIcon;
            }if (songItems.Name == "SongItem2")
            {
                this.MediaPlayer.URL = SongLists[1].songAudio;
                this.MainPictureBox.Image = SongLists[1].songImage;
                this.MainSongName.Text = SongLists[1].songName;
                this.MainSingerName.Text = SongLists[1].songSingerName;
                this.MainPlayer.Image = Properties.Resources.pasueIcon;
            }
            if (songItems.Name == "SongItem3")
            {
                this.MediaPlayer.URL = SongLists[2].songAudio;
                this.MainPictureBox.Image = SongLists[2].songImage;
                this.MainSongName.Text = SongLists[2].songName;
                this.MainSingerName.Text = SongLists[2].songSingerName;
                this.MainPlayer.Image = Properties.Resources.pasueIcon;
            }
            if (songItems.Name == "SongItem4")
            {
                this.MediaPlayer.URL = SongLists[3].songAudio;
                this.MainPictureBox.Image = SongLists[3].songImage;
                this.MainSongName.Text = SongLists[3].songName;
                this.MainSingerName.Text = SongLists[3].songSingerName;
                this.MainPlayer.Image = Properties.Resources.pasueIcon;
            }
            if (songItems.Name == "SongItem5")
            {
                this.MediaPlayer.URL = SongLists[4].songAudio;
                this.MainPictureBox.Image = SongLists[4].songImage;
                this.MainSongName.Text = SongLists[4].songName;
                this.MainSingerName.Text = SongLists[4].songSingerName;
                this.MainPlayer.Image = Properties.Resources.pasueIcon;
            }
        }

        private void MainPlayer_Click(object sender, EventArgs e)
        {
            if(this.playIng == "play")
            {
                this.playIng = "pause";
                this.MediaPlayer.Ctlcontrols.pause();
                this.MainPlayer.Image = Properties.Resources.playIcon;
            }
            else
            {
                this.playIng = "play";
                this.MediaPlayer.Ctlcontrols.play();
                this.MainPlayer.Image = Properties.Resources.pasueIcon;
            }
        }
    }
}
