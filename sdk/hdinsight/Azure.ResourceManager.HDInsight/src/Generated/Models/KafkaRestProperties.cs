// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The kafka rest proxy configuration which contains AAD security group information. </summary>
    public partial class KafkaRestProperties
    {
        /// <summary> Initializes a new instance of KafkaRestProperties. </summary>
        public KafkaRestProperties()
        {
            ConfigurationOverride = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of KafkaRestProperties. </summary>
        /// <param name="clientGroupInfo"> The information of AAD security group. </param>
        /// <param name="configurationOverride"> The configurations that need to be overriden. </param>
        internal KafkaRestProperties(ClientGroupInfo clientGroupInfo, IDictionary<string, string> configurationOverride)
        {
            ClientGroupInfo = clientGroupInfo;
            ConfigurationOverride = configurationOverride;
        }

        /// <summary> The information of AAD security group. </summary>
        public ClientGroupInfo ClientGroupInfo { get; set; }
        /// <summary> The configurations that need to be overriden. </summary>
        public IDictionary<string, string> ConfigurationOverride { get; }
    }
}
