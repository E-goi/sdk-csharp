/* 
 * APIv3 (Beta)
 *
 *  # Introduction Just a quick peek!!! This is our new version of API. Remember, it is not stable yet!!! But we invite you play with it and give us your feedback ;) # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.   The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.   BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication   We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:  #!/bin/bash  curl -X GET 'https://api.egoiapp.com/my-account' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:  #!/bin/bash  curl -X POST 'http://api.egoiapp.com/tags' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>' \\  -H 'Content-Type: application/json' \\  -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services. * <b><a href='https://github.com/E-goi/sdk-java'>Java</a></b> * <b><a href='https://github.com/E-goi/sdk-php'>PHP</a></b> * <b><a href='https://github.com/E-goi/sdk-python'>Python</a></b>  <security-definitions/>
 *
 * OpenAPI spec version: 3.0.0-beta
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
    ///  Class for testing AttachTagResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AttachTagResponseTests
    {
        // TODO uncomment below to declare an instance variable for AttachTagResponse
        //private AttachTagResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AttachTagResponse
            //instance = new AttachTagResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AttachTagResponse
        /// </summary>
        [Test]
        public void AttachTagResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AttachTagResponse
            //Assert.IsInstanceOfType<AttachTagResponse> (instance, "variable 'instance' is a AttachTagResponse");
        }


        /// <summary>
        /// Test the property 'TagId'
        /// </summary>
        [Test]
        public void TagIdTest()
        {
            // TODO unit test for the property 'TagId'
        }
        /// <summary>
        /// Test the property 'Success'
        /// </summary>
        [Test]
        public void SuccessTest()
        {
            // TODO unit test for the property 'Success'
        }
        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Test]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }

    }

}
