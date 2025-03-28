/*
 * Marketing API
 *
 *  # Introduction Welcome to the E-goi Marketing API! <br><br>This API enables you to integrate, automate, and manage all the marketing functionalities offered by E-goi. With it, you can interact with contact lists, send email campaigns, SMS, push notifications, and much more. <br><br>Our API is designed to simplify integration in a straightforward, efficient, and secure way, meeting the needs of developers and businesses looking to optimize their digital marketing operations. <br><br>Explore the documentation to discover all the possibilities and start creating integrations that drive your marketing results. # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.  The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.      BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Transport Layer Security (TLS) Transport Layer Security (TLS) is a widely used authentication and encryption protocol that establishes a secure communications channel for data-in-transit while ensuring that the client and server can validate one another.<br> Our API requires TLS 1.2 or TLS 1.3. We recommend <b>TLS 1.3</b>.<br><br> <b>TLS 1.3 ciphers</b> * TLS_AES_256_GCM_SHA384 (0x1302) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_CHACHA20_POLY1305_SHA256 (0x1303) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_AES_128_GCM_SHA256 (0x1301) ECDH x25519 (eq. 3072 bits RSA) FS  <b>TLS 1.2 ciphers</b> * TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 (0xc030) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 (0xc02f) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 (0x9f) DH 4096 bits FS * TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 (0x9e) DH 4096 bits FS  # Rate Limits Rate limits are used to control the amount of traffic that is allowed to flow between the client and the server.<br> This is done to prevent abuse and ensure that the API is available to all users.<br> The rate limits are applied to ensure the stability and security of our API and are based on the number of requests made in a given time period.<br> If the rate limit is exceeded, the API will return a 429 status code and the request will be rejected.<br> Each API response includes headers providing real-time rate limit information: * **X-RateLimit-Limit**: The maximum number of requests that the consumer is permitted to make in a given time period. * **X-RateLimit-Remaining**: The number of requests remaining in the current rate limit window. * **X-RateLimit-Reset**: The remaining time in seconds until the rate limit window resets.  # Account Limit The account limit is a rate limit that is applied to the account as a whole.<br> This limit is applied to all requests made by the account, regardless of the client making the request.<br> The account limit is applied to ensure that the account does not exceed the maximum number of requests allowed in a given time period. Each account has an overall usage limit per hour. If the account limit is exceeded, the API will return a 429 status code and the request will be rejected.<br> Each API response includes headers providing real-time rate limit information: * **X-Account-Limit**: The maximum number of requests that the account is permitted to make in a given time period. * **X-Account-Remaining**: The number of requests remaining in the current rate limit window. * **X-Account-Reset**: The remaining time in seconds until the rate limit window resets.   # Authentication  We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:     #!/bin/bash     curl -X GET 'https://api.egoiapp.com/my-account' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:     #!/bin/bash     curl -X POST 'http://api.egoiapp.com/tags' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>' \\     -H 'Content-Type: application/json' \\     -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  # Callbacks A callback is an asynchronous API request that originates from the API server and is sent to the client in response to a previous request sent by that client.  The API will make a **POST** request to the address defined in the URL with the information regarding the event of interest and share data related to that event.  <a href='/usecases/callbacks/' target='_blank'>[Go to callbacks documentation]</a>  ***Note:*** Only http or https protocols are supported in the Url parameter.  <security-definitions/>
 *
 * The version of the OpenAPI document: V3
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
    /// Product schema
    /// </summary>
    [DataContract]
    public partial class Product :  IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="categories">Array of product categories, using the character &#39;&gt;&#39; as delimiter for the breadcrumb                                 syntax.</param>
        /// <param name="relatedProducts">Related products, array of &#39;product_identifier&#39;.</param>
        /// <param name="customAttributes">Custom attributes.</param>
        /// <param name="productIdentifier">The ID of the product in your store.</param>
        /// <param name="name">Name of the product.</param>
        /// <param name="description">Description of the product.</param>
        /// <param name="sku">Stock Keeping Unit.</param>
        /// <param name="upc">Universal Product Code.</param>
        /// <param name="ean">European Article Numbering.</param>
        /// <param name="gtin">Global Trade Item Number.</param>
        /// <param name="mpn">Manufacturer Part Number.</param>
        /// <param name="link">Link for the product.</param>
        /// <param name="imageLink">Link for the product image.</param>
        /// <param name="price">Price of the product (default to 0D).</param>
        /// <param name="salePrice">Sale price of the product (default to 0D).</param>
        /// <param name="brand">Brand of the product.</param>
        public Product(List<string> categories = default(List<string>), List<string> relatedProducts = default(List<string>), List<ProductCustomAttributes> customAttributes = default(List<ProductCustomAttributes>), string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), string link = default(string), string imageLink = default(string), double price = 0D, double salePrice = 0D, string brand = default(string))
        {
            this.Categories = categories;
            this.RelatedProducts = relatedProducts;
            this.CustomAttributes = customAttributes;
            this.ProductIdentifier = productIdentifier;
            this.Name = name;
            this.Description = description;
            this.Sku = sku;
            this.Upc = upc;
            this.Ean = ean;
            this.Gtin = gtin;
            this.Mpn = mpn;
            this.Link = link;
            this.ImageLink = imageLink;
            // use default value if no "price" provided
            if (price == null)
            {
                this.Price = 0D;
            }
            else
            {
                this.Price = price;
            }
            // use default value if no "salePrice" provided
            if (salePrice == null)
            {
                this.SalePrice = 0D;
            }
            else
            {
                this.SalePrice = salePrice;
            }
            this.Brand = brand;
        }

        /// <summary>
        /// Array of product categories, using the character &#39;&gt;&#39; as delimiter for the breadcrumb                                 syntax
        /// </summary>
        /// <value>Array of product categories, using the character &#39;&gt;&#39; as delimiter for the breadcrumb                                 syntax</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Related products, array of &#39;product_identifier&#39;
        /// </summary>
        /// <value>Related products, array of &#39;product_identifier&#39;</value>
        [DataMember(Name="related_products", EmitDefaultValue=false)]
        public List<string> RelatedProducts { get; set; }

        /// <summary>
        /// Custom attributes
        /// </summary>
        /// <value>Custom attributes</value>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public List<ProductCustomAttributes> CustomAttributes { get; set; }

        /// <summary>
        /// The ID of the product in your store
        /// </summary>
        /// <value>The ID of the product in your store</value>
        [DataMember(Name="product_identifier", EmitDefaultValue=false)]
        public string ProductIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CatalogId
        /// </summary>
        [DataMember(Name="catalog_id", EmitDefaultValue=false)]
        public int CatalogId { get; private set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        /// <value>Name of the product</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the product
        /// </summary>
        /// <value>Description of the product</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Stock Keeping Unit
        /// </summary>
        /// <value>Stock Keeping Unit</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Universal Product Code
        /// </summary>
        /// <value>Universal Product Code</value>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; set; }

        /// <summary>
        /// European Article Numbering
        /// </summary>
        /// <value>European Article Numbering</value>
        [DataMember(Name="ean", EmitDefaultValue=false)]
        public string Ean { get; set; }

        /// <summary>
        /// Global Trade Item Number
        /// </summary>
        /// <value>Global Trade Item Number</value>
        [DataMember(Name="gtin", EmitDefaultValue=false)]
        public string Gtin { get; set; }

        /// <summary>
        /// Manufacturer Part Number
        /// </summary>
        /// <value>Manufacturer Part Number</value>
        [DataMember(Name="mpn", EmitDefaultValue=false)]
        public string Mpn { get; set; }

        /// <summary>
        /// Link for the product
        /// </summary>
        /// <value>Link for the product</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Link for the product image
        /// </summary>
        /// <value>Link for the product image</value>
        [DataMember(Name="image_link", EmitDefaultValue=false)]
        public string ImageLink { get; set; }

        /// <summary>
        /// Price of the product
        /// </summary>
        /// <value>Price of the product</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double Price { get; set; }

        /// <summary>
        /// Sale price of the product
        /// </summary>
        /// <value>Sale price of the product</value>
        [DataMember(Name="sale_price", EmitDefaultValue=false)]
        public double SalePrice { get; set; }

        /// <summary>
        /// Brand of the product
        /// </summary>
        /// <value>Brand of the product</value>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  RelatedProducts: ").Append(RelatedProducts).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  ProductIdentifier: ").Append(ProductIdentifier).Append("\n");
            sb.Append("  CatalogId: ").Append(CatalogId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  Ean: ").Append(Ean).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Mpn: ").Append(Mpn).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  ImageLink: ").Append(ImageLink).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.RelatedProducts == input.RelatedProducts ||
                    this.RelatedProducts != null &&
                    input.RelatedProducts != null &&
                    this.RelatedProducts.SequenceEqual(input.RelatedProducts)
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    input.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
                ) && 
                (
                    this.ProductIdentifier == input.ProductIdentifier ||
                    (this.ProductIdentifier != null &&
                    this.ProductIdentifier.Equals(input.ProductIdentifier))
                ) && 
                (
                    this.CatalogId == input.CatalogId ||
                    (this.CatalogId != null &&
                    this.CatalogId.Equals(input.CatalogId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Upc == input.Upc ||
                    (this.Upc != null &&
                    this.Upc.Equals(input.Upc))
                ) && 
                (
                    this.Ean == input.Ean ||
                    (this.Ean != null &&
                    this.Ean.Equals(input.Ean))
                ) && 
                (
                    this.Gtin == input.Gtin ||
                    (this.Gtin != null &&
                    this.Gtin.Equals(input.Gtin))
                ) && 
                (
                    this.Mpn == input.Mpn ||
                    (this.Mpn != null &&
                    this.Mpn.Equals(input.Mpn))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.ImageLink == input.ImageLink ||
                    (this.ImageLink != null &&
                    this.ImageLink.Equals(input.ImageLink))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    (this.SalePrice != null &&
                    this.SalePrice.Equals(input.SalePrice))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
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
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.RelatedProducts != null)
                    hashCode = hashCode * 59 + this.RelatedProducts.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.ProductIdentifier != null)
                    hashCode = hashCode * 59 + this.ProductIdentifier.GetHashCode();
                if (this.CatalogId != null)
                    hashCode = hashCode * 59 + this.CatalogId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Upc != null)
                    hashCode = hashCode * 59 + this.Upc.GetHashCode();
                if (this.Ean != null)
                    hashCode = hashCode * 59 + this.Ean.GetHashCode();
                if (this.Gtin != null)
                    hashCode = hashCode * 59 + this.Gtin.GetHashCode();
                if (this.Mpn != null)
                    hashCode = hashCode * 59 + this.Mpn.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.ImageLink != null)
                    hashCode = hashCode * 59 + this.ImageLink.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.SalePrice != null)
                    hashCode = hashCode * 59 + this.SalePrice.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
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


            // ProductIdentifier (string) pattern
            Regex regexProductIdentifier = new Regex(@"[a-zA-Z0-9\\_\\-.]", RegexOptions.CultureInvariant);
            if (false == regexProductIdentifier.Match(this.ProductIdentifier).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductIdentifier, must match a pattern of " + regexProductIdentifier, new [] { "ProductIdentifier" });
            }



            // CatalogId (int) minimum
            if(this.CatalogId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatalogId, must be a value greater than or equal to 1.", new [] { "CatalogId" });
            }

            yield break;
        }
    }

}
