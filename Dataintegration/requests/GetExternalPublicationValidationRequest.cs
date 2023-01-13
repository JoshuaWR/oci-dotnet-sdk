/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DataintegrationService.Models;

namespace Oci.DataintegrationService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/dataintegration/GetExternalPublicationValidation.cs.html">here</a> to see an example of how to use GetExternalPublicationValidation request.
    /// </example>
    public class GetExternalPublicationValidationRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The workspace ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkspaceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "workspaceId")]
        public string WorkspaceId { get; set; }
        
        /// <value>
        /// The task key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "taskKey")]
        public string TaskKey { get; set; }
        
        /// <value>
        /// The external published object key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExternalPublicationValidationKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "externalPublicationValidationKey")]
        public string ExternalPublicationValidationKey { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If
        /// you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
