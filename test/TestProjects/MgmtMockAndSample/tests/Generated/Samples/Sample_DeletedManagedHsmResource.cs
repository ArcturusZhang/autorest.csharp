// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using MgmtMockAndSample;

namespace MgmtMockAndSample.Samples
{
    public partial class Sample_DeletedManagedHsmResource
    {
        // Retrieve a deleted managed HSM
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RetrieveADeletedManagedHSM()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "ManagedHsms_GetDeleted" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeletedManagedHsmResource created on azure
            // for more information of creating DeletedManagedHsmResource, please refer to the document of DeletedManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("westus");
            string name = "hsm1";
            ResourceIdentifier deletedManagedHsmResourceId = DeletedManagedHsmResource.CreateResourceIdentifier(subscriptionId, location, name);
            DeletedManagedHsmResource deletedManagedHsm = client.GetDeletedManagedHsmResource(deletedManagedHsmResourceId);

            // invoke the operation
            DeletedManagedHsmResource result = await deletedManagedHsm.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeletedManagedHsmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Purge a managed HSM Pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PurgeDeleted_PurgeAManagedHSMPool()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "ManagedHsms_PurgeDeleted" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeletedManagedHsmResource created on azure
            // for more information of creating DeletedManagedHsmResource, please refer to the document of DeletedManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("westus");
            string name = "hsm1";
            ResourceIdentifier deletedManagedHsmResourceId = DeletedManagedHsmResource.CreateResourceIdentifier(subscriptionId, location, name);
            DeletedManagedHsmResource deletedManagedHsm = client.GetDeletedManagedHsmResource(deletedManagedHsmResourceId);

            // invoke the operation
            await deletedManagedHsm.PurgeDeletedAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
