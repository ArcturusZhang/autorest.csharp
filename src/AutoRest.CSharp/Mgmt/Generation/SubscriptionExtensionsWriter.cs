﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoRest.CSharp.Common.Generation.Writers;
using AutoRest.CSharp.Common.Output.Builders;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace AutoRest.CSharp.Mgmt.Generation
{
    internal class SubscriptionExtensionsWriter : MgmtExtensionWriter
    {
        protected override string ExtensionOperationVariableName => "subscription";

        protected override Type ExtensionOperationVariableType => typeof(SubscriptionOperations);

        public override void WriteExtension(CodeWriter writer, BuildContext<MgmtOutputLibrary> context)
        {
            var @namespace = context.DefaultNamespace;
            using (writer.Namespace(@namespace))
            {
                writer.WriteXmlDocumentationSummary("Extension methods for convenient access on SubscriptionOperations in a client");
                using (writer.Scope($"public static partial class SubscriptionExtensions"))
                {
                    foreach (var resource in context.Library.ArmResource)
                    {
                        if (ParentDetection.ParentResourceType(resource.OperationGroup, context.Configuration.MgmtConfiguration).Equals(ResourceTypeBuilder.Subscriptions))
                        {
                            if (resource.OperationGroup.IsSingletonResource(context.Configuration.MgmtConfiguration))
                            {
                                var resourceOperation = context.Library.GetResourceOperation(resource.OperationGroup);
                                WriteChildSingletonGetOperationMethods(writer, resourceOperation);
                            }
                            else
                            {
                                writer.Line($"#region {resource.Type.Name}");
                                var resourceContainer = context.Library.GetResourceContainer(resource.OperationGroup);
                                WriteGetResourceContainerMethod(writer, resourceContainer);
                                writer.LineRaw("#endregion");
                            }
                        }
                        else
                        {
                            var resourceOperation = context.Library.GetResourceOperation(resource.OperationGroup);
                            PagingMethod? pagingMethod = default;
                            foreach (var method in resourceOperation.PagingMethods)
                            {
                                if (method.Name == "ListAll" || method.Name == "ListBySubscription")
                                {
                                    pagingMethod = method;
                                    break;
                                }
                            }
                            if (pagingMethod != null)
                            {
                                writer.Line($"#region {resource.Type.Name}");
                                WriteGetRestOperations(writer, resourceOperation.RestClient);

                                WriteListMethod(writer, resource.Type, resourceOperation.RestClient, pagingMethod, true, true);
                                WritePagingOperation(writer, resourceOperation.RestClient, pagingMethod, true);

                                WriteListMethod(writer, resource.Type, resourceOperation.RestClient, pagingMethod, false, true);
                                WritePagingOperation(writer, resourceOperation.RestClient, pagingMethod, false);

                                WriteListResourceByNameMethod(writer, resourceOperation, true);
                                WriteListResourceByNameMethod(writer, resourceOperation, false);
                                writer.LineRaw("#endregion");
                            }
                        }
                        writer.Line();
                    }

                    // write the standalone list operations with the parent of a subscription
                    var mgmtExtensionOperations = context.Library.GetMgmtExtensionOperations(ResourceTypeBuilder.Subscriptions);

                    foreach (var mgmtExtensionOperation in mgmtExtensionOperations)
                    {
                        writer.Line($"#region {mgmtExtensionOperation.Type.Name}");
                        WriteGetRestOperations(writer, mgmtExtensionOperation.RestClient);

                        // despite that we should only have one method, but we still using an IEnumerable
                        foreach (var pagingMethod in mgmtExtensionOperation.PagingMethods)
                        {
                            WriteListMethod(writer, pagingMethod.PagingResponse.ItemType, mgmtExtensionOperation.RestClient, pagingMethod, true, false);
                            WritePagingOperation(writer, mgmtExtensionOperation.RestClient, pagingMethod, true);

                            WriteListMethod(writer, pagingMethod.PagingResponse.ItemType, mgmtExtensionOperation.RestClient, pagingMethod, false, false);
                            WritePagingOperation(writer, mgmtExtensionOperation.RestClient, pagingMethod, false);
                        }

                        foreach (var clientMethod in mgmtExtensionOperation.ClientMethods)
                        {
                            WriteClientMethod(writer, mgmtExtensionOperation.RestClient, clientMethod, true);
                            WriteClientOperation(writer, mgmtExtensionOperation.RestClient, clientMethod, true);
                            WriteClientMethod(writer, mgmtExtensionOperation.RestClient, clientMethod, false);
                            WriteClientOperation(writer, mgmtExtensionOperation.RestClient, clientMethod, false);
                        }

                        writer.LineRaw("#endregion");
                        writer.Line();
                    }

                }
            }
        }

        private void WriteGetResourceContainerMethod(CodeWriter writer, ResourceContainer resourceContainer)
        {
            writer.WriteXmlDocumentationSummary($"Gets an object representing a {resourceContainer.Type.Name} along with the instance operations that can be performed on it.");
            writer.WriteXmlDocumentationParameter("subscription", $"The <see cref=\"{typeof(SubscriptionOperations)}\" /> instance the method will execute against.");

            using (writer.Scope($"public static {resourceContainer.Type} Get{resourceContainer.Type.Name}(this {typeof(SubscriptionOperations)} subscription)"))
            {
                writer.Line($"return new {resourceContainer.Type}(subscription);");
            }
        }

        private void WriteClientMethod(CodeWriter writer, MgmtRestClient restClient, ClientMethod clientMethod, bool async)
        {
            WriteClientMethod(
                writer, restClient, clientMethod,
                Enumerable.Empty<string>(),
                clientMethod.RestClientMethod.Parameters,
                async);
        }

        private void WriteListMethod(CodeWriter writer, CSharpType pageType, MgmtRestClient restClient, PagingMethod pagingMethod, bool async, bool needResourceWrapper)
        {
            WriteListMethod(writer, pageType, restClient, pagingMethod,
                new string[0],
                pagingMethod.Method.Parameters,
                async,
                needResourceWrapper);
        }

        private void WriteListResourceByNameMethod(CodeWriter writer, ResourceOperation resourceOperation, bool async)
        {
            writer.Line();
            writer.WriteXmlDocumentationSummary($"Filters the list of {resourceOperation.ResourceName}s for a {typeof(SubscriptionOperations)} represented as generic resources.");
            writer.WriteXmlDocumentationParameter("subscription", $"The <see cref=\"{typeof(SubscriptionOperations)}\" /> instance the method will execute against.");
            writer.WriteXmlDocumentationParameter("filter", "The string to filter the list.");
            writer.WriteXmlDocumentationParameter("top", "The number of results to return.");
            writer.WriteXmlDocumentationParameter("cancellationToken", "The cancellation token to use.");
            writer.WriteXmlDocumentationReturns($"A collection of resource operations that may take multiple service requests to iterate over.");

            var responseType = typeof(GenericResource).WrapPageable(async);
            using (writer.Scope($"public static {responseType} {CreateMethodName($"List{resourceOperation.ResourceName}ByName", async)}(this {typeof(SubscriptionOperations)} subscription, {typeof(string)} filter, {typeof(int?)} top, {typeof(CancellationToken)} cancellationToken = default)"))
            {
                var filters = new CodeWriterDeclaration("filters");
                writer.Line($"{typeof(ResourceFilterCollection)} {filters:D} = new({resourceOperation.Type}.ResourceType);");
                writer.Line($"{filters}.SubstringFilter = filter;");
                writer.Line($"return {typeof(ResourceListOperations)}.{CreateMethodName("ListAtContext", async)}(subscription, {filters}, top, cancellationToken);");
            }
        }

        private void WriteChildSingletonGetOperationMethods(CodeWriter writer, ResourceOperation resourceOperation)
        {
            writer.Line($"#region Get {StringExtensions.Pluralization(resourceOperation.Type.Name)} operation");

            writer.WriteXmlDocumentationSummary($"Gets an object representing a {resourceOperation.Type.Name} along with the instance operations that can be performed on it.");
            writer.WriteXmlDocumentationReturns($"Returns a <see cref=\"{resourceOperation.Type.Name}\" /> object.");
            using (writer.Scope($"public static {resourceOperation.Type} Get{StringExtensions.Pluralization(resourceOperation.Type.Name)}(this {typeof(SubscriptionOperations)} subscriptionOperations)"))
            {
                writer.Line($"return new {resourceOperation.Type.Name}(subscriptionOperations);");
            }
            writer.LineRaw("#endregion");
            writer.Line();
        }
    }
}
