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

namespace MgmtScopeResource.Models
{
    /// <summary> Validates whether the specified template is syntactically correct and will be accepted by Azure Resource Manager.. </summary>
    public partial class DeploymentValidateAtScopeOperation : Operation<DeploymentValidateResult>, IOperationSource<DeploymentValidateResult>
    {
        private readonly OperationInternals<DeploymentValidateResult> _operation;

        /// <summary> Initializes a new instance of DeploymentValidateAtScopeOperation for mocking. </summary>
        protected DeploymentValidateAtScopeOperation()
        {
        }

        internal DeploymentValidateAtScopeOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DeploymentValidateResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DeploymentValidateAtScopeOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DeploymentValidateResult Value => _operation.Value;

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
        public override ValueTask<Response<DeploymentValidateResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DeploymentValidateResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DeploymentValidateResult IOperationSource<DeploymentValidateResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DeploymentValidateResult.DeserializeDeploymentValidateResult(document.RootElement);
        }

        async ValueTask<DeploymentValidateResult> IOperationSource<DeploymentValidateResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DeploymentValidateResult.DeserializeDeploymentValidateResult(document.RootElement);
        }
    }
}
