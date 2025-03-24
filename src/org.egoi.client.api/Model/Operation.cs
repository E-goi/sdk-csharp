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
    /// Operation schema
    /// </summary>
    [DataContract]
    public partial class Operation :  IEquatable<Operation>, IValidatableObject
    {
        /// <summary>
        /// Type of operation
        /// </summary>
        /// <value>Type of operation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Importcontacts for value: import_contacts
            /// </summary>
            [EnumMember(Value = "import_contacts")]
            Importcontacts = 1,

            /// <summary>
            /// Enum Updatecontacts for value: update_contacts
            /// </summary>
            [EnumMember(Value = "update_contacts")]
            Updatecontacts = 2,

            /// <summary>
            /// Enum Exportcontacts for value: export_contacts
            /// </summary>
            [EnumMember(Value = "export_contacts")]
            Exportcontacts = 3,

            /// <summary>
            /// Enum Exportreports for value: export_reports
            /// </summary>
            [EnumMember(Value = "export_reports")]
            Exportreports = 4,

            /// <summary>
            /// Enum Advancedreport for value: advanced_report
            /// </summary>
            [EnumMember(Value = "advanced_report")]
            Advancedreport = 5,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 6,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 7,

            /// <summary>
            /// Enum Smartsms for value: smart_sms
            /// </summary>
            [EnumMember(Value = "smart_sms")]
            Smartsms = 8,

            /// <summary>
            /// Enum Voice for value: voice
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice = 9,

            /// <summary>
            /// Enum Push for value: push
            /// </summary>
            [EnumMember(Value = "push")]
            Push = 10,

            /// <summary>
            /// Enum Webpush for value: webpush
            /// </summary>
            [EnumMember(Value = "webpush")]
            Webpush = 11,

            /// <summary>
            /// Enum Ads for value: ads
            /// </summary>
            [EnumMember(Value = "ads")]
            Ads = 12,

            /// <summary>
            /// Enum Social for value: social
            /// </summary>
            [EnumMember(Value = "social")]
            Social = 13,

            /// <summary>
            /// Enum Segmentgeneration for value: segment_generation
            /// </summary>
            [EnumMember(Value = "segment_generation")]
            Segmentgeneration = 14,

            /// <summary>
            /// Enum Massoperation for value: mass_operation
            /// </summary>
            [EnumMember(Value = "mass_operation")]
            Massoperation = 15,

            /// <summary>
            /// Enum Unify for value: unify
            /// </summary>
            [EnumMember(Value = "unify")]
            Unify = 16

        }

        /// <summary>
        /// Type of operation
        /// </summary>
        /// <value>Type of operation</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// State of the operation
        /// </summary>
        /// <value>State of the operation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 1,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 2,

            /// <summary>
            /// Enum Executing for value: executing
            /// </summary>
            [EnumMember(Value = "executing")]
            Executing = 3,

            /// <summary>
            /// Enum Paused for value: paused
            /// </summary>
            [EnumMember(Value = "paused")]
            Paused = 4

        }

        /// <summary>
        /// State of the operation
        /// </summary>
        /// <value>State of the operation</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Operation" /> class.
        /// </summary>
        /// <param name="operationData">operationData.</param>
        /// <param name="type">Type of operation.</param>
        /// <param name="status">State of the operation.</param>
        /// <param name="created">created.</param>
        /// <param name="startDate">startDate.</param>
        public Operation(OperationOperationData operationData = default(OperationOperationData), TypeEnum? type = default(TypeEnum?), StatusEnum? status = default(StatusEnum?), DateTime created = default(DateTime), DateTime startDate = default(DateTime))
        {
            this.Created = created;
            this.StartDate = startDate;
            this.OperationData = operationData;
            this.Type = type;
            this.Status = status;
            this.Created = created;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name="operation_id", EmitDefaultValue=false)]
        public int OperationId { get; private set; }

        /// <summary>
        /// Gets or Sets OperationData
        /// </summary>
        [DataMember(Name="operation_data", EmitDefaultValue=false)]
        public OperationOperationData OperationData { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public int CreatedBy { get; private set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=true)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationData: ").Append(OperationData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return this.Equals(input as Operation);
        }

        /// <summary>
        /// Returns true if Operation instances are equal
        /// </summary>
        /// <param name="input">Instance of Operation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.OperationData == input.OperationData ||
                    (this.OperationData != null &&
                    this.OperationData.Equals(input.OperationData))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
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
                if (this.OperationId != null)
                    hashCode = hashCode * 59 + this.OperationId.GetHashCode();
                if (this.OperationData != null)
                    hashCode = hashCode * 59 + this.OperationData.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
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


            // OperationId (int) minimum
            if(this.OperationId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationId, must be a value greater than or equal to 1.", new [] { "OperationId" });
            }



            // CreatedBy (int) minimum
            if(this.CreatedBy < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedBy, must be a value greater than or equal to 1.", new [] { "CreatedBy" });
            }

            yield break;
        }
    }

}
