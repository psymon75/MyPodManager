namespace MyPodManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPodiPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusIpod = new System.Windows.Forms.ToolStripStatusLabel();
            this.lsbPlaylist = new System.Windows.Forms.ListBox();
            this.tracks = new System.Windows.Forms.DataGridView();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressCopy = new System.Windows.Forms.ToolStripProgressBar();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuldedBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executeFullBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.addPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracks)).BeginInit();
            this.menuNI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.iPodiPhoneToolStripMenuItem,
            this.playlistsToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fichierToolStripMenuItem.Text = "File";
            // 
            // iPodiPhoneToolStripMenuItem
            // 
            this.iPodiPhoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.iPodiPhoneToolStripMenuItem.Name = "iPodiPhoneToolStripMenuItem";
            this.iPodiPhoneToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.iPodiPhoneToolStripMenuItem.Text = "iPod/iPhone";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getPlaylistToolStripMenuItem,
            this.exportAllToolStripMenuItem,
            this.exportSelectedToolStripMenuItem,
            this.addPlaylistToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem});
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // getPlaylistToolStripMenuItem
            // 
            this.getPlaylistToolStripMenuItem.Name = "getPlaylistToolStripMenuItem";
            this.getPlaylistToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.getPlaylistToolStripMenuItem.Text = "Get playlist";
            this.getPlaylistToolStripMenuItem.Click += new System.EventHandler(this.getPlaylistToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusIpod,
            this.toolStripStatusLabel2,
            this.progressCopy});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(993, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "iPod/iPhone connected :";
            // 
            // statusIpod
            // 
            this.statusIpod.Name = "statusIpod";
            this.statusIpod.Size = new System.Drawing.Size(20, 17);
            this.statusIpod.Text = "No";
            // 
            // lsbPlaylist
            // 
            this.lsbPlaylist.FormattingEnabled = true;
            this.lsbPlaylist.Location = new System.Drawing.Point(12, 37);
            this.lsbPlaylist.Name = "lsbPlaylist";
            this.lsbPlaylist.Size = new System.Drawing.Size(159, 264);
            this.lsbPlaylist.TabIndex = 2;
            this.lsbPlaylist.SelectedIndexChanged += new System.EventHandler(this.lsbPlaylist_SelectedIndexChanged);
            // 
            // tracks
            // 
            this.tracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tracks.Location = new System.Drawing.Point(192, 37);
            this.tracks.Name = "tracks";
            this.tracks.Size = new System.Drawing.Size(789, 382);
            this.tracks.TabIndex = 3;
            this.tracks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tracks_RowHeaderMouseDoubleClick);
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportAllToolStripMenuItem.Text = "Export all";
            this.exportAllToolStripMenuItem.Click += new System.EventHandler(this.exportAllToolStripMenuItem_Click);
            // 
            // exportSelectedToolStripMenuItem
            // 
            this.exportSelectedToolStripMenuItem.Name = "exportSelectedToolStripMenuItem";
            this.exportSelectedToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportSelectedToolStripMenuItem.Text = "Export selected";
            this.exportSelectedToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel2.Text = "Copy :";
            // 
            // progressCopy
            // 
            this.progressCopy.Name = "progressCopy";
            this.progressCopy.Size = new System.Drawing.Size(100, 16);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shuldedBackupToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // shuldedBackupToolStripMenuItem
            // 
            this.shuldedBackupToolStripMenuItem.Name = "shuldedBackupToolStripMenuItem";
            this.shuldedBackupToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.shuldedBackupToolStripMenuItem.Text = "Scheduled backup";
            // 
            // NI
            // 
            this.NI.ContextMenuStrip = this.menuNI;
            this.NI.Icon = ((System.Drawing.Icon)(resources.GetObject("NI.Icon")));
            this.NI.Text = "MyPodManager";
            this.NI.Visible = true;
            // 
            // menuNI
            // 
            this.menuNI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeFullBackupToolStripMenuItem});
            this.menuNI.Name = "menuNI";
            this.menuNI.Size = new System.Drawing.Size(203, 26);
            // 
            // executeFullBackupToolStripMenuItem
            // 
            this.executeFullBackupToolStripMenuItem.Name = "executeFullBackupToolStripMenuItem";
            this.executeFullBackupToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.executeFullBackupToolStripMenuItem.Text = "Execute playlists backup";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Location = new System.Drawing.Point(13, 308);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(0, 13);
            this.lblPlaylist.TabIndex = 5;
            // 
            // addPlaylistToolStripMenuItem
            // 
            this.addPlaylistToolStripMenuItem.Name = "addPlaylistToolStripMenuItem";
            this.addPlaylistToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addPlaylistToolStripMenuItem.Text = "Add playlist";
            this.addPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addPlaylistToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save playlist -> Device";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 457);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.tracks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lsbPlaylist);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyPodManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracks)).EndInit();
            this.menuNI.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPodiPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusIpod;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPlaylistToolStripMenuItem;
        private System.Windows.Forms.ListBox lsbPlaylist;
        private System.Windows.Forms.DataGridView tracks;
        private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar progressCopy;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuldedBackupToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NI;
        private System.Windows.Forms.ContextMenuStrip menuNI;
        private System.Windows.Forms.ToolStripMenuItem executeFullBackupToolStripMenuItem;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.ToolStripMenuItem addPlaylistToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
    }
}

