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
    /// Campaign fields to include in the report
    /// </summary>
    [DataContract]
    public partial class EmailClicksByContactCampaignFields :  IEquatable<EmailClicksByContactCampaignFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClicksByContactCampaignFields" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailClicksByContactCampaignFields() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClicksByContactCampaignFields" /> class.
        /// </summary>
        /// <param name="internalName">True to include the internal name of the campaign, false otherwise (required).</param>
        /// <param name="campaignHash">True to include the hash of the campaign, false otherwise (required).</param>
        /// <param name="url">True to include the URL of the campaign, false otherwise (required).</param>
        /// <param name="sendDate">True to include the send date of the campaign, false otherwise.</param>
        /// <param name="group">True to include the group of the campaign, false otherwise.</param>
        /// <param name="channel">True to include the channel of the campaign, false otherwise.</param>
        /// <param name="type">True to include the type of the campaign, false otherwise.</param>
        /// <param name="sender">True to include the sender of the campaign, false otherwise.</param>
        /// <param name="city">True to include city information, false otherwise (deprecated).</param>
        /// <param name="country">True to include country information, false otherwise (deprecated).</param>
        /// <param name="region">True to include region information, false otherwise (deprecated).</param>
        /// <param name="program">True to include device program information, false otherwise (deprecated).</param>
        /// <param name="os">True to include operating system information, false otherwise (deprecated).</param>
        public EmailClicksByContactCampaignFields(bool internalName = default(bool), bool campaignHash = default(bool), bool url = default(bool), bool sendDate = default(bool), bool group = default(bool), bool channel = default(bool), bool type = default(bool), bool sender = default(bool), bool city = default(bool), bool country = default(bool), bool region = default(bool), bool program = default(bool), bool os = default(bool))
        {
            // to ensure "internalName" is required (not null)
            if (internalName == null)
            {
                throw new InvalidDataException("internalName is a required property for EmailClicksByContactCampaignFields and cannot be null");
            }
            else
            {
                this.InternalName = internalName;
            }

            // to ensure "campaignHash" is required (not null)
            if (campaignHash == null)
            {
                throw new InvalidDataException("campaignHash is a required property for EmailClicksByContactCampaignFields and cannot be null");
            }
            else
            {
                this.CampaignHash = campaignHash;
            }

            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for EmailClicksByContactCampaignFields and cannot be null");
            }
            else
            {
                this.Url = url;
            }

            this.SendDate = sendDate;
            this.Group = group;
            this.Channel = channel;
            this.Type = type;
            this.Sender = sender;
            this.City = city;
            this.Country = country;
            this.Region = region;
            this.Program = program;
            this.Os = os;
        }

        /// <summary>
        /// True to include the internal name of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the internal name of the campaign, false otherwise</value>
        [DataMember(Name="internal_name", EmitDefaultValue=true)]
        public bool InternalName { get; set; }

        /// <summary>
        /// True to include the hash of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the hash of the campaign, false otherwise</value>
        [DataMember(Name="campaign_hash", EmitDefaultValue=true)]
        public bool CampaignHash { get; set; }

        /// <summary>
        /// True to include the URL of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the URL of the campaign, false otherwise</value>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public bool Url { get; set; }

        /// <summary>
        /// True to include the send date of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the send date of the campaign, false otherwise</value>
        [DataMember(Name="send_date", EmitDefaultValue=false)]
        public bool SendDate { get; set; }

        /// <summary>
        /// True to include the group of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the group of the campaign, false otherwise</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public bool Group { get; set; }

        /// <summary>
        /// True to include the channel of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the channel of the campaign, false otherwise</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public bool Channel { get; set; }

        /// <summary>
        /// True to include the type of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the type of the campaign, false otherwise</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public bool Type { get; set; }

        /// <summary>
        /// True to include the sender of the campaign, false otherwise
        /// </summary>
        /// <value>True to include the sender of the campaign, false otherwise</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public bool Sender { get; set; }

        /// <summary>
        /// True to include city information, false otherwise (deprecated)
        /// </summary>
        /// <value>True to include city information, false otherwise (deprecated)</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public bool City { get; set; }

        /// <summary>
        /// True to include country information, false otherwise (deprecated)
        /// </summary>
        /// <value>True to include country information, false otherwise (deprecated)</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public bool Country { get; set; }

        /// <summary>
        /// True to include region information, false otherwise (deprecated)
        /// </summary>
        /// <value>True to include region information, false otherwise (deprecated)</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public bool Region { get; set; }

        /// <summary>
        /// True to include device program information, false otherwise (deprecated)
        /// </summary>
        /// <value>True to include device program information, false otherwise (deprecated)</value>
        [DataMember(Name="program", EmitDefaultValue=false)]
        public bool Program { get; set; }

        /// <summary>
        /// True to include operating system information, false otherwise (deprecated)
        /// </summary>
        /// <value>True to include operating system information, false otherwise (deprecated)</value>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public bool Os { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailClicksByContactCampaignFields {\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  CampaignHash: ").Append(CampaignHash).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Program: ").Append(Program).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
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
            return this.Equals(input as EmailClicksByContactCampaignFields);
        }

        /// <summary>
        /// Returns true if EmailClicksByContactCampaignFields instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailClicksByContactCampaignFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailClicksByContactCampaignFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternalName == input.InternalName ||
                    (this.InternalName != null &&
                    this.InternalName.Equals(input.InternalName))
                ) && 
                (
                    this.CampaignHash == input.CampaignHash ||
                    (this.CampaignHash != null &&
                    this.CampaignHash.Equals(input.CampaignHash))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.SendDate == input.SendDate ||
                    (this.SendDate != null &&
                    this.SendDate.Equals(input.SendDate))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Program == input.Program ||
                    (this.Program != null &&
                    this.Program.Equals(input.Program))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
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
                if (this.InternalName != null)
                    hashCode = hashCode * 59 + this.InternalName.GetHashCode();
                if (this.CampaignHash != null)
                    hashCode = hashCode * 59 + this.CampaignHash.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.SendDate != null)
                    hashCode = hashCode * 59 + this.SendDate.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Program != null)
                    hashCode = hashCode * 59 + this.Program.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
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
