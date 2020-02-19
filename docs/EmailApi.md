# org.egoi.client.api.Api.EmailApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionEnableEmailRss**](EmailApi.md#actionenableemailrss) | **POST** /campaigns/email/rss/{campaign_hash}/actions/enable | Enables a rss email campaign
[**ActionSendEmail**](EmailApi.md#actionsendemail) | **POST** /campaigns/email/{campaign_hash}/actions/send | Send email message
[**CreateEmailCampaign**](EmailApi.md#createemailcampaign) | **POST** /campaigns/email | Create new email campaign
[**CreateEmailRssCampaign**](EmailApi.md#createemailrsscampaign) | **POST** /campaigns/email/rss | Create new email rss campaign
[**PatchEmailCampaign**](EmailApi.md#patchemailcampaign) | **PATCH** /campaigns/email/{campaign_hash} | Update a specific email campaign


<a name="actionenableemailrss"></a>
# **ActionEnableEmailRss**
> AcceptedResponse ActionEnableEmailRss (string campaignHash)

Enables a rss email campaign

Enables a rss email message

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionEnableEmailRssExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EmailApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign

            try
            {
                // Enables a rss email campaign
                AcceptedResponse result = apiInstance.ActionEnableEmailRss(campaignHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.ActionEnableEmailRss: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionsendemail"></a>
# **ActionSendEmail**
> AcceptedResponse ActionSendEmail (string campaignHash, CampaignEmailSendRequest campaignEmailSendRequest)

Send email message

Deploys and sends an email message

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionSendEmailExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EmailApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var campaignEmailSendRequest = new CampaignEmailSendRequest(); // CampaignEmailSendRequest | Parameters for the 'send email' action

            try
            {
                // Send email message
                AcceptedResponse result = apiInstance.ActionSendEmail(campaignHash, campaignEmailSendRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.ActionSendEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **campaignEmailSendRequest** | [**CampaignEmailSendRequest**](CampaignEmailSendRequest.md)| Parameters for the &#39;send email&#39; action | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemailcampaign"></a>
# **CreateEmailCampaign**
> HashcodeCampaign CreateEmailCampaign (EmailCampaignCreate emailCampaignCreate)

Create new email campaign

Create a new email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateEmailCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EmailApi();
            var emailCampaignCreate = new EmailCampaignCreate(); // EmailCampaignCreate | Parameters for the Email Campaign

            try
            {
                // Create new email campaign
                HashcodeCampaign result = apiInstance.CreateEmailCampaign(emailCampaignCreate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.CreateEmailCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaignCreate** | [**EmailCampaignCreate**](EmailCampaignCreate.md)| Parameters for the Email Campaign | 

### Return type

[**HashcodeCampaign**](HashcodeCampaign.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemailrsscampaign"></a>
# **CreateEmailRssCampaign**
> HashcodeCampaign CreateEmailRssCampaign (EmailRssCampaignCreate emailRssCampaignCreate)

Create new email rss campaign

Create a new email rss campaign

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateEmailRssCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EmailApi();
            var emailRssCampaignCreate = new EmailRssCampaignCreate(); // EmailRssCampaignCreate | Parameters for the Email Campaign

            try
            {
                // Create new email rss campaign
                HashcodeCampaign result = apiInstance.CreateEmailRssCampaign(emailRssCampaignCreate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.CreateEmailRssCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailRssCampaignCreate** | [**EmailRssCampaignCreate**](EmailRssCampaignCreate.md)| Parameters for the Email Campaign | 

### Return type

[**HashcodeCampaign**](HashcodeCampaign.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchemailcampaign"></a>
# **PatchEmailCampaign**
> HashcodeCampaign PatchEmailCampaign (string campaignHash, EmailCampaignPatch emailCampaignPatch)

Update a specific email campaign

Update email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchEmailCampaignExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EmailApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var emailCampaignPatch = new EmailCampaignPatch(); // EmailCampaignPatch | Parameters for the Email Campaign

            try
            {
                // Update a specific email campaign
                HashcodeCampaign result = apiInstance.PatchEmailCampaign(campaignHash, emailCampaignPatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.PatchEmailCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **emailCampaignPatch** | [**EmailCampaignPatch**](EmailCampaignPatch.md)| Parameters for the Email Campaign | 

### Return type

[**HashcodeCampaign**](HashcodeCampaign.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

