/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
using Oci.Common.Model;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.RoverService.Requests;
using Oci.RoverService.Responses;

namespace Oci.RoverService
{
    /// <summary>Service client instance for Shape.</summary>
    public class ShapeClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20201210";

        public ShapePaginators Paginators { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public ShapeClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "SHAPE",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://rover.{region}.oci.{secondLevelDomain}"
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
            Paginators = new ShapePaginators(this);
        }

        /// <summary>
        /// Returns a list of Shapes.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/rover/ListShapes.cs.html">here</a> to see an example of how to use ListShapes API.</example>
        public async Task<ListShapesResponse> ListShapes(ListShapesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called listShapes");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/shapes".Trim('/')));
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
                    ServiceName = "Shape",
                    OperationName = "ListShapes",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/rover/20201210/ShapeSummary/ListShapes",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<ListShapesResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"ListShapes failed with error: {e.Message}");
                throw;
            }
        }

    }
}
