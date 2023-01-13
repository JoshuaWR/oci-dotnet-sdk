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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Pivot operator has one input and one output. Pivot operator takes group by columns, a pivot key with values and aggregations. Output is the pivoted table.
    /// </summary>
    public class Pivot : Operator
    {
        
        [JsonProperty(PropertyName = "groupByColumns")]
        public DynamicProxyField GroupByColumns { get; set; }
        
        [JsonProperty(PropertyName = "materializedGroupByColumns")]
        public MaterializedDynamicField MaterializedGroupByColumns { get; set; }
        
        [JsonProperty(PropertyName = "pivotKeys")]
        public PivotKeys PivotKeys { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "PIVOT_OPERATOR";
    }
}
