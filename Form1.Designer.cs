namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SongItem2 = new System.Windows.Forms.Panel();
            this.labelSinger2 = new System.Windows.Forms.Label();
            this.labelNameSong2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SongItem4 = new System.Windows.Forms.Panel();
            this.labelSinger4 = new System.Windows.Forms.Label();
            this.labelNameSong4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SongItem3 = new System.Windows.Forms.Panel();
            this.labelSinger3 = new System.Windows.Forms.Label();
            this.labelNameSong3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SongItem5 = new System.Windows.Forms.Panel();
            this.labelSinger5 = new System.Windows.Forms.Label();
            this.labelNameSong5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBoxSong5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSong4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSong2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSong3 = new System.Windows.Forms.PictureBox();
            this.MainPlayer = new System.Windows.Forms.PictureBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.pictureBoxSong1 = new System.Windows.Forms.PictureBox();
            this.labelNameSong1 = new System.Windows.Forms.Label();
            this.labelSinger1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.SongItem1 = new System.Windows.Forms.Panel();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.MainSongName = new System.Windows.Forms.Label();
            this.MainSingerName = new System.Windows.Forms.Label();
            this.BottomPanel.SuspendLayout();
            this.SongItem2.SuspendLayout();
            this.SongItem4.SuspendLayout();
            this.SongItem3.SuspendLayout();
            this.SongItem5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SongItem1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.White;
            this.BottomPanel.Controls.Add(this.MainSingerName);
            this.BottomPanel.Controls.Add(this.MainSongName);
            this.BottomPanel.Controls.Add(this.MainPictureBox);
            this.BottomPanel.Controls.Add(this.MainPlayer);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 650);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 109);
            this.BottomPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Charts 5";
            // 
            // SongItem2
            // 
            this.SongItem2.Controls.Add(this.labelSinger2);
            this.SongItem2.Controls.Add(this.labelNameSong2);
            this.SongItem2.Controls.Add(this.pictureBoxSong2);
            this.SongItem2.Controls.Add(this.label5);
            this.SongItem2.Location = new System.Drawing.Point(18, 180);
            this.SongItem2.Name = "SongItem2";
            this.SongItem2.Size = new System.Drawing.Size(770, 106);
            this.SongItem2.TabIndex = 11;
            this.SongItem2.Click += new System.EventHandler(this.Songclicks);
            this.SongItem2.MouseLeave += new System.EventHandler(this.Songleave);
            this.SongItem2.MouseHover += new System.EventHandler(this.Songhover);
            // 
            // labelSinger2
            // 
            this.labelSinger2.AutoSize = true;
            this.labelSinger2.BackColor = System.Drawing.Color.White;
            this.labelSinger2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSinger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelSinger2.Location = new System.Drawing.Point(183, 56);
            this.labelSinger2.Name = "labelSinger2";
            this.labelSinger2.Size = new System.Drawing.Size(69, 22);
            this.labelSinger2.TabIndex = 5;
            this.labelSinger2.Text = "Polycat";
            // 
            // labelNameSong2
            // 
            this.labelNameSong2.AutoSize = true;
            this.labelNameSong2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNameSong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSong2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelNameSong2.Location = new System.Drawing.Point(183, 17);
            this.labelNameSong2.Name = "labelNameSong2";
            this.labelNameSong2.Size = new System.Drawing.Size(119, 25);
            this.labelNameSong2.TabIndex = 4;
            this.labelNameSong2.Text = "SongName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(70, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "2";
            // 
            // SongItem4
            // 
            this.SongItem4.Controls.Add(this.labelSinger4);
            this.SongItem4.Controls.Add(this.labelNameSong4);
            this.SongItem4.Controls.Add(this.pictureBoxSong4);
            this.SongItem4.Controls.Add(this.label8);
            this.SongItem4.Location = new System.Drawing.Point(18, 404);
            this.SongItem4.Name = "SongItem4";
            this.SongItem4.Size = new System.Drawing.Size(770, 106);
            this.SongItem4.TabIndex = 13;
            this.SongItem4.Click += new System.EventHandler(this.Songclicks);
            this.SongItem4.MouseLeave += new System.EventHandler(this.Songleave);
            this.SongItem4.MouseHover += new System.EventHandler(this.Songhover);
            // 
            // labelSinger4
            // 
            this.labelSinger4.AutoSize = true;
            this.labelSinger4.BackColor = System.Drawing.Color.White;
            this.labelSinger4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSinger4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelSinger4.Location = new System.Drawing.Point(183, 56);
            this.labelSinger4.Name = "labelSinger4";
            this.labelSinger4.Size = new System.Drawing.Size(69, 22);
            this.labelSinger4.TabIndex = 5;
            this.labelSinger4.Text = "Polycat";
            // 
            // labelNameSong4
            // 
            this.labelNameSong4.AutoSize = true;
            this.labelNameSong4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNameSong4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSong4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelNameSong4.Location = new System.Drawing.Point(183, 17);
            this.labelNameSong4.Name = "labelNameSong4";
            this.labelNameSong4.Size = new System.Drawing.Size(119, 25);
            this.labelNameSong4.TabIndex = 4;
            this.labelNameSong4.Text = "SongName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label8.Location = new System.Drawing.Point(70, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "4";
            // 
            // SongItem3
            // 
            this.SongItem3.Controls.Add(this.labelSinger3);
            this.SongItem3.Controls.Add(this.labelNameSong3);
            this.SongItem3.Controls.Add(this.pictureBoxSong3);
            this.SongItem3.Controls.Add(this.label11);
            this.SongItem3.Location = new System.Drawing.Point(18, 292);
            this.SongItem3.Name = "SongItem3";
            this.SongItem3.Size = new System.Drawing.Size(770, 106);
            this.SongItem3.TabIndex = 12;
            this.SongItem3.Click += new System.EventHandler(this.Songclicks);
            this.SongItem3.MouseLeave += new System.EventHandler(this.Songleave);
            this.SongItem3.MouseHover += new System.EventHandler(this.Songhover);
            // 
            // labelSinger3
            // 
            this.labelSinger3.AutoSize = true;
            this.labelSinger3.BackColor = System.Drawing.Color.White;
            this.labelSinger3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSinger3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelSinger3.Location = new System.Drawing.Point(183, 56);
            this.labelSinger3.Name = "labelSinger3";
            this.labelSinger3.Size = new System.Drawing.Size(69, 22);
            this.labelSinger3.TabIndex = 5;
            this.labelSinger3.Text = "Polycat";
            // 
            // labelNameSong3
            // 
            this.labelNameSong3.AutoSize = true;
            this.labelNameSong3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNameSong3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSong3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelNameSong3.Location = new System.Drawing.Point(183, 17);
            this.labelNameSong3.Name = "labelNameSong3";
            this.labelNameSong3.Size = new System.Drawing.Size(119, 25);
            this.labelNameSong3.TabIndex = 4;
            this.labelNameSong3.Text = "SongName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label11.Location = new System.Drawing.Point(70, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "3";
            // 
            // SongItem5
            // 
            this.SongItem5.Controls.Add(this.labelSinger5);
            this.SongItem5.Controls.Add(this.labelNameSong5);
            this.SongItem5.Controls.Add(this.pictureBoxSong5);
            this.SongItem5.Controls.Add(this.label14);
            this.SongItem5.Location = new System.Drawing.Point(18, 517);
            this.SongItem5.Name = "SongItem5";
            this.SongItem5.Size = new System.Drawing.Size(770, 106);
            this.SongItem5.TabIndex = 14;
            this.SongItem5.Click += new System.EventHandler(this.Songclicks);
            this.SongItem5.MouseLeave += new System.EventHandler(this.Songleave);
            this.SongItem5.MouseHover += new System.EventHandler(this.Songhover);
            // 
            // labelSinger5
            // 
            this.labelSinger5.AutoSize = true;
            this.labelSinger5.BackColor = System.Drawing.Color.White;
            this.labelSinger5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSinger5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelSinger5.Location = new System.Drawing.Point(183, 56);
            this.labelSinger5.Name = "labelSinger5";
            this.labelSinger5.Size = new System.Drawing.Size(69, 22);
            this.labelSinger5.TabIndex = 5;
            this.labelSinger5.Text = "Polycat";
            // 
            // labelNameSong5
            // 
            this.labelNameSong5.AutoSize = true;
            this.labelNameSong5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNameSong5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSong5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelNameSong5.Location = new System.Drawing.Point(183, 17);
            this.labelNameSong5.Name = "labelNameSong5";
            this.labelNameSong5.Size = new System.Drawing.Size(119, 25);
            this.labelNameSong5.TabIndex = 4;
            this.labelNameSong5.Text = "SongName";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label14.Location = new System.Drawing.Point(70, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "5";
            // 
            // pictureBoxSong5
            // 
            this.pictureBoxSong5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSong5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSong5.Image")));
            this.pictureBoxSong5.Location = new System.Drawing.Point(110, 13);
            this.pictureBoxSong5.Name = "pictureBoxSong5";
            this.pictureBoxSong5.Size = new System.Drawing.Size(67, 77);
            this.pictureBoxSong5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSong5.TabIndex = 3;
            this.pictureBoxSong5.TabStop = false;
            // 
            // pictureBoxSong4
            // 
            this.pictureBoxSong4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSong4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSong4.Image")));
            this.pictureBoxSong4.Location = new System.Drawing.Point(110, 13);
            this.pictureBoxSong4.Name = "pictureBoxSong4";
            this.pictureBoxSong4.Size = new System.Drawing.Size(67, 77);
            this.pictureBoxSong4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSong4.TabIndex = 3;
            this.pictureBoxSong4.TabStop = false;
            // 
            // pictureBoxSong2
            // 
            this.pictureBoxSong2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSong2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSong2.Image")));
            this.pictureBoxSong2.Location = new System.Drawing.Point(110, 13);
            this.pictureBoxSong2.Name = "pictureBoxSong2";
            this.pictureBoxSong2.Size = new System.Drawing.Size(67, 77);
            this.pictureBoxSong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSong2.TabIndex = 3;
            this.pictureBoxSong2.TabStop = false;
            // 
            // pictureBoxSong3
            // 
            this.pictureBoxSong3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSong3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSong3.Image")));
            this.pictureBoxSong3.Location = new System.Drawing.Point(110, 13);
            this.pictureBoxSong3.Name = "pictureBoxSong3";
            this.pictureBoxSong3.Size = new System.Drawing.Size(67, 77);
            this.pictureBoxSong3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSong3.TabIndex = 3;
            this.pictureBoxSong3.TabStop = false;
            // 
            // MainPlayer
            // 
            this.MainPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPlayer.Image = global::WindowsFormsApp1.Properties.Resources.playIcon;
            this.MainPlayer.Location = new System.Drawing.Point(356, 24);
            this.MainPlayer.Name = "MainPlayer";
            this.MainPlayer.Size = new System.Drawing.Size(52, 49);
            this.MainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPlayer.TabIndex = 0;
            this.MainPlayer.TabStop = false;
            this.MainPlayer.Click += new System.EventHandler(this.MainPlayer_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelNumber.Location = new System.Drawing.Point(70, 39);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(24, 25);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "1";
            // 
            // pictureBoxSong1
            // 
            this.pictureBoxSong1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSong1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSong1.Image")));
            this.pictureBoxSong1.Location = new System.Drawing.Point(110, 13);
            this.pictureBoxSong1.Name = "pictureBoxSong1";
            this.pictureBoxSong1.Size = new System.Drawing.Size(67, 77);
            this.pictureBoxSong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSong1.TabIndex = 3;
            this.pictureBoxSong1.TabStop = false;
            // 
            // labelNameSong1
            // 
            this.labelNameSong1.AutoSize = true;
            this.labelNameSong1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNameSong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSong1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.labelNameSong1.Location = new System.Drawing.Point(183, 17);
            this.labelNameSong1.Name = "labelNameSong1";
            this.labelNameSong1.Size = new System.Drawing.Size(119, 25);
            this.labelNameSong1.TabIndex = 4;
            this.labelNameSong1.Text = "SongName";
            // 
            // labelSinger1
            // 
            this.labelSinger1.AutoSize = true;
            this.labelSinger1.BackColor = System.Drawing.Color.White;
            this.labelSinger1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSinger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelSinger1.Location = new System.Drawing.Point(183, 56);
            this.labelSinger1.Name = "labelSinger1";
            this.labelSinger1.Size = new System.Drawing.Size(69, 22);
            this.labelSinger1.TabIndex = 5;
            this.labelSinger1.Text = "Polycat";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.audioWave;
            this.pictureBox6.Location = new System.Drawing.Point(-51, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // SongItem1
            // 
            this.SongItem1.BackColor = System.Drawing.Color.White;
            this.SongItem1.Controls.Add(this.pictureBox6);
            this.SongItem1.Controls.Add(this.labelSinger1);
            this.SongItem1.Controls.Add(this.labelNameSong1);
            this.SongItem1.Controls.Add(this.pictureBoxSong1);
            this.SongItem1.Controls.Add(this.labelNumber);
            this.SongItem1.Location = new System.Drawing.Point(18, 68);
            this.SongItem1.Name = "SongItem1";
            this.SongItem1.Size = new System.Drawing.Size(770, 106);
            this.SongItem1.TabIndex = 2;
            this.SongItem1.Click += new System.EventHandler(this.Songclicks);
            this.SongItem1.MouseLeave += new System.EventHandler(this.Songleave);
            this.SongItem1.MouseHover += new System.EventHandler(this.Songhover);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(668, 12);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.MediaPlayer.TabIndex = 15;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(24, 10);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(67, 77);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 11;
            this.MainPictureBox.TabStop = false;
            // 
            // MainSongName
            // 
            this.MainSongName.AutoSize = true;
            this.MainSongName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.MainSongName.Location = new System.Drawing.Point(97, 21);
            this.MainSongName.Name = "MainSongName";
            this.MainSongName.Size = new System.Drawing.Size(119, 25);
            this.MainSongName.TabIndex = 11;
            this.MainSongName.Text = "SongName";
            // 
            // MainSingerName
            // 
            this.MainSingerName.AutoSize = true;
            this.MainSingerName.BackColor = System.Drawing.Color.White;
            this.MainSingerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainSingerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSingerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.MainSingerName.Location = new System.Drawing.Point(98, 57);
            this.MainSingerName.Name = "MainSingerName";
            this.MainSingerName.Size = new System.Drawing.Size(69, 22);
            this.MainSingerName.TabIndex = 11;
            this.MainSingerName.Text = "Polycat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 759);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.SongItem5);
            this.Controls.Add(this.SongItem4);
            this.Controls.Add(this.SongItem2);
            this.Controls.Add(this.SongItem3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SongItem1);
            this.Controls.Add(this.BottomPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Songclicks);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.SongItem2.ResumeLayout(false);
            this.SongItem2.PerformLayout();
            this.SongItem4.ResumeLayout(false);
            this.SongItem4.PerformLayout();
            this.SongItem3.ResumeLayout(false);
            this.SongItem3.PerformLayout();
            this.SongItem5.ResumeLayout(false);
            this.SongItem5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.SongItem1.ResumeLayout(false);
            this.SongItem1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox MainPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SongItem2;
        private System.Windows.Forms.Label labelSinger2;
        private System.Windows.Forms.Label labelNameSong2;
        private System.Windows.Forms.PictureBox pictureBoxSong2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SongItem4;
        private System.Windows.Forms.Label labelSinger4;
        private System.Windows.Forms.Label labelNameSong4;
        private System.Windows.Forms.PictureBox pictureBoxSong4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel SongItem3;
        private System.Windows.Forms.Label labelSinger3;
        private System.Windows.Forms.Label labelNameSong3;
        private System.Windows.Forms.PictureBox pictureBoxSong3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel SongItem5;
        private System.Windows.Forms.Label labelSinger5;
        private System.Windows.Forms.Label labelNameSong5;
        private System.Windows.Forms.PictureBox pictureBoxSong5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.PictureBox pictureBoxSong1;
        private System.Windows.Forms.Label labelNameSong1;
        private System.Windows.Forms.Label labelSinger1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel SongItem1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Label MainSingerName;
        private System.Windows.Forms.Label MainSongName;
        private System.Windows.Forms.PictureBox MainPictureBox;
    }
}

