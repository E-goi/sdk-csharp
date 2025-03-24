# org.egoi.client.api.Api.PushApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionSendPush**](PushApi.md#actionsendpush) | **POST** /campaigns/push/{campaign_hash}/actions/send | Send push message
[**CreatePushCampaign**](PushApi.md#createpushcampaign) | **POST** /campaigns/push | Create new push campaign
[**GetPushApp**](PushApi.md#getpushapp) | **GET** /push/apps/{app_id} | Get a Push application from E-goi
[**GetPushApps**](PushApi.md#getpushapps) | **GET** /push/apps | Get all Push applications from E-goi
[**PatchPushCampaign**](PushApi.md#patchpushcampaign) | **PATCH** /campaigns/push/{campaign_hash} | Update a specific push campaign
[**RegisterPushEvent**](PushApi.md#registerpushevent) | **POST** /push/apps/{app_id}/event | Registers an event from the push notification.
[**RegisterPushToken**](PushApi.md#registerpushtoken) | **POST** /push/apps/{app_id}/token | Registers a Firebase token



## ActionSendPush

> AcceptedResponse ActionSendPush (string campaignHash, CampaignPushSendRequest campaignPushSendRequest)

Send push message

Deploys and sends a push message

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionSendPushExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PushApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var campaignPushSendRequest = new CampaignPushSendRequest(); // CampaignPushSendRequest | Parameters for the 'send push' action

            try
            {
                // Send push message
                AcceptedResponse result = apiInstance.ActionSendPush(campaignHash, campaignPushSendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PushApi.ActionSendPush: " + e.Message );
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
 **campaignPushSendRequest** | [**CampaignPushSendRequest**](CampaignPushSendRequest.md)| Parameters for the &#39;send push&#39; action | 

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


## CreatePushCampaign

> HashcodeCampaign CreatePushCampaign (PushCampaignPostRequest pushCampaignPostRequest)

Create new push campaign

Create a new push campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreatePushCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PushApi(Configuration.Default);
            var pushCampaignPostRequest = new PushCampaignPostRequest(); // PushCampaignPostRequest | Parameters for the push campaign

            try
            {
                // Create new push campaign
                HashcodeCampaign result = apiInstance.CreatePushCampaign(pushCampaignPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PushApi.CreatePushCampaign: " + e.Message );
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
 **pushCampaignPostRequest** | [**PushCampaignPostRequest**](PushCampaignPostRequest.md)| Parameters for the push campaign | 

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
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPushApp

> AppStructure GetPushApp (string appId)

Get a Push application from E-goi

Get a Push application from E-goi

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetPushAppExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PushApi(Configuration.Default);
            var appId = appId_example;  // string | ID of the E-goi push app.

            try
            {
                // Get a Push application from E-goi
                AppStructure result = apiInstance.GetPushApp(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PushApi.GetPushApp: " + e.Message );
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
 **appId** | **string**| ID of the E-goi push app. | 

### Return type

[**AppStructure**](AppStructure.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPushApps

> List&lt;AppStructure&gt; GetPushApps (int? listId = null)

Get all Push applications from E-goi

Get all Push applications from E-goi

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetPushAppsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PushApi(Configuration.Default);
            var listId = 56;  // int? | ID of the list to search for. (optional) 

            try
            {
                // Get all Push applications from E-goi
                List<AppStructure> result = apiInstance.GetPushApps(listId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PushApi.GetPushApps: " + e.Message );
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
 **listId** | **int?**| ID of the list to search for. | [optional] 

### Return type

[**List&lt;AppStructure&gt;**](AppStructure.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchPushCampaign

> HashcodeCampaign PatchPushCampaign (string campaignHash, PushCampaignPatchRequest pushCampaignPatchRequest)

Update a specific push campaign

Update push campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchPushCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PushApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var pushCampaignPatchRequest = new PushCampaignPatchRequest(); // PushCampaignPatchRequest | Parameters for the push campaign

            try
            {
                // Update a specific push campaign
                HashcodeCampaign result = apiInstance.PatchPushCampaign(campaignHash, pushCampaignPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PushApi.PatchPushCampaign: " + e.Message );
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
 **pushCampaignPatchRequest** | [**PushCampaignPatchRequest**](PushCampaignPatchRequest.md)| Parameters for the push campaign | 

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


## RegisterPushEvent

> PushResponse RegisterPushEvent (string appId, PushEvent pushEvent)

Registers an event from the push notification.

Registers a Firebase token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class RegisterPushEventExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PushApi(Configuration.Default);
            var appId = appId_example;  // string | ID of the E-goi push app.
            var pushEvent = new PushEvent(); // PushEvent | Parameters for the event

            try
            {
                // Registers an event from the push notification.
                PushResponse result = apiInstance.RegisterPushEvent(appId, pushEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PushApi.RegisterPushEvent: " + e.Message );
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
 **appId** | **string**| ID of the E-goi push app. | 
 **pushEvent** | [**PushEvent**](PushEvent.md)| Parameters for the event | 

### Return type

[**PushResponse**](PushResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **401** | Unauthorized |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RegisterPushToken

> PushResponse RegisterPushToken (string appId, PushToken pushToken)

Registers a Firebase token

Registers a Firebase token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class RegisterPushTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new PushApi(Configuration.Default);
            var appId = appId_example;  // string | ID of the E-goi push app.
            var pushToken = new PushToken(); // PushToken | Parameters for the token

            try
            {
                // Registers a Firebase token
                PushResponse result = apiInstance.RegisterPushToken(appId, pushToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PushApi.RegisterPushToken: " + e.Message );
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
 **appId** | **string**| ID of the E-goi push app. | 
 **pushToken** | [**PushToken**](PushToken.md)| Parameters for the token | 

### Return type

[**PushResponse**](PushResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **401** | Unauthorized |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

