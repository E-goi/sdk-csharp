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
    /// ContactInsideBaseWithId
    /// </summary>
    [DataContract]
    public partial class ContactInsideBaseWithId :  IEquatable<ContactInsideBaseWithId>, IValidatableObject
    {
        /// <summary>
        /// Status of the contact
        /// </summary>
        /// <value>Status of the contact</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2,

            /// <summary>
            /// Enum Removed for value: removed
            /// </summary>
            [EnumMember(Value = "removed")]
            Removed = 3,

            /// <summary>
            /// Enum Unconfirmed for value: unconfirmed
            /// </summary>
            [EnumMember(Value = "unconfirmed")]
            Unconfirmed = 4

        }

        /// <summary>
        /// Status of the contact
        /// </summary>
        /// <value>Status of the contact</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Contact consent
        /// </summary>
        /// <value>Contact consent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConsentEnum
        {
            /// <summary>
            /// Enum Any for value: any
            /// </summary>
            [EnumMember(Value = "any")]
            Any = 1,

            /// <summary>
            /// Enum Consent for value: consent
            /// </summary>
            [EnumMember(Value = "consent")]
            Consent = 2,

            /// <summary>
            /// Enum Contract for value: contract
            /// </summary>
            [EnumMember(Value = "contract")]
            Contract = 3,

            /// <summary>
            /// Enum Legitimateinterest for value: legitimate_interest
            /// </summary>
            [EnumMember(Value = "legitimate_interest")]
            Legitimateinterest = 4,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 5,

            /// <summary>
            /// Enum Protectvitalinterests for value: protect_vital_interests
            /// </summary>
            [EnumMember(Value = "protect_vital_interests")]
            Protectvitalinterests = 6,

            /// <summary>
            /// Enum Publicinterests for value: public_interests
            /// </summary>
            [EnumMember(Value = "public_interests")]
            Publicinterests = 7,

            /// <summary>
            /// Enum Requiredbylaw for value: required_by_law
            /// </summary>
            [EnumMember(Value = "required_by_law")]
            Requiredbylaw = 8,

            /// <summary>
            /// Enum Withdrawn for value: withdrawn
            /// </summary>
            [EnumMember(Value = "withdrawn")]
            Withdrawn = 9

        }

        /// <summary>
        /// Contact consent
        /// </summary>
        /// <value>Contact consent</value>
        [DataMember(Name="consent", EmitDefaultValue=false)]
        public ConsentEnum? Consent { get; set; }
        /// <summary>
        /// Contact subscription method
        /// </summary>
        /// <value>Contact subscription method</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubscriptionMethodEnum
        {
            /// <summary>
            /// Enum Manual for value: manual
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual = 1,

            /// <summary>
            /// Enum Form for value: form
            /// </summary>
            [EnumMember(Value = "form")]
            Form = 2,

            /// <summary>
            /// Enum Imported for value: imported
            /// </summary>
            [EnumMember(Value = "imported")]
            Imported = 3,

            /// <summary>
            /// Enum Referral for value: referral
            /// </summary>
            [EnumMember(Value = "referral")]
            Referral = 4,

            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 5

        }

        /// <summary>
        /// Contact subscription method
        /// </summary>
        /// <value>Contact subscription method</value>
        [DataMember(Name="subscription_method", EmitDefaultValue=false)]
        public SubscriptionMethodEnum? SubscriptionMethod { get; set; }
        /// <summary>
        /// Contact unsubscription method
        /// </summary>
        /// <value>Contact unsubscription method</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnsubscriptionMethodEnum
        {
            /// <summary>
            /// Enum Manual for value: manual
            /// </summary>
            [EnumMember(Value = "manual")]
            Manual = 1,

            /// <summary>
            /// Enum Form for value: form
            /// </summary>
            [EnumMember(Value = "form")]
            Form = 2,

            /// <summary>
            /// Enum Unsubscribelink for value: unsubscribe_link
            /// </summary>
            [EnumMember(Value = "unsubscribe_link")]
            Unsubscribelink = 3,

            /// <summary>
            /// Enum Bounce for value: bounce
            /// </summary>
            [EnumMember(Value = "bounce")]
            Bounce = 4,

            /// <summary>
            /// Enum Api for value: api
            /// </summary>
            [EnumMember(Value = "api")]
            Api = 5,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 6

        }

        /// <summary>
        /// Contact unsubscription method
        /// </summary>
        /// <value>Contact unsubscription method</value>
        [DataMember(Name="unsubscription_method", EmitDefaultValue=false)]
        public UnsubscriptionMethodEnum? UnsubscriptionMethod { get; set; }
        /// <summary>
        /// Contact unsubscription reason
        /// </summary>
        /// <value>Contact unsubscription reason</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnsubscriptionReasonEnum
        {
            /// <summary>
            /// Enum Notinterested for value: not_interested
            /// </summary>
            [EnumMember(Value = "not_interested")]
            Notinterested = 1,

            /// <summary>
            /// Enum Lackoftime for value: lack_of_time
            /// </summary>
            [EnumMember(Value = "lack_of_time")]
            Lackoftime = 2,

            /// <summary>
            /// Enum Emailaddresschange for value: email_address_change
            /// </summary>
            [EnumMember(Value = "email_address_change")]
            Emailaddresschange = 3,

            /// <summary>
            /// Enum Spam for value: spam
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam = 4,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 6

        }

        /// <summary>
        /// Contact unsubscription reason
        /// </summary>
        /// <value>Contact unsubscription reason</value>
        [DataMember(Name="unsubscription_reason", EmitDefaultValue=false)]
        public UnsubscriptionReasonEnum? UnsubscriptionReason { get; set; }
        /// <summary>
        /// Email channel status
        /// </summary>
        /// <value>Email channel status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmailStatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }

        /// <summary>
        /// Email channel status
        /// </summary>
        /// <value>Email channel status</value>
        [DataMember(Name="email_status", EmitDefaultValue=false)]
        public EmailStatusEnum? EmailStatus { get; set; }
        /// <summary>
        /// Cellphone channel status
        /// </summary>
        /// <value>Cellphone channel status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CellphoneStatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }

        /// <summary>
        /// Cellphone channel status
        /// </summary>
        /// <value>Cellphone channel status</value>
        [DataMember(Name="cellphone_status", EmitDefaultValue=false)]
        public CellphoneStatusEnum? CellphoneStatus { get; set; }
        /// <summary>
        /// Phone channel status
        /// </summary>
        /// <value>Phone channel status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhoneStatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }

        /// <summary>
        /// Phone channel status
        /// </summary>
        /// <value>Phone channel status</value>
        [DataMember(Name="phone_status", EmitDefaultValue=false)]
        public PhoneStatusEnum? PhoneStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInsideBaseWithId" /> class.
        /// </summary>
        /// <param name="contactId">contactId.</param>
        /// <param name="status">Status of the contact (default to StatusEnum.Active).</param>
        /// <param name="firstName">First name of the contact.</param>
        /// <param name="lastName">Last name of the contact.</param>
        /// <param name="birthDate">Birth date of the contact.</param>
        /// <param name="language">language.</param>
        /// <param name="email">Email of the contact.</param>
        /// <param name="cellphone">Cellphone of the contact.</param>
        /// <param name="phone">Phone of the contact.</param>
        /// <param name="pushTokenAndroid">Android push token of the contact.</param>
        /// <param name="pushTokenIos">IOS push token of the contact.</param>
        public ContactInsideBaseWithId(string contactId = default(string), StatusEnum? status = StatusEnum.Active, string firstName = default(string), string lastName = default(string), DateTime birthDate = default(DateTime), Language language = default(Language), string email = default(string), string cellphone = default(string), string phone = default(string), List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid> pushTokenAndroid = default(List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid>), List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos> pushTokenIos = default(List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos>))
        {
            this.ContactId = contactId;
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = StatusEnum.Active;
            }
            else
            {
                this.Status = status;
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Language = language;
            this.Email = email;
            this.Cellphone = cellphone;
            this.Phone = phone;
            this.PushTokenAndroid = pushTokenAndroid;
            this.PushTokenIos = pushTokenIos;
        }

        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name="contact_id", EmitDefaultValue=false)]
        public string ContactId { get; set; }



        /// <summary>
        /// Date and hour of the contact consent
        /// </summary>
        /// <value>Date and hour of the contact consent</value>
        [DataMember(Name="consent_date", EmitDefaultValue=false)]
        public DateTime ConsentDate { get; private set; }


        /// <summary>
        /// Date and hour of the contact subscription
        /// </summary>
        /// <value>Date and hour of the contact subscription</value>
        [DataMember(Name="subscription_date", EmitDefaultValue=false)]
        public DateTime SubscriptionDate { get; private set; }

        /// <summary>
        /// Contact subscription form
        /// </summary>
        /// <value>Contact subscription form</value>
        [DataMember(Name="subscription_form", EmitDefaultValue=false)]
        public int SubscriptionForm { get; private set; }



        /// <summary>
        /// Contact unsubscription observation
        /// </summary>
        /// <value>Contact unsubscription observation</value>
        [DataMember(Name="unsubscription_observation", EmitDefaultValue=false)]
        public string UnsubscriptionObservation { get; private set; }

        /// <summary>
        /// Contact unsubscription date
        /// </summary>
        /// <value>Contact unsubscription date</value>
        [DataMember(Name="unsubscription_date", EmitDefaultValue=false)]
        public DateTime UnsubscriptionDate { get; private set; }

        /// <summary>
        /// Last modification date of the contact
        /// </summary>
        /// <value>Last modification date of the contact</value>
        [DataMember(Name="change_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ChangeDate { get; private set; }

        /// <summary>
        /// First name of the contact
        /// </summary>
        /// <value>First name of the contact</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the contact
        /// </summary>
        /// <value>Last name of the contact</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Birth date of the contact
        /// </summary>
        /// <value>Birth date of the contact</value>
        [DataMember(Name="birth_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public Language Language { get; set; }

        /// <summary>
        /// Email of the contact
        /// </summary>
        /// <value>Email of the contact</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }


        /// <summary>
        /// Cellphone of the contact
        /// </summary>
        /// <value>Cellphone of the contact</value>
        [DataMember(Name="cellphone", EmitDefaultValue=false)]
        public string Cellphone { get; set; }


        /// <summary>
        /// Phone of the contact
        /// </summary>
        /// <value>Phone of the contact</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }


        /// <summary>
        /// Android push token of the contact
        /// </summary>
        /// <value>Android push token of the contact</value>
        [DataMember(Name="push_token_android", EmitDefaultValue=false)]
        public List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid> PushTokenAndroid { get; set; }

        /// <summary>
        /// IOS push token of the contact
        /// </summary>
        /// <value>IOS push token of the contact</value>
        [DataMember(Name="push_token_ios", EmitDefaultValue=false)]
        public List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos> PushTokenIos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactInsideBaseWithId {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Consent: ").Append(Consent).Append("\n");
            sb.Append("  ConsentDate: ").Append(ConsentDate).Append("\n");
            sb.Append("  SubscriptionMethod: ").Append(SubscriptionMethod).Append("\n");
            sb.Append("  SubscriptionDate: ").Append(SubscriptionDate).Append("\n");
            sb.Append("  SubscriptionForm: ").Append(SubscriptionForm).Append("\n");
            sb.Append("  UnsubscriptionMethod: ").Append(UnsubscriptionMethod).Append("\n");
            sb.Append("  UnsubscriptionReason: ").Append(UnsubscriptionReason).Append("\n");
            sb.Append("  UnsubscriptionObservation: ").Append(UnsubscriptionObservation).Append("\n");
            sb.Append("  UnsubscriptionDate: ").Append(UnsubscriptionDate).Append("\n");
            sb.Append("  ChangeDate: ").Append(ChangeDate).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailStatus: ").Append(EmailStatus).Append("\n");
            sb.Append("  Cellphone: ").Append(Cellphone).Append("\n");
            sb.Append("  CellphoneStatus: ").Append(CellphoneStatus).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneStatus: ").Append(PhoneStatus).Append("\n");
            sb.Append("  PushTokenAndroid: ").Append(PushTokenAndroid).Append("\n");
            sb.Append("  PushTokenIos: ").Append(PushTokenIos).Append("\n");
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
            return this.Equals(input as ContactInsideBaseWithId);
        }

        /// <summary>
        /// Returns true if ContactInsideBaseWithId instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactInsideBaseWithId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactInsideBaseWithId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Consent == input.Consent ||
                    (this.Consent != null &&
                    this.Consent.Equals(input.Consent))
                ) && 
                (
                    this.ConsentDate == input.ConsentDate ||
                    (this.ConsentDate != null &&
                    this.ConsentDate.Equals(input.ConsentDate))
                ) && 
                (
                    this.SubscriptionMethod == input.SubscriptionMethod ||
                    (this.SubscriptionMethod != null &&
                    this.SubscriptionMethod.Equals(input.SubscriptionMethod))
                ) && 
                (
                    this.SubscriptionDate == input.SubscriptionDate ||
                    (this.SubscriptionDate != null &&
                    this.SubscriptionDate.Equals(input.SubscriptionDate))
                ) && 
                (
                    this.SubscriptionForm == input.SubscriptionForm ||
                    (this.SubscriptionForm != null &&
                    this.SubscriptionForm.Equals(input.SubscriptionForm))
                ) && 
                (
                    this.UnsubscriptionMethod == input.UnsubscriptionMethod ||
                    (this.UnsubscriptionMethod != null &&
                    this.UnsubscriptionMethod.Equals(input.UnsubscriptionMethod))
                ) && 
                (
                    this.UnsubscriptionReason == input.UnsubscriptionReason ||
                    (this.UnsubscriptionReason != null &&
                    this.UnsubscriptionReason.Equals(input.UnsubscriptionReason))
                ) && 
                (
                    this.UnsubscriptionObservation == input.UnsubscriptionObservation ||
                    (this.UnsubscriptionObservation != null &&
                    this.UnsubscriptionObservation.Equals(input.UnsubscriptionObservation))
                ) && 
                (
                    this.UnsubscriptionDate == input.UnsubscriptionDate ||
                    (this.UnsubscriptionDate != null &&
                    this.UnsubscriptionDate.Equals(input.UnsubscriptionDate))
                ) && 
                (
                    this.ChangeDate == input.ChangeDate ||
                    (this.ChangeDate != null &&
                    this.ChangeDate.Equals(input.ChangeDate))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EmailStatus == input.EmailStatus ||
                    (this.EmailStatus != null &&
                    this.EmailStatus.Equals(input.EmailStatus))
                ) && 
                (
                    this.Cellphone == input.Cellphone ||
                    (this.Cellphone != null &&
                    this.Cellphone.Equals(input.Cellphone))
                ) && 
                (
                    this.CellphoneStatus == input.CellphoneStatus ||
                    (this.CellphoneStatus != null &&
                    this.CellphoneStatus.Equals(input.CellphoneStatus))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneStatus == input.PhoneStatus ||
                    (this.PhoneStatus != null &&
                    this.PhoneStatus.Equals(input.PhoneStatus))
                ) && 
                (
                    this.PushTokenAndroid == input.PushTokenAndroid ||
                    this.PushTokenAndroid != null &&
                    input.PushTokenAndroid != null &&
                    this.PushTokenAndroid.SequenceEqual(input.PushTokenAndroid)
                ) && 
                (
                    this.PushTokenIos == input.PushTokenIos ||
                    this.PushTokenIos != null &&
                    input.PushTokenIos != null &&
                    this.PushTokenIos.SequenceEqual(input.PushTokenIos)
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
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Consent != null)
                    hashCode = hashCode * 59 + this.Consent.GetHashCode();
                if (this.ConsentDate != null)
                    hashCode = hashCode * 59 + this.ConsentDate.GetHashCode();
                if (this.SubscriptionMethod != null)
                    hashCode = hashCode * 59 + this.SubscriptionMethod.GetHashCode();
                if (this.SubscriptionDate != null)
                    hashCode = hashCode * 59 + this.SubscriptionDate.GetHashCode();
                if (this.SubscriptionForm != null)
                    hashCode = hashCode * 59 + this.SubscriptionForm.GetHashCode();
                if (this.UnsubscriptionMethod != null)
                    hashCode = hashCode * 59 + this.UnsubscriptionMethod.GetHashCode();
                if (this.UnsubscriptionReason != null)
                    hashCode = hashCode * 59 + this.UnsubscriptionReason.GetHashCode();
                if (this.UnsubscriptionObservation != null)
                    hashCode = hashCode * 59 + this.UnsubscriptionObservation.GetHashCode();
                if (this.UnsubscriptionDate != null)
                    hashCode = hashCode * 59 + this.UnsubscriptionDate.GetHashCode();
                if (this.ChangeDate != null)
                    hashCode = hashCode * 59 + this.ChangeDate.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EmailStatus != null)
                    hashCode = hashCode * 59 + this.EmailStatus.GetHashCode();
                if (this.Cellphone != null)
                    hashCode = hashCode * 59 + this.Cellphone.GetHashCode();
                if (this.CellphoneStatus != null)
                    hashCode = hashCode * 59 + this.CellphoneStatus.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneStatus != null)
                    hashCode = hashCode * 59 + this.PhoneStatus.GetHashCode();
                if (this.PushTokenAndroid != null)
                    hashCode = hashCode * 59 + this.PushTokenAndroid.GetHashCode();
                if (this.PushTokenIos != null)
                    hashCode = hashCode * 59 + this.PushTokenIos.GetHashCode();
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


            // ContactId (string) pattern
            Regex regexContactId = new Regex(@"[a-fA-F\\d]{10}", RegexOptions.CultureInvariant);
            if (false == regexContactId.Match(this.ContactId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactId, must match a pattern of " + regexContactId, new [] { "ContactId" });
            }



            // SubscriptionForm (int) minimum
            if(this.SubscriptionForm < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SubscriptionForm, must be a value greater than or equal to 0.", new [] { "SubscriptionForm" });
            }

            yield break;
        }
    }

}
