/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.DeveloperToolConfigurations;
using Oci.Common.Model;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.GenerativeaiagentruntimeService.Requests;
using Oci.GenerativeaiagentruntimeService.Responses;

namespace Oci.GenerativeaiagentruntimeService
{
    /// <summary>Service client instance for GenerativeAiAgentRuntime.</summary>
    public class GenerativeAiAgentRuntimeClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20240531";

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public GenerativeAiAgentRuntimeClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            if (!DeveloperToolConfiguration.IsServiceEnabled("generativeaiagentruntime"))
            {
                throw new ArgumentException("The DeveloperToolConfiguration disabled this service, this behavior is controlled by DeveloperToolConfiguration.OciEnabledServiceSet variable. Please check if your local DeveloperToolConfiguration file has configured the service you're targeting or contact the cloud provider on the availability of this service");
            }
            service = new Service
            {
                ServiceName = "GENERATIVEAIAGENTRUNTIME",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://genai-agent-service.{region}.oci.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
        }

        /// <summary>
        /// Chat on endpoint with provided messages.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/generativeaiagentruntime/Chat.cs.html">here</a> to see an example of how to use Chat API.</example>
        public async Task<ChatResponse> Chat(ChatRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called chat");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/agentEndpoints/{agentEndpointId}/actions/chat".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json, text/event-stream");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "GenerativeAiAgentRuntime",
                    OperationName = "Chat",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/generative-ai-agents-client/20240531/Session/Chat",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<ChatResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"Chat failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// A session represents an interactive conversation initiated by a user through an API to engage with an  agent. It involves a series of exchanges where the user sends queries or prompts, and the agent responds with relevant information, actions, or assistance based on the user&#39;s input. The session persists for the duration of the interaction, maintaining context and continuity to provide coherent and meaningful responses throughout the conversation.Creates an agent session.
        /// &lt;br/&gt;
        /// Use this API to create an agent session.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/generativeaiagentruntime/CreateSession.cs.html">here</a> to see an example of how to use CreateSession API.</example>
        public async Task<CreateSessionResponse> CreateSession(CreateSessionRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called createSession");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/agentEndpoints/{agentEndpointId}/sessions".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "GenerativeAiAgentRuntime",
                    OperationName = "CreateSession",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/generative-ai-agents-client/20240531/Session/CreateSession",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<CreateSessionResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"CreateSession failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Delete a session and all its associated information.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/generativeaiagentruntime/DeleteSession.cs.html">here</a> to see an example of how to use DeleteSession API.</example>
        public async Task<DeleteSessionResponse> DeleteSession(DeleteSessionRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called deleteSession");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/agentEndpoints/{agentEndpointId}/sessions/{sessionId}".Trim('/')));
            HttpMethod method = new HttpMethod("DELETE");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "GenerativeAiAgentRuntime",
                    OperationName = "DeleteSession",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/generative-ai-agents-client/20240531/Session/DeleteSession",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<DeleteSessionResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"DeleteSession failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Return the session resource identified by the session ID.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/generativeaiagentruntime/GetSession.cs.html">here</a> to see an example of how to use GetSession API.</example>
        public async Task<GetSessionResponse> GetSession(GetSessionRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called getSession");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/agentEndpoints/{agentEndpointId}/sessions/{sessionId}".Trim('/')));
            HttpMethod method = new HttpMethod("GET");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "GenerativeAiAgentRuntime",
                    OperationName = "GetSession",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/generative-ai-agents-client/20240531/Session/GetSession",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<GetSessionResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"GetSession failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Update session metadata, including but not limited to description, tags.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/generativeaiagentruntime/UpdateSession.cs.html">here</a> to see an example of how to use UpdateSession API.</example>
        public async Task<UpdateSessionResponse> UpdateSession(UpdateSessionRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called updateSession");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/agentEndpoints/{agentEndpointId}/sessions/{sessionId}".Trim('/')));
            HttpMethod method = new HttpMethod("PUT");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "GenerativeAiAgentRuntime",
                    OperationName = "UpdateSession",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/generative-ai-agents-client/20240531/Session/UpdateSession",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<UpdateSessionResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"UpdateSession failed with error: {e.Message}");
                throw;
            }
        }

    }
}
