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
    /// List stats fields to include in the report
    /// </summary>
    [DataContract]
    public partial class SmsEventsListStatsFields :  IEquatable<SmsEventsListStatsFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsEventsListStatsFields" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsEventsListStatsFields() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsEventsListStatsFields" /> class.
        /// </summary>
        /// <param name="deliveryAnswer">True to include delivery answer, false otherwise (required).</param>
        /// <param name="deliveryDate">True to include delivery date, false otherwise (required).</param>
        public SmsEventsListStatsFields(bool? deliveryAnswer = default(bool?), bool? deliveryDate = default(bool?))
        {
            // to ensure "deliveryAnswer" is required (not null)
            if (deliveryAnswer == null)
            {
                throw new InvalidDataException("deliveryAnswer is a required property for SmsEventsListStatsFields and cannot be null");
            }
            else
            {
                this.DeliveryAnswer = deliveryAnswer;
            }
            // to ensure "deliveryDate" is required (not null)
            if (deliveryDate == null)
            {
                throw new InvalidDataException("deliveryDate is a required property for SmsEventsListStatsFields and cannot be null");
            }
            else
            {
                this.DeliveryDate = deliveryDate;
            }
        }
        
        /// <summary>
        /// True to include delivery answer, false otherwise
        /// </summary>
        /// <value>True to include delivery answer, false otherwise</value>
        [DataMember(Name="delivery_answer", EmitDefaultValue=false)]
        public bool? DeliveryAnswer { get; set; }

        /// <summary>
        /// True to include delivery date, false otherwise
        /// </summary>
        /// <value>True to include delivery date, false otherwise</value>
        [DataMember(Name="delivery_date", EmitDefaultValue=false)]
        public bool? DeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsEventsListStatsFields {\n");
            sb.Append("  DeliveryAnswer: ").Append(DeliveryAnswer).Append("\n");
            sb.Append("  DeliveryDate: ").Append(DeliveryDate).Append("\n");
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
            return this.Equals(input as SmsEventsListStatsFields);
        }

        /// <summary>
        /// Returns true if SmsEventsListStatsFields instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsEventsListStatsFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsEventsListStatsFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryAnswer == input.DeliveryAnswer ||
                    (this.DeliveryAnswer != null &&
                    this.DeliveryAnswer.Equals(input.DeliveryAnswer))
                ) && 
                (
                    this.DeliveryDate == input.DeliveryDate ||
                    (this.DeliveryDate != null &&
                    this.DeliveryDate.Equals(input.DeliveryDate))
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
                if (this.DeliveryAnswer != null)
                    hashCode = hashCode * 59 + this.DeliveryAnswer.GetHashCode();
                if (this.DeliveryDate != null)
                    hashCode = hashCode * 59 + this.DeliveryDate.GetHashCode();
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
