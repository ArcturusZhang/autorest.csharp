// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System;
using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Models;
using Azure.ResourceManager;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class ArmResourceExtension : MgmtExtensions
    {
        private readonly IEnumerable<MgmtExtensions> _siblingArmResourceExtensions;

        public ArmResourceExtension(IEnumerable<MgmtExtensions> siblingArmResourceExtensions)
            : base(Enumerable.Empty<Operation>(), typeof(ArmResource), RequestPath.Null)
        {
            _siblingArmResourceExtensions = siblingArmResourceExtensions;
        }

        public override bool IsEmpty => _siblingArmResourceExtensions.All(ext => ext.IsEmpty);

        public override MgmtExtensionClient ExtensionClient => throw new InvalidOperationException("ArmClientExtension does not have an extension client");
    }
}
