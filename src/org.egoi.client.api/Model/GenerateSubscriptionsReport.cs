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
    /// Generate subscriptions report schema
    /// </summary>
    [DataContract]
    public partial class GenerateSubscriptionsReport :  IEquatable<GenerateSubscriptionsReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSubscriptionsReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateSubscriptionsReport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSubscriptionsReport" /> class.
        /// </summary>
        /// <param name="title">Advanced report title (required).</param>
        /// <param name="range">range (required).</param>
        /// <param name="lists">lists (required).</param>
        /// <param name="columns">columns (required).</param>
        /// <param name="options">options (required).</param>
        /// <param name="callbackUrl">URL which will receive the information of the report.</param>
        public GenerateSubscriptionsReport(string title = default(string), AdvancedReportRange range = default(AdvancedReportRange), int? lists = default(int?), AdvancedReportSubscriptionsColumns columns = default(AdvancedReportSubscriptionsColumns), AdvancedReportSubscriptionsOptions options = default(AdvancedReportSubscriptionsOptions), string callbackUrl = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for GenerateSubscriptionsReport and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "range" is required (not null)
            if (range == null)
            {
                throw new InvalidDataException("range is a required property for GenerateSubscriptionsReport and cannot be null");
            }
            else
            {
                this.Range = range;
            }
            // to ensure "lists" is required (not null)
            if (lists == null)
            {
                throw new InvalidDataException("lists is a required property for GenerateSubscriptionsReport and cannot be null");
            }
            else
            {
                this.Lists = lists;
            }
            // to ensure "columns" is required (not null)
            if (columns == null)
            {
                throw new InvalidDataException("columns is a required property for GenerateSubscriptionsReport and cannot be null");
            }
            else
            {
                this.Columns = columns;
            }
            // to ensure "options" is required (not null)
            if (options == null)
            {
                throw new InvalidDataException("options is a required property for GenerateSubscriptionsReport and cannot be null");
            }
            else
            {
                this.Options = options;
            }
            this.CallbackUrl = callbackUrl;
        }
        
        /// <summary>
        /// Advanced report title
        /// </summary>
        /// <value>Advanced report title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public AdvancedReportRange Range { get; set; }

        /// <summary>
        /// Gets or Sets Lists
        /// </summary>
        [DataMember(Name="lists", EmitDefaultValue=false)]
        public int? Lists { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public AdvancedReportSubscriptionsColumns Columns { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public AdvancedReportSubscriptionsOptions Options { get; set; }

        /// <summary>
        /// URL which will receive the information of the report
        /// </summary>
        /// <value>URL which will receive the information of the report</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateSubscriptionsReport {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Lists: ").Append(Lists).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GenerateSubscriptionsReport);
        }

        /// <summary>
        /// Returns true if GenerateSubscriptionsReport instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateSubscriptionsReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateSubscriptionsReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Range == input.Range ||
                    (this.Range != null &&
                    this.Range.Equals(input.Range))
                ) && 
                (
                    this.Lists == input.Lists ||
                    (this.Lists != null &&
                    this.Lists.Equals(input.Lists))
                ) && 
                (
                    this.Columns == input.Columns ||
                    (this.Columns != null &&
                    this.Columns.Equals(input.Columns))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
                if (this.Lists != null)
                    hashCode = hashCode * 59 + this.Lists.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
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
            // Lists (int?) minimum
            if(this.Lists < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Lists, must be a value greater than or equal to 1.", new [] { "Lists" });
            }

            yield break;
        }
    }

}
