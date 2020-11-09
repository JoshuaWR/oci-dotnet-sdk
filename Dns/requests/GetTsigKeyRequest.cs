/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DnsService.Models;

namespace Oci.DnsService.Requests
{
    public class GetTsigKeyRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the target TSIG key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TsigKeyId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "tsigKeyId")]
        public string TsigKeyId { get; set; }
        
        /// <value>
        /// The `If-None-Match` header field makes the request method conditional on
        /// the absence of any current representation of the target resource, when
        /// the field-value is `*`, or having a selected representation with an
        /// entity-tag that does not match any of those listed in the field-value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-None-Match")]
        public string IfNoneMatch { get; set; }
        
        /// <value>
        /// The `If-Modified-Since` header field makes a GET or HEAD request method
        /// conditional on the selected representation's modification date being more
        /// recent than the date provided in the field-value.  Transfer of the
        /// selected representation's data is avoided if that data has not changed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "If-Modified-Since")]
        public string IfModifiedSince { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need
        /// to contact Oracle about a particular request, please provide
        /// the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Specifies to operate only on resources that have a matching DNS scope.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "scope")]
        public System.Nullable<Scope> Scope { get; set; }
    }
}