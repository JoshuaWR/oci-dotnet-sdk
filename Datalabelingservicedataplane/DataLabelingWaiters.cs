/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DatalabelingservicedataplaneService.Models;
using Oci.DatalabelingservicedataplaneService.Requests;
using Oci.DatalabelingservicedataplaneService.Responses;

namespace Oci.DatalabelingservicedataplaneService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of DataLabeling.
    /// </summary>
    public class DataLabelingWaiters
    {
        private readonly DataLabelingClient client;

        public  DataLabelingWaiters(DataLabelingClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAnnotationRequest, GetAnnotationResponse> ForAnnotation(GetAnnotationRequest request, params Annotation.LifecycleStateEnum[] targetStates)
        {
            return this.ForAnnotation(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAnnotationRequest, GetAnnotationResponse> ForAnnotation(GetAnnotationRequest request, WaiterConfiguration config, params Annotation.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetAnnotationRequest, GetAnnotationResponse>(
                request,
                request => client.GetAnnotation(request),
                response => targetStates.Contains(response.Annotation.LifecycleState.Value),
                targetStates.Contains(Annotation.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetAnnotationRequest, GetAnnotationResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDatasetRequest, GetDatasetResponse> ForDataset(GetDatasetRequest request, params Dataset.LifecycleStateEnum[] targetStates)
        {
            return this.ForDataset(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDatasetRequest, GetDatasetResponse> ForDataset(GetDatasetRequest request, WaiterConfiguration config, params Dataset.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetDatasetRequest, GetDatasetResponse>(
                request,
                request => client.GetDataset(request),
                response => targetStates.Contains(response.Dataset.LifecycleState.Value),
                targetStates.Contains(Dataset.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetDatasetRequest, GetDatasetResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRecordRequest, GetRecordResponse> ForRecord(GetRecordRequest request, params Record.LifecycleStateEnum[] targetStates)
        {
            return this.ForRecord(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetRecordRequest, GetRecordResponse> ForRecord(GetRecordRequest request, WaiterConfiguration config, params Record.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetRecordRequest, GetRecordResponse>(
                request,
                request => client.GetRecord(request),
                response => targetStates.Contains(response.Record.LifecycleState.Value),
                targetStates.Contains(Record.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetRecordRequest, GetRecordResponse>(config, agent);
        }
    }
}
