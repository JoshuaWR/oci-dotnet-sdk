/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Collections.Generic;
using System.Threading;
using Oci.OsmanagementhubService.Requests;
using Oci.OsmanagementhubService.Responses;
using Oci.OsmanagementhubService.Models;

namespace Oci.OsmanagementhubService
{
    /// <summary>
    /// Collection of helper methods that can be used to provide an enumerator interface
    /// to any list operations of ManagedInstanceGroup where multiple pages of data may be fetched.
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
    public class ManagedInstanceGroupPaginators
    {
        private readonly ManagedInstanceGroupClient client;

        public ManagedInstanceGroupPaginators(ManagedInstanceGroupClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListManagedInstanceGroupAvailableModules operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListManagedInstanceGroupAvailableModulesResponse> ListManagedInstanceGroupAvailableModulesResponseEnumerator(ListManagedInstanceGroupAvailableModulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListManagedInstanceGroupAvailableModulesRequest, ListManagedInstanceGroupAvailableModulesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupAvailableModules(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ManagedInstanceGroupAvailableModuleSummary objects
        /// contained in responses from the ListManagedInstanceGroupAvailableModules operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ManagedInstanceGroupAvailableModuleSummary> ListManagedInstanceGroupAvailableModulesRecordEnumerator(ListManagedInstanceGroupAvailableModulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListManagedInstanceGroupAvailableModulesRequest, ListManagedInstanceGroupAvailableModulesResponse, ManagedInstanceGroupAvailableModuleSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupAvailableModules(request, retryConfiguration, cancellationToken),
                response => response.ManagedInstanceGroupAvailableModuleCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListManagedInstanceGroupAvailablePackages operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListManagedInstanceGroupAvailablePackagesResponse> ListManagedInstanceGroupAvailablePackagesResponseEnumerator(ListManagedInstanceGroupAvailablePackagesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListManagedInstanceGroupAvailablePackagesRequest, ListManagedInstanceGroupAvailablePackagesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupAvailablePackages(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ManagedInstanceGroupAvailablePackageSummary objects
        /// contained in responses from the ListManagedInstanceGroupAvailablePackages operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ManagedInstanceGroupAvailablePackageSummary> ListManagedInstanceGroupAvailablePackagesRecordEnumerator(ListManagedInstanceGroupAvailablePackagesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListManagedInstanceGroupAvailablePackagesRequest, ListManagedInstanceGroupAvailablePackagesResponse, ManagedInstanceGroupAvailablePackageSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupAvailablePackages(request, retryConfiguration, cancellationToken),
                response => response.ManagedInstanceGroupAvailablePackageCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListManagedInstanceGroupAvailableSoftwareSources operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListManagedInstanceGroupAvailableSoftwareSourcesResponse> ListManagedInstanceGroupAvailableSoftwareSourcesResponseEnumerator(ListManagedInstanceGroupAvailableSoftwareSourcesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListManagedInstanceGroupAvailableSoftwareSourcesRequest, ListManagedInstanceGroupAvailableSoftwareSourcesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupAvailableSoftwareSources(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the AvailableSoftwareSourceSummary objects
        /// contained in responses from the ListManagedInstanceGroupAvailableSoftwareSources operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<AvailableSoftwareSourceSummary> ListManagedInstanceGroupAvailableSoftwareSourcesRecordEnumerator(ListManagedInstanceGroupAvailableSoftwareSourcesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListManagedInstanceGroupAvailableSoftwareSourcesRequest, ListManagedInstanceGroupAvailableSoftwareSourcesResponse, AvailableSoftwareSourceSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupAvailableSoftwareSources(request, retryConfiguration, cancellationToken),
                response => response.AvailableSoftwareSourceCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListManagedInstanceGroupInstalledPackages operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListManagedInstanceGroupInstalledPackagesResponse> ListManagedInstanceGroupInstalledPackagesResponseEnumerator(ListManagedInstanceGroupInstalledPackagesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListManagedInstanceGroupInstalledPackagesRequest, ListManagedInstanceGroupInstalledPackagesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupInstalledPackages(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ManagedInstanceGroupInstalledPackageSummary objects
        /// contained in responses from the ListManagedInstanceGroupInstalledPackages operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ManagedInstanceGroupInstalledPackageSummary> ListManagedInstanceGroupInstalledPackagesRecordEnumerator(ListManagedInstanceGroupInstalledPackagesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListManagedInstanceGroupInstalledPackagesRequest, ListManagedInstanceGroupInstalledPackagesResponse, ManagedInstanceGroupInstalledPackageSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupInstalledPackages(request, retryConfiguration, cancellationToken),
                response => response.ManagedInstanceGroupInstalledPackageCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListManagedInstanceGroupModules operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListManagedInstanceGroupModulesResponse> ListManagedInstanceGroupModulesResponseEnumerator(ListManagedInstanceGroupModulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListManagedInstanceGroupModulesRequest, ListManagedInstanceGroupModulesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupModules(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ManagedInstanceGroupModuleSummary objects
        /// contained in responses from the ListManagedInstanceGroupModules operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ManagedInstanceGroupModuleSummary> ListManagedInstanceGroupModulesRecordEnumerator(ListManagedInstanceGroupModulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListManagedInstanceGroupModulesRequest, ListManagedInstanceGroupModulesResponse, ManagedInstanceGroupModuleSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroupModules(request, retryConfiguration, cancellationToken),
                response => response.ManagedInstanceGroupModuleCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListManagedInstanceGroups operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListManagedInstanceGroupsResponse> ListManagedInstanceGroupsResponseEnumerator(ListManagedInstanceGroupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListManagedInstanceGroupsRequest, ListManagedInstanceGroupsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroups(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the ManagedInstanceGroupSummary objects
        /// contained in responses from the ListManagedInstanceGroups operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ManagedInstanceGroupSummary> ListManagedInstanceGroupsRecordEnumerator(ListManagedInstanceGroupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListManagedInstanceGroupsRequest, ListManagedInstanceGroupsResponse, ManagedInstanceGroupSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListManagedInstanceGroups(request, retryConfiguration, cancellationToken),
                response => response.ManagedInstanceGroupCollection.Items
            );
        }

    }
}