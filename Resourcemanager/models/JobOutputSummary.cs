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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Terraform output associated with a job.
    /// 
    /// </summary>
    public class JobOutputSummary 
    {
        
        /// <value>
        /// Name of the output.
        /// </value>
        [JsonProperty(PropertyName = "outputName")]
        public string OutputName { get; set; }
        
        /// <value>
        /// Output resource type.
        /// </value>
        [JsonProperty(PropertyName = "outputType")]
        public string OutputType { get; set; }
        
        /// <value>
        /// Value of the Terraform output.
        /// </value>
        [JsonProperty(PropertyName = "outputValue")]
        public string OutputValue { get; set; }
        
        /// <value>
        /// When `true`, output is sensitive.
        /// </value>
        [JsonProperty(PropertyName = "isSensitive")]
        public System.Nullable<bool> IsSensitive { get; set; }
        
        /// <value>
        /// Description of the output.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }
}
