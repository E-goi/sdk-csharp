# org.egoi.client.api.Api.SendersApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCellphoneSender**](SendersApi.md#createcellphonesender) | **POST** /senders/cellphone | Create cellphone sender
[**CreateEmailSender**](SendersApi.md#createemailsender) | **POST** /senders/email | Create email sender
[**CreatePhoneSender**](SendersApi.md#createphonesender) | **POST** /senders/phone | Create phone sender
[**DeleteCellphoneSender**](SendersApi.md#deletecellphonesender) | **DELETE** /senders/cellphone/{sender_id} | Remove cellphone sender
[**DeleteEmailSender**](SendersApi.md#deleteemailsender) | **DELETE** /senders/email/{sender_id} | Remove email sender
[**DeletePhoneSender**](SendersApi.md#deletephonesender) | **DELETE** /senders/phone/{sender_id} | Remove phone sender
[**GetAllCellphoneSenders**](SendersApi.md#getallcellphonesenders) | **GET** /senders/cellphone | Get all cellphone senders
[**GetAllEmailSenders**](SendersApi.md#getallemailsenders) | **GET** /senders/email | Get all email senders
[**GetAllPhoneSenders**](SendersApi.md#getallphonesenders) | **GET** /senders/phone | Get all phone senders
[**PutEmailSender**](SendersApi.md#putemailsender) | **PUT** /senders/email/{sender_id} | Update email sender


<a name="createcellphonesender"></a>
# **CreateCellphoneSender**
> CellphoneSender CreateCellphoneSender (CellphoneSender cellphoneSender)

Create cellphone sender

Creates a cellphone sender

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateCellphoneSenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var cellphoneSender = new CellphoneSender(); // CellphoneSender | Parameters for the sender

            try
            {
                // Create cellphone sender
                CellphoneSender result = apiInstance.CreateCellphoneSender(cellphoneSender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.CreateCellphoneSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cellphoneSender** | [**CellphoneSender**](CellphoneSender.md)| Parameters for the sender | 

### Return type

[**CellphoneSender**](CellphoneSender.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemailsender"></a>
# **CreateEmailSender**
> EmailSender CreateEmailSender (EmailSender emailSender)

Create email sender

Creates an email sender

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreateEmailSenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var emailSender = new EmailSender(); // EmailSender | Parameters for the sender

            try
            {
                // Create email sender
                EmailSender result = apiInstance.CreateEmailSender(emailSender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.CreateEmailSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailSender** | [**EmailSender**](EmailSender.md)| Parameters for the sender | 

### Return type

[**EmailSender**](EmailSender.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createphonesender"></a>
# **CreatePhoneSender**
> PhoneSender CreatePhoneSender (PhoneSender phoneSender)

Create phone sender

Creates a phone sender

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class CreatePhoneSenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var phoneSender = new PhoneSender(); // PhoneSender | Parameters for the sender

            try
            {
                // Create phone sender
                PhoneSender result = apiInstance.CreatePhoneSender(phoneSender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.CreatePhoneSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneSender** | [**PhoneSender**](PhoneSender.md)| Parameters for the sender | 

### Return type

[**PhoneSender**](PhoneSender.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecellphonesender"></a>
# **DeleteCellphoneSender**
> void DeleteCellphoneSender (int? senderId)

Remove cellphone sender

Remove sender information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteCellphoneSenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var senderId = 56;  // int? | ID of the Sender

            try
            {
                // Remove cellphone sender
                apiInstance.DeleteCellphoneSender(senderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.DeleteCellphoneSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderId** | **int?**| ID of the Sender | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailsender"></a>
# **DeleteEmailSender**
> void DeleteEmailSender (int? senderId)

Remove email sender

Remove sender information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeleteEmailSenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var senderId = 56;  // int? | ID of the Sender

            try
            {
                // Remove email sender
                apiInstance.DeleteEmailSender(senderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.DeleteEmailSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderId** | **int?**| ID of the Sender | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletephonesender"></a>
# **DeletePhoneSender**
> void DeletePhoneSender (int? senderId)

Remove phone sender

Remove sender information given its ID

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class DeletePhoneSenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var senderId = 56;  // int? | ID of the Sender

            try
            {
                // Remove phone sender
                apiInstance.DeletePhoneSender(senderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.DeletePhoneSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderId** | **int?**| ID of the Sender | 

### Return type

void (empty response body)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcellphonesenders"></a>
# **GetAllCellphoneSenders**
> CellphoneSenderCollection GetAllCellphoneSenders (int? offset = null, int? limit = null, string status = null)

Get all cellphone senders

Returns all cellphone senders

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllCellphoneSendersExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var status = status_example;  // string | Status filter (optional) 

            try
            {
                // Get all cellphone senders
                CellphoneSenderCollection result = apiInstance.GetAllCellphoneSenders(offset, limit, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.GetAllCellphoneSenders: " + e.Message );
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
 **status** | **string**| Status filter | [optional] 

### Return type

[**CellphoneSenderCollection**](CellphoneSenderCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallemailsenders"></a>
# **GetAllEmailSenders**
> EmailSenderCollection GetAllEmailSenders (int? offset = null, int? limit = null, string status = null)

Get all email senders

Returns all email senders

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllEmailSendersExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var status = status_example;  // string | Status filter (optional) 

            try
            {
                // Get all email senders
                EmailSenderCollection result = apiInstance.GetAllEmailSenders(offset, limit, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.GetAllEmailSenders: " + e.Message );
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
 **status** | **string**| Status filter | [optional] 

### Return type

[**EmailSenderCollection**](EmailSenderCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallphonesenders"></a>
# **GetAllPhoneSenders**
> PhoneSenderCollection GetAllPhoneSenders (int? offset = null, int? limit = null, string status = null)

Get all phone senders

Returns all phone senders

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllPhoneSendersExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var status = status_example;  // string | Status filter (optional) 

            try
            {
                // Get all phone senders
                PhoneSenderCollection result = apiInstance.GetAllPhoneSenders(offset, limit, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.GetAllPhoneSenders: " + e.Message );
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
 **status** | **string**| Status filter | [optional] 

### Return type

[**PhoneSenderCollection**](PhoneSenderCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putemailsender"></a>
# **PutEmailSender**
> EmailSender PutEmailSender (int? senderId, EmailSenderPutRequest emailSenderPutRequest)

Update email sender

Updates an email sender

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class PutEmailSenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SendersApi();
            var senderId = 56;  // int? | ID of the Sender
            var emailSenderPutRequest = new EmailSenderPutRequest(); // EmailSenderPutRequest | Parameters for the contact

            try
            {
                // Update email sender
                EmailSender result = apiInstance.PutEmailSender(senderId, emailSenderPutRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.PutEmailSender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderId** | **int?**| ID of the Sender | 
 **emailSenderPutRequest** | [**EmailSenderPutRequest**](EmailSenderPutRequest.md)| Parameters for the contact | 

### Return type

[**EmailSender**](EmailSender.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

