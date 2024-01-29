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


namespace Oci.CapacitymanagementService.Models
{
    /// <summary>
    /// An operation that \"puts\" a value, replacing every item of the selection with it, or creating it if the selection is empty.
    /// NOT_FOUND exceptions are handled by creating the implied containing structure (but note that this may put the target in an invalid state,
    /// which can be prevented by use of precondition operations).
    /// To avoid referential errors if an item's descendant is also in the selection, items of the selection are processed in order of decreasing depth.
    /// 
    /// </summary>
    public class PatchReplaceInstruction : PatchInstruction
    {
        
        /// <value>
        /// A value to be added into the target.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public System.Object Value { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "REPLACE";
    }
}
