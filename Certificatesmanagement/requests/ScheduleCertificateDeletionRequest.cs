/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CertificatesmanagementService.Models;

namespace Oci.CertificatesmanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/certificatesmanagement/ScheduleCertificateDeletion.cs.html">here</a> to see an example of how to use ScheduleCertificateDeletion request.
    /// </example>
    public class ScheduleCertificateDeletionRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "certificateId")]
        public string CertificateId { get; set; }
        
        /// <value>
        /// The details of the request to schedule a certificate deletion.
        /// This sets the lifecycle state of the certificate to `PENDING_DELETION` and then deletes it
        /// after the specified retention period ends.
        /// You can subsequently use `GetCertificate` to determine the current deletion status.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduleCertificateDeletionDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ScheduleCertificateDeletionDetails ScheduleCertificateDeletionDetails { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If provided, the returned request ID
        /// will include this value. Otherwise, a random request ID will be
        /// generated by the service.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call for a
        /// resource, set the `if-match` parameter to the value of the etag from a
        /// previous GET or POST response for that resource. The resource will be
        /// updated or deleted only if the etag you provide matches the resource's
        /// current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
    }
}