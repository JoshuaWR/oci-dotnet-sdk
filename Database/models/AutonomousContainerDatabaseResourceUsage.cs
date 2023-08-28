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
    /// Associated autonomous container databases usages.
    /// </summary>
    public class AutonomousContainerDatabaseResourceUsage 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user-friendly name for the Autonomous Container Database. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// CPUs / cores reclaimable or released to cluster on Autonomous Container Database restart.
        /// </value>
        [JsonProperty(PropertyName = "reclaimableCpus")]
        public System.Nullable<float> ReclaimableCpus { get; set; }
        
        /// <value>
        /// CPUs / cores available for ADB provisioning or scaling in the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "availableCpus")]
        public System.Nullable<float> AvailableCpus { get; set; }
        
        /// <value>
        /// Largest provisionable ADB in the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "largestProvisionableAutonomousDatabaseInCpus")]
        public System.Nullable<float> LargestProvisionableAutonomousDatabaseInCpus { get; set; }
        
        /// <value>
        /// CPUs / cores assigned to ADBs in the Autonomous Container Database.
        /// </value>
        [JsonProperty(PropertyName = "provisionedCpus")]
        public System.Nullable<float> ProvisionedCpus { get; set; }
        
        /// <value>
        /// CPUs / cores reserved for scalability, resilliency and other overheads.
        /// This includes failover, autoscaling and idle instance overhead.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reservedCpus")]
        public System.Nullable<float> ReservedCpus { get; set; }
        
        /// <value>
        /// CPUs / cores assigned to the Autonomous Container Database. Sum of provisioned,
        /// reserved and reclaimable CPUs/ cores.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "usedCpus")]
        public System.Nullable<float> UsedCpus { get; set; }
        
        /// <value>
        /// Valid list of provisionable CPUs / cores for ADB creation.
        /// </value>
        [JsonProperty(PropertyName = "provisionableCpus")]
        public System.Collections.Generic.List<float> ProvisionableCpus { get; set; }
        
        /// <value>
        /// List of autonomous container database resource usage per autonomous virtual machine.
        /// </value>
        [JsonProperty(PropertyName = "autonomousContainerDatabaseVmUsage")]
        public System.Collections.Generic.List<AcdAvmResourceStats> AutonomousContainerDatabaseVmUsage { get; set; }
        
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
