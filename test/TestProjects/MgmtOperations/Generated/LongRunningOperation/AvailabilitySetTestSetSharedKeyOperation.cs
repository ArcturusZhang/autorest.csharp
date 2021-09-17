// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MgmtOperations;

namespace MgmtOperations.Models
{
    /// <summary> Testing description. </summary>
    public partial class AvailabilitySetTestSetSharedKeyOperation : Operation<ConnectionSharedKeyData>, IOperationSource<ConnectionSharedKeyData>
    {
        private readonly OperationInternals<ConnectionSharedKeyData> _operation;

        /// <summary> Initializes a new instance of AvailabilitySetTestSetSharedKeyOperation for mocking. </summary>
        protected AvailabilitySetTestSetSharedKeyOperation()
        {
        }

        internal AvailabilitySetTestSetSharedKeyOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ConnectionSharedKeyData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "AvailabilitySetTestSetSharedKeyOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ConnectionSharedKeyData Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConnectionSharedKeyData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConnectionSharedKeyData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ConnectionSharedKeyData IOperationSource<ConnectionSharedKeyData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ConnectionSharedKeyData.DeserializeConnectionSharedKeyData(document.RootElement);
        }

        async ValueTask<ConnectionSharedKeyData> IOperationSource<ConnectionSharedKeyData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ConnectionSharedKeyData.DeserializeConnectionSharedKeyData(document.RootElement);
        }
    }
}
