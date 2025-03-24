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
    public interface IAdvancedReportsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate report by model
        /// </summary>
        /// <remarks>
        /// Generates a new report by model Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateByModelReport (GenerateByModelReport generateByModelReport);

        /// <summary>
        /// Generate report by model
        /// </summary>
        /// <remarks>
        /// Generates a new report by model Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateByModelReportWithHttpInfo (GenerateByModelReport generateByModelReport);
        /// <summary>
        /// Generate contact activity report
        /// </summary>
        /// <remarks>
        /// Generates a new contact activity report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateContactActivityReport (GenerateContactActivityReport generateContactActivityReport);

        /// <summary>
        /// Generate contact activity report
        /// </summary>
        /// <remarks>
        /// Generates a new contact activity report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateContactActivityReportWithHttpInfo (GenerateContactActivityReport generateContactActivityReport);
        /// <summary>
        /// Generate email bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new email bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateEmailBouncesReport (GenerateEmailBouncesReport generateEmailBouncesReport);

        /// <summary>
        /// Generate email bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new email bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateEmailBouncesReportWithHttpInfo (GenerateEmailBouncesReport generateEmailBouncesReport);
        /// <summary>
        /// Generate email clicks by contact report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by contact report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateEmailClicksByContactReport (GenerateEmailClicksByContactReport generateEmailClicksByContactReport);

        /// <summary>
        /// Generate email clicks by contact report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by contact report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateEmailClicksByContactReportWithHttpInfo (GenerateEmailClicksByContactReport generateEmailClicksByContactReport);
        /// <summary>
        /// Generate email clicks by URL report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by URL report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateEmailClicksByUrlReport (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport);

        /// <summary>
        /// Generate email clicks by URL report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by URL report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateEmailClicksByUrlReportWithHttpInfo (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport);
        /// <summary>
        /// Generate email events report
        /// </summary>
        /// <remarks>
        /// Generates a new email events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateEmailEventsReport (GenerateEmailEventsReport generateEmailEventsReport);

        /// <summary>
        /// Generate email events report
        /// </summary>
        /// <remarks>
        /// Generates a new email events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateEmailEventsReportWithHttpInfo (GenerateEmailEventsReport generateEmailEventsReport);
        /// <summary>
        /// Generate email unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new email unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateEmailUnsubscriptionsReport (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport);

        /// <summary>
        /// Generate email unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new email unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateEmailUnsubscriptionsReportWithHttpInfo (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport);
        /// <summary>
        /// Generate form answers report
        /// </summary>
        /// <remarks>
        /// Generates a new form answers report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateFormAnswersReport (GenerateFormAnswersReport generateFormAnswersReport);

        /// <summary>
        /// Generate form answers report
        /// </summary>
        /// <remarks>
        /// Generates a new form answers report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateFormAnswersReportWithHttpInfo (GenerateFormAnswersReport generateFormAnswersReport);
        /// <summary>
        /// Generate sends report
        /// </summary>
        /// <remarks>
        /// Generates a new sends report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateSendsReport (GenerateSendsReport generateSendsReport);

        /// <summary>
        /// Generate sends report
        /// </summary>
        /// <remarks>
        /// Generates a new sends report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateSendsReportWithHttpInfo (GenerateSendsReport generateSendsReport);
        /// <summary>
        /// Generate SMS bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateSmsBouncesReport (GenerateSmsBouncesReport generateSmsBouncesReport);

        /// <summary>
        /// Generate SMS bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateSmsBouncesReportWithHttpInfo (GenerateSmsBouncesReport generateSmsBouncesReport);
        /// <summary>
        /// Generate SMS events report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateSmsEventsReport (GenerateSmsEventsReport generateSmsEventsReport);

        /// <summary>
        /// Generate SMS events report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateSmsEventsReportWithHttpInfo (GenerateSmsEventsReport generateSmsEventsReport);
        /// <summary>
        /// Generate subscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new subscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateSubscriptionsReport (GenerateSubscriptionsReport generateSubscriptionsReport);

        /// <summary>
        /// Generate subscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new subscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateSubscriptionsReportWithHttpInfo (GenerateSubscriptionsReport generateSubscriptionsReport);
        /// <summary>
        /// Generate unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse GenerateUnsubscriptionsReport (GenerateUnsubscriptionsReport generateUnsubscriptionsReport);

        /// <summary>
        /// Generate unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> GenerateUnsubscriptionsReportWithHttpInfo (GenerateUnsubscriptionsReport generateUnsubscriptionsReport);
        /// <summary>
        /// Get all advanced reports
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <returns>AdvancedReportsCollection</returns>
        AdvancedReportsCollection GetAllAdvancedReports (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string));

        /// <summary>
        /// Get all advanced reports
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <returns>ApiResponse of AdvancedReportsCollection</returns>
        ApiResponse<AdvancedReportsCollection> GetAllAdvancedReportsWithHttpInfo (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string));
        /// <summary>
        /// Get all advanced reports models
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <returns>AdvancedReportsModelsCollection</returns>
        AdvancedReportsModelsCollection GetAllAdvancedReportsModels (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string));

        /// <summary>
        /// Get all advanced reports models
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <returns>ApiResponse of AdvancedReportsModelsCollection</returns>
        ApiResponse<AdvancedReportsModelsCollection> GetAllAdvancedReportsModelsWithHttpInfo (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Generate report by model
        /// </summary>
        /// <remarks>
        /// Generates a new report by model Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateByModelReportAsync (GenerateByModelReport generateByModelReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate report by model
        /// </summary>
        /// <remarks>
        /// Generates a new report by model Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateByModelReportWithHttpInfoAsync (GenerateByModelReport generateByModelReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate contact activity report
        /// </summary>
        /// <remarks>
        /// Generates a new contact activity report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateContactActivityReportAsync (GenerateContactActivityReport generateContactActivityReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate contact activity report
        /// </summary>
        /// <remarks>
        /// Generates a new contact activity report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateContactActivityReportWithHttpInfoAsync (GenerateContactActivityReport generateContactActivityReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate email bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new email bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailBouncesReportAsync (GenerateEmailBouncesReport generateEmailBouncesReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate email bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new email bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailBouncesReportWithHttpInfoAsync (GenerateEmailBouncesReport generateEmailBouncesReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate email clicks by contact report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by contact report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailClicksByContactReportAsync (GenerateEmailClicksByContactReport generateEmailClicksByContactReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate email clicks by contact report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by contact report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailClicksByContactReportWithHttpInfoAsync (GenerateEmailClicksByContactReport generateEmailClicksByContactReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate email clicks by URL report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by URL report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailClicksByUrlReportAsync (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate email clicks by URL report
        /// </summary>
        /// <remarks>
        /// Generates a new email clicks by URL report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailClicksByUrlReportWithHttpInfoAsync (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate email events report
        /// </summary>
        /// <remarks>
        /// Generates a new email events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailEventsReportAsync (GenerateEmailEventsReport generateEmailEventsReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate email events report
        /// </summary>
        /// <remarks>
        /// Generates a new email events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailEventsReportWithHttpInfoAsync (GenerateEmailEventsReport generateEmailEventsReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate email unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new email unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailUnsubscriptionsReportAsync (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate email unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new email unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailUnsubscriptionsReportWithHttpInfoAsync (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate form answers report
        /// </summary>
        /// <remarks>
        /// Generates a new form answers report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateFormAnswersReportAsync (GenerateFormAnswersReport generateFormAnswersReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate form answers report
        /// </summary>
        /// <remarks>
        /// Generates a new form answers report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateFormAnswersReportWithHttpInfoAsync (GenerateFormAnswersReport generateFormAnswersReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate sends report
        /// </summary>
        /// <remarks>
        /// Generates a new sends report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateSendsReportAsync (GenerateSendsReport generateSendsReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate sends report
        /// </summary>
        /// <remarks>
        /// Generates a new sends report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSendsReportWithHttpInfoAsync (GenerateSendsReport generateSendsReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate SMS bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateSmsBouncesReportAsync (GenerateSmsBouncesReport generateSmsBouncesReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate SMS bounces report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS bounces report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSmsBouncesReportWithHttpInfoAsync (GenerateSmsBouncesReport generateSmsBouncesReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate SMS events report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateSmsEventsReportAsync (GenerateSmsEventsReport generateSmsEventsReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate SMS events report
        /// </summary>
        /// <remarks>
        /// Generates a new SMS events report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSmsEventsReportWithHttpInfoAsync (GenerateSmsEventsReport generateSmsEventsReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate subscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new subscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateSubscriptionsReportAsync (GenerateSubscriptionsReport generateSubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate subscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new subscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSubscriptionsReportWithHttpInfoAsync (GenerateSubscriptionsReport generateSubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generate unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> GenerateUnsubscriptionsReportAsync (GenerateUnsubscriptionsReport generateUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate unsubscriptions report
        /// </summary>
        /// <remarks>
        /// Generates a new unsubscriptions report
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateUnsubscriptionsReportWithHttpInfoAsync (GenerateUnsubscriptionsReport generateUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all advanced reports
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AdvancedReportsCollection</returns>
        System.Threading.Tasks.Task<AdvancedReportsCollection> GetAllAdvancedReportsAsync (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all advanced reports
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AdvancedReportsCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedReportsCollection>> GetAllAdvancedReportsWithHttpInfoAsync (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all advanced reports models
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AdvancedReportsModelsCollection</returns>
        System.Threading.Tasks.Task<AdvancedReportsModelsCollection> GetAllAdvancedReportsModelsAsync (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all advanced reports models
        /// </summary>
        /// <remarks>
        /// Returns all advanced reports
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AdvancedReportsModelsCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvancedReportsModelsCollection>> GetAllAdvancedReportsModelsWithHttpInfoAsync (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AdvancedReportsApi : IAdvancedReportsApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdvancedReportsApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedReportsApi"/> class
        /// </summary>
        /// <returns></returns>
        public AdvancedReportsApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedReportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdvancedReportsApi(org.egoi.client.api.Client.Configuration configuration = null)
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
        /// Generate report by model Generates a new report by model Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateByModelReport (GenerateByModelReport generateByModelReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateByModelReportWithHttpInfo(generateByModelReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate report by model Generates a new report by model Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateByModelReportWithHttpInfo (GenerateByModelReport generateByModelReport)
        {
            // verify the required parameter 'generateByModelReport' is set
            if (generateByModelReport == null)
                throw new ApiException(400, "Missing required parameter 'generateByModelReport' when calling AdvancedReportsApi->GenerateByModelReport");

            var localVarPath = "/reports/advanced/model";
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

            if (generateByModelReport != null && generateByModelReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateByModelReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateByModelReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateByModelReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate report by model Generates a new report by model Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateByModelReportAsync (GenerateByModelReport generateByModelReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateByModelReportWithHttpInfoAsync(generateByModelReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate report by model Generates a new report by model Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateByModelReport">Parameters for the report by model Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateByModelReportWithHttpInfoAsync (GenerateByModelReport generateByModelReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateByModelReport' is set
            if (generateByModelReport == null)
                throw new ApiException(400, "Missing required parameter 'generateByModelReport' when calling AdvancedReportsApi->GenerateByModelReport");

            var localVarPath = "/reports/advanced/model";
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

            if (generateByModelReport != null && generateByModelReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateByModelReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateByModelReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateByModelReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate contact activity report Generates a new contact activity report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateContactActivityReport (GenerateContactActivityReport generateContactActivityReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateContactActivityReportWithHttpInfo(generateContactActivityReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate contact activity report Generates a new contact activity report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateContactActivityReportWithHttpInfo (GenerateContactActivityReport generateContactActivityReport)
        {
            // verify the required parameter 'generateContactActivityReport' is set
            if (generateContactActivityReport == null)
                throw new ApiException(400, "Missing required parameter 'generateContactActivityReport' when calling AdvancedReportsApi->GenerateContactActivityReport");

            var localVarPath = "/reports/advanced/contact-activity";
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

            if (generateContactActivityReport != null && generateContactActivityReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateContactActivityReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateContactActivityReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateContactActivityReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate contact activity report Generates a new contact activity report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateContactActivityReportAsync (GenerateContactActivityReport generateContactActivityReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateContactActivityReportWithHttpInfoAsync(generateContactActivityReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate contact activity report Generates a new contact activity report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateContactActivityReport">Parameters for the contact activity report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateContactActivityReportWithHttpInfoAsync (GenerateContactActivityReport generateContactActivityReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateContactActivityReport' is set
            if (generateContactActivityReport == null)
                throw new ApiException(400, "Missing required parameter 'generateContactActivityReport' when calling AdvancedReportsApi->GenerateContactActivityReport");

            var localVarPath = "/reports/advanced/contact-activity";
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

            if (generateContactActivityReport != null && generateContactActivityReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateContactActivityReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateContactActivityReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateContactActivityReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email bounces report Generates a new email bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateEmailBouncesReport (GenerateEmailBouncesReport generateEmailBouncesReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateEmailBouncesReportWithHttpInfo(generateEmailBouncesReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate email bounces report Generates a new email bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateEmailBouncesReportWithHttpInfo (GenerateEmailBouncesReport generateEmailBouncesReport)
        {
            // verify the required parameter 'generateEmailBouncesReport' is set
            if (generateEmailBouncesReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailBouncesReport' when calling AdvancedReportsApi->GenerateEmailBouncesReport");

            var localVarPath = "/reports/advanced/email-bounces";
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

            if (generateEmailBouncesReport != null && generateEmailBouncesReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailBouncesReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailBouncesReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailBouncesReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email bounces report Generates a new email bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailBouncesReportAsync (GenerateEmailBouncesReport generateEmailBouncesReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateEmailBouncesReportWithHttpInfoAsync(generateEmailBouncesReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate email bounces report Generates a new email bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailBouncesReport">Parameters for the email bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailBouncesReportWithHttpInfoAsync (GenerateEmailBouncesReport generateEmailBouncesReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateEmailBouncesReport' is set
            if (generateEmailBouncesReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailBouncesReport' when calling AdvancedReportsApi->GenerateEmailBouncesReport");

            var localVarPath = "/reports/advanced/email-bounces";
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

            if (generateEmailBouncesReport != null && generateEmailBouncesReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailBouncesReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailBouncesReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailBouncesReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email clicks by contact report Generates a new email clicks by contact report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateEmailClicksByContactReport (GenerateEmailClicksByContactReport generateEmailClicksByContactReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateEmailClicksByContactReportWithHttpInfo(generateEmailClicksByContactReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate email clicks by contact report Generates a new email clicks by contact report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateEmailClicksByContactReportWithHttpInfo (GenerateEmailClicksByContactReport generateEmailClicksByContactReport)
        {
            // verify the required parameter 'generateEmailClicksByContactReport' is set
            if (generateEmailClicksByContactReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailClicksByContactReport' when calling AdvancedReportsApi->GenerateEmailClicksByContactReport");

            var localVarPath = "/reports/advanced/email-clicks-by-contact";
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

            if (generateEmailClicksByContactReport != null && generateEmailClicksByContactReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailClicksByContactReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailClicksByContactReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailClicksByContactReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email clicks by contact report Generates a new email clicks by contact report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailClicksByContactReportAsync (GenerateEmailClicksByContactReport generateEmailClicksByContactReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateEmailClicksByContactReportWithHttpInfoAsync(generateEmailClicksByContactReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate email clicks by contact report Generates a new email clicks by contact report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByContactReport">Parameters for the email clicks by contact report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailClicksByContactReportWithHttpInfoAsync (GenerateEmailClicksByContactReport generateEmailClicksByContactReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateEmailClicksByContactReport' is set
            if (generateEmailClicksByContactReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailClicksByContactReport' when calling AdvancedReportsApi->GenerateEmailClicksByContactReport");

            var localVarPath = "/reports/advanced/email-clicks-by-contact";
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

            if (generateEmailClicksByContactReport != null && generateEmailClicksByContactReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailClicksByContactReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailClicksByContactReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailClicksByContactReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email clicks by URL report Generates a new email clicks by URL report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateEmailClicksByUrlReport (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateEmailClicksByUrlReportWithHttpInfo(generateEmailClicksByUrlReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate email clicks by URL report Generates a new email clicks by URL report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateEmailClicksByUrlReportWithHttpInfo (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport)
        {
            // verify the required parameter 'generateEmailClicksByUrlReport' is set
            if (generateEmailClicksByUrlReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailClicksByUrlReport' when calling AdvancedReportsApi->GenerateEmailClicksByUrlReport");

            var localVarPath = "/reports/advanced/email-clicks-by-url";
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

            if (generateEmailClicksByUrlReport != null && generateEmailClicksByUrlReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailClicksByUrlReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailClicksByUrlReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailClicksByUrlReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email clicks by URL report Generates a new email clicks by URL report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailClicksByUrlReportAsync (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateEmailClicksByUrlReportWithHttpInfoAsync(generateEmailClicksByUrlReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate email clicks by URL report Generates a new email clicks by URL report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailClicksByUrlReport">Parameters for the email clicks by URL report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailClicksByUrlReportWithHttpInfoAsync (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateEmailClicksByUrlReport' is set
            if (generateEmailClicksByUrlReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailClicksByUrlReport' when calling AdvancedReportsApi->GenerateEmailClicksByUrlReport");

            var localVarPath = "/reports/advanced/email-clicks-by-url";
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

            if (generateEmailClicksByUrlReport != null && generateEmailClicksByUrlReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailClicksByUrlReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailClicksByUrlReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailClicksByUrlReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email events report Generates a new email events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateEmailEventsReport (GenerateEmailEventsReport generateEmailEventsReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateEmailEventsReportWithHttpInfo(generateEmailEventsReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate email events report Generates a new email events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateEmailEventsReportWithHttpInfo (GenerateEmailEventsReport generateEmailEventsReport)
        {
            // verify the required parameter 'generateEmailEventsReport' is set
            if (generateEmailEventsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailEventsReport' when calling AdvancedReportsApi->GenerateEmailEventsReport");

            var localVarPath = "/reports/advanced/email-events";
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

            if (generateEmailEventsReport != null && generateEmailEventsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailEventsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailEventsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailEventsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email events report Generates a new email events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailEventsReportAsync (GenerateEmailEventsReport generateEmailEventsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateEmailEventsReportWithHttpInfoAsync(generateEmailEventsReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate email events report Generates a new email events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailEventsReport">Parameters for the email events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailEventsReportWithHttpInfoAsync (GenerateEmailEventsReport generateEmailEventsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateEmailEventsReport' is set
            if (generateEmailEventsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailEventsReport' when calling AdvancedReportsApi->GenerateEmailEventsReport");

            var localVarPath = "/reports/advanced/email-events";
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

            if (generateEmailEventsReport != null && generateEmailEventsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailEventsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailEventsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailEventsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email unsubscriptions report Generates a new email unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateEmailUnsubscriptionsReport (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateEmailUnsubscriptionsReportWithHttpInfo(generateEmailUnsubscriptionsReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate email unsubscriptions report Generates a new email unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateEmailUnsubscriptionsReportWithHttpInfo (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport)
        {
            // verify the required parameter 'generateEmailUnsubscriptionsReport' is set
            if (generateEmailUnsubscriptionsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailUnsubscriptionsReport' when calling AdvancedReportsApi->GenerateEmailUnsubscriptionsReport");

            var localVarPath = "/reports/advanced/email-unsubscriptions";
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

            if (generateEmailUnsubscriptionsReport != null && generateEmailUnsubscriptionsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailUnsubscriptionsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailUnsubscriptionsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailUnsubscriptionsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate email unsubscriptions report Generates a new email unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateEmailUnsubscriptionsReportAsync (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateEmailUnsubscriptionsReportWithHttpInfoAsync(generateEmailUnsubscriptionsReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate email unsubscriptions report Generates a new email unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateEmailUnsubscriptionsReport">Parameters for the email unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateEmailUnsubscriptionsReportWithHttpInfoAsync (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateEmailUnsubscriptionsReport' is set
            if (generateEmailUnsubscriptionsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateEmailUnsubscriptionsReport' when calling AdvancedReportsApi->GenerateEmailUnsubscriptionsReport");

            var localVarPath = "/reports/advanced/email-unsubscriptions";
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

            if (generateEmailUnsubscriptionsReport != null && generateEmailUnsubscriptionsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateEmailUnsubscriptionsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateEmailUnsubscriptionsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateEmailUnsubscriptionsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate form answers report Generates a new form answers report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateFormAnswersReport (GenerateFormAnswersReport generateFormAnswersReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateFormAnswersReportWithHttpInfo(generateFormAnswersReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate form answers report Generates a new form answers report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateFormAnswersReportWithHttpInfo (GenerateFormAnswersReport generateFormAnswersReport)
        {
            // verify the required parameter 'generateFormAnswersReport' is set
            if (generateFormAnswersReport == null)
                throw new ApiException(400, "Missing required parameter 'generateFormAnswersReport' when calling AdvancedReportsApi->GenerateFormAnswersReport");

            var localVarPath = "/reports/advanced/form-answers";
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

            if (generateFormAnswersReport != null && generateFormAnswersReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateFormAnswersReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateFormAnswersReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateFormAnswersReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate form answers report Generates a new form answers report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateFormAnswersReportAsync (GenerateFormAnswersReport generateFormAnswersReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateFormAnswersReportWithHttpInfoAsync(generateFormAnswersReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate form answers report Generates a new form answers report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFormAnswersReport">Parameters for the form answers report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateFormAnswersReportWithHttpInfoAsync (GenerateFormAnswersReport generateFormAnswersReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateFormAnswersReport' is set
            if (generateFormAnswersReport == null)
                throw new ApiException(400, "Missing required parameter 'generateFormAnswersReport' when calling AdvancedReportsApi->GenerateFormAnswersReport");

            var localVarPath = "/reports/advanced/form-answers";
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

            if (generateFormAnswersReport != null && generateFormAnswersReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateFormAnswersReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateFormAnswersReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateFormAnswersReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate sends report Generates a new sends report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateSendsReport (GenerateSendsReport generateSendsReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateSendsReportWithHttpInfo(generateSendsReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate sends report Generates a new sends report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateSendsReportWithHttpInfo (GenerateSendsReport generateSendsReport)
        {
            // verify the required parameter 'generateSendsReport' is set
            if (generateSendsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSendsReport' when calling AdvancedReportsApi->GenerateSendsReport");

            var localVarPath = "/reports/advanced/sends";
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

            if (generateSendsReport != null && generateSendsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSendsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSendsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSendsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate sends report Generates a new sends report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateSendsReportAsync (GenerateSendsReport generateSendsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateSendsReportWithHttpInfoAsync(generateSendsReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate sends report Generates a new sends report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSendsReport">Parameters for the sends report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSendsReportWithHttpInfoAsync (GenerateSendsReport generateSendsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateSendsReport' is set
            if (generateSendsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSendsReport' when calling AdvancedReportsApi->GenerateSendsReport");

            var localVarPath = "/reports/advanced/sends";
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

            if (generateSendsReport != null && generateSendsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSendsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSendsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSendsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate SMS bounces report Generates a new SMS bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateSmsBouncesReport (GenerateSmsBouncesReport generateSmsBouncesReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateSmsBouncesReportWithHttpInfo(generateSmsBouncesReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate SMS bounces report Generates a new SMS bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateSmsBouncesReportWithHttpInfo (GenerateSmsBouncesReport generateSmsBouncesReport)
        {
            // verify the required parameter 'generateSmsBouncesReport' is set
            if (generateSmsBouncesReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSmsBouncesReport' when calling AdvancedReportsApi->GenerateSmsBouncesReport");

            var localVarPath = "/reports/advanced/sms-bounces";
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

            if (generateSmsBouncesReport != null && generateSmsBouncesReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSmsBouncesReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSmsBouncesReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSmsBouncesReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate SMS bounces report Generates a new SMS bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateSmsBouncesReportAsync (GenerateSmsBouncesReport generateSmsBouncesReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateSmsBouncesReportWithHttpInfoAsync(generateSmsBouncesReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate SMS bounces report Generates a new SMS bounces report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsBouncesReport">Parameters for the SMS bounces report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSmsBouncesReportWithHttpInfoAsync (GenerateSmsBouncesReport generateSmsBouncesReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateSmsBouncesReport' is set
            if (generateSmsBouncesReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSmsBouncesReport' when calling AdvancedReportsApi->GenerateSmsBouncesReport");

            var localVarPath = "/reports/advanced/sms-bounces";
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

            if (generateSmsBouncesReport != null && generateSmsBouncesReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSmsBouncesReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSmsBouncesReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSmsBouncesReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate SMS events report Generates a new SMS events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateSmsEventsReport (GenerateSmsEventsReport generateSmsEventsReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateSmsEventsReportWithHttpInfo(generateSmsEventsReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate SMS events report Generates a new SMS events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateSmsEventsReportWithHttpInfo (GenerateSmsEventsReport generateSmsEventsReport)
        {
            // verify the required parameter 'generateSmsEventsReport' is set
            if (generateSmsEventsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSmsEventsReport' when calling AdvancedReportsApi->GenerateSmsEventsReport");

            var localVarPath = "/reports/advanced/sms-events";
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

            if (generateSmsEventsReport != null && generateSmsEventsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSmsEventsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSmsEventsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSmsEventsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate SMS events report Generates a new SMS events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateSmsEventsReportAsync (GenerateSmsEventsReport generateSmsEventsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateSmsEventsReportWithHttpInfoAsync(generateSmsEventsReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate SMS events report Generates a new SMS events report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSmsEventsReport">Parameters for the SMS events report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSmsEventsReportWithHttpInfoAsync (GenerateSmsEventsReport generateSmsEventsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateSmsEventsReport' is set
            if (generateSmsEventsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSmsEventsReport' when calling AdvancedReportsApi->GenerateSmsEventsReport");

            var localVarPath = "/reports/advanced/sms-events";
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

            if (generateSmsEventsReport != null && generateSmsEventsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSmsEventsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSmsEventsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSmsEventsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate subscriptions report Generates a new subscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateSubscriptionsReport (GenerateSubscriptionsReport generateSubscriptionsReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateSubscriptionsReportWithHttpInfo(generateSubscriptionsReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate subscriptions report Generates a new subscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateSubscriptionsReportWithHttpInfo (GenerateSubscriptionsReport generateSubscriptionsReport)
        {
            // verify the required parameter 'generateSubscriptionsReport' is set
            if (generateSubscriptionsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSubscriptionsReport' when calling AdvancedReportsApi->GenerateSubscriptionsReport");

            var localVarPath = "/reports/advanced/subscriptions";
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

            if (generateSubscriptionsReport != null && generateSubscriptionsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSubscriptionsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSubscriptionsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSubscriptionsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate subscriptions report Generates a new subscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateSubscriptionsReportAsync (GenerateSubscriptionsReport generateSubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateSubscriptionsReportWithHttpInfoAsync(generateSubscriptionsReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate subscriptions report Generates a new subscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateSubscriptionsReport">Parameters for the subscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateSubscriptionsReportWithHttpInfoAsync (GenerateSubscriptionsReport generateSubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateSubscriptionsReport' is set
            if (generateSubscriptionsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateSubscriptionsReport' when calling AdvancedReportsApi->GenerateSubscriptionsReport");

            var localVarPath = "/reports/advanced/subscriptions";
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

            if (generateSubscriptionsReport != null && generateSubscriptionsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateSubscriptionsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateSubscriptionsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateSubscriptionsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate unsubscriptions report Generates a new unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse GenerateUnsubscriptionsReport (GenerateUnsubscriptionsReport generateUnsubscriptionsReport)
        {
             ApiResponse<AcceptedResponse> localVarResponse = GenerateUnsubscriptionsReportWithHttpInfo(generateUnsubscriptionsReport);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate unsubscriptions report Generates a new unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> GenerateUnsubscriptionsReportWithHttpInfo (GenerateUnsubscriptionsReport generateUnsubscriptionsReport)
        {
            // verify the required parameter 'generateUnsubscriptionsReport' is set
            if (generateUnsubscriptionsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateUnsubscriptionsReport' when calling AdvancedReportsApi->GenerateUnsubscriptionsReport");

            var localVarPath = "/reports/advanced/unsubscriptions";
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

            if (generateUnsubscriptionsReport != null && generateUnsubscriptionsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateUnsubscriptionsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateUnsubscriptionsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateUnsubscriptionsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Generate unsubscriptions report Generates a new unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> GenerateUnsubscriptionsReportAsync (GenerateUnsubscriptionsReport generateUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await GenerateUnsubscriptionsReportWithHttpInfoAsync(generateUnsubscriptionsReport, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate unsubscriptions report Generates a new unsubscriptions report
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateUnsubscriptionsReport">Parameters for the unsubscriptions report</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> GenerateUnsubscriptionsReportWithHttpInfoAsync (GenerateUnsubscriptionsReport generateUnsubscriptionsReport, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'generateUnsubscriptionsReport' is set
            if (generateUnsubscriptionsReport == null)
                throw new ApiException(400, "Missing required parameter 'generateUnsubscriptionsReport' when calling AdvancedReportsApi->GenerateUnsubscriptionsReport");

            var localVarPath = "/reports/advanced/unsubscriptions";
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

            if (generateUnsubscriptionsReport != null && generateUnsubscriptionsReport.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(generateUnsubscriptionsReport); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateUnsubscriptionsReport; // byte array
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
                Exception exception = ExceptionFactory("GenerateUnsubscriptionsReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Get all advanced reports Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <returns>AdvancedReportsCollection</returns>
        public AdvancedReportsCollection GetAllAdvancedReports (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string))
        {
             ApiResponse<AdvancedReportsCollection> localVarResponse = GetAllAdvancedReportsWithHttpInfo(status, title, createdMin, createdMax, offset, limit, order, orderBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all advanced reports Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <returns>ApiResponse of AdvancedReportsCollection</returns>
        public ApiResponse<AdvancedReportsCollection> GetAllAdvancedReportsWithHttpInfo (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string))
        {

            var localVarPath = "/reports/advanced";
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

            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (title != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "title", title)); // query parameter
            if (createdMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_min", createdMin)); // query parameter
            if (createdMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_max", createdMax)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllAdvancedReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdvancedReportsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AdvancedReportsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdvancedReportsCollection)));
        }

        /// <summary>
        /// Get all advanced reports Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AdvancedReportsCollection</returns>
        public async System.Threading.Tasks.Task<AdvancedReportsCollection> GetAllAdvancedReportsAsync (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AdvancedReportsCollection> localVarResponse = await GetAllAdvancedReportsWithHttpInfoAsync(status, title, createdMin, createdMax, offset, limit, order, orderBy, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all advanced reports Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Advanced report status (optional)</param>
        /// <param name="title">Advanced report title (optional)</param>
        /// <param name="createdMin">Created initial date (optional)</param>
        /// <param name="createdMax">Created finish (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to advanced_report_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AdvancedReportsCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedReportsCollection>> GetAllAdvancedReportsWithHttpInfoAsync (string status = default(string), string title = default(string), DateTime? createdMin = default(DateTime?), DateTime? createdMax = default(DateTime?), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/reports/advanced";
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

            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (title != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "title", title)); // query parameter
            if (createdMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_min", createdMin)); // query parameter
            if (createdMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created_max", createdMax)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllAdvancedReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdvancedReportsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AdvancedReportsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdvancedReportsCollection)));
        }

        /// <summary>
        /// Get all advanced reports models Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <returns>AdvancedReportsModelsCollection</returns>
        public AdvancedReportsModelsCollection GetAllAdvancedReportsModels (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string))
        {
             ApiResponse<AdvancedReportsModelsCollection> localVarResponse = GetAllAdvancedReportsModelsWithHttpInfo(title, offset, limit, order, orderBy);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all advanced reports models Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <returns>ApiResponse of AdvancedReportsModelsCollection</returns>
        public ApiResponse<AdvancedReportsModelsCollection> GetAllAdvancedReportsModelsWithHttpInfo (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string))
        {

            var localVarPath = "/reports/advanced/models";
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

            if (title != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "title", title)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllAdvancedReportsModels", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdvancedReportsModelsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AdvancedReportsModelsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdvancedReportsModelsCollection)));
        }

        /// <summary>
        /// Get all advanced reports models Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AdvancedReportsModelsCollection</returns>
        public async System.Threading.Tasks.Task<AdvancedReportsModelsCollection> GetAllAdvancedReportsModelsAsync (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AdvancedReportsModelsCollection> localVarResponse = await GetAllAdvancedReportsModelsWithHttpInfoAsync(title, offset, limit, order, orderBy, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all advanced reports models Returns all advanced reports
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="title">Advanced report model title (optional)</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="order">Type of order (optional, default to desc)</param>
        /// <param name="orderBy">Reference attribute to order the advanced reports (optional, default to model_id)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AdvancedReportsModelsCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvancedReportsModelsCollection>> GetAllAdvancedReportsModelsWithHttpInfoAsync (string title = default(string), int? offset = default(int?), int? limit = default(int?), string order = default(string), string orderBy = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/reports/advanced/models";
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

            if (title != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "title", title)); // query parameter
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
                Exception exception = ExceptionFactory("GetAllAdvancedReportsModels", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AdvancedReportsModelsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AdvancedReportsModelsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdvancedReportsModelsCollection)));
        }

    }
}
