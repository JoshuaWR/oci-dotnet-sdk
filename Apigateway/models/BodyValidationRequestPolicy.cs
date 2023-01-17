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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Validate the payload body of the incoming API requests on a specific route.
    /// </summary>
    public class BodyValidationRequestPolicy 
    {
        
        /// <value>
        /// Determines if the request body is required in the request.
        /// </value>
        [JsonProperty(PropertyName = "required")]
        public System.Nullable<bool> Required { get; set; }
        
        /// <value>
        /// The content of the request body. The key is a [media type range](https://tools.ietf.org/html/rfc7231#appendix-D)
        /// subset restricted to the following schema
        /// <br/>
        ///     key ::= (
        ///           / (  \"*\" \"/\" \"*\" )
        ///           / ( type \"/\" \"*\" )
        ///           / ( type \"/\" subtype )
        ///           )
        /// <br/>
        /// For requests that match multiple keys, only the most specific key is applicable.
        /// e.g. `text/plain` overrides `text/*`
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Content is required.")]
        [JsonProperty(PropertyName = "content")]
        public System.Collections.Generic.Dictionary<string, ContentValidation> Content { get; set; }
                ///
        /// <value>
        /// Validation behavior mode.
        /// <br/>
        /// In `ENFORCING` mode, upon a validation failure, the request will be rejected with a 4xx response
        /// and not sent to the backend.
        /// <br/>
        /// In `PERMISSIVE` mode, the result of the validation will be exposed as metrics while the request
        /// will follow the normal path.
        /// <br/>
        /// `DISABLED` type turns the validation off.
        /// 
        /// </value>
        ///
        public enum ValidationModeEnum {
            [EnumMember(Value = "ENFORCING")]
            Enforcing,
            [EnumMember(Value = "PERMISSIVE")]
            Permissive,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// Validation behavior mode.
        /// <br/>
        /// In `ENFORCING` mode, upon a validation failure, the request will be rejected with a 4xx response
        /// and not sent to the backend.
        /// <br/>
        /// In `PERMISSIVE` mode, the result of the validation will be exposed as metrics while the request
        /// will follow the normal path.
        /// <br/>
        /// `DISABLED` type turns the validation off.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "validationMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ValidationModeEnum> ValidationMode { get; set; }
        
    }
}
