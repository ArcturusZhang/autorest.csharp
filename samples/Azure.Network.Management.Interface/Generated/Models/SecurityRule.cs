// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Network security rule. </summary>
    public partial class SecurityRule : SubResource
    {
        /// <summary> Initializes a new instance of <see cref="SecurityRule"/>. </summary>
        public SecurityRule()
        {
            SourceAddressPrefixes = new ChangeTrackingList<string>();
            SourceApplicationSecurityGroups = new ChangeTrackingList<ApplicationSecurityGroup>();
            DestinationAddressPrefixes = new ChangeTrackingList<string>();
            DestinationApplicationSecurityGroups = new ChangeTrackingList<ApplicationSecurityGroup>();
            SourcePortRanges = new ChangeTrackingList<string>();
            DestinationPortRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityRule"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="description"> A description for this rule. Restricted to 140 chars. </param>
        /// <param name="protocol"> Network protocol this rule applies to. </param>
        /// <param name="sourcePortRange"> The source port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </param>
        /// <param name="destinationPortRange"> The destination port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </param>
        /// <param name="sourceAddressPrefix"> The CIDR or source IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. If this is an ingress rule, specifies where network traffic originates from. </param>
        /// <param name="sourceAddressPrefixes"> The CIDR or source IP ranges. </param>
        /// <param name="sourceApplicationSecurityGroups"> The application security group specified as source. </param>
        /// <param name="destinationAddressPrefix"> The destination address prefix. CIDR or destination IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. </param>
        /// <param name="destinationAddressPrefixes"> The destination address prefixes. CIDR or destination IP ranges. </param>
        /// <param name="destinationApplicationSecurityGroups"> The application security group specified as destination. </param>
        /// <param name="sourcePortRanges"> The source port ranges. </param>
        /// <param name="destinationPortRanges"> The destination port ranges. </param>
        /// <param name="access"> The network traffic is allowed or denied. </param>
        /// <param name="priority"> The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </param>
        /// <param name="direction"> The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. </param>
        /// <param name="provisioningState"> The provisioning state of the security rule resource. </param>
        internal SecurityRule(string id, string name, string etag, string description, SecurityRuleProtocol? protocol, string sourcePortRange, string destinationPortRange, string sourceAddressPrefix, IList<string> sourceAddressPrefixes, IList<ApplicationSecurityGroup> sourceApplicationSecurityGroups, string destinationAddressPrefix, IList<string> destinationAddressPrefixes, IList<ApplicationSecurityGroup> destinationApplicationSecurityGroups, IList<string> sourcePortRanges, IList<string> destinationPortRanges, SecurityRuleAccess? access, int? priority, SecurityRuleDirection? direction, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Description = description;
            Protocol = protocol;
            SourcePortRange = sourcePortRange;
            DestinationPortRange = destinationPortRange;
            SourceAddressPrefix = sourceAddressPrefix;
            SourceAddressPrefixes = sourceAddressPrefixes;
            SourceApplicationSecurityGroups = sourceApplicationSecurityGroups;
            DestinationAddressPrefix = destinationAddressPrefix;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            DestinationApplicationSecurityGroups = destinationApplicationSecurityGroups;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Access = access;
            Priority = priority;
            Direction = direction;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A description for this rule. Restricted to 140 chars. </summary>
        public string Description { get; set; }
        /// <summary> Network protocol this rule applies to. </summary>
        public SecurityRuleProtocol? Protocol { get; set; }
        /// <summary> The source port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </summary>
        public string SourcePortRange { get; set; }
        /// <summary> The destination port or range. Integer or range between 0 and 65535. Asterisk &apos;*&apos; can also be used to match all ports. </summary>
        public string DestinationPortRange { get; set; }
        /// <summary> The CIDR or source IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. If this is an ingress rule, specifies where network traffic originates from. </summary>
        public string SourceAddressPrefix { get; set; }
        /// <summary> The CIDR or source IP ranges. </summary>
        public IList<string> SourceAddressPrefixes { get; }
        /// <summary> The application security group specified as source. </summary>
        public IList<ApplicationSecurityGroup> SourceApplicationSecurityGroups { get; }
        /// <summary> The destination address prefix. CIDR or destination IP range. Asterisk &apos;*&apos; can also be used to match all source IPs. Default tags such as &apos;VirtualNetwork&apos;, &apos;AzureLoadBalancer&apos; and &apos;Internet&apos; can also be used. </summary>
        public string DestinationAddressPrefix { get; set; }
        /// <summary> The destination address prefixes. CIDR or destination IP ranges. </summary>
        public IList<string> DestinationAddressPrefixes { get; }
        /// <summary> The application security group specified as destination. </summary>
        public IList<ApplicationSecurityGroup> DestinationApplicationSecurityGroups { get; }
        /// <summary> The source port ranges. </summary>
        public IList<string> SourcePortRanges { get; }
        /// <summary> The destination port ranges. </summary>
        public IList<string> DestinationPortRanges { get; }
        /// <summary> The network traffic is allowed or denied. </summary>
        public SecurityRuleAccess? Access { get; set; }
        /// <summary> The priority of the rule. The value can be between 100 and 4096. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule. </summary>
        public int? Priority { get; set; }
        /// <summary> The direction of the rule. The direction specifies if rule will be evaluated on incoming or outgoing traffic. </summary>
        public SecurityRuleDirection? Direction { get; set; }
        /// <summary> The provisioning state of the security rule resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
