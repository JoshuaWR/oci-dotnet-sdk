/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.ApigatewayService.Models;
using Oci.ApigatewayService.Requests;
using Oci.ApigatewayService.Responses;

namespace Oci.ApigatewayService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Deployment.
    /// </summary>
    public class DeploymentWaiters
    {
        private readonly DeploymentClient client;

        public  DeploymentWaiters(DeploymentClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentRequest, GetDeploymentResponse> ForDeployment(GetDeploymentRequest request, params Deployment.LifecycleStateEnum[] targetStates)
        {
            return this.ForDeployment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDeploymentRequest, GetDeploymentResponse> ForDeployment(GetDeploymentRequest request, WaiterConfiguration config, params Deployment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDeploymentRequest, GetDeploymentResponse>(
                request,
                request => client.GetDeployment(request),
                response => targetStates.Contains(response.Deployment.LifecycleState.Value),
                targetStates.Contains(Deployment.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDeploymentRequest, GetDeploymentResponse>(config, agent);
        }
    }
}
