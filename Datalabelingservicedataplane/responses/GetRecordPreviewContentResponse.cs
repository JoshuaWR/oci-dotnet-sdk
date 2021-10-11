/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.DatalabelingservicedataplaneService.Models;

namespace Oci.DatalabelingservicedataplaneService.Responses
{
    public class GetRecordPreviewContentResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// For optimistic concurrency control. See `if-match`.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// The content size of the body in bytes.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-length")]
        public System.Nullable<long> ContentLength { get; set; }


        /// <value>
        /// The content disposition of the body, as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 19.5.1.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-disposition")]
        public string ContentDisposition { get; set; }


        /// <value>
        /// The content type as described in [RFC 2616](https://tools.ietf.org/rfc/rfc2616), section 14.17.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-type")]
        public string ContentType { get; set; }


        /// <value>
        /// Cache-control allows us to tell browsers to cache assets, how long to store them, and whether to validate them.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "cache-control")]
        public string CacheControl { get; set; }

        /// <value>
        /// The returned System.IO.Stream instance, or null if {@link #isNotModified()} is true.  Caller must always close the stream to avoid holding resources.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream InputStream { get; set; }

        /// <value>
        /// Flag to indicate whether or not the object was modified.  If this is true,
        /// the getter for the object itself will return null.  Callers should check this
        /// if they specified one of the request params that might result in a conditional
        /// response (like 'if-match'/'if-none-match').
        /// </value>
        public bool IsNotModified { get; set; }
    }
}
