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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The query properties.
    /// </summary>
    public class QueryProperties 
    {
        
        /// <value>
        /// Aggregate the result by. For Example: [ &quot;tagNamespace&quot;, &quot;tagKey&quot;, &quot;tagValue&quot;, &quot;service&quot;, &quot;skuName&quot;, &quot;skuPartNumber&quot;, &quot;unit&quot;, &quot;compartmentName&quot;, &quot;compartmentPath&quot;, &quot;compartmentId&quot;, &quot;platform&quot;, &quot;region&quot;, &quot;logicalAd&quot;, &quot;resourceId&quot;, &quot;tenantId&quot;, &quot;tenantName&quot; ]
        /// </value>
        [JsonProperty(PropertyName = "groupBy")]
        public System.Collections.Generic.List<string> GroupBy { get; set; }
        
        /// <value>
        /// GroupBy a specific tagKey. Provide the tagNamespace and tagKey in the tag object. Only supports one tag in the list. For Example: [ { &quot;namespace&quot;: &quot;oracle&quot;, &quot;key&quot;: &quot;createdBy&quot; ]
        /// </value>
        [JsonProperty(PropertyName = "groupByTag")]
        public System.Collections.Generic.List<Tag> GroupByTag { get; set; }
        
        [JsonProperty(PropertyName = "filter")]
        public Filter Filter { get; set; }
        
        /// <value>
        /// The depth level of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentDepth")]
        public System.Nullable<decimal> CompartmentDepth { get; set; }
                ///
        /// <value>
        /// The usage granularity. DAILY - Daily data aggregation. MONTHLY - Monthly data aggregation.
        /// Allowed values are:
        ///   DAILY
        ///   MONTHLY
        /// 
        /// </value>
        ///
        public enum GranularityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DAILY")]
            Daily,
            [EnumMember(Value = "MONTHLY")]
            Monthly
        };

        /// <value>
        /// The usage granularity. DAILY - Daily data aggregation. MONTHLY - Monthly data aggregation.
        /// Allowed values are:
        ///   DAILY
        ///   MONTHLY
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Granularity is required.")]
        [JsonProperty(PropertyName = "granularity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GranularityEnum> Granularity { get; set; }
                ///
        /// <value>
        /// The query usage type. COST by default if it is missing. Usage - Query the usage data. Cost - Query the cost/billing data.
        /// Allowed values are:
        ///   USAGE
        ///   COST
        ///   USAGE_AND_COST
        /// 
        /// </value>
        ///
        public enum QueryTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "USAGE")]
            Usage,
            [EnumMember(Value = "COST")]
            Cost,
            [EnumMember(Value = "USAGE_AND_COST")]
            UsageAndCost
        };

        /// <value>
        /// The query usage type. COST by default if it is missing. Usage - Query the usage data. Cost - Query the cost/billing data.
        /// Allowed values are:
        ///   USAGE
        ///   COST
        ///   USAGE_AND_COST
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<QueryTypeEnum> QueryType { get; set; }
        
        /// <value>
        /// Specifies whether aggregated by time. If isAggregateByTime is true, all usage or cost over the query time period will be added up.
        /// </value>
        [JsonProperty(PropertyName = "isAggregateByTime")]
        public System.Nullable<bool> IsAggregateByTime { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DateRange is required.")]
        [JsonProperty(PropertyName = "dateRange")]
        public DateRange DateRange { get; set; }
        
    }
}
