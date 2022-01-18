/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.CoreService.Models;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;

namespace Oci.CoreService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Blockstorage.
    /// </summary>
    public class BlockstorageWaiters
    {
        private readonly BlockstorageClient client;
        private readonly Oci.WorkrequestsService.WorkRequestClient workRequestClient;

        public  BlockstorageWaiters(BlockstorageClient client, Oci.WorkrequestsService.WorkRequestClient workRequestClient)
        {
            this.client = client;
            this.workRequestClient = workRequestClient;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="statuses">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<CopyBootVolumeBackupRequest, CopyBootVolumeBackupResponse> ForCopyBootVolumeBackup(CopyBootVolumeBackupRequest request, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForCopyBootVolumeBackup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<CopyBootVolumeBackupRequest, CopyBootVolumeBackupResponse> ForCopyBootVolumeBackup(CopyBootVolumeBackupRequest request, WaiterConfiguration config, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return new Waiter<CopyBootVolumeBackupRequest, CopyBootVolumeBackupResponse>(() =>
            {
                var response = client.CopyBootVolumeBackup(request).Result;
                var getWorkRequestRequest = new Oci.WorkrequestsService.Requests.GetWorkRequestRequest
                {
                    WorkRequestId = response.OpcWorkRequestId
                };
                workRequestClient.Waiters.ForWorkRequest(getWorkRequestRequest, config, targetStates).Execute();
                return response;
            });
        }
        
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="statuses">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<CopyVolumeBackupRequest, CopyVolumeBackupResponse> ForCopyVolumeBackup(CopyVolumeBackupRequest request, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return this.ForCopyVolumeBackup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<CopyVolumeBackupRequest, CopyVolumeBackupResponse> ForCopyVolumeBackup(CopyVolumeBackupRequest request, WaiterConfiguration config, params WorkrequestsService.Models.WorkRequest.StatusEnum[] targetStates)
        {
            return new Waiter<CopyVolumeBackupRequest, CopyVolumeBackupResponse>(() =>
            {
                var response = client.CopyVolumeBackup(request).Result;
                var getWorkRequestRequest = new Oci.WorkrequestsService.Requests.GetWorkRequestRequest
                {
                    WorkRequestId = response.OpcWorkRequestId
                };
                workRequestClient.Waiters.ForWorkRequest(getWorkRequestRequest, config, targetStates).Execute();
                return response;
            });
        }
        
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBlockVolumeReplicaRequest, GetBlockVolumeReplicaResponse> ForBlockVolumeReplica(GetBlockVolumeReplicaRequest request, params BlockVolumeReplica.LifecycleStateEnum[] targetStates)
        {
            return this.ForBlockVolumeReplica(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBlockVolumeReplicaRequest, GetBlockVolumeReplicaResponse> ForBlockVolumeReplica(GetBlockVolumeReplicaRequest request, WaiterConfiguration config, params BlockVolumeReplica.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetBlockVolumeReplicaRequest, GetBlockVolumeReplicaResponse>(
                request,
                request => client.GetBlockVolumeReplica(request),
                response => targetStates.Contains(response.BlockVolumeReplica.LifecycleState.Value),
                targetStates.Contains(BlockVolumeReplica.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetBlockVolumeReplicaRequest, GetBlockVolumeReplicaResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBootVolumeRequest, GetBootVolumeResponse> ForBootVolume(GetBootVolumeRequest request, params BootVolume.LifecycleStateEnum[] targetStates)
        {
            return this.ForBootVolume(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBootVolumeRequest, GetBootVolumeResponse> ForBootVolume(GetBootVolumeRequest request, WaiterConfiguration config, params BootVolume.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetBootVolumeRequest, GetBootVolumeResponse>(
                request,
                request => client.GetBootVolume(request),
                response => targetStates.Contains(response.BootVolume.LifecycleState.Value),
                targetStates.Contains(BootVolume.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetBootVolumeRequest, GetBootVolumeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBootVolumeBackupRequest, GetBootVolumeBackupResponse> ForBootVolumeBackup(GetBootVolumeBackupRequest request, params BootVolumeBackup.LifecycleStateEnum[] targetStates)
        {
            return this.ForBootVolumeBackup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBootVolumeBackupRequest, GetBootVolumeBackupResponse> ForBootVolumeBackup(GetBootVolumeBackupRequest request, WaiterConfiguration config, params BootVolumeBackup.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetBootVolumeBackupRequest, GetBootVolumeBackupResponse>(
                request,
                request => client.GetBootVolumeBackup(request),
                response => targetStates.Contains(response.BootVolumeBackup.LifecycleState.Value),
                targetStates.Contains(BootVolumeBackup.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetBootVolumeBackupRequest, GetBootVolumeBackupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBootVolumeReplicaRequest, GetBootVolumeReplicaResponse> ForBootVolumeReplica(GetBootVolumeReplicaRequest request, params BootVolumeReplica.LifecycleStateEnum[] targetStates)
        {
            return this.ForBootVolumeReplica(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetBootVolumeReplicaRequest, GetBootVolumeReplicaResponse> ForBootVolumeReplica(GetBootVolumeReplicaRequest request, WaiterConfiguration config, params BootVolumeReplica.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetBootVolumeReplicaRequest, GetBootVolumeReplicaResponse>(
                request,
                request => client.GetBootVolumeReplica(request),
                response => targetStates.Contains(response.BootVolumeReplica.LifecycleState.Value),
                targetStates.Contains(BootVolumeReplica.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetBootVolumeReplicaRequest, GetBootVolumeReplicaResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeRequest, GetVolumeResponse> ForVolume(GetVolumeRequest request, params Volume.LifecycleStateEnum[] targetStates)
        {
            return this.ForVolume(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeRequest, GetVolumeResponse> ForVolume(GetVolumeRequest request, WaiterConfiguration config, params Volume.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetVolumeRequest, GetVolumeResponse>(
                request,
                request => client.GetVolume(request),
                response => targetStates.Contains(response.Volume.LifecycleState.Value),
                targetStates.Contains(Volume.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetVolumeRequest, GetVolumeResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeBackupRequest, GetVolumeBackupResponse> ForVolumeBackup(GetVolumeBackupRequest request, params VolumeBackup.LifecycleStateEnum[] targetStates)
        {
            return this.ForVolumeBackup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeBackupRequest, GetVolumeBackupResponse> ForVolumeBackup(GetVolumeBackupRequest request, WaiterConfiguration config, params VolumeBackup.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetVolumeBackupRequest, GetVolumeBackupResponse>(
                request,
                request => client.GetVolumeBackup(request),
                response => targetStates.Contains(response.VolumeBackup.LifecycleState.Value),
                targetStates.Contains(VolumeBackup.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetVolumeBackupRequest, GetVolumeBackupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeGroupRequest, GetVolumeGroupResponse> ForVolumeGroup(GetVolumeGroupRequest request, params VolumeGroup.LifecycleStateEnum[] targetStates)
        {
            return this.ForVolumeGroup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeGroupRequest, GetVolumeGroupResponse> ForVolumeGroup(GetVolumeGroupRequest request, WaiterConfiguration config, params VolumeGroup.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetVolumeGroupRequest, GetVolumeGroupResponse>(
                request,
                request => client.GetVolumeGroup(request),
                response => targetStates.Contains(response.VolumeGroup.LifecycleState.Value),
                targetStates.Contains(VolumeGroup.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetVolumeGroupRequest, GetVolumeGroupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeGroupBackupRequest, GetVolumeGroupBackupResponse> ForVolumeGroupBackup(GetVolumeGroupBackupRequest request, params VolumeGroupBackup.LifecycleStateEnum[] targetStates)
        {
            return this.ForVolumeGroupBackup(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeGroupBackupRequest, GetVolumeGroupBackupResponse> ForVolumeGroupBackup(GetVolumeGroupBackupRequest request, WaiterConfiguration config, params VolumeGroupBackup.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetVolumeGroupBackupRequest, GetVolumeGroupBackupResponse>(
                request,
                request => client.GetVolumeGroupBackup(request),
                response => targetStates.Contains(response.VolumeGroupBackup.LifecycleState.Value),
                targetStates.Contains(VolumeGroupBackup.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetVolumeGroupBackupRequest, GetVolumeGroupBackupResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeGroupReplicaRequest, GetVolumeGroupReplicaResponse> ForVolumeGroupReplica(GetVolumeGroupReplicaRequest request, params VolumeGroupReplica.LifecycleStateEnum[] targetStates)
        {
            return this.ForVolumeGroupReplica(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetVolumeGroupReplicaRequest, GetVolumeGroupReplicaResponse> ForVolumeGroupReplica(GetVolumeGroupReplicaRequest request, WaiterConfiguration config, params VolumeGroupReplica.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetVolumeGroupReplicaRequest, GetVolumeGroupReplicaResponse>(
                request,
                request => client.GetVolumeGroupReplica(request),
                response => targetStates.Contains(response.VolumeGroupReplica.LifecycleState.Value),
                targetStates.Contains(VolumeGroupReplica.LifecycleStateEnum.Terminated)
            );
            return new Waiter<GetVolumeGroupReplicaRequest, GetVolumeGroupReplicaResponse>(config, agent);
        }
    }
}
