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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The Post Processing Function masking format is a special masking option that
    /// enables you to use a custom function to further transform column values after
    /// they have been masked using some other masking formats. It takes the intermediate
    /// masked values as input and returns the final masked values. For example, you can
    /// use it for adding checksums or special encodings to the masked values.
    /// <br/>
    /// A post-processing function has the same signature as a user-defined function,
    /// but it passes in the masked values the masking engine generates, and returns
    /// the final masked values that should be used for masking. To learn more, check
    /// Post Processing Function in the Data Safe documentation. 
    /// 
    /// </summary>
    public class PPFFormatEntry : FormatEntry
    {
        
        /// <value>
        /// The post processing function in SCHEMA_NAME.PACKAGE_NAME.FUNCTION_NAME
        /// format. It can be a standalone or packaged function, so PACKAGE_NAME
        /// is optional. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PostProcessingFunction is required.")]
        [JsonProperty(PropertyName = "postProcessingFunction")]
        public string PostProcessingFunction { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "POST_PROCESSING_FUNCTION";
    }
}
