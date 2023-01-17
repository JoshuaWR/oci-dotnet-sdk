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


namespace Oci.OnesubscriptionService.Models
{
    /// <summary>
    /// Computed Usage Summary object
    /// 
    /// </summary>
    public class InvoicelineComputedUsageSummary 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParentProduct is required.")]
        [JsonProperty(PropertyName = "parentProduct")]
        public InvoicingProduct ParentProduct { get; set; }
        
        [JsonProperty(PropertyName = "product")]
        public InvoicingProduct Product { get; set; }
        
        /// <value>
        /// Total Quantity that was used for computation
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Quantity is required.")]
        [JsonProperty(PropertyName = "quantity")]
        public System.Double Quantity { get; set; }
        
        /// <value>
        /// Net Unit Price for the product in consideration, price actual.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NetUnitPrice is required.")]
        [JsonProperty(PropertyName = "netUnitPrice")]
        public System.Double NetUnitPrice { get; set; }
        
        /// <value>
        /// Metered Service date.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeMeteredOn is required.")]
        [JsonProperty(PropertyName = "timeMeteredOn")]
        public System.Nullable<System.DateTime> TimeMeteredOn { get; set; }
                ///
        /// <value>
        /// Usage compute type in SPM.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROMOTION")]
            Promotion,
            [EnumMember(Value = "DO_NOT_BILL")]
            DoNotBill,
            [EnumMember(Value = "USAGE")]
            Usage,
            [EnumMember(Value = "COMMIT")]
            Commit,
            [EnumMember(Value = "OVERAGE")]
            Overage,
            [EnumMember(Value = "PAY_AS_YOU_GO")]
            PayAsYouGo,
            [EnumMember(Value = "MONTHLY_MINIMUM")]
            MonthlyMinimum,
            [EnumMember(Value = "DELAYED_USAGE_INVOICE_TIMING")]
            DelayedUsageInvoiceTiming,
            [EnumMember(Value = "DELAYED_USAGE_COMMITMENT_EXP")]
            DelayedUsageCommitmentExp,
            [EnumMember(Value = "ON_ACCOUNT_CREDIT")]
            OnAccountCredit,
            [EnumMember(Value = "SERVICE_CREDIT")]
            ServiceCredit
        };

        /// <value>
        /// Usage compute type in SPM.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// Sum of Usage/Service Billing Line net Amount
        /// 
        /// </value>
        [JsonProperty(PropertyName = "cost")]
        public System.Double Cost { get; set; }
        
        /// <value>
        /// Computed Line Amount rounded.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CostRounded is required.")]
        [JsonProperty(PropertyName = "costRounded")]
        public System.Double CostRounded { get; set; }
        
    }
}
