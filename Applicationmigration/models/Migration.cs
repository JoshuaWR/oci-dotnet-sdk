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


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// The properties that define a migration. A migration represents the end-to-end workflow of moving an application from a source
    /// environment to Oracle Cloud Infrastructure. Each migration moves a single application to Oracle Cloud Infrastructure.
    /// For more information, see [Manage Migrations](https://docs.cloud.oracle.com/iaas/application-migration/manage_migrations.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized, talk to an administrator.
    /// If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class Migration 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the migration.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment that contains the migration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// User-friendly name of the migration.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the migration.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The date and time at which the migration was created, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the source with which this migration is associated.
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
        
        /// <value>
        /// Name of the application which is being migrated. This is the name of the application in the source environment.
        /// </value>
        [JsonProperty(PropertyName = "applicationName")]
        public string ApplicationName { get; set; }
        
        /// <value>
        /// The type of application being migrated.
        /// </value>
        [JsonProperty(PropertyName = "applicationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MigrationTypes> ApplicationType { get; set; }
        
        /// <value>
        /// The pre-existing database type to be used in this migration. Currently, Application migration only supports Oracle Cloud
        /// Infrastructure databases and this option is currently available only for `JAVA_CLOUD_SERVICE` and `WEBLOGIC_CLOUD_SERVICE` target instance types.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "preCreatedTargetDatabaseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TargetDatabaseTypes> PreCreatedTargetDatabaseType { get; set; }
        
        /// <value>
        /// If set to `true`, Application Migration migrates only the application resources that you specify. If set to `false`, Application Migration migrates the entire application. When you migrate the entire application, all the application resources are migrated to the target environment. You can selectively migrate resources only for the Oracle Integration Cloud and Oracle Integration Cloud Service applications.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSelectiveMigration")]
        public System.Nullable<bool> IsSelectiveMigration { get; set; }
        
        /// <value>
        /// Configuration required to migrate the application. In addition to the key and value, additional fields are provided
        /// to describe type type and purpose of each field. Only the value for each key is required when passing configuration to the 
        /// CreateMigration operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serviceConfig")]
        public System.Collections.Generic.Dictionary<string, ConfigurationField> ServiceConfig { get; set; }
        
        /// <value>
        /// Configuration required to migrate the application. In addition to the key and value, additional fields are provided
        /// to describe type type and purpose of each field. Only the value for each key is required when passing configuration to the 
        /// CreateMigration operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applicationConfig")]
        public System.Collections.Generic.Dictionary<string, ConfigurationField> ApplicationConfig { get; set; }
        
        /// <value>
        /// The current state of the migration.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MigrationLifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the current lifecycle state of the migration.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The current state of the overall migration process.
        /// </value>
        [JsonProperty(PropertyName = "migrationState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MigrationStates> MigrationState { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
