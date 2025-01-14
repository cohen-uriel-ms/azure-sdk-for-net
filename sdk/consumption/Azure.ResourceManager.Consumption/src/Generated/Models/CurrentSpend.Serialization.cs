// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class CurrentSpend
    {
        internal static CurrentSpend DeserializeCurrentSpend(JsonElement element)
        {
            Optional<decimal> amount = default;
            Optional<string> unit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    amount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
            }
            return new CurrentSpend(Optional.ToNullable(amount), unit.Value);
        }
    }
}
