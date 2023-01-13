/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.FusionappsService.Models;
using Oci.FusionappsService.Requests;
using Oci.FusionappsService.Responses;

namespace Oci.FusionappsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of FusionApplications.
    /// </summary>
    public class FusionApplicationsWaiters
    {
        private readonly FusionApplicationsClient client;

        public  FusionApplicationsWaiters(FusionApplicationsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDataMaskingActivityRequest, GetDataMaskingActivityResponse> ForDataMaskingActivity(GetDataMaskingActivityRequest request, params DataMaskingActivity.LifecycleStateEnum[] targetStates)
        {
            return this.ForDataMaskingActivity(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDataMaskingActivityRequest, GetDataMaskingActivityResponse> ForDataMaskingActivity(GetDataMaskingActivityRequest request, WaiterConfiguration config, params DataMaskingActivity.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDataMaskingActivityRequest, GetDataMaskingActivityResponse>(
                request,
                request => client.GetDataMaskingActivity(request),
                response => targetStates.Contains(response.DataMaskingActivity.LifecycleState.Value)
            );
            return new Waiter<GetDataMaskingActivityRequest, GetDataMaskingActivityResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFusionEnvironmentRequest, GetFusionEnvironmentResponse> ForFusionEnvironment(GetFusionEnvironmentRequest request, params FusionEnvironment.LifecycleStateEnum[] targetStates)
        {
            return this.ForFusionEnvironment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFusionEnvironmentRequest, GetFusionEnvironmentResponse> ForFusionEnvironment(GetFusionEnvironmentRequest request, WaiterConfiguration config, params FusionEnvironment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetFusionEnvironmentRequest, GetFusionEnvironmentResponse>(
                request,
                request => client.GetFusionEnvironment(request),
                response => targetStates.Contains(response.FusionEnvironment.LifecycleState.Value),
                targetStates.Contains(FusionEnvironment.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetFusionEnvironmentRequest, GetFusionEnvironmentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse> ForFusionEnvironmentFamily(GetFusionEnvironmentFamilyRequest request, params FusionEnvironmentFamily.LifecycleStateEnum[] targetStates)
        {
            return this.ForFusionEnvironmentFamily(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse> ForFusionEnvironmentFamily(GetFusionEnvironmentFamilyRequest request, WaiterConfiguration config, params FusionEnvironmentFamily.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse>(
                request,
                request => client.GetFusionEnvironmentFamily(request),
                response => targetStates.Contains(response.FusionEnvironmentFamily.LifecycleState.Value),
                targetStates.Contains(FusionEnvironmentFamily.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRefreshActivityRequest, GetRefreshActivityResponse> ForRefreshActivity(GetRefreshActivityRequest request, params RefreshActivity.LifecycleStateEnum[] targetStates)
        {
            return this.ForRefreshActivity(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRefreshActivityRequest, GetRefreshActivityResponse> ForRefreshActivity(GetRefreshActivityRequest request, WaiterConfiguration config, params RefreshActivity.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetRefreshActivityRequest, GetRefreshActivityResponse>(
                request,
                request => client.GetRefreshActivity(request),
                response => targetStates.Contains(response.RefreshActivity.LifecycleState.Value)
            );
            return new Waiter<GetRefreshActivityRequest, GetRefreshActivityResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledActivityRequest, GetScheduledActivityResponse> ForScheduledActivity(GetScheduledActivityRequest request, params ScheduledActivity.LifecycleStateEnum[] targetStates)
        {
            return this.ForScheduledActivity(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetScheduledActivityRequest, GetScheduledActivityResponse> ForScheduledActivity(GetScheduledActivityRequest request, WaiterConfiguration config, params ScheduledActivity.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetScheduledActivityRequest, GetScheduledActivityResponse>(
                request,
                request => client.GetScheduledActivity(request),
                response => targetStates.Contains(response.ScheduledActivity.LifecycleState.Value)
            );
            return new Waiter<GetScheduledActivityRequest, GetScheduledActivityResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetServiceAttachmentRequest, GetServiceAttachmentResponse> ForServiceAttachment(GetServiceAttachmentRequest request, params ServiceAttachment.LifecycleStateEnum[] targetStates)
        {
            return this.ForServiceAttachment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetServiceAttachmentRequest, GetServiceAttachmentResponse> ForServiceAttachment(GetServiceAttachmentRequest request, WaiterConfiguration config, params ServiceAttachment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetServiceAttachmentRequest, GetServiceAttachmentResponse>(
                request,
                request => client.GetServiceAttachment(request),
                response => targetStates.Contains(response.ServiceAttachment.LifecycleState.Value),
                targetStates.Contains(ServiceAttachment.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetServiceAttachmentRequest, GetServiceAttachmentResponse>(config, agent);
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
    }
}
