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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// The shape of the DB System. The shape determines resources to allocate
    /// to the DB System - CPU cores and memory for VM shapes; CPU cores, memory
    /// and storage for non-VM (or bare metal) shapes.  For a description of
    /// shapes, see [DB System Shape Options](https://docs.cloud.oracle.com/mysql-database/doc/shapes.htm).
    /// 
    /// </summary>
    public class ShapeSummary 
    {
        
        /// <value>
        /// The name of the shape used for the DB System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The number of CPU Cores the Instance provides. These are \"OCPU\"s.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The amount of RAM the Instance provides. This is an IEC base-2 number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemorySizeInGBs is required.")]
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<int> MemorySizeInGBs { get; set; }
                ///
        ///
        public enum IsSupportedForEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DBSYSTEM")]
            Dbsystem,
            [EnumMember(Value = "HEATWAVECLUSTER")]
            Heatwavecluster
        };

        /// <value>
        /// What service features the shape is supported for.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSupportedFor", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<IsSupportedForEnum> IsSupportedFor { get; set; }
        
    }
}
