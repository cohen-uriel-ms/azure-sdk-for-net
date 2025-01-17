// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AppInsightsCredentials
    {
        internal static AppInsightsCredentials DeserializeAppInsightsCredentials(JsonElement element)
        {
            Optional<string> appId = default;
            Optional<string> instrumentationKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instrumentationKey"))
                {
                    instrumentationKey = property.Value.GetString();
                    continue;
                }
            }
            return new AppInsightsCredentials(appId.Value, instrumentationKey.Value);
        }
    }
}
