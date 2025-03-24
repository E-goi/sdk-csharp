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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = org.egoi.client.api.Client.OpenAPIDateConverter;

namespace org.egoi.client.api.Model
{
    /// <summary>
    /// Contact import bulk request schema
    /// </summary>
    [DataContract]
    public partial class ImportBulkRequest :  IEquatable<ImportBulkRequest>, IValidatableObject
    {
        /// <summary>
        /// Add new contacts only (&#39;add&#39;), add and replace existing ones (&#39;update&#39;) or only replace existing ones (&#39;update_only&#39;)
        /// </summary>
        /// <value>Add new contacts only (&#39;add&#39;), add and replace existing ones (&#39;update&#39;) or only replace existing ones (&#39;update_only&#39;)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Add for value: add
            /// </summary>
            [EnumMember(Value = "add")]
            Add = 1,

            /// <summary>
            /// Enum Update for value: update
            /// </summary>
            [EnumMember(Value = "update")]
            Update = 2,

            /// <summary>
            /// Enum Updateonly for value: update_only
            /// </summary>
            [EnumMember(Value = "update_only")]
            Updateonly = 3

        }

        /// <summary>
        /// Add new contacts only (&#39;add&#39;), add and replace existing ones (&#39;update&#39;) or only replace existing ones (&#39;update_only&#39;)
        /// </summary>
        /// <value>Add new contacts only (&#39;add&#39;), add and replace existing ones (&#39;update&#39;) or only replace existing ones (&#39;update_only&#39;)</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBulkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportBulkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBulkRequest" /> class.
        /// </summary>
        /// <param name="mode">Add new contacts only (&#39;add&#39;), add and replace existing ones (&#39;update&#39;) or only replace existing ones (&#39;update_only&#39;) (required).</param>
        /// <param name="compareField">Field ID which will be mapped for comparison to prevent duplicates. Field must be set as unique in E-goi. (required).</param>
        /// <param name="contacts">Array of contacts to import (required).</param>
        /// <param name="forceEmpty">If &#39;true&#39; accepts empty values and erases those fields (default to false).</param>
        /// <param name="notify">Array of IDs of the users to notify.</param>
        /// <param name="callbackUrl">Url to receive the report &lt;a href&#x3D;&#39;/usecases/callbacks/#import-collection-of-contacts&#39; target&#x3D;&#39;_blank&#39;&gt;[Go to callback documentation]&lt;/a&gt;.</param>
        public ImportBulkRequest(ModeEnum mode = default(ModeEnum), string compareField = default(string), List<ContactBulk> contacts = default(List<ContactBulk>), bool forceEmpty = false, List<int> notify = default(List<int>), string callbackUrl = default(string))
        {
            // to ensure "mode" is required (not null)
            if (mode == null)
            {
                throw new InvalidDataException("mode is a required property for ImportBulkRequest and cannot be null");
            }
            else
            {
                this.Mode = mode;
            }

            // to ensure "compareField" is required (not null)
            if (compareField == null)
            {
                throw new InvalidDataException("compareField is a required property for ImportBulkRequest and cannot be null");
            }
            else
            {
                this.CompareField = compareField;
            }

            // to ensure "contacts" is required (not null)
            if (contacts == null)
            {
                throw new InvalidDataException("contacts is a required property for ImportBulkRequest and cannot be null");
            }
            else
            {
                this.Contacts = contacts;
            }

            // use default value if no "forceEmpty" provided
            if (forceEmpty == null)
            {
                this.ForceEmpty = false;
            }
            else
            {
                this.ForceEmpty = forceEmpty;
            }
            this.Notify = notify;
            this.CallbackUrl = callbackUrl;
        }


        /// <summary>
        /// Field ID which will be mapped for comparison to prevent duplicates. Field must be set as unique in E-goi.
        /// </summary>
        /// <value>Field ID which will be mapped for comparison to prevent duplicates. Field must be set as unique in E-goi.</value>
        [DataMember(Name="compare_field", EmitDefaultValue=true)]
        public string CompareField { get; set; }

        /// <summary>
        /// Array of contacts to import
        /// </summary>
        /// <value>Array of contacts to import</value>
        [DataMember(Name="contacts", EmitDefaultValue=true)]
        public List<ContactBulk> Contacts { get; set; }

        /// <summary>
        /// If &#39;true&#39; accepts empty values and erases those fields
        /// </summary>
        /// <value>If &#39;true&#39; accepts empty values and erases those fields</value>
        [DataMember(Name="force_empty", EmitDefaultValue=false)]
        public bool ForceEmpty { get; set; }

        /// <summary>
        /// Array of IDs of the users to notify
        /// </summary>
        /// <value>Array of IDs of the users to notify</value>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public List<int> Notify { get; set; }

        /// <summary>
        /// Url to receive the report &lt;a href&#x3D;&#39;/usecases/callbacks/#import-collection-of-contacts&#39; target&#x3D;&#39;_blank&#39;&gt;[Go to callback documentation]&lt;/a&gt;
        /// </summary>
        /// <value>Url to receive the report &lt;a href&#x3D;&#39;/usecases/callbacks/#import-collection-of-contacts&#39; target&#x3D;&#39;_blank&#39;&gt;[Go to callback documentation]&lt;/a&gt;</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportBulkRequest {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  CompareField: ").Append(CompareField).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  ForceEmpty: ").Append(ForceEmpty).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
            return this.Equals(input as ImportBulkRequest);
        }

        /// <summary>
        /// Returns true if ImportBulkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportBulkRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.CompareField == input.CompareField ||
                    (this.CompareField != null &&
                    this.CompareField.Equals(input.CompareField))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.ForceEmpty == input.ForceEmpty ||
                    (this.ForceEmpty != null &&
                    this.ForceEmpty.Equals(input.ForceEmpty))
                ) && 
                (
                    this.Notify == input.Notify ||
                    this.Notify != null &&
                    input.Notify != null &&
                    this.Notify.SequenceEqual(input.Notify)
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.CompareField != null)
                    hashCode = hashCode * 59 + this.CompareField.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.ForceEmpty != null)
                    hashCode = hashCode * 59 + this.ForceEmpty.GetHashCode();
                if (this.Notify != null)
                    hashCode = hashCode * 59 + this.Notify.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
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
