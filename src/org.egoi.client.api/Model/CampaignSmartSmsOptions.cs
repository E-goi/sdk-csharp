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
    /// CampaignSmartSmsOptions
    /// </summary>
    [DataContract]
    public partial class CampaignSmartSmsOptions :  IEquatable<CampaignSmartSmsOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines Encoding
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncodingEnum
        {
            /// <summary>
            /// Enum Gsm for value: gsm
            /// </summary>
            [EnumMember(Value = "gsm")]
            Gsm = 1,

            /// <summary>
            /// Enum Gsmextended for value: gsm_extended
            /// </summary>
            [EnumMember(Value = "gsm_extended")]
            Gsmextended = 2,

            /// <summary>
            /// Enum Unicode for value: unicode
            /// </summary>
            [EnumMember(Value = "unicode")]
            Unicode = 3

        }

        /// <summary>
        /// Gets or Sets Encoding
        /// </summary>
        [DataMember(Name="encoding", EmitDefaultValue=false)]
        public EncodingEnum? Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSmartSmsOptions" /> class.
        /// </summary>
        /// <param name="encoding">encoding.</param>
        /// <param name="maxMessages">maxMessages.</param>
        public CampaignSmartSmsOptions(EncodingEnum? encoding = default(EncodingEnum?), int maxMessages = default(int))
        {
            this.Encoding = encoding;
            this.MaxMessages = maxMessages;
        }


        /// <summary>
        /// Gets or Sets MaxMessages
        /// </summary>
        [DataMember(Name="max_messages", EmitDefaultValue=false)]
        public int MaxMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignSmartSmsOptions {\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  MaxMessages: ").Append(MaxMessages).Append("\n");
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
            return this.Equals(input as CampaignSmartSmsOptions);
        }

        /// <summary>
        /// Returns true if CampaignSmartSmsOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignSmartSmsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignSmartSmsOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Encoding == input.Encoding ||
                    (this.Encoding != null &&
                    this.Encoding.Equals(input.Encoding))
                ) && 
                (
                    this.MaxMessages == input.MaxMessages ||
                    (this.MaxMessages != null &&
                    this.MaxMessages.Equals(input.MaxMessages))
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
                if (this.Encoding != null)
                    hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.MaxMessages != null)
                    hashCode = hashCode * 59 + this.MaxMessages.GetHashCode();
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


            // MaxMessages (int) maximum
            if(this.MaxMessages > (int)7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxMessages, must be a value less than or equal to 7.", new [] { "MaxMessages" });
            }

            // MaxMessages (int) minimum
            if(this.MaxMessages < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxMessages, must be a value greater than or equal to 1.", new [] { "MaxMessages" });
            }

            yield break;
        }
    }

}
