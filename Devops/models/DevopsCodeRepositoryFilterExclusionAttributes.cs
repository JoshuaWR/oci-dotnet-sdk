/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Attributes to filter DevopsCodeRepository events. File filter criteria - Changes only affecting excluded files will not invoke a build. if both include and exclude filter are used then exclusion filter will be applied on the result set of inclusion filter.
    /// </summary>
    public class DevopsCodeRepositoryFilterExclusionAttributes 
    {
        
        [JsonProperty(PropertyName = "fileFilter")]
        public FileFilter FileFilter { get; set; }
        
    }
}