/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/objectstorage/PutObject.cs.html">here</a> to see an example of how to use PutObject request.
    /// </example>
    public class PutObjectRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Object Storage namespace used for the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        /// <value>
        /// The name of the bucket. Avoid entering confidential information.
        /// Example: my-new-bucket1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The name of the object. Avoid entering confidential information.
        /// Example: test/object1.log
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// The content length of the body.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-Length")]
        public System.Nullable<long> ContentLength { get; set; }
        
        /// <value>
        /// The object to upload to the object store.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PutObjectBody is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream PutObjectBody { get; set; }
        
        /// <value>
        /// The entity tag (ETag) to match with the ETag of an existing resource. If the specified ETag matches the ETag of
        /// the existing resource, GET and HEAD requests will return the resource and PUT and POST requests will upload
        /// the resource.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// The entity tag (ETag) to avoid matching. The only valid value is '*', which indicates that the request should
        /// fail if the resource already exists.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-none-match")]
        public string IfNoneMatch { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }
        
        /// <value>
        /// 100-continue
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Expect")]
        public string Expect { get; set; }
        
        /// <value>
        /// The optional base-64 header that defines the encoded MD5 hash of the body. If the optional Content-MD5 header is present, Object
        /// Storage performs an integrity check on the body of the HTTP request by computing the MD5 hash for the body and comparing it to the
        /// MD5 hash supplied in the header. If the two hashes do not match, the object is rejected and an HTTP-400 Unmatched Content MD5 error
        /// is returned with the message:
        /// <br/>
        /// \"The computed MD5 of the request body (ACTUAL_MD5) does not match the Content-MD5 header (HEADER_MD5)\"
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-MD5")]
        public string ContentMD5 { get; set; }
        
        /// <value>
        /// The optional Content-Type header that defines the standard MIME type format of the object. Content type defaults to
        /// 'application/octet-stream' if not specified in the PutObject call. Specifying values for this header has no effect
        /// on Object Storage behavior. Programs that read the object determine what to do based on the value provided. For example,
        /// you could use this header to identify and perform special operations on text only objects.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-Type")]
        public string ContentType { get; set; }
        
        /// <value>
        /// The optional Content-Language header that defines the content language of the object to upload. Specifying
        /// values for this header has no effect on Object Storage behavior. Programs that read the object determine what
        /// to do based on the value provided. For example, you could use this header to identify and differentiate objects
        /// based on a particular language.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-Language")]
        public string ContentLanguage { get; set; }
        
        /// <value>
        /// The optional Content-Encoding header that defines the content encodings that were applied to the object to
        /// upload. Specifying values for this header has no effect on Object Storage behavior. Programs that read the
        /// object determine what to do based on the value provided. For example, you could use this header to determine
        /// what decoding mechanisms need to be applied to obtain the media-type specified by the Content-Type header of
        /// the object.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-Encoding")]
        public string ContentEncoding { get; set; }
        
        /// <value>
        /// The optional Content-Disposition header that defines presentational information for the object to be
        /// returned in GetObject and HeadObject responses. Specifying values for this header has no effect on Object
        /// Storage behavior. Programs that read the object determine what to do based on the value provided.
        /// For example, you could use this header to let users download objects with custom filenames in a browser.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Content-Disposition")]
        public string ContentDisposition { get; set; }
        
        /// <value>
        /// The optional Cache-Control header that defines the caching behavior value to be returned in GetObject and
        /// HeadObject responses. Specifying values for this header has no effect on Object Storage behavior. Programs
        /// that read the object determine what to do based on the value provided.
        /// For example, you could use this header to identify objects that require caching restrictions.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "Cache-Control")]
        public string CacheControl { get; set; }
        
        /// <value>
        /// The optional header that specifies \"AES256\" as the encryption algorithm. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-algorithm")]
        public string OpcSseCustomerAlgorithm { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded 256-bit encryption key to use to encrypt or
        /// decrypt the data. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-key")]
        public string OpcSseCustomerKey { get; set; }
        
        /// <value>
        /// The optional header that specifies the base64-encoded SHA256 hash of the encryption key. This
        /// value is used to check the integrity of the encryption key. For more information, see
        /// [Using Your Own Keys for Server-Side Encryption](https://docs.cloud.oracle.com/Content/Object/Tasks/usingyourencryptionkeys.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-customer-key-sha256")]
        public string OpcSseCustomerKeySha256 { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of a master encryption key used to call the Key
        /// Management service to generate a data encryption key or to encrypt or decrypt a data encryption key.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-sse-kms-key-id")]
        public string OpcSseKmsKeyId { get; set; }
        
        /// <value>
        /// The storage tier that the object should be stored in. If not specified, the object will be stored in
        /// the same storage tier as the bucket.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "storage-tier")]
        public System.Nullable<StorageTier> StorageTier { get; set; }
        
        /// <value>
        /// Optional user-defined metadata key and value.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-meta-")]
        public System.Collections.Generic.Dictionary<string, string> OpcMeta { get; set; }
    }
}
