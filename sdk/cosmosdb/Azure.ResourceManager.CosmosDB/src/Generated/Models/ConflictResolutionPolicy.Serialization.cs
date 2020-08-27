// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ConflictResolutionPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(ConflictResolutionPath))
            {
                writer.WritePropertyName("conflictResolutionPath");
                writer.WriteStringValue(ConflictResolutionPath);
            }
            if (Optional.IsDefined(ConflictResolutionProcedure))
            {
                writer.WritePropertyName("conflictResolutionProcedure");
                writer.WriteStringValue(ConflictResolutionProcedure);
            }
            writer.WriteEndObject();
        }

        internal static ConflictResolutionPolicy DeserializeConflictResolutionPolicy(JsonElement element)
        {
            Optional<ConflictResolutionMode> mode = default;
            Optional<string> conflictResolutionPath = default;
            Optional<string> conflictResolutionProcedure = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    mode = new ConflictResolutionMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("conflictResolutionPath"))
                {
                    conflictResolutionPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conflictResolutionProcedure"))
                {
                    conflictResolutionProcedure = property.Value.GetString();
                    continue;
                }
            }
            return new ConflictResolutionPolicy(Optional.ToNullable(mode), conflictResolutionPath.Value, conflictResolutionProcedure.Value);
        }
    }
}