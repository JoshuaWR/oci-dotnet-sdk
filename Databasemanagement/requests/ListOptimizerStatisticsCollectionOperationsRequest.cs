/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/ListOptimizerStatisticsCollectionOperations.cs.html">here</a> to see an example of how to use ListOptimizerStatisticsCollectionOperations request.
    /// </example>
    public class ListOptimizerStatisticsCollectionOperationsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The start time of the time range to retrieve the optimizer statistics of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "startTimeGreaterThanOrEqualTo")]
        public string StartTimeGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The end time of the time range to retrieve the optimizer statistics of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endTimeLessThanOrEqualTo")]
        public string EndTimeLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The filter types of the optimizer statistics tasks.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "taskType")]
        public System.Nullable<OptimizerStatisticsTaskFilterTypes> TaskType { get; set; }
        
        /// <value>
        /// The maximum number of records returned in the paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page from where the next set of paginated results
        /// are retrieved. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The parameter used to filter the optimizer statistics operations.
        /// Any property of the OptimizerStatisticsCollectionOperationSummary can be used to define the filter condition.
        /// The allowed conditional operators are AND or OR, and the allowed binary operators are are >, < and =. Any other operator is regarded invalid.
        /// Example: jobName=<replace with job name> AND status=<replace with status>
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "filterBy")]
        public string FilterBy { get; set; }
        
        ///
        /// <value>
        /// Sorts the list of optimizer statistics operations based on a specific attribute.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "START_TIME")]
            StartTime,
            [EnumMember(Value = "END_TIME")]
            EndTime,
            [EnumMember(Value = "STATUS")]
            Status
        };

        /// <value>
        /// Sorts the list of optimizer statistics operations based on a specific attribute.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The option to sort information in ascending (\u2018ASC\u2019) or descending (\u2018DESC\u2019) order. Ascending order is the default order.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
