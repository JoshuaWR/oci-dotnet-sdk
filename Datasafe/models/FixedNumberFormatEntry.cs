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
    /// The Fixed Number masking format uses a constant number for masking. To learn more,
    /// check Fixed Number in the Data Safe documentation. 
    /// 
    /// </summary>
    public class FixedNumberFormatEntry : FormatEntry
    {
        
        /// <value>
        /// The constant number to be used for masking.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FixedNumber is required.")]
        [JsonProperty(PropertyName = "fixedNumber")]
        public System.Nullable<decimal> FixedNumber { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "FIXED_NUMBER";
    }
}
