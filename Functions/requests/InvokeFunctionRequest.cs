/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.FunctionsService.Models;

namespace Oci.FunctionsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/functions/InvokeFunction.cs.html">here</a> to see an example of how to use InvokeFunction request.
    /// </example>
    public class InvokeFunctionRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of this function.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FunctionId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "functionId")]
        public string FunctionId { get; set; }
        
        /// <value>
        /// The body of the function invocation.
        /// Note: The maximum size of the request is limited. This limit is currently 6MB and the endpoint will not accept requests that are bigger than this limit.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream InvokeFunctionBody { get; set; }
        
        ///
        /// <value>
        /// An optional intent header that indicates to the FDK the way the event should be interpreted. E.g. 'httprequest', 'cloudevent'.
        /// 
        /// </value>
        ///
        public enum FnIntentEnum {
            [EnumMember(Value = "httprequest")]
            Httprequest,
            [EnumMember(Value = "cloudevent")]
            Cloudevent
        };

        /// <value>
        /// An optional intent header that indicates to the FDK the way the event should be interpreted. E.g. 'httprequest', 'cloudevent'.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "fn-intent")]
        public System.Nullable<FnIntentEnum> FnIntent { get; set; }
        
        ///
        /// <value>
        /// Indicates whether Oracle Functions should execute the request and return the result ('sync') of the execution, 
        /// or whether Oracle Functions should return as soon as processing has begun ('detached') and leave result handling to the function.
        /// 
        /// </value>
        ///
        public enum FnInvokeTypeEnum {
            [EnumMember(Value = "detached")]
            Detached,
            [EnumMember(Value = "sync")]
            Sync
        };

        /// <value>
        /// Indicates whether Oracle Functions should execute the request and return the result ('sync') of the execution, 
        /// or whether Oracle Functions should return as soon as processing has begun ('detached') and leave result handling to the function.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "fn-invoke-type")]
        public System.Nullable<FnInvokeTypeEnum> FnInvokeType { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you need to contact Oracle about a
        /// particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
