/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.NetworkloadbalancerService.Models;

namespace Oci.NetworkloadbalancerService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/networkloadbalancer/CreateNetworkLoadBalancer.cs.html">here</a> to see an example of how to use CreateNetworkLoadBalancer request.
    /// </example>
    public class CreateNetworkLoadBalancerRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Details for the new network load balancer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateNetworkLoadBalancerDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public CreateNetworkLoadBalancerDetails CreateNetworkLoadBalancerDetails { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so that it can be retried in case of a timeout or
        /// server error without risk of rerunning that same action. Retry tokens expire after 24
        /// hours but they can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// The unique Oracle-assigned identifier for the request. If you must contact Oracle about a
        /// particular request, then provide the request identifier.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
