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
    /// Possible TXTC model error analysis
    /// </summary>
    public class TextClassificationModelEvaluationResult : EvaluationResultSummary
    {
        
        /// <value>
        /// For CSV format location is rowId(1 is header) and for JSONL location is jsonL line sequence(1 is metadata)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Location is required.")]
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }
        
        /// <value>
        /// List of true(actual) labels in test data for multi class or multi label TextClassification
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrueLabels is required.")]
        [JsonProperty(PropertyName = "trueLabels")]
        public System.Collections.Generic.List<string> TrueLabels { get; set; }
        
        /// <value>
        /// List of predicted labels by custom multi class or multi label TextClassification model
        /// </value>
        [JsonProperty(PropertyName = "predictedLabels")]
        public System.Collections.Generic.List<string> PredictedLabels { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "TEXT_CLASSIFICATION";
    }
}
