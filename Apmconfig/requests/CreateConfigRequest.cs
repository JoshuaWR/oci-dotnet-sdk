/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ApmconfigService.Models;

namespace Oci.ApmconfigService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/apmconfig/CreateConfig.cs.html">here</a> to see an example of how to use CreateConfig request.
    /// </example>
    public class CreateConfigRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The APM Domain ID the request is intended for.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApmDomainId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "apmDomainId")]
        public string ApmDomainId { get; set; }
        
        /// <value>
        /// The configuration details of the new item.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateConfigDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public CreateConfigDetails CreateConfigDetails { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Indicates that the request is a dry run, if set to \"true\". A dry run request does not modify the
        /// configuration item details and is used only to perform validation on the submitted data.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-dry-run")]
        public string OpcDryRun { get; set; }
    }
}
