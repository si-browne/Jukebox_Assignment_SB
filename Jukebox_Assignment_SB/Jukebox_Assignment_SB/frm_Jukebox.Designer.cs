﻿namespace jukebox_assignment_SB
{
    partial class frm_Jukebox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Jukebox));
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.txt_Genre_Title = new System.Windows.Forms.TextBox();
            this.lst_Genre_List = new System.Windows.Forms.ListBox();
            this.hscr_Selector = new System.Windows.Forms.HScrollBar();
            this.txt_Presently_Playing = new System.Windows.Forms.TextBox();
            this.lst_Playlist = new System.Windows.Forms.ListBox();
            this.media_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_timer = new System.Windows.Forms.Timer(this.components);
            this.mnu_Jukebox = new System.Windows.Forms.MenuStrip();
            this.btn_Setup = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_About = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).BeginInit();
            this.mnu_Jukebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.AutoSize = true;
            this.lbl_Copyright.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Copyright.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Copyright.Location = new System.Drawing.Point(242, -2);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(203, 13);
            this.lbl_Copyright.TabIndex = 0;
            this.lbl_Copyright.Text = "Copyright (c) 2018. Simon Browne.";
            // 
            // txt_Genre_Title
            // 
            this.txt_Genre_Title.BackColor = System.Drawing.Color.Thistle;
            this.txt_Genre_Title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Genre_Title.Location = new System.Drawing.Point(95, 151);
            this.txt_Genre_Title.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Genre_Title.Name = "txt_Genre_Title";
            this.txt_Genre_Title.ReadOnly = true;
            this.txt_Genre_Title.Size = new System.Drawing.Size(255, 27);
            this.txt_Genre_Title.TabIndex = 1;
            // 
            // lst_Genre_List
            // 
            this.lst_Genre_List.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Genre_List.FormattingEnabled = true;
            this.lst_Genre_List.Location = new System.Drawing.Point(95, 178);
            this.lst_Genre_List.Margin = new System.Windows.Forms.Padding(0);
            this.lst_Genre_List.Name = "lst_Genre_List";
            this.lst_Genre_List.Size = new System.Drawing.Size(255, 95);
            this.lst_Genre_List.TabIndex = 2;
            this.lst_Genre_List.DoubleClick += new System.EventHandler(this.lst_Genre_List_DoubleClick);
            // 
            // hscr_Selector
            // 
            this.hscr_Selector.LargeChange = 1;
            this.hscr_Selector.Location = new System.Drawing.Point(95, 273);
            this.hscr_Selector.Name = "hscr_Selector";
            this.hscr_Selector.Size = new System.Drawing.Size(255, 24);
            this.hscr_Selector.TabIndex = 3;
            this.hscr_Selector.ValueChanged += new System.EventHandler(this.hscr_Selector_ValueChanged);
            // 
            // txt_Presently_Playing
            // 
            this.txt_Presently_Playing.BackColor = System.Drawing.Color.PaleGreen;
            this.txt_Presently_Playing.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Presently_Playing.Location = new System.Drawing.Point(95, 324);
            this.txt_Presently_Playing.Name = "txt_Presently_Playing";
            this.txt_Presently_Playing.ReadOnly = true;
            this.txt_Presently_Playing.Size = new System.Drawing.Size(255, 23);
            this.txt_Presently_Playing.TabIndex = 4;
            // 
            // lst_Playlist
            // 
            this.lst_Playlist.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Playlist.FormattingEnabled = true;
            this.lst_Playlist.Location = new System.Drawing.Point(109, 353);
            this.lst_Playlist.Name = "lst_Playlist";
            this.lst_Playlist.Size = new System.Drawing.Size(228, 134);
            this.lst_Playlist.TabIndex = 5;
            // 
            // media_player
            // 
            this.media_player.Enabled = true;
            this.media_player.Location = new System.Drawing.Point(95, 48);
            this.media_player.Name = "media_player";
            this.media_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media_player.OcxState")));
            this.media_player.Size = new System.Drawing.Size(255, 45);
            this.media_player.TabIndex = 6;
            this.media_player.Visible = false;
            this.media_player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.media_player_PlayStateChange);
            // 
            // track_timer
            // 
            this.track_timer.Interval = 3000;
            this.track_timer.Tick += new System.EventHandler(this.track_timer_Tick);
            // 
            // mnu_Jukebox
            // 
            this.mnu_Jukebox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mnu_Jukebox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Setup,
            this.btn_About});
            this.mnu_Jukebox.Location = new System.Drawing.Point(0, 684);
            this.mnu_Jukebox.Name = "mnu_Jukebox";
            this.mnu_Jukebox.Size = new System.Drawing.Size(444, 24);
            this.mnu_Jukebox.TabIndex = 7;
            this.mnu_Jukebox.Text = "menuStrip1";
            // 
            // btn_Setup
            // 
            this.btn_Setup.Name = "btn_Setup";
            this.btn_Setup.ShortcutKeyDisplayString = "";
            this.btn_Setup.Size = new System.Drawing.Size(53, 20);
            this.btn_Setup.Text = "Set Up";
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // btn_About
            // 
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(52, 20);
            this.btn_About.Text = "About";
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // frm_Jukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 708);
            this.Controls.Add(this.media_player);
            this.Controls.Add(this.lst_Playlist);
            this.Controls.Add(this.txt_Presently_Playing);
            this.Controls.Add(this.hscr_Selector);
            this.Controls.Add(this.lst_Genre_List);
            this.Controls.Add(this.txt_Genre_Title);
            this.Controls.Add(this.lbl_Copyright);
            this.Controls.Add(this.mnu_Jukebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_Jukebox;
            this.Name = "frm_Jukebox";
            this.Text = "My Juke Box v1.0";
            this.Load += new System.EventHandler(this.frm_Jukebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).EndInit();
            this.mnu_Jukebox.ResumeLayout(false);
            this.mnu_Jukebox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.TextBox txt_Genre_Title;
        private System.Windows.Forms.ListBox lst_Genre_List;
        private System.Windows.Forms.HScrollBar hscr_Selector;
        private System.Windows.Forms.TextBox txt_Presently_Playing;
        private System.Windows.Forms.ListBox lst_Playlist;
        private AxWMPLib.AxWindowsMediaPlayer media_player;
        private System.Windows.Forms.Timer track_timer;
        private System.Windows.Forms.MenuStrip mnu_Jukebox;
        private System.Windows.Forms.ToolStripMenuItem btn_Setup;
        private System.Windows.Forms.ToolStripMenuItem btn_About;
    }
}

