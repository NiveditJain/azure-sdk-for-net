// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class StorageErrorError
    {
        internal static StorageErrorError DeserializeStorageErrorError(XElement element)
        {
            string code = default;
            string message = default;
            if (element.Element("Code") is XElement codeElement)
            {
                code = (string)codeElement;
            }
            if (element.Element("Message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            return new StorageErrorError(code, message);
        }

        internal static StorageErrorError DeserializeStorageErrorError(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new StorageErrorError(code.Value, message.Value);
        }
    }
}
