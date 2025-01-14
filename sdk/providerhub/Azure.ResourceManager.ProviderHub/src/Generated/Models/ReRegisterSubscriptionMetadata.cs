// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ReRegisterSubscriptionMetadata. </summary>
    public partial class ReRegisterSubscriptionMetadata
    {
        /// <summary> Initializes a new instance of ReRegisterSubscriptionMetadata. </summary>
        /// <param name="enabled"></param>
        internal ReRegisterSubscriptionMetadata(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of ReRegisterSubscriptionMetadata. </summary>
        /// <param name="enabled"></param>
        /// <param name="concurrencyLimit"></param>
        internal ReRegisterSubscriptionMetadata(bool enabled, int? concurrencyLimit)
        {
            Enabled = enabled;
            ConcurrencyLimit = concurrencyLimit;
        }

        /// <summary> Gets the enabled. </summary>
        public bool Enabled { get; }
        /// <summary> Gets the concurrency limit. </summary>
        public int? ConcurrencyLimit { get; }
    }
}
