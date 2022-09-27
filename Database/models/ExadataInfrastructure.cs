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
    /// ExadataInfrastructure
    /// </summary>
    public class ExadataInfrastructure 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The current lifecycle state of the Exadata infrastructure.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "REQUIRES_ACTIVATION")]
            RequiresActivation,
            [EnumMember(Value = "ACTIVATING")]
            Activating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "ACTIVATION_FAILED")]
            ActivationFailed,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress
        };

        /// <value>
        /// The current lifecycle state of the Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The user-friendly name for the Exadata Cloud@Customer infrastructure. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The shape of the Exadata infrastructure. The shape determines the amount of CPU, storage, and memory resources allocated to the instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The time zone of the Exadata infrastructure. For details, see [Exadata Infrastructure Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The number of enabled CPU cores.
        /// </value>
        [JsonProperty(PropertyName = "cpusEnabled")]
        public System.Nullable<int> CpusEnabled { get; set; }
        
        /// <value>
        /// The total number of CPU cores available.
        /// </value>
        [JsonProperty(PropertyName = "maxCpuCount")]
        public System.Nullable<int> MaxCpuCount { get; set; }
        
        /// <value>
        /// The memory allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
        
        /// <value>
        /// The total memory available in GBs.
        /// </value>
        [JsonProperty(PropertyName = "maxMemoryInGBs")]
        public System.Nullable<int> MaxMemoryInGBs { get; set; }
        
        /// <value>
        /// The local node storage allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The total local node storage available in GBs.
        /// </value>
        [JsonProperty(PropertyName = "maxDbNodeStorageInGBs")]
        public System.Nullable<int> MaxDbNodeStorageInGBs { get; set; }
        
        /// <value>
        /// Size, in terabytes, of the DATA disk group.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Double DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The total available DATA disk group size.
        /// </value>
        [JsonProperty(PropertyName = "maxDataStorageInTBs")]
        public System.Double MaxDataStorageInTBs { get; set; }
        
        /// <value>
        /// The serial number for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "rackSerialNumber")]
        public string RackSerialNumber { get; set; }
        
        /// <value>
        /// The number of Exadata storage servers for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "storageCount")]
        public System.Nullable<int> StorageCount { get; set; }
        
        /// <value>
        /// The requested number of additional storage servers for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "additionalStorageCount")]
        public System.Nullable<int> AdditionalStorageCount { get; set; }
        
        /// <value>
        /// The requested number of additional storage servers activated for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "activatedStorageCount")]
        public System.Nullable<int> ActivatedStorageCount { get; set; }
        
        /// <value>
        /// The number of compute servers for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "computeCount")]
        public System.Nullable<int> ComputeCount { get; set; }
        
        /// <value>
        /// The requested number of additional compute servers for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "additionalComputeCount")]
        public System.Nullable<int> AdditionalComputeCount { get; set; }
                ///
        /// <value>
        /// Oracle Exadata System Model specification. The system model determines the amount of compute or storage
        /// server resources available for use. For more information, please see [System and Shape Configuration Options]
        /// (https://docs.oracle.com/en/engineered-systems/exadata-cloud-at-customer/ecccm/ecc-system-config-options.html#GUID-9E090174-5C57-4EB1-9243-B470F9F10D6B)
        /// 
        /// </value>
        ///
        public enum AdditionalComputeSystemModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "X7")]
            X7,
            [EnumMember(Value = "X8")]
            X8,
            [EnumMember(Value = "X8M")]
            X8M,
            [EnumMember(Value = "X9M")]
            X9M
        };

        /// <value>
        /// Oracle Exadata System Model specification. The system model determines the amount of compute or storage
        /// server resources available for use. For more information, please see [System and Shape Configuration Options]
        /// (https://docs.oracle.com/en/engineered-systems/exadata-cloud-at-customer/ecccm/ecc-system-config-options.html#GUID-9E090174-5C57-4EB1-9243-B470F9F10D6B)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalComputeSystemModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AdditionalComputeSystemModelEnum> AdditionalComputeSystemModel { get; set; }
        
        /// <value>
        /// The IP address for the first control plane server.
        /// </value>
        [JsonProperty(PropertyName = "cloudControlPlaneServer1")]
        public string CloudControlPlaneServer1 { get; set; }
        
        /// <value>
        /// The IP address for the second control plane server.
        /// </value>
        [JsonProperty(PropertyName = "cloudControlPlaneServer2")]
        public string CloudControlPlaneServer2 { get; set; }
        
        /// <value>
        /// The netmask for the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "netmask")]
        public string Netmask { get; set; }
        
        /// <value>
        /// The gateway for the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }
        
        /// <value>
        /// The CIDR block for the Exadata administration network.
        /// </value>
        [JsonProperty(PropertyName = "adminNetworkCIDR")]
        public string AdminNetworkCIDR { get; set; }
        
        /// <value>
        /// The CIDR block for the Exadata InfiniBand interconnect.
        /// </value>
        [JsonProperty(PropertyName = "infiniBandNetworkCIDR")]
        public string InfiniBandNetworkCIDR { get; set; }
        
        /// <value>
        /// The corporate network proxy for access to the control plane network.
        /// </value>
        [JsonProperty(PropertyName = "corporateProxy")]
        public string CorporateProxy { get; set; }
        
        /// <value>
        /// The list of DNS server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "dnsServer")]
        public System.Collections.Generic.List<string> DnsServer { get; set; }
        
        /// <value>
        /// The list of NTP server IP addresses. Maximum of 3 allowed.
        /// </value>
        [JsonProperty(PropertyName = "ntpServer")]
        public System.Collections.Generic.List<string> NtpServer { get; set; }
        
        /// <value>
        /// The date and time the Exadata infrastructure was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The CSI Number of the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "csiNumber")]
        public string CsiNumber { get; set; }
        
        /// <value>
        /// The list of contacts for the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "contacts")]
        public System.Collections.Generic.List<ExadataInfrastructureContact> Contacts { get; set; }
                ///
        /// <value>
        /// A field to capture \u2018Maintenance SLO Status\u2019 for the Exadata infrastructure with values \u2018OK\u2019, \u2018DEGRADED\u2019. Default is \u2018OK\u2019 when the infrastructure is provisioned.
        /// </value>
        ///
        public enum MaintenanceSLOStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "DEGRADED")]
            Degraded
        };

        /// <value>
        /// A field to capture \u2018Maintenance SLO Status\u2019 for the Exadata infrastructure with values \u2018OK\u2019, \u2018DEGRADED\u2019. Default is \u2018OK\u2019 when the infrastructure is provisioned.
        /// </value>
        [JsonProperty(PropertyName = "maintenanceSLOStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaintenanceSLOStatusEnum> MaintenanceSLOStatus { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindow")]
        public MaintenanceWindow MaintenanceWindow { get; set; }
        
        /// <value>
        /// The software version of the storage servers (cells) in the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "storageServerVersion")]
        public string StorageServerVersion { get; set; }
        
        /// <value>
        /// The software version of the database servers (dom0) in the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "dbServerVersion")]
        public string DbServerVersion { get; set; }
        
        /// <value>
        /// The monthly software version of the database servers (dom0) in the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "monthlyDbServerVersion")]
        public string MonthlyDbServerVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "lastMaintenanceRunId")]
        public string LastMaintenanceRunId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the next maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "nextMaintenanceRunId")]
        public string NextMaintenanceRunId { get; set; }
        
        /// <value>
        /// Indicates whether cps offline diagnostic report is enabled for this Exadata infrastructure. This will allow a customer to quickly check status themselves and fix problems on their end, saving time and frustration
        /// for both Oracle and the customer when they find the CPS in a disconnected state.You can enable offline diagnostic report during Exadata infrastructure provisioning. You can also disable or enable it at any time
        /// using the UpdateExadatainfrastructure API.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCpsOfflineReportEnabled")]
        public System.Nullable<bool> IsCpsOfflineReportEnabled { get; set; }
        
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
        
    }
}
