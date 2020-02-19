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
    /// Form schema
    /// </summary>
    [DataContract]
    public partial class Form :  IEquatable<Form>, IValidatableObject
    {
        /// <summary>
        /// Status of the form
        /// </summary>
        /// <value>Status of the form</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Unpublished for value: unpublished
            /// </summary>
            [EnumMember(Value = "unpublished")]
            Unpublished = 2,

            /// <summary>
            /// Enum Cloned for value: cloned
            /// </summary>
            [EnumMember(Value = "cloned")]
            Cloned = 3,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 4

        }

        /// <summary>
        /// Status of the form
        /// </summary>
        /// <value>Status of the form</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Form() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form" /> class.
        /// </summary>
        /// <param name="internalTitle">Internal title of the form (default to &quot;$request.body#/title&quot;).</param>
        /// <param name="title">Title of the form (required).</param>
        /// <param name="language">language.</param>
        /// <param name="listId">listId.</param>
        /// <param name="_default">True if this is the default form in the list, false otherwise.</param>
        /// <param name="owner">owner.</param>
        /// <param name="created">The date and time.</param>
        /// <param name="updated">The date and time.</param>
        public Form(string internalTitle = "$request.body#/title", string title = default(string), Language language = default(Language), int? listId = default(int?), bool? _default = default(bool?), int? owner = default(int?), DateTime? created = default(DateTime?), DateTime? updated = default(DateTime?))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for Form and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // use default value if no "internalTitle" provided
            if (internalTitle == null)
            {
                this.InternalTitle = "$request.body#/title";
            }
            else
            {
                this.InternalTitle = internalTitle;
            }
            this.Language = language;
            this.ListId = listId;
            this.Default = _default;
            this.Owner = owner;
            this.Created = created;
            this.Updated = updated;
        }
        
        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [DataMember(Name="form_id", EmitDefaultValue=false)]
        public int? FormId { get; private set; }

        /// <summary>
        /// Internal title of the form
        /// </summary>
        /// <value>Internal title of the form</value>
        [DataMember(Name="internal_title", EmitDefaultValue=false)]
        public string InternalTitle { get; set; }

        /// <summary>
        /// Title of the form
        /// </summary>
        /// <value>Title of the form</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public Language Language { get; set; }

        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public int? ListId { get; set; }

        /// <summary>
        /// True if this is the default form in the list, false otherwise
        /// </summary>
        /// <value>True if this is the default form in the list, false otherwise</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public int? Owner { get; set; }


        /// <summary>
        /// The date and time
        /// </summary>
        /// <value>The date and time</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date and time
        /// </summary>
        /// <value>The date and time</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Form {\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  InternalTitle: ").Append(InternalTitle).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(input as Form);
        }

        /// <summary>
        /// Returns true if Form instances are equal
        /// </summary>
        /// <param name="input">Instance of Form to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Form input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FormId == input.FormId ||
                    (this.FormId != null &&
                    this.FormId.Equals(input.FormId))
                ) && 
                (
                    this.InternalTitle == input.InternalTitle ||
                    (this.InternalTitle != null &&
                    this.InternalTitle.Equals(input.InternalTitle))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.FormId != null)
                    hashCode = hashCode * 59 + this.FormId.GetHashCode();
                if (this.InternalTitle != null)
                    hashCode = hashCode * 59 + this.InternalTitle.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
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
            // FormId (int?) minimum
            if(this.FormId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FormId, must be a value greater than or equal to 1.", new [] { "FormId" });
            }

            // ListId (int?) minimum
            if(this.ListId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ListId, must be a value greater than or equal to 1.", new [] { "ListId" });
            }

            // Owner (int?) minimum
            if(this.Owner < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Owner, must be a value greater than or equal to 1.", new [] { "Owner" });
            }

            yield break;
        }
    }

}