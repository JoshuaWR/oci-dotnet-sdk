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


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// Profiling configuration.
    /// </summary>
    public class ProfileConfig 
    {
        
        /// <value>
        /// Array of column names to profile. If empty all columns in the entity are profiled.
        /// </value>
        [JsonProperty(PropertyName = "attributes")]
        public System.Collections.Generic.List<string> Attributes { get; set; }
                ///
        ///
        public enum FunctionsEnum {
            [EnumMember(Value = "ATTRIBUTE_COUNT")]
            AttributeCount,
            [EnumMember(Value = "ROW_COUNT")]
            RowCount,
            [EnumMember(Value = "DATA_TYPE")]
            DataType,
            [EnumMember(Value = "DISTINCT_COUNT")]
            DistinctCount,
            [EnumMember(Value = "DUPLICATE_COUNT")]
            DuplicateCount,
            [EnumMember(Value = "HISTOGRAM")]
            Histogram,
            [EnumMember(Value = "MAX")]
            Max,
            [EnumMember(Value = "MAX_LENGTH")]
            MaxLength,
            [EnumMember(Value = "MEAN")]
            Mean,
            [EnumMember(Value = "MEAN_LENGTH")]
            MeanLength,
            [EnumMember(Value = "MEDIAN")]
            Median,
            [EnumMember(Value = "MIN")]
            Min,
            [EnumMember(Value = "MIN_LENGTH")]
            MinLength,
            [EnumMember(Value = "NULL_COUNT")]
            NullCount,
            [EnumMember(Value = "OUTLIER")]
            Outlier,
            [EnumMember(Value = "PATTERN")]
            Pattern,
            [EnumMember(Value = "STANDARD_DEVIATION")]
            StandardDeviation,
            [EnumMember(Value = "UNIQUE_COUNT")]
            UniqueCount,
            [EnumMember(Value = "VARIANCE")]
            Variance,
            [EnumMember(Value = "VALUE_FREQUENCY")]
            ValueFrequency
        };

        /// <value>
        /// Array of enum Strings basically what all profile functions to run. If empty, all supported functions are run.
        /// </value>
        [JsonProperty(PropertyName = "functions", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<FunctionsEnum> Functions { get; set; }
        
        /// <value>
        /// The maximum number of value frequencies to return per column. The VFs are sorted descending on frequency and ascending on value and then topN are returned and rest discarded.
        /// </value>
        [JsonProperty(PropertyName = "topNValFreq")]
        public System.Nullable<int> TopNValFreq { get; set; }
        
        /// <value>
        /// A pattern has to qualify minumum this percentage threshold to be considered a legitimate pattern on its own. All patterns which does not qualify this will be clubbed together into a single 'Others' pattern.
        /// </value>
        [JsonProperty(PropertyName = "patternThreshold")]
        public System.Nullable<int> PatternThreshold { get; set; }
        
        /// <value>
        /// A data type has to qualify minimum this percentage threshold to be considered an infrred data type for a column.
        /// </value>
        [JsonProperty(PropertyName = "dataTypeThreshold")]
        public System.Nullable<int> DataTypeThreshold { get; set; }
        
    }
}
