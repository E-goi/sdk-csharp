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
    /// Contact campaign activity schema
    /// </summary>
    [DataContract]
    public partial class ContactCampaignActivity :  IEquatable<ContactCampaignActivity>, IValidatableObject
    {
        /// <summary>
        /// Action name
        /// </summary>
        /// <value>Action name</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionNameEnum
        {
            /// <summary>
            /// Enum Emailopen for value: email_open
            /// </summary>
            [EnumMember(Value = "email_open")]
            Emailopen = 1,

            /// <summary>
            /// Enum Forward for value: forward
            /// </summary>
            [EnumMember(Value = "forward")]
            Forward = 2,

            /// <summary>
            /// Enum Emailsend for value: email_send
            /// </summary>
            [EnumMember(Value = "email_send")]
            Emailsend = 3,

            /// <summary>
            /// Enum Smssend for value: sms_send
            /// </summary>
            [EnumMember(Value = "sms_send")]
            Smssend = 4,

            /// <summary>
            /// Enum Voicesend for value: voice_send
            /// </summary>
            [EnumMember(Value = "voice_send")]
            Voicesend = 5,

            /// <summary>
            /// Enum Smsreport for value: sms_report
            /// </summary>
            [EnumMember(Value = "sms_report")]
            Smsreport = 6,

            /// <summary>
            /// Enum Voicereport for value: voice_report
            /// </summary>
            [EnumMember(Value = "voice_report")]
            Voicereport = 7,

            /// <summary>
            /// Enum Invitationsend for value: invitation_send
            /// </summary>
            [EnumMember(Value = "invitation_send")]
            Invitationsend = 8,

            /// <summary>
            /// Enum Invitationopen for value: invitation_open
            /// </summary>
            [EnumMember(Value = "invitation_open")]
            Invitationopen = 9,

            /// <summary>
            /// Enum Emailsoftbounce for value: email_soft_bounce
            /// </summary>
            [EnumMember(Value = "email_soft_bounce")]
            Emailsoftbounce = 10,

            /// <summary>
            /// Enum Emailhardbounce for value: email_hard_bounce
            /// </summary>
            [EnumMember(Value = "email_hard_bounce")]
            Emailhardbounce = 11,

            /// <summary>
            /// Enum Doubleoptin for value: double_optin
            /// </summary>
            [EnumMember(Value = "double_optin")]
            Doubleoptin = 12,

            /// <summary>
            /// Enum Doubleoptinresend for value: double_optin_resend
            /// </summary>
            [EnumMember(Value = "double_optin_resend")]
            Doubleoptinresend = 13,

            /// <summary>
            /// Enum Emailspamcomplaint for value: email_spam_complaint
            /// </summary>
            [EnumMember(Value = "email_spam_complaint")]
            Emailspamcomplaint = 14,

            /// <summary>
            /// Enum Doubleoptedit for value: double_optedit
            /// </summary>
            [EnumMember(Value = "double_optedit")]
            Doubleoptedit = 15,

            /// <summary>
            /// Enum Pushsend for value: push_send
            /// </summary>
            [EnumMember(Value = "push_send")]
            Pushsend = 16,

            /// <summary>
            /// Enum Pushopen for value: push_open
            /// </summary>
            [EnumMember(Value = "push_open")]
            Pushopen = 17,

            /// <summary>
            /// Enum Pushreceived for value: push_received
            /// </summary>
            [EnumMember(Value = "push_received")]
            Pushreceived = 18,

            /// <summary>
            /// Enum Pusherror for value: push_error
            /// </summary>
            [EnumMember(Value = "push_error")]
            Pusherror = 19,

            /// <summary>
            /// Enum Pushcanceled for value: push_canceled
            /// </summary>
            [EnumMember(Value = "push_canceled")]
            Pushcanceled = 20,

            /// <summary>
            /// Enum Replytoemail for value: reply_to_email
            /// </summary>
            [EnumMember(Value = "reply_to_email")]
            Replytoemail = 21,

            /// <summary>
            /// Enum Webpushsend for value: web_push_send
            /// </summary>
            [EnumMember(Value = "web_push_send")]
            Webpushsend = 22,

            /// <summary>
            /// Enum Webpushdelivered for value: web_push_delivered
            /// </summary>
            [EnumMember(Value = "web_push_delivered")]
            Webpushdelivered = 23,

            /// <summary>
            /// Enum Webpushopen for value: web_push_open
            /// </summary>
            [EnumMember(Value = "web_push_open")]
            Webpushopen = 24,

            /// <summary>
            /// Enum Webpushbounce for value: web_push_bounce
            /// </summary>
            [EnumMember(Value = "web_push_bounce")]
            Webpushbounce = 25,

            /// <summary>
            /// Enum Voicemenuevent for value: voice_menu_event
            /// </summary>
            [EnumMember(Value = "voice_menu_event")]
            Voicemenuevent = 26,

            /// <summary>
            /// Enum Voiceredirect for value: voice_redirect
            /// </summary>
            [EnumMember(Value = "voice_redirect")]
            Voiceredirect = 27,

            /// <summary>
            /// Enum Pushdelivered for value: push_delivered
            /// </summary>
            [EnumMember(Value = "push_delivered")]
            Pushdelivered = 28,

            /// <summary>
            /// Enum Smartsmssend for value: smart_sms_send
            /// </summary>
            [EnumMember(Value = "smart_sms_send")]
            Smartsmssend = 29,

            /// <summary>
            /// Enum Smartsmsopen for value: smart_sms_open
            /// </summary>
            [EnumMember(Value = "smart_sms_open")]
            Smartsmsopen = 30,

            /// <summary>
            /// Enum Smartsmsreport for value: smart_sms_report
            /// </summary>
            [EnumMember(Value = "smart_sms_report")]
            Smartsmsreport = 31

        }

        /// <summary>
        /// Action name
        /// </summary>
        /// <value>Action name</value>
        [DataMember(Name="action_name", EmitDefaultValue=false)]
        public ActionNameEnum? ActionName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactCampaignActivity" /> class.
        /// </summary>
        /// <param name="actionData">actionData.</param>
        /// <param name="date">The date and time.</param>
        /// <param name="actionName">Action name.</param>
        public ContactCampaignActivity(ContactCampaignActivityAllOfActionData actionData = default(ContactCampaignActivityAllOfActionData), DateTime date = default(DateTime), ActionNameEnum? actionName = default(ActionNameEnum?))
        {
            this.ActionData = actionData;
            this.Date = date;
            this.ActionName = actionName;
        }

        /// <summary>
        /// Gets or Sets ActionData
        /// </summary>
        [DataMember(Name="action_data", EmitDefaultValue=false)]
        public ContactCampaignActivityAllOfActionData ActionData { get; set; }

        /// <summary>
        /// The date and time
        /// </summary>
        /// <value>The date and time</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactCampaignActivity {\n");
            sb.Append("  ActionData: ").Append(ActionData).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
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
            return this.Equals(input as ContactCampaignActivity);
        }

        /// <summary>
        /// Returns true if ContactCampaignActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactCampaignActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactCampaignActivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionData == input.ActionData ||
                    (this.ActionData != null &&
                    this.ActionData.Equals(input.ActionData))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.ActionName == input.ActionName ||
                    (this.ActionName != null &&
                    this.ActionName.Equals(input.ActionName))
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
                if (this.ActionData != null)
                    hashCode = hashCode * 59 + this.ActionData.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.ActionName != null)
                    hashCode = hashCode * 59 + this.ActionName.GetHashCode();
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
