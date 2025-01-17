// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App Dapr configuration. </summary>
    public partial class DaprProvider
    {
        /// <summary> Initializes a new instance of DaprProvider. </summary>
        public DaprProvider()
        {
        }

        /// <summary> Initializes a new instance of DaprProvider. </summary>
        /// <param name="enabled"> Boolean indicating if the Dapr side car is enabled. </param>
        /// <param name="appId"> Dapr application identifier. </param>
        /// <param name="appProtocol"> Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http. </param>
        /// <param name="appPort"> Tells Dapr which port your application is listening on. </param>
        internal DaprProvider(bool? enabled, string appId, AppProtocol? appProtocol, int? appPort)
        {
            Enabled = enabled;
            AppId = appId;
            AppProtocol = appProtocol;
            AppPort = appPort;
        }

        /// <summary> Boolean indicating if the Dapr side car is enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Dapr application identifier. </summary>
        public string AppId { get; set; }
        /// <summary> Tells Dapr which protocol your application is using. Valid options are http and grpc. Default is http. </summary>
        public AppProtocol? AppProtocol { get; set; }
        /// <summary> Tells Dapr which port your application is listening on. </summary>
        public int? AppPort { get; set; }
    }
}
