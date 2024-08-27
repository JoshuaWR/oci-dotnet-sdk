/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
        /// In general, this is a specific version of bundled ESXi software supported by
        /// Oracle Cloud VMware Solution (see
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}).
        /// <br/>
        /// This attribute is not guaranteed to reflect the version of
        /// software currently installed on the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the version of software that the Oracle
        /// Cloud VMware Solution will install on any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost} 
        /// unless a different version is configured on the Cluster or ESXi host level.
        /// <br/>
        /// Therefore, if you upgrade the existing ESXi hosts in the SDDC to use a newer
        /// version of bundled ESXi software supported by the Oracle Cloud VMware Solution, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `vmwareSoftwareVersion` with that new version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "esxiSoftwareVersion")]
        public string EsxiSoftwareVersion { get; set; }
        
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
        /// The number of Clusters in the SDDC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClustersCount is required.")]
        [JsonProperty(PropertyName = "clustersCount")]
        public System.Nullable<int> ClustersCount { get; set; }
        
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
        /// The SDDC includes an administrator username and password for vCenter. You can
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the `PrivateIp` object that is
        /// the virtual IP (VIP) for the NSX Edge Uplink. Use this OCID as the route target for
        /// route table rules when setting up connectivity between the SDDC and other networks.
        /// For information about `PrivateIp` objects, see the Core Services API.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsxEdgeUplinkIpId")]
        public string NsxEdgeUplinkIpId { get; set; }
        
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
        /// HCX configuration of the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HcxMode is required.")]
        [JsonProperty(PropertyName = "hcxMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HcxModes> HcxMode { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InitialConfiguration is required.")]
        [JsonProperty(PropertyName = "initialConfiguration")]
        public InitialConfiguration InitialConfiguration { get; set; }
        
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
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {orcl-cloud: {free-tier-retain: true}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
