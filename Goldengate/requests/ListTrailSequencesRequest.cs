/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.GoldengateService.Models;

namespace Oci.GoldengateService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/goldengate/ListTrailSequences.cs.html">here</a> to see an example of how to use ListTrailSequences request.
    /// </example>
    public class ListTrailSequencesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// A unique Deployment identifier.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "deploymentId")]
        public string DeploymentId { get; set; }
        
        /// <value>
        /// A Trail File identifier
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrailFileId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "trailFileId")]
        public string TrailFileId { get; set; }
        
        /// <value>
        /// A Trail Sequence identifier
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "trailSequenceId")]
        public string TrailSequenceId { get; set; }
        
        /// <value>
        /// A filter to return only the resources that match the entire 'displayName' given.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually
        /// retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order can be provided. Default order for 'timeLastUpdated' is
        /// descending.  Default order for 'displayName' is ascending. If no value is specified
        /// displayName is the default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeLastUpdated")]
            TimeLastUpdated,
            [EnumMember(Value = "displayName")]
            DisplayName
        };

        /// <value>
        /// The field to sort by. Only one sort order can be provided. Default order for 'timeLastUpdated' is
        /// descending.  Default order for 'displayName' is ascending. If no value is specified
        /// displayName is the default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
    }
}
