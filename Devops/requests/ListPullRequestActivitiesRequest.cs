/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DevopsService.Models;

namespace Oci.DevopsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/devops/ListPullRequestActivities.cs.html">here</a> to see an example of how to use ListPullRequestActivities request.
    /// </example>
    public class ListPullRequestActivitiesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// unique PullRequest identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PullRequestId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "pullRequestId")]
        public string PullRequestId { get; set; }
        
        ///
        /// <value>
        /// An optional filter to list activities based on activity type. If no value is specified, all activity types will returned.
        /// 
        /// </value>
        ///
        public enum ActivityTypeEnum {
            [EnumMember(Value = "LIFECYCLE")]
            Lifecycle,
            [EnumMember(Value = "APPROVAL")]
            Approval,
            [EnumMember(Value = "COMMIT")]
            Commit,
            [EnumMember(Value = "REVIEWER")]
            Reviewer,
            [EnumMember(Value = "COMMENT")]
            Comment
        };

        /// <value>
        /// An optional filter to list activities based on activity type. If no value is specified, all activity types will returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "activityType")]
        public System.Nullable<ActivityTypeEnum> ActivityType { get; set; }
        
        /// <value>
        /// The sort order to use. Use either ascending or descending.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a particular request, provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}