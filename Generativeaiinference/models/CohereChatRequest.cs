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


namespace Oci.GenerativeaiinferenceService.Models
{
    /// <summary>
    /// Details for the chat request for Cohere models.
    /// </summary>
    public class CohereChatRequest : BaseChatRequest
    {
        
        /// <value>
        /// The text that the user inputs for the model to respond to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// The list of previous messages between the user and the model. The chat history gives the model context for responding to the user's inputs.
        /// </value>
        [JsonProperty(PropertyName = "chatHistory")]
        public System.Collections.Generic.List<CohereMessage> ChatHistory { get; set; }
        
        /// <value>
        /// A list of relevant documents that the model can refer to for generating grounded responses to the user's requests.
        /// Some example keys that you can add to the dictionary are \"text\", \"author\", and \"date\". Keep the total word count of the strings in the dictionary to 300 words or less.
        /// <br/>
        /// Example: [  { &quot;title&quot;: &quot;Tall penguins&quot;, &quot;snippet&quot;: &quot;Emperor penguins are the tallest.&quot; },  { &quot;title&quot;: &quot;Penguin habitats&quot;, &quot;snippet&quot;: &quot;Emperor penguins only live in Antarctica.&quot; }]
        /// </value>
        [JsonProperty(PropertyName = "documents")]
        public System.Collections.Generic.List<System.Object> Documents { get; set; }
        
        /// <value>
        /// When set to true, the response contains only a list of generated search queries without the search results and the model will not respond to the user's message.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSearchQueriesOnly")]
        public System.Nullable<bool> IsSearchQueriesOnly { get; set; }
        
        /// <value>
        /// If specified, the default Cohere preamble is replaced with the provided preamble. A preamble is an initial guideline message that can change the model's overall chat behavior and conversation style. Default preambles vary for different models.
        /// <br/>
        /// Example: You are a travel advisor. Answer with a pirate tone.
        /// </value>
        [JsonProperty(PropertyName = "preambleOverride")]
        public string PreambleOverride { get; set; }
        
        /// <value>
        /// Whether to stream the partial progress of the model's response. When set to true, as tokens become available, they are sent as data-only server-sent events.
        /// </value>
        [JsonProperty(PropertyName = "isStream")]
        public System.Nullable<bool> IsStream { get; set; }
        
        /// <value>
        /// The maximum number of output tokens that the model will generate for the response.
        /// </value>
        [JsonProperty(PropertyName = "maxTokens")]
        public System.Nullable<int> MaxTokens { get; set; }
        
        /// <value>
        /// A number that sets the randomness of the generated output. A lower temperature means less random generations.
        /// Use lower numbers for tasks such as question answering or summarizing. High temperatures can generate hallucinations or factually incorrect information. Start with temperatures lower than 1.0 and increase the temperature for more creative outputs, as you regenerate the prompts to refine the outputs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "temperature")]
        public System.Double Temperature { get; set; }
        
        /// <value>
        /// A sampling method in which the model chooses the next token randomly from the top k most likely tokens. A higher value for k generates more random output, which makes the output text sound more natural. The default value for k is 0 which disables this method and considers all tokens. To set a number for the likely tokens, choose an integer between 1 and 500.
        /// <br/>
        /// If also using top p, then the model considers only the top tokens whose probabilities add up to p percent and ignores the rest of the k tokens. For example, if k is 20 but only the probabilities of the top 10 add up to the value of p, then only the top 10 tokens are chosen.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topK")]
        public System.Nullable<int> TopK { get; set; }
        
        /// <value>
        /// If set to a probability 0.0 < p < 1.0, it ensures that only the most likely tokens, with total probability mass of p, are considered for generation at each step.
        /// <br/>
        /// To eliminate tokens with low likelihood, assign p a minimum percentage for the next token's likelihood. For example, when p is set to 0.75, the model eliminates the bottom 25 percent for the next token. Set to 1.0 to consider all tokens and set to 0 to disable. If both k and p are enabled, p acts after k.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topP")]
        public System.Double TopP { get; set; }
                ///
        /// <value>
        /// Defaults to OFF. Dictates how the prompt will be constructed. With `prompt_truncation` set to AUTO_PRESERVE_ORDER, some elements from `chat_history` and `documents` will be dropped to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be preserved. With `prompt_truncation` set to OFF, no elements will be dropped.
        /// 
        /// </value>
        ///
        public enum PromptTruncationEnum {
            [EnumMember(Value = "OFF")]
            Off,
            [EnumMember(Value = "AUTO_PRESERVE_ORDER")]
            AutoPreserveOrder
        };

