# org.egoi.client.api.Api.AdvancedReportsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateEmailBouncesReport**](AdvancedReportsApi.md#generateemailbouncesreport) | **POST** /reports/advanced/email-bounces | Generate email bounces report
[**GenerateEmailClicksByContactReport**](AdvancedReportsApi.md#generateemailclicksbycontactreport) | **POST** /reports/advanced/email-clicks-by-contact | Generate email clicks by contact report
[**GenerateEmailClicksByUrlReport**](AdvancedReportsApi.md#generateemailclicksbyurlreport) | **POST** /reports/advanced/email-clicks-by-url | Generate email clicks by URL report
[**GenerateEmailEventsReport**](AdvancedReportsApi.md#generateemaileventsreport) | **POST** /reports/advanced/email-events | Generate email events report
[**GenerateEmailSmsReport**](AdvancedReportsApi.md#generateemailsmsreport) | **POST** /reports/advanced/sms-bounces | Generate SMS bounces report
[**GenerateEmailUnsubscriptionsReport**](AdvancedReportsApi.md#generateemailunsubscriptionsreport) | **POST** /reports/advanced/email-unsubscriptions | Generate email unsubscriptions report
[**GenerateFormAnswersReport**](AdvancedReportsApi.md#generateformanswersreport) | **POST** /reports/advanced/form-answers | Generate form answers report
[**GenerateSendsReport**](AdvancedReportsApi.md#generatesendsreport) | **POST** /reports/advanced/sends | Generate sends report
[**GenerateSmsEventsReport**](AdvancedReportsApi.md#generatesmseventsreport) | **POST** /reports/advanced/sms-events | Generate SMS events report
[**GenerateSubscriptionsReport**](AdvancedReportsApi.md#generatesubscriptionsreport) | **POST** /reports/advanced/subscriptions | Generate subscriptions report
[**GenerateUnsubscriptionsReport**](AdvancedReportsApi.md#generateunsubscriptionsreport) | **POST** /reports/advanced/unsubscriptions | Generate unsubscriptions report
[**GetAllAdvancedReports**](AdvancedReportsApi.md#getalladvancedreports) | **GET** /reports/advanced | Get all advanced reports


<a name="generateemailbouncesreport"></a>
# **GenerateEmailBouncesReport**
> AcceptedResponse GenerateEmailBouncesReport (GenerateEmailBouncesReport generateEmailBouncesReport)

Generate email bounces report

Generates a new email bounces report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateEmailBouncesReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateEmailBouncesReport = new GenerateEmailBouncesReport(); // GenerateEmailBouncesReport | Parameters for the email bounces report

            try
            {
                // Generate email bounces report
                AcceptedResponse result = apiInstance.GenerateEmailBouncesReport(generateEmailBouncesReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateEmailBouncesReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateEmailBouncesReport** | [**GenerateEmailBouncesReport**](GenerateEmailBouncesReport.md)| Parameters for the email bounces report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateemailclicksbycontactreport"></a>
# **GenerateEmailClicksByContactReport**
> AcceptedResponse GenerateEmailClicksByContactReport (GenerateEmailClicksByContactReport generateEmailClicksByContactReport)

Generate email clicks by contact report

Generates a new email clicks by contact report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateEmailClicksByContactReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateEmailClicksByContactReport = new GenerateEmailClicksByContactReport(); // GenerateEmailClicksByContactReport | Parameters for the email clicks by contact report

            try
            {
                // Generate email clicks by contact report
                AcceptedResponse result = apiInstance.GenerateEmailClicksByContactReport(generateEmailClicksByContactReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateEmailClicksByContactReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateEmailClicksByContactReport** | [**GenerateEmailClicksByContactReport**](GenerateEmailClicksByContactReport.md)| Parameters for the email clicks by contact report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateemailclicksbyurlreport"></a>
# **GenerateEmailClicksByUrlReport**
> AcceptedResponse GenerateEmailClicksByUrlReport (GenerateEmailClicksByUrlReport generateEmailClicksByUrlReport)

Generate email clicks by URL report

Generates a new email clicks by URL report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateEmailClicksByUrlReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateEmailClicksByUrlReport = new GenerateEmailClicksByUrlReport(); // GenerateEmailClicksByUrlReport | Parameters for the email clicks by URL report

            try
            {
                // Generate email clicks by URL report
                AcceptedResponse result = apiInstance.GenerateEmailClicksByUrlReport(generateEmailClicksByUrlReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateEmailClicksByUrlReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateEmailClicksByUrlReport** | [**GenerateEmailClicksByUrlReport**](GenerateEmailClicksByUrlReport.md)| Parameters for the email clicks by URL report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateemaileventsreport"></a>
# **GenerateEmailEventsReport**
> AcceptedResponse GenerateEmailEventsReport (GenerateEmailEventsReport generateEmailEventsReport)

Generate email events report

Generates a new email events report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateEmailEventsReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateEmailEventsReport = new GenerateEmailEventsReport(); // GenerateEmailEventsReport | Parameters for the email events report

            try
            {
                // Generate email events report
                AcceptedResponse result = apiInstance.GenerateEmailEventsReport(generateEmailEventsReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateEmailEventsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateEmailEventsReport** | [**GenerateEmailEventsReport**](GenerateEmailEventsReport.md)| Parameters for the email events report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateemailsmsreport"></a>
# **GenerateEmailSmsReport**
> AcceptedResponse GenerateEmailSmsReport (GenerateSmsBouncesReport generateSmsBouncesReport)

Generate SMS bounces report

Generates a new SMS bounces report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateEmailSmsReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateSmsBouncesReport = new GenerateSmsBouncesReport(); // GenerateSmsBouncesReport | Parameters for the SMS bounces report

            try
            {
                // Generate SMS bounces report
                AcceptedResponse result = apiInstance.GenerateEmailSmsReport(generateSmsBouncesReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateEmailSmsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateSmsBouncesReport** | [**GenerateSmsBouncesReport**](GenerateSmsBouncesReport.md)| Parameters for the SMS bounces report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateemailunsubscriptionsreport"></a>
# **GenerateEmailUnsubscriptionsReport**
> AcceptedResponse GenerateEmailUnsubscriptionsReport (GenerateEmailUnsubscriptionsReport generateEmailUnsubscriptionsReport)

Generate email unsubscriptions report

Generates a new email unsubscriptions report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateEmailUnsubscriptionsReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateEmailUnsubscriptionsReport = new GenerateEmailUnsubscriptionsReport(); // GenerateEmailUnsubscriptionsReport | Parameters for the email unsubscriptions report

            try
            {
                // Generate email unsubscriptions report
                AcceptedResponse result = apiInstance.GenerateEmailUnsubscriptionsReport(generateEmailUnsubscriptionsReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateEmailUnsubscriptionsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateEmailUnsubscriptionsReport** | [**GenerateEmailUnsubscriptionsReport**](GenerateEmailUnsubscriptionsReport.md)| Parameters for the email unsubscriptions report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateformanswersreport"></a>
# **GenerateFormAnswersReport**
> AcceptedResponse GenerateFormAnswersReport (GenerateFormAnswersReport generateFormAnswersReport)

Generate form answers report

Generates a new form answers report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateFormAnswersReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateFormAnswersReport = new GenerateFormAnswersReport(); // GenerateFormAnswersReport | Parameters for the form answers report

            try
            {
                // Generate form answers report
                AcceptedResponse result = apiInstance.GenerateFormAnswersReport(generateFormAnswersReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateFormAnswersReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateFormAnswersReport** | [**GenerateFormAnswersReport**](GenerateFormAnswersReport.md)| Parameters for the form answers report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatesendsreport"></a>
# **GenerateSendsReport**
> AcceptedResponse GenerateSendsReport (GenerateSendsReport generateSendsReport)

Generate sends report

Generates a new sends report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateSendsReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateSendsReport = new GenerateSendsReport(); // GenerateSendsReport | Parameters for the sends report

            try
            {
                // Generate sends report
                AcceptedResponse result = apiInstance.GenerateSendsReport(generateSendsReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateSendsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateSendsReport** | [**GenerateSendsReport**](GenerateSendsReport.md)| Parameters for the sends report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatesmseventsreport"></a>
# **GenerateSmsEventsReport**
> AcceptedResponse GenerateSmsEventsReport (GenerateSmsEventsReport generateSmsEventsReport)

Generate SMS events report

Generates a new SMS events report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateSmsEventsReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateSmsEventsReport = new GenerateSmsEventsReport(); // GenerateSmsEventsReport | Parameters for the SMS events report

            try
            {
                // Generate SMS events report
                AcceptedResponse result = apiInstance.GenerateSmsEventsReport(generateSmsEventsReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateSmsEventsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateSmsEventsReport** | [**GenerateSmsEventsReport**](GenerateSmsEventsReport.md)| Parameters for the SMS events report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatesubscriptionsreport"></a>
# **GenerateSubscriptionsReport**
> AcceptedResponse GenerateSubscriptionsReport (GenerateSubscriptionsReport generateSubscriptionsReport)

Generate subscriptions report

Generates a new subscriptions report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateSubscriptionsReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateSubscriptionsReport = new GenerateSubscriptionsReport(); // GenerateSubscriptionsReport | Parameters for the subscriptions report

            try
            {
                // Generate subscriptions report
                AcceptedResponse result = apiInstance.GenerateSubscriptionsReport(generateSubscriptionsReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateSubscriptionsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateSubscriptionsReport** | [**GenerateSubscriptionsReport**](GenerateSubscriptionsReport.md)| Parameters for the subscriptions report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generateunsubscriptionsreport"></a>
# **GenerateUnsubscriptionsReport**
> AcceptedResponse GenerateUnsubscriptionsReport (GenerateUnsubscriptionsReport generateUnsubscriptionsReport)

Generate unsubscriptions report

Generates a new unsubscriptions report

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GenerateUnsubscriptionsReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var generateUnsubscriptionsReport = new GenerateUnsubscriptionsReport(); // GenerateUnsubscriptionsReport | Parameters for the unsubscriptions report

            try
            {
                // Generate unsubscriptions report
                AcceptedResponse result = apiInstance.GenerateUnsubscriptionsReport(generateUnsubscriptionsReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateUnsubscriptionsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateUnsubscriptionsReport** | [**GenerateUnsubscriptionsReport**](GenerateUnsubscriptionsReport.md)| Parameters for the unsubscriptions report | 

### Return type

[**AcceptedResponse**](AcceptedResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalladvancedreports"></a>
# **GetAllAdvancedReports**
> AdvancedReportsCollection GetAllAdvancedReports (string status = null, string title = null, DateTime? createdMin = null, DateTime? createdMax = null, int? offset = null, int? limit = null, string order = null, string orderBy = null)

Get all advanced reports

Returns all advanced reports

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetAllAdvancedReportsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi();
            var status = status_example;  // string | Advanced report status (optional) 
            var title = title_example;  // string | Advanced report title (optional) 
            var createdMin = 2013-10-20T19:20:30+01:00;  // DateTime? | Created initial date (optional) 
            var createdMax = 2013-10-20T19:20:30+01:00;  // DateTime? | Created finish (optional) 
            var offset = 56;  // int? | Element offset (starting at zero for the first element) (optional) 
            var limit = 56;  // int? | Number of items to return (optional)  (default to 10)
            var order = order_example;  // string | Type of order (optional)  (default to desc)
            var orderBy = orderBy_example;  // string | Reference attribute to order the advanced reports (optional)  (default to advanced_report_id)

            try
            {
                // Get all advanced reports
                AdvancedReportsCollection result = apiInstance.GetAllAdvancedReports(status, title, createdMin, createdMax, offset, limit, order, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GetAllAdvancedReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Advanced report status | [optional] 
 **title** | **string**| Advanced report title | [optional] 
 **createdMin** | **DateTime?**| Created initial date | [optional] 
 **createdMax** | **DateTime?**| Created finish | [optional] 
 **offset** | **int?**| Element offset (starting at zero for the first element) | [optional] 
 **limit** | **int?**| Number of items to return | [optional] [default to 10]
 **order** | **string**| Type of order | [optional] [default to desc]
 **orderBy** | **string**| Reference attribute to order the advanced reports | [optional] [default to advanced_report_id]

### Return type

[**AdvancedReportsCollection**](AdvancedReportsCollection.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

