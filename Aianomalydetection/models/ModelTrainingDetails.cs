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


namespace Oci.AianomalydetectionService.Models
{
    /// <summary>
    /// Specifies the details of the MSET model during the create call.
    /// </summary>
    public class ModelTrainingDetails 
    {
        
        /// <value>
        /// A target model accuracy metric user provides as their requirement
        /// </value>
        [JsonProperty(PropertyName = "targetFap")]
        public System.Nullable<float> TargetFap { get; set; }
        
        /// <value>
        /// Fraction of total data that is used for training the model. The remaining is used for validation of the model.
        /// </value>
        [JsonProperty(PropertyName = "trainingFraction")]
        public System.Nullable<float> TrainingFraction { get; set; }
        
        /// <value>
        /// The list of OCIDs of the data assets to train the model. The dataAssets have to be in the same project where the ai model would reside.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataAssetIds is required.")]
        [JsonProperty(PropertyName = "dataAssetIds")]
        public System.Collections.Generic.List<string> DataAssetIds { get; set; }
        
    }
}
