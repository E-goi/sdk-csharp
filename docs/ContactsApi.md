# org.egoi.client.api.Api.ContactsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionActivateContacts**](ContactsApi.md#actionactivatecontacts) | **POST** /lists/{list_id}/contacts/actions/activate | Activate contacts
[**ActionAttachTag**](ContactsApi.md#actionattachtag) | **POST** /lists/{list_id}/contacts/actions/attach-tag | Attach tag to contact
[**ActionDeactivateContacts**](ContactsApi.md#actiondeactivatecontacts) | **POST** /lists/{list_id}/contacts/actions/deactivate | Deactivate contacts
[**ActionDetachTag**](ContactsApi.md#actiondetachtag) | **POST** /lists/{list_id}/contacts/actions/detach-tag | Detach tag to contact
[**ActionExportContacts**](ContactsApi.md#actionexportcontacts) | **POST** /lists/{list_id}/contacts/actions/export | Exports a list of contacts
[**ActionForgetContacts**](ContactsApi.md#actionforgetcontacts) | **POST** /lists/{list_id}/contacts/actions/forget | Forget contacts
[**ActionImportBulk**](ContactsApi.md#actionimportbulk) | **POST** /lists/{list_id}/contacts/actions/import-bulk | Import collection of contacts
[**ActionStartAutomation**](ContactsApi.md#actionstartautomation) | **POST** /lists/{list_id}/contacts/actions/start-automation | Start automation
[**ActionUnsubscribeContact**](ContactsApi.md#actionunsubscribecontact) | **POST** /lists/{list_id}/contacts/actions/unsubscribe | Unsubscribes contacts
[**ActionUpdateContacts**](ContactsApi.md#actionupdatecontacts) | **POST** /lists/{list_id}/contacts/actions/update | Updates contacts
[**CreateContact**](ContactsApi.md#createcontact) | **POST** /lists/{list_id}/contacts | Create new contact
[**GetAllContactActivities**](ContactsApi.md#getallcontactactivities) | **GET** /lists/{list_id}/contacts/{contact_id}/activities | Get all contact activities
[**GetAllContacts**](ContactsApi.md#getallcontacts) | **GET** /lists/{list_id}/contacts | Get all contacts
[**GetAllContactsBySegment**](ContactsApi.md#getallcontactsbysegment) | **GET** /lists/{list_id}/contacts/segment/{segment_id} | Get all contacts by Segment Id
[**GetContact**](ContactsApi.md#getcontact) | **GET** /lists/{list_id}/contacts/{contact_id} | Get contact
[**PatchContact**](ContactsApi.md#patchcontact) | **PATCH** /lists/{list_id}/contacts/{contact_id} | Update a specific contact
[**SearchContacts**](ContactsApi.md#searchcontacts) | **GET** /contacts/search | Search contact



## ActionActivateContacts

> AcceptedResponse ActionActivateContacts (int listId, ActivateContactsRequest activateContactsRequest)

Activate contacts

Activates a collection of contacts (does not apply to removed contacts)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionActivateContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var activateContactsRequest = new ActivateContactsRequest(); // ActivateContactsRequest | Parameters for the request

            try
            {
                // Activate contacts
                AcceptedResponse result = apiInstance.ActionActivateContacts(listId, activateContactsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionActivateContacts: " + e.Message );
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
 **activateContactsRequest** | [**ActivateContactsRequest**](ActivateContactsRequest.md)| Parameters for the request | 

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


## ActionAttachTag

> AcceptedResponse ActionAttachTag (int listId, AttachTagRequest attachTagRequest)

Attach tag to contact

Attaches a tag to the provided contacts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionAttachTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var attachTagRequest = new AttachTagRequest(); // AttachTagRequest | Parameters for the Tag

            try
            {
                // Attach tag to contact
                AcceptedResponse result = apiInstance.ActionAttachTag(listId, attachTagRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionAttachTag: " + e.Message );
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
 **attachTagRequest** | [**AttachTagRequest**](AttachTagRequest.md)| Parameters for the Tag | 

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


## ActionDeactivateContacts

> AcceptedResponse ActionDeactivateContacts (int listId, DeactivateContactsRequest deactivateContactsRequest)

Deactivate contacts

Deactivates a collection of contacts (does not apply to removed contacts)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionDeactivateContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var deactivateContactsRequest = new DeactivateContactsRequest(); // DeactivateContactsRequest | Parameters for the request

            try
            {
                // Deactivate contacts
                AcceptedResponse result = apiInstance.ActionDeactivateContacts(listId, deactivateContactsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionDeactivateContacts: " + e.Message );
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
 **deactivateContactsRequest** | [**DeactivateContactsRequest**](DeactivateContactsRequest.md)| Parameters for the request | 

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


## ActionDetachTag

> AcceptedResponse ActionDetachTag (int listId, DetachTagRequest detachTagRequest)

Detach tag to contact

Detach a tag to the provided contacts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionDetachTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var detachTagRequest = new DetachTagRequest(); // DetachTagRequest | Parameters for the Tag

            try
            {
                // Detach tag to contact
                AcceptedResponse result = apiInstance.ActionDetachTag(listId, detachTagRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionDetachTag: " + e.Message );
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
 **detachTagRequest** | [**DetachTagRequest**](DetachTagRequest.md)| Parameters for the Tag | 

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


## ActionExportContacts

> AcceptedResponse ActionExportContacts (int listId, ContactExportRequest contactExportRequest)

Exports a list of contacts

Exports a list of contacts to the desired callback url

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionExportContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var contactExportRequest = new ContactExportRequest(); // ContactExportRequest | Parameters for export

            try
            {
                // Exports a list of contacts
                AcceptedResponse result = apiInstance.ActionExportContacts(listId, contactExportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionExportContacts: " + e.Message );
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
 **contactExportRequest** | [**ContactExportRequest**](ContactExportRequest.md)| Parameters for export | 

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


## ActionForgetContacts

> AcceptedResponse ActionForgetContacts (int listId, ContactForgetRequest contactForgetRequest)

Forget contacts

Forgets a list of contacts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionForgetContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var contactForgetRequest = new ContactForgetRequest(); // ContactForgetRequest | Parameters for the action

            try
            {
                // Forget contacts
                AcceptedResponse result = apiInstance.ActionForgetContacts(listId, contactForgetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionForgetContacts: " + e.Message );
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
 **contactForgetRequest** | [**ContactForgetRequest**](ContactForgetRequest.md)| Parameters for the action | 

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
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ActionImportBulk

> AcceptedResponse ActionImportBulk (int listId, ImportBulkFileRequest importBulkFileRequest)

Import collection of contacts

Imports a collection of contacts </br>      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits 'Stream Limits')<br> ***Notes:***<br>Minimum of 2 contacts to use this method. [Use Create new contact method instead](#operation/createContact 'Create new contact')<br>It defaults to ***Bulk object*** import.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionImportBulkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var importBulkFileRequest = new ImportBulkFileRequest(); // ImportBulkFileRequest | Parameters for the bulk import

            try
            {
                // Import collection of contacts
                AcceptedResponse result = apiInstance.ActionImportBulk(listId, importBulkFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionImportBulk: " + e.Message );
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
 **importBulkFileRequest** | [**ImportBulkFileRequest**](ImportBulkFileRequest.md)| Parameters for the bulk import | 

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
| **202** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **408** | Request Timeout |  -  |
| **409** | Conflict |  -  |
| **413** | Request Entity Too Large |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ActionStartAutomation

> StartAutomationResponse ActionStartAutomation (int listId, StartAutomationRequest startAutomationRequest)

Start automation

Start automation to the provided contacts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionStartAutomationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var startAutomationRequest = new StartAutomationRequest(); // StartAutomationRequest | Parameters for the operation to start automation

            try
            {
                // Start automation
                StartAutomationResponse result = apiInstance.ActionStartAutomation(listId, startAutomationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionStartAutomation: " + e.Message );
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
 **startAutomationRequest** | [**StartAutomationRequest**](StartAutomationRequest.md)| Parameters for the operation to start automation | 

### Return type

[**StartAutomationResponse**](StartAutomationResponse.md)

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


## ActionUnsubscribeContact

> RemoveResponse ActionUnsubscribeContact (int listId, RemoveRequest removeRequest)

Unsubscribes contacts

Unsubscribes contacts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionUnsubscribeContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var removeRequest = new RemoveRequest(); // RemoveRequest | Parameters for the contact to unsubscribe

            try
            {
                // Unsubscribes contacts
                RemoveResponse result = apiInstance.ActionUnsubscribeContact(listId, removeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionUnsubscribeContact: " + e.Message );
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
 **removeRequest** | [**RemoveRequest**](RemoveRequest.md)| Parameters for the contact to unsubscribe | 

### Return type

[**RemoveResponse**](RemoveResponse.md)

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
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ActionUpdateContacts

> AcceptedResponse ActionUpdateContacts (int listId, UpdateContactsRequest updateContactsRequest)

Updates contacts

Updates a collection of contacts (does not apply to removed contacts).      Note that all contacts will be updated with the same values and the existance of unique fields in the payload will trigger a 409 Conflict response.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionUpdateContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var updateContactsRequest = new UpdateContactsRequest(); // UpdateContactsRequest | Parameters for the request

            try
            {
                // Updates contacts
                AcceptedResponse result = apiInstance.ActionUpdateContacts(listId, updateContactsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionUpdateContacts: " + e.Message );
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
 **updateContactsRequest** | [**UpdateContactsRequest**](UpdateContactsRequest.md)| Parameters for the request | 

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
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateContact

> CreateContactResponse CreateContact (int listId, ContactBaseExtraPost contactBaseExtraPost)

Create new contact

Create a new contact

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the list where the contact belongs
            var contactBaseExtraPost = new ContactBaseExtraPost(); // ContactBaseExtraPost | Parameters for the Contact

            try
            {
                // Create new contact
                CreateContactResponse result = apiInstance.CreateContact(listId, contactBaseExtraPost);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message );
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
 **listId** | **int**| ID of the list where the contact belongs | 
 **contactBaseExtraPost** | [**ContactBaseExtraPost**](ContactBaseExtraPost.md)| Parameters for the Contact | 

### Return type

[**CreateContactResponse**](CreateContactResponse.md)

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
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllContactActivities

> ActivityCollection GetAllContactActivities (string contactId, int listId, int? offset = null, int? limit = null, DateTime? dateMin = null, DateTime? dateMax = null)

Get all contact activities

Returns all contact activities

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllContactActivitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var contactId = contactId_example;  // string | ID of the Contact
            var listId = 56;  // int | ID of the List
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var dateMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date (optional) 
            var dateMax = 2013-10-20T19:20:30+01:00;  // DateTime? | End date (optional) 

            try
            {
                // Get all contact activities
                ActivityCollection result = apiInstance.GetAllContactActivities(contactId, listId, offset, limit, dateMin, dateMax);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAllContactActivities: " + e.Message );
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
 **contactId** | **string**| ID of the Contact | 
 **listId** | **int**| ID of the List | 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **dateMin** | **DateTime?**| Start date | [optional] 
 **dateMax** | **DateTime?**| End date | [optional] 

### Return type

[**ActivityCollection**](ActivityCollection.md)

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


## GetAllContacts

> ContactCollection GetAllContacts (int listId, int? offset = null, int? limit = null, string firstName = null, string lastName = null, string email = null, bool? emailStatus = null, string cellphone = null, bool? cellphoneStatus = null, string phone = null, bool? phoneStatus = null, DateTime? birthDate = null, string language = null, ExtraFieldId extraFieldId = null)

Get all contacts

Returns all contacts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var firstName = firstName_example;  // string | First name of the contacts to return (optional) 
            var lastName = lastName_example;  // string | Last name of the contacts to return (optional) 
            var email = email_example;  // string | Email of the contacts to return (optional) 
            var emailStatus = true;  // bool? | EmailStatus of the contacts to return (optional) 
            var cellphone = cellphone_example;  // string | Cellphone of the contacts to return (optional) 
            var cellphoneStatus = true;  // bool? | CellphoneStatus of the contacts to return (optional) 
            var phone = phone_example;  // string | Phone of the contacts to return (optional) 
            var phoneStatus = true;  // bool? | PhoneStatus of the contacts to return (optional) 
            var birthDate = new DateTime?(); // DateTime? | Birth date of the contacts to return (optional) 
            var language = language_example;  // string | Language date of the contacts to return (optional) 
            var extraFieldId = new ExtraFieldId(); // ExtraFieldId | Extra field of contacts<div><span class='sc-cJSrbW cWGDGi'> Example: </span> <span class='sc-uJMKN cTkJKI'> 'extra_field_id[field_id]=value' </span></div> (optional) 

            try
            {
                // Get all contacts
                ContactCollection result = apiInstance.GetAllContacts(listId, offset, limit, firstName, lastName, email, emailStatus, cellphone, cellphoneStatus, phone, phoneStatus, birthDate, language, extraFieldId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAllContacts: " + e.Message );
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
 **firstName** | **string**| First name of the contacts to return | [optional] 
 **lastName** | **string**| Last name of the contacts to return | [optional] 
 **email** | **string**| Email of the contacts to return | [optional] 
 **emailStatus** | **bool?**| EmailStatus of the contacts to return | [optional] 
 **cellphone** | **string**| Cellphone of the contacts to return | [optional] 
 **cellphoneStatus** | **bool?**| CellphoneStatus of the contacts to return | [optional] 
 **phone** | **string**| Phone of the contacts to return | [optional] 
 **phoneStatus** | **bool?**| PhoneStatus of the contacts to return | [optional] 
 **birthDate** | [**DateTime?**](DateTime?.md)| Birth date of the contacts to return | [optional] 
 **language** | **string**| Language date of the contacts to return | [optional] 
 **extraFieldId** | [**ExtraFieldId**](ExtraFieldId.md)| Extra field of contacts&lt;div&gt;&lt;span class&#x3D;&#39;sc-cJSrbW cWGDGi&#39;&gt; Example: &lt;/span&gt; &lt;span class&#x3D;&#39;sc-uJMKN cTkJKI&#39;&gt; &#39;extra_field_id[field_id]&#x3D;value&#39; &lt;/span&gt;&lt;/div&gt; | [optional] 

### Return type

[**ContactCollection**](ContactCollection.md)

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
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAllContactsBySegment

> ContactCollection GetAllContactsBySegment (int listId, string segmentId, int? offset = null, int? limit = null, bool? showRemoved = null)

Get all contacts by Segment Id

Returns all contacts filtered by Segment Id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllContactsBySegmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var listId = 56;  // int | ID of the List
            var segmentId = segmentId_example;  // string | ID of the Segment
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var showRemoved = true;  // bool? | Show removed contacts (optional)  (default to false)

            try
            {
                // Get all contacts by Segment Id
                ContactCollection result = apiInstance.GetAllContactsBySegment(listId, segmentId, offset, limit, showRemoved);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAllContactsBySegment: " + e.Message );
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
 **segmentId** | **string**| ID of the Segment | 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **showRemoved** | **bool?**| Show removed contacts | [optional] [default to false]

### Return type

[**ContactCollection**](ContactCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

- **Content-Type**: Not defined
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


## GetContact

> ComplexContact GetContact (string contactId, int listId)

Get contact

Returns contact information given its ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var contactId = contactId_example;  // string | ID of the Contact
            var listId = 56;  // int | ID of the List

            try
            {
                // Get contact
                ComplexContact result = apiInstance.GetContact(contactId, listId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContact: " + e.Message );
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
 **contactId** | **string**| ID of the Contact | 
 **listId** | **int**| ID of the List | 

### Return type

[**ComplexContact**](ComplexContact.md)

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
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchContact

> CreateContactResponse PatchContact (string contactId, int listId, ContactBaseStatusExtraNoRemoved contactBaseStatusExtraNoRemoved)

Update a specific contact

Update contact

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var contactId = contactId_example;  // string | ID of the Contact
            var listId = 56;  // int | ID of the List
            var contactBaseStatusExtraNoRemoved = new ContactBaseStatusExtraNoRemoved(); // ContactBaseStatusExtraNoRemoved | Parameters for the contact

            try
            {
                // Update a specific contact
                CreateContactResponse result = apiInstance.PatchContact(contactId, listId, contactBaseStatusExtraNoRemoved);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.PatchContact: " + e.Message );
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
 **contactId** | **string**| ID of the Contact | 
 **listId** | **int**| ID of the List | 
 **contactBaseStatusExtraNoRemoved** | [**ContactBaseStatusExtraNoRemoved**](ContactBaseStatusExtraNoRemoved.md)| Parameters for the contact | 

### Return type

[**CreateContactResponse**](CreateContactResponse.md)

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
| **409** | Conflict |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchContacts

> InlineResponse2001 SearchContacts (string contact, string type = null)

Search contact

Searches a contact across all lists and returns a collection of contacts found

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class SearchContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi(Configuration.Default);
            var contact = contact_example;  // string | Contact to search
            var type = type_example;  // string | Type of contact to search (defaults to 'email') (optional)  (default to email)

            try
            {
                // Search contact
                InlineResponse2001 result = apiInstance.SearchContacts(contact, type);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ContactsApi.SearchContacts: " + e.Message );
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
 **contact** | **string**| Contact to search | 
 **type** | **string**| Type of contact to search (defaults to &#39;email&#39;) | [optional] [default to email]

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

