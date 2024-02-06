/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// Text to be displayed on UI after doing self registration
    /// </summary>
    public class SelfRegistrationProfileAfterSubmitText 
    {
        
        /// <value>
        /// Type of user's locale e.g. en-CA
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsCanonicalValueSourceFilter: attrName eq \"locales\" and attrValues.value eq \"$(type)\"
        ///  - idcsCanonicalValueSourceResourceType: AllowedValue
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Locale is required.")]
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }
        
        /// <value>
        /// Localized value of after submit text in corresponding locale
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// If true, specifies that the localized attribute instance value is the default and will be returned if no localized value found for requesting user's preferred locale. One and only one instance should have this attribute set to true.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "default")]
        public System.Nullable<bool> Default { get; set; }
        
    }
}