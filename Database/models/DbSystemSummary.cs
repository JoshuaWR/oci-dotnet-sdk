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
    /// The Database Service supports several types of DB systems, ranging in size, price, and performance. For details about
    /// each type of system, see [Bare Metal and Virtual Machine DB Systems](https://docs.cloud.oracle.com/Content/Database/Concepts/overview.htm).
    /// <br/>
    /// **Note:** Deprecated for Exadata Cloud Service instances using the new [resource model](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/exaflexsystem.htm#exaflexsystem_topic-resource_model).
    /// To provision and manage new Exadata Cloud Service systems, use the
    /// {@link CloudExadataInfrastructure} and {@link CloudVmCluster}.
    /// See [Exadata Cloud Service](https://docs.cloud.oracle.com/Content/Database/Concepts/exaoverview.htm) for more information on Exadata systems.
    /// <br/>
    /// For Exadata Cloud Service instances, support for this API will end on May 15th, 2021. See [Switching an Exadata DB System to the New Resource Model and APIs](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/exaflexsystem_topic-resource_model_conversion.htm) for details on converting existing Exadata DB systems to the new resource model.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized, talk to an administrator. If you are an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// For information about access control and compartments, see
    /// [Overview of the Identity Service](https://docs.cloud.oracle.com/Content/Identity/Concepts/overview.htm).
    /// <br/>
    /// For information about availability domains, see
    /// [Regions and Availability Domains](https://docs.cloud.oracle.com/Content/General/Concepts/regions.htm).
    /// <br/>
    /// To get a list of availability domains, use the `ListAvailabilityDomains` operation
    /// in the Identity Service API.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class DbSystemSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DB system.
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
        /// The user-friendly name for the DB system. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The name of the availability domain that the DB system is located in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// List of the Fault Domains in which this DB system is provisioned.
        /// </value>
        [JsonProperty(PropertyName = "faultDomains")]
        public System.Collections.Generic.List<string> FaultDomains { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the DB system is associated with.
        /// <br/>
        /// **Subnet Restrictions:**
        /// - For bare metal DB systems and for single node virtual machine DB systems, do not use a subnet that overlaps with 192.168.16.16/28.
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the backup network subnet the DB system is associated with. Applicable only to Exadata DB systems.
        /// <br/>
        /// **Subnet Restriction:** See the subnet restrictions information for **subnetId**.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupSubnetId")]
        public string BackupSubnetId { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) for the network security groups (NSGs) to which this resource belongs. Setting this to an empty list removes all resources from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - A network security group (NSG) is optional for Autonomous Databases with private access. The nsgIds list can be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that the backup network of this DB system belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm). Applicable only to Exadata systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupNetworkNsgIds")]
        public System.Collections.Generic.List<string> BackupNetworkNsgIds { get; set; }
        
        /// <value>
        /// Memory allocated to the DB system, in gigabytes.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
                ///
        /// <value>
        /// The block storage volume performance level. Valid values are `BALANCED` and `HIGH_PERFORMANCE`. See [Block Volume Performance](https://docs.cloud.oracle.com/Content/Block/Concepts/blockvolumeperformance.htm) for more information.
        /// 
        /// </value>
        ///
        public enum StorageVolumePerformanceModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "BALANCED")]
            Balanced,
            [EnumMember(Value = "HIGH_PERFORMANCE")]
            HighPerformance
        };

        /// <value>
        /// The block storage volume performance level. Valid values are `BALANCED` and `HIGH_PERFORMANCE`. See [Block Volume Performance](https://docs.cloud.oracle.com/Content/Block/Concepts/blockvolumeperformance.htm) for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "storageVolumePerformanceMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StorageVolumePerformanceModeEnum> StorageVolumePerformanceMode { get; set; }
        
        /// <value>
        /// The shape of the DB system. The shape determines resources to allocate to the DB system.
        /// - For virtual machine shapes, the number of CPU cores and memory
        /// - For bare metal and Exadata shapes, the number of CPU cores, storage, and memory
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        [JsonProperty(PropertyName = "dbSystemOptions")]
        public DbSystemOptions DbSystemOptions { get; set; }
        
        /// <value>
        /// The public key portion of one or more key pairs used for SSH access to the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SshPublicKeys is required.")]
        [JsonProperty(PropertyName = "sshPublicKeys")]
        public System.Collections.Generic.List<string> SshPublicKeys { get; set; }
        
        /// <value>
        /// The time zone of the DB system. For details, see [DB System Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }
        
        /// <value>
        /// The hostname for the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Hostname is required.")]
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }
        
        /// <value>
        /// The domain name for the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Domain is required.")]
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The Oracle Database version of the DB system.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The number of CPU cores enabled on the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The cluster name for Exadata and 2-node RAC virtual machine DB systems. The cluster name must begin with an alphabetic character, and may contain hyphens (-). Underscores (_) are not permitted. The cluster name can be no longer than 11 characters and is not case sensitive.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "clusterName")]
        public string ClusterName { get; set; }
        
        /// <value>
        /// The percentage assigned to DATA storage (user data and database files).
        /// The remaining percentage is assigned to RECO storage (database redo logs, archive logs, and recovery manager backups). Accepted values are 40 and 80. The default is 80 percent assigned to DATA storage. Not applicable for virtual machine DB systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStoragePercentage")]
        public System.Nullable<int> DataStoragePercentage { get; set; }
                ///
        /// <value>
        /// The Oracle Database edition that applies to all the databases on the DB system.
        /// 
        /// </value>
        ///
        public enum DatabaseEditionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STANDARD_EDITION")]
            StandardEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION")]
            EnterpriseEdition,
            [EnumMember(Value = "ENTERPRISE_EDITION_HIGH_PERFORMANCE")]
            EnterpriseEditionHighPerformance,
            [EnumMember(Value = "ENTERPRISE_EDITION_EXTREME_PERFORMANCE")]
            EnterpriseEditionExtremePerformance
        };

        /// <value>
        /// The Oracle Database edition that applies to all the databases on the DB system.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseEdition is required.")]
        [JsonProperty(PropertyName = "databaseEdition")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseEditionEnum> DatabaseEdition { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the last patch history. This value is updated as soon as a patch operation starts.
        /// </value>
        [JsonProperty(PropertyName = "lastPatchHistoryEntryId")]
        public string LastPatchHistoryEntryId { get; set; }
        
        /// <value>
        /// The port number configured for the listener on the DB system.
        /// </value>
        [JsonProperty(PropertyName = "listenerPort")]
        public System.Nullable<int> ListenerPort { get; set; }
                ///
        /// <value>
        /// The current state of the DB system.
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
            [EnumMember(Value = "MIGRATED")]
            Migrated,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "NEEDS_ATTENTION")]
            NeedsAttention,
            [EnumMember(Value = "UPGRADING")]
            Upgrading
        };

        /// <value>
        /// The current state of the DB system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time the DB system was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
                ///
        /// <value>
        /// The type of redundancy configured for the DB system.
        /// NORMAL is 2-way redundancy.
        /// HIGH is 3-way redundancy.
        /// 
        /// </value>
        ///
        public enum DiskRedundancyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HIGH")]
            High,
            [EnumMember(Value = "NORMAL")]
            Normal
        };

        /// <value>
        /// The type of redundancy configured for the DB system.
        /// NORMAL is 2-way redundancy.
        /// HIGH is 3-way redundancy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "diskRedundancy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DiskRedundancyEnum> DiskRedundancy { get; set; }
        
        /// <value>
        /// True, if Sparse Diskgroup is configured for Exadata dbsystem, False, if Sparse diskgroup was not configured.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sparseDiskgroup")]
        public System.Nullable<bool> SparseDiskgroup { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Single Client Access Name (SCAN) IP addresses associated with the DB system.
        /// SCAN IP addresses are typically used for load balancing and are not assigned to any interface.
        /// Oracle Clusterware directs the requests to the appropriate nodes in the cluster.
        /// <br/>
        /// **Note:** For a single-node DB system, this list is empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanIpIds")]
        public System.Collections.Generic.List<string> ScanIpIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the virtual IP (VIP) addresses associated with the DB system.
        /// The Cluster Ready Services (CRS) creates and maintains one VIP address for each node in the DB system to
        /// enable failover. If one node fails, the VIP is reassigned to another active node in the cluster.
        /// <br/>
        /// **Note:** For a single-node DB system, this list is empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vipIds")]
        public System.Collections.Generic.List<string> VipIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DNS record for the SCAN IP addresses that are associated with the DB system.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanDnsRecordId")]
        public string ScanDnsRecordId { get; set; }
        
        /// <value>
        /// The FQDN of the DNS record for the SCAN IP addresses that are associated with the DB system.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scanDnsName")]
        public string ScanDnsName { get; set; }
        
        /// <value>
        /// The OCID of the zone the DB system is associated with.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "zoneId")]
        public string ZoneId { get; set; }
        
        /// <value>
        /// The data storage size, in gigabytes, that is currently available to the DB system. Applies only for virtual machine DB systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The RECO/REDO storage size, in gigabytes, that is currently allocated to the DB system. Applies only for virtual machine DB systems.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recoStorageSizeInGB")]
        public System.Nullable<int> RecoStorageSizeInGB { get; set; }
        
        /// <value>
        /// The number of nodes in the DB system. For RAC DB systems, the value is greater than 1.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to all the databases on the DB system. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to all the databases on the DB system. The default is LICENSE_INCLUDED.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
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
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DB system.
        /// </value>
        [JsonProperty(PropertyName = "sourceDbSystemId")]
        public string SourceDbSystemId { get; set; }
        
        /// <value>
        /// The point in time for a cloned database system when the data disks were cloned from the source database system, as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "pointInTimeDataDiskCloneTimestamp")]
        public System.Nullable<System.DateTime> PointInTimeDataDiskCloneTimestamp { get; set; }
        
        [JsonProperty(PropertyName = "dataCollectionOptions")]
        public DataCollectionOptions DataCollectionOptions { get; set; }
        
    }
}
