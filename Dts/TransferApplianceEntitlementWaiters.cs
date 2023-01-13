/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DtsService.Models;
using Oci.DtsService.Requests;
using Oci.DtsService.Responses;

namespace Oci.DtsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of TransferApplianceEntitlement.
    /// </summary>
    public class TransferApplianceEntitlementWaiters
    {
        private readonly TransferApplianceEntitlementClient client;

        public  TransferApplianceEntitlementWaiters(TransferApplianceEntitlementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTransferApplianceEntitlementRequest, GetTransferApplianceEntitlementResponse> ForTransferApplianceEntitlement(GetTransferApplianceEntitlementRequest request, params TransferApplianceEntitlement.LifecycleStateEnum[] targetStates)
        {
            return this.ForTransferApplianceEntitlement(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTransferApplianceEntitlementRequest, GetTransferApplianceEntitlementResponse> ForTransferApplianceEntitlement(GetTransferApplianceEntitlementRequest request, WaiterConfiguration config, params TransferApplianceEntitlement.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTransferApplianceEntitlementRequest, GetTransferApplianceEntitlementResponse>(
                request,
                request => client.GetTransferApplianceEntitlement(request),
                response => targetStates.Contains(response.TransferApplianceEntitlement.LifecycleState.Value),
                targetStates.Contains(TransferApplianceEntitlement.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetTransferApplianceEntitlementRequest, GetTransferApplianceEntitlementResponse>(config, agent);
        }
    }
}
