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


namespace Oci.NetworkloadbalancerService.Models
{
    /// <summary>
    /// The health status details for a backend set.
    /// <br/>
    /// This object does not explicitly enumerate backend servers with a status of `OK`. However, the backend sets are included in the
    /// `totalBackendCount` sum.
    /// 
    /// </summary>
    public class BackendSetHealth 
    {
                ///
        /// <value>
        /// Overall health status of the backend set.
        /// <br/>
        /// *  **OK:** All backend servers in the backend set return a status of `OK`.
        /// <br/>
        /// *  **WARNING:** Half or more of the backend servers in a backend set return a status of `OK` and at least one backend
        /// server returns a status of `WARNING`, `CRITICAL`, or `UNKNOWN`.
        /// <br/>
        /// *  **CRITICAL:** Fewer than half of the backend servers in a backend set return a status of `OK`.
        /// <br/>
        /// *  **UNKNOWN:** If no probes have yet been sent to the backends, or the system is
        /// unable to retrieve metrics from the backends.
        /// 
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OK")]
            Ok,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        };

        /// <value>
        /// Overall health status of the backend set.
        /// <br/>
        /// *  **OK:** All backend servers in the backend set return a status of `OK`.
        /// <br/>
        /// *  **WARNING:** Half or more of the backend servers in a backend set return a status of `OK` and at least one backend
        /// server returns a status of `WARNING`, `CRITICAL`, or `UNKNOWN`.
        /// <br/>
        /// *  **CRITICAL:** Fewer than half of the backend servers in a backend set return a status of `OK`.
        /// <br/>
        /// *  **UNKNOWN:** If no probes have yet been sent to the backends, or the system is
        /// unable to retrieve metrics from the backends.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// A list of backend servers that are currently in the `WARNING` health state. The list identifies each backend server by
        /// IP address or OCID and port.
        /// <br/>
        /// Example: 10.0.0.3:8080 or ocid1.privateip..oc1.<var>&lt;unique_ID&gt;</var>:8080
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WarningStateBackendNames is required.")]
        [JsonProperty(PropertyName = "warningStateBackendNames")]
        public System.Collections.Generic.List<string> WarningStateBackendNames { get; set; }
        
        /// <value>
        /// A list of backend servers that are currently in the `CRITICAL` health state. The list identifies each backend server by
        /// IP address and port.
        /// <br/>
        /// Example: 10.0.0.4:8080
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CriticalStateBackendNames is required.")]
        [JsonProperty(PropertyName = "criticalStateBackendNames")]
        public System.Collections.Generic.List<string> CriticalStateBackendNames { get; set; }
        
        /// <value>
        /// A list of backend servers that are currently in the `UNKNOWN` health state. The list identifies each backend server by
        /// IP address and port.
        /// <br/>
        /// Example: 10.0.0.5:8080
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnknownStateBackendNames is required.")]
        [JsonProperty(PropertyName = "unknownStateBackendNames")]
        public System.Collections.Generic.List<string> UnknownStateBackendNames { get; set; }
        
        /// <value>
        /// The total number of backend servers in this backend set.
        /// <br/>
        /// Example: 7
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalBackendCount is required.")]
        [JsonProperty(PropertyName = "totalBackendCount")]
        public System.Nullable<int> TotalBackendCount { get; set; }
        
    }
}
