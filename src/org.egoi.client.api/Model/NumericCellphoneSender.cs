/*
 * APIv3 (New)
 *
 *  # Introduction This is our new version of API. We invite you to start using it and give us your feedback # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.  The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.      BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication  We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:     #!/bin/bash     curl -X GET 'https://api.egoiapp.com/my-account' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:     #!/bin/bash     curl -X POST 'http://api.egoiapp.com/tags' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>' \\     -H 'Content-Type: application/json' \\     -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  # Callbacks A callback is an asynchronous API request that originates from the API server and is sent to the client in response to a previous request sent by that client.  The API will make a **POST** request to the address defined in the URL with the information regarding the event of interest and share data related to that event.  ***Note:*** Only http or https protocols are supported in the Url parameter.  <security-definitions/>
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
    /// Numeric cellphone sender schema
    /// </summary>
    [DataContract]
    public partial class NumericCellphoneSender :  IEquatable<NumericCellphoneSender>, IValidatableObject
    {
        /// <summary>
        /// Sender code type
        /// </summary>
        /// <value>Sender code type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Alphanumeric for value: alpha_numeric
            /// </summary>
            [EnumMember(Value = "alpha_numeric")]
            Alphanumeric = 1,

            /// <summary>
            /// Enum Numeric for value: numeric
            /// </summary>
            [EnumMember(Value = "numeric")]
            Numeric = 2

        }

        /// <summary>
        /// Sender code type
        /// </summary>
        /// <value>Sender code type</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Status of the sender
        /// </summary>
        /// <value>Status of the sender</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Moderation for value: moderation
            /// </summary>
            [EnumMember(Value = "moderation")]
            Moderation = 2,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 3

        }

        /// <summary>
        /// Status of the sender
        /// </summary>
        /// <value>Status of the sender</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericCellphoneSender" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NumericCellphoneSender() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumericCellphoneSender" /> class.
        /// </summary>
        /// <param name="cellphone">Sender cellphone (country code followed by phone number, split by &#39;-&#39;) (required).</param>
        /// <param name="type">Sender code type (required).</param>
        public NumericCellphoneSender(string cellphone = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "cellphone" is required (not null)
            if (cellphone == null)
            {
                throw new InvalidDataException("cellphone is a required property for NumericCellphoneSender and cannot be null");
            }
            else
            {
                this.Cellphone = cellphone;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for NumericCellphoneSender and cannot be null");
            }
            else
            {
                this.Type = type;
            }

        }

        /// <summary>
        /// Sender cellphone (country code followed by phone number, split by &#39;-&#39;)
        /// </summary>
        /// <value>Sender cellphone (country code followed by phone number, split by &#39;-&#39;)</value>
        [DataMember(Name="cellphone", EmitDefaultValue=true)]
        public string Cellphone { get; set; }


        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=true)]
        public int SenderId { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumericCellphoneSender {\n");
            sb.Append("  Cellphone: ").Append(Cellphone).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as NumericCellphoneSender);
        }

        /// <summary>
        /// Returns true if NumericCellphoneSender instances are equal
        /// </summary>
        /// <param name="input">Instance of NumericCellphoneSender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumericCellphoneSender input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cellphone == input.Cellphone ||
                    (this.Cellphone != null &&
                    this.Cellphone.Equals(input.Cellphone))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Cellphone != null)
                    hashCode = hashCode * 59 + this.Cellphone.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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


            // Cellphone (string) pattern
            Regex regexCellphone = new Regex(@"^(){0,1}(\\d){1,3}-(\\d){4,20}$", RegexOptions.CultureInvariant);
            if (false == regexCellphone.Match(this.Cellphone).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cellphone, must match a pattern of " + regexCellphone, new [] { "Cellphone" });
            }



            // SenderId (int) minimum
            if(this.SenderId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderId, must be a value greater than or equal to 1.", new [] { "SenderId" });
            }

            yield break;
        }
    }

}
