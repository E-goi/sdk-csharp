# org.egoi.client.api.Api.OperationsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionApproveOperation**](OperationsApi.md#actionapproveoperation) | **POST** /operations/actions/approve | Approve operation
[**ActionCancelOperation**](OperationsApi.md#actioncanceloperation) | **POST** /operations/actions/cancel | Cancel operation
[**ActionPauseOperation**](OperationsApi.md#actionpauseoperation) | **POST** /operations/actions/pause | Pause operation
[**ActionResumeOperation**](OperationsApi.md#actionresumeoperation) | **POST** /operations/actions/resume | Resume operation
[**GetAllOperations**](OperationsApi.md#getalloperations) | **GET** /operations | Get all queued operations


<a name="actionapproveoperation"></a>
# **ActionApproveOperation**
> OperationActionResponse ActionApproveOperation (OperationActionRequest operationActionRequest)

Approve operation

Approves an operation

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionApproveOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new OperationsApi();
            var operationActionRequest = new OperationActionRequest(); // OperationActionRequest | Parameters for the request

            try
            {
                // Approve operation
                OperationActionResponse result = apiInstance.ActionApproveOperation(operationActionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ActionApproveOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operationActionRequest** | [**OperationActionRequest**](OperationActionRequest.md)| Parameters for the request | 

### Return type

[**OperationActionResponse**](OperationActionResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actioncanceloperation"></a>
# **ActionCancelOperation**
> OperationActionResponse ActionCancelOperation (OperationActionRequest operationActionRequest)

Cancel operation

Cancels an operation

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionCancelOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new OperationsApi();
            var operationActionRequest = new OperationActionRequest(); // OperationActionRequest | Parameters for the request

            try
            {
                // Cancel operation
                OperationActionResponse result = apiInstance.ActionCancelOperation(operationActionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ActionCancelOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operationActionRequest** | [**OperationActionRequest**](OperationActionRequest.md)| Parameters for the request | 

### Return type

[**OperationActionResponse**](OperationActionResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpauseoperation"></a>
# **ActionPauseOperation**
> OperationActionResponse ActionPauseOperation (OperationActionRequest operationActionRequest)

Pause operation

Pauses an operation

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionPauseOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new OperationsApi();
            var operationActionRequest = new OperationActionRequest(); // OperationActionRequest | Parameters for the request

            try
            {
                // Pause operation
                OperationActionResponse result = apiInstance.ActionPauseOperation(operationActionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ActionPauseOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operationActionRequest** | [**OperationActionRequest**](OperationActionRequest.md)| Parameters for the request | 

### Return type

[**OperationActionResponse**](OperationActionResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionresumeoperation"></a>
# **ActionResumeOperation**
> OperationActionResponse ActionResumeOperation (OperationActionRequest operationActionRequest)

Resume operation

Resumes an operation

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionResumeOperationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new OperationsApi();
            var operationActionRequest = new OperationActionRequest(); // OperationActionRequest | Parameters for the request

            try
            {
                // Resume operation
                OperationActionResponse result = apiInstance.ActionResumeOperation(operationActionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.ActionResumeOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **operationActionRequest** | [**OperationActionRequest**](OperationActionRequest.md)| Parameters for the request | 

### Return type

[**OperationActionResponse**](OperationActionResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalloperations"></a>
# **GetAllOperations**
> OperationsCollection GetAllOperations (string type = null, string status = null, int? offset = null, int? limit = null, string order = null, string orderBy = null)

Get all queued operations

Returns all operations in queue

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllOperationsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new OperationsApi();
            var type = type_example;  // string | Operation type (optional) 
            var status = status_example;  // string | Operation state (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order operations (optional) 

            try
            {
                // Get all queued operations
                OperationsCollection result = apiInstance.GetAllOperations(type, status, offset, limit, order, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GetAllOperations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Operation type | [optional] 
 **status** | **string**| Operation state | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order operations | [optional] 

### Return type

[**OperationsCollection**](OperationsCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

