# org.egoi.client.api.Api.SmsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionSendSms**](SmsApi.md#actionsendsms) | **POST** /campaigns/sms/{campaign_hash}/actions/send | Send sms message
[**CreateSmsCampaign**](SmsApi.md#createsmscampaign) | **POST** /campaigns/sms | Create new sms campaign
[**PatchSmsCampaign**](SmsApi.md#patchsmscampaign) | **PATCH** /campaigns/sms/{campaign_hash} | Update a specific sms campaign


<a name="actionsendsms"></a>
# **ActionSendSms**
> AcceptedResponse ActionSendSms (string campaignHash, CampaignSmsSendRequest campaignSmsSendRequest)

Send sms message

Deploys and sends an sms message

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionSendSmsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SmsApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var campaignSmsSendRequest = new CampaignSmsSendRequest(); // CampaignSmsSendRequest | Parameters for the 'send sms' action

            try
            {
                // Send sms message
                AcceptedResponse result = apiInstance.ActionSendSms(campaignHash, campaignSmsSendRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.ActionSendSms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **campaignSmsSendRequest** | [**CampaignSmsSendRequest**](CampaignSmsSendRequest.md)| Parameters for the &#39;send sms&#39; action | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsmscampaign"></a>
# **CreateSmsCampaign**
> HashcodeCampaign CreateSmsCampaign (SmsCampaign smsCampaign)

Create new sms campaign

Create a new sms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateSmsCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SmsApi();
            var smsCampaign = new SmsCampaign(); // SmsCampaign | Parameters for the Sms Campaign

            try
            {
                // Create new sms campaign
                HashcodeCampaign result = apiInstance.CreateSmsCampaign(smsCampaign);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.CreateSmsCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smsCampaign** | [**SmsCampaign**](SmsCampaign.md)| Parameters for the Sms Campaign | 

### Return type

[**HashcodeCampaign**](HashcodeCampaign.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsmscampaign"></a>
# **PatchSmsCampaign**
> HashcodeCampaign PatchSmsCampaign (string campaignHash, SmsCampaignPatchRequest smsCampaignPatchRequest)

Update a specific sms campaign

Update sms campaign

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchSmsCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SmsApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var smsCampaignPatchRequest = new SmsCampaignPatchRequest(); // SmsCampaignPatchRequest | Parameters for the Sms Campaign

            try
            {
                // Update a specific sms campaign
                HashcodeCampaign result = apiInstance.PatchSmsCampaign(campaignHash, smsCampaignPatchRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.PatchSmsCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **smsCampaignPatchRequest** | [**SmsCampaignPatchRequest**](SmsCampaignPatchRequest.md)| Parameters for the Sms Campaign | 

### Return type

[**HashcodeCampaign**](HashcodeCampaign.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

