/* 
 * APIv3 (Beta)
 *
 *  # Introduction Just a quick peek!!! This is our new version of API. Remember, it is not stable yet!!! But we invite you play with it and give us your feedback ;) # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.   The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.   BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication   We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:  #!/bin/bash  curl -X GET 'https://api.egoiapp.com/my-account' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:  #!/bin/bash  curl -X POST 'http://api.egoiapp.com/tags' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>' \\  -H 'Content-Type: application/json' \\  -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB. <security-definitions/>
 *
 * OpenAPI spec version: 3.0.0-beta
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
    /// Campaign email abstract schema
    /// </summary>
    [DataContract]
    public partial class AbstractSendEmail :  IEquatable<AbstractSendEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSendEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbstractSendEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractSendEmail" /> class.
        /// </summary>
        /// <param name="listId">listId (required).</param>
        /// <param name="segments">segments (required).</param>
        /// <param name="notify">Array of IDs of the users to notify.</param>
        /// <param name="destinationField">Destination field of this campaign, which must be an email field (email or extra field id).                         If not sent, defaults to the general email field.</param>
        /// <param name="uniqueContactsOnly">True to send the campaign only to unique contacts (default to false).</param>
        public AbstractSendEmail(int? listId = default(int?), EmailSendSegment segments = default(EmailSendSegment), List<int?> notify = default(List<int?>), string destinationField = default(string), bool? uniqueContactsOnly = false)
        {
            // to ensure "listId" is required (not null)
            if (listId == null)
            {
                throw new InvalidDataException("listId is a required property for AbstractSendEmail and cannot be null");
            }
            else
            {
                this.ListId = listId;
            }
            // to ensure "segments" is required (not null)
            if (segments == null)
            {
                throw new InvalidDataException("segments is a required property for AbstractSendEmail and cannot be null");
            }
            else
            {
                this.Segments = segments;
            }
            this.Notify = notify;
            this.DestinationField = destinationField;
            // use default value if no "uniqueContactsOnly" provided
            if (uniqueContactsOnly == null)
            {
                this.UniqueContactsOnly = false;
            }
            else
            {
                this.UniqueContactsOnly = uniqueContactsOnly;
            }
        }
        
        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public int? ListId { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public EmailSendSegment Segments { get; set; }

        /// <summary>
        /// Array of IDs of the users to notify
        /// </summary>
        /// <value>Array of IDs of the users to notify</value>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public List<int?> Notify { get; set; }

        /// <summary>
        /// Destination field of this campaign, which must be an email field (email or extra field id).                         If not sent, defaults to the general email field
        /// </summary>
        /// <value>Destination field of this campaign, which must be an email field (email or extra field id).                         If not sent, defaults to the general email field</value>
        [DataMember(Name="destination_field", EmitDefaultValue=false)]
        public string DestinationField { get; set; }

        /// <summary>
        /// True to send the campaign only to unique contacts
        /// </summary>
        /// <value>True to send the campaign only to unique contacts</value>
        [DataMember(Name="unique_contacts_only", EmitDefaultValue=false)]
        public bool? UniqueContactsOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractSendEmail {\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  DestinationField: ").Append(DestinationField).Append("\n");
            sb.Append("  UniqueContactsOnly: ").Append(UniqueContactsOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AbstractSendEmail);
        }

        /// <summary>
        /// Returns true if AbstractSendEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractSendEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractSendEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Segments == input.Segments ||
                    (this.Segments != null &&
                    this.Segments.Equals(input.Segments))
                ) && 
                (
                    this.Notify == input.Notify ||
                    this.Notify != null &&
                    this.Notify.SequenceEqual(input.Notify)
                ) && 
                (
                    this.DestinationField == input.DestinationField ||
                    (this.DestinationField != null &&
                    this.DestinationField.Equals(input.DestinationField))
                ) && 
                (
                    this.UniqueContactsOnly == input.UniqueContactsOnly ||
                    (this.UniqueContactsOnly != null &&
                    this.UniqueContactsOnly.Equals(input.UniqueContactsOnly))
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
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.Notify != null)
                    hashCode = hashCode * 59 + this.Notify.GetHashCode();
                if (this.DestinationField != null)
                    hashCode = hashCode * 59 + this.DestinationField.GetHashCode();
                if (this.UniqueContactsOnly != null)
                    hashCode = hashCode * 59 + this.UniqueContactsOnly.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // ListId (int?) minimum
            if(this.ListId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ListId, must be a value greater than or equal to 1.", new [] { "ListId" });
            }

            yield break;
        }
    }

}
