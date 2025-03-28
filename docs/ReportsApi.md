# org.egoi.client.api.Api.ReportsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEmailReport**](ReportsApi.md#getemailreport) | **GET** /reports/email/{campaign_hash} | Get email report
[**GetPushReport**](ReportsApi.md#getpushreport) | **GET** /reports/push/{campaign_hash} | Get push report
[**GetSMSReport**](ReportsApi.md#getsmsreport) | **GET** /reports/sms/{campaign_hash} | Get sms report
[**GetVoiceReport**](ReportsApi.md#getvoicereport) | **GET** /reports/voice/{campaign_hash} | Get voice report
[**GetWebPushReport**](ReportsApi.md#getwebpushreport) | **GET** /reports/web-push/{campaign_hash} | Get webpush report



## GetEmailReport

> EmailReport GetEmailReport (string campaignHash, bool? date = null, bool? weekday = null, bool? hour = null, bool? location = null, bool? domain = null, bool? url = null, bool? reader = null)

Get email report

Returns email report given the campaign hash

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetEmailReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var date = true;  // bool? | True to show date stats (optional)  (default to true)
            var weekday = true;  // bool? | True to show weekday stats (optional)  (default to true)
            var hour = true;  // bool? | True to show hour stats (optional)  (default to true)
            var location = true;  // bool? | True to show location stats (optional)  (default to true)
            var domain = true;  // bool? | True to show Domain stats (optional)  (default to true)
            var url = true;  // bool? | True to show Url stats (optional)  (default to true)
            var reader = true;  // bool? | True to show Reader stats (optional)  (default to true)

            try
            {
                // Get email report
                EmailReport result = apiInstance.GetEmailReport(campaignHash, date, weekday, hour, location, domain, url, reader);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.GetEmailReport: " + e.Message );
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
 **campaignHash** | **string**| Hash of the Campaign | 
 **date** | **bool?**| True to show date stats | [optional] [default to true]
 **weekday** | **bool?**| True to show weekday stats | [optional] [default to true]
 **hour** | **bool?**| True to show hour stats | [optional] [default to true]
 **location** | **bool?**| True to show location stats | [optional] [default to true]
 **domain** | **bool?**| True to show Domain stats | [optional] [default to true]
 **url** | **bool?**| True to show Url stats | [optional] [default to true]
 **reader** | **bool?**| True to show Reader stats | [optional] [default to true]

### Return type

[**EmailReport**](EmailReport.md)

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
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPushReport

> PushReport GetPushReport (string campaignHash, bool? operatingSystems = null)

Get push report

Returns a push report given the campaign hash

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetPushReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var operatingSystems = true;  // bool? | True to show operating system stats (optional)  (default to true)

            try
            {
                // Get push report
                PushReport result = apiInstance.GetPushReport(campaignHash, operatingSystems);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.GetPushReport: " + e.Message );
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
 **campaignHash** | **string**| Hash of the Campaign | 
 **operatingSystems** | **bool?**| True to show operating system stats | [optional] [default to true]

### Return type

[**PushReport**](PushReport.md)

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
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSMSReport

> PhoneReport GetSMSReport (string campaignHash, bool? networks = null)

Get sms report

Returns sms report given the campaign hash

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetSMSReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var networks = true;  // bool? | True to show network stats (optional)  (default to true)

            try
            {
                // Get sms report
                PhoneReport result = apiInstance.GetSMSReport(campaignHash, networks);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.GetSMSReport: " + e.Message );
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
 **campaignHash** | **string**| Hash of the Campaign | 
 **networks** | **bool?**| True to show network stats | [optional] [default to true]

### Return type

[**PhoneReport**](PhoneReport.md)

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
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetVoiceReport

> PhoneReport GetVoiceReport (string campaignHash, bool? networks = null)

Get voice report

Returns voice report given the campaign hash

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetVoiceReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var networks = true;  // bool? | True to show network stats (optional)  (default to true)

            try
            {
                // Get voice report
                PhoneReport result = apiInstance.GetVoiceReport(campaignHash, networks);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.GetVoiceReport: " + e.Message );
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
 **campaignHash** | **string**| Hash of the Campaign | 
 **networks** | **bool?**| True to show network stats | [optional] [default to true]

### Return type

[**PhoneReport**](PhoneReport.md)

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
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetWebPushReport

> WebPushReport GetWebPushReport (string campaignHash, bool? devices = null, bool? operatingSystems = null, bool? browsers = null, bool? url = null)

Get webpush report

Returns webpush report given the campaign hash

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetWebPushReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi(Configuration.Default);
            var campaignHash = campaignHash_example;  // string | Hash of the Campaign
            var devices = true;  // bool? | True to show device stats (optional)  (default to true)
            var operatingSystems = true;  // bool? | True to show operating systems stats (optional)  (default to true)
            var browsers = true;  // bool? | True to show browser stats (optional)  (default to true)
            var url = true;  // bool? | True to show url stats (optional)  (default to true)

            try
            {
                // Get webpush report
                WebPushReport result = apiInstance.GetWebPushReport(campaignHash, devices, operatingSystems, browsers, url);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.GetWebPushReport: " + e.Message );
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
 **campaignHash** | **string**| Hash of the Campaign | 
 **devices** | **bool?**| True to show device stats | [optional] [default to true]
 **operatingSystems** | **bool?**| True to show operating systems stats | [optional] [default to true]
 **browsers** | **bool?**| True to show browser stats | [optional] [default to true]
 **url** | **bool?**| True to show url stats | [optional] [default to true]

### Return type

[**WebPushReport**](WebPushReport.md)

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
| **404** | NotFound |  -  |
| **408** | Request Timeout |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

