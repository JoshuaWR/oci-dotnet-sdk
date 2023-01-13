/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.AidocumentService.Models;
using Oci.AidocumentService.Requests;
using Oci.AidocumentService.Responses;

namespace Oci.AidocumentService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of AIServiceDocument.
    /// </summary>
    public class AIServiceDocumentWaiters
    {
        private readonly AIServiceDocumentClient client;

        public  AIServiceDocumentWaiters(AIServiceDocumentClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProcessorJobRequest, GetProcessorJobResponse> ForProcessorJob(GetProcessorJobRequest request, params ProcessorJob.LifecycleStateEnum[] targetStates)
        {
            return this.ForProcessorJob(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetProcessorJobRequest, GetProcessorJobResponse> ForProcessorJob(GetProcessorJobRequest request, WaiterConfiguration config, params ProcessorJob.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetProcessorJobRequest, GetProcessorJobResponse>(
                request,
                request => client.GetProcessorJob(request),
                response => targetStates.Contains(response.ProcessorJob.LifecycleState.Value)
            );
            return new Waiter<GetProcessorJobRequest, GetProcessorJobResponse>(config, agent);
        }
    }
}
