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
    /// Email stats of the contact
    /// </summary>
    [DataContract]
    public partial class ContactStatsEmailStats :  IEquatable<ContactStatsEmailStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactStatsEmailStats" /> class.
        /// </summary>
        /// <param name="sent">Emails sent to the contact.</param>
        /// <param name="opens">Emails opened by the contact.</param>
        /// <param name="clicks">Total number of clicks made by the contact.</param>
        /// <param name="softBounces">Soft bounces for the contact.</param>
        /// <param name="hardBounces">Hard bounces for the contact.</param>
        /// <param name="forwards">Emails forwarded by the contact.</param>
        /// <param name="conversions">Total of conversions.</param>
        /// <param name="socialActions">Total of social actions for the contact.</param>
        /// <param name="lastSendDate">Date of the last email sent to the contact.</param>
        /// <param name="lastOpenDate">Date of the last email open of the contact.</param>
        /// <param name="lastClickDate">Date of the last email click of the contact.</param>
        /// <param name="lastOpenCountry">Country where the last email for that contact was opened.</param>
        /// <param name="lastOpenRegion">Region where the last email for that contact was opened.</param>
        /// <param name="lastOpenCity">City where the last email for that contact was opened.</param>
        public ContactStatsEmailStats(int sent = default(int), int opens = default(int), int clicks = default(int), int softBounces = default(int), int hardBounces = default(int), int forwards = default(int), int conversions = default(int), int socialActions = default(int), DateTime? lastSendDate = default(DateTime?), DateTime? lastOpenDate = default(DateTime?), DateTime? lastClickDate = default(DateTime?), string lastOpenCountry = default(string), string lastOpenRegion = default(string), string lastOpenCity = default(string))
        {
            this.LastSendDate = lastSendDate;
            this.LastOpenDate = lastOpenDate;
            this.LastClickDate = lastClickDate;
            this.LastOpenCountry = lastOpenCountry;
            this.LastOpenRegion = lastOpenRegion;
            this.LastOpenCity = lastOpenCity;
            this.Sent = sent;
            this.Opens = opens;
            this.Clicks = clicks;
            this.SoftBounces = softBounces;
            this.HardBounces = hardBounces;
            this.Forwards = forwards;
            this.Conversions = conversions;
            this.SocialActions = socialActions;
            this.LastSendDate = lastSendDate;
            this.LastOpenDate = lastOpenDate;
            this.LastClickDate = lastClickDate;
            this.LastOpenCountry = lastOpenCountry;
            this.LastOpenRegion = lastOpenRegion;
            this.LastOpenCity = lastOpenCity;
        }

        /// <summary>
        /// Emails sent to the contact
        /// </summary>
        /// <value>Emails sent to the contact</value>
        [DataMember(Name="sent", EmitDefaultValue=false)]
        public int Sent { get; set; }

        /// <summary>
        /// Emails opened by the contact
        /// </summary>
        /// <value>Emails opened by the contact</value>
        [DataMember(Name="opens", EmitDefaultValue=false)]
        public int Opens { get; set; }

        /// <summary>
        /// Total number of clicks made by the contact
        /// </summary>
        /// <value>Total number of clicks made by the contact</value>
        [DataMember(Name="clicks", EmitDefaultValue=false)]
        public int Clicks { get; set; }

        /// <summary>
        /// Soft bounces for the contact
        /// </summary>
        /// <value>Soft bounces for the contact</value>
        [DataMember(Name="soft_bounces", EmitDefaultValue=false)]
        public int SoftBounces { get; set; }

        /// <summary>
        /// Hard bounces for the contact
        /// </summary>
        /// <value>Hard bounces for the contact</value>
        [DataMember(Name="hard_bounces", EmitDefaultValue=false)]
        public int HardBounces { get; set; }

        /// <summary>
        /// Emails forwarded by the contact
        /// </summary>
        /// <value>Emails forwarded by the contact</value>
        [DataMember(Name="forwards", EmitDefaultValue=false)]
        public int Forwards { get; set; }

        /// <summary>
        /// Total of conversions
        /// </summary>
        /// <value>Total of conversions</value>
        [DataMember(Name="conversions", EmitDefaultValue=false)]
        public int Conversions { get; set; }

        /// <summary>
        /// Total of social actions for the contact
        /// </summary>
        /// <value>Total of social actions for the contact</value>
        [DataMember(Name="social_actions", EmitDefaultValue=false)]
        public int SocialActions { get; set; }

        /// <summary>
        /// Date of the last email sent to the contact
        /// </summary>
        /// <value>Date of the last email sent to the contact</value>
        [DataMember(Name="last_send_date", EmitDefaultValue=true)]
        public DateTime? LastSendDate { get; set; }

        /// <summary>
        /// Date of the last email open of the contact
        /// </summary>
        /// <value>Date of the last email open of the contact</value>
        [DataMember(Name="last_open_date", EmitDefaultValue=true)]
        public DateTime? LastOpenDate { get; set; }

        /// <summary>
        /// Date of the last email click of the contact
        /// </summary>
        /// <value>Date of the last email click of the contact</value>
        [DataMember(Name="last_click_date", EmitDefaultValue=true)]
        public DateTime? LastClickDate { get; set; }

        /// <summary>
        /// Country where the last email for that contact was opened
        /// </summary>
        /// <value>Country where the last email for that contact was opened</value>
        [DataMember(Name="last_open_country", EmitDefaultValue=true)]
        public string LastOpenCountry { get; set; }

        /// <summary>
        /// Region where the last email for that contact was opened
        /// </summary>
        /// <value>Region where the last email for that contact was opened</value>
        [DataMember(Name="last_open_region", EmitDefaultValue=true)]
        public string LastOpenRegion { get; set; }

        /// <summary>
        /// City where the last email for that contact was opened
        /// </summary>
        /// <value>City where the last email for that contact was opened</value>
        [DataMember(Name="last_open_city", EmitDefaultValue=true)]
        public string LastOpenCity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactStatsEmailStats {\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Opens: ").Append(Opens).Append("\n");
            sb.Append("  Clicks: ").Append(Clicks).Append("\n");
            sb.Append("  SoftBounces: ").Append(SoftBounces).Append("\n");
            sb.Append("  HardBounces: ").Append(HardBounces).Append("\n");
            sb.Append("  Forwards: ").Append(Forwards).Append("\n");
            sb.Append("  Conversions: ").Append(Conversions).Append("\n");
            sb.Append("  SocialActions: ").Append(SocialActions).Append("\n");
            sb.Append("  LastSendDate: ").Append(LastSendDate).Append("\n");
            sb.Append("  LastOpenDate: ").Append(LastOpenDate).Append("\n");
            sb.Append("  LastClickDate: ").Append(LastClickDate).Append("\n");
            sb.Append("  LastOpenCountry: ").Append(LastOpenCountry).Append("\n");
            sb.Append("  LastOpenRegion: ").Append(LastOpenRegion).Append("\n");
            sb.Append("  LastOpenCity: ").Append(LastOpenCity).Append("\n");
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
            return this.Equals(input as ContactStatsEmailStats);
        }

        /// <summary>
        /// Returns true if ContactStatsEmailStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactStatsEmailStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactStatsEmailStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sent == input.Sent ||
                    (this.Sent != null &&
                    this.Sent.Equals(input.Sent))
                ) && 
                (
                    this.Opens == input.Opens ||
                    (this.Opens != null &&
                    this.Opens.Equals(input.Opens))
                ) && 
                (
                    this.Clicks == input.Clicks ||
                    (this.Clicks != null &&
                    this.Clicks.Equals(input.Clicks))
                ) && 
                (
                    this.SoftBounces == input.SoftBounces ||
                    (this.SoftBounces != null &&
                    this.SoftBounces.Equals(input.SoftBounces))
                ) && 
                (
                    this.HardBounces == input.HardBounces ||
                    (this.HardBounces != null &&
                    this.HardBounces.Equals(input.HardBounces))
                ) && 
                (
                    this.Forwards == input.Forwards ||
                    (this.Forwards != null &&
                    this.Forwards.Equals(input.Forwards))
                ) && 
                (
                    this.Conversions == input.Conversions ||
                    (this.Conversions != null &&
                    this.Conversions.Equals(input.Conversions))
                ) && 
                (
                    this.SocialActions == input.SocialActions ||
                    (this.SocialActions != null &&
                    this.SocialActions.Equals(input.SocialActions))
                ) && 
                (
                    this.LastSendDate == input.LastSendDate ||
                    (this.LastSendDate != null &&
                    this.LastSendDate.Equals(input.LastSendDate))
                ) && 
                (
                    this.LastOpenDate == input.LastOpenDate ||
                    (this.LastOpenDate != null &&
                    this.LastOpenDate.Equals(input.LastOpenDate))
                ) && 
                (
                    this.LastClickDate == input.LastClickDate ||
                    (this.LastClickDate != null &&
                    this.LastClickDate.Equals(input.LastClickDate))
                ) && 
                (
                    this.LastOpenCountry == input.LastOpenCountry ||
                    (this.LastOpenCountry != null &&
                    this.LastOpenCountry.Equals(input.LastOpenCountry))
                ) && 
                (
                    this.LastOpenRegion == input.LastOpenRegion ||
                    (this.LastOpenRegion != null &&
                    this.LastOpenRegion.Equals(input.LastOpenRegion))
                ) && 
                (
                    this.LastOpenCity == input.LastOpenCity ||
                    (this.LastOpenCity != null &&
                    this.LastOpenCity.Equals(input.LastOpenCity))
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
                if (this.Sent != null)
                    hashCode = hashCode * 59 + this.Sent.GetHashCode();
                if (this.Opens != null)
                    hashCode = hashCode * 59 + this.Opens.GetHashCode();
                if (this.Clicks != null)
                    hashCode = hashCode * 59 + this.Clicks.GetHashCode();
                if (this.SoftBounces != null)
                    hashCode = hashCode * 59 + this.SoftBounces.GetHashCode();
                if (this.HardBounces != null)
                    hashCode = hashCode * 59 + this.HardBounces.GetHashCode();
                if (this.Forwards != null)
                    hashCode = hashCode * 59 + this.Forwards.GetHashCode();
                if (this.Conversions != null)
                    hashCode = hashCode * 59 + this.Conversions.GetHashCode();
                if (this.SocialActions != null)
                    hashCode = hashCode * 59 + this.SocialActions.GetHashCode();
                if (this.LastSendDate != null)
                    hashCode = hashCode * 59 + this.LastSendDate.GetHashCode();
                if (this.LastOpenDate != null)
                    hashCode = hashCode * 59 + this.LastOpenDate.GetHashCode();
                if (this.LastClickDate != null)
                    hashCode = hashCode * 59 + this.LastClickDate.GetHashCode();
                if (this.LastOpenCountry != null)
                    hashCode = hashCode * 59 + this.LastOpenCountry.GetHashCode();
                if (this.LastOpenRegion != null)
                    hashCode = hashCode * 59 + this.LastOpenRegion.GetHashCode();
                if (this.LastOpenCity != null)
                    hashCode = hashCode * 59 + this.LastOpenCity.GetHashCode();
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
