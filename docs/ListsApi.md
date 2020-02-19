# org.egoi.client.api.Api.ListsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateList**](ListsApi.md#createlist) | **POST** /lists | Create new list
[**DeleteList**](ListsApi.md#deletelist) | **DELETE** /lists/{list_id} | Remove list
[**GetAllLists**](ListsApi.md#getalllists) | **GET** /lists | Get all lists
[**UpdateList**](ListsApi.md#updatelist) | **PATCH** /lists/{list_id} | Update a specific list


<a name="createlist"></a>
# **CreateList**
> List CreateList (PostRequestList postRequestList)

Create new list

Create a new list

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateListExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ListsApi();
            var postRequestList = new PostRequestList(); // PostRequestList | Parameters for the List

            try
            {
                // Create new list
                List result = apiInstance.CreateList(postRequestList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.CreateList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postRequestList** | [**PostRequestList**](PostRequestList.md)| Parameters for the List | 

### Return type

**List**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelist"></a>
# **DeleteList**
> void DeleteList (int? listId)

Remove list

Remove list information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteListExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ListsApi();
            var listId = 56;  // int? | ID of the List

            try
            {
                // Remove list
                apiInstance.DeleteList(listId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.DeleteList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalllists"></a>
# **GetAllLists**
> ListCollection GetAllLists (int? offset = null, int? limit = null, string order = null, string orderBy = null, string internalName = null, string publicName = null, DateTime? createdMin = null, DateTime? createdMax = null, DateTime? updatedMin = null, DateTime? updatedMax = null)

Get all lists

Returns all lists

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllListsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ListsApi();
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order lists (optional)  (default to list_id)
            var internalName = internalName_example;  // string | Internal name of the list (optional) 
            var publicName = publicName_example;  // string | Public name of the list (optional) 
            var createdMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Created initial date (optional) 
            var createdMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Created finish (optional) 
            var updatedMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Updated initial (optional) 
            var updatedMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Updated finish (optional) 

            try
            {
                // Get all lists
                ListCollection result = apiInstance.GetAllLists(offset, limit, order, orderBy, internalName, publicName, createdMin, createdMax, updatedMin, updatedMax);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.GetAllLists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order lists | [optional] [default to list_id]
 **internalName** | **string**| Internal name of the list | [optional] 
 **publicName** | **string**| Public name of the list | [optional] 
 **createdMin** | **DateTime?**| Created initial date | [optional] 
 **createdMax** | **DateTime?**| Created finish | [optional] 
 **updatedMin** | **DateTime?**| Updated initial | [optional] 
 **updatedMax** | **DateTime?**| Updated finish | [optional] 

### Return type

[**ListCollection**](ListCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelist"></a>
# **UpdateList**
> List UpdateList (int? listId, PatchRequestList patchRequestList)

Update a specific list

Update a list

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class UpdateListExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ListsApi();
            var listId = 56;  // int? | ID of the List
            var patchRequestList = new PatchRequestList(); // PatchRequestList | Parameters for the List

            try
            {
                // Update a specific list
                List result = apiInstance.UpdateList(listId, patchRequestList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListsApi.UpdateList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **patchRequestList** | [**PatchRequestList**](PatchRequestList.md)| Parameters for the List | 

### Return type

**List**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

