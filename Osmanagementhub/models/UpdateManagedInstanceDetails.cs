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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// The information to be updated.
    /// </summary>
    public class UpdateManagedInstanceDetails 
    {
        
        /// <value>
        /// The OCID of a management station to be used as the preferred primary.
        /// </value>
        [JsonProperty(PropertyName = "primaryManagementStationId")]
        public string PrimaryManagementStationId { get; set; }
        
        /// <value>
        /// The OCID of a management station to be used as the preferred secondary.
        /// </value>
        [JsonProperty(PropertyName = "secondaryManagementStationId")]
        public string SecondaryManagementStationId { get; set; }
        
    }
}
