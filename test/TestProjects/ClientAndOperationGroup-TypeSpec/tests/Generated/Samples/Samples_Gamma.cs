// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.ClientAndOperationGroupService;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace ClientAndOperationGroup.Samples
{
    internal class Samples_Gamma
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Four()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = client.Four();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Four_AllParameters()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = client.Four();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Four_Async()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = await client.FourAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Four_AllParameters_Async()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = await client.FourAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Five()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = client.Five();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Five_AllParameters()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = client.Five();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Five_Async()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = await client.FiveAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Five_AllParameters_Async()
        {
<<<<<<< HEAD
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            Gamma client = new ClientAndOperationGroupServiceClient(endpoint).GetGammaClient();
=======
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();
>>>>>>> origin/feature/v3

            Response response = await client.FiveAsync();

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
