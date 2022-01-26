# org.egoi.client.api.Api.CampaignGroupsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCampaignGroup**](CampaignGroupsApi.md#createcampaigngroup) | **POST** /campaign-groups | Create new campaign group
[**DeleteCampaignGroup**](CampaignGroupsApi.md#deletecampaigngroup) | **DELETE** /campaign-groups/{group_id} | Remove Campaign Group
[**GetAllCampaignGroups**](CampaignGroupsApi.md#getallcampaigngroups) | **GET** /campaign-groups | Get all campaign groups
[**UpdateCampaignGroup**](CampaignGroupsApi.md#updatecampaigngroup) | **PUT** /campaign-groups/{group_id} | Update a specific campaign group



## CreateCampaignGroup

> CampaignGroup CreateCampaignGroup (CampaignGroupPost campaignGroupPost)

Create new campaign group

Create a new campaign group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateCampaignGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi(Configuration.Default);
            var campaignGroupPost = new CampaignGroupPost(); // CampaignGroupPost | Parameters for the Campaign Group

            try
            {
                // Create new campaign group
                CampaignGroup result = apiInstance.CreateCampaignGroup(campaignGroupPost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.CreateCampaignGroup: " + e.Message );
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
 **campaignGroupPost** | [**CampaignGroupPost**](CampaignGroupPost.md)| Parameters for the Campaign Group | 

### Return type

[**CampaignGroup**](CampaignGroup.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
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


## DeleteCampaignGroup

> void DeleteCampaignGroup (int groupId)

Remove Campaign Group

Remove campaign group information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteCampaignGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi(Configuration.Default);
            var groupId = 56;  // int | ID of the Campaign Group

            try
            {
                // Remove Campaign Group
                apiInstance.DeleteCampaignGroup(groupId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.DeleteCampaignGroup: " + e.Message );
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
 **groupId** | **int**| ID of the Campaign Group | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllCampaignGroups

> CampaignGroupCollection GetAllCampaignGroups (int? groupId = null, string name = null, int? limit = null, int? offset = null)

Get all campaign groups

Returns all campaign groups

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllCampaignGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi(Configuration.Default);
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.GetAllCampaignGroups: " + e.Message );
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


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
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


## UpdateCampaignGroup

> CampaignGroup UpdateCampaignGroup (int groupId, CampaignGroupPost campaignGroupPost)

Update a specific campaign group

Update a campaign group

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class UpdateCampaignGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignGroupsApi(Configuration.Default);
            var groupId = 56;  // int | ID of the Campaign Group
            var campaignGroupPost = new CampaignGroupPost(); // CampaignGroupPost | Parameters for the Campaign Group

            try
            {
                // Update a specific campaign group
                CampaignGroup result = apiInstance.UpdateCampaignGroup(groupId, campaignGroupPost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CampaignGroupsApi.UpdateCampaignGroup: " + e.Message );
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
 **groupId** | **int**| ID of the Campaign Group | 
 **campaignGroupPost** | [**CampaignGroupPost**](CampaignGroupPost.md)| Parameters for the Campaign Group | 

### Return type

[**CampaignGroup**](CampaignGroup.md)

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

