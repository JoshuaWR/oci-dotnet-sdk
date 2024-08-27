/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DelegateaccesscontrolService.Models
{
    /// <summary>
    /// Approval info for initial access or extension of a Delegated Resource Access Request
    /// 
    /// </summary>
    public class DelegatedResourceAccessRequestApprovalDetails 
    {
                ///
        /// <value>
        /// Indicated whether the request is approved or rejected.
        /// </value>
        ///
        public enum ApprovalActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "APPROVE")]
            Approve,
            [EnumMember(Value = "REJECT")]
            Reject
        };

        /// <value>
        /// Indicated whether the request is approved or rejected.
        /// </value>
        [JsonProperty(PropertyName = "approvalAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ApprovalActionEnum> ApprovalAction { get; set; }
        
        /// <value>
        /// Access start time that is actually approved by the customer in [RFC 3339](https://tools.ietf.org/html/rfc3339)timestamp format, e.g. '2020-05-22T21:10:29.600Z'.
        /// </value>
        [JsonProperty(PropertyName = "timeApprovedForAccess")]
        public System.Nullable<System.DateTime> TimeApprovedForAccess { get; set; }
                ///
        /// <value>
        /// approval type, initial or extension
        /// </value>
        ///
        public enum ApprovalTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INITIAL")]
            Initial,
            [EnumMember(Value = "EXTENSION")]
            Extension
        };

        /// <value>
        /// approval type, initial or extension
        /// </value>
        [JsonProperty(PropertyName = "approvalType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ApprovalTypeEnum> ApprovalType { get; set; }
        
        /// <value>
        /// Comment specified by the approver of the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApproverComment is required.")]
        [JsonProperty(PropertyName = "approverComment")]
        public string ApproverComment { get; set; }
        
        /// <value>
        /// User ID of the approver.
        /// </value>
        [JsonProperty(PropertyName = "approverId")]
        public string ApproverId { get; set; }
        
        /// <value>
        /// Additional message specified by the approver of the request.
        /// </value>
        [JsonProperty(PropertyName = "approverAdditionalMessage")]
        public string ApproverAdditionalMessage { get; set; }
        
    }
}
