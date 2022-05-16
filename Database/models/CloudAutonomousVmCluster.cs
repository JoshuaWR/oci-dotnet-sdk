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
    /// Details of the cloud Autonomous VM cluster.
    /// 
    /// </summary>
    public class CloudAutonomousVmCluster 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Cloud Autonomous VM cluster.
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
        
        /// <value>
        /// User defined description of the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The name of the availability domain that the cloud Autonomous VM cluster is located in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the cloud Autonomous VM Cluster is associated with.
        /// <br/>
        /// **Subnet Restrictions:**
        /// - For Exadata and virtual machine 2-node RAC DB systems, do not use a subnet that overlaps with 192.168.128.0/20.
        /// <br/>
        /// These subnets are used by the Oracle Clusterware private interconnect on the database instance.
        /// Specifying an overlapping subnet will cause the private interconnect to malfunction.
        /// This restriction applies to both the client subnet and backup subnet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) for the network security groups (NSGs) to which this resource belongs. Setting this to an empty list removes all resources from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - Autonomous Databases with private access require at least 1 Network Security Group (NSG). The nsgIds list cannot be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last maintenance update history. This value is updated when a maintenance update starts.
        /// </value>
        [JsonProperty(PropertyName = "lastUpdateHistoryEntryId")]
        public string LastUpdateHistoryEntryId { get; set; }
                ///
        /// <value>
        /// The current state of the cloud Autonomous VM cluster.
        /// </value>
        ///
        public enum LifecycleStateEnum {
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
        /// The current state of the cloud Autonomous VM cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The user-friendly name for the cloud Autonomous VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The date and time that the cloud Autonomous VM cluster was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last date and time that the cloud Autonomous VM cluster was updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The hostname for the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The domain name for the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "cloudExadataInfrastructureId")]
        public string CloudExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The model name of the Exadata hardware running the cloud Autonomous VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The number of database servers in the cloud VM cluster.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
        
        /// <value>
        /// The total data storage allocated, in terabytes (TB).
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Double DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The total data storage allocated, in gigabytes (GB).
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Double DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled on the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled on the cloud Autonomous VM cluster. Only 1 decimal place is allowed for the fractional part.
        /// </value>
        [JsonProperty(PropertyName = "ocpuCount")]
        public System.Nullable<float> OcpuCount { get; set; }
        
        /// <value>
        /// The memory allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle PaaS and IaaS services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Database service.
        /// Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
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
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle PaaS and IaaS services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Database service.
        /// Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
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
        /// CPU cores available for allocation to Autonomous Databases.
        /// </value>
        [JsonProperty(PropertyName = "availableCpus")]
        public System.Nullable<float> AvailableCpus { get; set; }
        
        /// <value>
        /// CPU cores that are not released to available pool after an Autonomous Database is terminated (Requires Autonomous Container Database restart).
        /// </value>
        [JsonProperty(PropertyName = "reclaimableCpus")]
        public System.Nullable<float> ReclaimableCpus { get; set; }
        
        /// <value>
        /// The number of Autonomous Container Databases that can be created with the currently available local storage.
        /// </value>
        [JsonProperty(PropertyName = "availableContainerDatabases")]
        public System.Nullable<int> AvailableContainerDatabases { get; set; }
        
        /// <value>
        /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
        /// </value>
        [JsonProperty(PropertyName = "totalContainerDatabases")]
        public System.Nullable<int> TotalContainerDatabases { get; set; }
        
        /// <value>
        /// The data disk group size available for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "availableAutonomousDataStorageSizeInTBs")]
        public System.Double AvailableAutonomousDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The data disk group size allocated for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "autonomousDataStorageSizeInTBs")]
        public System.Double AutonomousDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The local node storage allocated in GBs.
        /// </value>
        [JsonProperty(PropertyName = "dbNodeStorageSizeInGBs")]
        public System.Nullable<int> DbNodeStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The amount of memory (in GBs) enabled per each OCPU core.
        /// </value>
        [JsonProperty(PropertyName = "memoryPerOracleComputeUnitInGBs")]
        public System.Nullable<int> MemoryPerOracleComputeUnitInGBs { get; set; }
        
    }
}
