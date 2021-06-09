﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoRest.CSharp.Common.Output.Builders;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Output.Builders;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class MgmtExtensionOperation : TypeProvider
    {
        private BuildContext<MgmtOutputLibrary> _context;
        private ClientMethod[]? _methods;
        private PagingMethod[]? _pagingMethods;

        internal OperationGroup OperationGroup { get; }
        protected MgmtRestClient? _restClient;

        public MgmtExtensionOperation(OperationGroup operationGroup, BuildContext<MgmtOutputLibrary> context) : base(context)
        {
            _context = context;
            OperationGroup = operationGroup;

            // TODO -- this is only a temporary solution, when an operation was added here, it usually does not belong to any "Resource"
            // We will need a way to identify the name of this
            DefaultName = operationGroup.Resource(context.Configuration.MgmtConfiguration);
        }

        protected override string DefaultName { get; }

        protected override string DefaultAccessibility { get; } = "public";

        public MgmtRestClient RestClient => _restClient ??= _context.Library.GetRestClient(OperationGroup);

        public ClientMethod[] Methods => _methods ??= ClientBuilder.BuildMethods(OperationGroup, RestClient, Declaration, (_, operation, _) => $"{operation.CSharpName()}{DefaultName}").ToArray();

        public PagingMethod[] PagingMethods => _pagingMethods ??= ClientBuilder.BuildPagingMethods(OperationGroup, RestClient, Declaration, (_, operation, _) => $"{operation.CSharpName()}{DefaultName}").ToArray();
    }
}
