// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes an upgrade policy - automatic, manual, or rolling.
    /// Serialized Name: UpgradePolicy
    /// </summary>
    public partial class UpgradePolicy
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

        /// <summary> Initializes a new instance of <see cref="UpgradePolicy"/>. </summary>
        public UpgradePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpgradePolicy"/>. </summary>
        /// <param name="mode">
        /// Specifies the mode of an upgrade to virtual machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt; **Automatic** - All virtual machines in the scale set are  automatically updated at the same time.
        /// Serialized Name: UpgradePolicy.mode
        /// </param>
        /// <param name="rollingUpgradePolicy">
        /// The configuration parameters used while performing a rolling upgrade.
        /// Serialized Name: UpgradePolicy.rollingUpgradePolicy
        /// </param>
        /// <param name="automaticOSUpgradePolicy">
        /// Configuration parameters used for performing automatic OS Upgrade.
        /// Serialized Name: UpgradePolicy.automaticOSUpgradePolicy
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpgradePolicy(UpgradeMode? mode, RollingUpgradePolicy rollingUpgradePolicy, AutomaticOSUpgradePolicy automaticOSUpgradePolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Mode = mode;
            RollingUpgradePolicy = rollingUpgradePolicy;
            AutomaticOSUpgradePolicy = automaticOSUpgradePolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Specifies the mode of an upgrade to virtual machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt; **Automatic** - All virtual machines in the scale set are  automatically updated at the same time.
        /// Serialized Name: UpgradePolicy.mode
        /// </summary>
        public UpgradeMode? Mode { get; set; }
        /// <summary>
        /// The configuration parameters used while performing a rolling upgrade.
        /// Serialized Name: UpgradePolicy.rollingUpgradePolicy
        /// </summary>
        public RollingUpgradePolicy RollingUpgradePolicy { get; set; }
        /// <summary>
        /// Configuration parameters used for performing automatic OS Upgrade.
        /// Serialized Name: UpgradePolicy.automaticOSUpgradePolicy
        /// </summary>
        public AutomaticOSUpgradePolicy AutomaticOSUpgradePolicy { get; set; }
    }
}
