﻿namespace LANdrop.UI
{
    partial class NotificationPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container( );
            this.rejectCountdownTimer = new System.Windows.Forms.Timer( this.components );
            this.SuspendLayout( );
            // 
            // rejectCountdownTimer
            // 
            this.rejectCountdownTimer.Enabled = true;
            this.rejectCountdownTimer.Interval = 1000;
            this.rejectCountdownTimer.Tick += new System.EventHandler( this.rejectCountdownTimer_Tick );
            // 
            // AutoHidePane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 64 ) ) ) ), ( (int) ( ( (byte) ( 64 ) ) ) ), ( (int) ( ( (byte) ( 64 ) ) ) ) );
            this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.Name = "AutoHidePane";
            this.Size = new System.Drawing.Size( 449, 68 );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Timer rejectCountdownTimer;

    }
}