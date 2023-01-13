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
    /// The Random Digits masking format generates random digits of length within a range. 
    /// The length range is defined by the startLength and endLength attributes. The start 
    /// length must be less than or equal to the end length. When masking columns with 
    /// uniqueness constraint, ensure that the length range is sufficient enough to generate 
    /// unique values. This masking format pads to the appropriate length in a string, but 
    /// does not pad when used for a number column. It's a complementary type of Random Number,
    /// which is not padded. 
    /// 
    /// </summary>
    public class RandomDigitsFormatEntry : FormatEntry
    {
        
        /// <value>
        /// The minimum number of digits the generated values should have. It can be 
        /// any integer greater than zero, but it must be less than or equal to the 
        /// end length. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StartLength is required.")]
        [JsonProperty(PropertyName = "startLength")]
        public System.Nullable<int> StartLength { get; set; }
        
        /// <value>
        /// The maximum number of digits the generated values should have. It can 
        /// be any integer greater than zero, but it must be greater than or equal 
        /// to the start length. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndLength is required.")]
        [JsonProperty(PropertyName = "endLength")]
        public System.Nullable<int> EndLength { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "RANDOM_DIGITS";
    }
}
