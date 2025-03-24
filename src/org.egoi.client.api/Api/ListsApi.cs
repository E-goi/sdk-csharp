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
    public interface IListsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create new list
        /// </summary>
        /// <remarks>
        /// Create a new list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <returns>List</returns>
        List CreateList (PostRequestList postRequestList);

        /// <summary>
        /// Create new list
        /// </summary>
        /// <remarks>
        /// Create a new list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <returns>ApiResponse of List</returns>
        ApiResponse<List> CreateListWithHttpInfo (PostRequestList postRequestList);
        /// <summary>
        /// Remove list
        /// </summary>
        /// <remarks>
        /// Remove list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns></returns>
        void DeleteList (int listId);

        /// <summary>
        /// Remove list
        /// </summary>
        /// <remarks>
        /// Remove list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteListWithHttpInfo (int listId);
        /// <summary>
        /// Get all lists
        /// </summary>
        /// <remarks>
        /// Returns all lists
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <returns>ListCollection</returns>
        ListCollection GetAllLists (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?));

        /// <summary>
        /// Get all lists
        /// </summary>
        /// <remarks>
        /// Returns all lists
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <returns>ApiResponse of ListCollection</returns>
        ApiResponse<ListCollection> GetAllListsWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?));
        /// <summary>
        /// Get list
        /// </summary>
        /// <remarks>
        /// Returns list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns>ComplexList</returns>
        ComplexList GetList (int listId);

        /// <summary>
        /// Get list
        /// </summary>
        /// <remarks>
        /// Returns list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns>ApiResponse of ComplexList</returns>
        ApiResponse<ComplexList> GetListWithHttpInfo (int listId);
        /// <summary>
        /// Update a specific list
        /// </summary>
        /// <remarks>
        /// Update a list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <returns>List</returns>
        List UpdateList (int listId, PatchRequestList patchRequestList);

        /// <summary>
        /// Update a specific list
        /// </summary>
        /// <remarks>
        /// Update a list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <returns>ApiResponse of List</returns>
        ApiResponse<List> UpdateListWithHttpInfo (int listId, PatchRequestList patchRequestList);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create new list
        /// </summary>
        /// <remarks>
        /// Create a new list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List</returns>
        System.Threading.Tasks.Task<List> CreateListAsync (PostRequestList postRequestList, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new list
        /// </summary>
        /// <remarks>
        /// Create a new list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List)</returns>
        System.Threading.Tasks.Task<ApiResponse<List>> CreateListWithHttpInfoAsync (PostRequestList postRequestList, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove list
        /// </summary>
        /// <remarks>
        /// Remove list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteListAsync (int listId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove list
        /// </summary>
        /// <remarks>
        /// Remove list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteListWithHttpInfoAsync (int listId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all lists
        /// </summary>
        /// <remarks>
        /// Returns all lists
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ListCollection</returns>
        System.Threading.Tasks.Task<ListCollection> GetAllListsAsync (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all lists
        /// </summary>
        /// <remarks>
        /// Returns all lists
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ListCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListCollection>> GetAllListsWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get list
        /// </summary>
        /// <remarks>
        /// Returns list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ComplexList</returns>
        System.Threading.Tasks.Task<ComplexList> GetListAsync (int listId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get list
        /// </summary>
        /// <remarks>
        /// Returns list information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ComplexList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ComplexList>> GetListWithHttpInfoAsync (int listId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a specific list
        /// </summary>
        /// <remarks>
        /// Update a list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List</returns>
        System.Threading.Tasks.Task<List> UpdateListAsync (int listId, PatchRequestList patchRequestList, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update a specific list
        /// </summary>
        /// <remarks>
        /// Update a list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List)</returns>
        System.Threading.Tasks.Task<ApiResponse<List>> UpdateListWithHttpInfoAsync (int listId, PatchRequestList patchRequestList, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ListsApi : IListsApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ListsApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListsApi"/> class
        /// </summary>
        /// <returns></returns>
        public ListsApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ListsApi(org.egoi.client.api.Client.Configuration configuration = null)
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
        /// Create new list Create a new list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <returns>List</returns>
        public List CreateList (PostRequestList postRequestList)
        {
             ApiResponse<List> localVarResponse = CreateListWithHttpInfo(postRequestList);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new list Create a new list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <returns>ApiResponse of List</returns>
        public ApiResponse<List> CreateListWithHttpInfo (PostRequestList postRequestList)
        {
            // verify the required parameter 'postRequestList' is set
            if (postRequestList == null)
                throw new ApiException(400, "Missing required parameter 'postRequestList' when calling ListsApi->CreateList");

            var localVarPath = "/lists";
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

            if (postRequestList != null && postRequestList.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(postRequestList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = postRequestList; // byte array
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
                Exception exception = ExceptionFactory("CreateList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List)));
        }

        /// <summary>
        /// Create new list Create a new list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List</returns>
        public async System.Threading.Tasks.Task<List> CreateListAsync (PostRequestList postRequestList, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List> localVarResponse = await CreateListWithHttpInfoAsync(postRequestList, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new list Create a new list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List>> CreateListWithHttpInfoAsync (PostRequestList postRequestList, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'postRequestList' is set
            if (postRequestList == null)
                throw new ApiException(400, "Missing required parameter 'postRequestList' when calling ListsApi->CreateList");

            var localVarPath = "/lists";
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

            if (postRequestList != null && postRequestList.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(postRequestList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = postRequestList; // byte array
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
                Exception exception = ExceptionFactory("CreateList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List)));
        }

        /// <summary>
        /// Remove list Remove list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns></returns>
        public void DeleteList (int listId)
        {
             DeleteListWithHttpInfo(listId);
        }

        /// <summary>
        /// Remove list Remove list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteListWithHttpInfo (int listId)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ListsApi->DeleteList");

            var localVarPath = "/lists/{list_id}";
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

            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove list Remove list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteListAsync (int listId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteListWithHttpInfoAsync(listId, cancellationToken);

        }

        /// <summary>
        /// Remove list Remove list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteListWithHttpInfoAsync (int listId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ListsApi->DeleteList");

            var localVarPath = "/lists/{list_id}";
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

            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get all lists Returns all lists
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <returns>ListCollection</returns>
        public ListCollection GetAllLists (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?))
        {
             ApiResponse<ListCollection> localVarResponse = GetAllListsWithHttpInfo(offset, limit, order, orderBy, internalName, publicName, createdMin, createdMax, updatedMin, updatedMax);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all lists Returns all lists
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <returns>ApiResponse of ListCollection</returns>
        public ApiResponse<ListCollection> GetAllListsWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?))
        {

            var localVarPath = "/lists";
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

            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_by", orderBy)); // query parameter
            if (internalName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "internal_name", internalName)); // query parameter
            if (publicName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "public_name", publicName)); // query parameter
            if (createdMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_min", createdMin)); // query parameter
            if (createdMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_max", createdMax)); // query parameter
            if (updatedMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_min", updatedMin)); // query parameter
            if (updatedMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_max", updatedMax)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllLists", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ListCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListCollection)));
        }

        /// <summary>
        /// Get all lists Returns all lists
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ListCollection</returns>
        public async System.Threading.Tasks.Task<ListCollection> GetAllListsAsync (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ListCollection> localVarResponse = await GetAllListsWithHttpInfoAsync(offset, limit, order, orderBy, internalName, publicName, createdMin, createdMax, updatedMin, updatedMax, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all lists Returns all lists
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order lists (optional, default to list_id)</param>
        /// <param name="internalName">Internal name of the list (optional)</param>
        /// <param name="publicName">Public name of the list (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ListCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListCollection>> GetAllListsWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), string internalName = default(string), string publicName = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/lists";
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

            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_by", orderBy)); // query parameter
            if (internalName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "internal_name", internalName)); // query parameter
            if (publicName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "public_name", publicName)); // query parameter
            if (createdMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_min", createdMin)); // query parameter
            if (createdMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_max", createdMax)); // query parameter
            if (updatedMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_min", updatedMin)); // query parameter
            if (updatedMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_max", updatedMax)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllLists", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ListCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListCollection)));
        }

        /// <summary>
        /// Get list Returns list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns>ComplexList</returns>
        public ComplexList GetList (int listId)
        {
             ApiResponse<ComplexList> localVarResponse = GetListWithHttpInfo(listId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list Returns list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <returns>ApiResponse of ComplexList</returns>
        public ApiResponse<ComplexList> GetListWithHttpInfo (int listId)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ListsApi->GetList");

            var localVarPath = "/lists/{list_id}";
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

            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter

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
                Exception exception = ExceptionFactory("GetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComplexList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ComplexList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComplexList)));
        }

        /// <summary>
        /// Get list Returns list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ComplexList</returns>
        public async System.Threading.Tasks.Task<ComplexList> GetListAsync (int listId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ComplexList> localVarResponse = await GetListWithHttpInfoAsync(listId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list Returns list information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ComplexList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ComplexList>> GetListWithHttpInfoAsync (int listId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ListsApi->GetList");

            var localVarPath = "/lists/{list_id}";
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

            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter

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
                Exception exception = ExceptionFactory("GetList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComplexList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ComplexList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComplexList)));
        }

        /// <summary>
        /// Update a specific list Update a list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <returns>List</returns>
        public List UpdateList (int listId, PatchRequestList patchRequestList)
        {
             ApiResponse<List> localVarResponse = UpdateListWithHttpInfo(listId, patchRequestList);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a specific list Update a list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <returns>ApiResponse of List</returns>
        public ApiResponse<List> UpdateListWithHttpInfo (int listId, PatchRequestList patchRequestList)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ListsApi->UpdateList");
            // verify the required parameter 'patchRequestList' is set
            if (patchRequestList == null)
                throw new ApiException(400, "Missing required parameter 'patchRequestList' when calling ListsApi->UpdateList");

            var localVarPath = "/lists/{list_id}";
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
            if (patchRequestList != null && patchRequestList.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(patchRequestList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = patchRequestList; // byte array
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
                Exception exception = ExceptionFactory("UpdateList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List)));
        }

        /// <summary>
        /// Update a specific list Update a list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List</returns>
        public async System.Threading.Tasks.Task<List> UpdateListAsync (int listId, PatchRequestList patchRequestList, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List> localVarResponse = await UpdateListWithHttpInfoAsync(listId, patchRequestList, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a specific list Update a list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="patchRequestList">Parameters for the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List>> UpdateListWithHttpInfoAsync (int listId, PatchRequestList patchRequestList, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ListsApi->UpdateList");
            // verify the required parameter 'patchRequestList' is set
            if (patchRequestList == null)
                throw new ApiException(400, "Missing required parameter 'patchRequestList' when calling ListsApi->UpdateList");

            var localVarPath = "/lists/{list_id}";
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
            if (patchRequestList != null && patchRequestList.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(patchRequestList); // http body (model) parameter
            }
            else
            {
                localVarPostBody = patchRequestList; // byte array
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
                Exception exception = ExceptionFactory("UpdateList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List)));
        }

    }
}
