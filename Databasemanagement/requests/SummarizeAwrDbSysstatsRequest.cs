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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/SummarizeAwrDbSysstats.cs.html">here</a> to see an example of how to use SummarizeAwrDbSysstats request.
    /// </example>
    public class SummarizeAwrDbSysstatsRequest : Oci.Common.IOciRequest
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
        /// The parameter to filter the database by internal ID.
        /// Note that the internal ID of the database can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbs
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwrDbId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "awrDbId")]
        public string AwrDbId { get; set; }
        
        /// <value>
        /// The required multiple value query parameter to filter the entity name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Name { get; set; }
        
        /// <value>
        /// The optional single value query parameter to filter the database instance number.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "instNum")]
        public string InstNum { get; set; }
        
        /// <value>
        /// The optional greater than or equal to filter on the snapshot ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "beginSnIdGreaterThanOrEqualTo")]
        public System.Nullable<int> BeginSnIdGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to query parameter to filter the snapshot ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "endSnIdLessThanOrEqualTo")]
        public System.Nullable<int> EndSnIdLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional greater than or equal to query parameter to filter the timestamp.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional less than or equal to query parameter to filter the timestamp.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// The optional query parameter to filter the database container by an exact ID value.
        /// Note that the database container ID can be retrieved from the following endpoint:
        /// /managedDatabases/{managedDatabaseId}/awrDbSnapshotRanges
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "containerId")]
        public System.Nullable<int> ContainerId { get; set; }
        
        /// <value>
        /// The page token representing the page from where the next set of paginated results
        /// are retrieved. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of records returned in large paginated response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        ///
        /// <value>
        /// The option to sort the data within a time period.
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIME_BEGIN")]
            TimeBegin,
            [EnumMember(Value = "NAME")]
            Name
        };

        /// <value>
        /// The option to sort the data within a time period.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The option to sort information in ascending (\u2018ASC\u2019) or descending (\u2018DESC\u2019) order. Descending order is the default order.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}
