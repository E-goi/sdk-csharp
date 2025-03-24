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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using org.egoi.client.api.Client;
using org.egoi.client.api.Api;
using org.egoi.client.api.Model;

namespace org.egoi.client.api.Test
{
    /// <summary>
    ///  Class for testing AdvancedReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AdvancedReportsApiTests
    {
        private AdvancedReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AdvancedReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdvancedReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AdvancedReportsApi
            //Assert.IsInstanceOf(typeof(AdvancedReportsApi), instance);
        }

        
        /// <summary>
        /// Test GenerateByModelReport
        /// </summary>
        [Test]
        public void GenerateByModelReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateByModelReport generateByModelReport = null;
            //var response = instance.GenerateByModelReport(generateByModelReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateContactActivityReport
        /// </summary>
        [Test]
        public void GenerateContactActivityReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateContactActivityReport generateContactActivityReport = null;
            //var response = instance.GenerateContactActivityReport(generateContactActivityReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateEmailBouncesReport
        /// </summary>
        [Test]
        public void GenerateEmailBouncesReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateEmailBouncesReport generateEmailBouncesReport = null;
            //var response = instance.GenerateEmailBouncesReport(generateEmailBouncesReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateEmailClicksByContactReport
        /// </summary>
        [Test]
        public void GenerateEmailClicksByContactReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateEmailClicksByContactReport generateEmailClicksByContactReport = null;
            //var response = instance.GenerateEmailClicksByContactReport(generateEmailClicksByContactReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateEmailClicksByUrlReport
        /// </summary>
        [Test]
        public void GenerateEmailClicksByUrlReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport = null;
            //var response = instance.GenerateEmailClicksByUrlReport(generateEmailClicksByUrlReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateEmailEventsReport
        /// </summary>
        [Test]
        public void GenerateEmailEventsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateEmailEventsReport generateEmailEventsReport = null;
            //var response = instance.GenerateEmailEventsReport(generateEmailEventsReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateEmailUnsubscriptionsReport
        /// </summary>
        [Test]
        public void GenerateEmailUnsubscriptionsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport = null;
            //var response = instance.GenerateEmailUnsubscriptionsReport(generateEmailUnsubscriptionsReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateFormAnswersReport
        /// </summary>
        [Test]
        public void GenerateFormAnswersReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateFormAnswersReport generateFormAnswersReport = null;
            //var response = instance.GenerateFormAnswersReport(generateFormAnswersReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateSendsReport
        /// </summary>
        [Test]
        public void GenerateSendsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateSendsReport generateSendsReport = null;
            //var response = instance.GenerateSendsReport(generateSendsReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateSmsBouncesReport
        /// </summary>
        [Test]
        public void GenerateSmsBouncesReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateSmsBouncesReport generateSmsBouncesReport = null;
            //var response = instance.GenerateSmsBouncesReport(generateSmsBouncesReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateSmsEventsReport
        /// </summary>
        [Test]
        public void GenerateSmsEventsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateSmsEventsReport generateSmsEventsReport = null;
            //var response = instance.GenerateSmsEventsReport(generateSmsEventsReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateSubscriptionsReport
        /// </summary>
        [Test]
        public void GenerateSubscriptionsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateSubscriptionsReport generateSubscriptionsReport = null;
            //var response = instance.GenerateSubscriptionsReport(generateSubscriptionsReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GenerateUnsubscriptionsReport
        /// </summary>
        [Test]
        public void GenerateUnsubscriptionsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GenerateUnsubscriptionsReport generateUnsubscriptionsReport = null;
            //var response = instance.GenerateUnsubscriptionsReport(generateUnsubscriptionsReport);
            //Assert.IsInstanceOf(typeof(AcceptedResponse), response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test GetAllAdvancedReports
        /// </summary>
        [Test]
        public void GetAllAdvancedReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string status = null;
            //string title = null;
            //DateTime? createdMin = null;
            //DateTime? createdMax = null;
            //int? offset = null;
            //int? limit = null;
            //string order = null;
            //string orderBy = null;
            //var response = instance.GetAllAdvancedReports(status, title, createdMin, createdMax, offset, limit, order, orderBy);
            //Assert.IsInstanceOf(typeof(AdvancedReportsCollection), response, "response is AdvancedReportsCollection");
        }
        
        /// <summary>
        /// Test GetAllAdvancedReportsModels
        /// </summary>
        [Test]
        public void GetAllAdvancedReportsModelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string title = null;
            //int? offset = null;
            //int? limit = null;
            //string order = null;
            //string orderBy = null;
            //var response = instance.GetAllAdvancedReportsModels(title, offset, limit, order, orderBy);
            //Assert.IsInstanceOf(typeof(AdvancedReportsModelsCollection), response, "response is AdvancedReportsModelsCollection");
        }
        
    }

}
