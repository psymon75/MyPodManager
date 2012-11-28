using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SharePodLib.Parsers.iTunesDB;
using SharePodLib.Export;

namespace MyPodManager
{
    public partial class Form1 : Form
    {
        SharePodLib.IPod iPod;
        PlaylistList playlists;
        int nb_track;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SharePodLib.Device.IPodConnected += new SharePodLib.Device.IPodConnectedHandler(Device_IPodConnected);
            SharePodLib.Device.IPodDisconnected += new SharePodLib.Device.IPodDisconnectedHandler(Device_IPodDisconnected);

            //tell SharePodLib to listen for new iPods
            SharePodLib.Device.ListenForDeviceChanges(this.Handle);
        }

        void Device_IPodDisconnected(EventArgs args)
        {
            MessageBox.Show("iPod/iPhone disconnected !", "iPod/iPhone disconnected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iPod = null;
        }

        void Device_IPodConnected(SharePodLib.IPod iPodin)
        {
            if (MessageBox.Show("iPod/iPhone detected ! Do you want to connected to it ?", "iPod/iPhone detected", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.iPod = iPodin;
                NI.BalloonTipIcon = ToolTipIcon.Info;
                NI.BalloonTipText = "Device connected.";
                NI.BalloonTipTitle = "Device connected";
                NI.ShowBalloonTip(3);
                //statusIpod.Text = iPod.DeviceInfo.SerialNumber.ToString();
            }
        }

        void showPlaylistById(int id)
        {
            Playlist selectedPlaylist = iPod.Playlists[id];

            tracks.DataSource = selectedPlaylist.BindingTrackList;
        }

        void getPlaylists()
        {
            lsbPlaylist.Items.Clear();
            playlists = iPod.Playlists;
            for (int i = 0; i < playlists.Count; i++)
            {

                lsbPlaylist.Items.Add(playlists[i].Name.ToString());
            }
            lblPlaylist.Text = "Playlists : " + playlists.Count;
        }

        private void getPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iPod != null)
            {
                getPlaylists();
            }
            else
            {
                MessageBox.Show("Please connect your iPod/iPhone", "No device detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPlaylistById(lsbPlaylist.SelectedIndex);
        }

        private void exportSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPodFileExporter exporter = new IPodFileExporter(iPod);
            List<Playlist> selected = new List<Playlist>();
            selected.Add(playlists[lsbPlaylist.SelectedIndex]);
            exporter.SetPlaylistsToCopy(selected);
            exporter.ProgressEvent += new IPodFileExporter.ProgressEventHandler(exporter_ProgressEvent);
            exporter.Completed += new IPodFileExporter.CompletedEventHandler(exporter_Completed);
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                progressCopy.Value = 0;
                nb_track = selected[0].TrackCount;
                progressCopy.Maximum = nb_track;
                exporter.PerformCopy(FBD.SelectedPath, "[Artist] - [Album] - [Title]", null, IPodFileExporter.FilenameCollisionBehavior.Ignore);
            }
            
        }


        void exporter_Completed(string message)
        {
            MessageBox.Show("Copy has been complet", "Copy OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void exporter_ProgressEvent(Track track)
        {
            progressCopy.Value++;
        }

        private void exportAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPodFileExporter exporter = new IPodFileExporter(iPod);
            List<Playlist> selected = new List<Playlist>();
            for (int i = 0; i < lsbPlaylist.Items.Count; i++)
            {
                selected.Add(playlists[i]);
            }
            exporter.SetPlaylistsToCopy(selected);
            exporter.ProgressEvent += new IPodFileExporter.ProgressEventHandler(exporter_ProgressEvent);
            exporter.Completed += new IPodFileExporter.CompletedEventHandler(exporter_Completed);
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                progressCopy.Value = 0;
                nb_track = 0;
                for (int i = 0; i < selected.Count; i++)
                {
                    nb_track += selected[i].TrackCount;
                }
                progressCopy.Maximum = nb_track;
                exporter.PerformCopy(FBD.SelectedPath, "[Artist] - [Album] - [Title]", null, IPodFileExporter.FilenameCollisionBehavior.Ignore);
            }
        }

        private void tracks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void addPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = ShowDialog("Playlist name :", "New playlist");
            iPod.Playlists.Add(name);
            getPlaylists();
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 200;
            prompt.Height = 150;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 100 };
            Button confirmation = new Button() { Text = "Ok", Left = 75, Width = 50, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            return textBox.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (iPod != null)
            {
                iPod.SaveChanges();
                iPod.StartSync();
            }
            else
            {
                MessageBox.Show("bad");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'R')
            {
                iPod.Refresh();
            }
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iPod.Playlists.Remove(iPod.Playlists[lsbPlaylist.SelectedIndex], true);
            getPlaylists();
        }
    }
}
