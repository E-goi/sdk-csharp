# org.egoi.client.api.Api.CampaignsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCampaigns**](CampaignsApi.md#deletecampaigns) | **DELETE** /campaigns/{campaign_hash} | Remove Campaign
[**GetAllCampaigns**](CampaignsApi.md#getallcampaigns) | **GET** /campaigns | Get all Campaigns



## DeleteCampaigns

> void DeleteCampaigns (string campaignHash)

Remove Campaign

Remove campaign information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteCampaignsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | ID of the Campaign

            try
            {
                // Remove Campaign
                apiInstance.DeleteCampaigns(campaignHash);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CampaignsApi.DeleteCampaigns: " + e.Message );
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
 **campaignHash** | **string**| ID of the Campaign | 

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


## GetAllCampaigns

> CampaignsCollection GetAllCampaigns (string channel = null, string campaignHash = null, int? listId = null, string status = null, string internalName = null, int? createdBy = null, int? groupId = null, DateTime? createdMin = null, DateTime? createdMax = null, DateTime? updatedMin = null, DateTime? updatedMax = null, DateTime? startDateMin = null, DateTime? startDateMax = null, DateTime? endDateMin = null, DateTime? endDateMax = null, DateTime? scheduleDateMin = null, DateTime? scheduleDateMax = null, int? offset = null, int? limit = null, string order = null, string orderBy = null)

Get all Campaigns

Returns all campaigns

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllCampaignsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CampaignsApi(Configuration.Default);
            var channel = channel_example;  // string | Channel of the campaign (optional) 
            var campaignHash = campaignHash_example;  // string | Hash of the campaign (optional) 
            var listId = 56;  // int? | ID of the list where the campaign belongs (optional) 
            var status = status_example;  // string | Status of the campaign (optional) 
            var internalName = internalName_example;  // string | Internal name of the campaign (optional) 
            var createdBy = 56;  // int? | ID of the user who created the campaign (optional) 
            var groupId = 56;  // int? | ID of the group where the campaign belongs (optional) 
            var createdMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Created initial date (optional) 
            var createdMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Created finish (optional) 
            var updatedMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Updated initial (optional) 
            var updatedMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Updated finish (optional) 
            var startDateMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date initial (optional) 
            var startDateMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date finish (optional) 
            var endDateMin = 2013-10-20T19:20:30+01:00;  // DateTime? | End Date initial (optional) 
            var endDateMax = 2013-10-20T19:20:30+01:00;  // DateTime? | End Date finish (optional) 
            var scheduleDateMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Schedule Date initial (optional) 
            var scheduleDateMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Schedule Date finish (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order campaigns (optional)  (default to created)

            try
            {
                // Get all Campaigns
                CampaignsCollection result = apiInstance.GetAllCampaigns(channel, campaignHash, listId, status, internalName, createdBy, groupId, createdMin, createdMax, updatedMin, updatedMax, startDateMin, startDateMax, endDateMin, endDateMax, scheduleDateMin, scheduleDateMax, offset, limit, order, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CampaignsApi.GetAllCampaigns: " + e.Message );
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
 **channel** | **string**| Channel of the campaign | [optional] 
 **campaignHash** | **string**| Hash of the campaign | [optional] 
 **listId** | **int?**| ID of the list where the campaign belongs | [optional] 
 **status** | **string**| Status of the campaign | [optional] 
 **internalName** | **string**| Internal name of the campaign | [optional] 
 **createdBy** | **int?**| ID of the user who created the campaign | [optional] 
 **groupId** | **int?**| ID of the group where the campaign belongs | [optional] 
 **createdMin** | **DateTime?**| Created initial date | [optional] 
 **createdMax** | **DateTime?**| Created finish | [optional] 
 **updatedMin** | **DateTime?**| Updated initial | [optional] 
 **updatedMax** | **DateTime?**| Updated finish | [optional] 
 **startDateMin** | **DateTime?**| Start date initial | [optional] 
 **startDateMax** | **DateTime?**| Start date finish | [optional] 
 **endDateMin** | **DateTime?**| End Date initial | [optional] 
 **endDateMax** | **DateTime?**| End Date finish | [optional] 
 **scheduleDateMin** | **DateTime?**| Schedule Date initial | [optional] 
 **scheduleDateMax** | **DateTime?**| Schedule Date finish | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order campaigns | [optional] [default to created]

### Return type

[**CampaignsCollection**](CampaignsCollection.md)

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

