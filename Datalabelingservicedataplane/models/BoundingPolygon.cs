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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// A polygon used to describe the location of an object.
    /// </summary>
    public class BoundingPolygon 
    {
        
        /// <value>
        /// The normalized vertices that make up the polygon.  They are in the order of the segments they connect.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NormalizedVertices is required.")]
        [JsonProperty(PropertyName = "normalizedVertices")]
        public System.Collections.Generic.List<NormalizedVertex> NormalizedVertices { get; set; }
        
    }
}
