/*
 * Marketing API
 *
 *  # Introduction Welcome to the E-goi Marketing API! <br><br>This API enables you to integrate, automate, and manage all the marketing functionalities offered by E-goi. With it, you can interact with contact lists, send email campaigns, SMS, push notifications, and much more. <br><br>Our API is designed to simplify integration in a straightforward, efficient, and secure way, meeting the needs of developers and businesses looking to optimize their digital marketing operations. <br><br>Explore the documentation to discover all the possibilities and start creating integrations that drive your marketing results. # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.  The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.      BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Transport Layer Security (TLS) Transport Layer Security (TLS) is a widely used authentication and encryption protocol that establishes a secure communications channel for data-in-transit while ensuring that the client and server can validate one another.<br> Our API requires TLS 1.2 or TLS 1.3. We recommend <b>TLS 1.3</b>.<br><br> <b>TLS 1.3 ciphers</b> * TLS_AES_256_GCM_SHA384 (0x1302) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_CHACHA20_POLY1305_SHA256 (0x1303) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_AES_128_GCM_SHA256 (0x1301) ECDH x25519 (eq. 3072 bits RSA) FS  <b>TLS 1.2 ciphers</b> * TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 (0xc030) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 (0xc02f) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 (0x9f) DH 4096 bits FS * TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 (0x9e) DH 4096 bits FS  # Rate Limits Rate limits are used to control the amount of traffic that is allowed to flow between the client and the server.<br> This is done to prevent abuse and ensure that the API is available to all users.<br> The rate limits are applied to ensure the stability and security of our API and are based on the number of requests made in a given time period.<br> If the rate limit is exceeded, the API will return a 429 status code and the request will be rejected.<br> Each API response includes headers providing real-time rate limit information: * **X-RateLimit-Limit**: The maximum number of requests that the consumer is permitted to make in a given time period. * **X-RateLimit-Remaining**: The number of requests remaining in the current rate limit window. * **X-RateLimit-Reset**: The remaining time in seconds until the rate limit window resets.  # Account Limit The account limit is a rate limit that is applied to the account as a whole.<br> This limit is applied to all requests made by the account, regardless of the client making the request.<br> The account limit is applied to ensure that the account does not exceed the maximum number of requests allowed in a given time period. Each account has an overall usage limit per hour. If the account limit is exceeded, the API will return a 429 status code and the request will be rejected.<br> Each API response includes headers providing real-time rate limit information: * **X-Account-Limit**: The maximum number of requests that the account is permitted to make in a given time period. * **X-Account-Remaining**: The number of requests remaining in the current rate limit window. * **X-Account-Reset**: The remaining time in seconds until the rate limit window resets.   # Authentication  We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:     #!/bin/bash     curl -X GET 'https://api.egoiapp.com/my-account' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:     #!/bin/bash     curl -X POST 'http://api.egoiapp.com/tags' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>' \\     -H 'Content-Type: application/json' \\     -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  # Callbacks A callback is an asynchronous API request that originates from the API server and is sent to the client in response to a previous request sent by that client.  The API will make a **POST** request to the address defined in the URL with the information regarding the event of interest and share data related to that event.  <a href='/usecases/callbacks/' target='_blank'>[Go to callbacks documentation]</a>  ***Note:*** Only http or https protocols are supported in the Url parameter.  <security-definitions/>
 *
 * The version of the OpenAPI document: V3
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = org.egoi.client.api.Client.OpenAPIDateConverter;

namespace org.egoi.client.api.Model
{
    /// <summary>
    /// GoalInfo
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    public partial class GoalInfo :  IEquatable<GoalInfo>, IValidatableObject
    {
        /// <summary>
        /// Goal type
        /// </summary>
        /// <value>Goal type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Time for value: time
            /// </summary>
            [EnumMember(Value = "time")]
            Time = 1

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
        /// Initializes a new instance of the <see cref="GoalInfo" /> class.
        /// </summary>
        /// <param name="type">Goal type.</param>
        /// <param name="multipleConversion">Goal is multiple conversion.</param>
        /// <param name="rule">Goal rule.</param>
        /// <param name="condition">Goal condition.</param>
        /// <param name="pattern">Goal pattern.</param>
        /// <param name="caseSensitive">Goal pattern case sensitive.</param>
        /// <param name="minutes">Goal trigger time in minutes.</param>
        public GoalInfo(TypeEnum? type = default(TypeEnum?), bool multipleConversion = default(bool), RuleEnum? rule = default(RuleEnum?), ConditionEnum? condition = default(ConditionEnum?), string pattern = default(string), bool caseSensitive = default(bool), double minutes = default(double))
        {
            this.Type = type;
            this.MultipleConversion = multipleConversion;
            this.Rule = rule;
            this.Condition = condition;
            this.Pattern = pattern;
            this.CaseSensitive = caseSensitive;
            this.Minutes = minutes;
        }


        /// <summary>
        /// Goal is multiple conversion
        /// </summary>
        /// <value>Goal is multiple conversion</value>
        [DataMember(Name="multiple_conversion", EmitDefaultValue=false)]
        public bool MultipleConversion { get; set; }



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
        /// Goal trigger time in minutes
        /// </summary>
        /// <value>Goal trigger time in minutes</value>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public double Minutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoalInfo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MultipleConversion: ").Append(MultipleConversion).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  CaseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
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
            return this.Equals(input as GoalInfo);
        }

        /// <summary>
        /// Returns true if GoalInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalInfo input)
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
                    this.MultipleConversion == input.MultipleConversion ||
                    (this.MultipleConversion != null &&
                    this.MultipleConversion.Equals(input.MultipleConversion))
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
                    this.Minutes == input.Minutes ||
                    (this.Minutes != null &&
                    this.Minutes.Equals(input.Minutes))
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
                if (this.MultipleConversion != null)
                    hashCode = hashCode * 59 + this.MultipleConversion.GetHashCode();
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.CaseSensitive != null)
                    hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.Minutes != null)
                    hashCode = hashCode * 59 + this.Minutes.GetHashCode();
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
