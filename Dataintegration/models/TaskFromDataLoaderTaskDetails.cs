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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about a data flow task.
    /// </summary>
    public class TaskFromDataLoaderTaskDetails : Task
    {
        
        [JsonProperty(PropertyName = "dataFlow")]
        public DataFlow DataFlow { get; set; }
        
        [JsonProperty(PropertyName = "conditionalCompositeFieldMap")]
        public ConditionalCompositeFieldMap ConditionalCompositeFieldMap { get; set; }
        
        /// <value>
        /// Defines whether Data Loader task is used for single load or multiple
        /// </value>
        [JsonProperty(PropertyName = "isSingleLoad")]
        public System.Nullable<bool> IsSingleLoad { get; set; }
        
        /// <value>
        /// Defines the number of entities being loaded in parallel at a time for a Data Loader task
        /// </value>
        [JsonProperty(PropertyName = "parallelLoadLimit")]
        public System.Nullable<int> ParallelLoadLimit { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "DATA_LOADER_TASK";
    }
}
