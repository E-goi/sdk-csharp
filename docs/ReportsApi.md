# org.egoi.client.api.Api.ReportsApi

All URIs are relative to *https://api.egoiapp.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSMSReport**](ReportsApi.md#getsmsreport) | **GET** /reports/sms/{campaign_hash} | Get sms report
[**GetVoiceReport**](ReportsApi.md#getvoicereport) | **GET** /reports/voice/{campaign_hash} | Get voice report
[**GetWebPushReport**](ReportsApi.md#getwebpushreport) | **GET** /reports/web-push/{campaign_hash} | Get webpush report


<a name="getsmsreport"></a>
# **GetSMSReport**
> PhoneReport GetSMSReport (string campaignHash, bool? networks = null)

Get sms report

Returns sms report given the campaign hash

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetSMSReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var networks = true;  // bool? | True to show network stats (optional)  (default to true)

            try
            {
                // Get sms report
                PhoneReport result = apiInstance.GetSMSReport(campaignHash, networks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetSMSReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **networks** | **bool?**| True to show network stats | [optional] [default to true]

### Return type

[**PhoneReport**](PhoneReport.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvoicereport"></a>
# **GetVoiceReport**
> PhoneReport GetVoiceReport (string campaignHash, bool? networks = null)

Get voice report

Returns voice report given the campaign hash

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetVoiceReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
            var networks = true;  // bool? | True to show network stats (optional)  (default to true)

            try
            {
                // Get voice report
                PhoneReport result = apiInstance.GetVoiceReport(campaignHash, networks);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetVoiceReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
 **networks** | **bool?**| True to show network stats | [optional] [default to true]

### Return type

[**PhoneReport**](PhoneReport.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebpushreport"></a>
# **GetWebPushReport**
> WebPushReport GetWebPushReport (string campaignHash, bool? devices = null, bool? operatingSystems = null, bool? browsers = null, bool? url = null)

Get webpush report

Returns webpush report given the campaign hash

### Example
```csharp
using System;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class GetWebPushReportExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ReportsApi();
            var campaignHash = campaignHash_example;  // string | ID of the Campaign
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
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetWebPushReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignHash** | **string**| ID of the Campaign | 
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

