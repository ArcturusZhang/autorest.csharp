// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using NUnit.Framework;
using _Specs_.Azure.Core.Basic;
using _Specs_.Azure.Core.Basic.Models;

namespace _Specs_.Azure.Core.Basic.Samples
{
    public partial class Samples_TwoModelsAsPageItem
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetFirstItems_ShortVersion()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (BinaryData item in client.GetFirstItems(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetFirstItems_ShortVersion_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (BinaryData item in client.GetFirstItemsAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetFirstItems_ShortVersion_Convenience()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (FirstItem item in client.GetFirstItems())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetFirstItems_ShortVersion_Convenience_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (FirstItem item in client.GetFirstItemsAsync())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetFirstItems_AllParameters()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (BinaryData item in client.GetFirstItems(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetFirstItems_AllParameters_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (BinaryData item in client.GetFirstItemsAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetFirstItems_AllParameters_Convenience()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (FirstItem item in client.GetFirstItems())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetFirstItems_AllParameters_Convenience_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (FirstItem item in client.GetFirstItemsAsync())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetSecondItems_ShortVersion()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (BinaryData item in client.GetSecondItems(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetSecondItems_ShortVersion_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (BinaryData item in client.GetSecondItemsAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetSecondItems_ShortVersion_Convenience()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (SecondItem item in client.GetSecondItems())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetSecondItems_ShortVersion_Convenience_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (SecondItem item in client.GetSecondItemsAsync())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetSecondItems_AllParameters()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (BinaryData item in client.GetSecondItems(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetSecondItems_AllParameters_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (BinaryData item in client.GetSecondItemsAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("name").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_TwoModelsAsPageItem_GetSecondItems_AllParameters_Convenience()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            foreach (SecondItem item in client.GetSecondItems())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_TwoModelsAsPageItem_GetSecondItems_AllParameters_Convenience_Async()
        {
            TwoModelsAsPageItem client = new BasicClient().GetTwoModelsAsPageItemClient();

            await foreach (SecondItem item in client.GetSecondItemsAsync())
            {
            }
        }
    }
}
