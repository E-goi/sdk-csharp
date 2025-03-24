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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = org.egoi.client.api.Client.OpenAPIDateConverter;

namespace org.egoi.client.api.Model
{
    /// <summary>
    /// List of contacts activities to include in the report
    /// </summary>
    [DataContract]
    public partial class ContactActivityActivitiesFields :  IEquatable<ContactActivityActivitiesFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactActivityActivitiesFields" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactActivityActivitiesFields() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactActivityActivitiesFields" /> class.
        /// </summary>
        /// <param name="opens">True to include opens, false otherwise (required).</param>
        /// <param name="clicks">True to include clicks, false otherwise (required).</param>
        /// <param name="recommends">True to include recommends, false otherwise (required).</param>
        /// <param name="conversion">True to include convertions, false otherwise (required).</param>
        /// <param name="emailSend">True to include email sends, false otherwise (required).</param>
        /// <param name="smsSend">True to include sms sends, false otherwise (required).</param>
        /// <param name="smsReport">True to include sms report, false otherwise (required).</param>
        /// <param name="voiceSend">True to include voice sends, false otherwise (required).</param>
        /// <param name="voiceReport">True to include voice report, false otherwise (required).</param>
        /// <param name="invitationSend">True to include invitation sends, false otherwise (required).</param>
        /// <param name="invitationOpen">True to include invitation opens, false otherwise (required).</param>
        /// <param name="unsubscribe">True to include unsubscriptions, false otherwise (required).</param>
        /// <param name="emailSoftBounce">True to include email soft bounces, false otherwise (required).</param>
        /// <param name="emailHardBounce">True to include email hard bounces, false otherwise (required).</param>
        /// <param name="subscription">True to include subscriptions, false otherwise (required).</param>
        /// <param name="resubscription">True to include re-subscriptions, false otherwise (required).</param>
        /// <param name="unsubscribeReason">True to include unsubscription reason, false otherwise (required).</param>
        /// <param name="facebookLike">True to include facebook likes, false otherwise (required).</param>
        /// <param name="socialShare">True to include social shares, false otherwise (required).</param>
        /// <param name="unsubscribeManual">True to include manual unsubscriptions, false otherwise (required).</param>
        /// <param name="doubleOptin">True to include double optins, false otherwise (required).</param>
        /// <param name="emailSpamComplaint">True to include spam complaints, false otherwise (required).</param>
        /// <param name="emailFieldDisable">True to include email field disable, false otherwise (required).</param>
        /// <param name="cellphoneFieldDisable">True to include cellphone field disable, false otherwise (required).</param>
        /// <param name="phoneFieldDisable">True to include phone field disable, false otherwise (required).</param>
        /// <param name="unsubscribeApi">True to include api unsubscriptions, false otherwise (required).</param>
        /// <param name="emailFieldEnable">True to include email field enable, false otherwise (required).</param>
        /// <param name="cellphoneFieldEnable">True to include cellphone field enable, false otherwise (required).</param>
        /// <param name="phoneFieldEnable">True to include phone field enable, false otherwise (required).</param>
        /// <param name="editSubscription">True to include edit subscriptions, false otherwise (required).</param>
        /// <param name="automationEvent">True to include automation events, false otherwise (required).</param>
        /// <param name="pushSend">True to include push events, false otherwise (required).</param>
        /// <param name="pushDelivered">True to include push delivered, false otherwise (required).</param>
        /// <param name="pushError">True to include push error, false otherwise (required).</param>
        /// <param name="pushReceived">True to include push received, false otherwise (required).</param>
        /// <param name="pushOpen">True to include push open, false otherwise (required).</param>
        /// <param name="pushCanceled">True to include push canceled, false otherwise (required).</param>
        /// <param name="pushUnsubscription">True to include push unsubscriptions, false otherwise (required).</param>
        /// <param name="replyToEmail">True to include reply to email, false otherwise (required).</param>
        /// <param name="webPushSend">True to include web push send, false otherwise (required).</param>
        /// <param name="webPushDelivered">True to include web push delivered, false otherwise (required).</param>
        /// <param name="webPushOpen">True to include web push open, false otherwise (required).</param>
        /// <param name="webPushBounce">True to include web push bounces, false otherwise (required).</param>
        /// <param name="webPushClick">True to include web push clicks, false otherwise (required).</param>
        /// <param name="webPushSubscription">True to include web push subscriptions, false otherwise (required).</param>
        /// <param name="webPushUnsubscription">True to include web push unsubscriptions, false otherwise (required).</param>
        /// <param name="forgetSubscription">True to include forget subscriptions, false otherwise (required).</param>
        /// <param name="changeConsent">True to include consent change, false otherwise (required).</param>
        /// <param name="doubleOptinResend">True to include optin resends, false otherwise (required).</param>
        /// <param name="doubleOptedit">True to include double optedit, false otherwise (required).</param>
        public ContactActivityActivitiesFields(bool opens = default(bool), bool clicks = default(bool), bool recommends = default(bool), bool conversion = default(bool), bool emailSend = default(bool), bool smsSend = default(bool), bool smsReport = default(bool), bool voiceSend = default(bool), bool voiceReport = default(bool), bool invitationSend = default(bool), bool invitationOpen = default(bool), bool unsubscribe = default(bool), bool emailSoftBounce = default(bool), bool emailHardBounce = default(bool), bool subscription = default(bool), bool resubscription = default(bool), bool unsubscribeReason = default(bool), bool facebookLike = default(bool), bool socialShare = default(bool), bool unsubscribeManual = default(bool), bool doubleOptin = default(bool), bool emailSpamComplaint = default(bool), bool emailFieldDisable = default(bool), bool cellphoneFieldDisable = default(bool), bool phoneFieldDisable = default(bool), bool unsubscribeApi = default(bool), bool emailFieldEnable = default(bool), bool cellphoneFieldEnable = default(bool), bool phoneFieldEnable = default(bool), bool editSubscription = default(bool), bool automationEvent = default(bool), bool pushSend = default(bool), bool pushDelivered = default(bool), bool pushError = default(bool), bool pushReceived = default(bool), bool pushOpen = default(bool), bool pushCanceled = default(bool), bool pushUnsubscription = default(bool), bool replyToEmail = default(bool), bool webPushSend = default(bool), bool webPushDelivered = default(bool), bool webPushOpen = default(bool), bool webPushBounce = default(bool), bool webPushClick = default(bool), bool webPushSubscription = default(bool), bool webPushUnsubscription = default(bool), bool forgetSubscription = default(bool), bool changeConsent = default(bool), bool doubleOptinResend = default(bool), bool doubleOptedit = default(bool))
        {
            // to ensure "opens" is required (not null)
            if (opens == null)
            {
                throw new InvalidDataException("opens is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.Opens = opens;
            }

            // to ensure "clicks" is required (not null)
            if (clicks == null)
            {
                throw new InvalidDataException("clicks is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.Clicks = clicks;
            }

            // to ensure "recommends" is required (not null)
            if (recommends == null)
            {
                throw new InvalidDataException("recommends is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.Recommends = recommends;
            }

            // to ensure "conversion" is required (not null)
            if (conversion == null)
            {
                throw new InvalidDataException("conversion is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.Conversion = conversion;
            }

            // to ensure "emailSend" is required (not null)
            if (emailSend == null)
            {
                throw new InvalidDataException("emailSend is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.EmailSend = emailSend;
            }

            // to ensure "smsSend" is required (not null)
            if (smsSend == null)
            {
                throw new InvalidDataException("smsSend is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.SmsSend = smsSend;
            }

            // to ensure "smsReport" is required (not null)
            if (smsReport == null)
            {
                throw new InvalidDataException("smsReport is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.SmsReport = smsReport;
            }

            // to ensure "voiceSend" is required (not null)
            if (voiceSend == null)
            {
                throw new InvalidDataException("voiceSend is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.VoiceSend = voiceSend;
            }

            // to ensure "voiceReport" is required (not null)
            if (voiceReport == null)
            {
                throw new InvalidDataException("voiceReport is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.VoiceReport = voiceReport;
            }

            // to ensure "invitationSend" is required (not null)
            if (invitationSend == null)
            {
                throw new InvalidDataException("invitationSend is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.InvitationSend = invitationSend;
            }

            // to ensure "invitationOpen" is required (not null)
            if (invitationOpen == null)
            {
                throw new InvalidDataException("invitationOpen is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.InvitationOpen = invitationOpen;
            }

            // to ensure "unsubscribe" is required (not null)
            if (unsubscribe == null)
            {
                throw new InvalidDataException("unsubscribe is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.Unsubscribe = unsubscribe;
            }

            // to ensure "emailSoftBounce" is required (not null)
            if (emailSoftBounce == null)
            {
                throw new InvalidDataException("emailSoftBounce is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.EmailSoftBounce = emailSoftBounce;
            }

            // to ensure "emailHardBounce" is required (not null)
            if (emailHardBounce == null)
            {
                throw new InvalidDataException("emailHardBounce is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.EmailHardBounce = emailHardBounce;
            }

            // to ensure "subscription" is required (not null)
            if (subscription == null)
            {
                throw new InvalidDataException("subscription is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.Subscription = subscription;
            }

            // to ensure "resubscription" is required (not null)
            if (resubscription == null)
            {
                throw new InvalidDataException("resubscription is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.Resubscription = resubscription;
            }

            // to ensure "unsubscribeReason" is required (not null)
            if (unsubscribeReason == null)
            {
                throw new InvalidDataException("unsubscribeReason is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.UnsubscribeReason = unsubscribeReason;
            }

            // to ensure "facebookLike" is required (not null)
            if (facebookLike == null)
            {
                throw new InvalidDataException("facebookLike is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.FacebookLike = facebookLike;
            }

            // to ensure "socialShare" is required (not null)
            if (socialShare == null)
            {
                throw new InvalidDataException("socialShare is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.SocialShare = socialShare;
            }

            // to ensure "unsubscribeManual" is required (not null)
            if (unsubscribeManual == null)
            {
                throw new InvalidDataException("unsubscribeManual is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.UnsubscribeManual = unsubscribeManual;
            }

            // to ensure "doubleOptin" is required (not null)
            if (doubleOptin == null)
            {
                throw new InvalidDataException("doubleOptin is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.DoubleOptin = doubleOptin;
            }

            // to ensure "emailSpamComplaint" is required (not null)
            if (emailSpamComplaint == null)
            {
                throw new InvalidDataException("emailSpamComplaint is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.EmailSpamComplaint = emailSpamComplaint;
            }

            // to ensure "emailFieldDisable" is required (not null)
            if (emailFieldDisable == null)
            {
                throw new InvalidDataException("emailFieldDisable is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.EmailFieldDisable = emailFieldDisable;
            }

            // to ensure "cellphoneFieldDisable" is required (not null)
            if (cellphoneFieldDisable == null)
            {
                throw new InvalidDataException("cellphoneFieldDisable is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.CellphoneFieldDisable = cellphoneFieldDisable;
            }

            // to ensure "phoneFieldDisable" is required (not null)
            if (phoneFieldDisable == null)
            {
                throw new InvalidDataException("phoneFieldDisable is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PhoneFieldDisable = phoneFieldDisable;
            }

            // to ensure "unsubscribeApi" is required (not null)
            if (unsubscribeApi == null)
            {
                throw new InvalidDataException("unsubscribeApi is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.UnsubscribeApi = unsubscribeApi;
            }

            // to ensure "emailFieldEnable" is required (not null)
            if (emailFieldEnable == null)
            {
                throw new InvalidDataException("emailFieldEnable is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.EmailFieldEnable = emailFieldEnable;
            }

            // to ensure "cellphoneFieldEnable" is required (not null)
            if (cellphoneFieldEnable == null)
            {
                throw new InvalidDataException("cellphoneFieldEnable is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.CellphoneFieldEnable = cellphoneFieldEnable;
            }

            // to ensure "phoneFieldEnable" is required (not null)
            if (phoneFieldEnable == null)
            {
                throw new InvalidDataException("phoneFieldEnable is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PhoneFieldEnable = phoneFieldEnable;
            }

            // to ensure "editSubscription" is required (not null)
            if (editSubscription == null)
            {
                throw new InvalidDataException("editSubscription is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.EditSubscription = editSubscription;
            }

            // to ensure "automationEvent" is required (not null)
            if (automationEvent == null)
            {
                throw new InvalidDataException("automationEvent is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.AutomationEvent = automationEvent;
            }

            // to ensure "pushSend" is required (not null)
            if (pushSend == null)
            {
                throw new InvalidDataException("pushSend is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PushSend = pushSend;
            }

            // to ensure "pushDelivered" is required (not null)
            if (pushDelivered == null)
            {
                throw new InvalidDataException("pushDelivered is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PushDelivered = pushDelivered;
            }

            // to ensure "pushError" is required (not null)
            if (pushError == null)
            {
                throw new InvalidDataException("pushError is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PushError = pushError;
            }

            // to ensure "pushReceived" is required (not null)
            if (pushReceived == null)
            {
                throw new InvalidDataException("pushReceived is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PushReceived = pushReceived;
            }

            // to ensure "pushOpen" is required (not null)
            if (pushOpen == null)
            {
                throw new InvalidDataException("pushOpen is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PushOpen = pushOpen;
            }

            // to ensure "pushCanceled" is required (not null)
            if (pushCanceled == null)
            {
                throw new InvalidDataException("pushCanceled is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PushCanceled = pushCanceled;
            }

            // to ensure "pushUnsubscription" is required (not null)
            if (pushUnsubscription == null)
            {
                throw new InvalidDataException("pushUnsubscription is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.PushUnsubscription = pushUnsubscription;
            }

            // to ensure "replyToEmail" is required (not null)
            if (replyToEmail == null)
            {
                throw new InvalidDataException("replyToEmail is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.ReplyToEmail = replyToEmail;
            }

            // to ensure "webPushSend" is required (not null)
            if (webPushSend == null)
            {
                throw new InvalidDataException("webPushSend is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.WebPushSend = webPushSend;
            }

            // to ensure "webPushDelivered" is required (not null)
            if (webPushDelivered == null)
            {
                throw new InvalidDataException("webPushDelivered is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.WebPushDelivered = webPushDelivered;
            }

            // to ensure "webPushOpen" is required (not null)
            if (webPushOpen == null)
            {
                throw new InvalidDataException("webPushOpen is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.WebPushOpen = webPushOpen;
            }

            // to ensure "webPushBounce" is required (not null)
            if (webPushBounce == null)
            {
                throw new InvalidDataException("webPushBounce is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.WebPushBounce = webPushBounce;
            }

            // to ensure "webPushClick" is required (not null)
            if (webPushClick == null)
            {
                throw new InvalidDataException("webPushClick is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.WebPushClick = webPushClick;
            }

            // to ensure "webPushSubscription" is required (not null)
            if (webPushSubscription == null)
            {
                throw new InvalidDataException("webPushSubscription is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.WebPushSubscription = webPushSubscription;
            }

            // to ensure "webPushUnsubscription" is required (not null)
            if (webPushUnsubscription == null)
            {
                throw new InvalidDataException("webPushUnsubscription is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.WebPushUnsubscription = webPushUnsubscription;
            }

            // to ensure "forgetSubscription" is required (not null)
            if (forgetSubscription == null)
            {
                throw new InvalidDataException("forgetSubscription is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.ForgetSubscription = forgetSubscription;
            }

            // to ensure "changeConsent" is required (not null)
            if (changeConsent == null)
            {
                throw new InvalidDataException("changeConsent is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.ChangeConsent = changeConsent;
            }

            // to ensure "doubleOptinResend" is required (not null)
            if (doubleOptinResend == null)
            {
                throw new InvalidDataException("doubleOptinResend is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.DoubleOptinResend = doubleOptinResend;
            }

            // to ensure "doubleOptedit" is required (not null)
            if (doubleOptedit == null)
            {
                throw new InvalidDataException("doubleOptedit is a required property for ContactActivityActivitiesFields and cannot be null");
            }
            else
            {
                this.DoubleOptedit = doubleOptedit;
            }

        }

        /// <summary>
        /// True to include opens, false otherwise
        /// </summary>
        /// <value>True to include opens, false otherwise</value>
        [DataMember(Name="opens", EmitDefaultValue=true)]
        public bool Opens { get; set; }

        /// <summary>
        /// True to include clicks, false otherwise
        /// </summary>
        /// <value>True to include clicks, false otherwise</value>
        [DataMember(Name="clicks", EmitDefaultValue=true)]
        public bool Clicks { get; set; }

        /// <summary>
        /// True to include recommends, false otherwise
        /// </summary>
        /// <value>True to include recommends, false otherwise</value>
        [DataMember(Name="recommends", EmitDefaultValue=true)]
        public bool Recommends { get; set; }

        /// <summary>
        /// True to include convertions, false otherwise
        /// </summary>
        /// <value>True to include convertions, false otherwise</value>
        [DataMember(Name="conversion", EmitDefaultValue=true)]
        public bool Conversion { get; set; }

        /// <summary>
        /// True to include email sends, false otherwise
        /// </summary>
        /// <value>True to include email sends, false otherwise</value>
        [DataMember(Name="email_send", EmitDefaultValue=true)]
        public bool EmailSend { get; set; }

        /// <summary>
        /// True to include sms sends, false otherwise
        /// </summary>
        /// <value>True to include sms sends, false otherwise</value>
        [DataMember(Name="sms_send", EmitDefaultValue=true)]
        public bool SmsSend { get; set; }

        /// <summary>
        /// True to include sms report, false otherwise
        /// </summary>
        /// <value>True to include sms report, false otherwise</value>
        [DataMember(Name="sms_report", EmitDefaultValue=true)]
        public bool SmsReport { get; set; }

        /// <summary>
        /// True to include voice sends, false otherwise
        /// </summary>
        /// <value>True to include voice sends, false otherwise</value>
        [DataMember(Name="voice_send", EmitDefaultValue=true)]
        public bool VoiceSend { get; set; }

        /// <summary>
        /// True to include voice report, false otherwise
        /// </summary>
        /// <value>True to include voice report, false otherwise</value>
        [DataMember(Name="voice_report", EmitDefaultValue=true)]
        public bool VoiceReport { get; set; }

        /// <summary>
        /// True to include invitation sends, false otherwise
        /// </summary>
        /// <value>True to include invitation sends, false otherwise</value>
        [DataMember(Name="invitation_send", EmitDefaultValue=true)]
        public bool InvitationSend { get; set; }

        /// <summary>
        /// True to include invitation opens, false otherwise
        /// </summary>
        /// <value>True to include invitation opens, false otherwise</value>
        [DataMember(Name="invitation_open", EmitDefaultValue=true)]
        public bool InvitationOpen { get; set; }

        /// <summary>
        /// True to include unsubscriptions, false otherwise
        /// </summary>
        /// <value>True to include unsubscriptions, false otherwise</value>
        [DataMember(Name="unsubscribe", EmitDefaultValue=true)]
        public bool Unsubscribe { get; set; }

        /// <summary>
        /// True to include email soft bounces, false otherwise
        /// </summary>
        /// <value>True to include email soft bounces, false otherwise</value>
        [DataMember(Name="email_soft_bounce", EmitDefaultValue=true)]
        public bool EmailSoftBounce { get; set; }

        /// <summary>
        /// True to include email hard bounces, false otherwise
        /// </summary>
        /// <value>True to include email hard bounces, false otherwise</value>
        [DataMember(Name="email_hard_bounce", EmitDefaultValue=true)]
        public bool EmailHardBounce { get; set; }

        /// <summary>
        /// True to include subscriptions, false otherwise
        /// </summary>
        /// <value>True to include subscriptions, false otherwise</value>
        [DataMember(Name="subscription", EmitDefaultValue=true)]
        public bool Subscription { get; set; }

        /// <summary>
        /// True to include re-subscriptions, false otherwise
        /// </summary>
        /// <value>True to include re-subscriptions, false otherwise</value>
        [DataMember(Name="resubscription", EmitDefaultValue=true)]
        public bool Resubscription { get; set; }

        /// <summary>
        /// True to include unsubscription reason, false otherwise
        /// </summary>
        /// <value>True to include unsubscription reason, false otherwise</value>
        [DataMember(Name="unsubscribe_reason", EmitDefaultValue=true)]
        public bool UnsubscribeReason { get; set; }

        /// <summary>
        /// True to include facebook likes, false otherwise
        /// </summary>
        /// <value>True to include facebook likes, false otherwise</value>
        [DataMember(Name="facebook_like", EmitDefaultValue=true)]
        public bool FacebookLike { get; set; }

        /// <summary>
        /// True to include social shares, false otherwise
        /// </summary>
        /// <value>True to include social shares, false otherwise</value>
        [DataMember(Name="social_share", EmitDefaultValue=true)]
        public bool SocialShare { get; set; }

        /// <summary>
        /// True to include manual unsubscriptions, false otherwise
        /// </summary>
        /// <value>True to include manual unsubscriptions, false otherwise</value>
        [DataMember(Name="unsubscribe_manual", EmitDefaultValue=true)]
        public bool UnsubscribeManual { get; set; }

        /// <summary>
        /// True to include double optins, false otherwise
        /// </summary>
        /// <value>True to include double optins, false otherwise</value>
        [DataMember(Name="double_optin", EmitDefaultValue=true)]
        public bool DoubleOptin { get; set; }

        /// <summary>
        /// True to include spam complaints, false otherwise
        /// </summary>
        /// <value>True to include spam complaints, false otherwise</value>
        [DataMember(Name="email_spam_complaint", EmitDefaultValue=true)]
        public bool EmailSpamComplaint { get; set; }

        /// <summary>
        /// True to include email field disable, false otherwise
        /// </summary>
        /// <value>True to include email field disable, false otherwise</value>
        [DataMember(Name="email_field_disable", EmitDefaultValue=true)]
        public bool EmailFieldDisable { get; set; }

        /// <summary>
        /// True to include cellphone field disable, false otherwise
        /// </summary>
        /// <value>True to include cellphone field disable, false otherwise</value>
        [DataMember(Name="cellphone_field_disable", EmitDefaultValue=true)]
        public bool CellphoneFieldDisable { get; set; }

        /// <summary>
        /// True to include phone field disable, false otherwise
        /// </summary>
        /// <value>True to include phone field disable, false otherwise</value>
        [DataMember(Name="phone_field_disable", EmitDefaultValue=true)]
        public bool PhoneFieldDisable { get; set; }

        /// <summary>
        /// True to include api unsubscriptions, false otherwise
        /// </summary>
        /// <value>True to include api unsubscriptions, false otherwise</value>
        [DataMember(Name="unsubscribe_api", EmitDefaultValue=true)]
        public bool UnsubscribeApi { get; set; }

        /// <summary>
        /// True to include email field enable, false otherwise
        /// </summary>
        /// <value>True to include email field enable, false otherwise</value>
        [DataMember(Name="email_field_enable", EmitDefaultValue=true)]
        public bool EmailFieldEnable { get; set; }

        /// <summary>
        /// True to include cellphone field enable, false otherwise
        /// </summary>
        /// <value>True to include cellphone field enable, false otherwise</value>
        [DataMember(Name="cellphone_field_enable", EmitDefaultValue=true)]
        public bool CellphoneFieldEnable { get; set; }

        /// <summary>
        /// True to include phone field enable, false otherwise
        /// </summary>
        /// <value>True to include phone field enable, false otherwise</value>
        [DataMember(Name="phone_field_enable", EmitDefaultValue=true)]
        public bool PhoneFieldEnable { get; set; }

        /// <summary>
        /// True to include edit subscriptions, false otherwise
        /// </summary>
        /// <value>True to include edit subscriptions, false otherwise</value>
        [DataMember(Name="edit_subscription", EmitDefaultValue=true)]
        public bool EditSubscription { get; set; }

        /// <summary>
        /// True to include automation events, false otherwise
        /// </summary>
        /// <value>True to include automation events, false otherwise</value>
        [DataMember(Name="automation_event", EmitDefaultValue=true)]
        public bool AutomationEvent { get; set; }

        /// <summary>
        /// True to include push events, false otherwise
        /// </summary>
        /// <value>True to include push events, false otherwise</value>
        [DataMember(Name="push_send", EmitDefaultValue=true)]
        public bool PushSend { get; set; }

        /// <summary>
        /// True to include push delivered, false otherwise
        /// </summary>
        /// <value>True to include push delivered, false otherwise</value>
        [DataMember(Name="push_delivered", EmitDefaultValue=true)]
        public bool PushDelivered { get; set; }

        /// <summary>
        /// True to include push error, false otherwise
        /// </summary>
        /// <value>True to include push error, false otherwise</value>
        [DataMember(Name="push_error", EmitDefaultValue=true)]
        public bool PushError { get; set; }

        /// <summary>
        /// True to include push received, false otherwise
        /// </summary>
        /// <value>True to include push received, false otherwise</value>
        [DataMember(Name="push_received", EmitDefaultValue=true)]
        public bool PushReceived { get; set; }

        /// <summary>
        /// True to include push open, false otherwise
        /// </summary>
        /// <value>True to include push open, false otherwise</value>
        [DataMember(Name="push_open", EmitDefaultValue=true)]
        public bool PushOpen { get; set; }

        /// <summary>
        /// True to include push canceled, false otherwise
        /// </summary>
        /// <value>True to include push canceled, false otherwise</value>
        [DataMember(Name="push_canceled", EmitDefaultValue=true)]
        public bool PushCanceled { get; set; }

        /// <summary>
        /// True to include push unsubscriptions, false otherwise
        /// </summary>
        /// <value>True to include push unsubscriptions, false otherwise</value>
        [DataMember(Name="push_unsubscription", EmitDefaultValue=true)]
        public bool PushUnsubscription { get; set; }

        /// <summary>
        /// True to include reply to email, false otherwise
        /// </summary>
        /// <value>True to include reply to email, false otherwise</value>
        [DataMember(Name="reply_to_email", EmitDefaultValue=true)]
        public bool ReplyToEmail { get; set; }

        /// <summary>
        /// True to include web push send, false otherwise
        /// </summary>
        /// <value>True to include web push send, false otherwise</value>
        [DataMember(Name="web_push_send", EmitDefaultValue=true)]
        public bool WebPushSend { get; set; }

        /// <summary>
        /// True to include web push delivered, false otherwise
        /// </summary>
        /// <value>True to include web push delivered, false otherwise</value>
        [DataMember(Name="web_push_delivered", EmitDefaultValue=true)]
        public bool WebPushDelivered { get; set; }

        /// <summary>
        /// True to include web push open, false otherwise
        /// </summary>
        /// <value>True to include web push open, false otherwise</value>
        [DataMember(Name="web_push_open", EmitDefaultValue=true)]
        public bool WebPushOpen { get; set; }

        /// <summary>
        /// True to include web push bounces, false otherwise
        /// </summary>
        /// <value>True to include web push bounces, false otherwise</value>
        [DataMember(Name="web_push_bounce", EmitDefaultValue=true)]
        public bool WebPushBounce { get; set; }

        /// <summary>
        /// True to include web push clicks, false otherwise
        /// </summary>
        /// <value>True to include web push clicks, false otherwise</value>
        [DataMember(Name="web_push_click", EmitDefaultValue=true)]
        public bool WebPushClick { get; set; }

        /// <summary>
        /// True to include web push subscriptions, false otherwise
        /// </summary>
        /// <value>True to include web push subscriptions, false otherwise</value>
        [DataMember(Name="web_push_subscription", EmitDefaultValue=true)]
        public bool WebPushSubscription { get; set; }

        /// <summary>
        /// True to include web push unsubscriptions, false otherwise
        /// </summary>
        /// <value>True to include web push unsubscriptions, false otherwise</value>
        [DataMember(Name="web_push_unsubscription", EmitDefaultValue=true)]
        public bool WebPushUnsubscription { get; set; }

        /// <summary>
        /// True to include forget subscriptions, false otherwise
        /// </summary>
        /// <value>True to include forget subscriptions, false otherwise</value>
        [DataMember(Name="forget_subscription", EmitDefaultValue=true)]
        public bool ForgetSubscription { get; set; }

        /// <summary>
        /// True to include consent change, false otherwise
        /// </summary>
        /// <value>True to include consent change, false otherwise</value>
        [DataMember(Name="change_consent", EmitDefaultValue=true)]
        public bool ChangeConsent { get; set; }

        /// <summary>
        /// True to include optin resends, false otherwise
        /// </summary>
        /// <value>True to include optin resends, false otherwise</value>
        [DataMember(Name="double_optin_resend", EmitDefaultValue=true)]
        public bool DoubleOptinResend { get; set; }

        /// <summary>
        /// True to include double optedit, false otherwise
        /// </summary>
        /// <value>True to include double optedit, false otherwise</value>
        [DataMember(Name="double_optedit", EmitDefaultValue=true)]
        public bool DoubleOptedit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactActivityActivitiesFields {\n");
            sb.Append("  Opens: ").Append(Opens).Append("\n");
            sb.Append("  Clicks: ").Append(Clicks).Append("\n");
            sb.Append("  Recommends: ").Append(Recommends).Append("\n");
            sb.Append("  Conversion: ").Append(Conversion).Append("\n");
            sb.Append("  EmailSend: ").Append(EmailSend).Append("\n");
            sb.Append("  SmsSend: ").Append(SmsSend).Append("\n");
            sb.Append("  SmsReport: ").Append(SmsReport).Append("\n");
            sb.Append("  VoiceSend: ").Append(VoiceSend).Append("\n");
            sb.Append("  VoiceReport: ").Append(VoiceReport).Append("\n");
            sb.Append("  InvitationSend: ").Append(InvitationSend).Append("\n");
            sb.Append("  InvitationOpen: ").Append(InvitationOpen).Append("\n");
            sb.Append("  Unsubscribe: ").Append(Unsubscribe).Append("\n");
            sb.Append("  EmailSoftBounce: ").Append(EmailSoftBounce).Append("\n");
            sb.Append("  EmailHardBounce: ").Append(EmailHardBounce).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Resubscription: ").Append(Resubscription).Append("\n");
            sb.Append("  UnsubscribeReason: ").Append(UnsubscribeReason).Append("\n");
            sb.Append("  FacebookLike: ").Append(FacebookLike).Append("\n");
            sb.Append("  SocialShare: ").Append(SocialShare).Append("\n");
            sb.Append("  UnsubscribeManual: ").Append(UnsubscribeManual).Append("\n");
            sb.Append("  DoubleOptin: ").Append(DoubleOptin).Append("\n");
            sb.Append("  EmailSpamComplaint: ").Append(EmailSpamComplaint).Append("\n");
            sb.Append("  EmailFieldDisable: ").Append(EmailFieldDisable).Append("\n");
            sb.Append("  CellphoneFieldDisable: ").Append(CellphoneFieldDisable).Append("\n");
            sb.Append("  PhoneFieldDisable: ").Append(PhoneFieldDisable).Append("\n");
            sb.Append("  UnsubscribeApi: ").Append(UnsubscribeApi).Append("\n");
            sb.Append("  EmailFieldEnable: ").Append(EmailFieldEnable).Append("\n");
            sb.Append("  CellphoneFieldEnable: ").Append(CellphoneFieldEnable).Append("\n");
            sb.Append("  PhoneFieldEnable: ").Append(PhoneFieldEnable).Append("\n");
            sb.Append("  EditSubscription: ").Append(EditSubscription).Append("\n");
            sb.Append("  AutomationEvent: ").Append(AutomationEvent).Append("\n");
            sb.Append("  PushSend: ").Append(PushSend).Append("\n");
            sb.Append("  PushDelivered: ").Append(PushDelivered).Append("\n");
            sb.Append("  PushError: ").Append(PushError).Append("\n");
            sb.Append("  PushReceived: ").Append(PushReceived).Append("\n");
            sb.Append("  PushOpen: ").Append(PushOpen).Append("\n");
            sb.Append("  PushCanceled: ").Append(PushCanceled).Append("\n");
            sb.Append("  PushUnsubscription: ").Append(PushUnsubscription).Append("\n");
            sb.Append("  ReplyToEmail: ").Append(ReplyToEmail).Append("\n");
            sb.Append("  WebPushSend: ").Append(WebPushSend).Append("\n");
            sb.Append("  WebPushDelivered: ").Append(WebPushDelivered).Append("\n");
            sb.Append("  WebPushOpen: ").Append(WebPushOpen).Append("\n");
            sb.Append("  WebPushBounce: ").Append(WebPushBounce).Append("\n");
            sb.Append("  WebPushClick: ").Append(WebPushClick).Append("\n");
            sb.Append("  WebPushSubscription: ").Append(WebPushSubscription).Append("\n");
            sb.Append("  WebPushUnsubscription: ").Append(WebPushUnsubscription).Append("\n");
            sb.Append("  ForgetSubscription: ").Append(ForgetSubscription).Append("\n");
            sb.Append("  ChangeConsent: ").Append(ChangeConsent).Append("\n");
            sb.Append("  DoubleOptinResend: ").Append(DoubleOptinResend).Append("\n");
            sb.Append("  DoubleOptedit: ").Append(DoubleOptedit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContactActivityActivitiesFields);
        }

        /// <summary>
        /// Returns true if ContactActivityActivitiesFields instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactActivityActivitiesFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactActivityActivitiesFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Opens == input.Opens ||
                    (this.Opens != null &&
                    this.Opens.Equals(input.Opens))
                ) && 
                (
                    this.Clicks == input.Clicks ||
                    (this.Clicks != null &&
                    this.Clicks.Equals(input.Clicks))
                ) && 
                (
                    this.Recommends == input.Recommends ||
                    (this.Recommends != null &&
                    this.Recommends.Equals(input.Recommends))
                ) && 
                (
                    this.Conversion == input.Conversion ||
                    (this.Conversion != null &&
                    this.Conversion.Equals(input.Conversion))
                ) && 
                (
                    this.EmailSend == input.EmailSend ||
                    (this.EmailSend != null &&
                    this.EmailSend.Equals(input.EmailSend))
                ) && 
                (
                    this.SmsSend == input.SmsSend ||
                    (this.SmsSend != null &&
                    this.SmsSend.Equals(input.SmsSend))
                ) && 
                (
                    this.SmsReport == input.SmsReport ||
                    (this.SmsReport != null &&
                    this.SmsReport.Equals(input.SmsReport))
                ) && 
                (
                    this.VoiceSend == input.VoiceSend ||
                    (this.VoiceSend != null &&
                    this.VoiceSend.Equals(input.VoiceSend))
                ) && 
                (
                    this.VoiceReport == input.VoiceReport ||
                    (this.VoiceReport != null &&
                    this.VoiceReport.Equals(input.VoiceReport))
                ) && 
                (
                    this.InvitationSend == input.InvitationSend ||
                    (this.InvitationSend != null &&
                    this.InvitationSend.Equals(input.InvitationSend))
                ) && 
                (
                    this.InvitationOpen == input.InvitationOpen ||
                    (this.InvitationOpen != null &&
                    this.InvitationOpen.Equals(input.InvitationOpen))
                ) && 
                (
                    this.Unsubscribe == input.Unsubscribe ||
                    (this.Unsubscribe != null &&
                    this.Unsubscribe.Equals(input.Unsubscribe))
                ) && 
                (
                    this.EmailSoftBounce == input.EmailSoftBounce ||
                    (this.EmailSoftBounce != null &&
                    this.EmailSoftBounce.Equals(input.EmailSoftBounce))
                ) && 
                (
                    this.EmailHardBounce == input.EmailHardBounce ||
                    (this.EmailHardBounce != null &&
                    this.EmailHardBounce.Equals(input.EmailHardBounce))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.Resubscription == input.Resubscription ||
                    (this.Resubscription != null &&
                    this.Resubscription.Equals(input.Resubscription))
                ) && 
                (
                    this.UnsubscribeReason == input.UnsubscribeReason ||
                    (this.UnsubscribeReason != null &&
                    this.UnsubscribeReason.Equals(input.UnsubscribeReason))
                ) && 
                (
                    this.FacebookLike == input.FacebookLike ||
                    (this.FacebookLike != null &&
                    this.FacebookLike.Equals(input.FacebookLike))
                ) && 
                (
                    this.SocialShare == input.SocialShare ||
                    (this.SocialShare != null &&
                    this.SocialShare.Equals(input.SocialShare))
                ) && 
                (
                    this.UnsubscribeManual == input.UnsubscribeManual ||
                    (this.UnsubscribeManual != null &&
                    this.UnsubscribeManual.Equals(input.UnsubscribeManual))
                ) && 
                (
                    this.DoubleOptin == input.DoubleOptin ||
                    (this.DoubleOptin != null &&
                    this.DoubleOptin.Equals(input.DoubleOptin))
                ) && 
                (
                    this.EmailSpamComplaint == input.EmailSpamComplaint ||
                    (this.EmailSpamComplaint != null &&
                    this.EmailSpamComplaint.Equals(input.EmailSpamComplaint))
                ) && 
                (
                    this.EmailFieldDisable == input.EmailFieldDisable ||
                    (this.EmailFieldDisable != null &&
                    this.EmailFieldDisable.Equals(input.EmailFieldDisable))
                ) && 
                (
                    this.CellphoneFieldDisable == input.CellphoneFieldDisable ||
                    (this.CellphoneFieldDisable != null &&
                    this.CellphoneFieldDisable.Equals(input.CellphoneFieldDisable))
                ) && 
                (
                    this.PhoneFieldDisable == input.PhoneFieldDisable ||
                    (this.PhoneFieldDisable != null &&
                    this.PhoneFieldDisable.Equals(input.PhoneFieldDisable))
                ) && 
                (
                    this.UnsubscribeApi == input.UnsubscribeApi ||
                    (this.UnsubscribeApi != null &&
                    this.UnsubscribeApi.Equals(input.UnsubscribeApi))
                ) && 
                (
                    this.EmailFieldEnable == input.EmailFieldEnable ||
                    (this.EmailFieldEnable != null &&
                    this.EmailFieldEnable.Equals(input.EmailFieldEnable))
                ) && 
                (
                    this.CellphoneFieldEnable == input.CellphoneFieldEnable ||
                    (this.CellphoneFieldEnable != null &&
                    this.CellphoneFieldEnable.Equals(input.CellphoneFieldEnable))
                ) && 
                (
                    this.PhoneFieldEnable == input.PhoneFieldEnable ||
                    (this.PhoneFieldEnable != null &&
                    this.PhoneFieldEnable.Equals(input.PhoneFieldEnable))
                ) && 
                (
                    this.EditSubscription == input.EditSubscription ||
                    (this.EditSubscription != null &&
                    this.EditSubscription.Equals(input.EditSubscription))
                ) && 
                (
                    this.AutomationEvent == input.AutomationEvent ||
                    (this.AutomationEvent != null &&
                    this.AutomationEvent.Equals(input.AutomationEvent))
                ) && 
                (
                    this.PushSend == input.PushSend ||
                    (this.PushSend != null &&
                    this.PushSend.Equals(input.PushSend))
                ) && 
                (
                    this.PushDelivered == input.PushDelivered ||
                    (this.PushDelivered != null &&
                    this.PushDelivered.Equals(input.PushDelivered))
                ) && 
                (
                    this.PushError == input.PushError ||
                    (this.PushError != null &&
                    this.PushError.Equals(input.PushError))
                ) && 
                (
                    this.PushReceived == input.PushReceived ||
                    (this.PushReceived != null &&
                    this.PushReceived.Equals(input.PushReceived))
                ) && 
                (
                    this.PushOpen == input.PushOpen ||
                    (this.PushOpen != null &&
                    this.PushOpen.Equals(input.PushOpen))
                ) && 
                (
                    this.PushCanceled == input.PushCanceled ||
                    (this.PushCanceled != null &&
                    this.PushCanceled.Equals(input.PushCanceled))
                ) && 
                (
                    this.PushUnsubscription == input.PushUnsubscription ||
                    (this.PushUnsubscription != null &&
                    this.PushUnsubscription.Equals(input.PushUnsubscription))
                ) && 
                (
                    this.ReplyToEmail == input.ReplyToEmail ||
                    (this.ReplyToEmail != null &&
                    this.ReplyToEmail.Equals(input.ReplyToEmail))
                ) && 
                (
                    this.WebPushSend == input.WebPushSend ||
                    (this.WebPushSend != null &&
                    this.WebPushSend.Equals(input.WebPushSend))
                ) && 
                (
                    this.WebPushDelivered == input.WebPushDelivered ||
                    (this.WebPushDelivered != null &&
                    this.WebPushDelivered.Equals(input.WebPushDelivered))
                ) && 
                (
                    this.WebPushOpen == input.WebPushOpen ||
                    (this.WebPushOpen != null &&
                    this.WebPushOpen.Equals(input.WebPushOpen))
                ) && 
                (
                    this.WebPushBounce == input.WebPushBounce ||
                    (this.WebPushBounce != null &&
                    this.WebPushBounce.Equals(input.WebPushBounce))
                ) && 
                (
                    this.WebPushClick == input.WebPushClick ||
                    (this.WebPushClick != null &&
                    this.WebPushClick.Equals(input.WebPushClick))
                ) && 
                (
                    this.WebPushSubscription == input.WebPushSubscription ||
                    (this.WebPushSubscription != null &&
                    this.WebPushSubscription.Equals(input.WebPushSubscription))
                ) && 
                (
                    this.WebPushUnsubscription == input.WebPushUnsubscription ||
                    (this.WebPushUnsubscription != null &&
                    this.WebPushUnsubscription.Equals(input.WebPushUnsubscription))
                ) && 
                (
                    this.ForgetSubscription == input.ForgetSubscription ||
                    (this.ForgetSubscription != null &&
                    this.ForgetSubscription.Equals(input.ForgetSubscription))
                ) && 
                (
                    this.ChangeConsent == input.ChangeConsent ||
                    (this.ChangeConsent != null &&
                    this.ChangeConsent.Equals(input.ChangeConsent))
                ) && 
                (
                    this.DoubleOptinResend == input.DoubleOptinResend ||
                    (this.DoubleOptinResend != null &&
                    this.DoubleOptinResend.Equals(input.DoubleOptinResend))
                ) && 
                (
                    this.DoubleOptedit == input.DoubleOptedit ||
                    (this.DoubleOptedit != null &&
                    this.DoubleOptedit.Equals(input.DoubleOptedit))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Opens != null)
                    hashCode = hashCode * 59 + this.Opens.GetHashCode();
                if (this.Clicks != null)
                    hashCode = hashCode * 59 + this.Clicks.GetHashCode();
                if (this.Recommends != null)
                    hashCode = hashCode * 59 + this.Recommends.GetHashCode();
                if (this.Conversion != null)
                    hashCode = hashCode * 59 + this.Conversion.GetHashCode();
                if (this.EmailSend != null)
                    hashCode = hashCode * 59 + this.EmailSend.GetHashCode();
                if (this.SmsSend != null)
                    hashCode = hashCode * 59 + this.SmsSend.GetHashCode();
                if (this.SmsReport != null)
                    hashCode = hashCode * 59 + this.SmsReport.GetHashCode();
                if (this.VoiceSend != null)
                    hashCode = hashCode * 59 + this.VoiceSend.GetHashCode();
                if (this.VoiceReport != null)
                    hashCode = hashCode * 59 + this.VoiceReport.GetHashCode();
                if (this.InvitationSend != null)
                    hashCode = hashCode * 59 + this.InvitationSend.GetHashCode();
                if (this.InvitationOpen != null)
                    hashCode = hashCode * 59 + this.InvitationOpen.GetHashCode();
                if (this.Unsubscribe != null)
                    hashCode = hashCode * 59 + this.Unsubscribe.GetHashCode();
                if (this.EmailSoftBounce != null)
                    hashCode = hashCode * 59 + this.EmailSoftBounce.GetHashCode();
                if (this.EmailHardBounce != null)
                    hashCode = hashCode * 59 + this.EmailHardBounce.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.Resubscription != null)
                    hashCode = hashCode * 59 + this.Resubscription.GetHashCode();
                if (this.UnsubscribeReason != null)
                    hashCode = hashCode * 59 + this.UnsubscribeReason.GetHashCode();
                if (this.FacebookLike != null)
                    hashCode = hashCode * 59 + this.FacebookLike.GetHashCode();
                if (this.SocialShare != null)
                    hashCode = hashCode * 59 + this.SocialShare.GetHashCode();
                if (this.UnsubscribeManual != null)
                    hashCode = hashCode * 59 + this.UnsubscribeManual.GetHashCode();
                if (this.DoubleOptin != null)
                    hashCode = hashCode * 59 + this.DoubleOptin.GetHashCode();
                if (this.EmailSpamComplaint != null)
                    hashCode = hashCode * 59 + this.EmailSpamComplaint.GetHashCode();
                if (this.EmailFieldDisable != null)
                    hashCode = hashCode * 59 + this.EmailFieldDisable.GetHashCode();
                if (this.CellphoneFieldDisable != null)
                    hashCode = hashCode * 59 + this.CellphoneFieldDisable.GetHashCode();
                if (this.PhoneFieldDisable != null)
                    hashCode = hashCode * 59 + this.PhoneFieldDisable.GetHashCode();
                if (this.UnsubscribeApi != null)
                    hashCode = hashCode * 59 + this.UnsubscribeApi.GetHashCode();
                if (this.EmailFieldEnable != null)
                    hashCode = hashCode * 59 + this.EmailFieldEnable.GetHashCode();
                if (this.CellphoneFieldEnable != null)
                    hashCode = hashCode * 59 + this.CellphoneFieldEnable.GetHashCode();
                if (this.PhoneFieldEnable != null)
                    hashCode = hashCode * 59 + this.PhoneFieldEnable.GetHashCode();
                if (this.EditSubscription != null)
                    hashCode = hashCode * 59 + this.EditSubscription.GetHashCode();
                if (this.AutomationEvent != null)
                    hashCode = hashCode * 59 + this.AutomationEvent.GetHashCode();
                if (this.PushSend != null)
                    hashCode = hashCode * 59 + this.PushSend.GetHashCode();
                if (this.PushDelivered != null)
                    hashCode = hashCode * 59 + this.PushDelivered.GetHashCode();
                if (this.PushError != null)
                    hashCode = hashCode * 59 + this.PushError.GetHashCode();
                if (this.PushReceived != null)
                    hashCode = hashCode * 59 + this.PushReceived.GetHashCode();
                if (this.PushOpen != null)
                    hashCode = hashCode * 59 + this.PushOpen.GetHashCode();
                if (this.PushCanceled != null)
                    hashCode = hashCode * 59 + this.PushCanceled.GetHashCode();
                if (this.PushUnsubscription != null)
                    hashCode = hashCode * 59 + this.PushUnsubscription.GetHashCode();
                if (this.ReplyToEmail != null)
                    hashCode = hashCode * 59 + this.ReplyToEmail.GetHashCode();
                if (this.WebPushSend != null)
                    hashCode = hashCode * 59 + this.WebPushSend.GetHashCode();
                if (this.WebPushDelivered != null)
                    hashCode = hashCode * 59 + this.WebPushDelivered.GetHashCode();
                if (this.WebPushOpen != null)
                    hashCode = hashCode * 59 + this.WebPushOpen.GetHashCode();
                if (this.WebPushBounce != null)
                    hashCode = hashCode * 59 + this.WebPushBounce.GetHashCode();
                if (this.WebPushClick != null)
                    hashCode = hashCode * 59 + this.WebPushClick.GetHashCode();
                if (this.WebPushSubscription != null)
                    hashCode = hashCode * 59 + this.WebPushSubscription.GetHashCode();
                if (this.WebPushUnsubscription != null)
                    hashCode = hashCode * 59 + this.WebPushUnsubscription.GetHashCode();
                if (this.ForgetSubscription != null)
                    hashCode = hashCode * 59 + this.ForgetSubscription.GetHashCode();
                if (this.ChangeConsent != null)
                    hashCode = hashCode * 59 + this.ChangeConsent.GetHashCode();
                if (this.DoubleOptinResend != null)
                    hashCode = hashCode * 59 + this.DoubleOptinResend.GetHashCode();
                if (this.DoubleOptedit != null)
                    hashCode = hashCode * 59 + this.DoubleOptedit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
