// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Describes a virtual machines scale set IP Configuration&apos;s PublicIPAddress configuration. </summary>
    public partial class VirtualMachineScaleSetUpdatePublicIPAddressConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdatePublicIPAddressConfiguration"/>. </summary>
        public VirtualMachineScaleSetUpdatePublicIPAddressConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdatePublicIPAddressConfiguration"/>. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the public IP address. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the publicIP addresses . </param>
        internal VirtualMachineScaleSetUpdatePublicIPAddressConfiguration(string name, int? idleTimeoutInMinutes, VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings)
        {
            Name = name;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DnsSettings = dnsSettings;
        }

        /// <summary> The publicIP address configuration name. </summary>
        public string Name { get; set; }
        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The dns settings to be applied on the publicIP addresses . </summary>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public string DnsDomainNameLabel
        {
            get => DnsSettings is null ? default : DnsSettings.DomainNameLabel;
            set => DnsSettings = new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(value);
        }
    }
}
