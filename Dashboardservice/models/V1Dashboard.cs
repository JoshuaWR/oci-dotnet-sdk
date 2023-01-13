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


namespace Oci.DashboardService.Models
{
    /// <summary>
    /// A version 1 dashboard.
    /// The interpretation of the `config` and `widgets` fields depends on the runtime behavior of the Oracle Cloud Infrastructure Console.
    /// The sum of the `config` and `widget` fields JSON text representation cannot exceed 200 KB.
    /// 
    /// </summary>
    public class V1Dashboard : Dashboard
    {
        
        /// <value>
        /// The dashboard configuration. For example, the layout and widget placement.
        /// </value>
        [JsonProperty(PropertyName = "config")]
        public System.Object Config { get; set; }
        
        /// <value>
        /// The visualization building blocks of the dashboard.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Widgets is required.")]
        [JsonProperty(PropertyName = "widgets")]
        public System.Collections.Generic.List<System.Object> Widgets { get; set; }
        
        [JsonProperty(PropertyName = "schemaVersion")]
        private readonly string schemaVersion = "V1";
    }
}
