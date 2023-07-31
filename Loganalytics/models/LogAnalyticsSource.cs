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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsSource
    /// </summary>
    public class LogAnalyticsSource 
    {
        
        /// <value>
        /// The label alert conditions.
        /// </value>
        [JsonProperty(PropertyName = "labelConditions")]
        public System.Collections.Generic.List<LogAnalyticsSourceLabelCondition> LabelConditions { get; set; }
        
        /// <value>
        /// The association count.
        /// </value>
        [JsonProperty(PropertyName = "associationCount")]
        public System.Nullable<int> AssociationCount { get; set; }
        
        /// <value>
        /// The association entities.
        /// </value>
        [JsonProperty(PropertyName = "associationEntity")]
        public System.Collections.Generic.List<LogAnalyticsAssociation> AssociationEntity { get; set; }
        
        /// <value>
        /// The data filter definitions.
        /// </value>
        [JsonProperty(PropertyName = "dataFilterDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsSourceDataFilter> DataFilterDefinitions { get; set; }
        
        /// <value>
        /// The database credential.
        /// </value>
        [JsonProperty(PropertyName = "databaseCredential")]
        public string DatabaseCredential { get; set; }
        
        /// <value>
        /// The extended field definitions.
        /// </value>
        [JsonProperty(PropertyName = "extendedFieldDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsSourceExtendedFieldDefinition> ExtendedFieldDefinitions { get; set; }
        
        /// <value>
        /// A flag indicating whether or not this is a cloud source.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isForCloud")]
        public System.Nullable<bool> IsForCloud { get; set; }
        
        /// <value>
        /// The labels associated with the source.
        /// </value>
        [JsonProperty(PropertyName = "labels")]
        public System.Collections.Generic.List<LogAnalyticsLabelView> Labels { get; set; }
        
        /// <value>
        /// The metric definitions.
        /// </value>
        [JsonProperty(PropertyName = "metricDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsMetric> MetricDefinitions { get; set; }
        
        /// <value>
        /// The metric source map.
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.List<LogAnalyticsSourceMetric> Metrics { get; set; }
        
        /// <value>
        /// The built in parsers associated with source.
        /// </value>
        [JsonProperty(PropertyName = "oobParsers")]
        public System.Collections.Generic.List<LogAnalyticsParser> OobParsers { get; set; }
        
        /// <value>
        /// The source parameters.
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.List<LogAnalyticsParameter> Parameters { get; set; }
        
        /// <value>
        /// The pattern count.
        /// </value>
        [JsonProperty(PropertyName = "patternCount")]
        public System.Nullable<int> PatternCount { get; set; }
        
        /// <value>
        /// The source patterns.
        /// </value>
        [JsonProperty(PropertyName = "patterns")]
        public System.Collections.Generic.List<LogAnalyticsSourcePattern> Patterns { get; set; }
        
        /// <value>
        /// The source description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The source display name.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The source edit version.
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }
        
        /// <value>
        /// The source functions.
        /// </value>
        [JsonProperty(PropertyName = "functions")]
        public System.Collections.Generic.List<LogAnalyticsSourceFunction> Functions { get; set; }
        
        /// <value>
        /// The source unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public System.Nullable<long> SourceId { get; set; }
        
        /// <value>
        /// The source internal name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the source content is secure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSecureContent")]
        public System.Nullable<bool> IsSecureContent { get; set; }
        
        /// <value>
        /// The system flag.  A value of false denotes a custom, or user
        /// defined object.  A value of true denotes a built in object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSystem")]
        public System.Nullable<bool> IsSystem { get; set; }
        
        /// <value>
        /// The list of parsers used by the source.
        /// </value>
        [JsonProperty(PropertyName = "parsers")]
        public System.Collections.Generic.List<LogAnalyticsParser> Parsers { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the source is marked for auto-association.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoAssociationEnabled")]
        public System.Nullable<bool> IsAutoAssociationEnabled { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the auto-association state should be overriden.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoAssociationOverride")]
        public System.Nullable<bool> IsAutoAssociationOverride { get; set; }
        
        /// <value>
        /// The rule unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "ruleId")]
        public System.Nullable<long> RuleId { get; set; }
        
        /// <value>
        /// The source type internal name.
        /// </value>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }
        
        /// <value>
        /// The source type name.
        /// </value>
        [JsonProperty(PropertyName = "typeDisplayName")]
        public string TypeDisplayName { get; set; }
        
        /// <value>
        /// The source warning configuration.
        /// </value>
        [JsonProperty(PropertyName = "warningConfig")]
        public System.Nullable<long> WarningConfig { get; set; }
        
        /// <value>
        /// The source metadata fields.
        /// </value>
        [JsonProperty(PropertyName = "metadataFields")]
        public System.Collections.Generic.List<LogAnalyticsSourceMetadataField> MetadataFields { get; set; }
        
        /// <value>
        /// The labls used by the source.
        /// </value>
        [JsonProperty(PropertyName = "labelDefinitions")]
        public System.Collections.Generic.List<LogAnalyticsLabelDefinition> LabelDefinitions { get; set; }
        
        /// <value>
        /// The entity types.
        /// </value>
        [JsonProperty(PropertyName = "entityTypes")]
        public System.Collections.Generic.List<LogAnalyticsSourceEntityType> EntityTypes { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the source has a time zone override.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isTimezoneOverride")]
        public System.Nullable<bool> IsTimezoneOverride { get; set; }
        
        /// <value>
        /// An array of custom parsers.
        /// </value>
        [JsonProperty(PropertyName = "userParsers")]
        public System.Collections.Generic.List<LogAnalyticsParser> UserParsers { get; set; }
        
        /// <value>
        /// The last updated date.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// An array of event types.
        /// </value>
        [JsonProperty(PropertyName = "eventTypes")]
        public System.Collections.Generic.List<EventType> EventTypes { get; set; }
        
        /// <value>
        /// An array of categories assigned to this source.
        /// The isSystem flag denotes if each category assignment is user-created or Oracle-defined.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "categories")]
        public System.Collections.Generic.List<LogAnalyticsCategory> Categories { get; set; }
        
        /// <value>
        /// An array of REST API endpoints for log collection.
        /// </value>
        [JsonProperty(PropertyName = "endpoints")]
        public System.Collections.Generic.List<LogAnalyticsEndpoint> Endpoints { get; set; }
        
        /// <value>
        /// A list of source properties.
        /// </value>
        [JsonProperty(PropertyName = "sourceProperties")]
        public System.Collections.Generic.List<LogAnalyticsProperty> SourceProperties { get; set; }
        
    }
}
