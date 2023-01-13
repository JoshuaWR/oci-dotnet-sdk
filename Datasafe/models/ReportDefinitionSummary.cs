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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Summary of report definition.
    /// </summary>
    public class ReportDefinitionSummary 
    {
        
        /// <value>
        /// Name of the report definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the report definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// Specifies the name of the category that this report belongs to.
        /// </value>
        ///
        public enum CategoryEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CUSTOM_REPORTS")]
            CustomReports,
            [EnumMember(Value = "SUMMARY")]
            Summary,
            [EnumMember(Value = "ACTIVITY_AUDITING")]
            ActivityAuditing
        };

        /// <value>
        /// Specifies the name of the category that this report belongs to.
        /// </value>
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CategoryEnum> Category { get; set; }
        
        /// <value>
        /// A description of the report definition.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Signifies whether the definition is seeded or user defined. Values can either be 'true' or 'false'.
        /// </value>
        [JsonProperty(PropertyName = "isSeeded")]
        public System.Nullable<bool> IsSeeded { get; set; }
        
        /// <value>
        /// Specifies how the report definitions are ordered in the display.
        /// </value>
        [JsonProperty(PropertyName = "displayOrder")]
        public System.Nullable<int> DisplayOrder { get; set; }
        
        /// <value>
        /// Specifies the time at which the report definition was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time of the report definition update in Data Safe.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the report definition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Specifies the name of a resource that provides data for the report. For example alerts, events.
        /// </value>
        [JsonProperty(PropertyName = "dataSource")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ReportDefinitionDataSource> DataSource { get; set; }
        
        /// <value>
        /// The current state of the report
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ReportDefinitionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Schedule to generate the report periodically in the specified format:
        /// <version-string>;<version-specific-schedule>
        /// <br/>
        /// Allowed version strings - \"v1\"
        /// v1's version specific schedule -<ss> <mm> <hh> <day-of-week> <day-of-month>
        /// Each of the above fields potentially introduce constraints. A workrequest is created only
        /// when clock time satisfies all the constraints. Constraints introduced:
        /// 1. seconds = <ss> (So, the allowed range for <ss> is [0, 59])
        /// 2. minutes = <mm> (So, the allowed range for <mm> is [0, 59])
        /// 3. hours = <hh> (So, the allowed range for <hh> is [0, 23])
        /// 4. <day-of-week> can be either '*' (without quotes or a number between 1(Monday) and 7(Sunday))
        /// No constraint introduced when it is '*'. When not, day of week must equal the given value
        /// 5. <day-of-month> can be either '*' (without quotes or a number between 1 and 28)
        /// No constraint introduced when it is '*'. When not, day of month must equal the given value
        /// 
        /// </value>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }
        
        /// <value>
        /// The list of data protection regulations/standards used in the report that will help demonstrate compliance.
        /// </value>
        [JsonProperty(PropertyName = "complianceStandards")]
        public System.Collections.Generic.List<string> ComplianceStandards { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
