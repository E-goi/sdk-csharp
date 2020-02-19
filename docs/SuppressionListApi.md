# org.egoi.client.api.Api.SuppressionListApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllSuppressionList**](SuppressionListApi.md#getallsuppressionlist) | **GET** /suppression-list | Get the suppression list


<a name="getallsuppressionlist"></a>
# **GetAllSuppressionList**
> SuppressionListItems GetAllSuppressionList (string type = null, string method = null, string value = null, string campaignHash = null, DateTime? createdMin = null, DateTime? createdMax = null, int? offset = null, int? limit = null, string order = null, string orderBy = null)

Get the suppression list

Returns the suppression list

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllSuppressionListExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SuppressionListApi();
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
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuppressionListApi.GetAllSuppressionList: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

