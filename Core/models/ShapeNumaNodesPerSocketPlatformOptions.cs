/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Configuration options for NUMA nodes per socket.
    /// 
    /// </summary>
    public class ShapeNumaNodesPerSocketPlatformOptions 
    {
                ///
        ///
        public enum AllowedValuesEnum {
            [EnumMember(Value = "NPS0")]
            Nps0,
            [EnumMember(Value = "NPS1")]
            Nps1,
            [EnumMember(Value = "NPS2")]
            Nps2,
            [EnumMember(Value = "NPS4")]
            Nps4
        };

        /// <value>
        /// The supported values for this platform configuration property.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowedValues", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<AllowedValuesEnum> AllowedValues { get; set; }
        
        /// <value>
        /// The default NUMA nodes per socket configuration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
    }
}