/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Responses
{
    public class GetAwrHubObjectResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Echoes back the value passed in the opc-client-request-id header, for use by clients when debugging.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// For optimistic concurrency control. See `if-match`.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// The user-defined metadata for the Awr Hub object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-meta-")]
        public System.Collections.Generic.Dictionary<string, string> OpcMeta { get; set; }


        /// <value>
        /// The Awr Hub object size in bytes.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-length")]
        public System.Nullable<long> ContentLength { get; set; }


        /// <value>
        /// Content-Range header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-range")]
        public Oci.Common.Model.Range ContentRange { get; set; }


        /// <value>
        /// Content-MD5 header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-md5")]
        public string ContentMd5 { get; set; }


        /// <value>
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-multipart-md5")]
        public string OpcMultipartMd5 { get; set; }


        /// <value>
        /// Content-Type header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-type")]
        public string ContentType { get; set; }


        /// <value>
        /// Content-Language header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-language")]
        public string ContentLanguage { get; set; }


        /// <value>
        /// Content-Encoding header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-encoding")]
        public string ContentEncoding { get; set; }


        /// <value>
        /// Cache-Control header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "cache-control")]
        public string CacheControl { get; set; }


        /// <value>
        /// Content-Disposition header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-disposition")]
        public string ContentDisposition { get; set; }


        /// <value>
        /// The Awr Hub object modification time.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "last-modified")]
        public System.Nullable<System.DateTime> LastModified { get; set; }

        ///
        /// <value>
        /// The storage tier that the Awr Hub object is stored in.
        /// </value>
        ///
        public enum StorageTierEnum {
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "INFREQUENTACCESS")]
            Infrequentaccess,
            [EnumMember(Value = "ARCHIVE")]
            Archive
        };

        /// <value>
        /// The storage tier that the Awr Hub object is stored in.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "storage-tier")]
        public System.Nullable<StorageTierEnum> StorageTier { get; set; }

        ///
        /// <value>
        /// Archival state of an Awr Hub object. This field is set only for Awr Hub objects in Archive tier.
        /// </value>
        ///
        public enum ArchivalStateEnum {
            [EnumMember(Value = "ARCHIVED")]
            Archived,
            [EnumMember(Value = "RESTORING")]
            Restoring,
            [EnumMember(Value = "RESTORED")]
            Restored
        };

        /// <value>
        /// Archival state of an Awr Hub object. This field is set only for Awr Hub objects in Archive tier.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "archival-state")]
        public System.Nullable<ArchivalStateEnum> ArchivalState { get; set; }


        /// <value>
        /// Time that the Awr Hub object is returned to the archived state.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "time-of-archival")]
        public System.Nullable<System.DateTime> TimeOfArchival { get; set; }


        /// <value>
        /// VersionId of the requested Awr Hub object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "version-id")]
        public string VersionId { get; set; }


        /// <value>
        /// The date and time after which the Awr Hub object is no longer cached by a browser, proxy, or other caching entity.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "expires")]
        public System.Nullable<System.DateTime> Expires { get; set; }

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
