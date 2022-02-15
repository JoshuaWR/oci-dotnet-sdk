/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.AivisionService.Models;
using Oci.AivisionService.Requests;
using Oci.AivisionService.Responses;

namespace Oci.AivisionService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of AIServiceVision.
    /// </summary>
    public class AIServiceVisionWaiters
    {
        private readonly AIServiceVisionClient client;

        public  AIServiceVisionWaiters(AIServiceVisionClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDocumentJobRequest, GetDocumentJobResponse> ForDocumentJob(GetDocumentJobRequest request, params DocumentJob.LifecycleStateEnum[] targetStates)
        {
            return this.ForDocumentJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDocumentJobRequest, GetDocumentJobResponse> ForDocumentJob(GetDocumentJobRequest request, WaiterConfiguration config, params DocumentJob.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDocumentJobRequest, GetDocumentJobResponse>(
                request,
                request => client.GetDocumentJob(request),
                response => targetStates.Contains(response.DocumentJob.LifecycleState.Value)
            );
            return new Waiter<GetDocumentJobRequest, GetDocumentJobResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetImageJobRequest, GetImageJobResponse> ForImageJob(GetImageJobRequest request, params ImageJob.LifecycleStateEnum[] targetStates)
        {
            return this.ForImageJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetImageJobRequest, GetImageJobResponse> ForImageJob(GetImageJobRequest request, WaiterConfiguration config, params ImageJob.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetImageJobRequest, GetImageJobResponse>(
                request,
                request => client.GetImageJob(request),
                response => targetStates.Contains(response.ImageJob.LifecycleState.Value)
            );
            return new Waiter<GetImageJobRequest, GetImageJobResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetModelRequest, GetModelResponse> ForModel(GetModelRequest request, params Model.LifecycleStateEnum[] targetStates)
        {
            return this.ForModel(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetModelRequest, GetModelResponse> ForModel(GetModelRequest request, WaiterConfiguration config, params Model.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetModelRequest, GetModelResponse>(
                request,
                request => client.GetModel(request),
                response => targetStates.Contains(response.Model.LifecycleState.Value),
                targetStates.Contains(Model.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetModelRequest, GetModelResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProjectRequest, GetProjectResponse> ForProject(GetProjectRequest request, params Project.LifecycleStateEnum[] targetStates)
        {
            return this.ForProject(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProjectRequest, GetProjectResponse> ForProject(GetProjectRequest request, WaiterConfiguration config, params Project.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetProjectRequest, GetProjectResponse>(
                request,
                request => client.GetProject(request),
                response => targetStates.Contains(response.Project.LifecycleState.Value),
                targetStates.Contains(Project.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetProjectRequest, GetProjectResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, params OperationStatus[] targetStates)
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
        public Waiter<GetWorkRequestRequest, GetWorkRequestResponse> ForWorkRequest(GetWorkRequestRequest request, WaiterConfiguration config, params OperationStatus[] targetStates)
        {
            var agent = new WaiterAgent<GetWorkRequestRequest, GetWorkRequestResponse>(
                request,
                request => client.GetWorkRequest(request),
                response => targetStates.Contains(response.WorkRequest.Status.Value)
            );
            return new Waiter<GetWorkRequestRequest, GetWorkRequestResponse>(config, agent);
        }
    }
}
