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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Unit details of a data object column of CUSTOM unit category.
    /// </summary>
    public class DataObjectCustomColumnUnit : DataObjectColumnUnit
    {
        
        /// <value>
        /// Custom column unit.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }
        
        [JsonProperty(PropertyName = "unitCategory")]
        private readonly string unitCategory = "CUSTOM";
    }
}
