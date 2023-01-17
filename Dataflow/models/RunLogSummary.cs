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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// A summary of a log associated with a particular run.
    /// 
    /// </summary>
    public class RunLogSummary 
    {
        
        /// <value>
        /// The name of the log.
        /// Example: spark_driver_stderr_20190917T114000Z.log.gz
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The runId associated with the log.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunId is required.")]
        [JsonProperty(PropertyName = "runId")]
        public string RunId { get; set; }
        
        /// <value>
        /// The size of the object in bytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sizeInBytes")]
        public System.Nullable<long> SizeInBytes { get; set; }
                ///
        /// <value>
        /// The source of the log such as driver and executor.
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "APPLICATION")]
            Application,
            [EnumMember(Value = "DRIVER")]
            Driver,
            [EnumMember(Value = "EXECUTOR")]
            Executor
        };

        /// <value>
        /// The source of the log such as driver and executor.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SourceEnum> Source { get; set; }
        
        /// <value>
        /// The date and time the object was created, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The type of log such as stdout and stderr.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "STDERR")]
            Stderr,
            [EnumMember(Value = "STDOUT")]
            Stdout
        };

        /// <value>
        /// The type of log such as stdout and stderr.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
    }
}
