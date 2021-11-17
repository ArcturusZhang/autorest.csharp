// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;
using NUnit.Framework;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for Vault. </summary>
    public partial class VaultMockTests : MockTestBase
    {
        public VaultMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        public VaultMockTests() : this(false)
        {
        }

        private async Task<MgmtKeyvault.VaultCollection> GetVaultCollectionAsync(string resourceGroupName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            VaultCollection vaultCollection = resourceGroup.GetVaults();
            return vaultCollection;
        }

        private async Task<MgmtKeyvault.Vault> GetVaultAsync()
        {
            var collection = await GetVaultCollectionAsync("sample-resource-group");
            var createOperation = await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "sample-vault");
            return createOperation.Value;
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task GetAsync()
        {
            // Example: Retrieve a vault
            var resource = await GetVaultAsync();

            await resource.GetAsync();
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task DeleteAsync()
        {
            // Example: Delete a vault
            var resource = await GetVaultAsync();

            await resource.DeleteAsync();
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task UpdateAsync()
        {
            // Example: Update an existing vault
            var resource = await GetVaultAsync();
            IDictionary<string, string> tags = null;
            var properties = new MgmtKeyvault.Models.VaultPatchProperties()
            {
                TenantId = System.Guid.Parse("00000000-0000-0000-0000-000000000000"),
                Sku = new MgmtKeyvault.Models.Sku(new MgmtKeyvault.Models.SkuFamily("A"), SkuName.Standard),
                EnabledForDeployment = true,
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
            };

            await resource.UpdateAsync(tags, properties);
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task GetPrivateLinkResourcesAsync()
        {
            // Example: KeyVaultListPrivateLinkResources
            var resource = await GetVaultAsync();

            await resource.GetPrivateLinkResourcesAsync();
        }
    }
}
