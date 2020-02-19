# org.egoi.client.api.Api.VoiceApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionSendVoice**](VoiceApi.md#actionsendvoice) | **POST** /campaigns/voice/{campaign_hash}/actions/send | Send voice message
[**CreateVoiceCampaign**](VoiceApi.md#createvoicecampaign) | **POST** /campaigns/voice | Create new voice campaign
[**PatchVoiceCampaign**](VoiceApi.md#patchvoicecampaign) | **PATCH** /campaigns/voice/{campaign_hash} | Update a specific voice campaign


<a name="actionsendvoice"></a>
# **ActionSendVoice**
> AcceptedResponse ActionSendVoice (string campaignHash, CampaignVoiceSendRequest campaignVoiceSendRequest)

Send voice message

Deploys and sends an voice message

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionSendVoiceExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VoiceApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var campaignVoiceSendRequest = new CampaignVoiceSendRequest(); // CampaignVoiceSendRequest | Parameters for the 'send voice' action

            try
            {
                // Send voice message
                AcceptedResponse result = apiInstance.ActionSendVoice(campaignHash, campaignVoiceSendRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.ActionSendVoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **campaignVoiceSendRequest** | [**CampaignVoiceSendRequest**](CampaignVoiceSendRequest.md)| Parameters for the &#39;send voice&#39; action | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvoicecampaign"></a>
# **CreateVoiceCampaign**
> CampaignHash CreateVoiceCampaign (VoiceCampaign voiceCampaign)

Create new voice campaign

Create a new voice campaign

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateVoiceCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VoiceApi();
            var voiceCampaign = new VoiceCampaign(); // VoiceCampaign | Parameters for the Voice Campaign

            try
            {
                // Create new voice campaign
                CampaignHash result = apiInstance.CreateVoiceCampaign(voiceCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.CreateVoiceCampaign: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchvoicecampaign"></a>
# **PatchVoiceCampaign**
> CampaignHash PatchVoiceCampaign (string campaignHash, VoicePatchCampaign voicePatchCampaign)

Update a specific voice campaign

Update a voice campaign

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchVoiceCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VoiceApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var voicePatchCampaign = new VoicePatchCampaign(); // VoicePatchCampaign | Parameters for the Voice Campaign

            try
            {
                // Update a specific voice campaign
                CampaignHash result = apiInstance.PatchVoiceCampaign(campaignHash, voicePatchCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VoiceApi.PatchVoiceCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **voicePatchCampaign** | [**VoicePatchCampaign**](VoicePatchCampaign.md)| Parameters for the Voice Campaign | 

### Return type

[**CampaignHash**](CampaignHash.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

