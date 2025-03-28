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
    public interface IContactsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Activate contacts
        /// </summary>
        /// <remarks>
        /// Activates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionActivateContacts (int listId, ActivateContactsRequest activateContactsRequest);

        /// <summary>
        /// Activate contacts
        /// </summary>
        /// <remarks>
        /// Activates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionActivateContactsWithHttpInfo (int listId, ActivateContactsRequest activateContactsRequest);
        /// <summary>
        /// Attach tag to contact
        /// </summary>
        /// <remarks>
        /// Attaches a tag to the provided contacts.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionAttachTag (int listId, AttachTagRequest attachTagRequest);

        /// <summary>
        /// Attach tag to contact
        /// </summary>
        /// <remarks>
        /// Attaches a tag to the provided contacts.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionAttachTagWithHttpInfo (int listId, AttachTagRequest attachTagRequest);
        /// <summary>
        /// Deactivate contacts
        /// </summary>
        /// <remarks>
        /// Deactivates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionDeactivateContacts (int listId, DeactivateContactsRequest deactivateContactsRequest);

        /// <summary>
        /// Deactivate contacts
        /// </summary>
        /// <remarks>
        /// Deactivates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionDeactivateContactsWithHttpInfo (int listId, DeactivateContactsRequest deactivateContactsRequest);
        /// <summary>
        /// Detach tag to contact
        /// </summary>
        /// <remarks>
        /// Detach a tag to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionDetachTag (int listId, DetachTagRequest detachTagRequest);

        /// <summary>
        /// Detach tag to contact
        /// </summary>
        /// <remarks>
        /// Detach a tag to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionDetachTagWithHttpInfo (int listId, DetachTagRequest detachTagRequest);
        /// <summary>
        /// Exports a list of contacts
        /// </summary>
        /// <remarks>
        /// Exports a list of contacts to the desired callback url
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionExportContacts (int listId, ContactExportRequest contactExportRequest);

        /// <summary>
        /// Exports a list of contacts
        /// </summary>
        /// <remarks>
        /// Exports a list of contacts to the desired callback url
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionExportContactsWithHttpInfo (int listId, ContactExportRequest contactExportRequest);
        /// <summary>
        /// Forget contacts
        /// </summary>
        /// <remarks>
        /// Forgets a list of contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionForgetContacts (int listId, ContactForgetRequest contactForgetRequest);

        /// <summary>
        /// Forget contacts
        /// </summary>
        /// <remarks>
        /// Forgets a list of contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionForgetContactsWithHttpInfo (int listId, ContactForgetRequest contactForgetRequest);
        /// <summary>
        /// Import collection of contacts
        /// </summary>
        /// <remarks>
        /// Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionImportBulk (int listId, ImportBulkFileRequest importBulkFileRequest);

        /// <summary>
        /// Import collection of contacts
        /// </summary>
        /// <remarks>
        /// Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionImportBulkWithHttpInfo (int listId, ImportBulkFileRequest importBulkFileRequest);
        /// <summary>
        /// Start automation
        /// </summary>
        /// <remarks>
        /// Start automation to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <returns>StartAutomationResponse</returns>
        StartAutomationResponse ActionStartAutomation (int listId, StartAutomationRequest startAutomationRequest);

        /// <summary>
        /// Start automation
        /// </summary>
        /// <remarks>
        /// Start automation to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <returns>ApiResponse of StartAutomationResponse</returns>
        ApiResponse<StartAutomationResponse> ActionStartAutomationWithHttpInfo (int listId, StartAutomationRequest startAutomationRequest);
        /// <summary>
        /// Unsubscribes contacts
        /// </summary>
        /// <remarks>
        /// Unsubscribes contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <returns>RemoveResponse</returns>
        RemoveResponse ActionUnsubscribeContact (int listId, RemoveRequest removeRequest);

        /// <summary>
        /// Unsubscribes contacts
        /// </summary>
        /// <remarks>
        /// Unsubscribes contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <returns>ApiResponse of RemoveResponse</returns>
        ApiResponse<RemoveResponse> ActionUnsubscribeContactWithHttpInfo (int listId, RemoveRequest removeRequest);
        /// <summary>
        /// Updates contacts
        /// </summary>
        /// <remarks>
        /// Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <returns>AcceptedResponse</returns>
        AcceptedResponse ActionUpdateContacts (int listId, UpdateContactsRequest updateContactsRequest);

        /// <summary>
        /// Updates contacts
        /// </summary>
        /// <remarks>
        /// Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        ApiResponse<AcceptedResponse> ActionUpdateContactsWithHttpInfo (int listId, UpdateContactsRequest updateContactsRequest);
        /// <summary>
        /// Create new contact
        /// </summary>
        /// <remarks>
        /// Create a new contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <returns>CreateContactResponse</returns>
        CreateContactResponse CreateContact (int listId, ContactBaseExtraPost contactBaseExtraPost);

        /// <summary>
        /// Create new contact
        /// </summary>
        /// <remarks>
        /// Create a new contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <returns>ApiResponse of CreateContactResponse</returns>
        ApiResponse<CreateContactResponse> CreateContactWithHttpInfo (int listId, ContactBaseExtraPost contactBaseExtraPost);
        /// <summary>
        /// Get all contact activities
        /// </summary>
        /// <remarks>
        /// Returns all contact activities
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <returns>ActivityCollection</returns>
        ActivityCollection GetAllContactActivities (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string));

        /// <summary>
        /// Get all contact activities
        /// </summary>
        /// <remarks>
        /// Returns all contact activities
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <returns>ApiResponse of ActivityCollection</returns>
        ApiResponse<ActivityCollection> GetAllContactActivitiesWithHttpInfo (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string));
        /// <summary>
        /// Get all contacts
        /// </summary>
        /// <remarks>
        /// Returns all contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <returns>ContactCollection</returns>
        ContactCollection GetAllContacts (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId));

        /// <summary>
        /// Get all contacts
        /// </summary>
        /// <remarks>
        /// Returns all contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <returns>ApiResponse of ContactCollection</returns>
        ApiResponse<ContactCollection> GetAllContactsWithHttpInfo (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId));
        /// <summary>
        /// Get all contacts by Segment Id
        /// </summary>
        /// <remarks>
        /// Returns all contacts filtered by Segment Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <returns>ContactCollection</returns>
        ContactCollection GetAllContactsBySegment (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?));

        /// <summary>
        /// Get all contacts by Segment Id
        /// </summary>
        /// <remarks>
        /// Returns all contacts filtered by Segment Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <returns>ApiResponse of ContactCollection</returns>
        ApiResponse<ContactCollection> GetAllContactsBySegmentWithHttpInfo (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?));
        /// <summary>
        /// Get contact
        /// </summary>
        /// <remarks>
        /// Returns contact information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <returns>ComplexContact</returns>
        ComplexContact GetContact (string contactId, int listId);

        /// <summary>
        /// Get contact
        /// </summary>
        /// <remarks>
        /// Returns contact information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <returns>ApiResponse of ComplexContact</returns>
        ApiResponse<ComplexContact> GetContactWithHttpInfo (string contactId, int listId);
        /// <summary>
        /// Update a specific contact
        /// </summary>
        /// <remarks>
        /// Update contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <returns>CreateContactResponse</returns>
        CreateContactResponse PatchContact (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved);

        /// <summary>
        /// Update a specific contact
        /// </summary>
        /// <remarks>
        /// Update contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <returns>ApiResponse of CreateContactResponse</returns>
        ApiResponse<CreateContactResponse> PatchContactWithHttpInfo (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved);
        /// <summary>
        /// Search contact
        /// </summary>
        /// <remarks>
        /// Searches a contact across all lists and returns a collection of contacts found
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 SearchContacts (string contact, string type = default(string));

        /// <summary>
        /// Search contact
        /// </summary>
        /// <remarks>
        /// Searches a contact across all lists and returns a collection of contacts found
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> SearchContactsWithHttpInfo (string contact, string type = default(string));
        /// <summary>
        /// Updates a contact by field
        /// </summary>
        /// <remarks>
        /// Updates a contact by field, wich must be unique in list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <returns>CreateContactResponse</returns>
        CreateContactResponse UpdateContactByField (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost);

        /// <summary>
        /// Updates a contact by field
        /// </summary>
        /// <remarks>
        /// Updates a contact by field, wich must be unique in list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <returns>ApiResponse of CreateContactResponse</returns>
        ApiResponse<CreateContactResponse> UpdateContactByFieldWithHttpInfo (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Activate contacts
        /// </summary>
        /// <remarks>
        /// Activates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionActivateContactsAsync (int listId, ActivateContactsRequest activateContactsRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Activate contacts
        /// </summary>
        /// <remarks>
        /// Activates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionActivateContactsWithHttpInfoAsync (int listId, ActivateContactsRequest activateContactsRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Attach tag to contact
        /// </summary>
        /// <remarks>
        /// Attaches a tag to the provided contacts.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionAttachTagAsync (int listId, AttachTagRequest attachTagRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Attach tag to contact
        /// </summary>
        /// <remarks>
        /// Attaches a tag to the provided contacts.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionAttachTagWithHttpInfoAsync (int listId, AttachTagRequest attachTagRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deactivate contacts
        /// </summary>
        /// <remarks>
        /// Deactivates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionDeactivateContactsAsync (int listId, DeactivateContactsRequest deactivateContactsRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deactivate contacts
        /// </summary>
        /// <remarks>
        /// Deactivates a collection of contacts (does not apply to removed contacts)
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionDeactivateContactsWithHttpInfoAsync (int listId, DeactivateContactsRequest deactivateContactsRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Detach tag to contact
        /// </summary>
        /// <remarks>
        /// Detach a tag to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionDetachTagAsync (int listId, DetachTagRequest detachTagRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Detach tag to contact
        /// </summary>
        /// <remarks>
        /// Detach a tag to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionDetachTagWithHttpInfoAsync (int listId, DetachTagRequest detachTagRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports a list of contacts
        /// </summary>
        /// <remarks>
        /// Exports a list of contacts to the desired callback url
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionExportContactsAsync (int listId, ContactExportRequest contactExportRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Exports a list of contacts
        /// </summary>
        /// <remarks>
        /// Exports a list of contacts to the desired callback url
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionExportContactsWithHttpInfoAsync (int listId, ContactExportRequest contactExportRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Forget contacts
        /// </summary>
        /// <remarks>
        /// Forgets a list of contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionForgetContactsAsync (int listId, ContactForgetRequest contactForgetRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Forget contacts
        /// </summary>
        /// <remarks>
        /// Forgets a list of contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionForgetContactsWithHttpInfoAsync (int listId, ContactForgetRequest contactForgetRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Import collection of contacts
        /// </summary>
        /// <remarks>
        /// Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionImportBulkAsync (int listId, ImportBulkFileRequest importBulkFileRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Import collection of contacts
        /// </summary>
        /// <remarks>
        /// Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionImportBulkWithHttpInfoAsync (int listId, ImportBulkFileRequest importBulkFileRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start automation
        /// </summary>
        /// <remarks>
        /// Start automation to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of StartAutomationResponse</returns>
        System.Threading.Tasks.Task<StartAutomationResponse> ActionStartAutomationAsync (int listId, StartAutomationRequest startAutomationRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Start automation
        /// </summary>
        /// <remarks>
        /// Start automation to the provided contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (StartAutomationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StartAutomationResponse>> ActionStartAutomationWithHttpInfoAsync (int listId, StartAutomationRequest startAutomationRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unsubscribes contacts
        /// </summary>
        /// <remarks>
        /// Unsubscribes contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of RemoveResponse</returns>
        System.Threading.Tasks.Task<RemoveResponse> ActionUnsubscribeContactAsync (int listId, RemoveRequest removeRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unsubscribes contacts
        /// </summary>
        /// <remarks>
        /// Unsubscribes contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (RemoveResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RemoveResponse>> ActionUnsubscribeContactWithHttpInfoAsync (int listId, RemoveRequest removeRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates contacts
        /// </summary>
        /// <remarks>
        /// Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        System.Threading.Tasks.Task<AcceptedResponse> ActionUpdateContactsAsync (int listId, UpdateContactsRequest updateContactsRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates contacts
        /// </summary>
        /// <remarks>
        /// Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionUpdateContactsWithHttpInfoAsync (int listId, UpdateContactsRequest updateContactsRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create new contact
        /// </summary>
        /// <remarks>
        /// Create a new contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CreateContactResponse</returns>
        System.Threading.Tasks.Task<CreateContactResponse> CreateContactAsync (int listId, ContactBaseExtraPost contactBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create new contact
        /// </summary>
        /// <remarks>
        /// Create a new contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CreateContactResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateContactResponse>> CreateContactWithHttpInfoAsync (int listId, ContactBaseExtraPost contactBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all contact activities
        /// </summary>
        /// <remarks>
        /// Returns all contact activities
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ActivityCollection</returns>
        System.Threading.Tasks.Task<ActivityCollection> GetAllContactActivitiesAsync (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all contact activities
        /// </summary>
        /// <remarks>
        /// Returns all contact activities
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ActivityCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<ActivityCollection>> GetAllContactActivitiesWithHttpInfoAsync (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all contacts
        /// </summary>
        /// <remarks>
        /// Returns all contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ContactCollection</returns>
        System.Threading.Tasks.Task<ContactCollection> GetAllContactsAsync (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all contacts
        /// </summary>
        /// <remarks>
        /// Returns all contacts
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ContactCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactCollection>> GetAllContactsWithHttpInfoAsync (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all contacts by Segment Id
        /// </summary>
        /// <remarks>
        /// Returns all contacts filtered by Segment Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ContactCollection</returns>
        System.Threading.Tasks.Task<ContactCollection> GetAllContactsBySegmentAsync (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get all contacts by Segment Id
        /// </summary>
        /// <remarks>
        /// Returns all contacts filtered by Segment Id
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ContactCollection)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContactCollection>> GetAllContactsBySegmentWithHttpInfoAsync (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get contact
        /// </summary>
        /// <remarks>
        /// Returns contact information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ComplexContact</returns>
        System.Threading.Tasks.Task<ComplexContact> GetContactAsync (string contactId, int listId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get contact
        /// </summary>
        /// <remarks>
        /// Returns contact information given its ID
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ComplexContact)</returns>
        System.Threading.Tasks.Task<ApiResponse<ComplexContact>> GetContactWithHttpInfoAsync (string contactId, int listId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a specific contact
        /// </summary>
        /// <remarks>
        /// Update contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CreateContactResponse</returns>
        System.Threading.Tasks.Task<CreateContactResponse> PatchContactAsync (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update a specific contact
        /// </summary>
        /// <remarks>
        /// Update contact
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CreateContactResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateContactResponse>> PatchContactWithHttpInfoAsync (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Search contact
        /// </summary>
        /// <remarks>
        /// Searches a contact across all lists and returns a collection of contacts found
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> SearchContactsAsync (string contact, string type = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search contact
        /// </summary>
        /// <remarks>
        /// Searches a contact across all lists and returns a collection of contacts found
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> SearchContactsWithHttpInfoAsync (string contact, string type = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a contact by field
        /// </summary>
        /// <remarks>
        /// Updates a contact by field, wich must be unique in list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CreateContactResponse</returns>
        System.Threading.Tasks.Task<CreateContactResponse> UpdateContactByFieldAsync (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates a contact by field
        /// </summary>
        /// <remarks>
        /// Updates a contact by field, wich must be unique in list
        /// </remarks>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CreateContactResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateContactResponse>> UpdateContactByFieldWithHttpInfoAsync (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ContactsApi : IContactsApi
    {
        private org.egoi.client.api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContactsApi(String basePath)
        {
            this.Configuration = new org.egoi.client.api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class
        /// </summary>
        /// <returns></returns>
        public ContactsApi()
        {
            this.Configuration = org.egoi.client.api.Client.Configuration.Default;

            ExceptionFactory = org.egoi.client.api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContactsApi(org.egoi.client.api.Client.Configuration configuration = null)
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
        /// Activate contacts Activates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionActivateContacts (int listId, ActivateContactsRequest activateContactsRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionActivateContactsWithHttpInfo(listId, activateContactsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activate contacts Activates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionActivateContactsWithHttpInfo (int listId, ActivateContactsRequest activateContactsRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionActivateContacts");
            // verify the required parameter 'activateContactsRequest' is set
            if (activateContactsRequest == null)
                throw new ApiException(400, "Missing required parameter 'activateContactsRequest' when calling ContactsApi->ActionActivateContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/activate";
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
            if (activateContactsRequest != null && activateContactsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(activateContactsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = activateContactsRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionActivateContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Activate contacts Activates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionActivateContactsAsync (int listId, ActivateContactsRequest activateContactsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionActivateContactsWithHttpInfoAsync(listId, activateContactsRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activate contacts Activates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="activateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionActivateContactsWithHttpInfoAsync (int listId, ActivateContactsRequest activateContactsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionActivateContacts");
            // verify the required parameter 'activateContactsRequest' is set
            if (activateContactsRequest == null)
                throw new ApiException(400, "Missing required parameter 'activateContactsRequest' when calling ContactsApi->ActionActivateContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/activate";
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
            if (activateContactsRequest != null && activateContactsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(activateContactsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = activateContactsRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionActivateContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Attach tag to contact Attaches a tag to the provided contacts.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionAttachTag (int listId, AttachTagRequest attachTagRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionAttachTagWithHttpInfo(listId, attachTagRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attach tag to contact Attaches a tag to the provided contacts.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionAttachTagWithHttpInfo (int listId, AttachTagRequest attachTagRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionAttachTag");
            // verify the required parameter 'attachTagRequest' is set
            if (attachTagRequest == null)
                throw new ApiException(400, "Missing required parameter 'attachTagRequest' when calling ContactsApi->ActionAttachTag");

            var localVarPath = "/lists/{list_id}/contacts/actions/attach-tag";
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
            if (attachTagRequest != null && attachTagRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(attachTagRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = attachTagRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionAttachTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Attach tag to contact Attaches a tag to the provided contacts.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionAttachTagAsync (int listId, AttachTagRequest attachTagRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionAttachTagWithHttpInfoAsync(listId, attachTagRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Attach tag to contact Attaches a tag to the provided contacts.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="attachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionAttachTagWithHttpInfoAsync (int listId, AttachTagRequest attachTagRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionAttachTag");
            // verify the required parameter 'attachTagRequest' is set
            if (attachTagRequest == null)
                throw new ApiException(400, "Missing required parameter 'attachTagRequest' when calling ContactsApi->ActionAttachTag");

            var localVarPath = "/lists/{list_id}/contacts/actions/attach-tag";
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
            if (attachTagRequest != null && attachTagRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(attachTagRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = attachTagRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionAttachTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Deactivate contacts Deactivates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionDeactivateContacts (int listId, DeactivateContactsRequest deactivateContactsRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionDeactivateContactsWithHttpInfo(listId, deactivateContactsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivate contacts Deactivates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionDeactivateContactsWithHttpInfo (int listId, DeactivateContactsRequest deactivateContactsRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionDeactivateContacts");
            // verify the required parameter 'deactivateContactsRequest' is set
            if (deactivateContactsRequest == null)
                throw new ApiException(400, "Missing required parameter 'deactivateContactsRequest' when calling ContactsApi->ActionDeactivateContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/deactivate";
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
            if (deactivateContactsRequest != null && deactivateContactsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(deactivateContactsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deactivateContactsRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionDeactivateContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Deactivate contacts Deactivates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionDeactivateContactsAsync (int listId, DeactivateContactsRequest deactivateContactsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionDeactivateContactsWithHttpInfoAsync(listId, deactivateContactsRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivate contacts Deactivates a collection of contacts (does not apply to removed contacts)
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="deactivateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionDeactivateContactsWithHttpInfoAsync (int listId, DeactivateContactsRequest deactivateContactsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionDeactivateContacts");
            // verify the required parameter 'deactivateContactsRequest' is set
            if (deactivateContactsRequest == null)
                throw new ApiException(400, "Missing required parameter 'deactivateContactsRequest' when calling ContactsApi->ActionDeactivateContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/deactivate";
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
            if (deactivateContactsRequest != null && deactivateContactsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(deactivateContactsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deactivateContactsRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionDeactivateContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Detach tag to contact Detach a tag to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionDetachTag (int listId, DetachTagRequest detachTagRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionDetachTagWithHttpInfo(listId, detachTagRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Detach tag to contact Detach a tag to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionDetachTagWithHttpInfo (int listId, DetachTagRequest detachTagRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionDetachTag");
            // verify the required parameter 'detachTagRequest' is set
            if (detachTagRequest == null)
                throw new ApiException(400, "Missing required parameter 'detachTagRequest' when calling ContactsApi->ActionDetachTag");

            var localVarPath = "/lists/{list_id}/contacts/actions/detach-tag";
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
            if (detachTagRequest != null && detachTagRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detachTagRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detachTagRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionDetachTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Detach tag to contact Detach a tag to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionDetachTagAsync (int listId, DetachTagRequest detachTagRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionDetachTagWithHttpInfoAsync(listId, detachTagRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Detach tag to contact Detach a tag to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="detachTagRequest">Parameters for the Tag</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionDetachTagWithHttpInfoAsync (int listId, DetachTagRequest detachTagRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionDetachTag");
            // verify the required parameter 'detachTagRequest' is set
            if (detachTagRequest == null)
                throw new ApiException(400, "Missing required parameter 'detachTagRequest' when calling ContactsApi->ActionDetachTag");

            var localVarPath = "/lists/{list_id}/contacts/actions/detach-tag";
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
            if (detachTagRequest != null && detachTagRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(detachTagRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = detachTagRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionDetachTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Exports a list of contacts Exports a list of contacts to the desired callback url
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionExportContacts (int listId, ContactExportRequest contactExportRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionExportContactsWithHttpInfo(listId, contactExportRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Exports a list of contacts Exports a list of contacts to the desired callback url
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionExportContactsWithHttpInfo (int listId, ContactExportRequest contactExportRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionExportContacts");
            // verify the required parameter 'contactExportRequest' is set
            if (contactExportRequest == null)
                throw new ApiException(400, "Missing required parameter 'contactExportRequest' when calling ContactsApi->ActionExportContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/export";
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
            if (contactExportRequest != null && contactExportRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactExportRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactExportRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionExportContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Exports a list of contacts Exports a list of contacts to the desired callback url
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionExportContactsAsync (int listId, ContactExportRequest contactExportRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionExportContactsWithHttpInfoAsync(listId, contactExportRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Exports a list of contacts Exports a list of contacts to the desired callback url
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactExportRequest">Parameters for export</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionExportContactsWithHttpInfoAsync (int listId, ContactExportRequest contactExportRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionExportContacts");
            // verify the required parameter 'contactExportRequest' is set
            if (contactExportRequest == null)
                throw new ApiException(400, "Missing required parameter 'contactExportRequest' when calling ContactsApi->ActionExportContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/export";
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
            if (contactExportRequest != null && contactExportRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactExportRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactExportRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionExportContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Forget contacts Forgets a list of contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionForgetContacts (int listId, ContactForgetRequest contactForgetRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionForgetContactsWithHttpInfo(listId, contactForgetRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Forget contacts Forgets a list of contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionForgetContactsWithHttpInfo (int listId, ContactForgetRequest contactForgetRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionForgetContacts");
            // verify the required parameter 'contactForgetRequest' is set
            if (contactForgetRequest == null)
                throw new ApiException(400, "Missing required parameter 'contactForgetRequest' when calling ContactsApi->ActionForgetContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/forget";
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
            if (contactForgetRequest != null && contactForgetRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactForgetRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactForgetRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionForgetContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Forget contacts Forgets a list of contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionForgetContactsAsync (int listId, ContactForgetRequest contactForgetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionForgetContactsWithHttpInfoAsync(listId, contactForgetRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Forget contacts Forgets a list of contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactForgetRequest">Parameters for the action</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionForgetContactsWithHttpInfoAsync (int listId, ContactForgetRequest contactForgetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionForgetContacts");
            // verify the required parameter 'contactForgetRequest' is set
            if (contactForgetRequest == null)
                throw new ApiException(400, "Missing required parameter 'contactForgetRequest' when calling ContactsApi->ActionForgetContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/forget";
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
            if (contactForgetRequest != null && contactForgetRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactForgetRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactForgetRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionForgetContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Import collection of contacts Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionImportBulk (int listId, ImportBulkFileRequest importBulkFileRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionImportBulkWithHttpInfo(listId, importBulkFileRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Import collection of contacts Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionImportBulkWithHttpInfo (int listId, ImportBulkFileRequest importBulkFileRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionImportBulk");
            // verify the required parameter 'importBulkFileRequest' is set
            if (importBulkFileRequest == null)
                throw new ApiException(400, "Missing required parameter 'importBulkFileRequest' when calling ContactsApi->ActionImportBulk");

            var localVarPath = "/lists/{list_id}/contacts/actions/import-bulk";
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
            if (importBulkFileRequest != null && importBulkFileRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(importBulkFileRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = importBulkFileRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionImportBulk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Import collection of contacts Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionImportBulkAsync (int listId, ImportBulkFileRequest importBulkFileRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionImportBulkWithHttpInfoAsync(listId, importBulkFileRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Import collection of contacts Imports a collection of contacts &lt;/br&gt;      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits &#39;Stream Limits&#39;)&lt;br&gt; ***Notes:***&lt;br&gt;Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact &#39;Create new contact&#39;)&lt;br&gt;It defaults to ***Bulk object*** import.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="importBulkFileRequest">Parameters for the bulk import</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionImportBulkWithHttpInfoAsync (int listId, ImportBulkFileRequest importBulkFileRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionImportBulk");
            // verify the required parameter 'importBulkFileRequest' is set
            if (importBulkFileRequest == null)
                throw new ApiException(400, "Missing required parameter 'importBulkFileRequest' when calling ContactsApi->ActionImportBulk");

            var localVarPath = "/lists/{list_id}/contacts/actions/import-bulk";
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
            if (importBulkFileRequest != null && importBulkFileRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(importBulkFileRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = importBulkFileRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionImportBulk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Start automation Start automation to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <returns>StartAutomationResponse</returns>
        public StartAutomationResponse ActionStartAutomation (int listId, StartAutomationRequest startAutomationRequest)
        {
             ApiResponse<StartAutomationResponse> localVarResponse = ActionStartAutomationWithHttpInfo(listId, startAutomationRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Start automation Start automation to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <returns>ApiResponse of StartAutomationResponse</returns>
        public ApiResponse<StartAutomationResponse> ActionStartAutomationWithHttpInfo (int listId, StartAutomationRequest startAutomationRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionStartAutomation");
            // verify the required parameter 'startAutomationRequest' is set
            if (startAutomationRequest == null)
                throw new ApiException(400, "Missing required parameter 'startAutomationRequest' when calling ContactsApi->ActionStartAutomation");

            var localVarPath = "/lists/{list_id}/contacts/actions/start-automation";
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
            if (startAutomationRequest != null && startAutomationRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(startAutomationRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = startAutomationRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionStartAutomation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StartAutomationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StartAutomationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StartAutomationResponse)));
        }

        /// <summary>
        /// Start automation Start automation to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of StartAutomationResponse</returns>
        public async System.Threading.Tasks.Task<StartAutomationResponse> ActionStartAutomationAsync (int listId, StartAutomationRequest startAutomationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<StartAutomationResponse> localVarResponse = await ActionStartAutomationWithHttpInfoAsync(listId, startAutomationRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Start automation Start automation to the provided contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="startAutomationRequest">Parameters for the operation to start automation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (StartAutomationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StartAutomationResponse>> ActionStartAutomationWithHttpInfoAsync (int listId, StartAutomationRequest startAutomationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionStartAutomation");
            // verify the required parameter 'startAutomationRequest' is set
            if (startAutomationRequest == null)
                throw new ApiException(400, "Missing required parameter 'startAutomationRequest' when calling ContactsApi->ActionStartAutomation");

            var localVarPath = "/lists/{list_id}/contacts/actions/start-automation";
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
            if (startAutomationRequest != null && startAutomationRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(startAutomationRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = startAutomationRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionStartAutomation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StartAutomationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (StartAutomationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StartAutomationResponse)));
        }

        /// <summary>
        /// Unsubscribes contacts Unsubscribes contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <returns>RemoveResponse</returns>
        public RemoveResponse ActionUnsubscribeContact (int listId, RemoveRequest removeRequest)
        {
             ApiResponse<RemoveResponse> localVarResponse = ActionUnsubscribeContactWithHttpInfo(listId, removeRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unsubscribes contacts Unsubscribes contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <returns>ApiResponse of RemoveResponse</returns>
        public ApiResponse<RemoveResponse> ActionUnsubscribeContactWithHttpInfo (int listId, RemoveRequest removeRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionUnsubscribeContact");
            // verify the required parameter 'removeRequest' is set
            if (removeRequest == null)
                throw new ApiException(400, "Missing required parameter 'removeRequest' when calling ContactsApi->ActionUnsubscribeContact");

            var localVarPath = "/lists/{list_id}/contacts/actions/unsubscribe";
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
            if (removeRequest != null && removeRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(removeRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = removeRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionUnsubscribeContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RemoveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (RemoveResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RemoveResponse)));
        }

        /// <summary>
        /// Unsubscribes contacts Unsubscribes contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of RemoveResponse</returns>
        public async System.Threading.Tasks.Task<RemoveResponse> ActionUnsubscribeContactAsync (int listId, RemoveRequest removeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<RemoveResponse> localVarResponse = await ActionUnsubscribeContactWithHttpInfoAsync(listId, removeRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unsubscribes contacts Unsubscribes contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="removeRequest">Parameters for the contact to unsubscribe</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (RemoveResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RemoveResponse>> ActionUnsubscribeContactWithHttpInfoAsync (int listId, RemoveRequest removeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionUnsubscribeContact");
            // verify the required parameter 'removeRequest' is set
            if (removeRequest == null)
                throw new ApiException(400, "Missing required parameter 'removeRequest' when calling ContactsApi->ActionUnsubscribeContact");

            var localVarPath = "/lists/{list_id}/contacts/actions/unsubscribe";
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
            if (removeRequest != null && removeRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(removeRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = removeRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionUnsubscribeContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RemoveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (RemoveResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(RemoveResponse)));
        }

        /// <summary>
        /// Updates contacts Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <returns>AcceptedResponse</returns>
        public AcceptedResponse ActionUpdateContacts (int listId, UpdateContactsRequest updateContactsRequest)
        {
             ApiResponse<AcceptedResponse> localVarResponse = ActionUpdateContactsWithHttpInfo(listId, updateContactsRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates contacts Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <returns>ApiResponse of AcceptedResponse</returns>
        public ApiResponse<AcceptedResponse> ActionUpdateContactsWithHttpInfo (int listId, UpdateContactsRequest updateContactsRequest)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionUpdateContacts");
            // verify the required parameter 'updateContactsRequest' is set
            if (updateContactsRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateContactsRequest' when calling ContactsApi->ActionUpdateContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/update";
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
            if (updateContactsRequest != null && updateContactsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updateContactsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateContactsRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionUpdateContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Updates contacts Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of AcceptedResponse</returns>
        public async System.Threading.Tasks.Task<AcceptedResponse> ActionUpdateContactsAsync (int listId, UpdateContactsRequest updateContactsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<AcceptedResponse> localVarResponse = await ActionUpdateContactsWithHttpInfoAsync(listId, updateContactsRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates contacts Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="updateContactsRequest">Parameters for the request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (AcceptedResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AcceptedResponse>> ActionUpdateContactsWithHttpInfoAsync (int listId, UpdateContactsRequest updateContactsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->ActionUpdateContacts");
            // verify the required parameter 'updateContactsRequest' is set
            if (updateContactsRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateContactsRequest' when calling ContactsApi->ActionUpdateContacts");

            var localVarPath = "/lists/{list_id}/contacts/actions/update";
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
            if (updateContactsRequest != null && updateContactsRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updateContactsRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updateContactsRequest; // byte array
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
                Exception exception = ExceptionFactory("ActionUpdateContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AcceptedResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AcceptedResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AcceptedResponse)));
        }

        /// <summary>
        /// Create new contact Create a new contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <returns>CreateContactResponse</returns>
        public CreateContactResponse CreateContact (int listId, ContactBaseExtraPost contactBaseExtraPost)
        {
             ApiResponse<CreateContactResponse> localVarResponse = CreateContactWithHttpInfo(listId, contactBaseExtraPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new contact Create a new contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <returns>ApiResponse of CreateContactResponse</returns>
        public ApiResponse<CreateContactResponse> CreateContactWithHttpInfo (int listId, ContactBaseExtraPost contactBaseExtraPost)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->CreateContact");
            // verify the required parameter 'contactBaseExtraPost' is set
            if (contactBaseExtraPost == null)
                throw new ApiException(400, "Missing required parameter 'contactBaseExtraPost' when calling ContactsApi->CreateContact");

            var localVarPath = "/lists/{list_id}/contacts";
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
            if (contactBaseExtraPost != null && contactBaseExtraPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactBaseExtraPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactBaseExtraPost; // byte array
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
                Exception exception = ExceptionFactory("CreateContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContactResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CreateContactResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContactResponse)));
        }

        /// <summary>
        /// Create new contact Create a new contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CreateContactResponse</returns>
        public async System.Threading.Tasks.Task<CreateContactResponse> CreateContactAsync (int listId, ContactBaseExtraPost contactBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CreateContactResponse> localVarResponse = await CreateContactWithHttpInfoAsync(listId, contactBaseExtraPost, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new contact Create a new contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactBaseExtraPost">Parameters for the Contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CreateContactResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateContactResponse>> CreateContactWithHttpInfoAsync (int listId, ContactBaseExtraPost contactBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->CreateContact");
            // verify the required parameter 'contactBaseExtraPost' is set
            if (contactBaseExtraPost == null)
                throw new ApiException(400, "Missing required parameter 'contactBaseExtraPost' when calling ContactsApi->CreateContact");

            var localVarPath = "/lists/{list_id}/contacts";
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
            if (contactBaseExtraPost != null && contactBaseExtraPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactBaseExtraPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactBaseExtraPost; // byte array
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
                Exception exception = ExceptionFactory("CreateContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContactResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CreateContactResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContactResponse)));
        }

        /// <summary>
        /// Get all contact activities Returns all contact activities
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <returns>ActivityCollection</returns>
        public ActivityCollection GetAllContactActivities (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string))
        {
             ApiResponse<ActivityCollection> localVarResponse = GetAllContactActivitiesWithHttpInfo(contactId, listId, offset, limit, dateMin, dateMax, actionName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all contact activities Returns all contact activities
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <returns>ApiResponse of ActivityCollection</returns>
        public ApiResponse<ActivityCollection> GetAllContactActivitiesWithHttpInfo (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string))
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ContactsApi->GetAllContactActivities");
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetAllContactActivities");

            var localVarPath = "/lists/{list_id}/contacts/{contact_id}/activities";
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

            if (contactId != null) localVarPathParams.Add("contact_id", this.Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (dateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_min", dateMin)); // query parameter
            if (dateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_max", dateMax)); // query parameter
            if (actionName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "action_name", actionName)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllContactActivities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ActivityCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ActivityCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCollection)));
        }

        /// <summary>
        /// Get all contact activities Returns all contact activities
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ActivityCollection</returns>
        public async System.Threading.Tasks.Task<ActivityCollection> GetAllContactActivitiesAsync (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ActivityCollection> localVarResponse = await GetAllContactActivitiesWithHttpInfoAsync(contactId, listId, offset, limit, dateMin, dateMax, actionName, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all contact activities Returns all contact activities
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="dateMin">Start date (optional)</param>
        /// <param name="dateMax">End date (optional)</param>
        /// <param name="actionName">Action data to return (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ActivityCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ActivityCollection>> GetAllContactActivitiesWithHttpInfoAsync (string contactId, int listId, int? offset = default(int?), int? limit = default(int?), DateTime? dateMin = default(DateTime?), DateTime? dateMax = default(DateTime?), string actionName = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ContactsApi->GetAllContactActivities");
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetAllContactActivities");

            var localVarPath = "/lists/{list_id}/contacts/{contact_id}/activities";
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

            if (contactId != null) localVarPathParams.Add("contact_id", this.Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (dateMin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_min", dateMin)); // query parameter
            if (dateMax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_max", dateMax)); // query parameter
            if (actionName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "action_name", actionName)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllContactActivities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ActivityCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ActivityCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ActivityCollection)));
        }

        /// <summary>
        /// Get all contacts Returns all contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <returns>ContactCollection</returns>
        public ContactCollection GetAllContacts (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId))
        {
             ApiResponse<ContactCollection> localVarResponse = GetAllContactsWithHttpInfo(listId, offset, limit, firstName, lastName, email, emailStatus, cellphone, cellphoneStatus, phone, phoneStatus, birthDate, language, extraFieldId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all contacts Returns all contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <returns>ApiResponse of ContactCollection</returns>
        public ApiResponse<ContactCollection> GetAllContactsWithHttpInfo (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetAllContacts");

            var localVarPath = "/lists/{list_id}/contacts";
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
            if (firstName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "first_name", firstName)); // query parameter
            if (lastName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "last_name", lastName)); // query parameter
            if (email != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email", email)); // query parameter
            if (emailStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email_status", emailStatus)); // query parameter
            if (cellphone != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "cellphone", cellphone)); // query parameter
            if (cellphoneStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "cellphone_status", cellphoneStatus)); // query parameter
            if (phone != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "phone", phone)); // query parameter
            if (phoneStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "phone_status", phoneStatus)); // query parameter
            if (birthDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "birth_date", birthDate)); // query parameter
            if (language != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (extraFieldId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "extra_field_id", extraFieldId)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ContactCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ContactCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCollection)));
        }

        /// <summary>
        /// Get all contacts Returns all contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ContactCollection</returns>
        public async System.Threading.Tasks.Task<ContactCollection> GetAllContactsAsync (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ContactCollection> localVarResponse = await GetAllContactsWithHttpInfoAsync(listId, offset, limit, firstName, lastName, email, emailStatus, cellphone, cellphoneStatus, phone, phoneStatus, birthDate, language, extraFieldId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all contacts Returns all contacts
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="firstName">First name of the contacts to return (optional)</param>
        /// <param name="lastName">Last name of the contacts to return (optional)</param>
        /// <param name="email">Email of the contacts to return (optional)</param>
        /// <param name="emailStatus">EmailStatus of the contacts to return (optional)</param>
        /// <param name="cellphone">Cellphone of the contacts to return (optional)</param>
        /// <param name="cellphoneStatus">CellphoneStatus of the contacts to return (optional)</param>
        /// <param name="phone">Phone of the contacts to return (optional)</param>
        /// <param name="phoneStatus">PhoneStatus of the contacts to return (optional)</param>
        /// <param name="birthDate">Birth date of the contacts to return (optional)</param>
        /// <param name="language">Language date of the contacts to return (optional)</param>
        /// <param name="extraFieldId">Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ContactCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCollection>> GetAllContactsWithHttpInfoAsync (int listId, int? offset = default(int?), int? limit = default(int?), string firstName = default(string), string lastName = default(string), string email = default(string), bool? emailStatus = default(bool?), string cellphone = default(string), bool? cellphoneStatus = default(bool?), string phone = default(string), bool? phoneStatus = default(bool?), DateTime? birthDate = default(DateTime?), string language = default(string), ExtraFieldId extraFieldId = default(ExtraFieldId), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetAllContacts");

            var localVarPath = "/lists/{list_id}/contacts";
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
            if (firstName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "first_name", firstName)); // query parameter
            if (lastName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "last_name", lastName)); // query parameter
            if (email != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email", email)); // query parameter
            if (emailStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "email_status", emailStatus)); // query parameter
            if (cellphone != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "cellphone", cellphone)); // query parameter
            if (cellphoneStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "cellphone_status", cellphoneStatus)); // query parameter
            if (phone != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "phone", phone)); // query parameter
            if (phoneStatus != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "phone_status", phoneStatus)); // query parameter
            if (birthDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "birth_date", birthDate)); // query parameter
            if (language != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "language", language)); // query parameter
            if (extraFieldId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "extra_field_id", extraFieldId)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ContactCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ContactCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCollection)));
        }

        /// <summary>
        /// Get all contacts by Segment Id Returns all contacts filtered by Segment Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <returns>ContactCollection</returns>
        public ContactCollection GetAllContactsBySegment (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?))
        {
             ApiResponse<ContactCollection> localVarResponse = GetAllContactsBySegmentWithHttpInfo(listId, segmentId, offset, limit, showRemoved);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all contacts by Segment Id Returns all contacts filtered by Segment Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <returns>ApiResponse of ContactCollection</returns>
        public ApiResponse<ContactCollection> GetAllContactsBySegmentWithHttpInfo (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetAllContactsBySegment");
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling ContactsApi->GetAllContactsBySegment");

            var localVarPath = "/lists/{list_id}/contacts/segment/{segment_id}";
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
            if (segmentId != null) localVarPathParams.Add("segment_id", this.Configuration.ApiClient.ParameterToString(segmentId)); // path parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (showRemoved != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "show_removed", showRemoved)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllContactsBySegment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ContactCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ContactCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCollection)));
        }

        /// <summary>
        /// Get all contacts by Segment Id Returns all contacts filtered by Segment Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ContactCollection</returns>
        public async System.Threading.Tasks.Task<ContactCollection> GetAllContactsBySegmentAsync (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ContactCollection> localVarResponse = await GetAllContactsBySegmentWithHttpInfoAsync(listId, segmentId, offset, limit, showRemoved, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all contacts by Segment Id Returns all contacts filtered by Segment Id
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the List</param>
        /// <param name="segmentId">ID of the Segment</param>
        /// <param name="offset">Element offset (starting at zero for the first element) (optional)</param>
        /// <param name="limit">Number of items to return (optional, default to 10)</param>
        /// <param name="showRemoved">Show removed contacts (optional, default to false)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ContactCollection)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContactCollection>> GetAllContactsBySegmentWithHttpInfoAsync (int listId, string segmentId, int? offset = default(int?), int? limit = default(int?), bool? showRemoved = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetAllContactsBySegment");
            // verify the required parameter 'segmentId' is set
            if (segmentId == null)
                throw new ApiException(400, "Missing required parameter 'segmentId' when calling ContactsApi->GetAllContactsBySegment");

            var localVarPath = "/lists/{list_id}/contacts/segment/{segment_id}";
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
            if (segmentId != null) localVarPathParams.Add("segment_id", this.Configuration.ApiClient.ParameterToString(segmentId)); // path parameter
            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (showRemoved != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "show_removed", showRemoved)); // query parameter

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
                Exception exception = ExceptionFactory("GetAllContactsBySegment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ContactCollection>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ContactCollection) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContactCollection)));
        }

        /// <summary>
        /// Get contact Returns contact information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <returns>ComplexContact</returns>
        public ComplexContact GetContact (string contactId, int listId)
        {
             ApiResponse<ComplexContact> localVarResponse = GetContactWithHttpInfo(contactId, listId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get contact Returns contact information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <returns>ApiResponse of ComplexContact</returns>
        public ApiResponse<ComplexContact> GetContactWithHttpInfo (string contactId, int listId)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ContactsApi->GetContact");
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetContact");

            var localVarPath = "/lists/{list_id}/contacts/{contact_id}";
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

            if (contactId != null) localVarPathParams.Add("contact_id", this.Configuration.ApiClient.ParameterToString(contactId)); // path parameter
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
                Exception exception = ExceptionFactory("GetContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComplexContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ComplexContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComplexContact)));
        }

        /// <summary>
        /// Get contact Returns contact information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ComplexContact</returns>
        public async System.Threading.Tasks.Task<ComplexContact> GetContactAsync (string contactId, int listId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ComplexContact> localVarResponse = await GetContactWithHttpInfoAsync(contactId, listId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get contact Returns contact information given its ID
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ComplexContact)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ComplexContact>> GetContactWithHttpInfoAsync (string contactId, int listId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ContactsApi->GetContact");
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->GetContact");

            var localVarPath = "/lists/{list_id}/contacts/{contact_id}";
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

            if (contactId != null) localVarPathParams.Add("contact_id", this.Configuration.ApiClient.ParameterToString(contactId)); // path parameter
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
                Exception exception = ExceptionFactory("GetContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComplexContact>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ComplexContact) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComplexContact)));
        }

        /// <summary>
        /// Update a specific contact Update contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <returns>CreateContactResponse</returns>
        public CreateContactResponse PatchContact (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved)
        {
             ApiResponse<CreateContactResponse> localVarResponse = PatchContactWithHttpInfo(contactId, listId, contactBaseStatusExtraNoRemoved);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a specific contact Update contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <returns>ApiResponse of CreateContactResponse</returns>
        public ApiResponse<CreateContactResponse> PatchContactWithHttpInfo (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved)
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ContactsApi->PatchContact");
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->PatchContact");
            // verify the required parameter 'contactBaseStatusExtraNoRemoved' is set
            if (contactBaseStatusExtraNoRemoved == null)
                throw new ApiException(400, "Missing required parameter 'contactBaseStatusExtraNoRemoved' when calling ContactsApi->PatchContact");

            var localVarPath = "/lists/{list_id}/contacts/{contact_id}";
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

            if (contactId != null) localVarPathParams.Add("contact_id", this.Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter
            if (contactBaseStatusExtraNoRemoved != null && contactBaseStatusExtraNoRemoved.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactBaseStatusExtraNoRemoved); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactBaseStatusExtraNoRemoved; // byte array
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
                Exception exception = ExceptionFactory("PatchContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContactResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CreateContactResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContactResponse)));
        }

        /// <summary>
        /// Update a specific contact Update contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CreateContactResponse</returns>
        public async System.Threading.Tasks.Task<CreateContactResponse> PatchContactAsync (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CreateContactResponse> localVarResponse = await PatchContactWithHttpInfoAsync(contactId, listId, contactBaseStatusExtraNoRemoved, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a specific contact Update contact
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contactId">ID of the Contact</param>
        /// <param name="listId">ID of the List</param>
        /// <param name="contactBaseStatusExtraNoRemoved">Parameters for the contact</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CreateContactResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateContactResponse>> PatchContactWithHttpInfoAsync (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'contactId' is set
            if (contactId == null)
                throw new ApiException(400, "Missing required parameter 'contactId' when calling ContactsApi->PatchContact");
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->PatchContact");
            // verify the required parameter 'contactBaseStatusExtraNoRemoved' is set
            if (contactBaseStatusExtraNoRemoved == null)
                throw new ApiException(400, "Missing required parameter 'contactBaseStatusExtraNoRemoved' when calling ContactsApi->PatchContact");

            var localVarPath = "/lists/{list_id}/contacts/{contact_id}";
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

            if (contactId != null) localVarPathParams.Add("contact_id", this.Configuration.ApiClient.ParameterToString(contactId)); // path parameter
            if (listId != null) localVarPathParams.Add("list_id", this.Configuration.ApiClient.ParameterToString(listId)); // path parameter
            if (contactBaseStatusExtraNoRemoved != null && contactBaseStatusExtraNoRemoved.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactBaseStatusExtraNoRemoved); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactBaseStatusExtraNoRemoved; // byte array
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
                Exception exception = ExceptionFactory("PatchContact", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContactResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CreateContactResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContactResponse)));
        }

        /// <summary>
        /// Search contact Searches a contact across all lists and returns a collection of contacts found
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 SearchContacts (string contact, string type = default(string))
        {
             ApiResponse<InlineResponse2001> localVarResponse = SearchContactsWithHttpInfo(contact, type);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search contact Searches a contact across all lists and returns a collection of contacts found
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse<InlineResponse2001> SearchContactsWithHttpInfo (string contact, string type = default(string))
        {
            // verify the required parameter 'contact' is set
            if (contact == null)
                throw new ApiException(400, "Missing required parameter 'contact' when calling ContactsApi->SearchContacts");

            var localVarPath = "/contacts/search";
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

            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (contact != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "contact", contact)); // query parameter

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
                Exception exception = ExceptionFactory("SearchContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Search contact Searches a contact across all lists and returns a collection of contacts found
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> SearchContactsAsync (string contact, string type = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse2001> localVarResponse = await SearchContactsWithHttpInfoAsync(contact, type, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search contact Searches a contact across all lists and returns a collection of contacts found
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="contact">Contact to search</param>
        /// <param name="type">Type of contact to search (defaults to &#39;email&#39;) (optional, default to email)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> SearchContactsWithHttpInfoAsync (string contact, string type = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'contact' is set
            if (contact == null)
                throw new ApiException(400, "Missing required parameter 'contact' when calling ContactsApi->SearchContacts");

            var localVarPath = "/contacts/search";
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

            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (contact != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "contact", contact)); // query parameter

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
                Exception exception = ExceptionFactory("SearchContacts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Updates a contact by field Updates a contact by field, wich must be unique in list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <returns>CreateContactResponse</returns>
        public CreateContactResponse UpdateContactByField (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost)
        {
             ApiResponse<CreateContactResponse> localVarResponse = UpdateContactByFieldWithHttpInfo(listId, contactFieldIdBaseExtraPost);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a contact by field Updates a contact by field, wich must be unique in list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <returns>ApiResponse of CreateContactResponse</returns>
        public ApiResponse<CreateContactResponse> UpdateContactByFieldWithHttpInfo (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->UpdateContactByField");
            // verify the required parameter 'contactFieldIdBaseExtraPost' is set
            if (contactFieldIdBaseExtraPost == null)
                throw new ApiException(400, "Missing required parameter 'contactFieldIdBaseExtraPost' when calling ContactsApi->UpdateContactByField");

            var localVarPath = "/lists/{list_id}/contacts/by-field";
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
            if (contactFieldIdBaseExtraPost != null && contactFieldIdBaseExtraPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactFieldIdBaseExtraPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactFieldIdBaseExtraPost; // byte array
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
                Exception exception = ExceptionFactory("UpdateContactByField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContactResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CreateContactResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContactResponse)));
        }

        /// <summary>
        /// Updates a contact by field Updates a contact by field, wich must be unique in list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CreateContactResponse</returns>
        public async System.Threading.Tasks.Task<CreateContactResponse> UpdateContactByFieldAsync (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CreateContactResponse> localVarResponse = await UpdateContactByFieldWithHttpInfoAsync(listId, contactFieldIdBaseExtraPost, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a contact by field Updates a contact by field, wich must be unique in list
        /// </summary>
        /// <exception cref="org.egoi.client.api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">ID of the list where the contact belongs</param>
        /// <param name="contactFieldIdBaseExtraPost">Parameters for the Contact Update by Field Id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CreateContactResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateContactResponse>> UpdateContactByFieldWithHttpInfoAsync (int listId, ContactFieldIdBaseExtraPost contactFieldIdBaseExtraPost, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->UpdateContactByField");
            // verify the required parameter 'contactFieldIdBaseExtraPost' is set
            if (contactFieldIdBaseExtraPost == null)
                throw new ApiException(400, "Missing required parameter 'contactFieldIdBaseExtraPost' when calling ContactsApi->UpdateContactByField");

            var localVarPath = "/lists/{list_id}/contacts/by-field";
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
            if (contactFieldIdBaseExtraPost != null && contactFieldIdBaseExtraPost.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(contactFieldIdBaseExtraPost); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contactFieldIdBaseExtraPost; // byte array
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
                Exception exception = ExceptionFactory("UpdateContactByField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateContactResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CreateContactResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateContactResponse)));
        }

    }
}
