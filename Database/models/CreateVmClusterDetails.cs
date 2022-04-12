/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details for the create Exadata VM cluster operation. Applies to Exadata Cloud@Customer instances only.
    /// For details on the create cloud Exadata VM cluster operation used with Exadata Cloud Service instances, see {@link #createCloudVmClusterDetails(CreateCloudVmClusterDetailsRequest) createCloudVmClusterDetails}
    /// 
    /// </summary>
    public class CreateVmClusterDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The user-friendly name for the VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "exadataInfrastructureId")]
        public string ExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The number of CPU cores to enable for the VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The number of OCPU cores to enable for the VM cluster. Only one decimal place is allowed for the fractional part.
        /// </value>
        [JsonProperty(PropertyName = "ocpuCount")]
        public System.Nullable<float> OcpuCount { get; set; }
        
        /// <value>
        /// The memory to be allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
        
        /// <value>
        /// The local node storage to be allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The data disk group size to be allocated in TBs.
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Double DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The data disk group size to be allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Double DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The public key portion of one or more key pairs used for SSH access to the VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshPublicKeys is required.")]
        [JsonProperty(PropertyName = "sshPublicKeys")]
        public System.Collections.Generic.List<string> SshPublicKeys { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the VM cluster network.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmClusterNetworkId is required.")]
        [JsonProperty(PropertyName = "vmClusterNetworkId")]
        public string VmClusterNetworkId { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the VM cluster. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the VM cluster. The default is BRING_YOUR_OWN_LICENSE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// If true, the sparse disk group is configured for the VM cluster. If false, the sparse disk group is not created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSparseDiskgroupEnabled")]
        public System.Nullable<bool> IsSparseDiskgroupEnabled { get; set; }
        
        /// <value>
        /// If true, database backup on local Exadata storage is configured for the VM cluster. If false, database backup on local Exadata storage is not available in the VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isLocalBackupEnabled")]
        public System.Nullable<bool> IsLocalBackupEnabled { get; set; }
        
        /// <value>
        /// The time zone to use for the VM cluster. For details, see [DB System Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The Oracle Grid Infrastructure software version for the VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GiVersion is required.")]
        [JsonProperty(PropertyName = "giVersion")]
        public string GiVersion { get; set; }
        
        /// <value>
        /// The list of Db server.
        /// </value>
        [JsonProperty(PropertyName = "dbServers")]
        public System.Collections.Generic.List<string> DbServers { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "dataCollectionOptions")]
        public DataCollectionOptions DataCollectionOptions { get; set; }
        
    }
}
