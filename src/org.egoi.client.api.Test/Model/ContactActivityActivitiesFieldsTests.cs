/*
 * Marketing API
 *
 *  # Introduction Welcome to the E-goi Marketing API! <br><br>This API enables you to integrate, automate, and manage all the marketing functionalities offered by E-goi. With it, you can interact with contact lists, send email campaigns, SMS, push notifications, and much more. <br><br>Our API is designed to simplify integration in a straightforward, efficient, and secure way, meeting the needs of developers and businesses looking to optimize their digital marketing operations. <br><br>Explore the documentation to discover all the possibilities and start creating integrations that drive your marketing results. # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.  The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.      BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Transport Layer Security (TLS) Transport Layer Security (TLS) is a widely used authentication and encryption protocol that establishes a secure communications channel for data-in-transit while ensuring that the client and server can validate one another.<br> Our API requires TLS 1.2 or TLS 1.3. We recommend <b>TLS 1.3</b>.<br><br> <b>TLS 1.3 ciphers</b> * TLS_AES_256_GCM_SHA384 (0x1302) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_CHACHA20_POLY1305_SHA256 (0x1303) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_AES_128_GCM_SHA256 (0x1301) ECDH x25519 (eq. 3072 bits RSA) FS  <b>TLS 1.2 ciphers</b> * TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 (0xc030) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 (0xc02f) ECDH x25519 (eq. 3072 bits RSA) FS * TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 (0x9f) DH 4096 bits FS * TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 (0x9e) DH 4096 bits FS  # Rate Limits Rate limits are used to control the amount of traffic that is allowed to flow between the client and the server.<br> This is done to prevent abuse and ensure that the API is available to all users.<br> The rate limits are applied to ensure the stability and security of our API and are based on the number of requests made in a given time period.<br> If the rate limit is exceeded, the API will return a 429 status code and the request will be rejected.<br> Each API response includes headers providing real-time rate limit information: * **X-RateLimit-Limit**: The maximum number of requests that the consumer is permitted to make in a given time period. * **X-RateLimit-Remaining**: The number of requests remaining in the current rate limit window. * **X-RateLimit-Reset**: The remaining time in seconds until the rate limit window resets.  # Account Limit The account limit is a rate limit that is applied to the account as a whole.<br> This limit is applied to all requests made by the account, regardless of the client making the request.<br> The account limit is applied to ensure that the account does not exceed the maximum number of requests allowed in a given time period. Each account has an overall usage limit per hour. If the account limit is exceeded, the API will return a 429 status code and the request will be rejected.<br> Each API response includes headers providing real-time rate limit information: * **X-Account-Limit**: The maximum number of requests that the account is permitted to make in a given time period. * **X-Account-Remaining**: The number of requests remaining in the current rate limit window. * **X-Account-Reset**: The remaining time in seconds until the rate limit window resets.   # Authentication  We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:     #!/bin/bash     curl -X GET 'https://api.egoiapp.com/my-account' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:     #!/bin/bash     curl -X POST 'http://api.egoiapp.com/tags' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>' \\     -H 'Content-Type: application/json' \\     -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  # Callbacks A callback is an asynchronous API request that originates from the API server and is sent to the client in response to a previous request sent by that client.  The API will make a **POST** request to the address defined in the URL with the information regarding the event of interest and share data related to that event.  <a href='/usecases/callbacks/' target='_blank'>[Go to callbacks documentation]</a>  ***Note:*** Only http or https protocols are supported in the Url parameter.  <security-definitions/>
 *
 * The version of the OpenAPI document: V3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using org.egoi.client.api.Api;
using org.egoi.client.api.Model;
using org.egoi.client.api.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace org.egoi.client.api.Test
{
    /// <summary>
    ///  Class for testing ContactActivityActivitiesFields
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ContactActivityActivitiesFieldsTests
    {
        // TODO uncomment below to declare an instance variable for ContactActivityActivitiesFields
        //private ContactActivityActivitiesFields instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ContactActivityActivitiesFields
            //instance = new ContactActivityActivitiesFields();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactActivityActivitiesFields
        /// </summary>
        [Test]
        public void ContactActivityActivitiesFieldsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" ContactActivityActivitiesFields
            //Assert.IsInstanceOf(typeof(ContactActivityActivitiesFields), instance);
        }


        /// <summary>
        /// Test the property 'Opens'
        /// </summary>
        [Test]
        public void OpensTest()
        {
            // TODO unit test for the property 'Opens'
        }
        /// <summary>
        /// Test the property 'Clicks'
        /// </summary>
        [Test]
        public void ClicksTest()
        {
            // TODO unit test for the property 'Clicks'
        }
        /// <summary>
        /// Test the property 'Recommends'
        /// </summary>
        [Test]
        public void RecommendsTest()
        {
            // TODO unit test for the property 'Recommends'
        }
        /// <summary>
        /// Test the property 'Conversion'
        /// </summary>
        [Test]
        public void ConversionTest()
        {
            // TODO unit test for the property 'Conversion'
        }
        /// <summary>
        /// Test the property 'EmailSend'
        /// </summary>
        [Test]
        public void EmailSendTest()
        {
            // TODO unit test for the property 'EmailSend'
        }
        /// <summary>
        /// Test the property 'SmsSend'
        /// </summary>
        [Test]
        public void SmsSendTest()
        {
            // TODO unit test for the property 'SmsSend'
        }
        /// <summary>
        /// Test the property 'SmsReport'
        /// </summary>
        [Test]
        public void SmsReportTest()
        {
            // TODO unit test for the property 'SmsReport'
        }
        /// <summary>
        /// Test the property 'VoiceSend'
        /// </summary>
        [Test]
        public void VoiceSendTest()
        {
            // TODO unit test for the property 'VoiceSend'
        }
        /// <summary>
        /// Test the property 'VoiceReport'
        /// </summary>
        [Test]
        public void VoiceReportTest()
        {
            // TODO unit test for the property 'VoiceReport'
        }
        /// <summary>
        /// Test the property 'InvitationSend'
        /// </summary>
        [Test]
        public void InvitationSendTest()
        {
            // TODO unit test for the property 'InvitationSend'
        }
        /// <summary>
        /// Test the property 'InvitationOpen'
        /// </summary>
        [Test]
        public void InvitationOpenTest()
        {
            // TODO unit test for the property 'InvitationOpen'
        }
        /// <summary>
        /// Test the property 'Unsubscribe'
        /// </summary>
        [Test]
        public void UnsubscribeTest()
        {
            // TODO unit test for the property 'Unsubscribe'
        }
        /// <summary>
        /// Test the property 'EmailSoftBounce'
        /// </summary>
        [Test]
        public void EmailSoftBounceTest()
        {
            // TODO unit test for the property 'EmailSoftBounce'
        }
        /// <summary>
        /// Test the property 'EmailHardBounce'
        /// </summary>
        [Test]
        public void EmailHardBounceTest()
        {
            // TODO unit test for the property 'EmailHardBounce'
        }
        /// <summary>
        /// Test the property 'Subscription'
        /// </summary>
        [Test]
        public void SubscriptionTest()
        {
            // TODO unit test for the property 'Subscription'
        }
        /// <summary>
        /// Test the property 'Resubscription'
        /// </summary>
        [Test]
        public void ResubscriptionTest()
        {
            // TODO unit test for the property 'Resubscription'
        }
        /// <summary>
        /// Test the property 'UnsubscribeReason'
        /// </summary>
        [Test]
        public void UnsubscribeReasonTest()
        {
            // TODO unit test for the property 'UnsubscribeReason'
        }
        /// <summary>
        /// Test the property 'FacebookLike'
        /// </summary>
        [Test]
        public void FacebookLikeTest()
        {
            // TODO unit test for the property 'FacebookLike'
        }
        /// <summary>
        /// Test the property 'SocialShare'
        /// </summary>
        [Test]
        public void SocialShareTest()
        {
            // TODO unit test for the property 'SocialShare'
        }
        /// <summary>
        /// Test the property 'UnsubscribeManual'
        /// </summary>
        [Test]
        public void UnsubscribeManualTest()
        {
            // TODO unit test for the property 'UnsubscribeManual'
        }
        /// <summary>
        /// Test the property 'DoubleOptin'
        /// </summary>
        [Test]
        public void DoubleOptinTest()
        {
            // TODO unit test for the property 'DoubleOptin'
        }
        /// <summary>
        /// Test the property 'EmailSpamComplaint'
        /// </summary>
        [Test]
        public void EmailSpamComplaintTest()
        {
            // TODO unit test for the property 'EmailSpamComplaint'
        }
        /// <summary>
        /// Test the property 'EmailFieldDisable'
        /// </summary>
        [Test]
        public void EmailFieldDisableTest()
        {
            // TODO unit test for the property 'EmailFieldDisable'
        }
        /// <summary>
        /// Test the property 'CellphoneFieldDisable'
        /// </summary>
        [Test]
        public void CellphoneFieldDisableTest()
        {
            // TODO unit test for the property 'CellphoneFieldDisable'
        }
        /// <summary>
        /// Test the property 'PhoneFieldDisable'
        /// </summary>
        [Test]
        public void PhoneFieldDisableTest()
        {
            // TODO unit test for the property 'PhoneFieldDisable'
        }
        /// <summary>
        /// Test the property 'UnsubscribeApi'
        /// </summary>
        [Test]
        public void UnsubscribeApiTest()
        {
            // TODO unit test for the property 'UnsubscribeApi'
        }
        /// <summary>
        /// Test the property 'EmailFieldEnable'
        /// </summary>
        [Test]
        public void EmailFieldEnableTest()
        {
            // TODO unit test for the property 'EmailFieldEnable'
        }
        /// <summary>
        /// Test the property 'CellphoneFieldEnable'
        /// </summary>
        [Test]
        public void CellphoneFieldEnableTest()
        {
            // TODO unit test for the property 'CellphoneFieldEnable'
        }
        /// <summary>
        /// Test the property 'PhoneFieldEnable'
        /// </summary>
        [Test]
        public void PhoneFieldEnableTest()
        {
            // TODO unit test for the property 'PhoneFieldEnable'
        }
        /// <summary>
        /// Test the property 'EditSubscription'
        /// </summary>
        [Test]
        public void EditSubscriptionTest()
        {
            // TODO unit test for the property 'EditSubscription'
        }
        /// <summary>
        /// Test the property 'AutomationEvent'
        /// </summary>
        [Test]
        public void AutomationEventTest()
        {
            // TODO unit test for the property 'AutomationEvent'
        }
        /// <summary>
        /// Test the property 'PushSend'
        /// </summary>
        [Test]
        public void PushSendTest()
        {
            // TODO unit test for the property 'PushSend'
        }
        /// <summary>
        /// Test the property 'PushDelivered'
        /// </summary>
        [Test]
        public void PushDeliveredTest()
        {
            // TODO unit test for the property 'PushDelivered'
        }
        /// <summary>
        /// Test the property 'PushError'
        /// </summary>
        [Test]
        public void PushErrorTest()
        {
            // TODO unit test for the property 'PushError'
        }
        /// <summary>
        /// Test the property 'PushReceived'
        /// </summary>
        [Test]
        public void PushReceivedTest()
        {
            // TODO unit test for the property 'PushReceived'
        }
        /// <summary>
        /// Test the property 'PushOpen'
        /// </summary>
        [Test]
        public void PushOpenTest()
        {
            // TODO unit test for the property 'PushOpen'
        }
        /// <summary>
        /// Test the property 'PushCanceled'
        /// </summary>
        [Test]
        public void PushCanceledTest()
        {
            // TODO unit test for the property 'PushCanceled'
        }
        /// <summary>
        /// Test the property 'PushUnsubscription'
        /// </summary>
        [Test]
        public void PushUnsubscriptionTest()
        {
            // TODO unit test for the property 'PushUnsubscription'
        }
        /// <summary>
        /// Test the property 'ReplyToEmail'
        /// </summary>
        [Test]
        public void ReplyToEmailTest()
        {
            // TODO unit test for the property 'ReplyToEmail'
        }
        /// <summary>
        /// Test the property 'WebPushSend'
        /// </summary>
        [Test]
        public void WebPushSendTest()
        {
            // TODO unit test for the property 'WebPushSend'
        }
        /// <summary>
        /// Test the property 'WebPushDelivered'
        /// </summary>
        [Test]
        public void WebPushDeliveredTest()
        {
            // TODO unit test for the property 'WebPushDelivered'
        }
        /// <summary>
        /// Test the property 'WebPushOpen'
        /// </summary>
        [Test]
        public void WebPushOpenTest()
        {
            // TODO unit test for the property 'WebPushOpen'
        }
        /// <summary>
        /// Test the property 'WebPushBounce'
        /// </summary>
        [Test]
        public void WebPushBounceTest()
        {
            // TODO unit test for the property 'WebPushBounce'
        }
        /// <summary>
        /// Test the property 'WebPushClick'
        /// </summary>
        [Test]
        public void WebPushClickTest()
        {
            // TODO unit test for the property 'WebPushClick'
        }
        /// <summary>
        /// Test the property 'WebPushSubscription'
        /// </summary>
        [Test]
        public void WebPushSubscriptionTest()
        {
            // TODO unit test for the property 'WebPushSubscription'
        }
        /// <summary>
        /// Test the property 'WebPushUnsubscription'
        /// </summary>
        [Test]
        public void WebPushUnsubscriptionTest()
        {
            // TODO unit test for the property 'WebPushUnsubscription'
        }
        /// <summary>
        /// Test the property 'ForgetSubscription'
        /// </summary>
        [Test]
        public void ForgetSubscriptionTest()
        {
            // TODO unit test for the property 'ForgetSubscription'
        }
        /// <summary>
        /// Test the property 'ChangeConsent'
        /// </summary>
        [Test]
        public void ChangeConsentTest()
        {
            // TODO unit test for the property 'ChangeConsent'
        }
        /// <summary>
        /// Test the property 'DoubleOptinResend'
        /// </summary>
        [Test]
        public void DoubleOptinResendTest()
        {
            // TODO unit test for the property 'DoubleOptinResend'
        }
        /// <summary>
        /// Test the property 'DoubleOptedit'
        /// </summary>
        [Test]
        public void DoubleOpteditTest()
        {
            // TODO unit test for the property 'DoubleOptedit'
        }

    }

}
