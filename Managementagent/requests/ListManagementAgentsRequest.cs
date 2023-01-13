/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ManagementagentService.Models;

namespace Oci.ManagementagentService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/managementagent/ListManagementAgents.cs.html">here</a> to see an example of how to use ListManagementAgents request.
    /// </example>
    public class ListManagementAgentsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment to which a request will be scoped.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Filter to return only Management Agents having the particular Plugin installed. A special pluginName of 'None' can be provided and this will return only Management Agents having no plugin installed.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "pluginName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> PluginName { get; set; }
        
        /// <value>
        /// Filter to return only Management Agents having the particular agent version.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "version", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Version { get; set; }
        
        /// <value>
        /// Filter to return only Management Agents having the particular display name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Filter to return only Management Agents in the particular lifecycle state.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// Filter to return only Management Agents in the particular availability status.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "availabilityStatus")]
        public System.Nullable<AvailabilityStatus> AvailabilityStatus { get; set; }
        
        /// <value>
        /// Filter to return only Management Agents having the particular agent host id.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostId")]
        public string HostId { get; set; }
        
        /// <value>
        /// Filter to return only results having the particular platform type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "platformType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<PlatformTypes> PlatformType { get; set; }
        
        /// <value>
        /// true, if the agent image is manually downloaded and installed. false, if the agent is deployed as a plugin in Oracle Cloud Agent.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isCustomerDeployed")]
        public System.Nullable<bool> IsCustomerDeployed { get; set; }
        
        /// <value>
        /// A filter to return either agents or gateway types depending upon install type selected by user. By default both install type will be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "installType")]
        public System.Nullable<InstallTypes> InstallType { get; set; }
        
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
        
        ///
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending. If no value is specified timeCreated is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "host")]
            Host,
            [EnumMember(Value = "availabilityStatus")]
            AvailabilityStatus,
            [EnumMember(Value = "platformType")]
            PlatformType,
            [EnumMember(Value = "pluginDisplayNames")]
            PluginDisplayNames,
            [EnumMember(Value = "version")]
            Version
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending. Default order for displayName is ascending. If no value is specified timeCreated is default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// if set to true then it fetches resources for all compartments where user has access to else only on the compartment specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// When the value is \"ACCESSIBLE\", insufficient permissions for a compartment will filter out resources in that compartment without rejecting the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public string AccessLevel { get; set; }
    }
}
