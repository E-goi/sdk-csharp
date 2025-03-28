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
    public interface IPushApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send push message
        /// </summary>
        /// <remarks>
        /// Deploys and sends a push message
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionSendPush (string campaignHash, CampaignPushSendRequest campaignPushSendRequest);

        /// <summary>
        /// Send push message
        /// </summary>
        /// <remarks>
        /// Deploys and sends a push message
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionSendPushWithHttpInfo (string campaignHash, CampaignPushSendRequest campaignPushSendRequest);
        /// <summary>
        /// Create new push campaign
        /// </summary>
        /// <remarks>
        /// Create a new push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <returns>HashcodeCampaign</returns>
        HashcodeCampaign CreatePushCampaign (PushCampaignPostRequest pushCampaignPostRequest);

        /// <summary>
        /// Create new push campaign
        /// </summary>
        /// <remarks>
        /// Create a new push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <returns>ApiResponse of HashcodeCampaign</returns>
        ApiResponse<HashcodeCampaign> CreatePushCampaignWithHttpInfo (PushCampaignPostRequest pushCampaignPostRequest);
        /// <summary>
        /// Get a Push application from E-goi
        /// </summary>
        /// <remarks>
        /// Get a Push application from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <returns>AppStructure</returns>
        AppStructure GetPushApp (string appId);

        /// <summary>
        /// Get a Push application from E-goi
        /// </summary>
        /// <remarks>
        /// Get a Push application from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <returns>ApiResponse of AppStructure</returns>
        ApiResponse<AppStructure> GetPushAppWithHttpInfo (string appId);
        /// <summary>
        /// Get all Push applications from E-goi
        /// </summary>
        /// <remarks>
        /// Get all Push applications from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <returns>List&lt;AppStructure&gt;</returns>
        List<AppStructure> GetPushApps (int? listId = default(int?));

        /// <summary>
        /// Get all Push applications from E-goi
        /// </summary>
        /// <remarks>
        /// Get all Push applications from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <returns>ApiResponse of List&lt;AppStructure&gt;</returns>
        ApiResponse<List<AppStructure>> GetPushAppsWithHttpInfo (int? listId = default(int?));
        /// <summary>
        /// Update a specific push campaign
        /// </summary>
        /// <remarks>
        /// Update push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <returns>HashcodeCampaign</returns>
        HashcodeCampaign PatchPushCampaign (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest);

        /// <summary>
        /// Update a specific push campaign
        /// </summary>
        /// <remarks>
        /// Update push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <returns>ApiResponse of HashcodeCampaign</returns>
        ApiResponse<HashcodeCampaign> PatchPushCampaignWithHttpInfo (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest);
        /// <summary>
        /// Registers an event from the push notification.
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <returns>PushResponse</returns>
        PushResponse RegisterPushEvent (string appId, PushEvent pushEvent);

        /// <summary>
        /// Registers an event from the push notification.
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <returns>ApiResponse of PushResponse</returns>
        ApiResponse<PushResponse> RegisterPushEventWithHttpInfo (string appId, PushEvent pushEvent);
        /// <summary>
        /// Registers a Firebase token
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <returns>PushResponse</returns>
        PushResponse RegisterPushToken (string appId, PushToken pushToken);

        /// <summary>
        /// Registers a Firebase token
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <returns>ApiResponse of PushResponse</returns>
        ApiResponse<PushResponse> RegisterPushTokenWithHttpInfo (string appId, PushToken pushToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send push message
        /// </summary>
        /// <remarks>
        /// Deploys and sends a push message
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionSendPushAsync (string campaignHash, CampaignPushSendRequest campaignPushSendRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Send push message
        /// </summary>
        /// <remarks>
        /// Deploys and sends a push message
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionSendPushWithHttpInfoAsync (string campaignHash, CampaignPushSendRequest campaignPushSendRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create new push campaign
        /// </summary>
        /// <remarks>
        /// Create a new push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of HashcodeCampaign</returns>
        System.Threading.Tasks.Task<HashcodeCampaign> CreatePushCampaignAsync (PushCampaignPostRequest pushCampaignPostRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new push campaign
        /// </summary>
        /// <remarks>
        /// Create a new push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (HashcodeCampaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<HashcodeCampaign>> CreatePushCampaignWithHttpInfoAsync (PushCampaignPostRequest pushCampaignPostRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a Push application from E-goi
        /// </summary>
        /// <remarks>
        /// Get a Push application from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AppStructure</returns>
        System.Threading.Tasks.Task<AppStructure> GetPushAppAsync (string appId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get a Push application from E-goi
        /// </summary>
        /// <remarks>
        /// Get a Push application from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AppStructure)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppStructure>> GetPushAppWithHttpInfoAsync (string appId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all Push applications from E-goi
        /// </summary>
        /// <remarks>
        /// Get all Push applications from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;AppStructure&gt;</returns>
        System.Threading.Tasks.Task<List<AppStructure>> GetPushAppsAsync (int? listId = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all Push applications from E-goi
        /// </summary>
        /// <remarks>
        /// Get all Push applications from E-goi
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;AppStructure&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AppStructure>>> GetPushAppsWithHttpInfoAsync (int? listId = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a specific push campaign
        /// </summary>
        /// <remarks>
        /// Update push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of HashcodeCampaign</returns>
        System.Threading.Tasks.Task<HashcodeCampaign> PatchPushCampaignAsync (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update a specific push campaign
        /// </summary>
        /// <remarks>
        /// Update push campaign
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (HashcodeCampaign)</returns>
        System.Threading.Tasks.Task<ApiResponse<HashcodeCampaign>> PatchPushCampaignWithHttpInfoAsync (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Registers an event from the push notification.
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PushResponse</returns>
        System.Threading.Tasks.Task<PushResponse> RegisterPushEventAsync (string appId, PushEvent pushEvent, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Registers an event from the push notification.
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PushResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PushResponse>> RegisterPushEventWithHttpInfoAsync (string appId, PushEvent pushEvent, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Registers a Firebase token
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PushResponse</returns>
        System.Threading.Tasks.Task<PushResponse> RegisterPushTokenAsync (string appId, PushToken pushToken, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Registers a Firebase token
        /// </summary>
        /// <remarks>
        /// Registers a Firebase token
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PushResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PushResponse>> RegisterPushTokenWithHttpInfoAsync (string appId, PushToken pushToken, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PushApi : IPushApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PushApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PushApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushApi"/> class
        /// </summary>
        /// <returns></returns>
        public PushApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PushApi(org.egoi.client.api.Client.Configuration configuration = null)
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
        /// Send push message Deploys and sends a push message
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionSendPush (string campaignHash, CampaignPushSendRequest campaignPushSendRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionSendPushWithHttpInfo(campaignHash, campaignPushSendRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send push message Deploys and sends a push message
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionSendPushWithHttpInfo (string campaignHash, CampaignPushSendRequest campaignPushSendRequest)
        {
            // verify the required parameter 'campaignHash' is set
            if (campaignHash == null)
                throw new ApiException(400, "Missing required parameter 'campaignHash' when calling PushApi->ActionSendPush");
            // verify the required parameter 'campaignPushSendRequest' is set
            if (campaignPushSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'campaignPushSendRequest' when calling PushApi->ActionSendPush");

            var localVarPath = "/campaigns/push/{campaign_hash}/actions/send";
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

            if (campaignHash != null) localVarPathParams.Add("campaign_hash", this.Configuration.ApiClient.ParameterToString(campaignHash)); // path parameter
            if (campaignPushSendRequest != null && campaignPushSendRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(campaignPushSendRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = campaignPushSendRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionSendPush", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Send push message Deploys and sends a push message
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionSendPushAsync (string campaignHash, CampaignPushSendRequest campaignPushSendRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionSendPushWithHttpInfoAsync(campaignHash, campaignPushSendRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send push message Deploys and sends a push message
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="campaignPushSendRequest">Parameters for the &#39;send push&#39; action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionSendPushWithHttpInfoAsync (string campaignHash, CampaignPushSendRequest campaignPushSendRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'campaignHash' is set
            if (campaignHash == null)
                throw new ApiException(400, "Missing required parameter 'campaignHash' when calling PushApi->ActionSendPush");
            // verify the required parameter 'campaignPushSendRequest' is set
            if (campaignPushSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'campaignPushSendRequest' when calling PushApi->ActionSendPush");

            var localVarPath = "/campaigns/push/{campaign_hash}/actions/send";
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

            if (campaignHash != null) localVarPathParams.Add("campaign_hash", this.Configuration.ApiClient.ParameterToString(campaignHash)); // path parameter
            if (campaignPushSendRequest != null && campaignPushSendRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(campaignPushSendRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = campaignPushSendRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionSendPush", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Create new push campaign Create a new push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <returns>HashcodeCampaign</returns>
        public HashcodeCampaign CreatePushCampaign (PushCampaignPostRequest pushCampaignPostRequest)
        {
             ApiResponse<HashcodeCampaign> localVarResponse = CreatePushCampaignWithHttpInfo(pushCampaignPostRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new push campaign Create a new push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <returns>ApiResponse of HashcodeCampaign</returns>
        public ApiResponse<HashcodeCampaign> CreatePushCampaignWithHttpInfo (PushCampaignPostRequest pushCampaignPostRequest)
        {
            // verify the required parameter 'pushCampaignPostRequest' is set
            if (pushCampaignPostRequest == null)
                throw new ApiException(400, "Missing required parameter 'pushCampaignPostRequest' when calling PushApi->CreatePushCampaign");

            var localVarPath = "/campaigns/push";
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

            if (pushCampaignPostRequest != null && pushCampaignPostRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushCampaignPostRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushCampaignPostRequest; // byte array
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
                Exception exception = ExceptionFactory("CreatePushCampaign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HashcodeCampaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (HashcodeCampaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HashcodeCampaign)));
        }

        /// <summary>
        /// Create new push campaign Create a new push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of HashcodeCampaign</returns>
        public async System.Threading.Tasks.Task<HashcodeCampaign> CreatePushCampaignAsync (PushCampaignPostRequest pushCampaignPostRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<HashcodeCampaign> localVarResponse = await CreatePushCampaignWithHttpInfoAsync(pushCampaignPostRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new push campaign Create a new push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pushCampaignPostRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (HashcodeCampaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HashcodeCampaign>> CreatePushCampaignWithHttpInfoAsync (PushCampaignPostRequest pushCampaignPostRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'pushCampaignPostRequest' is set
            if (pushCampaignPostRequest == null)
                throw new ApiException(400, "Missing required parameter 'pushCampaignPostRequest' when calling PushApi->CreatePushCampaign");

            var localVarPath = "/campaigns/push";
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

            if (pushCampaignPostRequest != null && pushCampaignPostRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushCampaignPostRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushCampaignPostRequest; // byte array
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
                Exception exception = ExceptionFactory("CreatePushCampaign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HashcodeCampaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (HashcodeCampaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HashcodeCampaign)));
        }

        /// <summary>
        /// Get a Push application from E-goi Get a Push application from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <returns>AppStructure</returns>
        public AppStructure GetPushApp (string appId)
        {
             ApiResponse<AppStructure> localVarResponse = GetPushAppWithHttpInfo(appId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Push application from E-goi Get a Push application from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <returns>ApiResponse of AppStructure</returns>
        public ApiResponse<AppStructure> GetPushAppWithHttpInfo (string appId)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling PushApi->GetPushApp");

            var localVarPath = "/push/apps/{app_id}";
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

            if (appId != null) localVarPathParams.Add("app_id", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter

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
                Exception exception = ExceptionFactory("GetPushApp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppStructure>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AppStructure) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppStructure)));
        }

        /// <summary>
        /// Get a Push application from E-goi Get a Push application from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AppStructure</returns>
        public async System.Threading.Tasks.Task<AppStructure> GetPushAppAsync (string appId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AppStructure> localVarResponse = await GetPushAppWithHttpInfoAsync(appId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Push application from E-goi Get a Push application from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AppStructure)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AppStructure>> GetPushAppWithHttpInfoAsync (string appId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling PushApi->GetPushApp");

            var localVarPath = "/push/apps/{app_id}";
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

            if (appId != null) localVarPathParams.Add("app_id", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter

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
                Exception exception = ExceptionFactory("GetPushApp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppStructure>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AppStructure) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppStructure)));
        }

        /// <summary>
        /// Get all Push applications from E-goi Get all Push applications from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <returns>List&lt;AppStructure&gt;</returns>
        public List<AppStructure> GetPushApps (int? listId = default(int?))
        {
             ApiResponse<List<AppStructure>> localVarResponse = GetPushAppsWithHttpInfo(listId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Push applications from E-goi Get all Push applications from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <returns>ApiResponse of List&lt;AppStructure&gt;</returns>
        public ApiResponse<List<AppStructure>> GetPushAppsWithHttpInfo (int? listId = default(int?))
        {

            var localVarPath = "/push/apps";
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

            if (listId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "list_id", listId)); // query parameter

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
                Exception exception = ExceptionFactory("GetPushApps", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AppStructure>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<AppStructure>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AppStructure>)));
        }

        /// <summary>
        /// Get all Push applications from E-goi Get all Push applications from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;AppStructure&gt;</returns>
        public async System.Threading.Tasks.Task<List<AppStructure>> GetPushAppsAsync (int? listId = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<AppStructure>> localVarResponse = await GetPushAppsWithHttpInfoAsync(listId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Push applications from E-goi Get all Push applications from E-goi
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list to search for. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;AppStructure&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AppStructure>>> GetPushAppsWithHttpInfoAsync (int? listId = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/push/apps";
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

            if (listId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "list_id", listId)); // query parameter

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
                Exception exception = ExceptionFactory("GetPushApps", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<AppStructure>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<AppStructure>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<AppStructure>)));
        }

        /// <summary>
        /// Update a specific push campaign Update push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <returns>HashcodeCampaign</returns>
        public HashcodeCampaign PatchPushCampaign (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest)
        {
             ApiResponse<HashcodeCampaign> localVarResponse = PatchPushCampaignWithHttpInfo(campaignHash, pushCampaignPatchRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a specific push campaign Update push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <returns>ApiResponse of HashcodeCampaign</returns>
        public ApiResponse<HashcodeCampaign> PatchPushCampaignWithHttpInfo (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest)
        {
            // verify the required parameter 'campaignHash' is set
            if (campaignHash == null)
                throw new ApiException(400, "Missing required parameter 'campaignHash' when calling PushApi->PatchPushCampaign");
            // verify the required parameter 'pushCampaignPatchRequest' is set
            if (pushCampaignPatchRequest == null)
                throw new ApiException(400, "Missing required parameter 'pushCampaignPatchRequest' when calling PushApi->PatchPushCampaign");

            var localVarPath = "/campaigns/push/{campaign_hash}";
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

            if (campaignHash != null) localVarPathParams.Add("campaign_hash", this.Configuration.ApiClient.ParameterToString(campaignHash)); // path parameter
            if (pushCampaignPatchRequest != null && pushCampaignPatchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushCampaignPatchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushCampaignPatchRequest; // byte array
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
                Exception exception = ExceptionFactory("PatchPushCampaign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HashcodeCampaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (HashcodeCampaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HashcodeCampaign)));
        }

        /// <summary>
        /// Update a specific push campaign Update push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of HashcodeCampaign</returns>
        public async System.Threading.Tasks.Task<HashcodeCampaign> PatchPushCampaignAsync (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<HashcodeCampaign> localVarResponse = await PatchPushCampaignWithHttpInfoAsync(campaignHash, pushCampaignPatchRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a specific push campaign Update push campaign
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="campaignHash">Hash of the Campaign</param>
        /// <param name="pushCampaignPatchRequest">Parameters for the push campaign</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (HashcodeCampaign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HashcodeCampaign>> PatchPushCampaignWithHttpInfoAsync (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'campaignHash' is set
            if (campaignHash == null)
                throw new ApiException(400, "Missing required parameter 'campaignHash' when calling PushApi->PatchPushCampaign");
            // verify the required parameter 'pushCampaignPatchRequest' is set
            if (pushCampaignPatchRequest == null)
                throw new ApiException(400, "Missing required parameter 'pushCampaignPatchRequest' when calling PushApi->PatchPushCampaign");

            var localVarPath = "/campaigns/push/{campaign_hash}";
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

            if (campaignHash != null) localVarPathParams.Add("campaign_hash", this.Configuration.ApiClient.ParameterToString(campaignHash)); // path parameter
            if (pushCampaignPatchRequest != null && pushCampaignPatchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushCampaignPatchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushCampaignPatchRequest; // byte array
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
                Exception exception = ExceptionFactory("PatchPushCampaign", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HashcodeCampaign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (HashcodeCampaign) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(HashcodeCampaign)));
        }

        /// <summary>
        /// Registers an event from the push notification. Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <returns>PushResponse</returns>
        public PushResponse RegisterPushEvent (string appId, PushEvent pushEvent)
        {
             ApiResponse<PushResponse> localVarResponse = RegisterPushEventWithHttpInfo(appId, pushEvent);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registers an event from the push notification. Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <returns>ApiResponse of PushResponse</returns>
        public ApiResponse<PushResponse> RegisterPushEventWithHttpInfo (string appId, PushEvent pushEvent)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling PushApi->RegisterPushEvent");
            // verify the required parameter 'pushEvent' is set
            if (pushEvent == null)
                throw new ApiException(400, "Missing required parameter 'pushEvent' when calling PushApi->RegisterPushEvent");

            var localVarPath = "/push/apps/{app_id}/event";
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

            if (appId != null) localVarPathParams.Add("app_id", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (pushEvent != null && pushEvent.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushEvent); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushEvent; // byte array
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
                Exception exception = ExceptionFactory("RegisterPushEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PushResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PushResponse)));
        }

        /// <summary>
        /// Registers an event from the push notification. Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PushResponse</returns>
        public async System.Threading.Tasks.Task<PushResponse> RegisterPushEventAsync (string appId, PushEvent pushEvent, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PushResponse> localVarResponse = await RegisterPushEventWithHttpInfoAsync(appId, pushEvent, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registers an event from the push notification. Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushEvent">Parameters for the event</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PushResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PushResponse>> RegisterPushEventWithHttpInfoAsync (string appId, PushEvent pushEvent, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling PushApi->RegisterPushEvent");
            // verify the required parameter 'pushEvent' is set
            if (pushEvent == null)
                throw new ApiException(400, "Missing required parameter 'pushEvent' when calling PushApi->RegisterPushEvent");

            var localVarPath = "/push/apps/{app_id}/event";
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

            if (appId != null) localVarPathParams.Add("app_id", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (pushEvent != null && pushEvent.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushEvent); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushEvent; // byte array
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
                Exception exception = ExceptionFactory("RegisterPushEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PushResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PushResponse)));
        }

        /// <summary>
        /// Registers a Firebase token Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <returns>PushResponse</returns>
        public PushResponse RegisterPushToken (string appId, PushToken pushToken)
        {
             ApiResponse<PushResponse> localVarResponse = RegisterPushTokenWithHttpInfo(appId, pushToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Registers a Firebase token Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <returns>ApiResponse of PushResponse</returns>
        public ApiResponse<PushResponse> RegisterPushTokenWithHttpInfo (string appId, PushToken pushToken)
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling PushApi->RegisterPushToken");
            // verify the required parameter 'pushToken' is set
            if (pushToken == null)
                throw new ApiException(400, "Missing required parameter 'pushToken' when calling PushApi->RegisterPushToken");

            var localVarPath = "/push/apps/{app_id}/token";
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

            if (appId != null) localVarPathParams.Add("app_id", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (pushToken != null && pushToken.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushToken); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushToken; // byte array
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
                Exception exception = ExceptionFactory("RegisterPushToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PushResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PushResponse)));
        }

        /// <summary>
        /// Registers a Firebase token Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PushResponse</returns>
        public async System.Threading.Tasks.Task<PushResponse> RegisterPushTokenAsync (string appId, PushToken pushToken, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PushResponse> localVarResponse = await RegisterPushTokenWithHttpInfoAsync(appId, pushToken, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Registers a Firebase token Registers a Firebase token
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">ID of the E-goi push app.</param>
        /// <param name="pushToken">Parameters for the token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PushResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PushResponse>> RegisterPushTokenWithHttpInfoAsync (string appId, PushToken pushToken, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'appId' is set
            if (appId == null)
                throw new ApiException(400, "Missing required parameter 'appId' when calling PushApi->RegisterPushToken");
            // verify the required parameter 'pushToken' is set
            if (pushToken == null)
                throw new ApiException(400, "Missing required parameter 'pushToken' when calling PushApi->RegisterPushToken");

            var localVarPath = "/push/apps/{app_id}/token";
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

            if (appId != null) localVarPathParams.Add("app_id", this.Configuration.ApiClient.ParameterToString(appId)); // path parameter
            if (pushToken != null && pushToken.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(pushToken); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pushToken; // byte array
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
                Exception exception = ExceptionFactory("RegisterPushToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PushResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PushResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PushResponse)));
        }

    }
}
