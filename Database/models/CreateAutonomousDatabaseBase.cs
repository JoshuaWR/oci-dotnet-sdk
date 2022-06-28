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
using Newtonsoft.Json.Linq;

namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details to create an Oracle Autonomous Database.
    /// <br/>
    /// **Notes:**
    /// - To specify OCPU core count, you must use either `ocpuCount` or `cpuCoreCount`. You cannot use both parameters at the same time.
    /// - To specify a storage allocation, you must use  either `dataStorageSizeInGBs` or `dataStorageSizeInTBs`.
    /// - See the individual parameter discriptions for more information on the OCPU and storage value parameters.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateAutonomousDatabaseBaseModelConverter))]
    public class CreateAutonomousDatabaseBase 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment of the Autonomous Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The character set for the autonomous database.  The default is AL32UTF8. Allowed values for an Autonomous Database on shared infrastructure as as returned by [List Autonomous Database Character Sets](https://docs.cloud.oracle.com/autonomousDatabaseCharacterSets)
        /// <br/>
        /// For an Autonomous Database on dedicated infrastructure, the allowed values are:
        /// <br/>
        /// AL32UTF8, AR8ADOS710, AR8ADOS720, AR8APTEC715, AR8ARABICMACS, AR8ASMO8X, AR8ISO8859P6, AR8MSWIN1256, AR8MUSSAD768, AR8NAFITHA711, AR8NAFITHA721, AR8SAKHR706, AR8SAKHR707, AZ8ISO8859P9E, BG8MSWIN, BG8PC437S, BLT8CP921, BLT8ISO8859P13, BLT8MSWIN1257, BLT8PC775, BN8BSCII, CDN8PC863, CEL8ISO8859P14, CL8ISO8859P5, CL8ISOIR111, CL8KOI8R, CL8KOI8U, CL8MACCYRILLICS, CL8MSWIN1251, EE8ISO8859P2, EE8MACCES, EE8MACCROATIANS, EE8MSWIN1250, EE8PC852, EL8DEC, EL8ISO8859P7, EL8MACGREEKS, EL8MSWIN1253, EL8PC437S, EL8PC851, EL8PC869, ET8MSWIN923, HU8ABMOD, HU8CWI2, IN8ISCII, IS8PC861, IW8ISO8859P8, IW8MACHEBREWS, IW8MSWIN1255, IW8PC1507, JA16EUC, JA16EUCTILDE, JA16SJIS, JA16SJISTILDE, JA16VMS, KO16KSC5601, KO16KSCCS, KO16MSWIN949, LA8ISO6937, LA8PASSPORT, LT8MSWIN921, LT8PC772, LT8PC774, LV8PC1117, LV8PC8LR, LV8RST104090, N8PC865, NE8ISO8859P10, NEE8ISO8859P4, RU8BESTA, RU8PC855, RU8PC866, SE8ISO8859P3, TH8MACTHAIS, TH8TISASCII, TR8DEC, TR8MACTURKISHS, TR8MSWIN1254, TR8PC857, US7ASCII, US8PC437, UTF8, VN8MSWIN1258, VN8VN3, WE8DEC, WE8DG, WE8ISO8859P1, WE8ISO8859P15, WE8ISO8859P9, WE8MACROMAN8S, WE8MSWIN1252, WE8NCR4970, WE8NEXTSTEP, WE8PC850, WE8PC858, WE8PC860, WE8ROMAN8, ZHS16CGB231280, ZHS16GBK, ZHT16BIG5, ZHT16CCDC, ZHT16DBT, ZHT16HKSCS, ZHT16MSWIN950, ZHT32EUC, ZHT32SOPS, ZHT32TRIS
        /// 
        /// </value>
        [JsonProperty(PropertyName = "characterSet")]
        public string CharacterSet { get; set; }
        
        /// <value>
        /// The character set for the Autonomous Database.  The default is AL32UTF8. Use [List Autonomous Database Character Sets](https://docs.cloud.oracle.com/autonomousDatabaseCharacterSets) to list the allowed values for an Autonomous Database on shared Exadata infrastructure.
        /// For an Autonomous Database on dedicated Exadata infrastructure, the allowed values are:
        /// AL16UTF16 or UTF8.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ncharacterSet")]
        public string NcharacterSet { get; set; }
        
        /// <value>
        /// The database name. The name must begin with an alphabetic character and can contain a maximum of 14 alphanumeric characters. Special characters are not permitted. The database name must be unique in the tenancy.
        /// </value>
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// The number of OCPU cores to be made available to the database. For Autonomous Databases on dedicated Exadata infrastructure, the maximum number of cores is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details. 
        /// <br/>
        /// **Note:** This parameter cannot be used with the `ocpuCount` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The number of OCPU cores to be made available to the database. 
        /// <br/>
        /// The following points apply:
        /// - For Autonomous Databases on dedicated Exadata infrastructure, to provision less than 1 core, enter a fractional value in an increment of 0.1. For example, you can provision 0.3 or 0.4 cores, but not 0.35 cores. (Note that fractional OCPU values are not supported for Autonomous Databasese on shared Exadata infrastructure.)
        /// - To provision 1 or more cores, you must enter an integer between 1 and the maximum number of cores available for the infrastructure shape. For example, you can provision 2 cores or 3 cores, but not 2.5 cores. This applies to Autonomous Databases on both shared and dedicated Exadata infrastructure.
        /// <br/>
        /// For Autonomous Databases on dedicated Exadata infrastructure, the maximum number of cores is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details.
        /// <br/>
        /// **Note:** This parameter cannot be used with the `cpuCoreCount` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpuCount")]
        public System.Nullable<float> OcpuCount { get; set; }
                ///
        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// - APEX - indicates an Autonomous Database with the Oracle APEX Application Development workload type.
        /// 
        /// </value>
        ///
        public enum DbWorkloadEnum {
            [EnumMember(Value = "OLTP")]
            Oltp,
            [EnumMember(Value = "DW")]
            Dw,
            [EnumMember(Value = "AJD")]
            Ajd,
            [EnumMember(Value = "APEX")]
            Apex
        };

        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// - APEX - indicates an Autonomous Database with the Oracle APEX Application Development workload type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbWorkload")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbWorkloadEnum> DbWorkload { get; set; }
        
        /// <value>
        /// The size, in terabytes, of the data volume that will be created and attached to the database. This storage can later be scaled up if needed. For Autonomous Databases on dedicated Exadata infrastructure, the maximum storage value is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details. 
        /// <br/>
        /// **Note:** This parameter cannot be used with the `dataStorageSizeInGBs` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Nullable<int> DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The size, in gigabytes, of the data volume that will be created and attached to the database. This storage can later be scaled up if needed. The maximum storage value is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details.
        /// <br/>
        /// **Notes** 
        /// - This parameter is only supported for dedicated Exadata infrastructure.
        /// - This parameter cannot be used with the `dataStorageSizeInTBs` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// Indicates if this is an Always Free resource. The default value is false. Note that Always Free Autonomous Databases have 1 CPU and 20GB of memory. For Always Free databases, memory and CPU cannot be scaled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFreeTier")]
        public System.Nullable<bool> IsFreeTier { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [vault](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts).
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// **Important** The `adminPassword` must be specified for all Autonomous Databases except for refreshable clones. The password must be between 12 and 30 characters long, and must contain at least 1 uppercase, 1 lowercase, and 1 numeric character. It cannot contain the double quote symbol (\") or the username \"admin\", regardless of casing.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }
        
        /// <value>
        /// The user-friendly name for the Autonomous Database. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
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
        /// If set to `TRUE`, indicates that an Autonomous Database preview version is being provisioned, and that the preview version's terms of service have been accepted. Note that preview version software is only available for databases on [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPreviewVersionWithServiceTermsAccepted")]
        public System.Nullable<bool> IsPreviewVersionWithServiceTermsAccepted { get; set; }
        
        /// <value>
        /// Indicates if auto scaling is enabled for the Autonomous Database OCPU core count. The default value is `FALSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
        
        /// <value>
        /// True if the database is on [dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDedicated")]
        public System.Nullable<bool> IsDedicated { get; set; }
        
        /// <value>
        /// The Autonomous Container Database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "autonomousContainerDatabaseId")]
        public string AutonomousContainerDatabaseId { get; set; }
        
        /// <value>
        /// Indicates if the database-level access control is enabled.
        /// If disabled, database access is defined by the network security rules.
        /// If enabled, database access is restricted to the IP addresses defined by the rules specified with the `whitelistedIps` property. While specifying `whitelistedIps` rules is optional,
        ///  if database-level access control is enabled and no rules are specified, the database will become inaccessible. The rules can be added later using the `UpdateAutonomousDatabase` API operation or edit option in console.
        /// When creating a database clone, the desired access control setting should be specified. By default, database-level access control will be disabled for the clone.
        /// <br/>
        /// This property is applicable only to Autonomous Databases on the Exadata Cloud@Customer platform.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAccessControlEnabled")]
        public System.Nullable<bool> IsAccessControlEnabled { get; set; }
        
        /// <value>
        /// The client IP access control list (ACL). This feature is available for autonomous databases on [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) and on Exadata Cloud@Customer.
        /// Only clients connecting from an IP address included in the ACL may access the Autonomous Database instance.
        /// <br/>
        /// For shared Exadata infrastructure, this is an array of CIDR (Classless Inter-Domain Routing) notations for a subnet or VCN OCID.
        /// Use a semicolon (;) as a deliminator between the VCN-specific subnets or IPs.
        /// Example: [&quot;1.1.1.1&quot;,&quot;1.1.1.0/24&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id>&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id1>;1.1.1.1&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id2>;1.1.0.0/16&quot;]For Exadata Cloud@Customer, this is an array of IP addresses or CIDR (Classless Inter-Domain Routing) notations.
        /// </value>
        [JsonProperty(PropertyName = "whitelistedIps")]
        public System.Collections.Generic.List<string> WhitelistedIps { get; set; }
        
        /// <value>
        /// This field will be null if the Autonomous Database is not Data Guard enabled or Access Control is disabled.
        /// It's value would be `TRUE` if Autonomous Database is Data Guard enabled and Access Control is enabled and if the Autonomous Database uses primary IP access control list (ACL) for standby.
        /// It's value would be `FALSE` if Autonomous Database is Data Guard enabled and Access Control is enabled and if the Autonomous Database uses different IP access control list (ACL) for standby compared to primary.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arePrimaryWhitelistedIpsUsed")]
        public System.Nullable<bool> ArePrimaryWhitelistedIpsUsed { get; set; }
        
        /// <value>
        /// The client IP access control list (ACL). This feature is available for autonomous databases on [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) and on Exadata Cloud@Customer.
        /// Only clients connecting from an IP address included in the ACL may access the Autonomous Database instance.
        /// <br/>
        /// For shared Exadata infrastructure, this is an array of CIDR (Classless Inter-Domain Routing) notations for a subnet or VCN OCID.
        /// Use a semicolon (;) as a deliminator between the VCN-specific subnets or IPs.
        /// Example: [&quot;1.1.1.1&quot;,&quot;1.1.1.0/24&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id>&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id1>;1.1.1.1&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id2>;1.1.0.0/16&quot;]For Exadata Cloud@Customer, this is an array of IP addresses or CIDR (Classless Inter-Domain Routing) notations.
        /// </value>
        [JsonProperty(PropertyName = "standbyWhitelistedIps")]
        public System.Collections.Generic.List<string> StandbyWhitelistedIps { get; set; }
        
        /// <value>
        /// **Deprecated.** Indicates whether the Autonomous Database has local (in-region) Data Guard enabled. Not applicable to cross-region Autonomous Data Guard associations, or to Autonomous Databases using dedicated Exadata infrastructure or Exadata Cloud@Customer infrastructure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDataGuardEnabled")]
        public System.Nullable<bool> IsDataGuardEnabled { get; set; }
        
        /// <value>
        /// Indicates whether the Autonomous Database has local (in-region) Data Guard enabled. Not applicable to cross-region Autonomous Data Guard associations, or to Autonomous Databases using dedicated Exadata infrastructure or Exadata Cloud@Customer infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "isLocalDataGuardEnabled")]
        public System.Nullable<bool> IsLocalDataGuardEnabled { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the resource is associated with.
        /// <br/>
        /// **Subnet Restrictions:**
        /// - For bare metal DB systems and for single node virtual machine DB systems, do not use a subnet that overlaps with 192.168.16.16/28.
        /// - For Exadata and virtual machine 2-node RAC systems, do not use a subnet that overlaps with 192.168.128.0/20.
        /// - For Autonomous Database, setting this will disable public secure access to the database.
        /// <br/>
        /// These subnets are used by the Oracle Clusterware private interconnect on the database instance.
        /// Specifying an overlapping subnet will cause the private interconnect to malfunction.
        /// This restriction applies to both the client subnet and the backup subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) for the network security groups (NSGs) to which this resource belongs. Setting this to an empty list removes all resources from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - A network security group (NSG) is optional for Autonomous Databases with private access. The nsgIds list can be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The private endpoint label for the resource. Setting this to an empty string, after the private endpoint database gets created, will change the same private endpoint database to the public endpoint database.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointLabel")]
        public string PrivateEndpointLabel { get; set; }
        
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
        /// A valid Oracle Database version for Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
                ///
        /// <value>
        /// The source of the database: Use `NONE` for creating a new Autonomous Database. Use `DATABASE` for creating a new Autonomous Database by cloning an existing Autonomous Database. Use `CROSS_REGION_DATAGUARD` to create a standby Data Guard database in another region.
        /// <br/>
        /// For Autonomous Databases on [shared Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), the following cloning options are available: Use `BACKUP_FROM_ID` for creating a new Autonomous Database from a specified backup. Use `BACKUP_FROM_TIMESTAMP` for creating a point-in-time Autonomous Database clone using backups. For more information, see [Cloning and Moving an Autonomous Database](https://docs.oracle.com/en/cloud/paas/autonomous-database/adbsa/clone-autonomous-database.html#GUID-D771796F-5081-4CFB-A7FF-0F893EABD7BC).
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "DATABASE")]
            Database,
            [EnumMember(Value = "BACKUP_FROM_ID")]
            BackupFromId,
            [EnumMember(Value = "BACKUP_FROM_TIMESTAMP")]
            BackupFromTimestamp,
            [EnumMember(Value = "CLONE_TO_REFRESHABLE")]
            CloneToRefreshable,
            [EnumMember(Value = "CROSS_REGION_DATAGUARD")]
            CrossRegionDataguard
        };

        
        /// <value>
        /// Customer Contacts.
        /// </value>
        [JsonProperty(PropertyName = "customerContacts")]
        public System.Collections.Generic.List<CustomerContact> CustomerContacts { get; set; }
        
        /// <value>
        /// Indicates whether the Autonomous Database requires mTLS connections.
        /// </value>
        [JsonProperty(PropertyName = "isMtlsConnectionRequired")]
        public System.Nullable<bool> IsMtlsConnectionRequired { get; set; }
                ///
        /// <value>
        /// The maintenance schedule type of the Autonomous Database on shared Exadata infrastructure. The EARLY maintenance schedule of this Autonomous Database
        /// follows a schedule that applies patches prior to the REGULAR schedule.The REGULAR maintenance schedule of this Autonomous Database follows the normal cycle.
        /// 
        /// </value>
        ///
        public enum AutonomousMaintenanceScheduleTypeEnum {
            [EnumMember(Value = "EARLY")]
            Early,
            [EnumMember(Value = "REGULAR")]
            Regular
        };

        /// <value>
        /// The maintenance schedule type of the Autonomous Database on shared Exadata infrastructure. The EARLY maintenance schedule of this Autonomous Database
        /// follows a schedule that applies patches prior to the REGULAR schedule.The REGULAR maintenance schedule of this Autonomous Database follows the normal cycle.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "autonomousMaintenanceScheduleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AutonomousMaintenanceScheduleTypeEnum> AutonomousMaintenanceScheduleType { get; set; }
        
        /// <value>
        /// list of scheduled operations
        /// </value>
        [JsonProperty(PropertyName = "scheduledOperations")]
        public System.Collections.Generic.List<ScheduledOperationDetails> ScheduledOperations { get; set; }
        
        /// <value>
        /// Indicates if auto scaling is enabled for the Autonomous Database storage. The default value is `FALSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingForStorageEnabled")]
        public System.Nullable<bool> IsAutoScalingForStorageEnabled { get; set; }
        
        /// <value>
        /// The number of Max OCPU cores to be made available to the autonomous database with auto scaling of cpu enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxCpuCoreCount")]
        public System.Nullable<int> MaxCpuCoreCount { get; set; }
        
        /// <value>
        /// The Oracle Database Edition that applies to the Autonomous databases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseEdition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AutonomousDatabaseSummary.DatabaseEditionEnum> DatabaseEdition { get; set; }
        
    }

    public class CreateAutonomousDatabaseBaseModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateAutonomousDatabaseBase);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateAutonomousDatabaseBase);
            var discriminator = jsonObject["source"].Value<string>();
            switch (discriminator)
            {
                case "DATABASE":
                    obj = new CreateAutonomousDatabaseCloneDetails();
                    break;
                case "CLONE_TO_REFRESHABLE":
                    obj = new CreateRefreshableAutonomousDatabaseCloneDetails();
                    break;
                case "BACKUP_FROM_ID":
                    obj = new CreateAutonomousDatabaseFromBackupDetails();
                    break;
                case "BACKUP_FROM_TIMESTAMP":
                    obj = new CreateAutonomousDatabaseFromBackupTimestampDetails();
                    break;
                case "CROSS_REGION_DATAGUARD":
                    obj = new CreateCrossRegionAutonomousDatabaseDataGuardDetails();
                    break;
                case "NONE":
                    obj = new CreateAutonomousDatabaseDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
