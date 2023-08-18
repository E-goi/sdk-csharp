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
    /// ContactInsideBasePost
    /// </summary>
    [DataContract]
    public partial class ContactInsideBasePost :  IEquatable<ContactInsideBasePost>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ContactInsideBasePost" /> class.
        /// </summary>
        /// <param name="status">Status of the contact (default to StatusEnum.Active).</param>
        /// <param name="firstName">First name of the contact.</param>
        /// <param name="lastName">Last name of the contact.</param>
        /// <param name="birthDate">Birth date of the contact.</param>
        /// <param name="language">language.</param>
        /// <param name="email">Email of the contact.</param>
        /// <param name="cellphone">Cellphone of the contact (country code followed by phone number, split by &#39;-&#39;).</param>
        /// <param name="phone">Phone of the contact (country code followed by phone number, split by &#39;-&#39;).</param>
        /// <param name="pushTokenAndroid">Android push token of the contact.</param>
        /// <param name="pushTokenIos">IOS push token of the contact.</param>
        public ContactInsideBasePost(StatusEnum? status = StatusEnum.Active, string firstName = default(string), string lastName = default(string), string birthDate = default(string), Language language = default(Language), string email = default(string), string cellphone = default(string), string phone = default(string), List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid> pushTokenAndroid = default(List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid>), List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos> pushTokenIos = default(List<ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos>))
        {
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
        public string ContactId { get; private set; }


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
        public string BirthDate { get; set; }

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
        /// Cellphone of the contact (country code followed by phone number, split by &#39;-&#39;)
        /// </summary>
        /// <value>Cellphone of the contact (country code followed by phone number, split by &#39;-&#39;)</value>
        [DataMember(Name="cellphone", EmitDefaultValue=false)]
        public string Cellphone { get; set; }

        /// <summary>
        /// Phone of the contact (country code followed by phone number, split by &#39;-&#39;)
        /// </summary>
        /// <value>Phone of the contact (country code followed by phone number, split by &#39;-&#39;)</value>
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
            sb.Append("class ContactInsideBasePost {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Cellphone: ").Append(Cellphone).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as ContactInsideBasePost);
        }

        /// <summary>
        /// Returns true if ContactInsideBasePost instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactInsideBasePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactInsideBasePost input)
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
                    this.Cellphone == input.Cellphone ||
                    (this.Cellphone != null &&
                    this.Cellphone.Equals(input.Cellphone))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Cellphone != null)
                    hashCode = hashCode * 59 + this.Cellphone.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
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



            // Cellphone (string) pattern
            Regex regexCellphone = new Regex(@"^(\\d){1,3}-(\\d){4,20}$", RegexOptions.CultureInvariant);
            if (false == regexCellphone.Match(this.Cellphone).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cellphone, must match a pattern of " + regexCellphone, new [] { "Cellphone" });
            }



            // Phone (string) pattern
            Regex regexPhone = new Regex(@"^(\\d){1,3}-(\\d){4,20}$", RegexOptions.CultureInvariant);
            if (false == regexPhone.Match(this.Phone).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, must match a pattern of " + regexPhone, new [] { "Phone" });
            }

            yield break;
        }
    }

}
