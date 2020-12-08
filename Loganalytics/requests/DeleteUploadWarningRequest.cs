/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/8.1.0/loganalytics/DeleteUploadWarning.cs.html">here</a> to see an example of how to use DeleteUploadWarning request.
    /// </example>
    public class DeleteUploadWarningRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Logging Analytics namespace used for the request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// Unique internal identifier to refer to upload container
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UploadReference is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "uploadReference")]
        public string UploadReference { get; set; }
        
        /// <value>
        /// Unique internal identifier to refer to upload warning
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WarningReference is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "warningReference")]
        public string WarningReference { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}