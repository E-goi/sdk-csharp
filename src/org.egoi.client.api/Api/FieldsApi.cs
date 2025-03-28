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
    public interface IFieldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create extra field
        /// </summary>
        /// <remarks>
        /// Creates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <returns>Field</returns>
        Field CreateExtraField (int listId, Field field);

        /// <summary>
        /// Create extra field
        /// </summary>
        /// <remarks>
        /// Creates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <returns>ApiResponse of Field</returns>
        ApiResponse<Field> CreateExtraFieldWithHttpInfo (int listId, Field field);
        /// <summary>
        /// Create new field option
        /// </summary>
        /// <remarks>
        /// Creates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>FieldOption</returns>
        FieldOption CreateFieldOption (int listId, int fieldId, FieldOptionPost fieldOptionPost);

        /// <summary>
        /// Create new field option
        /// </summary>
        /// <remarks>
        /// Creates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>ApiResponse of FieldOption</returns>
        ApiResponse<FieldOption> CreateFieldOptionWithHttpInfo (int listId, int fieldId, FieldOptionPost fieldOptionPost);
        /// <summary>
        /// Remove extra field
        /// </summary>
        /// <remarks>
        /// Removes an extra field given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns></returns>
        void DeleteExtraField (int listId, int fieldId);

        /// <summary>
        /// Remove extra field
        /// </summary>
        /// <remarks>
        /// Removes an extra field given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteExtraFieldWithHttpInfo (int listId, int fieldId);
        /// <summary>
        /// Deletes an option
        /// </summary>
        /// <remarks>
        /// Deletes an option of a list of values field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <returns></returns>
        void DeleteFieldOption (int listId, int fieldId, int optionId);

        /// <summary>
        /// Deletes an option
        /// </summary>
        /// <remarks>
        /// Deletes an option of a list of values field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteFieldOptionWithHttpInfo (int listId, int fieldId, int optionId);
        /// <summary>
        /// Get all field options
        /// </summary>
        /// <remarks>
        /// Returns all options of a given field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns>FieldOptionsCollection</returns>
        FieldOptionsCollection GetAllFieldOptions (int listId, int fieldId);

        /// <summary>
        /// Get all field options
        /// </summary>
        /// <remarks>
        /// Returns all options of a given field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns>ApiResponse of FieldOptionsCollection</returns>
        ApiResponse<FieldOptionsCollection> GetAllFieldOptionsWithHttpInfo (int listId, int fieldId);
        /// <summary>
        /// Get all fields
        /// </summary>
        /// <remarks>
        /// Returns all fields
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>List&lt;ComplexField&gt;</returns>
        List<ComplexField> GetAllFields (int listId, int? offset = default(int?), int? limit = default(int?));

        /// <summary>
        /// Get all fields
        /// </summary>
        /// <remarks>
        /// Returns all fields
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>ApiResponse of List&lt;ComplexField&gt;</returns>
        ApiResponse<List<ComplexField>> GetAllFieldsWithHttpInfo (int listId, int? offset = default(int?), int? limit = default(int?));
        /// <summary>
        /// Update base field
        /// </summary>
        /// <remarks>
        /// Updates a base field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <returns>Field</returns>
        Field PatchBaseField (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField);

        /// <summary>
        /// Update base field
        /// </summary>
        /// <remarks>
        /// Updates a base field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <returns>ApiResponse of Field</returns>
        ApiResponse<Field> PatchBaseFieldWithHttpInfo (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField);
        /// <summary>
        /// Update extra field
        /// </summary>
        /// <remarks>
        /// Updates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <returns>Field</returns>
        Field PatchExtraField (int listId, int fieldId, PatchRequestField patchRequestField);

        /// <summary>
        /// Update extra field
        /// </summary>
        /// <remarks>
        /// Updates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <returns>ApiResponse of Field</returns>
        ApiResponse<Field> PatchExtraFieldWithHttpInfo (int listId, int fieldId, PatchRequestField patchRequestField);
        /// <summary>
        /// Update field option
        /// </summary>
        /// <remarks>
        /// Updates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>FieldOption</returns>
        FieldOption UpdateFieldOption (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost);

        /// <summary>
        /// Update field option
        /// </summary>
        /// <remarks>
        /// Updates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>ApiResponse of FieldOption</returns>
        ApiResponse<FieldOption> UpdateFieldOptionWithHttpInfo (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create extra field
        /// </summary>
        /// <remarks>
        /// Creates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Field</returns>
        System.Threading.Tasks.Task<Field> CreateExtraFieldAsync (int listId, Field field, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create extra field
        /// </summary>
        /// <remarks>
        /// Creates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Field)</returns>
        System.Threading.Tasks.Task<ApiResponse<Field>> CreateExtraFieldWithHttpInfoAsync (int listId, Field field, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create new field option
        /// </summary>
        /// <remarks>
        /// Creates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FieldOption</returns>
        System.Threading.Tasks.Task<FieldOption> CreateFieldOptionAsync (int listId, int fieldId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new field option
        /// </summary>
        /// <remarks>
        /// Creates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FieldOption)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldOption>> CreateFieldOptionWithHttpInfoAsync (int listId, int fieldId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove extra field
        /// </summary>
        /// <remarks>
        /// Removes an extra field given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteExtraFieldAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove extra field
        /// </summary>
        /// <remarks>
        /// Removes an extra field given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExtraFieldWithHttpInfoAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an option
        /// </summary>
        /// <remarks>
        /// Deletes an option of a list of values field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteFieldOptionAsync (int listId, int fieldId, int optionId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes an option
        /// </summary>
        /// <remarks>
        /// Deletes an option of a list of values field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFieldOptionWithHttpInfoAsync (int listId, int fieldId, int optionId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all field options
        /// </summary>
        /// <remarks>
        /// Returns all options of a given field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FieldOptionsCollection</returns>
        System.Threading.Tasks.Task<FieldOptionsCollection> GetAllFieldOptionsAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all field options
        /// </summary>
        /// <remarks>
        /// Returns all options of a given field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FieldOptionsCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldOptionsCollection>> GetAllFieldOptionsWithHttpInfoAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all fields
        /// </summary>
        /// <remarks>
        /// Returns all fields
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;ComplexField&gt;</returns>
        System.Threading.Tasks.Task<List<ComplexField>> GetAllFieldsAsync (int listId, int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all fields
        /// </summary>
        /// <remarks>
        /// Returns all fields
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;ComplexField&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ComplexField>>> GetAllFieldsWithHttpInfoAsync (int listId, int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update base field
        /// </summary>
        /// <remarks>
        /// Updates a base field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Field</returns>
        System.Threading.Tasks.Task<Field> PatchBaseFieldAsync (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update base field
        /// </summary>
        /// <remarks>
        /// Updates a base field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Field)</returns>
        System.Threading.Tasks.Task<ApiResponse<Field>> PatchBaseFieldWithHttpInfoAsync (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update extra field
        /// </summary>
        /// <remarks>
        /// Updates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Field</returns>
        System.Threading.Tasks.Task<Field> PatchExtraFieldAsync (int listId, int fieldId, PatchRequestField patchRequestField, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update extra field
        /// </summary>
        /// <remarks>
        /// Updates an extra field
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Field)</returns>
        System.Threading.Tasks.Task<ApiResponse<Field>> PatchExtraFieldWithHttpInfoAsync (int listId, int fieldId, PatchRequestField patchRequestField, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update field option
        /// </summary>
        /// <remarks>
        /// Updates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FieldOption</returns>
        System.Threading.Tasks.Task<FieldOption> UpdateFieldOptionAsync (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update field option
        /// </summary>
        /// <remarks>
        /// Updates a field option
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FieldOption)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldOption>> UpdateFieldOptionWithHttpInfoAsync (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FieldsApi : IFieldsApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FieldsApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsApi"/> class
        /// </summary>
        /// <returns></returns>
        public FieldsApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FieldsApi(org.egoi.client.api.Client.Configuration configuration = null)
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
        /// Create extra field Creates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <returns>Field</returns>
        public Field CreateExtraField (int listId, Field field)
        {
             ApiResponse<Field> localVarResponse = CreateExtraFieldWithHttpInfo(listId, field);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create extra field Creates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <returns>ApiResponse of Field</returns>
        public ApiResponse<Field> CreateExtraFieldWithHttpInfo (int listId, Field field)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->CreateExtraField");
            // verify the required parameter 'field' is set
            if (field == null)
                throw new ApiException(400, "Missing required parameter 'field' when calling FieldsApi->CreateExtraField");

            var localVarPath = "/lists/{list_id}/fields/extra";
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
            if (field != null && field.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(field); // http body (model) parameter
            }
            else
            {
                localVarPostBody = field; // byte array
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
                Exception exception = ExceptionFactory("CreateExtraField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Field>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Field) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Field)));
        }

        /// <summary>
        /// Create extra field Creates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Field</returns>
        public async System.Threading.Tasks.Task<Field> CreateExtraFieldAsync (int listId, Field field, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Field> localVarResponse = await CreateExtraFieldWithHttpInfoAsync(listId, field, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create extra field Creates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="field">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Field)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Field>> CreateExtraFieldWithHttpInfoAsync (int listId, Field field, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->CreateExtraField");
            // verify the required parameter 'field' is set
            if (field == null)
                throw new ApiException(400, "Missing required parameter 'field' when calling FieldsApi->CreateExtraField");

            var localVarPath = "/lists/{list_id}/fields/extra";
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
            if (field != null && field.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(field); // http body (model) parameter
            }
            else
            {
                localVarPostBody = field; // byte array
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
                Exception exception = ExceptionFactory("CreateExtraField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Field>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Field) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Field)));
        }

        /// <summary>
        /// Create new field option Creates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>FieldOption</returns>
        public FieldOption CreateFieldOption (int listId, int fieldId, FieldOptionPost fieldOptionPost)
        {
             ApiResponse<FieldOption> localVarResponse = CreateFieldOptionWithHttpInfo(listId, fieldId, fieldOptionPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new field option Creates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>ApiResponse of FieldOption</returns>
        public ApiResponse<FieldOption> CreateFieldOptionWithHttpInfo (int listId, int fieldId, FieldOptionPost fieldOptionPost)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->CreateFieldOption");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->CreateFieldOption");
            // verify the required parameter 'fieldOptionPost' is set
            if (fieldOptionPost == null)
                throw new ApiException(400, "Missing required parameter 'fieldOptionPost' when calling FieldsApi->CreateFieldOption");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (fieldOptionPost != null && fieldOptionPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fieldOptionPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fieldOptionPost; // byte array
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
                Exception exception = ExceptionFactory("CreateFieldOption", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldOption>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FieldOption) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldOption)));
        }

        /// <summary>
        /// Create new field option Creates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FieldOption</returns>
        public async System.Threading.Tasks.Task<FieldOption> CreateFieldOptionAsync (int listId, int fieldId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FieldOption> localVarResponse = await CreateFieldOptionWithHttpInfoAsync(listId, fieldId, fieldOptionPost, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new field option Creates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FieldOption)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldOption>> CreateFieldOptionWithHttpInfoAsync (int listId, int fieldId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->CreateFieldOption");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->CreateFieldOption");
            // verify the required parameter 'fieldOptionPost' is set
            if (fieldOptionPost == null)
                throw new ApiException(400, "Missing required parameter 'fieldOptionPost' when calling FieldsApi->CreateFieldOption");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (fieldOptionPost != null && fieldOptionPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fieldOptionPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fieldOptionPost; // byte array
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
                Exception exception = ExceptionFactory("CreateFieldOption", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldOption>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FieldOption) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldOption)));
        }

        /// <summary>
        /// Remove extra field Removes an extra field given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns></returns>
        public void DeleteExtraField (int listId, int fieldId)
        {
             DeleteExtraFieldWithHttpInfo(listId, fieldId);
        }

        /// <summary>
        /// Remove extra field Removes an extra field given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteExtraFieldWithHttpInfo (int listId, int fieldId)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->DeleteExtraField");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->DeleteExtraField");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteExtraField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Remove extra field Removes an extra field given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteExtraFieldAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteExtraFieldWithHttpInfoAsync(listId, fieldId, cancellationToken);

        }

        /// <summary>
        /// Remove extra field Removes an extra field given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteExtraFieldWithHttpInfoAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->DeleteExtraField");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->DeleteExtraField");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteExtraField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Deletes an option Deletes an option of a list of values field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <returns></returns>
        public void DeleteFieldOption (int listId, int fieldId, int optionId)
        {
             DeleteFieldOptionWithHttpInfo(listId, fieldId, optionId);
        }

        /// <summary>
        /// Deletes an option Deletes an option of a list of values field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteFieldOptionWithHttpInfo (int listId, int fieldId, int optionId)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->DeleteFieldOption");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->DeleteFieldOption");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling FieldsApi->DeleteFieldOption");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options/{option_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteFieldOption", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Deletes an option Deletes an option of a list of values field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteFieldOptionAsync (int listId, int fieldId, int optionId, CancellationToken cancellationToken = default(CancellationToken))
        {
             await DeleteFieldOptionWithHttpInfoAsync(listId, fieldId, optionId, cancellationToken);

        }

        /// <summary>
        /// Deletes an option Deletes an option of a list of values field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteFieldOptionWithHttpInfoAsync (int listId, int fieldId, int optionId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->DeleteFieldOption");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->DeleteFieldOption");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling FieldsApi->DeleteFieldOption");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options/{option_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter

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
                Exception exception = ExceptionFactory("DeleteFieldOption", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get all field options Returns all options of a given field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns>FieldOptionsCollection</returns>
        public FieldOptionsCollection GetAllFieldOptions (int listId, int fieldId)
        {
             ApiResponse<FieldOptionsCollection> localVarResponse = GetAllFieldOptionsWithHttpInfo(listId, fieldId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all field options Returns all options of a given field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <returns>ApiResponse of FieldOptionsCollection</returns>
        public ApiResponse<FieldOptionsCollection> GetAllFieldOptionsWithHttpInfo (int listId, int fieldId)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->GetAllFieldOptions");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->GetAllFieldOptions");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAllFieldOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldOptionsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FieldOptionsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldOptionsCollection)));
        }

        /// <summary>
        /// Get all field options Returns all options of a given field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FieldOptionsCollection</returns>
        public async System.Threading.Tasks.Task<FieldOptionsCollection> GetAllFieldOptionsAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FieldOptionsCollection> localVarResponse = await GetAllFieldOptionsWithHttpInfoAsync(listId, fieldId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all field options Returns all options of a given field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FieldOptionsCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldOptionsCollection>> GetAllFieldOptionsWithHttpInfoAsync (int listId, int fieldId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->GetAllFieldOptions");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->GetAllFieldOptions");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAllFieldOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldOptionsCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FieldOptionsCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldOptionsCollection)));
        }

        /// <summary>
        /// Get all fields Returns all fields
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>List&lt;ComplexField&gt;</returns>
        public List<ComplexField> GetAllFields (int listId, int? offset = default(int?), int? limit = default(int?))
        {
             ApiResponse<List<ComplexField>> localVarResponse = GetAllFieldsWithHttpInfo(listId, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all fields Returns all fields
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <returns>ApiResponse of List&lt;ComplexField&gt;</returns>
        public ApiResponse<List<ComplexField>> GetAllFieldsWithHttpInfo (int listId, int? offset = default(int?), int? limit = default(int?))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->GetAllFields");

            var localVarPath = "/lists/{list_id}/fields";
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
                Exception exception = ExceptionFactory("GetAllFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ComplexField>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ComplexField>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ComplexField>)));
        }

        /// <summary>
        /// Get all fields Returns all fields
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of List&lt;ComplexField&gt;</returns>
        public async System.Threading.Tasks.Task<List<ComplexField>> GetAllFieldsAsync (int listId, int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<List<ComplexField>> localVarResponse = await GetAllFieldsWithHttpInfoAsync(listId, offset, limit, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all fields Returns all fields
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (List&lt;ComplexField&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ComplexField>>> GetAllFieldsWithHttpInfoAsync (int listId, int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->GetAllFields");

            var localVarPath = "/lists/{list_id}/fields";
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
                Exception exception = ExceptionFactory("GetAllFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ComplexField>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ComplexField>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ComplexField>)));
        }

        /// <summary>
        /// Update base field Updates a base field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <returns>Field</returns>
        public Field PatchBaseField (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField)
        {
             ApiResponse<Field> localVarResponse = PatchBaseFieldWithHttpInfo(listId, fieldId, patchRequestBaseField);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update base field Updates a base field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <returns>ApiResponse of Field</returns>
        public ApiResponse<Field> PatchBaseFieldWithHttpInfo (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->PatchBaseField");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->PatchBaseField");
            // verify the required parameter 'patchRequestBaseField' is set
            if (patchRequestBaseField == null)
                throw new ApiException(400, "Missing required parameter 'patchRequestBaseField' when calling FieldsApi->PatchBaseField");

            var localVarPath = "/lists/{list_id}/fields/base/{field_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (patchRequestBaseField != null && patchRequestBaseField.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(patchRequestBaseField); // http body (model) parameter
            }
            else
            {
                localVarPostBody = patchRequestBaseField; // byte array
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
                Exception exception = ExceptionFactory("PatchBaseField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Field>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Field) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Field)));
        }

        /// <summary>
        /// Update base field Updates a base field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Field</returns>
        public async System.Threading.Tasks.Task<Field> PatchBaseFieldAsync (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Field> localVarResponse = await PatchBaseFieldWithHttpInfoAsync(listId, fieldId, patchRequestBaseField, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update base field Updates a base field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the base field</param>
        /// <param name="patchRequestBaseField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Field)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Field>> PatchBaseFieldWithHttpInfoAsync (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->PatchBaseField");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->PatchBaseField");
            // verify the required parameter 'patchRequestBaseField' is set
            if (patchRequestBaseField == null)
                throw new ApiException(400, "Missing required parameter 'patchRequestBaseField' when calling FieldsApi->PatchBaseField");

            var localVarPath = "/lists/{list_id}/fields/base/{field_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (patchRequestBaseField != null && patchRequestBaseField.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(patchRequestBaseField); // http body (model) parameter
            }
            else
            {
                localVarPostBody = patchRequestBaseField; // byte array
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
                Exception exception = ExceptionFactory("PatchBaseField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Field>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Field) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Field)));
        }

        /// <summary>
        /// Update extra field Updates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <returns>Field</returns>
        public Field PatchExtraField (int listId, int fieldId, PatchRequestField patchRequestField)
        {
             ApiResponse<Field> localVarResponse = PatchExtraFieldWithHttpInfo(listId, fieldId, patchRequestField);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update extra field Updates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <returns>ApiResponse of Field</returns>
        public ApiResponse<Field> PatchExtraFieldWithHttpInfo (int listId, int fieldId, PatchRequestField patchRequestField)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->PatchExtraField");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->PatchExtraField");
            // verify the required parameter 'patchRequestField' is set
            if (patchRequestField == null)
                throw new ApiException(400, "Missing required parameter 'patchRequestField' when calling FieldsApi->PatchExtraField");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (patchRequestField != null && patchRequestField.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(patchRequestField); // http body (model) parameter
            }
            else
            {
                localVarPostBody = patchRequestField; // byte array
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
                Exception exception = ExceptionFactory("PatchExtraField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Field>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Field) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Field)));
        }

        /// <summary>
        /// Update extra field Updates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Field</returns>
        public async System.Threading.Tasks.Task<Field> PatchExtraFieldAsync (int listId, int fieldId, PatchRequestField patchRequestField, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Field> localVarResponse = await PatchExtraFieldWithHttpInfoAsync(listId, fieldId, patchRequestField, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update extra field Updates an extra field
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="patchRequestField">Parameters for the extra field</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Field)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Field>> PatchExtraFieldWithHttpInfoAsync (int listId, int fieldId, PatchRequestField patchRequestField, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->PatchExtraField");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->PatchExtraField");
            // verify the required parameter 'patchRequestField' is set
            if (patchRequestField == null)
                throw new ApiException(400, "Missing required parameter 'patchRequestField' when calling FieldsApi->PatchExtraField");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (patchRequestField != null && patchRequestField.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(patchRequestField); // http body (model) parameter
            }
            else
            {
                localVarPostBody = patchRequestField; // byte array
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
                Exception exception = ExceptionFactory("PatchExtraField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Field>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Field) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Field)));
        }

        /// <summary>
        /// Update field option Updates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>FieldOption</returns>
        public FieldOption UpdateFieldOption (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost)
        {
             ApiResponse<FieldOption> localVarResponse = UpdateFieldOptionWithHttpInfo(listId, fieldId, optionId, fieldOptionPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update field option Updates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <returns>ApiResponse of FieldOption</returns>
        public ApiResponse<FieldOption> UpdateFieldOptionWithHttpInfo (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->UpdateFieldOption");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->UpdateFieldOption");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling FieldsApi->UpdateFieldOption");
            // verify the required parameter 'fieldOptionPost' is set
            if (fieldOptionPost == null)
                throw new ApiException(400, "Missing required parameter 'fieldOptionPost' when calling FieldsApi->UpdateFieldOption");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options/{option_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (fieldOptionPost != null && fieldOptionPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fieldOptionPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fieldOptionPost; // byte array
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
                Exception exception = ExceptionFactory("UpdateFieldOption", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldOption>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FieldOption) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldOption)));
        }

        /// <summary>
        /// Update field option Updates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FieldOption</returns>
        public async System.Threading.Tasks.Task<FieldOption> UpdateFieldOptionAsync (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FieldOption> localVarResponse = await UpdateFieldOptionWithHttpInfoAsync(listId, fieldId, optionId, fieldOptionPost, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update field option Updates a field option
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="fieldId">ID of the Field</param>
        /// <param name="optionId">ID of the field option</param>
        /// <param name="fieldOptionPost">Parameters for the field option</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FieldOption)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldOption>> UpdateFieldOptionWithHttpInfoAsync (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling FieldsApi->UpdateFieldOption");
            // verify the required parameter 'fieldId' is set
            if (fieldId == null)
                throw new ApiException(400, "Missing required parameter 'fieldId' when calling FieldsApi->UpdateFieldOption");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling FieldsApi->UpdateFieldOption");
            // verify the required parameter 'fieldOptionPost' is set
            if (fieldOptionPost == null)
                throw new ApiException(400, "Missing required parameter 'fieldOptionPost' when calling FieldsApi->UpdateFieldOption");

            var localVarPath = "/lists/{list_id}/fields/extra/{field_id}/options/{option_id}";
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
            if (fieldId != null) localVarPathParams.Add("field_id", this.Configuration.ApiClient.ParameterToString(fieldId)); // path parameter
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (fieldOptionPost != null && fieldOptionPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(fieldOptionPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = fieldOptionPost; // byte array
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
                Exception exception = ExceptionFactory("UpdateFieldOption", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldOption>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FieldOption) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FieldOption)));
        }

    }
}
