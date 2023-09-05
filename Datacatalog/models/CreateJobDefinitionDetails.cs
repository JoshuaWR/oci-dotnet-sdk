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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Representation of a job definition Resource. Job definitions define the harvest scope and includes the list of
    /// objects to be harvested along with a schedule. The list of objects is usually specified through a combination of
    /// object type, regular expressions, or specific names of objects and a sample size for the data harvested.
    /// 
    /// </summary>
    public class CreateJobDefinitionDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Detailed description of the job definition.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Type of the job definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobType is required.")]
        [JsonProperty(PropertyName = "jobType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JobType> JobType { get; set; }
        
        /// <value>
        /// Specifies if the job definition is incremental or full.
        /// </value>
        [JsonProperty(PropertyName = "isIncremental")]
        public System.Nullable<bool> IsIncremental { get; set; }
        
        /// <value>
        /// The key of the data asset for which the job is defined.
        /// </value>
        [JsonProperty(PropertyName = "dataAssetKey")]
        public string DataAssetKey { get; set; }
        
        /// <value>
        /// Unique key of the glossary to which this job applies.
        /// </value>
        [JsonProperty(PropertyName = "glossaryKey")]
        public string GlossaryKey { get; set; }
        
        /// <value>
        /// The key of the connection resource to be used for the job.
        /// </value>
        [JsonProperty(PropertyName = "connectionKey")]
        public string ConnectionKey { get; set; }
        
        /// <value>
        /// Specify if sample data to be extracted as part of this harvest.
        /// </value>
        [JsonProperty(PropertyName = "isSampleDataExtracted")]
        public System.Nullable<bool> IsSampleDataExtracted { get; set; }
        
        /// <value>
        /// Specify the sample data size in MB, specified as number of rows, for this metadata harvest.
        /// </value>
        [JsonProperty(PropertyName = "sampleDataSizeInMBs")]
        public System.Nullable<int> SampleDataSizeInMBs { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the job type. Each job type
        /// definition may define it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// job definitions have required properties within the \"default\" category.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;host&quot;: &quot;host1&quot;, &quot;port&quot;: &quot;1521&quot;, &quot;database&quot;: &quot;orcl&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
    }
}
