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


namespace Oci.ThreatintelligenceService.Models
{
    /// <summary>
    /// A data signature observed on a network or host that indicates a potential security threat. Indicators can be plain text or computed (hashed) values.
    /// </summary>
    public class Indicator 
    {
        
        /// <value>
        /// The OCID of the indicator.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Type of indicator
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IndicatorType> Type { get; set; }
        
        /// <value>
        /// The value for this indicator.
        /// Format is dependent upon `type`, e.g. DOMAIN_NAME \"evil.example.com\", MD5_HASH \"44d88612fea8a8f36de82e1278abb02f\", IP_ADDRESS \"2001:db8::1\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Confidence is an integer from 0 to 100 that provides a measure of our certainty in the maliciousness of the indicator.  This confidence value is aggregated from the confidence in the threat types, attributes, and relationships to create an overall value for the indicator.
        /// </value>
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<int> Confidence { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Characteristics of the threat indicator based on previous observations or behavior. May include related tactics, techniques, and procedures.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ThreatTypes is required.")]
        [JsonProperty(PropertyName = "threatTypes")]
        public System.Collections.Generic.List<ThreatType> ThreatTypes { get; set; }
        
        /// <value>
        /// A map of attribute name (string) to IndicatorAttribute (values and supporting data).
        /// This provides generic storage for additional data about an indicator.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Attributes is required.")]
        [JsonProperty(PropertyName = "attributes")]
        public System.Collections.Generic.List<IndicatorAttribute> Attributes { get; set; }
        
        /// <value>
        /// A map of relationship name (string) to IndicatorRelationship (related entities and supporting data).
        /// This provides generic storage for relationships between indicators or other entities.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Relationships is required.")]
        [JsonProperty(PropertyName = "relationships")]
        public System.Collections.Generic.List<IndicatorRelationship> Relationships { get; set; }
        
        /// <value>
        /// The state of the indicator.  It will always be ACTIVE.  This field is added for consistency.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The time the data was first seen for this indicator. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The last time this indicator was updated. It starts with the same value as timeCreated and is never empty. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
