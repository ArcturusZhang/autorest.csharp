﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Shared;
using Azure;
using Azure.Core;
using static AutoRest.CSharp.Mgmt.Decorator.ParameterMappingBuilder;

namespace AutoRest.CSharp.Mgmt.Models
{
    /// <summary>
    /// A <see cref="MgmtClientOperation"/> includes at least one <see cref="MgmtRestOperation"/>.
    /// This is a collection of multiple methods with the same purpose but belong to different parents.
    /// For instance, one resource might how two different parents, and we can invoke the `CreateOrUpdate` under either of those parents.
    /// To make the SDK more user-friendly and considering that our SDK has been built in the "context aware" way,
    /// we group these methods together and invoke them by the current context
    /// </summary>
    internal class MgmtClientOperation : IReadOnlyList<MgmtRestOperation>
    {
        public static MgmtClientOperation Override(MgmtClientOperation clientOperation, string overrideName, CSharpType? overrideReturnType, string? overrideDescription = null, string? overrideDiagnosticName = null, MgmtTypeProvider? overrideCarrier = null)
        {
            overrideCarrier ??= clientOperation.Carrier;
            var newOperation = MgmtClientOperation.FromOperations(overrideCarrier, clientOperation.Select(operation => new MgmtRestOperation(
                other: operation,
                nameOverride: overrideName,
                overrideReturnType: overrideReturnType,
                overrideDescription: overrideDescription ?? operation.Description,
                operation.OverrideParameters)))!;

            newOperation._description = overrideDescription;
            newOperation._diagnosticName = overrideDiagnosticName;

            return newOperation;
        }

        public static MgmtClientOperation? FromOperations(MgmtTypeProvider carrier, IEnumerable<MgmtRestOperation> operations)
        {
            if (operations.Any())
            {
                return new MgmtClientOperation(carrier, operations.OrderBy(operation => operation.Name).ToArray(), null);
            }

            return null;
        }

        public static MgmtClientOperation FromOperation(MgmtTypeProvider carrier, MgmtRestOperation operation, Parameter? extensionParameter = null, bool isConvenientOperation = false)
        {
            return new MgmtClientOperation(carrier, new List<MgmtRestOperation> { operation }, extensionParameter, isConvenientOperation);
        }

        private const string IdVariableName = "Id";
        private readonly Parameter? _extensionParameter;

        public MgmtTypeProvider Carrier { get; }

        private IEnumerable<Attribute>? _attributes;
        public IEnumerable<Attribute>? Attributes => _attributes ??= EnsureAttributes();

        private IEnumerable<Attribute>? EnsureAttributes()
        {
            if (ShouldHaveForwardsClientCallAttribute())
            {
                return new[] { new ForwardsClientCallsAttribute() };
            }

            return null;
        }

        private bool ShouldHaveForwardsClientCallAttribute()
        {
            return Carrier is BaseResource || (Carrier is Resource resource && resource.CommonOperations.ContainsKey(this));
        }

        private string? _diagnosticName;
        public string DiagnosticName => _diagnosticName ??= Name;

        public Func<bool, FormattableString>? ReturnsDescription => _operations.First().ReturnsDescription;

        private IReadOnlyDictionary<RequestPath, MgmtRestOperation>? _operationMappings;
        public IReadOnlyDictionary<RequestPath, MgmtRestOperation> OperationMappings => _operationMappings ??= EnsureOperationMappings();

        private IReadOnlyDictionary<RequestPath, IEnumerable<ParameterMapping>>? _parameterMappings;
        public IReadOnlyDictionary<RequestPath, IEnumerable<ParameterMapping>> ParameterMappings => _parameterMappings ??= EnsureParameterMappings();

        private IReadOnlyList<Parameter>? _methodParameters;
        public IReadOnlyList<Parameter> MethodParameters => _methodParameters ??= EnsureMethodParameters();

        private readonly IReadOnlyList<MgmtRestOperation> _operations;

        private MgmtClientOperation(MgmtTypeProvider carrier, IReadOnlyList<MgmtRestOperation> operations, Parameter? extensionParameter, bool isConvenientOperation = false)
        {
            Carrier = carrier;
            _operations = operations;
            _extensionParameter = extensionParameter;
            IsConvenientOperation = isConvenientOperation;
        }

        public bool IsConvenientOperation { get; }

        public MgmtRestOperation this[int index] => _operations[index];

        private MethodSignature? _methodSignature;
        public MethodSignature MethodSignature => _methodSignature ??= new MethodSignature(
                Name,
                null,
                Description,
                GetModifiers(),
                IsPagingOperation
                    ? ReturnType.WrapPageable(false)
                    : ReturnType, null, MethodParameters.ToArray());

