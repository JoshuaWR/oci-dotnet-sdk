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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Response object for showing differences for a file between two revisions.
    /// </summary>
    public class DiffSummary 
    {
        
        /// <value>
        /// The path on the base version to the changed object.
        /// </value>
        [JsonProperty(PropertyName = "oldPath")]
        public string OldPath { get; set; }
        
        /// <value>
        /// The path on the target version to the changed object.
        /// </value>
        [JsonProperty(PropertyName = "newPath")]
        public string NewPath { get; set; }
        
        /// <value>
        /// The ID of the changed object on the base version.
        /// </value>
        [JsonProperty(PropertyName = "oldId")]
        public string OldId { get; set; }
        
        /// <value>
        /// The ID of the changed object on the target version.
        /// </value>
        [JsonProperty(PropertyName = "newId")]
        public string NewId { get; set; }
        
        /// <value>
        /// Indicates whether the changed file contains conflicts.
        /// </value>
        [JsonProperty(PropertyName = "areConflictsInFile")]
        public System.Nullable<bool> AreConflictsInFile { get; set; }
        
        /// <value>
        /// Indicates whether the file is large.
        /// </value>
        [JsonProperty(PropertyName = "isLarge")]
        public System.Nullable<bool> IsLarge { get; set; }
        
        /// <value>
        /// Indicates whether the file is binary.
        /// </value>
        [JsonProperty(PropertyName = "isBinary")]
        public System.Nullable<bool> IsBinary { get; set; }
        
        /// <value>
        /// List of changed section in the file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Changes is required.")]
        [JsonProperty(PropertyName = "changes")]
        public System.Collections.Generic.List<DiffChunk> Changes { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
