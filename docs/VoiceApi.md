# org.egoi.client.api.Api.VoiceApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionSendVoice**](VoiceApi.md#actionsendvoice) | **POST** /campaigns/voice/{campaign_hash}/actions/send | Send voice message
[**CreateVoiceCampaign**](VoiceApi.md#createvoicecampaign) | **POST** /campaigns/voice | Create new voice campaign
[**PatchVoiceCampaign**](VoiceApi.md#patchvoicecampaign) | **PATCH** /campaigns/voice/{campaign_hash} | Update a specific voice campaign



## ActionSendVoice

> AcceptedResponse ActionSendVoice (string campaignHash, CampaignVoiceSendRequest campaignVoiceSendRequest)

Send voice message

Deploys and sends an voice message

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionSendVoiceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VoiceApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var campaignVoiceSendRequest = new CampaignVoiceSendRequest(); // CampaignVoiceSendRequest | Parameters for the 'send voice' action

            try
            {
                // Send voice message
                AcceptedResponse result = apiInstance.ActionSendVoice(campaignHash, campaignVoiceSendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VoiceApi.ActionSendVoice: " + e.Message );
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
 **campaignVoiceSendRequest** | [**CampaignVoiceSendRequest**](CampaignVoiceSendRequest.md)| Parameters for the &#39;send voice&#39; action | 

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


## CreateVoiceCampaign

> CampaignHash CreateVoiceCampaign (VoiceCampaign voiceCampaign)

Create new voice campaign

Create a new voice campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateVoiceCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VoiceApi(Configuration.Default);
            var voiceCampaign = new VoiceCampaign(); // VoiceCampaign | Parameters for the Voice Campaign

            try
            {
                // Create new voice campaign
                CampaignHash result = apiInstance.CreateVoiceCampaign(voiceCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VoiceApi.CreateVoiceCampaign: " + e.Message );
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
 **voiceCampaign** | [**VoiceCampaign**](VoiceCampaign.md)| Parameters for the Voice Campaign | 

### Return type

[**CampaignHash**](CampaignHash.md)

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


## PatchVoiceCampaign

> InlineResponse200 PatchVoiceCampaign (string campaignHash, VoicePatchCampaign voicePatchCampaign)

Update a specific voice campaign

Update a voice campaign

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchVoiceCampaignExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VoiceApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var voicePatchCampaign = new VoicePatchCampaign(); // VoicePatchCampaign | Parameters for the Voice Campaign

            try
            {
                // Update a specific voice campaign
                InlineResponse200 result = apiInstance.PatchVoiceCampaign(campaignHash, voicePatchCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VoiceApi.PatchVoiceCampaign: " + e.Message );
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
 **voicePatchCampaign** | [**VoicePatchCampaign**](VoicePatchCampaign.md)| Parameters for the Voice Campaign | 

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

