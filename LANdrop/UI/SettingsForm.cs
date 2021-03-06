﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LANdrop.Updates;

namespace LANdrop.UI
{
    /// <summary>
    /// A simple form where the user can configure LANdrop's settings.
    /// </summary>
    public partial class SettingsForm : Form
    {
        public SettingsForm( )
        {
            InitializeComponent( );
            LoadFromConfiguration( Configuration.CurrentSettings );            
        }

        /// <summary>
        /// Updates the form to match the given configuration.
        /// </summary>
        private void LoadFromConfiguration( Configuration config )
        {
            tbUserName.Text = config.Username;
            cbUpdateAutomatically.Checked = config.UpdateAutomatically;
            comboUpdateChannel.Text = config.UpdateChannel.ToString( );

            // Hide the "Dev" channel, unless the user is currently using it.
            if ( config.UpdateChannel != Channel.Dev )
                comboUpdateChannel.Items.Remove( "Dev" );

            UpdateState( );
            Refresh( );
        }

        /// <summary>
        /// Saves the current state of the form to the given configuration.
        /// </summary>
        private void SaveToConfiguration( Configuration config )
        {
            config.UpdateAutomatically = cbUpdateAutomatically.Checked;
            config.UpdateChannel = ChannelFunctions.Parse( comboUpdateChannel.Text );
            config.Username = tbUserName.Text;
        }

        private void UpdateState( )
        {
            if ( BuildInfo.DoesUpdate )
                comboUpdateChannel.Enabled = lblChannel.Enabled = cbUpdateAutomatically.Checked;
            else
                comboUpdateChannel.Visible = lblChannel.Visible = cbUpdateAutomatically.Visible = false; // No updates in this build!
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            SaveToConfiguration( Configuration.CurrentSettings );
            Configuration.CurrentSettings.Save( );
        }

        private void llblResetToDefaults_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            if ( MessageBox.Show( "Are you sure you want to load the default settings?", "LANdrop Configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes )
                LoadFromConfiguration( Configuration.DefaultSettings );
        }

        private void cbUpdateAutomatically_CheckedChanged( object sender, EventArgs e )
        {
            UpdateState( );
        }
    }
}
