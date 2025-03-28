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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace org.egoi.client.api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEcommerceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create cart
        /// </summary>
        /// <remarks>
        /// Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse CreateCart (string domain, Cart cart);

        /// <summary>
        /// Create cart
        /// </summary>
        /// <remarks>
        /// Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> CreateCartWithHttpInfo (string domain, Cart cart);
        /// <summary>
        /// Create new catalog
        /// </summary>
        /// <remarks>
        /// Creates a new catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <returns>Catalog</returns>
        Catalog CreateCatalog (CatalogPostRequest catalogPostRequest);

        /// <summary>
        /// Create new catalog
        /// </summary>
        /// <remarks>
        /// Creates a new catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <returns>ApiResponse of Catalog</returns>
        ApiResponse<Catalog> CreateCatalogWithHttpInfo (CatalogPostRequest catalogPostRequest);
        /// <summary>
        /// Create order
        /// </summary>
        /// <remarks>
        /// Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse CreateOrder (string domain, CreateOrder createOrder);

        /// <summary>
        /// Create order
        /// </summary>
        /// <remarks>
        /// Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> CreateOrderWithHttpInfo (string domain, CreateOrder createOrder);
        /// <summary>
        /// Create new product
        /// </summary>
        /// <remarks>
        /// Creates a new product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <returns>Product</returns>
        Product CreateProduct (int catalogId, ProductPostRequest productPostRequest);

        /// <summary>
        /// Create new product
        /// </summary>
        /// <remarks>
        /// Creates a new product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <returns>ApiResponse of Product</returns>
        ApiResponse<Product> CreateProductWithHttpInfo (int catalogId, ProductPostRequest productPostRequest);
        /// <summary>
        /// Remove catalog
        /// </summary>
        /// <remarks>
        /// Remove catalog information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <returns></returns>
        void DeleteCatalog (int catalogId);

        /// <summary>
        /// Remove catalog
        /// </summary>
        /// <remarks>
        /// Remove catalog information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCatalogWithHttpInfo (int catalogId);
        /// <summary>
        /// Remove product
        /// </summary>
        /// <remarks>
        /// Remove product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns></returns>
        void DeleteProduct (int catalogId, string productIdentifier);

        /// <summary>
        /// Remove product
        /// </summary>
        /// <remarks>
        /// Remove product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProductWithHttpInfo (int catalogId, string productIdentifier);
        /// <summary>
        /// Get all catalogs
        /// </summary>
        /// <remarks>
        /// Returns all catalogs
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CatalogCollection</returns>
        CatalogCollection GetAllCatalogs ();

        /// <summary>
        /// Get all catalogs
        /// </summary>
        /// <remarks>
        /// Returns all catalogs
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CatalogCollection</returns>
        ApiResponse<CatalogCollection> GetAllCatalogsWithHttpInfo ();
        /// <summary>
        /// Get all products
        /// </summary>
        /// <remarks>
        /// Returns all products for the given catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>ProductCollection</returns>
        ProductCollection GetAllProducts (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?));

        /// <summary>
        /// Get all products
        /// </summary>
        /// <remarks>
        /// Returns all products for the given catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>ApiResponse of ProductCollection</returns>
        ApiResponse<ProductCollection> GetAllProductsWithHttpInfo (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?));
        /// <summary>
        /// Get product
        /// </summary>
        /// <remarks>
        /// Returns product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns>Product</returns>
        Product GetProduct (int catalogId, string productIdentifier);

        /// <summary>
        /// Get product
        /// </summary>
        /// <remarks>
        /// Returns product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns>ApiResponse of Product</returns>
        ApiResponse<Product> GetProductWithHttpInfo (int catalogId, string productIdentifier);
        /// <summary>
        /// Orders import bulk request
        /// </summary>
        /// <remarks>
        /// Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ImportOrdersBulk (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest);

        /// <summary>
        /// Orders import bulk request
        /// </summary>
        /// <remarks>
        /// Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ImportOrdersBulkWithHttpInfo (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest);
        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ImportProducts (int catalogId, ProductBulkRequest productBulkRequest);

        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ImportProductsWithHttpInfo (int catalogId, ProductBulkRequest productBulkRequest);
        /// <summary>
        /// Update product
        /// </summary>
        /// <remarks>
        /// Updates a product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <returns>Product</returns>
        Product UpdateProduct (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest);

        /// <summary>
        /// Update product
        /// </summary>
        /// <remarks>
        /// Updates a product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <returns>ApiResponse of Product</returns>
        ApiResponse<Product> UpdateProductWithHttpInfo (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create cart
        /// </summary>
        /// <remarks>
        /// Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> CreateCartAsync (string domain, Cart cart, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create cart
        /// </summary>
        /// <remarks>
        /// Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> CreateCartWithHttpInfoAsync (string domain, Cart cart, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create new catalog
        /// </summary>
        /// <remarks>
        /// Creates a new catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Catalog</returns>
        System.Threading.Tasks.Task<Catalog> CreateCatalogAsync (CatalogPostRequest catalogPostRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new catalog
        /// </summary>
        /// <remarks>
        /// Creates a new catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Catalog)</returns>
        System.Threading.Tasks.Task<ApiResponse<Catalog>> CreateCatalogWithHttpInfoAsync (CatalogPostRequest catalogPostRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create order
        /// </summary>
        /// <remarks>
        /// Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> CreateOrderAsync (string domain, CreateOrder createOrder, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create order
        /// </summary>
        /// <remarks>
        /// Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> CreateOrderWithHttpInfoAsync (string domain, CreateOrder createOrder, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create new product
        /// </summary>
        /// <remarks>
        /// Creates a new product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Product</returns>
        System.Threading.Tasks.Task<Product> CreateProductAsync (int catalogId, ProductPostRequest productPostRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new product
        /// </summary>
        /// <remarks>
        /// Creates a new product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Product)</returns>
        System.Threading.Tasks.Task<ApiResponse<Product>> CreateProductWithHttpInfoAsync (int catalogId, ProductPostRequest productPostRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove catalog
        /// </summary>
        /// <remarks>
        /// Remove catalog information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCatalogAsync (int catalogId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove catalog
        /// </summary>
        /// <remarks>
        /// Remove catalog information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCatalogWithHttpInfoAsync (int catalogId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove product
        /// </summary>
        /// <remarks>
        /// Remove product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProductAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove product
        /// </summary>
        /// <remarks>
        /// Remove product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductWithHttpInfoAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all catalogs
        /// </summary>
        /// <remarks>
        /// Returns all catalogs
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CatalogCollection</returns>
        System.Threading.Tasks.Task<CatalogCollection> GetAllCatalogsAsync (CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all catalogs
        /// </summary>
        /// <remarks>
        /// Returns all catalogs
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CatalogCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<CatalogCollection>> GetAllCatalogsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all products
        /// </summary>
        /// <remarks>
        /// Returns all products for the given catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ProductCollection</returns>
        System.Threading.Tasks.Task<ProductCollection> GetAllProductsAsync (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all products
        /// </summary>
        /// <remarks>
        /// Returns all products for the given catalog
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ProductCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductCollection>> GetAllProductsWithHttpInfoAsync (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get product
        /// </summary>
        /// <remarks>
        /// Returns product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Product</returns>
        System.Threading.Tasks.Task<Product> GetProductAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get product
        /// </summary>
        /// <remarks>
        /// Returns product information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Product)</returns>
        System.Threading.Tasks.Task<ApiResponse<Product>> GetProductWithHttpInfoAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Orders import bulk request
        /// </summary>
        /// <remarks>
        /// Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ImportOrdersBulkAsync (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Orders import bulk request
        /// </summary>
        /// <remarks>
        /// Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ImportOrdersBulkWithHttpInfoAsync (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ImportProductsAsync (int catalogId, ProductBulkRequest productBulkRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Import products
        /// </summary>
        /// <remarks>
        /// Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ImportProductsWithHttpInfoAsync (int catalogId, ProductBulkRequest productBulkRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update product
        /// </summary>
        /// <remarks>
        /// Updates a product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Product</returns>
        System.Threading.Tasks.Task<Product> UpdateProductAsync (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update product
        /// </summary>
        /// <remarks>
        /// Updates a product
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Product)</returns>
        System.Threading.Tasks.Task<ApiResponse<Product>> UpdateProductWithHttpInfoAsync (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EcommerceApi : IEcommerceApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EcommerceApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceApi"/> class
        /// </summary>
        /// <returns></returns>
        public EcommerceApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EcommerceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EcommerceApi(org.egoi.client.api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = org.egoi.client.api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public org.egoi.client.api.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public org.egoi.client.api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create cart Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse CreateCart (string domain, Cart cart)
        {
             ApiResponse<AcceptedResponse> localVarResponse = CreateCartWithHttpInfo(domain, cart);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create cart Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> CreateCartWithHttpInfo (string domain, Cart cart)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling EcommerceApi->CreateCart");
            // verify the required parameter 'cart' is set
            if (cart == null)
                throw new ApiException(400, "Missing required parameter 'cart' when calling EcommerceApi->CreateCart");

            var localVarPath = "/{domain}/carts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (domain != null) localVarPathParams.Add("domain", this.Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (cart != null && cart.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cart); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cart; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCart", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Create cart Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> CreateCartAsync (string domain, Cart cart, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await CreateCartWithHttpInfoAsync(domain, cart, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create cart Creates a new cart. If ***contact_id*** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (**make sure you are sending atleast all configured list&#39;s unique fields**). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="cart">Parameters for the Carts</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> CreateCartWithHttpInfoAsync (string domain, Cart cart, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling EcommerceApi->CreateCart");
            // verify the required parameter 'cart' is set
            if (cart == null)
                throw new ApiException(400, "Missing required parameter 'cart' when calling EcommerceApi->CreateCart");

            var localVarPath = "/{domain}/carts";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (domain != null) localVarPathParams.Add("domain", this.Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (cart != null && cart.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cart); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cart; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCart", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Create new catalog Creates a new catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <returns>Catalog</returns>
        public Catalog CreateCatalog (CatalogPostRequest catalogPostRequest)
        {
             ApiResponse<Catalog> localVarResponse = CreateCatalogWithHttpInfo(catalogPostRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new catalog Creates a new catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <returns>ApiResponse of Catalog</returns>
        public ApiResponse<Catalog> CreateCatalogWithHttpInfo (CatalogPostRequest catalogPostRequest)
        {
            // verify the required parameter 'catalogPostRequest' is set
            if (catalogPostRequest == null)
                throw new ApiException(400, "Missing required parameter 'catalogPostRequest' when calling EcommerceApi->CreateCatalog");

            var localVarPath = "/catalogs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogPostRequest != null && catalogPostRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(catalogPostRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = catalogPostRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCatalog", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Catalog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Catalog) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Catalog)));
        }

        /// <summary>
        /// Create new catalog Creates a new catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Catalog</returns>
        public async System.Threading.Tasks.Task<Catalog> CreateCatalogAsync (CatalogPostRequest catalogPostRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Catalog> localVarResponse = await CreateCatalogWithHttpInfoAsync(catalogPostRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new catalog Creates a new catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogPostRequest">Parameters for the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Catalog)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Catalog>> CreateCatalogWithHttpInfoAsync (CatalogPostRequest catalogPostRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogPostRequest' is set
            if (catalogPostRequest == null)
                throw new ApiException(400, "Missing required parameter 'catalogPostRequest' when calling EcommerceApi->CreateCatalog");

            var localVarPath = "/catalogs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogPostRequest != null && catalogPostRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(catalogPostRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = catalogPostRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCatalog", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Catalog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Catalog) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Catalog)));
        }

        /// <summary>
        /// Create order Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse CreateOrder (string domain, CreateOrder createOrder)
        {
             ApiResponse<AcceptedResponse> localVarResponse = CreateOrderWithHttpInfo(domain, createOrder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create order Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> CreateOrderWithHttpInfo (string domain, CreateOrder createOrder)
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling EcommerceApi->CreateOrder");
            // verify the required parameter 'createOrder' is set
            if (createOrder == null)
                throw new ApiException(400, "Missing required parameter 'createOrder' when calling EcommerceApi->CreateOrder");

            var localVarPath = "/{domain}/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (domain != null) localVarPathParams.Add("domain", this.Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (createOrder != null && createOrder.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createOrder); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createOrder; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Create order Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> CreateOrderAsync (string domain, CreateOrder createOrder, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await CreateOrderWithHttpInfoAsync(domain, createOrder, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create order Creates a new order. If **contact_id** is specified, order will be atached to the contact, if the contact propreties are specified, we&#39;ll create the user, if its already in your list it will get the correct contact (***make sure you are sending atleast all configured list&#39;s unique fields***). This same logic is also applied to the **product_identifier**.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="domain">Domain</param>
        /// <param name="createOrder">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> CreateOrderWithHttpInfoAsync (string domain, CreateOrder createOrder, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new ApiException(400, "Missing required parameter 'domain' when calling EcommerceApi->CreateOrder");
            // verify the required parameter 'createOrder' is set
            if (createOrder == null)
                throw new ApiException(400, "Missing required parameter 'createOrder' when calling EcommerceApi->CreateOrder");

            var localVarPath = "/{domain}/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (domain != null) localVarPathParams.Add("domain", this.Configuration.ApiClient.ParameterToString(domain)); // path parameter
            if (createOrder != null && createOrder.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(createOrder); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createOrder; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Create new product Creates a new product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <returns>Product</returns>
        public Product CreateProduct (int catalogId, ProductPostRequest productPostRequest)
        {
             ApiResponse<Product> localVarResponse = CreateProductWithHttpInfo(catalogId, productPostRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new product Creates a new product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <returns>ApiResponse of Product</returns>
        public ApiResponse<Product> CreateProductWithHttpInfo (int catalogId, ProductPostRequest productPostRequest)
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->CreateProduct");
            // verify the required parameter 'productPostRequest' is set
            if (productPostRequest == null)
                throw new ApiException(400, "Missing required parameter 'productPostRequest' when calling EcommerceApi->CreateProduct");

            var localVarPath = "/catalogs/{catalog_id}/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productPostRequest != null && productPostRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(productPostRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productPostRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Product>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Product) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Product)));
        }

        /// <summary>
        /// Create new product Creates a new product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Product</returns>
        public async System.Threading.Tasks.Task<Product> CreateProductAsync (int catalogId, ProductPostRequest productPostRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Product> localVarResponse = await CreateProductWithHttpInfoAsync(catalogId, productPostRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new product Creates a new product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productPostRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Product)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Product>> CreateProductWithHttpInfoAsync (int catalogId, ProductPostRequest productPostRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->CreateProduct");
            // verify the required parameter 'productPostRequest' is set
            if (productPostRequest == null)
                throw new ApiException(400, "Missing required parameter 'productPostRequest' when calling EcommerceApi->CreateProduct");

            var localVarPath = "/catalogs/{catalog_id}/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productPostRequest != null && productPostRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(productPostRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productPostRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Product>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Product) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Product)));
        }

        /// <summary>
        /// Remove catalog Remove catalog information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <returns></returns>
        public void DeleteCatalog (int catalogId)
        {
             DeleteCatalogWithHttpInfo(catalogId);
        }

        /// <summary>
        /// Remove catalog Remove catalog information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCatalogWithHttpInfo (int catalogId)
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->DeleteCatalog");

            var localVarPath = "/catalogs/{catalog_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteCatalog", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove catalog Remove catalog information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCatalogAsync (int catalogId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteCatalogWithHttpInfoAsync(catalogId, cancellationToken);

        }

        /// <summary>
        /// Remove catalog Remove catalog information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCatalogWithHttpInfoAsync (int catalogId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->DeleteCatalog");

            var localVarPath = "/catalogs/{catalog_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteCatalog", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove product Remove product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns></returns>
        public void DeleteProduct (int catalogId, string productIdentifier)
        {
             DeleteProductWithHttpInfo(catalogId, productIdentifier);
        }

        /// <summary>
        /// Remove product Remove product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProductWithHttpInfo (int catalogId, string productIdentifier)
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->DeleteProduct");
            // verify the required parameter 'productIdentifier' is set
            if (productIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'productIdentifier' when calling EcommerceApi->DeleteProduct");

            var localVarPath = "/catalogs/{catalog_id}/products/{product_identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarPathParams.Add("product_identifier", this.Configuration.ApiClient.ParameterToString(productIdentifier)); // path parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove product Remove product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProductAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteProductWithHttpInfoAsync(catalogId, productIdentifier, cancellationToken);

        }

        /// <summary>
        /// Remove product Remove product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductWithHttpInfoAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->DeleteProduct");
            // verify the required parameter 'productIdentifier' is set
            if (productIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'productIdentifier' when calling EcommerceApi->DeleteProduct");

            var localVarPath = "/catalogs/{catalog_id}/products/{product_identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarPathParams.Add("product_identifier", this.Configuration.ApiClient.ParameterToString(productIdentifier)); // path parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get all catalogs Returns all catalogs
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CatalogCollection</returns>
        public CatalogCollection GetAllCatalogs ()
        {
             ApiResponse<CatalogCollection> localVarResponse = GetAllCatalogsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all catalogs Returns all catalogs
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CatalogCollection</returns>
        public ApiResponse<CatalogCollection> GetAllCatalogsWithHttpInfo ()
        {

            var localVarPath = "/catalogs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCatalogs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CatalogCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CatalogCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CatalogCollection)));
        }

        /// <summary>
        /// Get all catalogs Returns all catalogs
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CatalogCollection</returns>
        public async System.Threading.Tasks.Task<CatalogCollection> GetAllCatalogsAsync (CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CatalogCollection> localVarResponse = await GetAllCatalogsWithHttpInfoAsync(cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all catalogs Returns all catalogs
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CatalogCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CatalogCollection>> GetAllCatalogsWithHttpInfoAsync (CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/catalogs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCatalogs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CatalogCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CatalogCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CatalogCollection)));
        }

        /// <summary>
        /// Get all products Returns all products for the given catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>ProductCollection</returns>
        public ProductCollection GetAllProducts (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?))
        {
             ApiResponse<ProductCollection> localVarResponse = GetAllProductsWithHttpInfo(catalogId, productIdentifier, name, description, sku, upc, ean, gtin, mpn, price, salePrice, brand, customAttributes, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all products Returns all products for the given catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>ApiResponse of ProductCollection</returns>
        public ApiResponse<ProductCollection> GetAllProductsWithHttpInfo (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->GetAllProducts");

            var localVarPath = "/catalogs/{catalog_id}/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_identifier", productIdentifier)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "description", description)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (upc != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "upc", upc)); // query parameter
            if (ean != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ean", ean)); // query parameter
            if (gtin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "gtin", gtin)); // query parameter
            if (mpn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "mpn", mpn)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (salePrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sale_price", salePrice)); // query parameter
            if (brand != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand", brand)); // query parameter
            if (customAttributes != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "custom_attributes", customAttributes)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductCollection)));
        }

        /// <summary>
        /// Get all products Returns all products for the given catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ProductCollection</returns>
        public async System.Threading.Tasks.Task<ProductCollection> GetAllProductsAsync (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ProductCollection> localVarResponse = await GetAllProductsWithHttpInfoAsync(catalogId, productIdentifier, name, description, sku, upc, ean, gtin, mpn, price, salePrice, brand, customAttributes, offset, limit, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all products Returns all products for the given catalog
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">Filter by product ID in your store (optional)</param>
        /// <param name="name">Filter by name of the product (optional)</param>
        /// <param name="description">Filter by description of the product (optional)</param>
        /// <param name="sku">Filter by Stock Keeping Unit (optional)</param>
        /// <param name="upc">Filter by Universal Product Code (optional)</param>
        /// <param name="ean">Filter by European Article Numbering (optional)</param>
        /// <param name="gtin">Filter by Global Trade Item Number (optional)</param>
        /// <param name="mpn">Filter by Manufacturer Part Number (optional)</param>
        /// <param name="price">Filter by price of the product (optional)</param>
        /// <param name="salePrice">Filter by sale price of the product (optional)</param>
        /// <param name="brand">Filter by brand of the product (optional)</param>
        /// <param name="customAttributes">Filter by custom attributes of products&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;custom_attributes[alias]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ProductCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductCollection>> GetAllProductsWithHttpInfoAsync (int catalogId, string productIdentifier = default(string), string name = default(string), string description = default(string), string sku = default(string), string upc = default(string), string ean = default(string), string gtin = default(string), string mpn = default(string), decimal? price = default(decimal?), decimal? salePrice = default(decimal?), string brand = default(string), CustomAttributes customAttributes = default(CustomAttributes), int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->GetAllProducts");

            var localVarPath = "/catalogs/{catalog_id}/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_identifier", productIdentifier)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (description != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "description", description)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (upc != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "upc", upc)); // query parameter
            if (ean != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "ean", ean)); // query parameter
            if (gtin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "gtin", gtin)); // query parameter
            if (mpn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "mpn", mpn)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (salePrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sale_price", salePrice)); // query parameter
            if (brand != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand", brand)); // query parameter
            if (customAttributes != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "custom_attributes", customAttributes)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductCollection)));
        }

        /// <summary>
        /// Get product Returns product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns>Product</returns>
        public Product GetProduct (int catalogId, string productIdentifier)
        {
             ApiResponse<Product> localVarResponse = GetProductWithHttpInfo(catalogId, productIdentifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get product Returns product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <returns>ApiResponse of Product</returns>
        public ApiResponse<Product> GetProductWithHttpInfo (int catalogId, string productIdentifier)
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->GetProduct");
            // verify the required parameter 'productIdentifier' is set
            if (productIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'productIdentifier' when calling EcommerceApi->GetProduct");

            var localVarPath = "/catalogs/{catalog_id}/products/{product_identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarPathParams.Add("product_identifier", this.Configuration.ApiClient.ParameterToString(productIdentifier)); // path parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Product>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Product) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Product)));
        }

        /// <summary>
        /// Get product Returns product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Product</returns>
        public async System.Threading.Tasks.Task<Product> GetProductAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Product> localVarResponse = await GetProductWithHttpInfoAsync(catalogId, productIdentifier, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get product Returns product information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Product)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Product>> GetProductWithHttpInfoAsync (int catalogId, string productIdentifier, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->GetProduct");
            // verify the required parameter 'productIdentifier' is set
            if (productIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'productIdentifier' when calling EcommerceApi->GetProduct");

            var localVarPath = "/catalogs/{catalog_id}/products/{product_identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarPathParams.Add("product_identifier", this.Configuration.ApiClient.ParameterToString(productIdentifier)); // path parameter

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Product>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Product) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Product)));
        }

        /// <summary>
        /// Orders import bulk request Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ImportOrdersBulk (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ImportOrdersBulkWithHttpInfo(listId, importOrdersBulkBulkRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Orders import bulk request Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ImportOrdersBulkWithHttpInfo (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling EcommerceApi->ImportOrdersBulk");
            // verify the required parameter 'importOrdersBulkBulkRequest' is set
            if (importOrdersBulkBulkRequest == null)
                throw new ApiException(400, "Missing required parameter 'importOrdersBulkBulkRequest' when calling EcommerceApi->ImportOrdersBulk");

            var localVarPath = "/lists/{list_id}/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter
            if (importOrdersBulkBulkRequest != null && importOrdersBulkBulkRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(importOrdersBulkBulkRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = importOrdersBulkBulkRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImportOrdersBulk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Orders import bulk request Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ImportOrdersBulkAsync (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ImportOrdersBulkWithHttpInfoAsync(listId, importOrdersBulkBulkRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Orders import bulk request Creates new bulk orders syncronization &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importOrdersBulkBulkRequest">Parameters for the Orders</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ImportOrdersBulkWithHttpInfoAsync (int listId, List<ImportOrdersBulkBulkRequest> importOrdersBulkBulkRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling EcommerceApi->ImportOrdersBulk");
            // verify the required parameter 'importOrdersBulkBulkRequest' is set
            if (importOrdersBulkBulkRequest == null)
                throw new ApiException(400, "Missing required parameter 'importOrdersBulkBulkRequest' when calling EcommerceApi->ImportOrdersBulk");

            var localVarPath = "/lists/{list_id}/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter
            if (importOrdersBulkBulkRequest != null && importOrdersBulkBulkRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(importOrdersBulkBulkRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = importOrdersBulkBulkRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImportOrdersBulk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Import products Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ImportProducts (int catalogId, ProductBulkRequest productBulkRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ImportProductsWithHttpInfo(catalogId, productBulkRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Import products Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ImportProductsWithHttpInfo (int catalogId, ProductBulkRequest productBulkRequest)
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->ImportProducts");
            // verify the required parameter 'productBulkRequest' is set
            if (productBulkRequest == null)
                throw new ApiException(400, "Missing required parameter 'productBulkRequest' when calling EcommerceApi->ImportProducts");

            var localVarPath = "/catalogs/{catalog_id}/products/actions/import";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productBulkRequest != null && productBulkRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(productBulkRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productBulkRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImportProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Import products Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ImportProductsAsync (int catalogId, ProductBulkRequest productBulkRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ImportProductsWithHttpInfoAsync(catalogId, productBulkRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Import products Imports a collection of products&lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productBulkRequest">Parameters for the Product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ImportProductsWithHttpInfoAsync (int catalogId, ProductBulkRequest productBulkRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->ImportProducts");
            // verify the required parameter 'productBulkRequest' is set
            if (productBulkRequest == null)
                throw new ApiException(400, "Missing required parameter 'productBulkRequest' when calling EcommerceApi->ImportProducts");

            var localVarPath = "/catalogs/{catalog_id}/products/actions/import";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productBulkRequest != null && productBulkRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(productBulkRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productBulkRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ImportProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Update product Updates a product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <returns>Product</returns>
        public Product UpdateProduct (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest)
        {
             ApiResponse<Product> localVarResponse = UpdateProductWithHttpInfo(catalogId, productIdentifier, productPatchRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update product Updates a product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <returns>ApiResponse of Product</returns>
        public ApiResponse<Product> UpdateProductWithHttpInfo (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest)
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->UpdateProduct");
            // verify the required parameter 'productIdentifier' is set
            if (productIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'productIdentifier' when calling EcommerceApi->UpdateProduct");
            // verify the required parameter 'productPatchRequest' is set
            if (productPatchRequest == null)
                throw new ApiException(400, "Missing required parameter 'productPatchRequest' when calling EcommerceApi->UpdateProduct");

            var localVarPath = "/catalogs/{catalog_id}/products/{product_identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarPathParams.Add("product_identifier", this.Configuration.ApiClient.ParameterToString(productIdentifier)); // path parameter
            if (productPatchRequest != null && productPatchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(productPatchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productPatchRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Product>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Product) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Product)));
        }

        /// <summary>
        /// Update product Updates a product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Product</returns>
        public async System.Threading.Tasks.Task<Product> UpdateProductAsync (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Product> localVarResponse = await UpdateProductWithHttpInfoAsync(catalogId, productIdentifier, productPatchRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update product Updates a product
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="catalogId">ID of the Catalog</param>
        /// <param name="productIdentifier">ID of the Product</param>
        /// <param name="productPatchRequest">Parameters for the product</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Product)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Product>> UpdateProductWithHttpInfoAsync (int catalogId, string productIdentifier, ProductPatchRequest productPatchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'catalogId' is set
            if (catalogId == null)
                throw new ApiException(400, "Missing required parameter 'catalogId' when calling EcommerceApi->UpdateProduct");
            // verify the required parameter 'productIdentifier' is set
            if (productIdentifier == null)
                throw new ApiException(400, "Missing required parameter 'productIdentifier' when calling EcommerceApi->UpdateProduct");
            // verify the required parameter 'productPatchRequest' is set
            if (productPatchRequest == null)
                throw new ApiException(400, "Missing required parameter 'productPatchRequest' when calling EcommerceApi->UpdateProduct");

            var localVarPath = "/catalogs/{catalog_id}/products/{product_identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (catalogId != null) localVarPathParams.Add("catalog_id", this.Configuration.ApiClient.ParameterToString(catalogId)); // path parameter
            if (productIdentifier != null) localVarPathParams.Add("product_identifier", this.Configuration.ApiClient.ParameterToString(productIdentifier)); // path parameter
            if (productPatchRequest != null && productPatchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(productPatchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = productPatchRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Product>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Product) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Product)));
        }

    }
}
