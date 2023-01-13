/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DataintegrationService.Models;
using Oci.DataintegrationService.Requests;
using Oci.DataintegrationService.Responses;

namespace Oci.DataintegrationService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DataIntegration.
    /// </summary>
    public class DataIntegrationWaiters
    {
        private readonly DataIntegrationClient client;

        public  DataIntegrationWaiters(DataIntegrationClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApplicationRequest, GetApplicationResponse> ForApplication(GetApplicationRequest request, params Application.LifecycleStateEnum[] targetStates)
        {
            return this.ForApplication(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetApplicationRequest, GetApplicationResponse> ForApplication(GetApplicationRequest request, WaiterConfiguration config, params Application.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetApplicationRequest, GetApplicationResponse>(
                request,
                request => client.GetApplication(request),
                response => targetStates.Contains(response.Application.LifecycleState.Value),
                targetStates.Contains(Application.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetApplicationRequest, GetApplicationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDependentObjectRequest, GetDependentObjectResponse> ForDependentObject(GetDependentObjectRequest request, params DependentObject.LifecycleStateEnum[] targetStates)
        {
            return this.ForDependentObject(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDependentObjectRequest, GetDependentObjectResponse> ForDependentObject(GetDependentObjectRequest request, WaiterConfiguration config, params DependentObject.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDependentObjectRequest, GetDependentObjectResponse>(
                request,
                request => client.GetDependentObject(request),
                response => targetStates.Contains(response.DependentObject.LifecycleState.Value),
                targetStates.Contains(DependentObject.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDependentObjectRequest, GetDependentObjectResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDisApplicationRequest, GetDisApplicationResponse> ForDisApplication(GetDisApplicationRequest request, params DisApplication.LifecycleStateEnum[] targetStates)
        {
            return this.ForDisApplication(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDisApplicationRequest, GetDisApplicationResponse> ForDisApplication(GetDisApplicationRequest request, WaiterConfiguration config, params DisApplication.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDisApplicationRequest, GetDisApplicationResponse>(
                request,
                request => client.GetDisApplication(request),
                response => targetStates.Contains(response.DisApplication.LifecycleState.Value),
                targetStates.Contains(DisApplication.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDisApplicationRequest, GetDisApplicationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForWorkRequest(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params WorkRequest.StatusEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkspaceRequest, GetWorkspaceResponse> ForWorkspace(GetWorkspaceRequest request, params Workspace.LifecycleStateEnum[] targetStates)
        {
            return this.ForWorkspace(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkspaceRequest, GetWorkspaceResponse> ForWorkspace(GetWorkspaceRequest request, WaiterConfiguration config, params Workspace.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkspaceRequest, GetWorkspaceResponse>(
                request,
                request => client.GetWorkspace(request),
                response => targetStates.Contains(response.Workspace.LifecycleState.Value),
                targetStates.Contains(Workspace.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetWorkspaceRequest, GetWorkspaceResponse>(config, agent);
        }
    }
}
