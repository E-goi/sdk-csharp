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
[**CreateContact**](ContactsApi.md#createcontact) | **POST** /lists/{list_id}/contacts | Create new contact
[**GetAllContactActivities**](ContactsApi.md#getallcontactactivities) | **GET** /lists/{list_id}/contacts/{contact_id}/activities | Get all contact activities
[**GetAllContacts**](ContactsApi.md#getallcontacts) | **GET** /lists/{list_id}/contacts | Get all contacts
[**GetAllContactsBySegment**](ContactsApi.md#getallcontactsbysegment) | **GET** /lists/{list_id}/contacts/segment/{segment_id} | Get all contacts by Segment Id
[**GetContact**](ContactsApi.md#getcontact) | **GET** /lists/{list_id}/contacts/{contact_id} | Get contact
[**PatchContact**](ContactsApi.md#patchcontact) | **PATCH** /lists/{list_id}/contacts/{contact_id} | Update a specific contact
[**SearchContacts**](ContactsApi.md#searchcontacts) | **GET** /contacts/search | Search contact


<a name="actionactivatecontacts"></a>
# **ActionActivateContacts**
> AcceptedResponse ActionActivateContacts (int? listId, ActivateContactsRequest activateContactsRequest)

Activate contacts

Activates a collection of contacts (does not apply to removed contacts)

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionActivateContactsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var activateContactsRequest = new ActivateContactsRequest(); // ActivateContactsRequest | Parameters for the request

            try
            {
                // Activate contacts
                AcceptedResponse result = apiInstance.ActionActivateContacts(listId, activateContactsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionActivateContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **activateContactsRequest** | [**ActivateContactsRequest**](ActivateContactsRequest.md)| Parameters for the request | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionattachtag"></a>
# **ActionAttachTag**
> AttachTagResponse ActionAttachTag (int? listId, AttachTagRequest attachTagRequest)

Attach tag to contact

Attaches a tag to the provided contacts. <br>***Note:***<br> If you provide the array of **contacts** there will be a maximum limit of 1000 contacts in the payload, but if you provide a **segment_id** instead of     the array of contacts you will get an asynchronous response with the status code 202

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionAttachTagExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var attachTagRequest = new AttachTagRequest(); // AttachTagRequest | Parameters for the Tag

            try
            {
                // Attach tag to contact
                AttachTagResponse result = apiInstance.ActionAttachTag(listId, attachTagRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionAttachTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **attachTagRequest** | [**AttachTagRequest**](AttachTagRequest.md)| Parameters for the Tag | 

### Return type

[**AttachTagResponse**](AttachTagResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiondeactivatecontacts"></a>
# **ActionDeactivateContacts**
> AcceptedResponse ActionDeactivateContacts (int? listId, DeactivateContactsRequest deactivateContactsRequest)

Deactivate contacts

Deactivates a collection of contacts (does not apply to removed contacts)

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionDeactivateContactsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var deactivateContactsRequest = new DeactivateContactsRequest(); // DeactivateContactsRequest | Parameters for the request

            try
            {
                // Deactivate contacts
                AcceptedResponse result = apiInstance.ActionDeactivateContacts(listId, deactivateContactsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionDeactivateContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **deactivateContactsRequest** | [**DeactivateContactsRequest**](DeactivateContactsRequest.md)| Parameters for the request | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiondetachtag"></a>
# **ActionDetachTag**
> AttachTagResponse ActionDetachTag (int? listId, AttachTagRequest attachTagRequest)

Detach tag to contact

Detach a tag to the provided contacts

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionDetachTagExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var attachTagRequest = new AttachTagRequest(); // AttachTagRequest | Parameters for the Tag

            try
            {
                // Detach tag to contact
                AttachTagResponse result = apiInstance.ActionDetachTag(listId, attachTagRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionDetachTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **attachTagRequest** | [**AttachTagRequest**](AttachTagRequest.md)| Parameters for the Tag | 

### Return type

[**AttachTagResponse**](AttachTagResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionexportcontacts"></a>
# **ActionExportContacts**
> AcceptedResponse ActionExportContacts (int? listId, ContactExportRequest contactExportRequest)

Exports a list of contacts

Exports a list of contacts to the desired callback url

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionExportContactsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var contactExportRequest = new ContactExportRequest(); // ContactExportRequest | Parameters for export

            try
            {
                // Exports a list of contacts
                AcceptedResponse result = apiInstance.ActionExportContacts(listId, contactExportRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionExportContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **contactExportRequest** | [**ContactExportRequest**](ContactExportRequest.md)| Parameters for export | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionforgetcontacts"></a>
# **ActionForgetContacts**
> AcceptedResponse ActionForgetContacts (int? listId, ContactForgetRequest contactForgetRequest)

Forget contacts

Forgets a list of contacts to the desired callback url

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionForgetContactsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var contactForgetRequest = new ContactForgetRequest(); // ContactForgetRequest | Parameters for the action

            try
            {
                // Forget contacts
                AcceptedResponse result = apiInstance.ActionForgetContacts(listId, contactForgetRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionForgetContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **contactForgetRequest** | [**ContactForgetRequest**](ContactForgetRequest.md)| Parameters for the action | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionimportbulk"></a>
# **ActionImportBulk**
> AcceptedResponse ActionImportBulk (int? listId, ImportBulkRequest importBulkRequest)

Import collection of contacts

Imports a collection of contacts </br>      **DISCLAIMER:** stream limits applied. [view here](#section/Stream-Limits 'Stream Limits')<br> ***Note:*** minimum of 2 contacts to use this method. [use Create new contact method instead](#operation/createContact 'Create new contact')

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionImportBulkExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var importBulkRequest = new ImportBulkRequest(); // ImportBulkRequest | Parameters for the bulk import

            try
            {
                // Import collection of contacts
                AcceptedResponse result = apiInstance.ActionImportBulk(listId, importBulkRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionImportBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **importBulkRequest** | [**ImportBulkRequest**](ImportBulkRequest.md)| Parameters for the bulk import | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionstartautomation"></a>
# **ActionStartAutomation**
> StartAutomationResponse ActionStartAutomation (int? listId, StartAutomationRequest startAutomationRequest)

Start automation

Start automation to the provided contacts

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionStartAutomationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var startAutomationRequest = new StartAutomationRequest(); // StartAutomationRequest | Parameters for the operation to start automation

            try
            {
                // Start automation
                StartAutomationResponse result = apiInstance.ActionStartAutomation(listId, startAutomationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionStartAutomation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **startAutomationRequest** | [**StartAutomationRequest**](StartAutomationRequest.md)| Parameters for the operation to start automation | 

### Return type

[**StartAutomationResponse**](StartAutomationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionunsubscribecontact"></a>
# **ActionUnsubscribeContact**
> RemoveResponse ActionUnsubscribeContact (int? listId, RemoveRequest removeRequest)

Unsubscribes contacts

Unsubscribes contacts

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class ActionUnsubscribeContactExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var removeRequest = new RemoveRequest(); // RemoveRequest | Parameters for the contact to unsubscribe

            try
            {
                // Unsubscribes contacts
                RemoveResponse result = apiInstance.ActionUnsubscribeContact(listId, removeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ActionUnsubscribeContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **removeRequest** | [**RemoveRequest**](RemoveRequest.md)| Parameters for the contact to unsubscribe | 

### Return type

[**RemoveResponse**](RemoveResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontact"></a>
# **CreateContact**
> CreateContactResponse CreateContact (int? listId, ContactBaseExtra contactBaseExtra)

Create new contact

Create a new contact

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateContactExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the list where the contact belongs
            var contactBaseExtra = new ContactBaseExtra(); // ContactBaseExtra | Parameters for the Contact

            try
            {
                // Create new contact
                CreateContactResponse result = apiInstance.CreateContact(listId, contactBaseExtra);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the list where the contact belongs | 
 **contactBaseExtra** | [**ContactBaseExtra**](ContactBaseExtra.md)| Parameters for the Contact | 

### Return type

[**CreateContactResponse**](CreateContactResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcontactactivities"></a>
# **GetAllContactActivities**
> ActivityCollection GetAllContactActivities (string contactId, int? listId, int? offset = null, int? limit = null, DateTime? dateMin = null, DateTime? dateMax = null)

Get all contact activities

Returns all contact activities

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllContactActivitiesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var contactId = contactId_example;  // string | ID of the Contact
            var listId = 56;  // int? | ID of the List
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
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAllContactActivities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| ID of the Contact | 
 **listId** | **int?**| ID of the List | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcontacts"></a>
# **GetAllContacts**
> ContactCollection GetAllContacts (int? listId, int? offset = null, int? limit = null, string firstName = null, string lastName = null, string email = null, bool? emailStatus = null, string cellphone = null, bool? cellphoneStatus = null, string phone = null, bool? phoneStatus = null, DateTime? birthDate = null, string language = null, List<string> extraFieldId = null)

Get all contacts

Returns all contacts

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllContactsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
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
            var extraFieldId = new List<string>(); // List<string> | Extra field of contacts, extra_field_id[field_id]=value (optional) 

            try
            {
                // Get all contacts
                ContactCollection result = apiInstance.GetAllContacts(listId, offset, limit, firstName, lastName, email, emailStatus, cellphone, cellphoneStatus, phone, phoneStatus, birthDate, language, extraFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAllContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
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
 **extraFieldId** | [**List&lt;string&gt;**](string.md)| Extra field of contacts, extra_field_id[field_id]&#x3D;value | [optional] 

### Return type

[**ContactCollection**](ContactCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcontactsbysegment"></a>
# **GetAllContactsBySegment**
> ContactCollection GetAllContactsBySegment (int? listId, string segmentId, int? offset = null, int? limit = null, bool? showRemoved = null)

Get all contacts by Segment Id

Returns all contacts filtered by Segment Id

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllContactsBySegmentExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var listId = 56;  // int? | ID of the List
            var segmentId = segmentId_example;  // string | ID of the Segment
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var showRemoved = true;  // bool? | Show removed contacts (optional) 

            try
            {
                // Get all contacts by Segment Id
                ContactCollection result = apiInstance.GetAllContactsBySegment(listId, segmentId, offset, limit, showRemoved);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAllContactsBySegment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **int?**| ID of the List | 
 **segmentId** | **string**| ID of the Segment | 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **showRemoved** | **bool?**| Show removed contacts | [optional] 

### Return type

[**ContactCollection**](ContactCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontact"></a>
# **GetContact**
> ComplexContact GetContact (string contactId, int? listId)

Get contact

Returns contact information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetContactExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var contactId = contactId_example;  // string | ID of the Contact
            var listId = 56;  // int? | ID of the List

            try
            {
                // Get contact
                ComplexContact result = apiInstance.GetContact(contactId, listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| ID of the Contact | 
 **listId** | **int?**| ID of the List | 

### Return type

[**ComplexContact**](ComplexContact.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcontact"></a>
# **PatchContact**
> CreateContactResponse PatchContact (string contactId, int? listId, ContactBaseStatusExtra contactBaseStatusExtra)

Update a specific contact

Update contact

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PatchContactExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var contactId = contactId_example;  // string | ID of the Contact
            var listId = 56;  // int? | ID of the List
            var contactBaseStatusExtra = new ContactBaseStatusExtra(); // ContactBaseStatusExtra | Parameters for the contact

            try
            {
                // Update a specific contact
                CreateContactResponse result = apiInstance.PatchContact(contactId, listId, contactBaseStatusExtra);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.PatchContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| ID of the Contact | 
 **listId** | **int?**| ID of the List | 
 **contactBaseStatusExtra** | [**ContactBaseStatusExtra**](ContactBaseStatusExtra.md)| Parameters for the contact | 

### Return type

[**CreateContactResponse**](CreateContactResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcontacts"></a>
# **SearchContacts**
> InlineResponse200 SearchContacts (string contact, string type = null)

Search contact

Searches a contact across all lists and returns a collection of contacts found

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class SearchContactsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ContactsApi();
            var contact = contact_example;  // string | Contact to search
            var type = type_example;  // string | Type of contact to search (defaults to 'email') (optional)  (default to email)

            try
            {
                // Search contact
                InlineResponse200 result = apiInstance.SearchContacts(contact, type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.SearchContacts: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

