// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Models
{
    internal partial class TargetTypeListResult
    {
        internal static TargetTypeListResult DeserializeTargetTypeListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<TargetTypeData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetTypeData> array = new List<TargetTypeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetTypeData.DeserializeTargetTypeData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TargetTypeListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
