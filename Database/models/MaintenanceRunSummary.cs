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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details of a maintenance run.
    /// 
    /// </summary>
    public class MaintenanceRunSummary 
    {
        
        /// <value>
        /// The OCID of the maintenance run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The user-friendly name for the maintenance run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the maintenance run.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// The current state of the maintenance run. For Autonomous Database Serverless instances, valid states are IN_PROGRESS, SUCCEEDED, and FAILED.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SCHEDULED")]
            Scheduled,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "SKIPPED")]
            Skipped,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "CANCELED")]
            Canceled
        };

        /// <value>
        /// The current state of the maintenance run. For Autonomous Database Serverless instances, valid states are IN_PROGRESS, SUCCEEDED, and FAILED.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Additional information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The date and time the maintenance run is scheduled to occur.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeScheduled is required.")]
        [JsonProperty(PropertyName = "timeScheduled")]
        public System.Nullable<System.DateTime> TimeScheduled { get; set; }
        
        /// <value>
        /// The date and time the maintenance run starts.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The date and time the maintenance run was completed.
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
                ///
        /// <value>
        /// The type of the target resource on which the maintenance run occurs.
        /// </value>
        ///
        public enum TargetResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AUTONOMOUS_EXADATA_INFRASTRUCTURE")]
            AutonomousExadataInfrastructure,
            [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE")]
            AutonomousContainerDatabase,
            [EnumMember(Value = "EXADATA_DB_SYSTEM")]
            ExadataDbSystem,
            [EnumMember(Value = "CLOUD_EXADATA_INFRASTRUCTURE")]
            CloudExadataInfrastructure,
            [EnumMember(Value = "EXACC_INFRASTRUCTURE")]
            ExaccInfrastructure,
            [EnumMember(Value = "AUTONOMOUS_VM_CLUSTER")]
            AutonomousVmCluster,
            [EnumMember(Value = "AUTONOMOUS_DATABASE")]
            AutonomousDatabase,
            [EnumMember(Value = "CLOUD_AUTONOMOUS_VM_CLUSTER")]
            CloudAutonomousVmCluster
        };

        /// <value>
        /// The type of the target resource on which the maintenance run occurs.
        /// </value>
        [JsonProperty(PropertyName = "targetResourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TargetResourceTypeEnum> TargetResourceType { get; set; }
        
        /// <value>
        /// The ID of the target resource on which the maintenance run occurs.
        /// </value>
        [JsonProperty(PropertyName = "targetResourceId")]
        public string TargetResourceId { get; set; }
                ///
        /// <value>
        /// Maintenance type.
        /// </value>
        ///
        public enum MaintenanceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PLANNED")]
            Planned,
            [EnumMember(Value = "UNPLANNED")]
            Unplanned
        };

        /// <value>
        /// Maintenance type.
        /// </value>
        [JsonProperty(PropertyName = "maintenanceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaintenanceTypeEnum> MaintenanceType { get; set; }
        
        /// <value>
        /// The unique identifier of the patch. The identifier string includes the patch type, the Oracle Database version, and the patch creation date (using the format YYMMDD). For example, the identifier `ru_patch_19.9.0.0_201030` is used for an RU patch for Oracle Database 19.9.0.0 that was released October 30, 2020.
        /// </value>
        [JsonProperty(PropertyName = "patchId")]
        public string PatchId { get; set; }
                ///
        /// <value>
        /// Maintenance sub-type.
        /// </value>
        ///
        public enum MaintenanceSubtypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "QUARTERLY")]
            Quarterly,
            [EnumMember(Value = "HARDWARE")]
            Hardware,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "INFRASTRUCTURE")]
            Infrastructure,
            [EnumMember(Value = "DATABASE")]
            Database,
            [EnumMember(Value = "ONEOFF")]
            Oneoff,
            [EnumMember(Value = "SECURITY_MONTHLY")]
            SecurityMonthly,
            [EnumMember(Value = "TIMEZONE")]
            Timezone,
            [EnumMember(Value = "CUSTOM_DATABASE_SOFTWARE_IMAGE")]
            CustomDatabaseSoftwareImage
        };

        /// <value>
        /// Maintenance sub-type.
        /// </value>
        [JsonProperty(PropertyName = "maintenanceSubtype")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MaintenanceSubtypeEnum> MaintenanceSubtype { get; set; }
        
        /// <value>
        /// Indicates if an automatic DST Time Zone file update is enabled for the Autonomous Container Database. If enabled along with Release Update, patching will be done in a Non-Rolling manner.
        /// </value>
        [JsonProperty(PropertyName = "isDstFileUpdateEnabled")]
        public System.Nullable<bool> IsDstFileUpdateEnabled { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the maintenance run for the Autonomous Data Guard association's peer container database.
        /// </value>
        [JsonProperty(PropertyName = "peerMaintenanceRunId")]
        public string PeerMaintenanceRunId { get; set; }
                ///
        /// <value>
        /// Cloud Exadata infrastructure node patching method, either \"ROLLING\" or \"NONROLLING\". Default value is ROLLING.
        /// <br/>
        /// *IMPORTANT*: Non-rolling infrastructure patching involves system down time. See [Oracle-Managed Infrastructure Maintenance Updates](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/examaintenance.htm#Oracle) for more information.
        /// 
        /// </value>
        ///
        public enum PatchingModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ROLLING")]
            Rolling,
            [EnumMember(Value = "NONROLLING")]
            Nonrolling
        };

        /// <value>
        /// Cloud Exadata infrastructure node patching method, either \"ROLLING\" or \"NONROLLING\". Default value is ROLLING.
        /// <br/>
        /// *IMPORTANT*: Non-rolling infrastructure patching involves system down time. See [Oracle-Managed Infrastructure Maintenance Updates](https://docs.cloud.oracle.com/iaas/Content/Database/Concepts/examaintenance.htm#Oracle) for more information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "patchingMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchingModeEnum> PatchingMode { get; set; }
        
        /// <value>
        /// Contain the patch failure count.
        /// </value>
        [JsonProperty(PropertyName = "patchFailureCount")]
        public System.Nullable<int> PatchFailureCount { get; set; }
        
        /// <value>
        /// The target software version for the database server patching operation.
        /// </value>
        [JsonProperty(PropertyName = "targetDbServerVersion")]
        public string TargetDbServerVersion { get; set; }
        
        /// <value>
        /// The target Cell version that is to be patched to.
        /// </value>
        [JsonProperty(PropertyName = "targetStorageServerVersion")]
        public string TargetStorageServerVersion { get; set; }
        
        /// <value>
        /// If true, enables the configuration of a custom action timeout (waiting period) between database servers patching operations.
        /// </value>
        [JsonProperty(PropertyName = "isCustomActionTimeoutEnabled")]
        public System.Nullable<bool> IsCustomActionTimeoutEnabled { get; set; }
        
        /// <value>
        /// Determines the amount of time the system will wait before the start of each database server patching operation.
        /// Specify a number of minutes, from 15 to 120.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customActionTimeoutInMins")]
        public System.Nullable<int> CustomActionTimeoutInMins { get; set; }
        
        /// <value>
        /// Extend current custom action timeout between the current database servers during waiting state, from 0 (zero) to 30 minutes.
        /// </value>
        [JsonProperty(PropertyName = "currentCustomActionTimeoutInMins")]
        public System.Nullable<int> CurrentCustomActionTimeoutInMins { get; set; }
                ///
        /// <value>
        /// The status of the patching operation.
        /// </value>
        ///
        public enum PatchingStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PATCHING")]
            Patching,
            [EnumMember(Value = "WAITING")]
            Waiting,
            [EnumMember(Value = "SCHEDULED")]
            Scheduled
        };

        /// <value>
        /// The status of the patching operation.
        /// </value>
        [JsonProperty(PropertyName = "patchingStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchingStatusEnum> PatchingStatus { get; set; }
        
        /// <value>
        /// The time when the patching operation started.
        /// </value>
        [JsonProperty(PropertyName = "patchingStartTime")]
        public System.Nullable<System.DateTime> PatchingStartTime { get; set; }
        
        /// <value>
        /// The time when the patching operation ended.
        /// </value>
        [JsonProperty(PropertyName = "patchingEndTime")]
        public System.Nullable<System.DateTime> PatchingEndTime { get; set; }
        
        [JsonProperty(PropertyName = "estimatedPatchingTime")]
        public EstimatedPatchingTime EstimatedPatchingTime { get; set; }
        
        /// <value>
        /// The name of the current infrastruture component that is getting patched.
        /// </value>
        [JsonProperty(PropertyName = "currentPatchingComponent")]
        public string CurrentPatchingComponent { get; set; }
        
        /// <value>
        /// The estimated start time of the next infrastruture component patching operation.
        /// </value>
        [JsonProperty(PropertyName = "estimatedComponentPatchingStartTime")]
        public System.Nullable<System.DateTime> EstimatedComponentPatchingStartTime { get; set; }
        
        /// <value>
        /// If `FALSE`, the maintenance run doesn't support granular maintenance.
        /// </value>
        [JsonProperty(PropertyName = "isMaintenanceRunGranular")]
        public System.Nullable<bool> IsMaintenanceRunGranular { get; set; }
        
        /// <value>
        /// The total time taken by corresponding resource activity in minutes.
        /// </value>
        [JsonProperty(PropertyName = "totalTimeTakenInMins")]
        public System.Nullable<int> TotalTimeTakenInMins { get; set; }
        
        /// <value>
        /// The Autonomous Database Software Image [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// </value>
        [JsonProperty(PropertyName = "databaseSoftwareImageId")]
        public string DatabaseSoftwareImageId { get; set; }
        
    }
}
