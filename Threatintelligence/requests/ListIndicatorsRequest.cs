/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ThreatintelligenceService.Models;

namespace Oci.ThreatintelligenceService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/threatintelligence/ListIndicators.cs.html">here</a> to see an example of how to use ListIndicators request.
    /// </example>
    public class ListIndicatorsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the tenancy (root compartment) that is used to filter results.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The threat type of entites to be returned. To filter for multiple threat types, repeat this parameter.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "threatTypeName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ThreatTypeName { get; set; }
        
        /// <value>
        /// The indicator type of entities to be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "type")]
        public System.Nullable<IndicatorType> Type { get; set; }
        
        /// <value>
        /// The indicator value of entities to be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "value")]
        public string Value { get; set; }
        
        /// <value>
        /// The minimum confidence score of entities to be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "confidenceGreaterThanOrEqualTo")]
        public System.Nullable<int> ConfidenceGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// The oldest update time of entities to be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeUpdatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Return indicators updated before the provided time.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdatedLessThan")]
        public System.Nullable<System.DateTime> TimeUpdatedLessThan { get; set; }
        
        /// <value>
        /// The oldest last seen time of entities to be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLastSeenGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeLastSeenGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Return indicators last seen before the provided time.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeLastSeenLessThan")]
        public System.Nullable<System.DateTime> TimeLastSeenLessThan { get; set; }
        
        /// <value>
        /// The oldest created/first seen time of entities to be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeCreatedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// Return indicators created/first seen before the provided time.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreatedLessThan")]
        public System.Nullable<System.DateTime> TimeCreatedLessThan { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// A token representing the position at which to start retrieving results. This must come from the `opc-next-page` header field of a previous response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'ASC' or 'DESC'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one field to sort by may be provided.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "confidence")]
            Confidence,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "timeUpdated")]
            TimeUpdated,
            [EnumMember(Value = "timeLastSeen")]
            TimeLastSeen
        };

        /// <value>
        /// The field to sort by. Only one field to sort by may be provided.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
