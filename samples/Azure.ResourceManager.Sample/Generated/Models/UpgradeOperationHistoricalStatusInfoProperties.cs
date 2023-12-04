// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes each OS upgrade on the Virtual Machine Scale Set.
    /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties
    /// </summary>
    public partial class UpgradeOperationHistoricalStatusInfoProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpgradeOperationHistoricalStatusInfoProperties"/>. </summary>
        internal UpgradeOperationHistoricalStatusInfoProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpgradeOperationHistoricalStatusInfoProperties"/>. </summary>
        /// <param name="runningStatus">
        /// Information about the overall status of the upgrade operation.
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.runningStatus
        /// </param>
        /// <param name="progress">
        /// Counts of the VMs in each state.
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.progress
        /// </param>
        /// <param name="error">
        /// Error Details for this upgrade if there are any.
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.error
        /// </param>
        /// <param name="startedBy">
        /// Invoker of the Upgrade Operation
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.startedBy
        /// </param>
        /// <param name="targetImageReference">
        /// Image Reference details
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.targetImageReference
        /// </param>
        /// <param name="rollbackInfo">
        /// Information about OS rollback if performed
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.rollbackInfo
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpgradeOperationHistoricalStatusInfoProperties(UpgradeOperationHistoryStatus runningStatus, RollingUpgradeProgressInfo progress, ApiError error, UpgradeOperationInvoker? startedBy, ImageReference targetImageReference, RollbackStatusInfo rollbackInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RunningStatus = runningStatus;
            Progress = progress;
            Error = error;
            StartedBy = startedBy;
            TargetImageReference = targetImageReference;
            RollbackInfo = rollbackInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Information about the overall status of the upgrade operation.
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.runningStatus
        /// </summary>
        public UpgradeOperationHistoryStatus RunningStatus { get; }
        /// <summary>
        /// Counts of the VMs in each state.
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.progress
        /// </summary>
        public RollingUpgradeProgressInfo Progress { get; }
        /// <summary>
        /// Error Details for this upgrade if there are any.
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.error
        /// </summary>
        public ApiError Error { get; }
        /// <summary>
        /// Invoker of the Upgrade Operation
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.startedBy
        /// </summary>
        public UpgradeOperationInvoker? StartedBy { get; }
        /// <summary>
        /// Image Reference details
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.targetImageReference
        /// </summary>
        public ImageReference TargetImageReference { get; }
        /// <summary>
        /// Information about OS rollback if performed
        /// Serialized Name: UpgradeOperationHistoricalStatusInfoProperties.rollbackInfo
        /// </summary>
        public RollbackStatusInfo RollbackInfo { get; }
    }
}
