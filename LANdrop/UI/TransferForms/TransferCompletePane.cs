﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using LANdrop.Networking;

namespace LANdrop.UI.TransferForms
{
    /// <summary>
    /// Shown when somebody wants to send us a file; shows links to accept or reject it.
    /// </summary>
    public partial class TransferCompletePane : AutoHidePane
    {
        private IncomingTransfer transfer;

        public TransferCompletePane( IncomingTransfer transfer )
        {
            InitializeComponent( );
            this.transfer = transfer;

            lblTitle.Text = String.Format( "{0} received successfully!", transfer.FileName );
            Width = lblTitle.Width + lblTitle.Left + 16;
            OnHideTimeChanged( );
        }

        protected override void OnHideTimeChanged( )
        {
            lblHide.Text = String.Format( "Hide ({0})", secondsToHide );
        }

        private void lblHide_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            ParentNotification.StartClose( );
        }

        private void lblOpenFolder_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {

        }
    }
}
