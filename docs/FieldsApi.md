# org.egoi.client.api.Api.FieldsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateExtraField**](FieldsApi.md#createextrafield) | **POST** /lists/{list_id}/fields/extra | Create extra field
[**CreateFieldOption**](FieldsApi.md#createfieldoption) | **POST** /lists/{list_id}/fields/extra/{field_id}/options | Create new field option
[**DeleteExtraField**](FieldsApi.md#deleteextrafield) | **DELETE** /lists/{list_id}/fields/extra/{field_id} | Remove extra field
[**DeleteFieldOption**](FieldsApi.md#deletefieldoption) | **DELETE** /lists/{list_id}/fields/extra/{field_id}/options/{option_id} | Deletes an option
[**GetAllFieldOptions**](FieldsApi.md#getallfieldoptions) | **GET** /lists/{list_id}/fields/extra/{field_id}/options | Get all field options
[**GetAllFields**](FieldsApi.md#getallfields) | **GET** /lists/{list_id}/fields | Get all fields
[**PatchBaseField**](FieldsApi.md#patchbasefield) | **PATCH** /lists/{list_id}/fields/base/{field_id} | Update base field
[**PatchExtraField**](FieldsApi.md#patchextrafield) | **PATCH** /lists/{list_id}/fields/extra/{field_id} | Update extra field
[**UpdateFieldOption**](FieldsApi.md#updatefieldoption) | **PATCH** /lists/{list_id}/fields/extra/{field_id}/options/{option_id} | Update field option



## CreateExtraField

> Field CreateExtraField (int listId, Field field)

Create extra field

Creates an extra field

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateExtraFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var field = new Field(); // Field | Parameters for the extra field

            try
            {
                // Create extra field
                Field result = apiInstance.CreateExtraField(listId, field);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.CreateExtraField: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **field** | [**Field**](Field.md)| Parameters for the extra field | 

### Return type

[**Field**](Field.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
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


## CreateFieldOption

> FieldOption CreateFieldOption (int listId, int fieldId, FieldOptionPost fieldOptionPost)

Create new field option

Creates a field option

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateFieldOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var fieldId = 56;  // int | ID of the Field
            var fieldOptionPost = new FieldOptionPost(); // FieldOptionPost | Parameters for the field option

            try
            {
                // Create new field option
                FieldOption result = apiInstance.CreateFieldOption(listId, fieldId, fieldOptionPost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.CreateFieldOption: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **fieldId** | **int**| ID of the Field | 
 **fieldOptionPost** | [**FieldOptionPost**](FieldOptionPost.md)| Parameters for the field option | 

### Return type

[**FieldOption**](FieldOption.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Forbidden |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteExtraField

> void DeleteExtraField (int listId, int fieldId)

Remove extra field

Removes an extra field given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteExtraFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var fieldId = 56;  // int | ID of the Field

            try
            {
                // Remove extra field
                apiInstance.DeleteExtraField(listId, fieldId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.DeleteExtraField: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **fieldId** | **int**| ID of the Field | 

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


## DeleteFieldOption

> void DeleteFieldOption (int listId, int fieldId, int optionId)

Deletes an option

Deletes an option of a list of values field

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteFieldOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var fieldId = 56;  // int | ID of the Field
            var optionId = 56;  // int | ID of the field option

            try
            {
                // Deletes an option
                apiInstance.DeleteFieldOption(listId, fieldId, optionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.DeleteFieldOption: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **fieldId** | **int**| ID of the Field | 
 **optionId** | **int**| ID of the field option | 

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
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllFieldOptions

> FieldOptionsCollection GetAllFieldOptions (int listId, int fieldId)

Get all field options

Returns all options of a given field

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllFieldOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var fieldId = 56;  // int | ID of the Field

            try
            {
                // Get all field options
                FieldOptionsCollection result = apiInstance.GetAllFieldOptions(listId, fieldId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.GetAllFieldOptions: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **fieldId** | **int**| ID of the Field | 

### Return type

[**FieldOptionsCollection**](FieldOptionsCollection.md)

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
| **404** | Not Found |  -  |
| **408** | Request Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllFields

> FieldCollection GetAllFields (int listId, int? offset = null, int? limit = null)

Get all fields

Returns all fields

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllFieldsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)

            try
            {
                // Get all fields
                FieldCollection result = apiInstance.GetAllFields(listId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.GetAllFields: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]

### Return type

[**FieldCollection**](FieldCollection.md)

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


## PatchBaseField

> Field PatchBaseField (int listId, string fieldId, PatchRequestBaseField patchRequestBaseField)

Update base field

Updates a base field

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchBaseFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var fieldId = fieldId_example;  // string | ID of the base field
            var patchRequestBaseField = new PatchRequestBaseField(); // PatchRequestBaseField | Parameters for the extra field

            try
            {
                // Update base field
                Field result = apiInstance.PatchBaseField(listId, fieldId, patchRequestBaseField);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.PatchBaseField: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **fieldId** | **string**| ID of the base field | 
 **patchRequestBaseField** | [**PatchRequestBaseField**](PatchRequestBaseField.md)| Parameters for the extra field | 

### Return type

[**Field**](Field.md)

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


## PatchExtraField

> Field PatchExtraField (int listId, int fieldId, PatchRequestField patchRequestField)

Update extra field

Updates an extra field

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchExtraFieldExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var fieldId = 56;  // int | ID of the Field
            var patchRequestField = new PatchRequestField(); // PatchRequestField | Parameters for the extra field

            try
            {
                // Update extra field
                Field result = apiInstance.PatchExtraField(listId, fieldId, patchRequestField);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.PatchExtraField: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **fieldId** | **int**| ID of the Field | 
 **patchRequestField** | [**PatchRequestField**](PatchRequestField.md)| Parameters for the extra field | 

### Return type

[**Field**](Field.md)

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


## UpdateFieldOption

> FieldOption UpdateFieldOption (int listId, int fieldId, int optionId, FieldOptionPost fieldOptionPost)

Update field option

Updates a field option

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class UpdateFieldOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new FieldsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var fieldId = 56;  // int | ID of the Field
            var optionId = 56;  // int | ID of the field option
            var fieldOptionPost = new FieldOptionPost(); // FieldOptionPost | Parameters for the field option

            try
            {
                // Update field option
                FieldOption result = apiInstance.UpdateFieldOption(listId, fieldId, optionId, fieldOptionPost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FieldsApi.UpdateFieldOption: " + e.Message );
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
 **listId** | **int**| ID of the List | 
 **fieldId** | **int**| ID of the Field | 
 **optionId** | **int**| ID of the field option | 
 **fieldOptionPost** | [**FieldOptionPost**](FieldOptionPost.md)| Parameters for the field option | 

### Return type

[**FieldOption**](FieldOption.md)

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

