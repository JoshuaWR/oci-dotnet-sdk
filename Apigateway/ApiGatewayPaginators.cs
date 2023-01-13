/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Collections.Generic;
using System.Threading;
using Oci.ApigatewayService.Requests;
using Oci.ApigatewayService.Responses;
using Oci.ApigatewayService.Models;

namespace Oci.ApigatewayService
{
    /// <summary>
    /// Collection of helper methods that can be used to provide an enumerator interface
    /// to any list operations of ApiGateway where multiple pages of data may be fetched.
    /// Two styles of enumerators are supported:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Enumerating over the Response objects returned by the list operation. These are referred to as ResponseEnumerators, and the methods are suffixed with ResponseEnumerator. For example: listUsersResponseEnumerator.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// Enumerating over the resources/records being listed. These are referred to as RecordEnumerators, and the methods are suffixed with RecordEnumerator. For example: listUsersRecordEnumerator.
    /// </description>
    /// </item>
    /// </list>
    /// These enumerators abstract away the need to write code to manually handle pagination via looping and using the page tokens.
    /// They will automatically fetch more data from the service when required.
    /// <br/>
    /// <br/>
    /// As an example, if we were using the ListUsers operation in IdentityService, then the iterator returned by calling a
    /// ResponseEnumerator method would iterate over the ListUsersResponse objects returned by each ListUsers call, whereas the enumerables
    /// returned by calling a RecordEnumerator method would iterate over the User records and we don't have to deal with ListUsersResponse objects at all.
    /// In either case, pagination will be automatically handled so we can iterate until there are no more responses or no more resources/records available.
    /// </summary>
    public class ApiGatewayPaginators
    {
        private readonly ApiGatewayClient client;

        public ApiGatewayPaginators(ApiGatewayClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListApis operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListApisResponse> ListApisResponseEnumerator(ListApisRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListApisRequest, ListApisResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListApis(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ApiSummary objects
        /// contained in responses from the ListApis operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ApiSummary> ListApisRecordEnumerator(ListApisRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListApisRequest, ListApisResponse, ApiSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListApis(request, retryConfiguration, cancellationToken),
                response => response.ApiCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListCertificates operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListCertificatesResponse> ListCertificatesResponseEnumerator(ListCertificatesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListCertificatesRequest, ListCertificatesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListCertificates(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the CertificateSummary objects
        /// contained in responses from the ListCertificates operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<CertificateSummary> ListCertificatesRecordEnumerator(ListCertificatesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListCertificatesRequest, ListCertificatesResponse, CertificateSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListCertificates(request, retryConfiguration, cancellationToken),
                response => response.CertificateCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListSdkLanguageTypes operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListSdkLanguageTypesResponse> ListSdkLanguageTypesResponseEnumerator(ListSdkLanguageTypesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListSdkLanguageTypesRequest, ListSdkLanguageTypesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSdkLanguageTypes(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the SdkLanguageTypeSummary objects
        /// contained in responses from the ListSdkLanguageTypes operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<SdkLanguageTypeSummary> ListSdkLanguageTypesRecordEnumerator(ListSdkLanguageTypesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListSdkLanguageTypesRequest, ListSdkLanguageTypesResponse, SdkLanguageTypeSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSdkLanguageTypes(request, retryConfiguration, cancellationToken),
                response => response.SdkLanguageTypeCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListSdks operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListSdksResponse> ListSdksResponseEnumerator(ListSdksRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListSdksRequest, ListSdksResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSdks(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the SdkSummary objects
        /// contained in responses from the ListSdks operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<SdkSummary> ListSdksRecordEnumerator(ListSdksRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListSdksRequest, ListSdksResponse, SdkSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListSdks(request, retryConfiguration, cancellationToken),
                response => response.SdkCollection.Items
            );
        }

    }
}
