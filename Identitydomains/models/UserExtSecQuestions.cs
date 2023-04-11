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


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// Security question and answers provided by end-user for Account recovery and/or MFA. While setting up security questions, end-user can also provide hint along with answer.
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - idcsCompositeKey: [value]
    ///  - multiValued: true
    ///  - mutability: readWrite
    ///  - required: false
    ///  - returned: request
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class UserExtSecQuestions 
    {
        
        /// <value>
        /// Id of the question selected by user while setting up Security Question.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: true
        ///  - returned: always
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
        /// The URI of the corresponding SecurityQuestion resource
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: reference
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "$ref")]
        public string Ref { get; set; }
        
        /// <value>
        /// Answer provided by an user for a security question.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCsvAttributeName: Answer
        ///  - idcsSearchable: false
        ///  - idcsSensitive: hash
        ///  - multiValued: false
        ///  - mutability: writeOnly
        ///  - required: true
        ///  - returned: never
        ///  - type: string
        ///  - uniqueness: none
        ///  - idcsPii: true
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Answer is required.")]
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }
        
        /// <value>
        /// Hint for an answer given by user while setting up Security Question.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "hintText")]
        public string HintText { get; set; }
        
    }
}