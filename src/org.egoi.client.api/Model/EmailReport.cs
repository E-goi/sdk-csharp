/*
 * APIv3 (New)
 *
 *  # Introduction This is our new version of API. We invite you to start using it and give us your feedback # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.  The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.      BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication  We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:     #!/bin/bash     curl -X GET 'https://api.egoiapp.com/my-account' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:     #!/bin/bash     curl -X POST 'http://api.egoiapp.com/tags' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>' \\     -H 'Content-Type: application/json' \\     -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  # Callbacks A callback is an asynchronous API request that originates from the API server and is sent to the client in response to a previous request sent by that client.  The API will make a **POST** request to the address defined in the URL with the information regarding the event of interest and share data related to that event.  ***Note:*** Only http or https protocols are supported in the Url parameter.  <security-definitions/>
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
    /// Email report schema
    /// </summary>
    [DataContract]
    public partial class EmailReport :  IEquatable<EmailReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailReport" /> class.
        /// </summary>
        /// <param name="overall">overall.</param>
        /// <param name="date">Email stats grouped by date.</param>
        /// <param name="weekday">Email stats grouped by date.</param>
        /// <param name="hour">Email stats grouped by hour.</param>
        /// <param name="location">Email stats grouped by Location.</param>
        /// <param name="domain">Email stats grouped by Domain.</param>
        /// <param name="url">Email stats grouped by Domain.</param>
        /// <param name="reader">Email stats grouped by Reader.</param>
        public EmailReport(EmailReportOverallOverall overall = default(EmailReportOverallOverall), List<EmailReportByDateDate> date = default(List<EmailReportByDateDate>), List<EmailReportByWeekdayWeekday> weekday = default(List<EmailReportByWeekdayWeekday>), List<EmailReportByHourHour> hour = default(List<EmailReportByHourHour>), List<EmailReportByLocationLocation> location = default(List<EmailReportByLocationLocation>), List<EmailReportByDomainDomain> domain = default(List<EmailReportByDomainDomain>), List<EmailReportByUrlUrl> url = default(List<EmailReportByUrlUrl>), List<EmailReportByReaderReader> reader = default(List<EmailReportByReaderReader>))
        {
            this.Overall = overall;
            this.Date = date;
            this.Weekday = weekday;
            this.Hour = hour;
            this.Location = location;
            this.Domain = domain;
            this.Url = url;
            this.Reader = reader;
        }

        /// <summary>
        /// Gets or Sets CampaignHash
        /// </summary>
        [DataMember(Name="campaign_hash", EmitDefaultValue=false)]
        public string CampaignHash { get; private set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public EmailReportOverallOverall Overall { get; set; }

        /// <summary>
        /// Email stats grouped by date
        /// </summary>
        /// <value>Email stats grouped by date</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public List<EmailReportByDateDate> Date { get; set; }

        /// <summary>
        /// Email stats grouped by date
        /// </summary>
        /// <value>Email stats grouped by date</value>
        [DataMember(Name="weekday", EmitDefaultValue=false)]
        public List<EmailReportByWeekdayWeekday> Weekday { get; set; }

        /// <summary>
        /// Email stats grouped by hour
        /// </summary>
        /// <value>Email stats grouped by hour</value>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public List<EmailReportByHourHour> Hour { get; set; }

        /// <summary>
        /// Email stats grouped by Location
        /// </summary>
        /// <value>Email stats grouped by Location</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public List<EmailReportByLocationLocation> Location { get; set; }

        /// <summary>
        /// Email stats grouped by Domain
        /// </summary>
        /// <value>Email stats grouped by Domain</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public List<EmailReportByDomainDomain> Domain { get; set; }

        /// <summary>
        /// Email stats grouped by Domain
        /// </summary>
        /// <value>Email stats grouped by Domain</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public List<EmailReportByUrlUrl> Url { get; set; }

        /// <summary>
        /// Email stats grouped by Reader
        /// </summary>
        /// <value>Email stats grouped by Reader</value>
        [DataMember(Name="reader", EmitDefaultValue=false)]
        public List<EmailReportByReaderReader> Reader { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailReport {\n");
            sb.Append("  CampaignHash: ").Append(CampaignHash).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Weekday: ").Append(Weekday).Append("\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Reader: ").Append(Reader).Append("\n");
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
            return this.Equals(input as EmailReport);
        }

        /// <summary>
        /// Returns true if EmailReport instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailReport input)
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
                    this.Overall == input.Overall ||
                    (this.Overall != null &&
                    this.Overall.Equals(input.Overall))
                ) && 
                (
                    this.Date == input.Date ||
                    this.Date != null &&
                    input.Date != null &&
                    this.Date.SequenceEqual(input.Date)
                ) && 
                (
                    this.Weekday == input.Weekday ||
                    this.Weekday != null &&
                    input.Weekday != null &&
                    this.Weekday.SequenceEqual(input.Weekday)
                ) && 
                (
                    this.Hour == input.Hour ||
                    this.Hour != null &&
                    input.Hour != null &&
                    this.Hour.SequenceEqual(input.Hour)
                ) && 
                (
                    this.Location == input.Location ||
                    this.Location != null &&
                    input.Location != null &&
                    this.Location.SequenceEqual(input.Location)
                ) && 
                (
                    this.Domain == input.Domain ||
                    this.Domain != null &&
                    input.Domain != null &&
                    this.Domain.SequenceEqual(input.Domain)
                ) && 
                (
                    this.Url == input.Url ||
                    this.Url != null &&
                    input.Url != null &&
                    this.Url.SequenceEqual(input.Url)
                ) && 
                (
                    this.Reader == input.Reader ||
                    this.Reader != null &&
                    input.Reader != null &&
                    this.Reader.SequenceEqual(input.Reader)
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
                if (this.Overall != null)
                    hashCode = hashCode * 59 + this.Overall.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Weekday != null)
                    hashCode = hashCode * 59 + this.Weekday.GetHashCode();
                if (this.Hour != null)
                    hashCode = hashCode * 59 + this.Hour.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Reader != null)
                    hashCode = hashCode * 59 + this.Reader.GetHashCode();
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