        /// <value>
        /// Defaults to OFF. Dictates how the prompt will be constructed. With `prompt_truncation` set to AUTO_PRESERVE_ORDER, some elements from `chat_history` and `documents` will be dropped to construct a prompt that fits within the model's context length limit. During this process the order of the documents and chat history will be preserved. With `prompt_truncation` set to OFF, no elements will be dropped.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "promptTruncation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PromptTruncationEnum> PromptTruncation { get; set; }
        
        /// <value>
        /// To reduce repetitiveness of generated tokens, this number penalizes new tokens based on their frequency in the generated text so far. Greater numbers encourage the model to use new tokens, while lower numbers encourage the model to repeat the tokens. Set to 0 to disable.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "frequencyPenalty")]
        public System.Double FrequencyPenalty { get; set; }
        
        /// <value>
        /// To reduce repetitiveness of generated tokens, this number penalizes new tokens based on whether they've appeared in the generated text so far. Greater numbers encourage the model to use new tokens, while lower numbers encourage the model to repeat the tokens.
        /// <br/>
        /// Similar to frequency penalty, a penalty is applied to previously present tokens, except that this penalty is applied equally to all tokens that have already appeared, regardless of how many times they've appeared. Set to 0 to disable.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "presencePenalty")]
        public System.Double PresencePenalty { get; set; }
        
        /// <value>
        /// If specified, the backend will make a best effort to sample tokens deterministically, such that repeated requests with the same seed and parameters should return the same result. However, determinism cannot be totally guaranteed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "seed")]
        public System.Nullable<int> Seed { get; set; }
        
        /// <value>
        /// Returns the full prompt that was sent to the model when True.
        /// </value>
        [JsonProperty(PropertyName = "isEcho")]
        public System.Nullable<bool> IsEcho { get; set; }
        
        /// <value>
        /// A list of available tools (functions) that the model may suggest invoking before producing a text response.
        /// </value>
        [JsonProperty(PropertyName = "tools")]
        public System.Collections.Generic.List<CohereTool> Tools { get; set; }
        
        /// <value>
        /// A list of results from invoking tools recommended by the model in the previous chat turn.
        /// </value>
        [JsonProperty(PropertyName = "toolResults")]
        public System.Collections.Generic.List<CohereToolResult> ToolResults { get; set; }
        
        /// <value>
        /// When enabled, the model will issue (potentially multiple) tool calls in a single step, before it receives the tool responses and directly answers the user's original message.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isForceSingleStep")]
        public System.Nullable<bool> IsForceSingleStep { get; set; }
        
        /// <value>
        /// Stop the model generation when it reaches a stop sequence defined in this parameter.
        /// </value>
        [JsonProperty(PropertyName = "stopSequences")]
        public System.Collections.Generic.List<string> StopSequences { get; set; }
        
        /// <value>
        /// When enabled, the user\u2019s `message` will be sent to the model without any preprocessing.
        /// </value>
        [JsonProperty(PropertyName = "isRawPrompting")]
        public System.Nullable<bool> IsRawPrompting { get; set; }
                ///
        /// <value>
        /// When FAST is selected, citations are generated at the same time as the text output and the request will be completed sooner. May result in less accurate citations.
        /// 
        /// </value>
        ///
        public enum CitationQualityEnum {
            [EnumMember(Value = "ACCURATE")]
            Accurate,
            [EnumMember(Value = "FAST")]
            Fast
        };

        /// <value>
        /// When FAST is selected, citations are generated at the same time as the text output and the request will be completed sooner. May result in less accurate citations.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "citationQuality")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CitationQualityEnum> CitationQuality { get; set; }
        
        [JsonProperty(PropertyName = "apiFormat")]
        private readonly string apiFormat = "COHERE";
    }
}