/* 
 * APIv3 (Beta)
 *
 *  # Introduction Just a quick peek!!! This is our new version of API. Remember, it is not stable yet!!! But we invite you play with it and give us your feedback ;) # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.   The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.   BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication   We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:  #!/bin/bash  curl -X GET 'https://api.egoiapp.com/my-account' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:  #!/bin/bash  curl -X POST 'http://api.egoiapp.com/tags' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>' \\  -H 'Content-Type: application/json' \\  -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services. * <b><a href='https://github.com/E-goi/sdk-java'>Java</a></b> * <b><a href='https://github.com/E-goi/sdk-php'>PHP</a></b> * <b><a href='https://github.com/E-goi/sdk-python'>Python</a></b>  <security-definitions/>
 *
 * OpenAPI spec version: 3.0.0-beta
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
    ///  Class for testing WebpushApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WebpushApiTests
    {
        private WebpushApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WebpushApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WebpushApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WebpushApi
            //Assert.IsInstanceOfType(typeof(WebpushApi), instance, "instance is a WebpushApi");
        }

        
        /// <summary>
        /// Test ActionEnableWebPushRss
        /// </summary>
        [Test]
        public void ActionEnableWebPushRssTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string campaignHash = null;
            //var response = instance.ActionEnableWebPushRss(campaignHash);
            //Assert.IsInstanceOf<AcceptedResponse> (response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test ActionSendWebPush
        /// </summary>
        [Test]
        public void ActionSendWebPushTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string campaignHash = null;
            //CampaignWebPushSendRequest campaignWebPushSendRequest = null;
            //var response = instance.ActionSendWebPush(campaignHash, campaignWebPushSendRequest);
            //Assert.IsInstanceOf<AcceptedResponse> (response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test CreateWebPushCampaign
        /// </summary>
        [Test]
        public void CreateWebPushCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebPushCampaign webPushCampaign = null;
            //var response = instance.CreateWebPushCampaign(webPushCampaign);
            //Assert.IsInstanceOf<CampaignHash> (response, "response is CampaignHash");
        }
        
        /// <summary>
        /// Test CreateWebPushRssCampaign
        /// </summary>
        [Test]
        public void CreateWebPushRssCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebPushRssCampaign webPushRssCampaign = null;
            //var response = instance.CreateWebPushRssCampaign(webPushRssCampaign);
            //Assert.IsInstanceOf<HashcodeCampaign> (response, "response is HashcodeCampaign");
        }
        
        /// <summary>
        /// Test GetAllWebPushSites
        /// </summary>
        [Test]
        public void GetAllWebPushSitesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //string order = null;
            //string orderBy = null;
            //int? listId = null;
            //var response = instance.GetAllWebPushSites(offset, limit, order, orderBy, listId);
            //Assert.IsInstanceOf<TagCollection1> (response, "response is TagCollection1");
        }
        
        /// <summary>
        /// Test PatchWebPushCampaign
        /// </summary>
        [Test]
        public void PatchWebPushCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string campaignHash = null;
            //WebPushPatchCampaign webPushPatchCampaign = null;
            //var response = instance.PatchWebPushCampaign(campaignHash, webPushPatchCampaign);
            //Assert.IsInstanceOf<CampaignHash> (response, "response is CampaignHash");
        }
        
    }

}
