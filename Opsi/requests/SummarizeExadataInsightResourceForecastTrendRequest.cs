/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/SummarizeExadataInsightResourceForecastTrend.cs.html">here</a> to see an example of how to use SummarizeExadataInsightResourceForecastTrend request.
    /// </example>
    public class SummarizeExadataInsightResourceForecastTrendRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Filter by resource.
        /// Supported values are HOST , STORAGE_SERVER and DATABASE
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// Filter by resource metric.
        /// Supported values are CPU , STORAGE, MEMORY, IO, IOPS, THROUGHPUT
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceMetric is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceMetric")]
        public string ResourceMetric { get; set; }
        
        /// <value>
        /// [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of exadata insight resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInsightId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exadataInsightId")]
        public string ExadataInsightId { get; set; }
        
        /// <value>
        /// Specify time period in ISO 8601 format with respect to current time.
        /// Default is last 30 days represented by P30D.
        /// If timeInterval is specified, then timeIntervalStart and timeIntervalEnd will be ignored.
        /// Examples  P90D (last 90 days), P4W (last 4 weeks), P2M (last 2 months), P1Y (last 12 months), . Maximum value allowed is 25 months prior to current time (P25M).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "analysisTimeInterval")]
        public string AnalysisTimeInterval { get; set; }
        
        /// <value>
        /// Analysis start time in UTC in ISO 8601 format(inclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// The minimum allowed value is 2 years prior to the current day.
        /// timeIntervalStart and timeIntervalEnd parameters are used together.
        /// If analysisTimeInterval is specified, this parameter is ignored.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// Analysis end time in UTC in ISO 8601 format(exclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// timeIntervalStart and timeIntervalEnd are used together.
        /// If timeIntervalEnd is not specified, current time is used as timeIntervalEnd.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
        
        /// <value>
        /// Optional list of database insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "databaseInsightId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DatabaseInsightId { get; set; }
        
        /// <value>
        /// Optional list of host insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostInsightId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> HostInsightId { get; set; }
        
        /// <value>
        /// Optional storage server name on an exadata system.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "storageServerName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> StorageServerName { get; set; }
        
        /// <value>
        /// Filter by one or more Exadata types.
        /// Possible value are DBMACHINE, EXACS, and EXACC.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exadataType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ExadataType { get; set; }
        
        ///
        /// <value>
        /// Choose the type of statistic metric data to be used for forecasting.
        /// </value>
        ///
        public enum StatisticEnum {
            [EnumMember(Value = "AVG")]
            Avg,
            [EnumMember(Value = "MAX")]
            Max
        };

        /// <value>
        /// Choose the type of statistic metric data to be used for forecasting.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "statistic")]
        public System.Nullable<StatisticEnum> Statistic { get; set; }
        
        /// <value>
        /// Number of days used for utilization forecast analysis.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "forecastStartDay")]
        public System.Nullable<int> ForecastStartDay { get; set; }
        
        /// <value>
        /// Number of days used for utilization forecast analysis.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "forecastDays")]
        public System.Nullable<int> ForecastDays { get; set; }
        
        ///
        /// <value>
        /// Choose algorithm model for the forecasting.
        /// Possible values:
        ///   - LINEAR: Uses linear regression algorithm for forecasting.
        ///   - ML_AUTO: Automatically detects best algorithm to use for forecasting.
        ///   - ML_NO_AUTO: Automatically detects seasonality of the data for forecasting using linear or seasonal algorithm.
        /// 
        /// </value>
        ///
        public enum ForecastModelEnum {
            [EnumMember(Value = "LINEAR")]
            Linear,
            [EnumMember(Value = "ML_AUTO")]
            MlAuto,
            [EnumMember(Value = "ML_NO_AUTO")]
            MlNoAuto
        };

        /// <value>
        /// Choose algorithm model for the forecasting.
        /// Possible values:
        ///   - LINEAR: Uses linear regression algorithm for forecasting.
        ///   - ML_AUTO: Automatically detects best algorithm to use for forecasting.
        ///   - ML_NO_AUTO: Automatically detects seasonality of the data for forecasting using linear or seasonal algorithm.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "forecastModel")]
        public System.Nullable<ForecastModelEnum> ForecastModel { get; set; }
        
        /// <value>
        /// Filter by one or more cdb name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "cdbName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> CdbName { get; set; }
        
        /// <value>
        /// Filter by hostname.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> HostName { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to
        /// return in a paginated \"List\" call.
        /// For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// Example: 50
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// This parameter is used to change data's confidence level, this data is ingested by the
        /// forecast algorithm.
        /// Confidence is the probability of an interval to contain the expected population parameter.
        /// Manipulation of this value will lead to different results.
        /// If not set, default confidence value is 95%.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "confidence")]
        public System.Nullable<int> Confidence { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The order in which resource Forecast trend records are listed
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "id")]
            Id,
            [EnumMember(Value = "name")]
            Name,
            [EnumMember(Value = "daysToReachCapacity")]
            DaysToReachCapacity
        };

        /// <value>
        /// The order in which resource Forecast trend records are listed
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
