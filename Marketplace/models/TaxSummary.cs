/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// Tax implication that current tenant may be eligible while using specific listing
    /// </summary>
    public class TaxSummary 
    {
        
        /// <value>
        /// Unique code for the tax.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public System.Guid Code { get; set; }
        
        /// <value>
        /// Name of the tax code.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Country, which imposes the tax.
        /// </value>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <value>
        /// The URL with more details about this tax.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
    }
}