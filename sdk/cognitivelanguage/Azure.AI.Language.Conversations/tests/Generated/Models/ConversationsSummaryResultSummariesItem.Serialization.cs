// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class ConversationsSummaryResultSummariesItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("aspect");
            writer.WriteStringValue(Aspect);
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            writer.WriteEndObject();
        }

        internal static ConversationsSummaryResultSummariesItem DeserializeConversationsSummaryResultSummariesItem(JsonElement element)
        {
            string aspect = default;
            string text = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aspect"))
                {
                    aspect = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
            }
            return new ConversationsSummaryResultSummariesItem(aspect, text);
        }
    }
}
