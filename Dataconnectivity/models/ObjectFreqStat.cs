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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// One specific element. Its meaning changes according to the context. For example, for ValueFrequency, the value represents a column value. For Patterns the value represents a pattern. For DataType the value represents a data type. For DataType formats (pertaining to date time) the value represents a format.
    /// </summary>
    public class ObjectFreqStat 
    {
        
        /// <value>
        /// Value of the confidence of the profile result.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Placeholder for now, in future we will return the confidence of the profile result (because we are using sampled data and not whole data)
        /// </value>
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<int> Confidence { get; set; }
        
        /// <value>
        /// The number of times the value appeared.
        /// </value>
        [JsonProperty(PropertyName = "freq")]
        public System.Nullable<long> Freq { get; set; }
        
        /// <value>
        /// Frequency percentage across the sampled row counts (excluding nulls).
        /// </value>
        [JsonProperty(PropertyName = "freqPercentage")]
        public System.Double FreqPercentage { get; set; }
        
    }
}
