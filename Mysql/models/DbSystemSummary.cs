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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// A summary of a DB System.
    /// 
    /// </summary>
    public class DbSystemSummary 
    {
        
        /// <value>
        /// The OCID of the DB System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user-friendly name for the DB System. It does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// User-provided data about the DB System.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The OCID of the compartment the DB System belongs in.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// If the policy is to enable high availability of the instance, by
        /// maintaining secondary/failover capacity as necessary.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHighlyAvailable")]
        public System.Nullable<bool> IsHighlyAvailable { get; set; }
        
        [JsonProperty(PropertyName = "currentPlacement")]
        public DbSystemPlacement CurrentPlacement { get; set; }
        
        /// <value>
        /// DEPRECATED -- please use `isHeatWaveClusterAttached` instead.
        /// If the DB System has an Analytics Cluster attached.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAnalyticsClusterAttached")]
        public System.Nullable<bool> IsAnalyticsClusterAttached { get; set; }
        
        [JsonProperty(PropertyName = "analyticsCluster")]
        public AnalyticsClusterSummary AnalyticsCluster { get; set; }
        
        /// <value>
        /// If the DB System has a HeatWave Cluster attached.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHeatWaveClusterAttached")]
        public System.Nullable<bool> IsHeatWaveClusterAttached { get; set; }
        
        [JsonProperty(PropertyName = "heatWaveCluster")]
        public HeatWaveClusterSummary HeatWaveCluster { get; set; }
        
        /// <value>
        /// The availability domain on which to deploy the Read/Write endpoint. This defines the preferred primary instance.
        /// <br/>
        /// In a failover scenario, the Read/Write endpoint is redirected to one of the other availability domains
        /// and the MySQL instance in that domain is promoted to the primary instance.
        /// This redirection does not affect the IP address of the DB System in any way.
        /// <br/>
        /// For a standalone DB System, this defines the availability domain in which the DB System is placed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The fault domain on which to deploy the Read/Write endpoint. This defines the preferred primary instance.
        /// <br/>
        /// In a failover scenario, the Read/Write endpoint is redirected to one of the other fault domains
        /// and the MySQL instance in that domain is promoted to the primary instance.
        /// This redirection does not affect the IP address of the DB System in any way.
        /// <br/>
        /// For a standalone DB System, this defines the fault domain in which the DB System is placed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The network endpoints available for this DB System.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpoints")]
        public System.Collections.Generic.List<DbSystemEndpoint> Endpoints { get; set; }
        
        /// <value>
        /// The current state of the DB System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbSystem.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Name of the MySQL Version in use for the DB System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MysqlVersion is required.")]
        [JsonProperty(PropertyName = "mysqlVersion")]
        public string MysqlVersion { get; set; }
        
        /// <value>
        /// The date and time the DB System was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the DB System was last updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Whether to run the DB System with InnoDB Redo Logs and the Double Write Buffer enabled or disabled,
        /// and whether to enable or disable syncing of the Binary Logs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "crashRecovery")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CrashRecoveryStatus> CrashRecovery { get; set; }
        
    }
}
