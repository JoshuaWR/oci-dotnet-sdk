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
    /// The request of the generated Cost Analysis report.
    /// </summary>
    public class ReportQuery 
    {
        
        /// <value>
        /// Tenant ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantId is required.")]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
        
        /// <value>
        /// The usage start time.
        /// </value>
        [JsonProperty(PropertyName = "timeUsageStarted")]
        public System.Nullable<System.DateTime> TimeUsageStarted { get; set; }
        
        /// <value>
        /// The usage end time.
        /// </value>
        [JsonProperty(PropertyName = "timeUsageEnded")]
        public System.Nullable<System.DateTime> TimeUsageEnded { get; set; }
                ///
        /// <value>
        /// The usage granularity.
        /// HOURLY - Hourly data aggregation.
        /// DAILY - Daily data aggregation.
        /// MONTHLY - Monthly data aggregation.
        /// TOTAL - Not yet supported.
        /// 
        /// </value>
        ///
        public enum GranularityEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "HOURLY")]
            Hourly,
            [EnumMember(Value = "DAILY")]
            Daily,
            [EnumMember(Value = "MONTHLY")]
            Monthly,
            [EnumMember(Value = "TOTAL")]
            Total
        };

        /// <value>
        /// The usage granularity.
        /// HOURLY - Hourly data aggregation.
        /// DAILY - Daily data aggregation.
        /// MONTHLY - Monthly data aggregation.
        /// TOTAL - Not yet supported.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Granularity is required.")]
        [JsonProperty(PropertyName = "granularity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GranularityEnum> Granularity { get; set; }
        
        /// <value>
        /// Whether aggregated by time. If isAggregateByTime is true, all usage/cost over the query time period will be added up.
        /// </value>
        [JsonProperty(PropertyName = "isAggregateByTime")]
        public System.Nullable<bool> IsAggregateByTime { get; set; }
        
        [JsonProperty(PropertyName = "forecast")]
        public Forecast Forecast { get; set; }
                ///
        /// <value>
        /// The query usage type. COST by default if it is missing.
        /// Usage - Query the usage data.
        /// Cost - Query the cost/billing data.
        /// Credit - Query the credit adjustments data.
        /// ExpiredCredit - Query the expired credits data
        /// AllCredit - Query the credit adjustments and expired credit
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
            [EnumMember(Value = "CREDIT")]
            Credit,
            [EnumMember(Value = "EXPIREDCREDIT")]
            Expiredcredit,
            [EnumMember(Value = "ALLCREDIT")]
            Allcredit
        };

        /// <value>
        /// The query usage type. COST by default if it is missing.
        /// Usage - Query the usage data.
        /// Cost - Query the cost/billing data.
        /// Credit - Query the credit adjustments data.
        /// ExpiredCredit - Query the expired credits data
        /// AllCredit - Query the credit adjustments and expired credit
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<QueryTypeEnum> QueryType { get; set; }
        
        /// <value>
        /// Aggregate the result by.
        /// Example:   [&quot;tagNamespace&quot;, &quot;tagKey&quot;, &quot;tagValue&quot;, &quot;service&quot;, &quot;skuName&quot;, &quot;skuPartNumber&quot;, &quot;unit&quot;,    &quot;compartmentName&quot;, &quot;compartmentPath&quot;, &quot;compartmentId&quot;, &quot;platform&quot;, &quot;region&quot;, &quot;logicalAd&quot;,    &quot;resourceId&quot;, &quot;tenantId&quot;, &quot;tenantName&quot;]
        /// </value>
        [JsonProperty(PropertyName = "groupBy")]
        public System.Collections.Generic.List<string> GroupBy { get; set; }
        
        /// <value>
        /// GroupBy a specific tagKey. Provide the tagNamespace and tagKey in the tag object. Only supports one tag in the list.
        /// For Example:   [{&quot;namespace&quot;:&quot;oracle&quot;, &quot;key&quot;:&quot;createdBy&quot;]
        /// </value>
        [JsonProperty(PropertyName = "groupByTag")]
        public System.Collections.Generic.List<Tag> GroupByTag { get; set; }
        
        /// <value>
        /// The compartment depth level.
        /// </value>
        [JsonProperty(PropertyName = "compartmentDepth")]
        public System.Nullable<decimal> CompartmentDepth { get; set; }
        
        [JsonProperty(PropertyName = "filter")]
        public Filter Filter { get; set; }
                ///
        /// <value>
        /// The UI date range, for example, LAST_THREE_MONTHS. Conflicts with timeUsageStarted and timeUsageEnded.
        /// </value>
        ///
        public enum DateRangeNameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LAST_SEVEN_DAYS")]
            LastSevenDays,
            [EnumMember(Value = "LAST_TEN_DAYS")]
            LastTenDays,
            [EnumMember(Value = "MTD")]
            Mtd,
            [EnumMember(Value = "LAST_TWO_MONTHS")]
            LastTwoMonths,
            [EnumMember(Value = "LAST_THREE_MONTHS")]
            LastThreeMonths,
            [EnumMember(Value = "ALL")]
            All,
            [EnumMember(Value = "LAST_SIX_MONTHS")]
            LastSixMonths,
            [EnumMember(Value = "LAST_ONE_YEAR")]
            LastOneYear,
            [EnumMember(Value = "YTD")]
            Ytd,
            [EnumMember(Value = "CUSTOM")]
            Custom
        };

        /// <value>
        /// The UI date range, for example, LAST_THREE_MONTHS. Conflicts with timeUsageStarted and timeUsageEnded.
        /// </value>
        [JsonProperty(PropertyName = "dateRangeName")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DateRangeNameEnum> DateRangeName { get; set; }
        
    }
}
