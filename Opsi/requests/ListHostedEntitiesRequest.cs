/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/ListHostedEntities.cs.html">here</a> to see an example of how to use ListHostedEntities request.
    /// </example>
    public class ListHostedEntitiesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Required [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the host insight resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id")]
        public string Id { get; set; }
        
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
        
        ///
        /// <value>
        /// Filter by one or more platform types.
        /// Possible value is LINUX.
        /// 
        /// </value>
        ///
        public enum PlatformTypeEnum {
            [EnumMember(Value = "LINUX")]
            Linux
        };

        /// <value>
        /// Filter by one or more platform types.
        /// Possible value is LINUX.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "platformType")]
        public System.Collections.Generic.List<PlatformTypeEnum> PlatformType { get; set; }
        
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
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// Hosted entity list sort options.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "entityName")]
            EntityName,
            [EnumMember(Value = "entityType")]
            EntityType
        };

        /// <value>
        /// Hosted entity list sort options.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
