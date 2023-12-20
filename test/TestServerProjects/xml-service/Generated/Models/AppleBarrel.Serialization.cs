// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class AppleBarrel : IXmlSerializable, IPersistableModel<AppleBarrel>
    {
        private void WriteInternal(XmlWriter writer, string nameHint, ModelReaderWriterOptions options)
        {
            writer.WriteStartElement(nameHint ?? "AppleBarrel");
            if (Optional.IsCollectionDefined(GoodApples))
            {
                writer.WriteStartElement("GoodApples");
                foreach (var item in GoodApples)
                {
                    writer.WriteStartElement("Apple");
                    writer.WriteValue(item);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            if (Optional.IsCollectionDefined(BadApples))
            {
                writer.WriteStartElement("BadApples");
                foreach (var item in BadApples)
                {
                    writer.WriteStartElement("Apple");
                    writer.WriteValue(item);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => WriteInternal(writer, nameHint, new ModelReaderWriterOptions("W"));

        internal static AppleBarrel DeserializeAppleBarrel(XElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            IList<string> goodApples = default;
            IList<string> badApples = default;
            if (element.Element("GoodApples") is XElement goodApplesElement)
            {
                var array = new List<string>();
                foreach (var e in goodApplesElement.Elements("Apple"))
                {
                    array.Add((string)e);
                }
                goodApples = array;
            }
            if (element.Element("BadApples") is XElement badApplesElement)
            {
                var array = new List<string>();
                foreach (var e in badApplesElement.Elements("Apple"))
                {
                    array.Add((string)e);
                }
                badApples = array;
            }
            return new AppleBarrel(goodApples, badApples, serializedAdditionalRawData: null);
        }

        BinaryData IPersistableModel<AppleBarrel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppleBarrel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    {
                        using MemoryStream stream = new MemoryStream();
                        using XmlWriter writer = XmlWriter.Create(stream);
                        WriteInternal(writer, null, options);
                        writer.Flush();
                        return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AppleBarrel)} does not support '{options.Format}' format.");
            }
        }

        AppleBarrel IPersistableModel<AppleBarrel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppleBarrel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    return DeserializeAppleBarrel(XElement.Load(data.ToStream()), options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AppleBarrel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppleBarrel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "X";
    }
}
