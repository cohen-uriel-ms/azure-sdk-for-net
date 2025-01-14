// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersGcpOffering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefenderForServers))
            {
                writer.WritePropertyName("defenderForServers");
                writer.WriteObjectValue(DefenderForServers);
            }
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning");
                writer.WriteObjectValue(ArcAutoProvisioning);
            }
            if (Optional.IsDefined(VaAutoProvisioning))
            {
                writer.WritePropertyName("vaAutoProvisioning");
                writer.WriteObjectValue(VaAutoProvisioning);
            }
            if (Optional.IsDefined(MdeAutoProvisioning))
            {
                writer.WritePropertyName("mdeAutoProvisioning");
                writer.WriteObjectValue(MdeAutoProvisioning);
            }
            if (Optional.IsDefined(SubPlan))
            {
                writer.WritePropertyName("subPlan");
                writer.WriteObjectValue(SubPlan);
            }
            writer.WritePropertyName("offeringType");
            writer.WriteStringValue(OfferingType.ToString());
            writer.WriteEndObject();
        }

        internal static DefenderForServersGcpOffering DeserializeDefenderForServersGcpOffering(JsonElement element)
        {
            Optional<DefenderForServersGcpOfferingDefenderForServers> defenderForServers = default;
            Optional<DefenderForServersGcpOfferingArcAutoProvisioning> arcAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingVaAutoProvisioning> vaAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingMdeAutoProvisioning> mdeAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingSubPlan> subPlan = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defenderForServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defenderForServers = DefenderForServersGcpOfferingDefenderForServers.DeserializeDefenderForServersGcpOfferingDefenderForServers(property.Value);
                    continue;
                }
                if (property.NameEquals("arcAutoProvisioning"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    arcAutoProvisioning = DefenderForServersGcpOfferingArcAutoProvisioning.DeserializeDefenderForServersGcpOfferingArcAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("vaAutoProvisioning"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vaAutoProvisioning = DefenderForServersGcpOfferingVaAutoProvisioning.DeserializeDefenderForServersGcpOfferingVaAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("mdeAutoProvisioning"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mdeAutoProvisioning = DefenderForServersGcpOfferingMdeAutoProvisioning.DeserializeDefenderForServersGcpOfferingMdeAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("subPlan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subPlan = DefenderForServersGcpOfferingSubPlan.DeserializeDefenderForServersGcpOfferingSubPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderForServersGcpOffering(offeringType, description.Value, defenderForServers.Value, arcAutoProvisioning.Value, vaAutoProvisioning.Value, mdeAutoProvisioning.Value, subPlan.Value);
        }
    }
}
