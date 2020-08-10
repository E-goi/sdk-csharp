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
    /// Order data
    /// </summary>
    [DataContract]
    public partial class ImportOrdersBulkBulkRequest :  IEquatable<ImportOrdersBulkBulkRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOrdersBulkBulkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportOrdersBulkBulkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportOrdersBulkBulkRequest" /> class.
        /// </summary>
        /// <param name="orderId">Ecommerce order id (required).</param>
        /// <param name="contactId">Contact ID is any non-empty unique string identifying the user (such as an email address or e-goi uid).</param>
        /// <param name="revenue">Ecommerce order revenue (required).</param>
        /// <param name="storeUrl">Ecommerce store url (required).</param>
        /// <param name="date">Ecommerce order date (For technical reasons, all orders synchronized will have the date of synchronization.) (required).</param>
        /// <param name="items">Array of ordered products (required).</param>
        public ImportOrdersBulkBulkRequest(string orderId = default(string), string contactId = default(string), decimal? revenue = default(decimal?), string storeUrl = default(string), DateTime? date = default(DateTime?), List<ImportOrdersBulkBulkRequestItems> items = default(List<ImportOrdersBulkBulkRequestItems>))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for ImportOrdersBulkBulkRequest and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            // to ensure "revenue" is required (not null)
            if (revenue == null)
            {
                throw new InvalidDataException("revenue is a required property for ImportOrdersBulkBulkRequest and cannot be null");
            }
            else
            {
                this.Revenue = revenue;
            }
            // to ensure "storeUrl" is required (not null)
            if (storeUrl == null)
            {
                throw new InvalidDataException("storeUrl is a required property for ImportOrdersBulkBulkRequest and cannot be null");
            }
            else
            {
                this.StoreUrl = storeUrl;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for ImportOrdersBulkBulkRequest and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for ImportOrdersBulkBulkRequest and cannot be null");
            }
            else
            {
                this.Items = items;
            }
            this.ContactId = contactId;
        }
        
        /// <summary>
        /// Ecommerce order id
        /// </summary>
        /// <value>Ecommerce order id</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Contact ID is any non-empty unique string identifying the user (such as an email address or e-goi uid)
        /// </summary>
        /// <value>Contact ID is any non-empty unique string identifying the user (such as an email address or e-goi uid)</value>
        [DataMember(Name="contact_id", EmitDefaultValue=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// Ecommerce order revenue
        /// </summary>
        /// <value>Ecommerce order revenue</value>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public decimal? Revenue { get; set; }

        /// <summary>
        /// Ecommerce store url
        /// </summary>
        /// <value>Ecommerce store url</value>
        [DataMember(Name="store_url", EmitDefaultValue=false)]
        public string StoreUrl { get; set; }

        /// <summary>
        /// Ecommerce order date (For technical reasons, all orders synchronized will have the date of synchronization.)
        /// </summary>
        /// <value>Ecommerce order date (For technical reasons, all orders synchronized will have the date of synchronization.)</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Array of ordered products
        /// </summary>
        /// <value>Array of ordered products</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ImportOrdersBulkBulkRequestItems> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportOrdersBulkBulkRequest {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  StoreUrl: ").Append(StoreUrl).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ImportOrdersBulkBulkRequest);
        }

        /// <summary>
        /// Returns true if ImportOrdersBulkBulkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportOrdersBulkBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportOrdersBulkBulkRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.StoreUrl == input.StoreUrl ||
                    (this.StoreUrl != null &&
                    this.StoreUrl.Equals(input.StoreUrl))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.StoreUrl != null)
                    hashCode = hashCode * 59 + this.StoreUrl.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
            // Revenue (decimal?) minimum
            if(this.Revenue < (decimal?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Revenue, must be a value greater than or equal to 0.", new [] { "Revenue" });
            }

            yield break;
        }
    }

}
