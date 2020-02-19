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
    /// Push campaign patch request schema
    /// </summary>
    [DataContract]
    public partial class PushCampaignPatchRequest :  IEquatable<PushCampaignPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushCampaignPatchRequest" /> class.
        /// </summary>
        /// <param name="title">Push campaign subject.</param>
        /// <param name="content">content.</param>
        /// <param name="actions">Actions for push campaign.</param>
        /// <param name="geoOptions">geoOptions.</param>
        /// <param name="notificationOptions">notificationOptions.</param>
        public PushCampaignPatchRequest(string title = default(string), PushCampaignPatchRequestContent content = default(PushCampaignPatchRequestContent), List<PushCampaignPostRequestActions> actions = default(List<PushCampaignPostRequestActions>), PushCampaignPostRequestGeoOptions geoOptions = default(PushCampaignPostRequestGeoOptions), PushCampaignPostRequestNotificationOptions notificationOptions = default(PushCampaignPostRequestNotificationOptions))
        {
            this.Title = title;
            this.Content = content;
            this.Actions = actions;
            this.GeoOptions = geoOptions;
            this.NotificationOptions = notificationOptions;
        }
        
        /// <summary>
        /// Gets or Sets CampaignHash
        /// </summary>
        [DataMember(Name="campaign_hash", EmitDefaultValue=false)]
        public string CampaignHash { get; private set; }

        /// <summary>
        /// Push campaign subject
        /// </summary>
        /// <value>Push campaign subject</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public PushCampaignPatchRequestContent Content { get; set; }

        /// <summary>
        /// Actions for push campaign
        /// </summary>
        /// <value>Actions for push campaign</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<PushCampaignPostRequestActions> Actions { get; set; }

        /// <summary>
        /// Gets or Sets GeoOptions
        /// </summary>
        [DataMember(Name="geo_options", EmitDefaultValue=false)]
        public PushCampaignPostRequestGeoOptions GeoOptions { get; set; }

        /// <summary>
        /// Gets or Sets NotificationOptions
        /// </summary>
        [DataMember(Name="notification_options", EmitDefaultValue=false)]
        public PushCampaignPostRequestNotificationOptions NotificationOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushCampaignPatchRequest {\n");
            sb.Append("  CampaignHash: ").Append(CampaignHash).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  GeoOptions: ").Append(GeoOptions).Append("\n");
            sb.Append("  NotificationOptions: ").Append(NotificationOptions).Append("\n");
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
            return this.Equals(input as PushCampaignPatchRequest);
        }

        /// <summary>
        /// Returns true if PushCampaignPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PushCampaignPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushCampaignPatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignHash == input.CampaignHash ||
                    (this.CampaignHash != null &&
                    this.CampaignHash.Equals(input.CampaignHash))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.GeoOptions == input.GeoOptions ||
                    (this.GeoOptions != null &&
                    this.GeoOptions.Equals(input.GeoOptions))
                ) && 
                (
                    this.NotificationOptions == input.NotificationOptions ||
                    (this.NotificationOptions != null &&
                    this.NotificationOptions.Equals(input.NotificationOptions))
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
                if (this.CampaignHash != null)
                    hashCode = hashCode * 59 + this.CampaignHash.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.GeoOptions != null)
                    hashCode = hashCode * 59 + this.GeoOptions.GetHashCode();
                if (this.NotificationOptions != null)
                    hashCode = hashCode * 59 + this.NotificationOptions.GetHashCode();
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
            // CampaignHash (string) pattern
            Regex regexCampaignHash = new Regex(@"[a-zA-Z0-9_-]*", RegexOptions.CultureInvariant);
            if (false == regexCampaignHash.Match(this.CampaignHash).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignHash, must match a pattern of " + regexCampaignHash, new [] { "CampaignHash" });
            }

            yield break;
        }
    }

}
