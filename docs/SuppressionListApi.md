# org.egoi.client.api.Api.SuppressionListApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSuppressionList**](SuppressionListApi.md#createsuppressionlist) | **POST** /suppression-list | Add to suppression list
[**DeleteSuppressionList**](SuppressionListApi.md#deletesuppressionlist) | **DELETE** /suppression-list/{suppression_id} | Delete from suppression list
[**GetAllSuppressionList**](SuppressionListApi.md#getallsuppressionlist) | **GET** /suppression-list | Get the suppression list



## CreateSuppressionList

> AcceptedResponse CreateSuppressionList (CreateSuppressionListRequest createSuppressionListRequest)

Add to suppression list

Adds a collection of values to the suppression list

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateSuppressionListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SuppressionListApi(Configuration.Default);
            var createSuppressionListRequest = new CreateSuppressionListRequest(); // CreateSuppressionListRequest | Parameters for the request

            try
            {
                // Add to suppression list
                AcceptedResponse result = apiInstance.CreateSuppressionList(createSuppressionListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SuppressionListApi.CreateSuppressionList: " + e.Message );
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
 **createSuppressionListRequest** | [**CreateSuppressionListRequest**](CreateSuppressionListRequest.md)| Parameters for the request | 

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


## DeleteSuppressionList

> void DeleteSuppressionList (int suppressionId)

Delete from suppression list

Deletes a suppression list value given its ID if it's creation method was ´manual´

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteSuppressionListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SuppressionListApi(Configuration.Default);
            var suppressionId = 56;  // int | ID of Suppression List

            try
            {
                // Delete from suppression list
                apiInstance.DeleteSuppressionList(suppressionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SuppressionListApi.DeleteSuppressionList: " + e.Message );
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
 **suppressionId** | **int**| ID of Suppression List | 

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


## GetAllSuppressionList

> SuppressionListItems GetAllSuppressionList (string type = null, string method = null, string value = null, string campaignHash = null, DateTime? createdMin = null, DateTime? createdMax = null, int? offset = null, int? limit = null, string order = null, string orderBy = null)

Get the suppression list

Returns the suppression list

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllSuppressionListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SuppressionListApi(Configuration.Default);
            var type = type_example;  // string | Suppression type (optional) 
            var method = method_example;  // string | Suppression method (optional) 
            var value = value_example;  // string | Reference attribute to value suppression list (optional) 
            var campaignHash = campaignHash_example;  // string | Reference attribute to campaign id (optional) 
            var createdMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Created initial date (optional) 
            var createdMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Created finish (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order the suppression list (optional)  (default to id)

            try
            {
                // Get the suppression list
                SuppressionListItems result = apiInstance.GetAllSuppressionList(type, method, value, campaignHash, createdMin, createdMax, offset, limit, order, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SuppressionListApi.GetAllSuppressionList: " + e.Message );
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
 **type** | **string**| Suppression type | [optional] 
 **method** | **string**| Suppression method | [optional] 
 **value** | **string**| Reference attribute to value suppression list | [optional] 
 **campaignHash** | **string**| Reference attribute to campaign id | [optional] 
 **createdMin** | **DateTime?**| Created initial date | [optional] 
 **createdMax** | **DateTime?**| Created finish | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order the suppression list | [optional] [default to id]

### Return type

[**SuppressionListItems**](SuppressionListItems.md)

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

