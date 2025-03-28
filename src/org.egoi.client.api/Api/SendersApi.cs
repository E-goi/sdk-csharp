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
    public interface ISendersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create cellphone sender
        /// </summary>
        /// <remarks>
        /// Creates a cellphone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <returns>CellphoneSender</returns>
        CellphoneSender CreateCellphoneSender (CellphoneSenderPost cellphoneSenderPost);

        /// <summary>
        /// Create cellphone sender
        /// </summary>
        /// <remarks>
        /// Creates a cellphone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <returns>ApiResponse of CellphoneSender</returns>
        ApiResponse<CellphoneSender> CreateCellphoneSenderWithHttpInfo (CellphoneSenderPost cellphoneSenderPost);
        /// <summary>
        /// Create email sender
        /// </summary>
        /// <remarks>
        /// Creates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <returns>EmailSender</returns>
        EmailSender CreateEmailSender (EmailSenderPost emailSenderPost);

        /// <summary>
        /// Create email sender
        /// </summary>
        /// <remarks>
        /// Creates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <returns>ApiResponse of EmailSender</returns>
        ApiResponse<EmailSender> CreateEmailSenderWithHttpInfo (EmailSenderPost emailSenderPost);
        /// <summary>
        /// Create phone sender
        /// </summary>
        /// <remarks>
        /// Creates a phone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <returns>PhoneSender</returns>
        PhoneSender CreatePhoneSender (PhoneSenderPost phoneSenderPost);

        /// <summary>
        /// Create phone sender
        /// </summary>
        /// <remarks>
        /// Creates a phone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <returns>ApiResponse of PhoneSender</returns>
        ApiResponse<PhoneSender> CreatePhoneSenderWithHttpInfo (PhoneSenderPost phoneSenderPost);
        /// <summary>
        /// Remove cellphone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns></returns>
        void DeleteCellphoneSender (int senderId);

        /// <summary>
        /// Remove cellphone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCellphoneSenderWithHttpInfo (int senderId);
        /// <summary>
        /// Remove email sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns></returns>
        void DeleteEmailSender (int senderId);

        /// <summary>
        /// Remove email sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEmailSenderWithHttpInfo (int senderId);
        /// <summary>
        /// Remove phone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns></returns>
        void DeletePhoneSender (int senderId);

        /// <summary>
        /// Remove phone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePhoneSenderWithHttpInfo (int senderId);
        /// <summary>
        /// Get all cellphone senders
        /// </summary>
        /// <remarks>
        /// Returns all cellphone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>CellphoneSenderCollection</returns>
        CellphoneSenderCollection GetAllCellphoneSenders (int? offset = default(int?), int? limit = default(int?), string status = default(string));

        /// <summary>
        /// Get all cellphone senders
        /// </summary>
        /// <remarks>
        /// Returns all cellphone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>ApiResponse of CellphoneSenderCollection</returns>
        ApiResponse<CellphoneSenderCollection> GetAllCellphoneSendersWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string status = default(string));
        /// <summary>
        /// Get all email senders
        /// </summary>
        /// <remarks>
        /// Returns all email senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>EmailSenderCollection</returns>
        EmailSenderCollection GetAllEmailSenders (int? offset = default(int?), int? limit = default(int?), string status = default(string));

        /// <summary>
        /// Get all email senders
        /// </summary>
        /// <remarks>
        /// Returns all email senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>ApiResponse of EmailSenderCollection</returns>
        ApiResponse<EmailSenderCollection> GetAllEmailSendersWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string status = default(string));
        /// <summary>
        /// Get all phone senders
        /// </summary>
        /// <remarks>
        /// Returns all phone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>PhoneSenderCollection</returns>
        PhoneSenderCollection GetAllPhoneSenders (int? offset = default(int?), int? limit = default(int?), string status = default(string));

        /// <summary>
        /// Get all phone senders
        /// </summary>
        /// <remarks>
        /// Returns all phone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>ApiResponse of PhoneSenderCollection</returns>
        ApiResponse<PhoneSenderCollection> GetAllPhoneSendersWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string status = default(string));
        /// <summary>
        /// Update email sender
        /// </summary>
        /// <remarks>
        /// Updates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <returns>EmailSender</returns>
        EmailSender PutEmailSender (int senderId, EmailSenderPutRequest emailSenderPutRequest);

        /// <summary>
        /// Update email sender
        /// </summary>
        /// <remarks>
        /// Updates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <returns>ApiResponse of EmailSender</returns>
        ApiResponse<EmailSender> PutEmailSenderWithHttpInfo (int senderId, EmailSenderPutRequest emailSenderPutRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create cellphone sender
        /// </summary>
        /// <remarks>
        /// Creates a cellphone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CellphoneSender</returns>
        System.Threading.Tasks.Task<CellphoneSender> CreateCellphoneSenderAsync (CellphoneSenderPost cellphoneSenderPost, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create cellphone sender
        /// </summary>
        /// <remarks>
        /// Creates a cellphone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CellphoneSender)</returns>
        System.Threading.Tasks.Task<ApiResponse<CellphoneSender>> CreateCellphoneSenderWithHttpInfoAsync (CellphoneSenderPost cellphoneSenderPost, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create email sender
        /// </summary>
        /// <remarks>
        /// Creates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of EmailSender</returns>
        System.Threading.Tasks.Task<EmailSender> CreateEmailSenderAsync (EmailSenderPost emailSenderPost, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create email sender
        /// </summary>
        /// <remarks>
        /// Creates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (EmailSender)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSender>> CreateEmailSenderWithHttpInfoAsync (EmailSenderPost emailSenderPost, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create phone sender
        /// </summary>
        /// <remarks>
        /// Creates a phone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PhoneSender</returns>
        System.Threading.Tasks.Task<PhoneSender> CreatePhoneSenderAsync (PhoneSenderPost phoneSenderPost, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create phone sender
        /// </summary>
        /// <remarks>
        /// Creates a phone sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PhoneSender)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneSender>> CreatePhoneSenderWithHttpInfoAsync (PhoneSenderPost phoneSenderPost, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove cellphone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCellphoneSenderAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove cellphone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCellphoneSenderWithHttpInfoAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove email sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEmailSenderAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove email sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmailSenderWithHttpInfoAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove phone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePhoneSenderAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove phone sender
        /// </summary>
        /// <remarks>
        /// Remove sender information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePhoneSenderWithHttpInfoAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all cellphone senders
        /// </summary>
        /// <remarks>
        /// Returns all cellphone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CellphoneSenderCollection</returns>
        System.Threading.Tasks.Task<CellphoneSenderCollection> GetAllCellphoneSendersAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all cellphone senders
        /// </summary>
        /// <remarks>
        /// Returns all cellphone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CellphoneSenderCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<CellphoneSenderCollection>> GetAllCellphoneSendersWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all email senders
        /// </summary>
        /// <remarks>
        /// Returns all email senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of EmailSenderCollection</returns>
        System.Threading.Tasks.Task<EmailSenderCollection> GetAllEmailSendersAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all email senders
        /// </summary>
        /// <remarks>
        /// Returns all email senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (EmailSenderCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSenderCollection>> GetAllEmailSendersWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all phone senders
        /// </summary>
        /// <remarks>
        /// Returns all phone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PhoneSenderCollection</returns>
        System.Threading.Tasks.Task<PhoneSenderCollection> GetAllPhoneSendersAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all phone senders
        /// </summary>
        /// <remarks>
        /// Returns all phone senders
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PhoneSenderCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneSenderCollection>> GetAllPhoneSendersWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update email sender
        /// </summary>
        /// <remarks>
        /// Updates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of EmailSender</returns>
        System.Threading.Tasks.Task<EmailSender> PutEmailSenderAsync (int senderId, EmailSenderPutRequest emailSenderPutRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update email sender
        /// </summary>
        /// <remarks>
        /// Updates an email sender
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (EmailSender)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSender>> PutEmailSenderWithHttpInfoAsync (int senderId, EmailSenderPutRequest emailSenderPutRequest, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SendersApi : ISendersApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SendersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SendersApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendersApi"/> class
        /// </summary>
        /// <returns></returns>
        public SendersApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SendersApi(org.egoi.client.api.Client.Configuration configuration = null)
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
        /// Create cellphone sender Creates a cellphone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <returns>CellphoneSender</returns>
        public CellphoneSender CreateCellphoneSender (CellphoneSenderPost cellphoneSenderPost)
        {
             ApiResponse<CellphoneSender> localVarResponse = CreateCellphoneSenderWithHttpInfo(cellphoneSenderPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create cellphone sender Creates a cellphone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <returns>ApiResponse of CellphoneSender</returns>
        public ApiResponse<CellphoneSender> CreateCellphoneSenderWithHttpInfo (CellphoneSenderPost cellphoneSenderPost)
        {
            // verify the required parameter 'cellphoneSenderPost' is set
            if (cellphoneSenderPost == null)
                throw new ApiException(400, "Missing required parameter 'cellphoneSenderPost' when calling SendersApi->CreateCellphoneSender");

            var localVarPath = "/senders/cellphone";
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

            if (cellphoneSenderPost != null && cellphoneSenderPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cellphoneSenderPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cellphoneSenderPost; // byte array
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
                Exception exception = ExceptionFactory("CreateCellphoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CellphoneSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CellphoneSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CellphoneSender)));
        }

        /// <summary>
        /// Create cellphone sender Creates a cellphone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CellphoneSender</returns>
        public async System.Threading.Tasks.Task<CellphoneSender> CreateCellphoneSenderAsync (CellphoneSenderPost cellphoneSenderPost, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CellphoneSender> localVarResponse = await CreateCellphoneSenderWithHttpInfoAsync(cellphoneSenderPost, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create cellphone sender Creates a cellphone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cellphoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CellphoneSender)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CellphoneSender>> CreateCellphoneSenderWithHttpInfoAsync (CellphoneSenderPost cellphoneSenderPost, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'cellphoneSenderPost' is set
            if (cellphoneSenderPost == null)
                throw new ApiException(400, "Missing required parameter 'cellphoneSenderPost' when calling SendersApi->CreateCellphoneSender");

            var localVarPath = "/senders/cellphone";
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

            if (cellphoneSenderPost != null && cellphoneSenderPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cellphoneSenderPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cellphoneSenderPost; // byte array
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
                Exception exception = ExceptionFactory("CreateCellphoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CellphoneSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CellphoneSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CellphoneSender)));
        }

        /// <summary>
        /// Create email sender Creates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <returns>EmailSender</returns>
        public EmailSender CreateEmailSender (EmailSenderPost emailSenderPost)
        {
             ApiResponse<EmailSender> localVarResponse = CreateEmailSenderWithHttpInfo(emailSenderPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create email sender Creates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <returns>ApiResponse of EmailSender</returns>
        public ApiResponse<EmailSender> CreateEmailSenderWithHttpInfo (EmailSenderPost emailSenderPost)
        {
            // verify the required parameter 'emailSenderPost' is set
            if (emailSenderPost == null)
                throw new ApiException(400, "Missing required parameter 'emailSenderPost' when calling SendersApi->CreateEmailSender");

            var localVarPath = "/senders/email";
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

            if (emailSenderPost != null && emailSenderPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(emailSenderPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emailSenderPost; // byte array
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
                Exception exception = ExceptionFactory("CreateEmailSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSender)));
        }

        /// <summary>
        /// Create email sender Creates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of EmailSender</returns>
        public async System.Threading.Tasks.Task<EmailSender> CreateEmailSenderAsync (EmailSenderPost emailSenderPost, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<EmailSender> localVarResponse = await CreateEmailSenderWithHttpInfoAsync(emailSenderPost, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create email sender Creates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (EmailSender)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSender>> CreateEmailSenderWithHttpInfoAsync (EmailSenderPost emailSenderPost, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'emailSenderPost' is set
            if (emailSenderPost == null)
                throw new ApiException(400, "Missing required parameter 'emailSenderPost' when calling SendersApi->CreateEmailSender");

            var localVarPath = "/senders/email";
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

            if (emailSenderPost != null && emailSenderPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(emailSenderPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emailSenderPost; // byte array
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
                Exception exception = ExceptionFactory("CreateEmailSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSender)));
        }

        /// <summary>
        /// Create phone sender Creates a phone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <returns>PhoneSender</returns>
        public PhoneSender CreatePhoneSender (PhoneSenderPost phoneSenderPost)
        {
             ApiResponse<PhoneSender> localVarResponse = CreatePhoneSenderWithHttpInfo(phoneSenderPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create phone sender Creates a phone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <returns>ApiResponse of PhoneSender</returns>
        public ApiResponse<PhoneSender> CreatePhoneSenderWithHttpInfo (PhoneSenderPost phoneSenderPost)
        {
            // verify the required parameter 'phoneSenderPost' is set
            if (phoneSenderPost == null)
                throw new ApiException(400, "Missing required parameter 'phoneSenderPost' when calling SendersApi->CreatePhoneSender");

            var localVarPath = "/senders/phone";
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

            if (phoneSenderPost != null && phoneSenderPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(phoneSenderPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = phoneSenderPost; // byte array
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
                Exception exception = ExceptionFactory("CreatePhoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PhoneSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneSender)));
        }

        /// <summary>
        /// Create phone sender Creates a phone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PhoneSender</returns>
        public async System.Threading.Tasks.Task<PhoneSender> CreatePhoneSenderAsync (PhoneSenderPost phoneSenderPost, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PhoneSender> localVarResponse = await CreatePhoneSenderWithHttpInfoAsync(phoneSenderPost, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create phone sender Creates a phone sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneSenderPost">Parameters for the sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PhoneSender)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneSender>> CreatePhoneSenderWithHttpInfoAsync (PhoneSenderPost phoneSenderPost, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'phoneSenderPost' is set
            if (phoneSenderPost == null)
                throw new ApiException(400, "Missing required parameter 'phoneSenderPost' when calling SendersApi->CreatePhoneSender");

            var localVarPath = "/senders/phone";
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

            if (phoneSenderPost != null && phoneSenderPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(phoneSenderPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = phoneSenderPost; // byte array
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
                Exception exception = ExceptionFactory("CreatePhoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PhoneSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneSender)));
        }

        /// <summary>
        /// Remove cellphone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns></returns>
        public void DeleteCellphoneSender (int senderId)
        {
             DeleteCellphoneSenderWithHttpInfo(senderId);
        }

        /// <summary>
        /// Remove cellphone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCellphoneSenderWithHttpInfo (int senderId)
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->DeleteCellphoneSender");

            var localVarPath = "/senders/cellphone/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteCellphoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove cellphone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCellphoneSenderAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteCellphoneSenderWithHttpInfoAsync(senderId, cancellationToken);

        }

        /// <summary>
        /// Remove cellphone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCellphoneSenderWithHttpInfoAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->DeleteCellphoneSender");

            var localVarPath = "/senders/cellphone/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteCellphoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove email sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns></returns>
        public void DeleteEmailSender (int senderId)
        {
             DeleteEmailSenderWithHttpInfo(senderId);
        }

        /// <summary>
        /// Remove email sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEmailSenderWithHttpInfo (int senderId)
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->DeleteEmailSender");

            var localVarPath = "/senders/email/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteEmailSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove email sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteEmailSenderAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteEmailSenderWithHttpInfoAsync(senderId, cancellationToken);

        }

        /// <summary>
        /// Remove email sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmailSenderWithHttpInfoAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->DeleteEmailSender");

            var localVarPath = "/senders/email/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteEmailSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove phone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns></returns>
        public void DeletePhoneSender (int senderId)
        {
             DeletePhoneSenderWithHttpInfo(senderId);
        }

        /// <summary>
        /// Remove phone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePhoneSenderWithHttpInfo (int senderId)
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->DeletePhoneSender");

            var localVarPath = "/senders/phone/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter

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
                Exception exception = ExceptionFactory("DeletePhoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove phone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePhoneSenderAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeletePhoneSenderWithHttpInfoAsync(senderId, cancellationToken);

        }

        /// <summary>
        /// Remove phone sender Remove sender information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePhoneSenderWithHttpInfoAsync (int senderId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->DeletePhoneSender");

            var localVarPath = "/senders/phone/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter

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
                Exception exception = ExceptionFactory("DeletePhoneSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get all cellphone senders Returns all cellphone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>CellphoneSenderCollection</returns>
        public CellphoneSenderCollection GetAllCellphoneSenders (int? offset = default(int?), int? limit = default(int?), string status = default(string))
        {
             ApiResponse<CellphoneSenderCollection> localVarResponse = GetAllCellphoneSendersWithHttpInfo(offset, limit, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all cellphone senders Returns all cellphone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>ApiResponse of CellphoneSenderCollection</returns>
        public ApiResponse<CellphoneSenderCollection> GetAllCellphoneSendersWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string status = default(string))
        {

            var localVarPath = "/senders/cellphone";
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
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllCellphoneSenders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CellphoneSenderCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CellphoneSenderCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CellphoneSenderCollection)));
        }

        /// <summary>
        /// Get all cellphone senders Returns all cellphone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CellphoneSenderCollection</returns>
        public async System.Threading.Tasks.Task<CellphoneSenderCollection> GetAllCellphoneSendersAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CellphoneSenderCollection> localVarResponse = await GetAllCellphoneSendersWithHttpInfoAsync(offset, limit, status, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all cellphone senders Returns all cellphone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CellphoneSenderCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CellphoneSenderCollection>> GetAllCellphoneSendersWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/senders/cellphone";
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
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllCellphoneSenders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CellphoneSenderCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CellphoneSenderCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CellphoneSenderCollection)));
        }

        /// <summary>
        /// Get all email senders Returns all email senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>EmailSenderCollection</returns>
        public EmailSenderCollection GetAllEmailSenders (int? offset = default(int?), int? limit = default(int?), string status = default(string))
        {
             ApiResponse<EmailSenderCollection> localVarResponse = GetAllEmailSendersWithHttpInfo(offset, limit, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all email senders Returns all email senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>ApiResponse of EmailSenderCollection</returns>
        public ApiResponse<EmailSenderCollection> GetAllEmailSendersWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string status = default(string))
        {

            var localVarPath = "/senders/email";
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
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllEmailSenders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailSenderCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailSenderCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSenderCollection)));
        }

        /// <summary>
        /// Get all email senders Returns all email senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of EmailSenderCollection</returns>
        public async System.Threading.Tasks.Task<EmailSenderCollection> GetAllEmailSendersAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<EmailSenderCollection> localVarResponse = await GetAllEmailSendersWithHttpInfoAsync(offset, limit, status, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all email senders Returns all email senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (EmailSenderCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSenderCollection>> GetAllEmailSendersWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/senders/email";
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
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllEmailSenders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailSenderCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailSenderCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSenderCollection)));
        }

        /// <summary>
        /// Get all phone senders Returns all phone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>PhoneSenderCollection</returns>
        public PhoneSenderCollection GetAllPhoneSenders (int? offset = default(int?), int? limit = default(int?), string status = default(string))
        {
             ApiResponse<PhoneSenderCollection> localVarResponse = GetAllPhoneSendersWithHttpInfo(offset, limit, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all phone senders Returns all phone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <returns>ApiResponse of PhoneSenderCollection</returns>
        public ApiResponse<PhoneSenderCollection> GetAllPhoneSendersWithHttpInfo (int? offset = default(int?), int? limit = default(int?), string status = default(string))
        {

            var localVarPath = "/senders/phone";
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
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllPhoneSenders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneSenderCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PhoneSenderCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneSenderCollection)));
        }

        /// <summary>
        /// Get all phone senders Returns all phone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PhoneSenderCollection</returns>
        public async System.Threading.Tasks.Task<PhoneSenderCollection> GetAllPhoneSendersAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PhoneSenderCollection> localVarResponse = await GetAllPhoneSendersWithHttpInfoAsync(offset, limit, status, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all phone senders Returns all phone senders
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="status">Status filter (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PhoneSenderCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneSenderCollection>> GetAllPhoneSendersWithHttpInfoAsync (int? offset = default(int?), int? limit = default(int?), string status = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/senders/phone";
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
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllPhoneSenders", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneSenderCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PhoneSenderCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneSenderCollection)));
        }

        /// <summary>
        /// Update email sender Updates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <returns>EmailSender</returns>
        public EmailSender PutEmailSender (int senderId, EmailSenderPutRequest emailSenderPutRequest)
        {
             ApiResponse<EmailSender> localVarResponse = PutEmailSenderWithHttpInfo(senderId, emailSenderPutRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update email sender Updates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <returns>ApiResponse of EmailSender</returns>
        public ApiResponse<EmailSender> PutEmailSenderWithHttpInfo (int senderId, EmailSenderPutRequest emailSenderPutRequest)
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->PutEmailSender");
            // verify the required parameter 'emailSenderPutRequest' is set
            if (emailSenderPutRequest == null)
                throw new ApiException(400, "Missing required parameter 'emailSenderPutRequest' when calling SendersApi->PutEmailSender");

            var localVarPath = "/senders/email/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter
            if (emailSenderPutRequest != null && emailSenderPutRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(emailSenderPutRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emailSenderPutRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutEmailSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSender)));
        }

        /// <summary>
        /// Update email sender Updates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of EmailSender</returns>
        public async System.Threading.Tasks.Task<EmailSender> PutEmailSenderAsync (int senderId, EmailSenderPutRequest emailSenderPutRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<EmailSender> localVarResponse = await PutEmailSenderWithHttpInfoAsync(senderId, emailSenderPutRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update email sender Updates an email sender
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="senderId">ID of the Sender</param>
        /// <param name="emailSenderPutRequest">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (EmailSender)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSender>> PutEmailSenderWithHttpInfoAsync (int senderId, EmailSenderPutRequest emailSenderPutRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'senderId' is set
            if (senderId == null)
                throw new ApiException(400, "Missing required parameter 'senderId' when calling SendersApi->PutEmailSender");
            // verify the required parameter 'emailSenderPutRequest' is set
            if (emailSenderPutRequest == null)
                throw new ApiException(400, "Missing required parameter 'emailSenderPutRequest' when calling SendersApi->PutEmailSender");

            var localVarPath = "/senders/email/{sender_id}";
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

            if (senderId != null) localVarPathParams.Add("sender_id", this.Configuration.ApiClient.ParameterToString(senderId)); // path parameter
            if (emailSenderPutRequest != null && emailSenderPutRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(emailSenderPutRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = emailSenderPutRequest; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutEmailSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailSender>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailSender) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailSender)));
        }

    }
}
