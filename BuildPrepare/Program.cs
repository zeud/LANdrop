﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BuildPrepare
{
    class Program
    {
        const string fileName = @"LANdrop\BuildInfo.cs";
        const string tempFileName = @"LANdrop\BuildInfo.cs.old";

        const string versionDef = @"public const int BUILD_NUMBER = ";
        const string channelDef = @"public const UpdateChannels BUILD_TYPE = UpdateChannels.";

        static void Main( string[] args )
        {
            if ( args.Length < 2 )
            {
                Console.WriteLine( "Usage: LDprepare buildNumber channel" );
                Environment.Exit( -1 );
                return;
            }

            if ( !File.Exists( fileName ) )
            {
                Console.WriteLine( fileName + " does not exist" );
                Environment.Exit( -2 );
                return;
            }

            // Update LANdrop's BuildInfo.cs before building it.
            File.Delete( tempFileName );
            File.Move( fileName, tempFileName );
            Console.WriteLine( "Processing " + fileName + "..." );
            using ( StreamReader reader = new StreamReader( tempFileName ) )
            using ( StreamWriter writer = new StreamWriter( fileName ) )
            {
                while ( !reader.EndOfStream )
                {
                    string line = reader.ReadLine( );

                    if ( line.Trim( ).StartsWith( versionDef ) )
                        line = versionDef + args[0] + ";";
                    else if ( line.Trim( ).StartsWith( channelDef ) )
                        line = channelDef + args[1] + ";";

                    writer.WriteLine( line );
                }
            }
            Console.WriteLine( "Recreated " + fileName + "..." );

            // Update buildDeploy.bat
            File.Delete( tempFileName );
            Console.WriteLine( "Processing deployScript.bat..." );
            using ( StreamReader reader = new StreamReader( "Scripts\\deployScript.bat" ) )
            using ( StreamWriter writer = new StreamWriter( "Scripts\\deployScript.new.bat" ) )
            {
                while ( !reader.EndOfStream )
                {
                    string line = reader.ReadLine( );

                    // Add the build number to the path.
                    if ( line.Trim( ).StartsWith( "cd /home/phillco/landrop.net/downloads" ) )
                    {
                        writer.WriteLine( line );
                        writer.WriteLine( String.Format( "cd {0}\nmkdir {1}\ncd {1}", args[1].ToLower( ), args[0] ) );
                        continue;
                    }
                    else if ( line.Trim( ).StartsWith( "put version.json" ) )
                        line = "put " + args[1].ToLower( ) + ".json";

                    writer.WriteLine( line );
                }
            }

            // Create a json file for the web server.
            using ( StreamWriter writer = new StreamWriter( args[1].ToLower( ) + ".json" ) )
            {
                var info = new VersionInfo
                {
                    buildNumber = int.Parse( args[0] ),
                    channel = args[1].ToLower( ),
                    buildDate = DateTime.Now.ToUniversalTime( ).ToString( )
                };
                writer.Write( JsonConvert.SerializeObject( info, Formatting.Indented ) );
            }
        }

        class VersionInfo
        {
            public int buildNumber;

            public string channel;

            public string buildDate;
        }
    }
}