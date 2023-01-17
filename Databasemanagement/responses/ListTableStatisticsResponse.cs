/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Responses
{
    public class ListTableStatisticsResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }

        /// <value>
        /// The returned TableStatisticsCollection instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public TableStatisticsCollection TableStatisticsCollection { get; set; }

    }
}
