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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of the cloud Exadata infrastructure resource. Applies to Exadata Cloud Service instances only.
    /// 
    /// </summary>
    public class CloudExadataInfrastructure 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud Exadata infrastructure resource.
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
        /// The current lifecycle state of the cloud Exadata infrastructure resource.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress
        };

        /// <value>
        /// The current lifecycle state of the cloud Exadata infrastructure resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The user-friendly name for the cloud Exadata infrastructure resource. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The model name of the cloud Exadata infrastructure resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The name of the availability domain that the cloud Exadata infrastructure resource is located in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The number of compute servers for the cloud Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "computeCount")]
        public System.Nullable<int> ComputeCount { get; set; }
        
        /// <value>
        /// The number of storage servers for the cloud Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "storageCount")]
        public System.Nullable<int> StorageCount { get; set; }
        
        /// <value>
        /// The total storage allocated to the cloud Exadata infrastructure resource, in gigabytes (GB).
        /// </value>
        [JsonProperty(PropertyName = "totalStorageSizeInGBs")]
        public System.Nullable<int> TotalStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The available storage can be allocated to the cloud Exadata infrastructure resource, in gigabytes (GB).
        /// </value>
        [JsonProperty(PropertyName = "availableStorageSizeInGBs")]
        public System.Nullable<int> AvailableStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The total number of CPU cores allocated.
        /// </value>
        [JsonProperty(PropertyName = "cpuCount")]
        public System.Nullable<int> CpuCount { get; set; }
        
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
        /// The date and time the cloud Exadata infrastructure resource was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindow")]
        public MaintenanceWindow MaintenanceWindow { get; set; }
        
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
        
        /// <value>
        /// The list of customer email addresses that receive information from Oracle about the specified OCI Database service resource.
        /// Oracle uses these email addresses to send notifications about planned and unplanned software maintenance updates, information about system hardware, and other information needed by administrators.
        /// Up to 10 email addresses can be added to the customer contacts for a cloud Exadata infrastructure instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerContacts")]
        public System.Collections.Generic.List<CustomerContact> CustomerContacts { get; set; }
        
        /// <value>
        /// The software version of the storage servers (cells) in the cloud Exadata infrastructure.
        /// Example: 20.1.15
        /// </value>
        [JsonProperty(PropertyName = "storageServerVersion")]
        public string StorageServerVersion { get; set; }
        
        /// <value>
        /// The software version of the database servers (dom0) in the cloud Exadata infrastructure.
        /// Example: 20.1.15
        /// </value>
        [JsonProperty(PropertyName = "dbServerVersion")]
        public string DbServerVersion { get; set; }
        
        /// <value>
        /// The monthly software version of the storage servers (cells) in the cloud Exadata infrastructure.
        /// Example: 20.1.15
        /// </value>
        [JsonProperty(PropertyName = "monthlyStorageServerVersion")]
        public string MonthlyStorageServerVersion { get; set; }
        
        /// <value>
        /// The monthly software version of the database servers (dom0) in the cloud Exadata infrastructure.
        /// Example: 20.1.15
        /// </value>
        [JsonProperty(PropertyName = "monthlyDbServerVersion")]
        public string MonthlyDbServerVersion { get; set; }
        
    }
}
