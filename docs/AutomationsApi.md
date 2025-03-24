# org.egoi.client.api.Api.AutomationsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAutomation**](AutomationsApi.md#deleteautomation) | **DELETE** /automations/{automation_id} | Remove automation
[**GetAllActions**](AutomationsApi.md#getallactions) | **GET** /automations/{automation_id}/actions | Get all actions from given automation
[**GetAllAutomations**](AutomationsApi.md#getallautomations) | **GET** /automations | Get all automations



## DeleteAutomation

> void DeleteAutomation (int automationId)

Remove automation

Remove automation information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteAutomationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AutomationsApi(Configuration.Default);
            var automationId = 56;  // int | ID of the Automation

            try
            {
                // Remove automation
                apiInstance.DeleteAutomation(automationId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomationsApi.DeleteAutomation: " + e.Message );
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
 **automationId** | **int**| ID of the Automation | 

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


## GetAllActions

> AutomationActionsCollection GetAllActions (int? automationId = null, int? offset = null, int? limit = null)

Get all actions from given automation

Returns all actions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllActionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AutomationsApi(Configuration.Default);
            var automationId = 56;  // int? | Reference attribute to automation id (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)

            try
            {
                // Get all actions from given automation
                AutomationActionsCollection result = apiInstance.GetAllActions(automationId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomationsApi.GetAllActions: " + e.Message );
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
 **automationId** | **int?**| Reference attribute to automation id | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]

### Return type

[**AutomationActionsCollection**](AutomationActionsCollection.md)

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


## GetAllAutomations

> AutomationCollection GetAllAutomations (int? automationId = null, string title = null, int? createdBy = null, int? listId = null, string status = null, int? offset = null, int? limit = null, string order = null, string orderBy = null)

Get all automations

Returns all automations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllAutomationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AutomationsApi(Configuration.Default);
            var automationId = 56;  // int? | Reference attribute to automation id (optional) 
            var title = title_example;  // string | Reference attribute to title (optional) 
            var createdBy = 56;  // int? | Reference attribute to created by (optional) 
            var listId = 56;  // int? | ID of the list that owns the automation (optional) 
            var status = status_example;  // string | Automation status (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order automations (optional)  (default to automation_id)

            try
            {
                // Get all automations
                AutomationCollection result = apiInstance.GetAllAutomations(automationId, title, createdBy, listId, status, offset, limit, order, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomationsApi.GetAllAutomations: " + e.Message );
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
 **automationId** | **int?**| Reference attribute to automation id | [optional] 
 **title** | **string**| Reference attribute to title | [optional] 
 **createdBy** | **int?**| Reference attribute to created by | [optional] 
 **listId** | **int?**| ID of the list that owns the automation | [optional] 
 **status** | **string**| Automation status | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order automations | [optional] [default to automation_id]

### Return type

[**AutomationCollection**](AutomationCollection.md)

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

