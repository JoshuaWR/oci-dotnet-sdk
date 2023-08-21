/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.ComputecloudatcustomerService.Models;
using Oci.ComputecloudatcustomerService.Requests;
using Oci.ComputecloudatcustomerService.Responses;

namespace Oci.ComputecloudatcustomerService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of ComputeCloudAtCustomer.
    /// </summary>
    public class ComputeCloudAtCustomerWaiters
    {
        private readonly ComputeCloudAtCustomerClient client;

        public  ComputeCloudAtCustomerWaiters(ComputeCloudAtCustomerClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCccInfrastructureRequest, GetCccInfrastructureResponse> ForCccInfrastructure(GetCccInfrastructureRequest request, params CccInfrastructure.LifecycleStateEnum[] targetStates)
        {
            return this.ForCccInfrastructure(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCccInfrastructureRequest, GetCccInfrastructureResponse> ForCccInfrastructure(GetCccInfrastructureRequest request, WaiterConfiguration config, params CccInfrastructure.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetCccInfrastructureRequest, GetCccInfrastructureResponse>(
                request,
                request => client.GetCccInfrastructure(request),
                response => targetStates.Contains(response.CccInfrastructure.LifecycleState.Value),
                targetStates.Contains(CccInfrastructure.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetCccInfrastructureRequest, GetCccInfrastructureResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCccUpgradeScheduleRequest, GetCccUpgradeScheduleResponse> ForCccUpgradeSchedule(GetCccUpgradeScheduleRequest request, params CccUpgradeSchedule.LifecycleStateEnum[] targetStates)
        {
            return this.ForCccUpgradeSchedule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetCccUpgradeScheduleRequest, GetCccUpgradeScheduleResponse> ForCccUpgradeSchedule(GetCccUpgradeScheduleRequest request, WaiterConfiguration config, params CccUpgradeSchedule.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetCccUpgradeScheduleRequest, GetCccUpgradeScheduleResponse>(
                request,
                request => client.GetCccUpgradeSchedule(request),
                response => targetStates.Contains(response.CccUpgradeSchedule.LifecycleState.Value),
                targetStates.Contains(CccUpgradeSchedule.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetCccUpgradeScheduleRequest, GetCccUpgradeScheduleResponse>(config, agent);
        }
    }
}
