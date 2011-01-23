﻿namespace LANdrop.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container( );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem( "Phillip", 0 );
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem( "Jim", 1 );
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem( "Simon", 1 );
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem( "Will", 0 );
            this.onlineIcons = new System.Windows.Forms.ImageList( this.components );
            this.statusStrip = new System.Windows.Forms.StatusStrip( );
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel( );
            this.contentPanel = new System.Windows.Forms.Panel( );
            this.btnSend = new System.Windows.Forms.Button( );
            this.btnAddPerson = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.receipientList = new System.Windows.Forms.ListView( );
            this.recipientContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.sendFileToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.sendTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.sendClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this.copyIPAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.refreshPeerListTimer = new System.Windows.Forms.Timer( this.components );
            this.mainMenu = new System.Windows.Forms.MenuStrip( );
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem( );
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem( );
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.trayIcon = new System.Windows.Forms.NotifyIcon( this.components );
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem( );
            this.showLANdropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.selectFileToSendDialog = new System.Windows.Forms.OpenFileDialog( );
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator( );
            this.statusStrip.SuspendLayout( );
            this.contentPanel.SuspendLayout( );
            this.recipientContextMenu.SuspendLayout( );
            this.mainMenu.SuspendLayout( );
            this.trayIconMenu.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // onlineIcons
            // 
            this.onlineIcons.ImageStream = ( (System.Windows.Forms.ImageListStreamer) ( resources.GetObject( "onlineIcons.ImageStream" ) ) );
            this.onlineIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.onlineIcons.Images.SetKeyName( 0, "status_offline.png" );
            this.onlineIcons.Images.SetKeyName( 1, "status_online.png" );
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus} );
            this.statusStrip.Location = new System.Drawing.Point( 0, 304 );
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size( 244, 22 );
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size( 229, 17 );
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add( this.btnSend );
            this.contentPanel.Controls.Add( this.btnAddPerson );
            this.contentPanel.Controls.Add( this.label1 );
            this.contentPanel.Controls.Add( this.receipientList );
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point( 0, 24 );
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding( 16, 42, 16, 48 );
            this.contentPanel.Size = new System.Drawing.Size( 244, 280 );
            this.contentPanel.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point( 144, 243 );
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size( 84, 25 );
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
            this.btnAddPerson.Location = new System.Drawing.Point( 14, 243 );
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size( 98, 25 );
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Text = "Add user...";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler( this.btnSendFile_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point( 16, 14 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 169, 16 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a user to send to:";
            // 
            // receipientList
            // 
            this.receipientList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.receipientList.AllowDrop = true;
            this.receipientList.ContextMenuStrip = this.recipientContextMenu;
            this.receipientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receipientList.FullRowSelect = true;
            this.receipientList.GridLines = true;
            this.receipientList.HideSelection = false;
            this.receipientList.Items.AddRange( new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8} );
            this.receipientList.Location = new System.Drawing.Point( 16, 42 );
            this.receipientList.Name = "receipientList";
            this.receipientList.Size = new System.Drawing.Size( 212, 190 );
            this.receipientList.SmallImageList = this.onlineIcons;
            this.receipientList.TabIndex = 2;
            this.receipientList.UseCompatibleStateImageBehavior = false;
            this.receipientList.View = System.Windows.Forms.View.List;
            this.receipientList.DragDrop += new System.Windows.Forms.DragEventHandler( this.receipientList_DragDrop );
            this.receipientList.DragEnter += new System.Windows.Forms.DragEventHandler( this.receipientList_DragEnter );
            this.receipientList.DragLeave += new System.EventHandler( this.receipientList_DragLeave );
            this.receipientList.DragOver += new System.Windows.Forms.DragEventHandler( this.receipientList_DragOver );
            // 
            // recipientContextMenu
            // 
            this.recipientContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.sendFileToToolStripMenuItem,
            this.sendTextToolStripMenuItem,
            this.sendClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyIPAddressToolStripMenuItem} );
            this.recipientContextMenu.Name = "recipientConextMenu";
            this.recipientContextMenu.Size = new System.Drawing.Size( 154, 98 );
            this.recipientContextMenu.Opening += new System.ComponentModel.CancelEventHandler( this.recipientContextMenu_Opening );
            // 
            // sendFileToToolStripMenuItem
            // 
            this.sendFileToToolStripMenuItem.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.sendFileToToolStripMenuItem.Name = "sendFileToToolStripMenuItem";
            this.sendFileToToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.sendFileToToolStripMenuItem.Text = "Send file...";
            // 
            // sendTextToolStripMenuItem
            // 
            this.sendTextToolStripMenuItem.Name = "sendTextToolStripMenuItem";
            this.sendTextToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.sendTextToolStripMenuItem.Text = "Send text...";
            this.sendTextToolStripMenuItem.Click += new System.EventHandler( this.sendTextToolStripMenuItem_Click );
            // 
            // sendClipboardToolStripMenuItem
            // 
            this.sendClipboardToolStripMenuItem.Name = "sendClipboardToolStripMenuItem";
            this.sendClipboardToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.sendClipboardToolStripMenuItem.Text = "Send clipboard";
            this.sendClipboardToolStripMenuItem.Click += new System.EventHandler( this.sendClipboardContentsToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 150, 6 );
            // 
            // copyIPAddressToolStripMenuItem
            // 
            this.copyIPAddressToolStripMenuItem.Name = "copyIPAddressToolStripMenuItem";
            this.copyIPAddressToolStripMenuItem.Size = new System.Drawing.Size( 153, 22 );
            this.copyIPAddressToolStripMenuItem.Text = "Copy IP";
            this.copyIPAddressToolStripMenuItem.Click += new System.EventHandler( this.copyIPAddressToolStripMenuItem_Click );
            // 
            // refreshPeerListTimer
            // 
            this.refreshPeerListTimer.Enabled = true;
            this.refreshPeerListTimer.Interval = 1000;
            this.refreshPeerListTimer.Tick += new System.EventHandler( this.refreshPeerListTimer_Tick );
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1} );
            this.mainMenu.Location = new System.Drawing.Point( 0, 0 );
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size( 244, 24 );
            this.mainMenu.TabIndex = 7;
            this.mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem} );
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size( 37, 20 );
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 92, 22 );
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem} );
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::LANdrop.Properties.Resources.setting_tools;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size( 116, 22 );
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler( this.optionsToolStripMenuItem_Click );
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem} );
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size( 44, 20 );
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size( 116, 22 );
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler( this.aboutToolStripMenuItem_Click );
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "trayIcon.Icon" ) ) );
            this.trayIcon.Text = "LANdrop";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler( this.trayIcon_MouseClick );
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.showLANdropToolStripMenuItem,
            this.sendToToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1} );
            this.trayIconMenu.Name = "trayIconMenu";
            this.trayIconMenu.Size = new System.Drawing.Size( 158, 98 );
            this.trayIconMenu.Opening += new System.ComponentModel.CancelEventHandler( this.trayIconMenu_Opening );
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size( 157, 22 );
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler( this.exitToolStripMenuItem1_Click );
            // 
            // showLANdropToolStripMenuItem
            // 
            this.showLANdropToolStripMenuItem.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.showLANdropToolStripMenuItem.Name = "showLANdropToolStripMenuItem";
            this.showLANdropToolStripMenuItem.Size = new System.Drawing.Size( 157, 22 );
            this.showLANdropToolStripMenuItem.Text = "Show LANdrop";
            this.showLANdropToolStripMenuItem.Click += new System.EventHandler( this.showLANdropToolStripMenuItem_Click );
            // 
            // sendToToolStripMenuItem
            // 
            this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
            this.sendToToolStripMenuItem.Size = new System.Drawing.Size( 157, 22 );
            this.sendToToolStripMenuItem.Text = "Send to";
            // 
            // selectFileToSendDialog
            // 
            this.selectFileToSendDialog.Title = "Select a file to send";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 154, 6 );
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 244, 326 );
            this.Controls.Add( this.contentPanel );
            this.Controls.Add( this.statusStrip );
            this.Controls.Add( this.mainMenu );
            this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size( 300, 600 );
            this.MinimumSize = new System.Drawing.Size( 230, 250 );
            this.Name = "MainForm";
            this.Text = "LANdrop";
            this.Resize += new System.EventHandler( this.MainForm_Resize );
            this.statusStrip.ResumeLayout( false );
            this.statusStrip.PerformLayout( );
            this.contentPanel.ResumeLayout( false );
            this.contentPanel.PerformLayout( );
            this.recipientContextMenu.ResumeLayout( false );
            this.mainMenu.ResumeLayout( false );
            this.mainMenu.PerformLayout( );
            this.trayIconMenu.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.ImageList onlineIcons;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView receipientList;
        private System.Windows.Forms.ContextMenuStrip recipientContextMenu;
        private System.Windows.Forms.ToolStripMenuItem sendFileToToolStripMenuItem;
        private System.Windows.Forms.Timer refreshPeerListTimer;
        private System.Windows.Forms.ToolStripMenuItem copyIPAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showLANdropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog selectFileToSendDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

