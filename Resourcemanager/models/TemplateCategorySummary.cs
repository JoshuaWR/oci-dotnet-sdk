/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Summary information for the template category.
    /// 
    /// </summary>
    public class TemplateCategorySummary 
    {
        
        /// <value>
        /// Unique identifier for the template category.
        /// Possible values are `0` (Quickstarts), `1` (Service), `2` (Architecture), and `3` (Private).
        /// Template category labels are displayed in the Console page listing templates.
        /// Quickstarts, Service, and Architecture templates (categories 0, 1, and 2) are available in all compartments.
        /// Each private template (category 3) is available in the compartment where it was created.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the template category.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
    }
}
