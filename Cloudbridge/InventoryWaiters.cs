/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.CloudbridgeService.Models;
using Oci.CloudbridgeService.Requests;
using Oci.CloudbridgeService.Responses;

namespace Oci.CloudbridgeService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Inventory.
    /// </summary>
    public class InventoryWaiters
    {
        private readonly InventoryClient client;

        public  InventoryWaiters(InventoryClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAssetRequest, GetAssetResponse> ForAsset(GetAssetRequest request, params Asset.LifecycleStateEnum[] targetStates)
        {
            return this.ForAsset(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAssetRequest, GetAssetResponse> ForAsset(GetAssetRequest request, WaiterConfiguration config, params Asset.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetAssetRequest, GetAssetResponse>(
                request,
                request => client.GetAsset(request),
                response => targetStates.Contains(response.Asset.LifecycleState.Value),
                targetStates.Contains(Asset.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetAssetRequest, GetAssetResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInventoryRequest, GetInventoryResponse> ForInventory(GetInventoryRequest request, params Inventory.LifecycleStateEnum[] targetStates)
        {
            return this.ForInventory(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInventoryRequest, GetInventoryResponse> ForInventory(GetInventoryRequest request, WaiterConfiguration config, params Inventory.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetInventoryRequest, GetInventoryResponse>(
                request,
                request => client.GetInventory(request),
                response => targetStates.Contains(response.Inventory.LifecycleState.Value),
                targetStates.Contains(Inventory.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetInventoryRequest, GetInventoryResponse>(config, agent);
        }
    }
}