        private MethodSignatureModifiers GetModifiers()
        {
            if (Accessibility != MethodSignatureModifiers.Public)
                return Accessibility;
            if (_extensionParameter != null)
                return MethodSignatureModifiers.Public | MethodSignatureModifiers.Static | MethodSignatureModifiers.Extension;

            var defaultModifiers = MethodSignatureModifiers.Public | MethodSignatureModifiers.Virtual;
            // check if this is a common operation on base resource
            if (Carrier is BaseResource)
                return MethodSignatureModifiers.Public;

            // if this is a common operation on a resource, we should have different modifiers
            if (Carrier is Resource resource && Carrier is not ResourceCollection)
            {
                if (resource.CommonOperations.ContainsKey(this))
                {
                    // this is a common operation
                    var commonOperationModifiers = MethodSignatureModifiers.Public | MethodSignatureModifiers.New;
                    if (_operations.Any(operation => Configuration.MgmtConfiguration.VirtualOperations.Contains(operation.OperationId)))
                    {
                        commonOperationModifiers |= MethodSignatureModifiers.Virtual;
                    }
                    return commonOperationModifiers;
                }
                if (resource.CommonOperations.Values.Contains(this))
                {
                    // this is an override of core method
                    return MethodSignatureModifiers.Protected | MethodSignatureModifiers.Override;
                }
            }
            return defaultModifiers;
        }

        // TODO -- we need a better way to get the name of this
        public string Name => _operations.First().Name;

        private string? _description;
        public string Description => _description ??= BuildDescription();

        private string BuildDescription()
        {
            var pathInformation = string.Join('\n', _operations.Select(operation => $"Request Path: {operation.Operation.GetHttpPath()}\nOperation Id: {operation.OperationId}"));
            var descriptionOfOperation = _operations.First().Description;
            if (descriptionOfOperation != null)
                return $"{descriptionOfOperation}\n{pathInformation}";
            return $"{pathInformation}";
        }

        // TODO -- we need a better way to get this
        public IEnumerable<Parameter> Parameters => _operations.First().Parameters;

        public CSharpType? MgmtReturnType => _operations.First().MgmtReturnType;

        public CSharpType ReturnType => _operations.First().ReturnType;

        public MethodSignatureModifiers Accessibility => _operations.First().Accessibility;

        public int Count => _operations.Count;

        public Resource? Resource => _operations.First().Resource;

        public IEnumerator<MgmtRestOperation> GetEnumerator() => _operations.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _operations.GetEnumerator();

        public MgmtRestClient RestClient => _operations.First().RestClient;

        public bool IsLongRunningOperation => _operations.First().IsLongRunningOperation;

        public bool IsPagingOperation => _operations.First().IsPagingOperation;

        private IReadOnlyDictionary<RequestPath, MgmtRestOperation> EnsureOperationMappings()
        {
            return this.ToDictionary(
                operation => operation.ContextualPath,
                operation => operation);
        }

        private IReadOnlyDictionary<RequestPath, IEnumerable<ParameterMapping>> EnsureParameterMappings()
        {
            var contextParams = Resource?.ResourceCollection?.ExtraContextualParameterMapping ?? Enumerable.Empty<ContextualParameterMapping>();

            var contextualParameterMappings = new Dictionary<RequestPath, IEnumerable<ContextualParameterMapping>>();
            foreach (var contextualPath in OperationMappings.Keys)
            {
                var adjustedPath = Resource is not null ? contextualPath.ApplyHint(Resource.ResourceType) : contextualPath;
                contextualParameterMappings.Add(contextualPath, adjustedPath.BuildContextualParameters(IdVariableName).Concat(contextParams));
            }
            return OperationMappings.ToDictionary(
                pair => pair.Key,
                pair => pair.Value.BuildParameterMapping(contextualParameterMappings[pair.Key]));
        }

        private IReadOnlyList<Parameter> EnsureMethodParameters()
        {
            List<Parameter> parameters = new List<Parameter>();
            if (_extensionParameter is not null)
                parameters.Add(_extensionParameter);
            if (IsLongRunningOperation)
                parameters.Add(KnownParameters.WaitForCompletion);
            var overrideParameters = OperationMappings.Values.First().OverrideParameters;
            if (overrideParameters.Length > 0)
            {
                parameters.AddRange(overrideParameters);
            }
            else
            {
                parameters.AddRange(ParameterMappings.Values.First().GetPassThroughParameters());
            }
            parameters.Add(KnownParameters.CancellationTokenParameter);
            return parameters;
        }
    }
}
