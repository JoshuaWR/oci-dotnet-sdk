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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Properties used in attribute create operations.
    /// </summary>
    public class CreateAttributeDetails 
    {
        
        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Optional user friendly business name of the attribute. If set, this supplements the harvested display name of the object.
        /// </value>
        [JsonProperty(PropertyName = "businessName")]
        public string BusinessName { get; set; }
        
        /// <value>
        /// Detailed description of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Data type of the attribute as defined in the external system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExternalDataType is required.")]
        [JsonProperty(PropertyName = "externalDataType")]
        public string ExternalDataType { get; set; }
        
        /// <value>
        /// Property that identifies if this attribute can be used as a watermark to extract incremental data.
        /// </value>
        [JsonProperty(PropertyName = "isIncrementalData")]
        public System.Nullable<bool> IsIncrementalData { get; set; }
        
        /// <value>
        /// Property that identifies if this attribute can be assigned null values.
        /// </value>
        [JsonProperty(PropertyName = "isNullable")]
        public System.Nullable<bool> IsNullable { get; set; }
        
        /// <value>
        /// Max allowed length of the attribute value.
        /// </value>
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<long> Length { get; set; }
        
        /// <value>
        /// Position of the attribute in the record definition.
        /// </value>
        [JsonProperty(PropertyName = "position")]
        public System.Nullable<int> Position { get; set; }
        
        /// <value>
        /// Precision of the attribute value usually applies to float data type.
        /// </value>
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<int> Precision { get; set; }
        
        /// <value>
        /// Scale of the attribute value usually applies to float data type.
        /// </value>
        [JsonProperty(PropertyName = "scale")]
        public System.Nullable<int> Scale { get; set; }
        
        /// <value>
        /// Last modified timestamp of this object in the external system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeExternal is required.")]
        [JsonProperty(PropertyName = "timeExternal")]
        public System.Nullable<System.DateTime> TimeExternal { get; set; }
        
        /// <value>
        /// The minimum count for the number of instances of a given type stored in this collection type attribute,applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "minCollectionCount")]
        public System.Nullable<int> MinCollectionCount { get; set; }
        
        /// <value>
        /// The maximum count for the number of instances of a given type stored in this collection type attribute,applicable if this attribute is a complex type.
        /// For type specifications in systems that specify only \"capacity\" without upper or lower bound , this property can also be used to just mean \"capacity\".
        /// Some examples are Varray size in Oracle , Occurs Clause in Cobol , capacity in XmlSchemaObjectCollection , maxOccurs in  Xml , maxItems in Json
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxCollectionCount")]
        public System.Nullable<int> MaxCollectionCount { get; set; }
        
        /// <value>
        /// External entity key that represents the datatype of this attribute , applicable if this attribute is a complex type.
        /// </value>
        [JsonProperty(PropertyName = "externalDatatypeEntityKey")]
        public string ExternalDatatypeEntityKey { get; set; }
        
        /// <value>
        /// External attribute key that represents the parent attribute  of this attribute , applicable if the parent attribute is of complex type.
        /// </value>
        [JsonProperty(PropertyName = "externalParentAttributeKey")]
        public string ExternalParentAttributeKey { get; set; }
        
        /// <value>
        /// The list of customized properties along with the values for this object
        /// </value>
        [JsonProperty(PropertyName = "customPropertyMembers")]
        public System.Collections.Generic.List<CustomPropertySetUsage> CustomPropertyMembers { get; set; }
        
        /// <value>
        /// Type key of the object. Type keys can be found via the '/types' endpoint.
        /// </value>
        [JsonProperty(PropertyName = "typeKey")]
        public string TypeKey { get; set; }
        
        /// <value>
        /// A map of maps that contains the properties which are specific to the attribute type. Each attribute type
        /// definition defines it's set of required and optional properties. The map keys are category names and the
        /// values are maps of property name to property value. Every property is contained inside of a category. Most
        /// attributes have required properties within the \"default\" category. To determine the set of required and
        /// optional properties for an attribute type, a query can be done on '/types?type=attribute' that returns a
        /// collection of all attribute types. The appropriate attribute type, which will include definitions of all
        /// of it's properties, can be identified from this collection.
        /// Example: {&quot;properties&quot;: { &quot;default&quot;: { &quot;key1&quot;: &quot;value1&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "properties")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
        
    }
}
