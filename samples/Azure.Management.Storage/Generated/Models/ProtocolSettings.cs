// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> Protocol settings for file service. </summary>
    internal partial class ProtocolSettings
    {
        /// <summary> Initializes a new instance of ProtocolSettings. </summary>
        public ProtocolSettings()
        {
        }

        /// <summary> Initializes a new instance of ProtocolSettings. </summary>
        /// <param name="smb"> Setting for SMB protocol. </param>
        internal ProtocolSettings(SmbSetting smb)
        {
            Smb = smb;
        }

        /// <summary> Setting for SMB protocol. </summary>
        public SmbSetting Smb { get; set; }
    }
}
