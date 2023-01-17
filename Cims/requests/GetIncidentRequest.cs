/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CimsService.Models;

namespace Oci.CimsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/cims/GetIncident.cs.html">here</a> to see an example of how to use GetIncident request.
    /// </example>
    public class GetIncidentRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique identifier for the support ticket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncidentKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "incidentKey")]
        public string IncidentKey { get; set; }
        
        /// <value>
        /// The Customer Support Identifier associated with the support account.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Csi is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "csi")]
        public string Csi { get; set; }
        
        /// <value>
        /// User OCID for Oracle Identity Cloud Service (IDCS) users who also have a federated Oracle Cloud Infrastructure account.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ocid is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "ocid")]
        public string Ocid { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The region of the tenancy.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "homeregion")]
        public string Homeregion { get; set; }
        
        /// <value>
        /// The kind of support request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "problem-type")]
        public string ProblemType { get; set; }
    }
}
