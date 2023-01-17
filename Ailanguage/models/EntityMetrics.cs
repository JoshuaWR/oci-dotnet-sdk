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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Entity level named entity recognition model metrics
    /// </summary>
    public class EntityMetrics 
    {
        
        /// <value>
        /// Entity label
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Label is required.")]
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
        
        /// <value>
        /// F1-score, is a measure of a model\u2019s accuracy on a dataset
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "F1 is required.")]
        [JsonProperty(PropertyName = "f1")]
        public System.Nullable<float> F1 { get; set; }
        
        /// <value>
        /// Precision refers to the number of true positives divided by the total number of positive predictions (i.e., the number of true positives plus the number of false positives)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Precision is required.")]
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<float> Precision { get; set; }
        
        /// <value>
        /// Measures the model's ability to predict actual positive classes. It is the ratio between the predicted true positives and what was actually tagged. The recall metric reveals how many of the predicted classes are correct.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Recall is required.")]
        [JsonProperty(PropertyName = "recall")]
        public System.Nullable<float> Recall { get; set; }
        
    }
}
