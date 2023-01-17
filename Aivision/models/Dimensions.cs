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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The width and height of a page.
    /// </summary>
    public class Dimensions 
    {
        
        /// <value>
        /// the width of a page.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Width is required.")]
        [JsonProperty(PropertyName = "width")]
        public System.Double Width { get; set; }
        
        /// <value>
        /// The height of a page.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Height is required.")]
        [JsonProperty(PropertyName = "height")]
        public System.Double Height { get; set; }
                ///
        /// <value>
        /// The unit of length.
        /// </value>
        ///
        public enum UnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PIXEL")]
            Pixel,
            [EnumMember(Value = "INCH")]
            Inch
        };

        /// <value>
        /// The unit of length.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Unit is required.")]
        [JsonProperty(PropertyName = "unit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UnitEnum> Unit { get; set; }
        
    }
}
