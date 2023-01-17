/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.OdaService.Models;
using Oci.OdaService.Requests;
using Oci.OdaService.Responses;

namespace Oci.OdaService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Management.
    /// </summary>
    public class ManagementWaiters
    {
        private readonly ManagementClient client;

        public  ManagementWaiters(ManagementClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAuthenticationProviderRequest, GetAuthenticationProviderResponse> ForAuthenticationProvider(GetAuthenticationProviderRequest request, params LifecycleState[] targetStates)
        {
            return this.ForAuthenticationProvider(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetAuthenticationProviderRequest, GetAuthenticationProviderResponse> ForAuthenticationProvider(GetAuthenticationProviderRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetAuthenticationProviderRequest, GetAuthenticationProviderResponse>(
                request,
                request => client.GetAuthenticationProvider(request),
                response => targetStates.Contains(response.AuthenticationProvider.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetAuthenticationProviderRequest, GetAuthenticationProviderResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetChannelRequest, GetChannelResponse> ForChannel(GetChannelRequest request, params LifecycleState[] targetStates)
        {
            return this.ForChannel(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetChannelRequest, GetChannelResponse> ForChannel(GetChannelRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetChannelRequest, GetChannelResponse>(
                request,
                request => client.GetChannel(request),
                response => targetStates.Contains(response.Channel.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetChannelRequest, GetChannelResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDigitalAssistantRequest, GetDigitalAssistantResponse> ForDigitalAssistant(GetDigitalAssistantRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDigitalAssistant(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDigitalAssistantRequest, GetDigitalAssistantResponse> ForDigitalAssistant(GetDigitalAssistantRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDigitalAssistantRequest, GetDigitalAssistantResponse>(
                request,
                request => client.GetDigitalAssistant(request),
                response => targetStates.Contains(response.DigitalAssistant.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDigitalAssistantRequest, GetDigitalAssistantResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDigitalAssistantParameterRequest, GetDigitalAssistantParameterResponse> ForDigitalAssistantParameter(GetDigitalAssistantParameterRequest request, params LifecycleState[] targetStates)
        {
            return this.ForDigitalAssistantParameter(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetDigitalAssistantParameterRequest, GetDigitalAssistantParameterResponse> ForDigitalAssistantParameter(GetDigitalAssistantParameterRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetDigitalAssistantParameterRequest, GetDigitalAssistantParameterResponse>(
                request,
                request => client.GetDigitalAssistantParameter(request),
                response => targetStates.Contains(response.DigitalAssistantParameter.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetDigitalAssistantParameterRequest, GetDigitalAssistantParameterResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSkillRequest, GetSkillResponse> ForSkill(GetSkillRequest request, params LifecycleState[] targetStates)
        {
            return this.ForSkill(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSkillRequest, GetSkillResponse> ForSkill(GetSkillRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetSkillRequest, GetSkillResponse>(
                request,
                request => client.GetSkill(request),
                response => targetStates.Contains(response.Skill.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetSkillRequest, GetSkillResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSkillParameterRequest, GetSkillParameterResponse> ForSkillParameter(GetSkillParameterRequest request, params LifecycleState[] targetStates)
        {
            return this.ForSkillParameter(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSkillParameterRequest, GetSkillParameterResponse> ForSkillParameter(GetSkillParameterRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetSkillParameterRequest, GetSkillParameterResponse>(
                request,
                request => client.GetSkillParameter(request),
                response => targetStates.Contains(response.SkillParameter.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetSkillParameterRequest, GetSkillParameterResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTranslatorRequest, GetTranslatorResponse> ForTranslator(GetTranslatorRequest request, params LifecycleState[] targetStates)
        {
            return this.ForTranslator(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTranslatorRequest, GetTranslatorResponse> ForTranslator(GetTranslatorRequest request, WaiterConfiguration config, params LifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetTranslatorRequest, GetTranslatorResponse>(
                request,
                request => client.GetTranslator(request),
                response => targetStates.Contains(response.Translator.LifecycleState.Value),
                targetStates.Contains(LifecycleState.Deleted)
            );
            return new Waiter<GetTranslatorRequest, GetTranslatorResponse>(config, agent);
        }
    }
}
