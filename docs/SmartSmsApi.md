# org.egoi.client.api.Api.SmartSmsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionSendSmartSms**](SmartSmsApi.md#actionsendsmartsms) | **POST** /campaigns/smart-sms/{campaign_hash}/actions/send | Send smart sms message
[**CreateSmartSmsCampaign**](SmartSmsApi.md#createsmartsmscampaign) | **POST** /campaigns/smart-sms | Create new smart sms campaign
[**PatchSmartSmsCampaign**](SmartSmsApi.md#patchsmartsmscampaign) | **PATCH** /campaigns/smart-sms/{campaign_hash} | Update a specific smart sms campaign



## ActionSendSmartSms

> AcceptedResponse ActionSendSmartSms (string campaignHash, CampaignSmsSendRequest campaignSmsSendRequest)

Send smart sms message

Deploys and sends a smart sms message

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionSendSmartSmsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SmartSmsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var campaignSmsSendRequest = new CampaignSmsSendRequest(); // CampaignSmsSendRequest | Parameters for the 'send sms' action

            try
            {
                // Send smart sms message
                AcceptedResponse result = apiInstance.ActionSendSmartSms(campaignHash, campaignSmsSendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SmartSmsApi.ActionSendSmartSms: " + e.Message );
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
 **campaignSmsSendRequest** | [**CampaignSmsSendRequest**](CampaignSmsSendRequest.md)| Parameters for the &#39;send sms&#39; action | 

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
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
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


## CreateSmartSmsCampaign

> HashcodeCampaign CreateSmartSmsCampaign (SmartSmsCampaign smartSmsCampaign)

Create new smart sms campaign

Creates a new smart sms campaign.                         **DISCLAIMER:** A URL will be added at the end of your SMS

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateSmartSmsCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SmartSmsApi(Configuration.Default);
            var smartSmsCampaign = new SmartSmsCampaign(); // SmartSmsCampaign | Parameters for the Smart Sms Campaign

            try
            {
                // Create new smart sms campaign
                HashcodeCampaign result = apiInstance.CreateSmartSmsCampaign(smartSmsCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SmartSmsApi.CreateSmartSmsCampaign: " + e.Message );
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
 **smartSmsCampaign** | [**SmartSmsCampaign**](SmartSmsCampaign.md)| Parameters for the Smart Sms Campaign | 

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
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchSmartSmsCampaign

> HashcodeCampaign PatchSmartSmsCampaign (string campaignHash, SmartSmsCampaignPatchRequest smartSmsCampaignPatchRequest)

Update a specific smart sms campaign

Update smart sms campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchSmartSmsCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SmartSmsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var smartSmsCampaignPatchRequest = new SmartSmsCampaignPatchRequest(); // SmartSmsCampaignPatchRequest | Parameters for the Smart Sms Campaign

            try
            {
                // Update a specific smart sms campaign
                HashcodeCampaign result = apiInstance.PatchSmartSmsCampaign(campaignHash, smartSmsCampaignPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SmartSmsApi.PatchSmartSmsCampaign: " + e.Message );
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
 **smartSmsCampaignPatchRequest** | [**SmartSmsCampaignPatchRequest**](SmartSmsCampaignPatchRequest.md)| Parameters for the Smart Sms Campaign | 

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

