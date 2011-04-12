﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace LANdrop.Updates
{
    /// <summary>
    /// Applies newly downloaded versions of LANdrop. This is a three step process:
    ///     1. We're the old version, and we sense a newer build in /Update. Launch it with instructions to upgrade us.
    ///     2. We're the update, running in /Update. Copy us over the old version, then launch it.
    ///     3. We're the updated version. Clean up and run normally.
    /// </summary>
    class UpdateApplier
    {
        /// <summary>
        /// Whether this process has just been updated. Useful for displaying UI cues ("what's new" screen, etc).
        /// </summary>
        public static bool RunningNewVersion { get; private set; }

        /// <summary>
        /// Checks if we're in the middle of an update process, applying the update if needed.
        /// </summary>
        /// <returns>Whether the program should exit after calling this.</returns>
        public static bool Run( )
        {
            // See if we've been updated already, and just need to clean up.
            if ( Program.CommandLineArgs.Contains( "/completeUpdate" ) )
            {
                CompleteUpdate( );
                return false;
            }

            // See if we're the new build in /Update and need to update the old version.
            if ( Program.CommandLineArgs.Contains( "/applyUpdate" ) )
            {
                OverwriteOldVersion( );
                return true;
            }

            // Otherwise, just see if there's a new build to update to.
            return CheckForNewVersion( );
        }

        /// <summary>
        /// Searches for newly downloaded updates to apply.
        /// </summary>
        /// <returns>Whether one was found (and launched)</returns>
        private static bool CheckForNewVersion( )
        {
            if ( !Directory.Exists( @"LANdrop\Update" ) )
                return false;

            foreach ( string path in Directory.GetFiles( @"LANdrop\Update" ) )
            {
                FileInfo file = new FileInfo( path );

                // TODO: Check to see if this actually a newer build than the one we're running.
                if ( file.Name.StartsWith( "LANdrop" ) && file.Name.EndsWith( ".exe" ) )
                {
                    using ( Process proc = new Process( ) )
                    {
                        proc.StartInfo.FileName = file.FullName;
                        proc.StartInfo.Arguments = "/applyUpdate";
                        proc.Start( );
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Finds the old version that spawned this instance, and updates it.
        /// </summary>
        private static void OverwriteOldVersion( )
        {
            // Find the parent build.
            string parent = Path.Combine( new FileInfo( Application.ExecutablePath ).Directory.Parent.Parent.FullName, "LANdrop.exe" );

            // Copy this file over the old version (wait as necessary for it to exit).
            for ( int i = 0; i < 500; i++ )
            {
                try
                {
                    File.Copy( Application.ExecutablePath, parent, true );
                    break;
                }
                catch ( IOException ) { Thread.Sleep( 5 * i ); } // Thrown when the file is in use.
            }

            // Launch it with instructions to clean up.
            using ( Process proc = new Process( ) )
            {
                proc.StartInfo.FileName = parent;
                proc.StartInfo.Arguments = "/completeUpdate";
                proc.Start( );
            }
        }

        /// <summary>
        /// Completes the update (running as the updated build).
        /// </summary>
        private static void CompleteUpdate( )
        {
            Directory.Delete( @"LANdrop\Update", true );
            RunningNewVersion = true;
        }
    }
}
