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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Response object for obtaining list of changed files.
    /// </summary>
    public class DiffResponse 
    {
        
        /// <value>
        /// Boolean value to indicate if all changes are included in the response.
        /// </value>
        [JsonProperty(PropertyName = "areAllChangesIncluded")]
        public System.Nullable<bool> AreAllChangesIncluded { get; set; }
        
        /// <value>
        /// Count of each type of change in difference.
        /// </value>
        [JsonProperty(PropertyName = "changeTypeCount")]
        public System.Collections.Generic.Dictionary<string, int> ChangeTypeCount { get; set; }
        
        /// <value>
        /// The ID of the common commit between source and target.
        /// </value>
        [JsonProperty(PropertyName = "commonCommit")]
        public string CommonCommit { get; set; }
        
        /// <value>
        /// The number of commits source is ahead of target by.
        /// </value>
        [JsonProperty(PropertyName = "commitsAheadCount")]
        public System.Nullable<int> CommitsAheadCount { get; set; }
        
        /// <value>
        /// The number of commits source is behind target by.
        /// </value>
        [JsonProperty(PropertyName = "commitsBehindCount")]
        public System.Nullable<int> CommitsBehindCount { get; set; }
        
        /// <value>
        /// The number of lines added in whole difference.
        /// </value>
        [JsonProperty(PropertyName = "addedLinesCount")]
        public System.Nullable<int> AddedLinesCount { get; set; }
        
        /// <value>
        /// The number of lines deleted in whole difference.
        /// </value>
        [JsonProperty(PropertyName = "deletedLinesCount")]
        public System.Nullable<int> DeletedLinesCount { get; set; }
        
        /// <value>
        /// List of changes in the difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Changes is required.")]
        [JsonProperty(PropertyName = "changes")]
        public System.Collections.Generic.List<DiffResponseEntry> Changes { get; set; }
        
    }
}
