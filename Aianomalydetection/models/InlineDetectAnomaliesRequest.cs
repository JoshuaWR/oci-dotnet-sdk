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


namespace Oci.AianomalydetectionService.Models
{
    /// <summary>
    /// This is the specialised JSON format that we accept as Training data, with an additional
    /// field for 'requestType' which is a required field used deciding whether it is an inline
    /// request or contains embedded data.
    /// 
    /// </summary>
    public class InlineDetectAnomaliesRequest : DetectAnomaliesDetails
    {
        
        /// <value>
        /// List of signal names.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SignalNames is required.")]
        [JsonProperty(PropertyName = "signalNames")]
        public System.Collections.Generic.List<string> SignalNames { get; set; }
        
        /// <value>
        /// Array containing data.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Data is required.")]
        [JsonProperty(PropertyName = "data")]
        public System.Collections.Generic.List<DataItem> Data { get; set; }
        
        [JsonProperty(PropertyName = "requestType")]
        private readonly string requestType = "INLINE";
    }
}
