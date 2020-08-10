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
    /// HeaderFooterHeaderLinks
    /// </summary>
    [DataContract]
    public partial class HeaderFooterHeaderLinks :  IEquatable<HeaderFooterHeaderLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderFooterHeaderLinks" /> class.
        /// </summary>
        /// <param name="forward">Use view forward header link (default to false).</param>
        /// <param name="viewWeb">Use view view in web header link (default to false).</param>
        /// <param name="unsubscribe">Use view unsubscribe header link (default to false).</param>
        /// <param name="footerLinks">Use view edit header link (default to false).</param>
        /// <param name="socialShare">Use view social share header link (default to false).</param>
        /// <param name="facebookShare">Use view facebook share header link (default to false).</param>
        /// <param name="twitterShare">Use view twitter share header link (default to false).</param>
        public HeaderFooterHeaderLinks(bool? forward = false, bool? viewWeb = false, bool? unsubscribe = false, bool? footerLinks = false, bool? socialShare = false, bool? facebookShare = false, bool? twitterShare = false)
        {
            // use default value if no "forward" provided
            if (forward == null)
            {
                this.Forward = false;
            }
            else
            {
                this.Forward = forward;
            }
            // use default value if no "viewWeb" provided
            if (viewWeb == null)
            {
                this.ViewWeb = false;
            }
            else
            {
                this.ViewWeb = viewWeb;
            }
            // use default value if no "unsubscribe" provided
            if (unsubscribe == null)
            {
                this.Unsubscribe = false;
            }
            else
            {
                this.Unsubscribe = unsubscribe;
            }
            // use default value if no "footerLinks" provided
            if (footerLinks == null)
            {
                this.FooterLinks = false;
            }
            else
            {
                this.FooterLinks = footerLinks;
            }
            // use default value if no "socialShare" provided
            if (socialShare == null)
            {
                this.SocialShare = false;
            }
            else
            {
                this.SocialShare = socialShare;
            }
            // use default value if no "facebookShare" provided
            if (facebookShare == null)
            {
                this.FacebookShare = false;
            }
            else
            {
                this.FacebookShare = facebookShare;
            }
            // use default value if no "twitterShare" provided
            if (twitterShare == null)
            {
                this.TwitterShare = false;
            }
            else
            {
                this.TwitterShare = twitterShare;
            }
        }
        
        /// <summary>
        /// Use view forward header link
        /// </summary>
        /// <value>Use view forward header link</value>
        [DataMember(Name="forward", EmitDefaultValue=false)]
        public bool? Forward { get; set; }

        /// <summary>
        /// Use view view in web header link
        /// </summary>
        /// <value>Use view view in web header link</value>
        [DataMember(Name="view_web", EmitDefaultValue=false)]
        public bool? ViewWeb { get; set; }

        /// <summary>
        /// Use view unsubscribe header link
        /// </summary>
        /// <value>Use view unsubscribe header link</value>
        [DataMember(Name="unsubscribe", EmitDefaultValue=false)]
        public bool? Unsubscribe { get; set; }

        /// <summary>
        /// Use view edit header link
        /// </summary>
        /// <value>Use view edit header link</value>
        [DataMember(Name="footer_links", EmitDefaultValue=false)]
        public bool? FooterLinks { get; set; }

        /// <summary>
        /// Use view social share header link
        /// </summary>
        /// <value>Use view social share header link</value>
        [DataMember(Name="social_share", EmitDefaultValue=false)]
        public bool? SocialShare { get; set; }

        /// <summary>
        /// Use view facebook share header link
        /// </summary>
        /// <value>Use view facebook share header link</value>
        [DataMember(Name="facebook_share", EmitDefaultValue=false)]
        public bool? FacebookShare { get; set; }

        /// <summary>
        /// Use view twitter share header link
        /// </summary>
        /// <value>Use view twitter share header link</value>
        [DataMember(Name="twitter_share", EmitDefaultValue=false)]
        public bool? TwitterShare { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeaderFooterHeaderLinks {\n");
            sb.Append("  Forward: ").Append(Forward).Append("\n");
            sb.Append("  ViewWeb: ").Append(ViewWeb).Append("\n");
            sb.Append("  Unsubscribe: ").Append(Unsubscribe).Append("\n");
            sb.Append("  FooterLinks: ").Append(FooterLinks).Append("\n");
            sb.Append("  SocialShare: ").Append(SocialShare).Append("\n");
            sb.Append("  FacebookShare: ").Append(FacebookShare).Append("\n");
            sb.Append("  TwitterShare: ").Append(TwitterShare).Append("\n");
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
            return this.Equals(input as HeaderFooterHeaderLinks);
        }

        /// <summary>
        /// Returns true if HeaderFooterHeaderLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of HeaderFooterHeaderLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeaderFooterHeaderLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Forward == input.Forward ||
                    (this.Forward != null &&
                    this.Forward.Equals(input.Forward))
                ) && 
                (
                    this.ViewWeb == input.ViewWeb ||
                    (this.ViewWeb != null &&
                    this.ViewWeb.Equals(input.ViewWeb))
                ) && 
                (
                    this.Unsubscribe == input.Unsubscribe ||
                    (this.Unsubscribe != null &&
                    this.Unsubscribe.Equals(input.Unsubscribe))
                ) && 
                (
                    this.FooterLinks == input.FooterLinks ||
                    (this.FooterLinks != null &&
                    this.FooterLinks.Equals(input.FooterLinks))
                ) && 
                (
                    this.SocialShare == input.SocialShare ||
                    (this.SocialShare != null &&
                    this.SocialShare.Equals(input.SocialShare))
                ) && 
                (
                    this.FacebookShare == input.FacebookShare ||
                    (this.FacebookShare != null &&
                    this.FacebookShare.Equals(input.FacebookShare))
                ) && 
                (
                    this.TwitterShare == input.TwitterShare ||
                    (this.TwitterShare != null &&
                    this.TwitterShare.Equals(input.TwitterShare))
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
                if (this.Forward != null)
                    hashCode = hashCode * 59 + this.Forward.GetHashCode();
                if (this.ViewWeb != null)
                    hashCode = hashCode * 59 + this.ViewWeb.GetHashCode();
                if (this.Unsubscribe != null)
                    hashCode = hashCode * 59 + this.Unsubscribe.GetHashCode();
                if (this.FooterLinks != null)
                    hashCode = hashCode * 59 + this.FooterLinks.GetHashCode();
                if (this.SocialShare != null)
                    hashCode = hashCode * 59 + this.SocialShare.GetHashCode();
                if (this.FacebookShare != null)
                    hashCode = hashCode * 59 + this.FacebookShare.GetHashCode();
                if (this.TwitterShare != null)
                    hashCode = hashCode * 59 + this.TwitterShare.GetHashCode();
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
