/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CertificatesService.Models
{
    /// <summary>
    /// An object that describes a period of time during which an entity is valid.
    /// </summary>
    public class Validity 
    {
        
        /// <value>
        /// The date on which the certificate validity period begins, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeOfValidityNotBefore is required.")]
        [JsonProperty(PropertyName = "timeOfValidityNotBefore")]
        public System.Nullable<System.DateTime> TimeOfValidityNotBefore { get; set; }
        
        /// <value>
        /// The date on which the certificate validity period ends, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeOfValidityNotAfter is required.")]
        [JsonProperty(PropertyName = "timeOfValidityNotAfter")]
        public System.Nullable<System.DateTime> TimeOfValidityNotAfter { get; set; }
        
    }
}
