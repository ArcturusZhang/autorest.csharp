// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Inbound NAT rule of the load balancer. </summary>
    public partial class InboundNatRule : SubResource
    {
        /// <summary> Initializes a new instance of InboundNatRule. </summary>
        public InboundNatRule()
        {
        }

        /// <summary> Initializes a new instance of InboundNatRule. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="frontendIPConfiguration"> A reference to frontend IP addresses. </param>
        /// <param name="backendIPConfiguration"> A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP. </param>
        /// <param name="protocol"> The reference to the transport protocol used by the load balancing rule. </param>
        /// <param name="frontendPort"> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534. </param>
        /// <param name="backendPort"> The port used for the internal endpoint. Acceptable values range from 1 to 65535. </param>
        /// <param name="idleTimeoutInMinutes"> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </param>
        /// <param name="enableFloatingIP"> Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can&apos;t be changed after you create the endpoint. </param>
        /// <param name="enableTcpReset"> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </param>
        /// <param name="provisioningState"> The provisioning state of the inbound NAT rule resource. </param>
        internal InboundNatRule(string id, string name, string etag, string type, SubResource frontendIPConfiguration, NetworkInterfaceIPConfiguration backendIPConfiguration, TransportProtocol? protocol, int? frontendPort, int? backendPort, int? idleTimeoutInMinutes, bool? enableFloatingIP, bool? enableTcpReset, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            FrontendIPConfiguration = frontendIPConfiguration;
            BackendIPConfiguration = backendIPConfiguration;
            Protocol = protocol;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            EnableTcpReset = enableTcpReset;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> A reference to frontend IP addresses. </summary>
        public SubResource FrontendIPConfiguration { get; set; }
        /// <summary> A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP. </summary>
        public NetworkInterfaceIPConfiguration BackendIPConfiguration { get; }
        /// <summary> The reference to the transport protocol used by the load balancing rule. </summary>
        public TransportProtocol? Protocol { get; set; }
        /// <summary> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534. </summary>
        public int? FrontendPort { get; set; }
        /// <summary> The port used for the internal endpoint. Acceptable values range from 1 to 65535. </summary>
        public int? BackendPort { get; set; }
        /// <summary> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can&apos;t be changed after you create the endpoint. </summary>
        public bool? EnableFloatingIP { get; set; }
        /// <summary> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </summary>
        public bool? EnableTcpReset { get; set; }
        /// <summary> The provisioning state of the inbound NAT rule resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
