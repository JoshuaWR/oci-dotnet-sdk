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


namespace Oci.AnnouncementsService.Models
{
    /// <summary>
    /// A group of filters to match announcements against.
    /// </summary>
    public class FilterGroup 
    {
        
        /// <value>
        /// The name of the group. The name must be unique and it cannot be changed. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A list of filters against which the Announcements service matches announcements. You cannot have more than one of any given filter type within a filter group. You also cannot combine the RESOURCE_ID filter with any other type of filter within a given filter group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Filters is required.")]
        [JsonProperty(PropertyName = "filters")]
        public System.Collections.Generic.List<Filter> Filters { get; set; }
        
    }
}
