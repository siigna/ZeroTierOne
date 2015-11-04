﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinUI
{
    public class ZeroTierPeer
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("lastUnicastFrame")]
        public UInt64 LastUnicastFrame { get; set; }

        [JsonProperty("lastMulticastFrame")]
        public UInt64 LastMulticastFrame { get; set; }

        [JsonProperty("versionMajor")]
        public int VersionMajor { get; set; }

        [JsonProperty("versionMinor")]
        public int VersionMinor { get; set; }

        [JsonProperty("versionRev")]
        public int Versionrev { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        public string VersionString
        {
            get
            {
                if (Version == "-1.-1.-1")
                    return "-";
                else
                    return Version;
            }
        }

        [JsonProperty("latency")]
        public string Latency { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("paths")]
        public List<ZeroTierPeerPhysicalPath> Paths { get; set; }

        public string DataPaths
        {
            get
            {
                string pathStr = "";
                foreach(ZeroTierPeerPhysicalPath path in Paths)
                {
                    pathStr += path.Address + "\n";
                }
                return pathStr;
            }
        }
    }
}