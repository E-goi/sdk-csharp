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
    public interface ICampaignsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Remove Campaign
        /// </summary>
        /// <remarks>
        /// Remove campaign information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <returns></returns>
        void DeleteCampaigns (string campaignHash);

        /// <summary>
        /// Remove Campaign
        /// </summary>
        /// <remarks>
        /// Remove campaign information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCampaignsWithHttpInfo (string campaignHash);
        /// <summary>
        /// Get all Campaigns
        /// </summary>
        /// <remarks>
        /// Returns all campaigns
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <returns>CampaignsCollection</returns>
        CampaignsCollection GetAllCampaigns (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string));

        /// <summary>
        /// Get all Campaigns
        /// </summary>
        /// <remarks>
        /// Returns all campaigns
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <returns>ApiResponse of CampaignsCollection</returns>
        ApiResponse<CampaignsCollection> GetAllCampaignsWithHttpInfo (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Remove Campaign
        /// </summary>
        /// <remarks>
        /// Remove campaign information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCampaignsAsync (string campaignHash, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove Campaign
        /// </summary>
        /// <remarks>
        /// Remove campaign information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCampaignsWithHttpInfoAsync (string campaignHash, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all Campaigns
        /// </summary>
        /// <remarks>
        /// Returns all campaigns
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CampaignsCollection</returns>
        System.Threading.Tasks.Task<CampaignsCollection> GetAllCampaignsAsync (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all Campaigns
        /// </summary>
        /// <remarks>
        /// Returns all campaigns
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CampaignsCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<CampaignsCollection>> GetAllCampaignsWithHttpInfoAsync (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CampaignsApi : ICampaignsApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CampaignsApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CampaignsApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CampaignsApi(org.egoi.client.api.Client.Configuration configuration = null)
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
        /// Remove Campaign Remove campaign information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <returns></returns>
        public void DeleteCampaigns (string campaignHash)
        {
             DeleteCampaignsWithHttpInfo(campaignHash);
        }

        /// <summary>
        /// Remove Campaign Remove campaign information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCampaignsWithHttpInfo (string campaignHash)
        {
            // verify the required parameter 'campaignHash' is set
            if (campaignHash == null)
                throw new ApiException(400, "Missing required parameter 'campaignHash' when calling CampaignsApi->DeleteCampaigns");

            var localVarPath = "/campaigns/{campaign_hash}";
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

            if (campaignHash != null) localVarPathParams.Add("campaign_hash", this.Configuration.ApiClient.ParameterToString(campaignHash)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteCampaigns", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove Campaign Remove campaign information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCampaignsAsync (string campaignHash, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteCampaignsWithHttpInfoAsync(campaignHash, cancellationToken);

        }

        /// <summary>
        /// Remove Campaign Remove campaign information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCampaignsWithHttpInfoAsync (string campaignHash, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'campaignHash' is set
            if (campaignHash == null)
                throw new ApiException(400, "Missing required parameter 'campaignHash' when calling CampaignsApi->DeleteCampaigns");

            var localVarPath = "/campaigns/{campaign_hash}";
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

            if (campaignHash != null) localVarPathParams.Add("campaign_hash", this.Configuration.ApiClient.ParameterToString(campaignHash)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteCampaigns", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get all Campaigns Returns all campaigns
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <returns>CampaignsCollection</returns>
        public CampaignsCollection GetAllCampaigns (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string))
        {
             ApiResponse<CampaignsCollection> localVarResponse = GetAllCampaignsWithHttpInfo(channel, campaignHash, listId, status, internalName, createdBy, groupId, createdMin, createdMax, updatedMin, updatedMax, startDateMin, startDateMax, endDateMin, endDateMax, scheduleDateMin, scheduleDateMax, offset, limit, order, orderBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Campaigns Returns all campaigns
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <returns>ApiResponse of CampaignsCollection</returns>
        public ApiResponse<CampaignsCollection> GetAllCampaignsWithHttpInfo (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string))
        {

            var localVarPath = "/campaigns";
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

            if (channel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channel", channel)); // query parameter
            if (campaignHash != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "campaign_hash", campaignHash)); // query parameter
            if (listId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "list_id", listId)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (internalName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "internal_name", internalName)); // query parameter
            if (createdBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_by", createdBy)); // query parameter
            if (groupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "group_id", groupId)); // query parameter
            if (createdMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_min", createdMin)); // query parameter
            if (createdMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_max", createdMax)); // query parameter
            if (updatedMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_min", updatedMin)); // query parameter
            if (updatedMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_max", updatedMax)); // query parameter
            if (startDateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date_min", startDateMin)); // query parameter
            if (startDateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date_max", startDateMax)); // query parameter
            if (endDateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_min", endDateMin)); // query parameter
            if (endDateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_max", endDateMax)); // query parameter
            if (scheduleDateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "schedule_date_min", scheduleDateMin)); // query parameter
            if (scheduleDateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "schedule_date_max", scheduleDateMax)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_by", orderBy)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllCampaigns", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CampaignsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CampaignsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignsCollection)));
        }

        /// <summary>
        /// Get all Campaigns Returns all campaigns
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CampaignsCollection</returns>
        public async System.Threading.Tasks.Task<CampaignsCollection> GetAllCampaignsAsync (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CampaignsCollection> localVarResponse = await GetAllCampaignsWithHttpInfoAsync(channel, campaignHash, listId, status, internalName, createdBy, groupId, createdMin, createdMax, updatedMin, updatedMax, startDateMin, startDateMax, endDateMin, endDateMax, scheduleDateMin, scheduleDateMax, offset, limit, order, orderBy, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Campaigns Returns all campaigns
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channel">Channel of the campaign (optional)</param>
        /// <param name="campaignHash">Hash of the campaign (optional)</param>
        /// <param name="listId">ID of the list where the campaign belongs (optional)</param>
        /// <param name="status">Status of the campaign (optional)</param>
        /// <param name="internalName">Internal name of the campaign (optional)</param>
        /// <param name="createdBy">ID of the user who created the campaign (optional)</param>
        /// <param name="groupId">ID of the group where the campaign belongs (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="updatedMin">Updated initial (optional)</param>
        /// <param name="updatedMax">Updated finish (optional)</param>
        /// <param name="startDateMin">Start date initial (optional)</param>
        /// <param name="startDateMax">Start date finish (optional)</param>
        /// <param name="endDateMin">End Date initial (optional)</param>
        /// <param name="endDateMax">End Date finish (optional)</param>
        /// <param name="scheduleDateMin">Schedule Date initial (optional)</param>
        /// <param name="scheduleDateMax">Schedule Date finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 100)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order campaigns (optional, default to created)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CampaignsCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CampaignsCollection>> GetAllCampaignsWithHttpInfoAsync (string channel = default(string), string campaignHash = default(string), int? listId = default(int?), string status = default(string), string internalName = default(string), int? createdBy = default(int?), int? groupId = default(int?), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), DateTime? updatedMin = default(DateTime?), DateTime? updatedMax = default(DateTime?), DateTime? startDateMin = default(DateTime?), DateTime? startDateMax = default(DateTime?), DateTime? endDateMin = default(DateTime?), DateTime? endDateMax = default(DateTime?), DateTime? scheduleDateMin = default(DateTime?), DateTime? scheduleDateMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/campaigns";
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

            if (channel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channel", channel)); // query parameter
            if (campaignHash != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "campaign_hash", campaignHash)); // query parameter
            if (listId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "list_id", listId)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (internalName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "internal_name", internalName)); // query parameter
            if (createdBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_by", createdBy)); // query parameter
            if (groupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "group_id", groupId)); // query parameter
            if (createdMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_min", createdMin)); // query parameter
            if (createdMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_max", createdMax)); // query parameter
            if (updatedMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_min", updatedMin)); // query parameter
            if (updatedMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "updated_max", updatedMax)); // query parameter
            if (startDateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date_min", startDateMin)); // query parameter
            if (startDateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date_max", startDateMax)); // query parameter
            if (endDateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_min", endDateMin)); // query parameter
            if (endDateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date_max", endDateMax)); // query parameter
            if (scheduleDateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "schedule_date_min", scheduleDateMin)); // query parameter
            if (scheduleDateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "schedule_date_max", scheduleDateMax)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (order != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order", order)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "order_by", orderBy)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllCampaigns", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CampaignsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CampaignsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CampaignsCollection)));
        }

    }
}
