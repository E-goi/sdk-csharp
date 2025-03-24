# org.egoi.client.api.Api.WebpushApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionEnableWebPushRss**](WebpushApi.md#actionenablewebpushrss) | **POST** /campaigns/webpush/rss/{campaign_hash}/actions/enable | Enable a rss webpush campaign
[**ActionSendWebPush**](WebpushApi.md#actionsendwebpush) | **POST** /campaigns/web-push/{campaign_hash}/actions/send | Send webpush message
[**CreateWebPushCampaign**](WebpushApi.md#createwebpushcampaign) | **POST** /campaigns/web-push | Create new webpush campaign
[**CreateWebPushRssCampaign**](WebpushApi.md#createwebpushrsscampaign) | **POST** /campaigns/webpush/rss | Create new webpush rss campaign
[**CreateWebpushSite**](WebpushApi.md#createwebpushsite) | **POST** /webpush/sites | Creates a webpush site
[**GetAllWebPushSites**](WebpushApi.md#getallwebpushsites) | **GET** /webpush/sites | Get all webpush sites
[**PatchWebPushCampaign**](WebpushApi.md#patchwebpushcampaign) | **PATCH** /campaigns/web-push/{campaign_hash} | Update a specific webpush campaign



## ActionEnableWebPushRss

> AcceptedResponse ActionEnableWebPushRss (string campaignHash)

Enable a rss webpush campaign

Enable rss webpush message

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionEnableWebPushRssExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new WebpushApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign

            try
            {
                // Enable a rss webpush campaign
                AcceptedResponse result = apiInstance.ActionEnableWebPushRss(campaignHash);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebpushApi.ActionEnableWebPushRss: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| Hash of the Campaign | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ActionSendWebPush

> AcceptedResponse ActionSendWebPush (string campaignHash, CampaignWebPushSendRequest campaignWebPushSendRequest)

Send webpush message

Deploys and sends a webpush message

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionSendWebPushExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new WebpushApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var campaignWebPushSendRequest = new CampaignWebPushSendRequest(); // CampaignWebPushSendRequest | Parameters for the 'send web-push' action

            try
            {
                // Send webpush message
                AcceptedResponse result = apiInstance.ActionSendWebPush(campaignHash, campaignWebPushSendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebpushApi.ActionSendWebPush: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| Hash of the Campaign | 
 **campaignWebPushSendRequest** | [**CampaignWebPushSendRequest**](CampaignWebPushSendRequest.md)| Parameters for the &#39;send web-push&#39; action | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateWebPushCampaign

> InlineResponse200 CreateWebPushCampaign (WebPushCampaign webPushCampaign)

Create new webpush campaign

Create a new webpush campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateWebPushCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new WebpushApi(Configuration.Default);
            var webPushCampaign = new WebPushCampaign(); // WebPushCampaign | Parameters for the webpush campaign

            try
            {
                // Create new webpush campaign
                InlineResponse200 result = apiInstance.CreateWebPushCampaign(webPushCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebpushApi.CreateWebPushCampaign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webPushCampaign** | [**WebPushCampaign**](WebPushCampaign.md)| Parameters for the webpush campaign | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateWebPushRssCampaign

> HashcodeCampaign CreateWebPushRssCampaign (WebPushRssCampaign webPushRssCampaign)

Create new webpush rss campaign

Create a new webpush rss campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateWebPushRssCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new WebpushApi(Configuration.Default);
            var webPushRssCampaign = new WebPushRssCampaign(); // WebPushRssCampaign | Parameters for the WebPush Campaign

            try
            {
                // Create new webpush rss campaign
                HashcodeCampaign result = apiInstance.CreateWebPushRssCampaign(webPushRssCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebpushApi.CreateWebPushRssCampaign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webPushRssCampaign** | [**WebPushRssCampaign**](WebPushRssCampaign.md)| Parameters for the WebPush Campaign | 

### Return type

[**HashcodeCampaign**](HashcodeCampaign.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateWebpushSite

> WebPushSite CreateWebpushSite (WebPushSite webPushSite)

Creates a webpush site

Create a new webpush site

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateWebpushSiteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new WebpushApi(Configuration.Default);
            var webPushSite = new WebPushSite(); // WebPushSite | Parameters for the webpush site

            try
            {
                // Creates a webpush site
                WebPushSite result = apiInstance.CreateWebpushSite(webPushSite);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebpushApi.CreateWebpushSite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webPushSite** | [**WebPushSite**](WebPushSite.md)| Parameters for the webpush site | 

### Return type

[**WebPushSite**](WebPushSite.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **408** | Request Timeout |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllWebPushSites

> TagCollection1 GetAllWebPushSites (int? offset = null, int? limit = null, string order = null, string orderBy = null, int? listId = null)

Get all webpush sites

Returns all wepush's sites

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllWebPushSitesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new WebpushApi(Configuration.Default);
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order sites (optional)  (default to list_id)
            var listId = 56;  // int? | Select sites referenced to a list (optional) 

            try
            {
                // Get all webpush sites
                TagCollection1 result = apiInstance.GetAllWebPushSites(offset, limit, order, orderBy, listId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebpushApi.GetAllWebPushSites: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order sites | [optional] [default to list_id]
 **listId** | **int?**| Select sites referenced to a list | [optional] 

### Return type

[**TagCollection1**](TagCollection1.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchWebPushCampaign

> InlineResponse200 PatchWebPushCampaign (string campaignHash, WebPushPatchCampaign webPushPatchCampaign)

Update a specific webpush campaign

Update a webpush campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchWebPushCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new WebpushApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var webPushPatchCampaign = new WebPushPatchCampaign(); // WebPushPatchCampaign | Parameters for the Webpush Campaign

            try
            {
                // Update a specific webpush campaign
                InlineResponse200 result = apiInstance.PatchWebPushCampaign(campaignHash, webPushPatchCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebpushApi.PatchWebPushCampaign: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| Hash of the Campaign | 
 **webPushPatchCampaign** | [**WebPushPatchCampaign**](WebPushPatchCampaign.md)| Parameters for the Webpush Campaign | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

