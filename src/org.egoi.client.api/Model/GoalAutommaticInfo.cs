/*
 * APIv3 (New)
 *
 *  # Introduction This is our new version of API. We invite you to start using it and give us your feedback # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.  The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.      BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication  We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:     #!/bin/bash     curl -X GET 'https://api.egoiapp.com/my-account' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:     #!/bin/bash     curl -X POST 'http://api.egoiapp.com/tags' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>' \\     -H 'Content-Type: application/json' \\     -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  # Callbacks A callback is an asynchronous API request that originates from the API server and is sent to the client in response to a previous request sent by that client.  The API will make a **POST** request to the address defined in the URL with the information regarding the event of interest and share data related to that event.  <a href='/usecases/callbacks/' target='_blank'>[Go to callbacks documentation]</a>  ***Note:*** Only http or https protocols are supported in the Url parameter.  <security-definitions/>
 *
 * The version of the OpenAPI document: 3.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = org.egoi.client.api.Client.OpenAPIDateConverter;

namespace org.egoi.client.api.Model
{
    /// <summary>
    /// Automatic goal info schema
    /// </summary>
    [DataContract]
    public partial class GoalAutommaticInfo :  IEquatable<GoalAutommaticInfo>, IValidatableObject
    {
        /// <summary>
        /// Goal type
        /// </summary>
        /// <value>Goal type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Automatic for value: automatic
            /// </summary>
            [EnumMember(Value = "automatic")]
            Automatic = 1

        }

        /// <summary>
        /// Goal type
        /// </summary>
        /// <value>Goal type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Goal rule
        /// </summary>
        /// <value>Goal rule</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RuleEnum
        {
            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 1,

            /// <summary>
            /// Enum Title for value: title
            /// </summary>
            [EnumMember(Value = "title")]
            Title = 2,

            /// <summary>
            /// Enum Download for value: download
            /// </summary>
            [EnumMember(Value = "download")]
            Download = 3,

            /// <summary>
            /// Enum Externalurl for value: external_url
            /// </summary>
            [EnumMember(Value = "external_url")]
            Externalurl = 4

        }

        /// <summary>
        /// Goal rule
        /// </summary>
        /// <value>Goal rule</value>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public RuleEnum? Rule { get; set; }
        /// <summary>
        /// Goal condition
        /// </summary>
        /// <value>Goal condition</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConditionEnum
        {
            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 1,

            /// <summary>
            /// Enum Exactly for value: exactly
            /// </summary>
            [EnumMember(Value = "exactly")]
            Exactly = 2,

            /// <summary>
            /// Enum Regex for value: regex
            /// </summary>
            [EnumMember(Value = "regex")]
            Regex = 3

        }

        /// <summary>
        /// Goal condition
        /// </summary>
        /// <value>Goal condition</value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalAutommaticInfo" /> class.
        /// </summary>
        /// <param name="type">Goal type.</param>
        /// <param name="rule">Goal rule.</param>
        /// <param name="condition">Goal condition.</param>
        /// <param name="pattern">Goal pattern.</param>
        /// <param name="caseSensitive">Goal pattern case sensitive.</param>
        /// <param name="multipleConversion">Goal is multiple conversion.</param>
        public GoalAutommaticInfo(TypeEnum? type = default(TypeEnum?), RuleEnum? rule = default(RuleEnum?), ConditionEnum? condition = default(ConditionEnum?), string pattern = default(string), bool caseSensitive = default(bool), bool multipleConversion = default(bool))
        {
            this.Type = type;
            this.Rule = rule;
            this.Condition = condition;
            this.Pattern = pattern;
            this.CaseSensitive = caseSensitive;
            this.MultipleConversion = multipleConversion;
        }




        /// <summary>
        /// Goal pattern
        /// </summary>
        /// <value>Goal pattern</value>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Goal pattern case sensitive
        /// </summary>
        /// <value>Goal pattern case sensitive</value>
        [DataMember(Name="case_sensitive", EmitDefaultValue=false)]
        public bool CaseSensitive { get; set; }

        /// <summary>
        /// Goal is multiple conversion
        /// </summary>
        /// <value>Goal is multiple conversion</value>
        [DataMember(Name="multiple_conversion", EmitDefaultValue=false)]
        public bool MultipleConversion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoalAutommaticInfo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  CaseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  MultipleConversion: ").Append(MultipleConversion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GoalAutommaticInfo);
        }

        /// <summary>
        /// Returns true if GoalAutommaticInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalAutommaticInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalAutommaticInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Rule == input.Rule ||
                    (this.Rule != null &&
                    this.Rule.Equals(input.Rule))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.CaseSensitive == input.CaseSensitive ||
                    (this.CaseSensitive != null &&
                    this.CaseSensitive.Equals(input.CaseSensitive))
                ) && 
                (
                    this.MultipleConversion == input.MultipleConversion ||
                    (this.MultipleConversion != null &&
                    this.MultipleConversion.Equals(input.MultipleConversion))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.CaseSensitive != null)
                    hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.MultipleConversion != null)
                    hashCode = hashCode * 59 + this.MultipleConversion.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
