/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// An [Oracle Cloud VMware Solution](https://docs.cloud.oracle.com/iaas/Content/VMware/Concepts/ocvsoverview.htm) software-defined data center (SDDC) contains the resources required for a
    /// functional VMware environment. Instances in an SDDC
    /// (see {@link EsxiHost}) run in a virtual cloud network (VCN)
    /// and are preconfigured with VMware and storage. Use the vCenter utility to manage
    /// and deploy VMware virtual machines (VMs) in the SDDC.
    /// <br/>
    /// The SDDC uses a single management subnet for provisioning the SDDC. It also uses a
    /// set of VLANs for various components of the VMware environment (vSphere, vMotion,
    /// vSAN, and so on). See the Core Services API for information about VCN subnets and VLANs.
    /// 
    /// </summary>
    public class Sddc 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The availability domain the ESXi hosts are running in. For Multi-AD SDDC, it is `multi-AD`.
        /// <br/>
        /// Example: Uocm:PHX-AD-1, multi-AD
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeAvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "computeAvailabilityDomain")]
        public string ComputeAvailabilityDomain { get; set; }
        
        /// <value>
        /// A descriptive name for the SDDC. It must be unique, start with a letter, and contain only letters, digits,
        /// whitespaces, dashes and underscores.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A prefix used in the name of each ESXi host and Compute instance in the SDDC.
        /// If this isn't set, the SDDC's `displayName` is used as the prefix.
        /// <br/>
        /// For example, if the value is `MySDDC`, the ESXi hosts are named `MySDDC-1`,
        /// `MySDDC-2`, and so on.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "instanceDisplayNamePrefix")]
        public string InstanceDisplayNamePrefix { get; set; }
        
        /// <value>
        /// In general, this is a specific version of bundled VMware software supported by
        /// Oracle Cloud VMware Solution (see
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}).
        /// <br/>
        /// This attribute is not guaranteed to reflect the version of
        /// software currently installed on the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the version of software that the Oracle
        /// Cloud VMware Solution will install on any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you upgrade the existing ESXi hosts in the SDDC to use a newer
        /// version of bundled VMware software supported by the Oracle Cloud VMware Solution, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `vmwareSoftwareVersion` with that new version.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmwareSoftwareVersion is required.")]
        [JsonProperty(PropertyName = "vmwareSoftwareVersion")]
        public string VmwareSoftwareVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that
        /// contains the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The number of ESXi hosts in the SDDC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EsxiHostsCount is required.")]
        [JsonProperty(PropertyName = "esxiHostsCount")]
        public System.Nullable<int> EsxiHostsCount { get; set; }
        
        /// <value>
        /// The billing option selected during SDDC creation.
        /// {@link #listSupportedSkus(ListSupportedSkusRequest) listSupportedSkus}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "initialSku")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<Sku> InitialSku { get; set; }
        
        /// <value>
        /// The FQDN for vCenter.
        /// <br/>
        /// Example: vcenter-my-sddc.sddc.us-phoenix-1.oraclecloud.com
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcenterFqdn is required.")]
        [JsonProperty(PropertyName = "vcenterFqdn")]
        public string VcenterFqdn { get; set; }
        
        /// <value>
        /// The FQDN for NSX Manager.
        /// <br/>
        /// Example: nsx-my-sddc.sddc.us-phoenix-1.oraclecloud.com
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxManagerFqdn is required.")]
        [JsonProperty(PropertyName = "nsxManagerFqdn")]
        public string NsxManagerFqdn { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the `PrivateIp` object that is
        /// the virtual IP (VIP) for vCenter. For information about `PrivateIp` objects, see the
        /// Core Services API.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcenterPrivateIpId is required.")]
        [JsonProperty(PropertyName = "vcenterPrivateIpId")]
        public string VcenterPrivateIpId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the `PrivateIp` object that is
        /// the virtual IP (VIP) for NSX Manager. For information about `PrivateIp` objects, see the
        /// Core Services API.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxManagerPrivateIpId is required.")]
        [JsonProperty(PropertyName = "nsxManagerPrivateIpId")]
        public string NsxManagerPrivateIpId { get; set; }
        
        /// <value>
        /// The SDDC includes an administrator username and initial password for vCenter. Make sure
        /// to change this initial vCenter password to a different value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcenterInitialPassword")]
        public string VcenterInitialPassword { get; set; }
        
        /// <value>
        /// The SDDC includes an administrator username and initial password for NSX Manager. Make sure
        /// to change this initial NSX Manager password to a different value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxManagerInitialPassword")]
        public string NsxManagerInitialPassword { get; set; }
        
        /// <value>
        /// The SDDC includes an administrator username and initial password for vCenter. You can
        /// change this initial username to a different value in vCenter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vcenterUsername")]
        public string VcenterUsername { get; set; }
        
        /// <value>
        /// The SDDC includes an administrator username and initial password for NSX Manager. You
        /// can change this initial username to a different value in NSX Manager.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxManagerUsername")]
        public string NsxManagerUsername { get; set; }
        
        /// <value>
        /// One or more public SSH keys to be included in the `~/.ssh/authorized_keys` file for
        /// the default user on each ESXi host. Use a newline character to separate multiple keys.
        /// The SSH keys must be in the format required for the `authorized_keys` file.
        /// <br/>
        /// This attribute is not guaranteed to reflect the public SSH keys
        /// currently installed on the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the public SSH keys that Oracle
        /// Cloud VMware Solution will install on any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you upgrade the existing ESXi hosts in the SDDC to use different
        /// SSH keys, you should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update
        /// the SDDC's `sshAuthorizedKeys` with the new public keys.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshAuthorizedKeys is required.")]
        [JsonProperty(PropertyName = "sshAuthorizedKeys")]
        public string SshAuthorizedKeys { get; set; }
        
        /// <value>
        /// The CIDR block for the IP addresses that VMware VMs in the SDDC use to run application
        /// workloads.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workloadNetworkCidr")]
        public string WorkloadNetworkCidr { get; set; }
        
        /// <value>
        /// The VMware NSX overlay workload segment to host your application. Connect to workload
        /// portgroup in vCenter to access this overlay segment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxOverlaySegmentName")]
        public string NsxOverlaySegmentName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the `PrivateIp` object that is
        /// the virtual IP (VIP) for the NSX Edge Uplink. Use this OCID as the route target for
        /// route table rules when setting up connectivity between the SDDC and other networks.
        /// For information about `PrivateIp` objects, see the Core Services API.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxEdgeUplinkIpId")]
        public string NsxEdgeUplinkIpId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the management subnet used
        /// to provision the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProvisioningSubnetId is required.")]
        [JsonProperty(PropertyName = "provisioningSubnetId")]
        public string ProvisioningSubnetId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the vSphere component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the vSphere VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the vSphere VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the vSphere component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `vsphereVlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VsphereVlanId is required.")]
        [JsonProperty(PropertyName = "vsphereVlanId")]
        public string VsphereVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the vMotion component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the vMotion VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the vMotion VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the vMotion component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `vmotionVlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmotionVlanId is required.")]
        [JsonProperty(PropertyName = "vmotionVlanId")]
        public string VmotionVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the vSAN component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the vSAN VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the vSAN VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the vSAN component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `vsanVlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VsanVlanId is required.")]
        [JsonProperty(PropertyName = "vsanVlanId")]
        public string VsanVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the NSX VTEP component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the NSX VTEP VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the NSX VTEP VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the NSX VTEP component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `nsxVTepVlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxVTepVlanId is required.")]
        [JsonProperty(PropertyName = "nsxVTepVlanId")]
        public string NsxVTepVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the NSX Edge VTEP component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the NSX Edge VTEP VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the NSX Edge VTEP VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the NSX Edge VTEP component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `nsxEdgeVTepVlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxEdgeVTepVlanId is required.")]
        [JsonProperty(PropertyName = "nsxEdgeVTepVlanId")]
        public string NsxEdgeVTepVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the NSX Edge Uplink 1 component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the NSX Edge Uplink 1 VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the NSX Edge Uplink 1 VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the NSX Edge Uplink 1 component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `nsxEdgeUplink1VlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxEdgeUplink1VlanId is required.")]
        [JsonProperty(PropertyName = "nsxEdgeUplink1VlanId")]
        public string NsxEdgeUplink1VlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the NSX Edge Uplink 2 component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the NSX Edge Uplink 2 VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the NSX Edge Uplink 2 VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the NSX Edge Uplink 2 component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `nsxEdgeUplink2VlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NsxEdgeUplink2VlanId is required.")]
        [JsonProperty(PropertyName = "nsxEdgeUplink2VlanId")]
        public string NsxEdgeUplink2VlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the vSphere Replication component of the VMware environment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "replicationVlanId")]
        public string ReplicationVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the Provisioning component of the VMware environment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "provisioningVlanId")]
        public string ProvisioningVlanId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the `PrivateIp` object that is
        /// the virtual IP (VIP) for HCX Manager. For information about `PrivateIp` objects, see the
        /// Core Services API.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hcxPrivateIpId")]
        public string HcxPrivateIpId { get; set; }
        
        /// <value>
        /// The FQDN for HCX Manager.
        /// <br/>
        /// Example: hcx-my-sddc.sddc.us-phoenix-1.oraclecloud.com
        /// </value>
        [JsonProperty(PropertyName = "hcxFqdn")]
        public string HcxFqdn { get; set; }
        
        /// <value>
        /// The SDDC includes an administrator username and initial password for HCX Manager. Make sure
        /// to change this initial HCX Manager password to a different value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hcxInitialPassword")]
        public string HcxInitialPassword { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VLAN used by the SDDC
        /// for the HCX component of the VMware environment.
        /// <br/>
        /// This attribute is not guaranteed to reflect the HCX VLAN
        /// currently used by the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the HCX VLAN that the Oracle
        /// Cloud VMware Solution will use for any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you change the existing ESXi hosts in the SDDC to use a different VLAN
        /// for the HCX component of the VMware environment, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `hcxVlanId` with that new VLAN's OCID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hcxVlanId")]
        public string HcxVlanId { get; set; }
        
        /// <value>
        /// Indicates whether HCX is enabled for this SDDC.
        /// </value>
        [JsonProperty(PropertyName = "isHcxEnabled")]
        public System.Nullable<bool> IsHcxEnabled { get; set; }
        
        /// <value>
        /// The activation keys to use on the on-premises HCX Enterprise appliances you site pair with HCX Manager in your VMware Solution.
        /// The number of keys provided depends on the HCX license type. HCX Advanced provides 3 activation keys.
        /// HCX Enterprise provides 10 activation keys.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hcxOnPremKey")]
        public string HcxOnPremKey { get; set; }
        
        /// <value>
        /// Indicates whether HCX Enterprise is enabled for this SDDC.
        /// </value>
        [JsonProperty(PropertyName = "isHcxEnterpriseEnabled")]
        public System.Nullable<bool> IsHcxEnterpriseEnabled { get; set; }
        
        /// <value>
        /// Indicates whether SDDC is pending downgrade from HCX Enterprise to HCX Advanced.
        /// </value>
        [JsonProperty(PropertyName = "isHcxPendingDowngrade")]
        public System.Nullable<bool> IsHcxPendingDowngrade { get; set; }
        
        /// <value>
        /// The activation licenses to use on the on-premises HCX Enterprise appliance you site pair with HCX Manager in your VMware Solution.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hcxOnPremLicenses")]
        public System.Collections.Generic.List<HcxLicenseSummary> HcxOnPremLicenses { get; set; }
        
        /// <value>
        /// The date and time current HCX Enterprise billing cycle ends, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeHcxBillingCycleEnd")]
        public System.Nullable<System.DateTime> TimeHcxBillingCycleEnd { get; set; }
        
        /// <value>
        /// The date and time the SDDC's HCX on-premise license status was updated, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeHcxLicenseStatusUpdated")]
        public System.Nullable<System.DateTime> TimeHcxLicenseStatusUpdated { get; set; }
        
        /// <value>
        /// Indicates whether this SDDC is designated for only single ESXi host.
        /// </value>
        [JsonProperty(PropertyName = "isSingleHostSddc")]
        public System.Nullable<bool> IsSingleHostSddc { get; set; }
        
        /// <value>
        /// The date and time the SDDC was created, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the SDDC was updated, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the SDDC.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// The vSphere licenses to be used when upgrade SDDC.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "upgradeLicenses")]
        public System.Collections.Generic.List<VsphereLicense> UpgradeLicenses { get; set; }
        
        /// <value>
        /// The link of guidance to upgrade vSphere.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vsphereUpgradeGuide")]
        public string VsphereUpgradeGuide { get; set; }
        
        /// <value>
        /// The links of binary objects needed for upgrade vSphere.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vsphereUpgradeObjects")]
        public System.Collections.Generic.List<VsphereUpgradeObject> VsphereUpgradeObjects { get; set; }
        
        /// <value>
        /// The initial compute shape of the SDDC's ESXi hosts.
        /// {@link #listSupportedHostShapes(ListSupportedHostShapesRequest) listSupportedHostShapes}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InitialHostShapeName is required.")]
        [JsonProperty(PropertyName = "initialHostShapeName")]
        public string InitialHostShapeName { get; set; }
        
        /// <value>
        /// The initial OCPU count of the SDDC's ESXi hosts.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "initialHostOcpuCount")]
        public System.Nullable<float> InitialHostOcpuCount { get; set; }
        
        /// <value>
        /// Indicates whether shielded instance is enabled at the SDDC level.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isShieldedInstanceEnabled")]
        public System.Nullable<bool> IsShieldedInstanceEnabled { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Capacity Reservation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "capacityReservationId")]
        public string CapacityReservationId { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
