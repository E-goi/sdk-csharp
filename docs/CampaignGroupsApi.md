# org.egoi.client.api.Api.CampaignGroupsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCampaignGroup**](CampaignGroupsApi.md#createcampaigngroup) | **POST** /campaign-groups | Create new campaign group
[**DeleteCampaignGroup**](CampaignGroupsApi.md#deletecampaigngroup) | **DELETE** /campaign-groups/{group_id} | Remove Campaign Group
[**GetAllCampaignGroups**](CampaignGroupsApi.md#getallcampaigngroups) | **GET** /campaign-groups | Get all campaign groups
[**UpdateCampaignGroup**](CampaignGroupsApi.md#updatecampaigngroup) | **PUT** /campaign-groups/{group_id} | Update a specific campaign group


<a name="createcampaigngroup"></a>
# **CreateCampaignGroup**
> CampaignGroup CreateCampaignGroup (CampaignGroup campaignGroup)

Create new campaign group

Create a new campaign group

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateCampaignGroupExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi();
            var campaignGroup = new CampaignGroup(); // CampaignGroup | Parameters for the Campaign Group

            try
            {
                // Create new campaign group
                CampaignGroup result = apiInstance.CreateCampaignGroup(campaignGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.CreateCampaignGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignGroup** | [**CampaignGroup**](CampaignGroup.md)| Parameters for the Campaign Group | 

### Return type

[**CampaignGroup**](CampaignGroup.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecampaigngroup"></a>
# **DeleteCampaignGroup**
> void DeleteCampaignGroup (int? groupId)

Remove Campaign Group

Remove campaign group information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteCampaignGroupExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi();
            var groupId = 56;  // int? | ID of the Campaign Group

            try
            {
                // Remove Campaign Group
                apiInstance.DeleteCampaignGroup(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.DeleteCampaignGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| ID of the Campaign Group | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcampaigngroups"></a>
# **GetAllCampaignGroups**
> CampaignGroupCollection GetAllCampaignGroups (int? groupId = null, string name = null, int? limit = null, int? offset = null)

Get all campaign groups

Returns all campaign groups

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllCampaignGroupsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi();
            var groupId = 56;  // int? | Reference attribute to campaign group id (optional) 
            var name = name_example;  // string | Reference attribute to campaign group id (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 

            try
            {
                // Get all campaign groups
                CampaignGroupCollection result = apiInstance.GetAllCampaignGroups(groupId, name, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.GetAllCampaignGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| Reference attribute to campaign group id | [optional] 
 **name** | **string**| Reference attribute to campaign group id | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 

### Return type

[**CampaignGroupCollection**](CampaignGroupCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaigngroup"></a>
# **UpdateCampaignGroup**
> CampaignGroup UpdateCampaignGroup (int? groupId, CampaignGroup campaignGroup)

Update a specific campaign group

Update a campaign group

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class UpdateCampaignGroupExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi();
            var groupId = 56;  // int? | ID of the Campaign Group
            var campaignGroup = new CampaignGroup(); // CampaignGroup | Parameters for the Campaign Group

            try
            {
                // Update a specific campaign group
                CampaignGroup result = apiInstance.UpdateCampaignGroup(groupId, campaignGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.UpdateCampaignGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| ID of the Campaign Group | 
 **campaignGroup** | [**CampaignGroup**](CampaignGroup.md)| Parameters for the Campaign Group | 

### Return type

[**CampaignGroup**](CampaignGroup.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

