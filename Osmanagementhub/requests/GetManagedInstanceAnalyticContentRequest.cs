/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OsmanagementhubService.Models;

namespace Oci.OsmanagementhubService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/osmanagementhub/GetManagedInstanceAnalyticContent.cs.html">here</a> to see an example of how to use GetManagedInstanceAnalyticContent request.
    /// </example>
    public class GetManagedInstanceAnalyticContentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// This compartmentId is used to list managed instances within a compartment.
        /// Or serve as an additional filter to restrict only managed instances with in certain compartment if other filter presents.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the managed instance group for which to list resources.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "managedInstanceGroupId")]
        public string ManagedInstanceGroupId { get; set; }
        
        /// <value>
        /// The OCID of the lifecycle environment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleEnvironmentId")]
        public string LifecycleEnvironmentId { get; set; }
        
        /// <value>
        /// The OCID of the lifecycle stage for which to list resources.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleStageId")]
        public string LifecycleStageId { get; set; }
        
        /// <value>
        /// A filter to return only instances whose managed instance status matches the given status.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<ManagedInstanceStatus> Status { get; set; }
        
        /// <value>
        /// A filter to return resources that match the given display names.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DisplayName { get; set; }
        
        /// <value>
        /// A filter to return resources that may partially match the given display name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayNameContains")]
        public string DisplayNameContains { get; set; }
        
        /// <value>
        /// Filter instances by Location. Used when report target type is compartment or group.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "instanceLocation")]
        public System.Nullable<ManagedInstanceLocation> InstanceLocation { get; set; }
        
        /// <value>
        /// A filter to return instances with number of available security updates equals to the number specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "securityUpdatesAvailableEqualsTo")]
        public System.Nullable<int> SecurityUpdatesAvailableEqualsTo { get; set; }
        
        /// <value>
        /// A filter to return instances with number of available bug updates equals to the number specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "bugUpdatesAvailableEqualsTo")]
        public System.Nullable<int> BugUpdatesAvailableEqualsTo { get; set; }
        
        /// <value>
        /// A filter to return instances with number of available security updates greater than the number specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "securityUpdatesAvailableGreaterThan")]
        public System.Nullable<int> SecurityUpdatesAvailableGreaterThan { get; set; }
        
        /// <value>
        /// A filter to return instances with number of available bug updates greater than the number specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "bugUpdatesAvailableGreaterThan")]
        public System.Nullable<int> BugUpdatesAvailableGreaterThan { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}