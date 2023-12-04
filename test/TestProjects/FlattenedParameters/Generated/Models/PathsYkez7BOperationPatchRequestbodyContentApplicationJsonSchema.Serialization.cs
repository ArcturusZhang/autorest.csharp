// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace FlattenedParameters.Models
{
    internal partial class PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema : IUtf8JsonSerializable, IJsonModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Items))
            {
                if (Items != null)
                {
                    writer.WritePropertyName("items"u8);
                    writer.WriteStartArray();
                    foreach (var item in Items)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("items");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema IJsonModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema(document.RootElement, options);
        }

        internal static PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema DeserializePathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> items = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("items"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    items = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema(Optional.ToList(items), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema)} does not support '{options.Format}' format.");
            }
        }

        PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema IPersistableModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
