/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CapacitymanagementService.Models;

namespace Oci.CapacitymanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/capacitymanagement/GetOccCapacityRequest.cs.html">here</a> to see an example of how to use GetOccCapacityRequest request.
    /// </example>
    public class GetOccCapacityRequestRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the capacity request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OccCapacityRequestId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "occCapacityRequestId")]
        public string OccCapacityRequestId { get; set; }
        
        /// <value>
        /// The client request ID for tracing. The only valid characters for request IDs are letters, numbers,
        /// underscore, and dash.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
