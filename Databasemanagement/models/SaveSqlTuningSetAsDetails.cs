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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// Save current list of Sql statements into another Sql tuning set.
    /// It takes either credentialDetails or databaseCredential. It's recommended to provide databaseCredential
    /// 
    /// </summary>
    public class SaveSqlTuningSetAsDetails 
    {
        
        [JsonProperty(PropertyName = "credentialDetails")]
        public SqlTuningSetAdminCredentialDetails CredentialDetails { get; set; }
        
        [JsonProperty(PropertyName = "databaseCredential")]
        public DatabaseCredentialDetails DatabaseCredential { get; set; }
        
        /// <value>
        /// Flag to indicate whether to save the Sql tuning set or just display the plsql used to save Sql tuning set.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "showSqlOnly")]
        public System.Nullable<int> ShowSqlOnly { get; set; }
        
        /// <value>
        /// The owner of the Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// The name of the Sql tuning set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the destination Sql tuning set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationSqlTuningSetName is required.")]
        [JsonProperty(PropertyName = "destinationSqlTuningSetName")]
        public string DestinationSqlTuningSetName { get; set; }
        
        /// <value>
        /// The description for the destination Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "destinationSqlTuningSetDescription")]
        public string DestinationSqlTuningSetDescription { get; set; }
        
        /// <value>
        /// Owner of the destination Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "destinationSqlTuningSetOwner")]
        public string DestinationSqlTuningSetOwner { get; set; }
        
        /// <value>
        /// Specifies whether to create a new Sql tuning set or not.
        /// Possible values
        /// 1 - Create a new Sql tuning set
        /// 0 - Do not create a new Sql tuning set
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateNew is required.")]
        [JsonProperty(PropertyName = "createNew")]
        public System.Nullable<int> CreateNew { get; set; }
        
        /// <value>
        /// Specifies the Sql predicate to filter the Sql from the Sql tuning set defined on attributes of the SQLSET_ROW.
        /// User could use any combination of the following columns with appropriate values as Sql predicate
        /// Refer to the documentation https://docs.oracle.com/en/database/oracle/oracle-database/18/arpls/DBMS_SQLTUNE.html#GUID-1F4AFB03-7B29-46FC-B3F2-CB01EC36326C
        /// 
        /// </value>
        [JsonProperty(PropertyName = "basicFilter")]
        public string BasicFilter { get; set; }
                ///
        /// <value>
        /// Specifies the plan filter.
        /// This parameter enables you to select a single plan when a statement has multiple plans.
        /// Refer to the documentation https://docs.oracle.com/en/database/oracle/oracle-database/19/arpls/DBMS_SQLSET.html#GUID-9D995019-91AB-4B1E-9EAF-031050789B21
        /// 
        /// </value>
        ///
        public enum PlanFilterEnum {
            [EnumMember(Value = "LAST_GENERATED")]
            LastGenerated,
            [EnumMember(Value = "FIRST_GENERATED")]
            FirstGenerated,
            [EnumMember(Value = "LAST_LOADED")]
            LastLoaded,
            [EnumMember(Value = "FIRST_LOADED")]
            FirstLoaded,
            [EnumMember(Value = "MAX_ELAPSED_TIME")]
            MaxElapsedTime,
            [EnumMember(Value = "MAX_BUFFER_GETS")]
            MaxBufferGets,
            [EnumMember(Value = "MAX_DISK_READS")]
            MaxDiskReads,
            [EnumMember(Value = "MAX_DIRECT_WRITES")]
            MaxDirectWrites,
            [EnumMember(Value = "MAX_OPTIMIZER_COST")]
            MaxOptimizerCost
        };

        /// <value>
        /// Specifies the plan filter.
        /// This parameter enables you to select a single plan when a statement has multiple plans.
        /// Refer to the documentation https://docs.oracle.com/en/database/oracle/oracle-database/19/arpls/DBMS_SQLSET.html#GUID-9D995019-91AB-4B1E-9EAF-031050789B21
        /// 
        /// </value>
        [JsonProperty(PropertyName = "planFilter")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PlanFilterEnum> PlanFilter { get; set; }
                ///
        /// <value>
        /// Specifies that the filter must include recursive Sql in the Sql tuning set.
        /// </value>
        ///
        public enum RecursiveSqlEnum {
            [EnumMember(Value = "HAS_RECURSIVE_SQL")]
            HasRecursiveSql,
            [EnumMember(Value = "NO_RECURSIVE_SQL")]
            NoRecursiveSql
        };

        /// <value>
        /// Specifies that the filter must include recursive Sql in the Sql tuning set.
        /// </value>
        [JsonProperty(PropertyName = "recursiveSql")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RecursiveSqlEnum> RecursiveSql { get; set; }
        
        /// <value>
        /// Specifies a filter that picks the top n% according to the supplied ranking measure.
        /// Note that this parameter applies only if one ranking measure is supplied.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resultPercentage")]
        public System.Double ResultPercentage { get; set; }
        
        /// <value>
        /// The top limit Sql from the filtered source, ranked by the ranking measure.
        /// </value>
        [JsonProperty(PropertyName = "resultLimit")]
        public System.Nullable<int> ResultLimit { get; set; }
        
        /// <value>
        /// Specifies an ORDER BY clause on the selected Sql. User can specify upto three ranking measures.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rankingMeasure1")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RankingMeasure> RankingMeasure1 { get; set; }
        
        /// <value>
        /// Specifies an ORDER BY clause on the selected Sql. User can specify upto three ranking measures.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rankingMeasure2")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RankingMeasure> RankingMeasure2 { get; set; }
        
        /// <value>
        /// Specifies an ORDER BY clause on the selected Sql. User can specify upto three ranking measures.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rankingMeasure3")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RankingMeasure> RankingMeasure3 { get; set; }
        
        /// <value>
        /// Specifies the list of Sql statement attributes to return in the result.
        /// Note that this parameter cannot be made an enum since custom value can take a list of comma separated attribute names.
        /// Attribute list can take one of the following values.
        ///  TYPICAL - Specifies BASIC plus Sql plan (without row source statistics) and without object reference list (default).
        ///  BASIC - Specifies all attributes (such as execution statistics and binds) except the plans. The execution context is always part of the result.
        ///  ALL - Specifies all attributes.
        ///  CUSTOM - Comma-separated list of the following attribute names.
        ///           - EXECUTION_STATISTICS
        ///           - BIND_LIST
        ///           - OBJECT_LIST
        ///           - SQL_PLAN
        ///           - SQL_PLAN_STATISTICS
        /// Usage examples:
        ///   1. \"attributeList\": \"TYPICAL\"
        ///   2. \"attributeList\": \"ALL\"
        ///   3. \"attributeList\": \"EXECUTION_STATISTICS,OBJECT_LIST,SQL_PLAN\"
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributeList")]
        public string AttributeList { get; set; }
                ///
        /// <value>
        /// Specifies which statements are loaded into the Sql tuning set.
        /// The possible values are.
        ///   - INSERT (default)
        ///     Adds only new statements.
        ///   - UPDATE
        ///     Updates existing the Sql statements and ignores any new statements.
        ///   - MERGE
        ///     Inserts new statements and updates the information of the existing ones.
        /// 
        /// </value>
        ///
        public enum LoadOptionEnum {
            [EnumMember(Value = "INSERT")]
            Insert,
            [EnumMember(Value = "UPDATE")]
            Update,
            [EnumMember(Value = "MERGE")]
            Merge
        };

        /// <value>
        /// Specifies which statements are loaded into the Sql tuning set.
        /// The possible values are.
        ///   - INSERT (default)
        ///     Adds only new statements.
        ///   - UPDATE
        ///     Updates existing the Sql statements and ignores any new statements.
        ///   - MERGE
        ///     Inserts new statements and updates the information of the existing ones.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "loadOption")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LoadOptionEnum> LoadOption { get; set; }
                ///
        /// <value>
        /// Specifies how existing Sql statements are updated.
        /// This parameter is applicable only if load_option is specified with UPDATE or MERGE as an option.
        /// Update option can take one of the following values.
        ///    REPLACE (default) - Updates the statement using the new statistics, bind list, object list, and so on.
        ///    ACCUMULATE - Combines attributes when possible (for example, statistics such as elapsed_time), otherwise replaces the existing values (for example, module and action) with the provided values.
        ///    Following Sql statement attributes can be accumulated.
        ///        elapsed_time
        ///        buffer_gets
        ///        direct_writes
        ///        disk_reads
        ///        row_processed
        ///        fetches
        ///        executions
        ///        end_of_fetch_count
        ///        stat_period
        ///        active_stat_period
        /// 
        /// </value>
        ///
        public enum UpdateOptionEnum {
            [EnumMember(Value = "REPLACE")]
            Replace,
            [EnumMember(Value = "ACCUMULATE")]
            Accumulate
        };

        /// <value>
        /// Specifies how existing Sql statements are updated.
        /// This parameter is applicable only if load_option is specified with UPDATE or MERGE as an option.
        /// Update option can take one of the following values.
        ///    REPLACE (default) - Updates the statement using the new statistics, bind list, object list, and so on.
        ///    ACCUMULATE - Combines attributes when possible (for example, statistics such as elapsed_time), otherwise replaces the existing values (for example, module and action) with the provided values.
        ///    Following Sql statement attributes can be accumulated.
        ///        elapsed_time
        ///        buffer_gets
        ///        direct_writes
        ///        disk_reads
        ///        row_processed
        ///        fetches
        ///        executions
        ///        end_of_fetch_count
        ///        stat_period
        ///        active_stat_period
        /// 
        /// </value>
        [JsonProperty(PropertyName = "updateOption")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpdateOptionEnum> UpdateOption { get; set; }
                ///
        /// <value>
        /// Specifies when to perform the update.
        /// The procedure only performs the update when the specified condition is satisfied.
        /// The condition can refer to either the data source or destination.
        /// The condition must use the following prefixes to refer to attributes from the source or the destination:
        ///   OLD  \u2014 Refers to statement attributes from the SQL tuning set (destination).
        ///   NEW  \u2014 Refers to statement attributes from the input statements (source).
        ///   NULL \u2014 No updates are performed.
        /// 
        /// </value>
        ///
        public enum UpdateConditionEnum {
            [EnumMember(Value = "OLD")]
            Old,
            [EnumMember(Value = "NEW")]
            New
        };

        /// <value>
        /// Specifies when to perform the update.
        /// The procedure only performs the update when the specified condition is satisfied.
        /// The condition can refer to either the data source or destination.
        /// The condition must use the following prefixes to refer to attributes from the source or the destination:
        ///   OLD  \u2014 Refers to statement attributes from the SQL tuning set (destination).
        ///   NEW  \u2014 Refers to statement attributes from the input statements (source).
        ///   NULL \u2014 No updates are performed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "updateCondition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<UpdateConditionEnum> UpdateCondition { get; set; }
        
        /// <value>
        /// Specifies the list of Sql statement attributes to update during a merge or update.
        /// Note that this parameter cannot be made an enum since custom value can take a list of comma separated attribute names.
        /// Update attributes can take one of the following values.
        ///    NULL (default) - Specifies the content of the input cursor except the execution context. On other terms, it is equivalent to ALL without execution contexts such as module and action.
        ///    BASIC - Specifies statistics and binds only.
        ///    TYPICAL - Specifies BASIC with Sql plans (without row source statistics) and without an object reference list.
        ///    ALL - Specifies all attributes, including the execution context attributes such as module and action.
        ///    CUSTOM - List of comma separated attribute names to update
        ///        EXECUTION_CONTEXT
        ///        EXECUTION_STATISTICS
        ///        SQL_BINDS
        ///        SQL_PLAN
        ///        SQL_PLAN_STATISTICS (similar to SQL_PLAN with added row source statistics)
        /// Usage examples:
        ///   1. \"updateAttributes\": \"TYPICAL\"
        ///   2. \"updateAttributes\": \"BASIC\"
        ///   3. \"updateAttributes\": \"EXECUTION_STATISTICS,SQL_PLAN_STATISTICS,SQL_PLAN\"
        ///   4. \"updateAttributes\": \"EXECUTION_STATISTICS,SQL_PLAN\"
        /// 
        /// </value>
        [JsonProperty(PropertyName = "updateAttributes")]
        public string UpdateAttributes { get; set; }
        
        /// <value>
        /// Specifies whether to update attributes when the new value is NULL.
        /// If TRUE, then the procedure does not update an attribute when the new value is NULL.
        /// That is, do not override with NULL values unless intentional.
        /// Possible values - true or false
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isIgnoreNull")]
        public System.Nullable<bool> IsIgnoreNull { get; set; }
        
        /// <value>
        /// Specifies whether to commit statements after DML.
        /// If a value is provided, then the load commits after each specified number of statements is inserted.
        /// If NULL is provided, then the load commits only once, at the end of the operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "commitRows")]
        public System.Nullable<int> CommitRows { get; set; }
        
    }
}
