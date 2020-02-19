/* 
 * APIv3 (Beta)
 *
 *  # Introduction Just a quick peek!!! This is our new version of API. Remember, it is not stable yet!!! But we invite you play with it and give us your feedback ;) # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.   The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.   BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication   We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:  #!/bin/bash  curl -X GET 'https://api.egoiapp.com/my-account' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:  #!/bin/bash  curl -X POST 'http://api.egoiapp.com/tags' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>' \\  -H 'Content-Type: application/json' \\  -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services. * <b><a href='https://github.com/E-goi/sdk-java'>Java</a></b> * <b><a href='https://github.com/E-goi/sdk-php'>PHP</a></b> * <b><a href='https://github.com/E-goi/sdk-python'>Python</a></b>  <security-definitions/>
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
    /// Email campaign schema
    /// </summary>
    [DataContract]
    public partial class EmailCampaignCreate :  IEquatable<EmailCampaignCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCampaignCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailCampaignCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCampaignCreate" /> class.
        /// </summary>
        /// <param name="listId">listId (required).</param>
        /// <param name="internalName">Campaign internal name (required).</param>
        /// <param name="subject">Campaign subject. If no value is sent, defaults to &#39;internal_name&#39; property value.</param>
        /// <param name="content">content (required).</param>
        /// <param name="senderId">senderId (required).</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="headerFooter">headerFooter.</param>
        public EmailCampaignCreate(int? listId = default(int?), string internalName = default(string), string subject = default(string), CampaignEmailContent content = default(CampaignEmailContent), int? senderId = default(int?), int? replyTo = default(int?), HeaderFooter headerFooter = default(HeaderFooter))
        {
            // to ensure "listId" is required (not null)
            if (listId == null)
            {
                throw new InvalidDataException("listId is a required property for EmailCampaignCreate and cannot be null");
            }
            else
            {
                this.ListId = listId;
            }
            // to ensure "internalName" is required (not null)
            if (internalName == null)
            {
                throw new InvalidDataException("internalName is a required property for EmailCampaignCreate and cannot be null");
            }
            else
            {
                this.InternalName = internalName;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for EmailCampaignCreate and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "senderId" is required (not null)
            if (senderId == null)
            {
                throw new InvalidDataException("senderId is a required property for EmailCampaignCreate and cannot be null");
            }
            else
            {
                this.SenderId = senderId;
            }
            this.Subject = subject;
            this.ReplyTo = replyTo;
            this.HeaderFooter = headerFooter;
        }
        
        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public int? ListId { get; set; }

        /// <summary>
        /// Campaign internal name
        /// </summary>
        /// <value>Campaign internal name</value>
        [DataMember(Name="internal_name", EmitDefaultValue=false)]
        public string InternalName { get; set; }

        /// <summary>
        /// Campaign subject. If no value is sent, defaults to &#39;internal_name&#39; property value
        /// </summary>
        /// <value>Campaign subject. If no value is sent, defaults to &#39;internal_name&#39; property value</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public CampaignEmailContent Content { get; set; }

        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public int? SenderId { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name="reply_to", EmitDefaultValue=false)]
        public int? ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets HeaderFooter
        /// </summary>
        [DataMember(Name="header_footer", EmitDefaultValue=false)]
        public HeaderFooter HeaderFooter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCampaignCreate {\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  HeaderFooter: ").Append(HeaderFooter).Append("\n");
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
            return this.Equals(input as EmailCampaignCreate);
        }

        /// <summary>
        /// Returns true if EmailCampaignCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCampaignCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCampaignCreate input)
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
                    this.InternalName == input.InternalName ||
                    (this.InternalName != null &&
                    this.InternalName.Equals(input.InternalName))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.HeaderFooter == input.HeaderFooter ||
                    (this.HeaderFooter != null &&
                    this.HeaderFooter.Equals(input.HeaderFooter))
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
                if (this.InternalName != null)
                    hashCode = hashCode * 59 + this.InternalName.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.HeaderFooter != null)
                    hashCode = hashCode * 59 + this.HeaderFooter.GetHashCode();
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
            // ListId (int?) minimum
            if(this.ListId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ListId, must be a value greater than or equal to 1.", new [] { "ListId" });
            }

            // SenderId (int?) minimum
            if(this.SenderId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderId, must be a value greater than or equal to 1.", new [] { "SenderId" });
            }

            // ReplyTo (int?) minimum
            if(this.ReplyTo < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReplyTo, must be a value greater than or equal to 1.", new [] { "ReplyTo" });
            }

            yield break;
        }
    }

}
