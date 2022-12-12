![E-goi](https://www.e-goi.com/wp-content/themes/egoi2019/imgs/svg/logo-egoi.svg)

Almost anything you can do in E-goi, you can do with our API.

The API describes each available method. Learn about parameters, errors, and how to format your requests. That means you can easily call on E-goi actions for your integration.
**API** Full documentation at https://developers.e-goi.com/api/v3/

If you find a bug or something worth fixing, create an issue.

### Changelog
#### 1.1.4
## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out org.egoi.client.api.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using org.egoi.client.api.Api;
using org.egoi.client.api.Client;
using org.egoi.client.api.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://api.egoiapp.com";
            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new AdvancedReportsApi(Configuration.Default);
            var generateEmailBouncesReport = new GenerateEmailBouncesReport(); // GenerateEmailBouncesReport | Parameters for the email bounces report

            try
            {
                // Generate email bounces report
                AcceptedResponse result = apiInstance.GenerateEmailBouncesReport(generateEmailBouncesReport);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdvancedReportsApi.GenerateEmailBouncesReport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.egoiapp.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdvancedReportsApi* | [**GenerateEmailBouncesReport**](docs/AdvancedReportsApi.md#generateemailbouncesreport) | **POST** /reports/advanced/email-bounces | Generate email bounces report
*AdvancedReportsApi* | [**GenerateEmailClicksByContactReport**](docs/AdvancedReportsApi.md#generateemailclicksbycontactreport) | **POST** /reports/advanced/email-clicks-by-contact | Generate email clicks by contact report
*AdvancedReportsApi* | [**GenerateEmailClicksByUrlReport**](docs/AdvancedReportsApi.md#generateemailclicksbyurlreport) | **POST** /reports/advanced/email-clicks-by-url | Generate email clicks by URL report
*AdvancedReportsApi* | [**GenerateEmailEventsReport**](docs/AdvancedReportsApi.md#generateemaileventsreport) | **POST** /reports/advanced/email-events | Generate email events report
*AdvancedReportsApi* | [**GenerateEmailSmsReport**](docs/AdvancedReportsApi.md#generateemailsmsreport) | **POST** /reports/advanced/sms-bounces | Generate SMS bounces report
*AdvancedReportsApi* | [**GenerateEmailUnsubscriptionsReport**](docs/AdvancedReportsApi.md#generateemailunsubscriptionsreport) | **POST** /reports/advanced/email-unsubscriptions | Generate email unsubscriptions report
*AdvancedReportsApi* | [**GenerateFormAnswersReport**](docs/AdvancedReportsApi.md#generateformanswersreport) | **POST** /reports/advanced/form-answers | Generate form answers report
*AdvancedReportsApi* | [**GenerateSendsReport**](docs/AdvancedReportsApi.md#generatesendsreport) | **POST** /reports/advanced/sends | Generate sends report
*AdvancedReportsApi* | [**GenerateSmsEventsReport**](docs/AdvancedReportsApi.md#generatesmseventsreport) | **POST** /reports/advanced/sms-events | Generate SMS events report
*AdvancedReportsApi* | [**GenerateSubscriptionsReport**](docs/AdvancedReportsApi.md#generatesubscriptionsreport) | **POST** /reports/advanced/subscriptions | Generate subscriptions report
*AdvancedReportsApi* | [**GenerateUnsubscriptionsReport**](docs/AdvancedReportsApi.md#generateunsubscriptionsreport) | **POST** /reports/advanced/unsubscriptions | Generate unsubscriptions report
*AdvancedReportsApi* | [**GetAllAdvancedReports**](docs/AdvancedReportsApi.md#getalladvancedreports) | **GET** /reports/advanced | Get all advanced reports
*AutomationsApi* | [**DeleteAutomation**](docs/AutomationsApi.md#deleteautomation) | **DELETE** /automations/{automation_id} | Remove automation
*AutomationsApi* | [**GetAllAutomations**](docs/AutomationsApi.md#getallautomations) | **GET** /automations | Get all automations
*CNamesApi* | [**CreateCName**](docs/CNamesApi.md#createcname) | **POST** /cnames | Create cname
*CNamesApi* | [**GetAllCNames**](docs/CNamesApi.md#getallcnames) | **GET** /cnames | Get All CNames
*CampaignGroupsApi* | [**CreateCampaignGroup**](docs/CampaignGroupsApi.md#createcampaigngroup) | **POST** /campaign-groups | Create new campaign group
*CampaignGroupsApi* | [**DeleteCampaignGroup**](docs/CampaignGroupsApi.md#deletecampaigngroup) | **DELETE** /campaign-groups/{group_id} | Remove Campaign Group
*CampaignGroupsApi* | [**GetAllCampaignGroups**](docs/CampaignGroupsApi.md#getallcampaigngroups) | **GET** /campaign-groups | Get all campaign groups
*CampaignGroupsApi* | [**UpdateCampaignGroup**](docs/CampaignGroupsApi.md#updatecampaigngroup) | **PUT** /campaign-groups/{group_id} | Update a specific campaign group
*CampaignsApi* | [**DeleteCampaigns**](docs/CampaignsApi.md#deletecampaigns) | **DELETE** /campaigns/{campaign_hash} | Remove Campaign
*CampaignsApi* | [**GetAllCampaigns**](docs/CampaignsApi.md#getallcampaigns) | **GET** /campaigns | Get all Campaigns
*ConnectedSitesApi* | [**CreateConnectedSites**](docs/ConnectedSitesApi.md#createconnectedsites) | **POST** /connectedsites | Creates a Connected Site
*ConnectedSitesApi* | [**DeleteConnectedSites**](docs/ConnectedSitesApi.md#deleteconnectedsites) | **DELETE** /connectedsites/{domain} | Deletes a Connected Site
*ConnectedSitesApi* | [**GetAllConnectedSites**](docs/ConnectedSitesApi.md#getallconnectedsites) | **GET** /connectedsites | Get all Connected Sites
*ConnectedSitesApi* | [**GetConnectedSites**](docs/ConnectedSitesApi.md#getconnectedsites) | **GET** /connectedsites/{domain} | Get a Connected Site
*ContactsApi* | [**ActionActivateContacts**](docs/ContactsApi.md#actionactivatecontacts) | **POST** /lists/{list_id}/contacts/actions/activate | Activate contacts
*ContactsApi* | [**ActionAttachTag**](docs/ContactsApi.md#actionattachtag) | **POST** /lists/{list_id}/contacts/actions/attach-tag | Attach tag to contact
*ContactsApi* | [**ActionDeactivateContacts**](docs/ContactsApi.md#actiondeactivatecontacts) | **POST** /lists/{list_id}/contacts/actions/deactivate | Deactivate contacts
*ContactsApi* | [**ActionDetachTag**](docs/ContactsApi.md#actiondetachtag) | **POST** /lists/{list_id}/contacts/actions/detach-tag | Detach tag to contact
*ContactsApi* | [**ActionExportContacts**](docs/ContactsApi.md#actionexportcontacts) | **POST** /lists/{list_id}/contacts/actions/export | Exports a list of contacts
*ContactsApi* | [**ActionForgetContacts**](docs/ContactsApi.md#actionforgetcontacts) | **POST** /lists/{list_id}/contacts/actions/forget | Forget contacts
*ContactsApi* | [**ActionImportBulk**](docs/ContactsApi.md#actionimportbulk) | **POST** /lists/{list_id}/contacts/actions/import-bulk | Import collection of contacts
*ContactsApi* | [**ActionStartAutomation**](docs/ContactsApi.md#actionstartautomation) | **POST** /lists/{list_id}/contacts/actions/start-automation | Start automation
*ContactsApi* | [**ActionUnsubscribeContact**](docs/ContactsApi.md#actionunsubscribecontact) | **POST** /lists/{list_id}/contacts/actions/unsubscribe | Unsubscribes contacts
*ContactsApi* | [**ActionUpdateContacts**](docs/ContactsApi.md#actionupdatecontacts) | **POST** /lists/{list_id}/contacts/actions/update | Updates contacts
*ContactsApi* | [**CreateContact**](docs/ContactsApi.md#createcontact) | **POST** /lists/{list_id}/contacts | Create new contact
*ContactsApi* | [**GetAllContactActivities**](docs/ContactsApi.md#getallcontactactivities) | **GET** /lists/{list_id}/contacts/{contact_id}/activities | Get all contact activities
*ContactsApi* | [**GetAllContacts**](docs/ContactsApi.md#getallcontacts) | **GET** /lists/{list_id}/contacts | Get all contacts
*ContactsApi* | [**GetAllContactsBySegment**](docs/ContactsApi.md#getallcontactsbysegment) | **GET** /lists/{list_id}/contacts/segment/{segment_id} | Get all contacts by Segment Id
*ContactsApi* | [**GetContact**](docs/ContactsApi.md#getcontact) | **GET** /lists/{list_id}/contacts/{contact_id} | Get contact
*ContactsApi* | [**PatchContact**](docs/ContactsApi.md#patchcontact) | **PATCH** /lists/{list_id}/contacts/{contact_id} | Update a specific contact
*ContactsApi* | [**SearchContacts**](docs/ContactsApi.md#searchcontacts) | **GET** /contacts/search | Search contact
*EcommerceApi* | [**CreateCart**](docs/EcommerceApi.md#createcart) | **POST** /{domain}/carts | Create cart
*EcommerceApi* | [**CreateCatalog**](docs/EcommerceApi.md#createcatalog) | **POST** /catalogs | Create new catalog
*EcommerceApi* | [**CreateOrder**](docs/EcommerceApi.md#createorder) | **POST** /{domain}/orders | Create order
*EcommerceApi* | [**CreateProduct**](docs/EcommerceApi.md#createproduct) | **POST** /catalogs/{catalog_id}/products | Create new product
*EcommerceApi* | [**DeleteCatalog**](docs/EcommerceApi.md#deletecatalog) | **DELETE** /catalogs/{catalog_id} | Remove catalog
*EcommerceApi* | [**DeleteProduct**](docs/EcommerceApi.md#deleteproduct) | **DELETE** /catalogs/{catalog_id}/products/{product_identifier} | Remove product
*EcommerceApi* | [**GetAllCatalogs**](docs/EcommerceApi.md#getallcatalogs) | **GET** /catalogs | Get all catalogs
*EcommerceApi* | [**GetAllProducts**](docs/EcommerceApi.md#getallproducts) | **GET** /catalogs/{catalog_id}/products | Get all products
*EcommerceApi* | [**GetProduct**](docs/EcommerceApi.md#getproduct) | **GET** /catalogs/{catalog_id}/products/{product_identifier} | Get product
*EcommerceApi* | [**ImportProducts**](docs/EcommerceApi.md#importproducts) | **POST** /catalogs/{catalog_id}/products/actions/import | Import products
*EcommerceApi* | [**UpdateProduct**](docs/EcommerceApi.md#updateproduct) | **PATCH** /catalogs/{catalog_id}/products/{product_identifier} | Update product
*EcommerceActivityApi* | [**ImportOrdersBulk**](docs/EcommerceActivityApi.md#importordersbulk) | **POST** /lists/{list_id}/orders | Orders import bulk request
*EmailApi* | [**ActionEnableEmailRss**](docs/EmailApi.md#actionenableemailrss) | **POST** /campaigns/email/rss/{campaign_hash}/actions/enable | Enables a rss email campaign
*EmailApi* | [**ActionSendEmail**](docs/EmailApi.md#actionsendemail) | **POST** /campaigns/email/{campaign_hash}/actions/send | Send email message
*EmailApi* | [**CreateEmailCampaign**](docs/EmailApi.md#createemailcampaign) | **POST** /campaigns/email | Create new email campaign
*EmailApi* | [**CreateEmailRssCampaign**](docs/EmailApi.md#createemailrsscampaign) | **POST** /campaigns/email/rss | Create new email rss campaign
*EmailApi* | [**PatchEmailCampaign**](docs/EmailApi.md#patchemailcampaign) | **PATCH** /campaigns/email/{campaign_hash} | Update a specific email campaign
*FieldsApi* | [**CreateExtraField**](docs/FieldsApi.md#createextrafield) | **POST** /lists/{list_id}/fields/extra | Create extra field
*FieldsApi* | [**CreateFieldOption**](docs/FieldsApi.md#createfieldoption) | **POST** /lists/{list_id}/fields/extra/{field_id}/options | Create new field option
*FieldsApi* | [**DeleteExtraField**](docs/FieldsApi.md#deleteextrafield) | **DELETE** /lists/{list_id}/fields/extra/{field_id} | Remove extra field
*FieldsApi* | [**DeleteFieldOption**](docs/FieldsApi.md#deletefieldoption) | **DELETE** /lists/{list_id}/fields/extra/{field_id}/options/{option_id} | Deletes an option
*FieldsApi* | [**GetAllFieldOptions**](docs/FieldsApi.md#getallfieldoptions) | **GET** /lists/{list_id}/fields/extra/{field_id}/options | Get all field options
*FieldsApi* | [**GetAllFields**](docs/FieldsApi.md#getallfields) | **GET** /lists/{list_id}/fields | Get all fields
*FieldsApi* | [**PatchBaseField**](docs/FieldsApi.md#patchbasefield) | **PATCH** /lists/{list_id}/fields/base/{field_id} | Update base field
*FieldsApi* | [**PatchExtraField**](docs/FieldsApi.md#patchextrafield) | **PATCH** /lists/{list_id}/fields/extra/{field_id} | Update extra field
*FieldsApi* | [**UpdateFieldOption**](docs/FieldsApi.md#updatefieldoption) | **PATCH** /lists/{list_id}/fields/extra/{field_id}/options/{option_id} | Update field option
*ListsApi* | [**CreateList**](docs/ListsApi.md#createlist) | **POST** /lists | Create new list
*ListsApi* | [**DeleteList**](docs/ListsApi.md#deletelist) | **DELETE** /lists/{list_id} | Remove list
*ListsApi* | [**GetAllLists**](docs/ListsApi.md#getalllists) | **GET** /lists | Get all lists
*ListsApi* | [**UpdateList**](docs/ListsApi.md#updatelist) | **PATCH** /lists/{list_id} | Update a specific list
*MyAccountApi* | [**EnableTe**](docs/MyAccountApi.md#enablete) | **POST** /my-account/actions/enable-te | Enable Track&Engage
*MyAccountApi* | [**EnableTransactional**](docs/MyAccountApi.md#enabletransactional) | **POST** /my-account/actions/enable-transactional | Enable Transactional
*MyAccountApi* | [**GetMyAccount**](docs/MyAccountApi.md#getmyaccount) | **GET** /my-account | Get My Account Info
*OperationsApi* | [**ActionApproveOperation**](docs/OperationsApi.md#actionapproveoperation) | **POST** /operations/actions/approve | Approve operation
*OperationsApi* | [**ActionCancelOperation**](docs/OperationsApi.md#actioncanceloperation) | **POST** /operations/actions/cancel | Cancel operation
*OperationsApi* | [**ActionPauseOperation**](docs/OperationsApi.md#actionpauseoperation) | **POST** /operations/actions/pause | Pause operation
*OperationsApi* | [**ActionResumeOperation**](docs/OperationsApi.md#actionresumeoperation) | **POST** /operations/actions/resume | Resume operation
*OperationsApi* | [**GetAllOperations**](docs/OperationsApi.md#getalloperations) | **GET** /operations | Get all queued operations
*PingApi* | [**Ping**](docs/PingApi.md#ping) | **POST** /ping | Pings the API
*PushApi* | [**ActionSendPush**](docs/PushApi.md#actionsendpush) | **POST** /campaigns/push/{campaign_hash}/actions/send | Send push message
*PushApi* | [**CreatePushCampaign**](docs/PushApi.md#createpushcampaign) | **POST** /campaigns/push | Create new push campaign
*PushApi* | [**GetPushApp**](docs/PushApi.md#getpushapp) | **GET** /push/apps/{app_id} | Get a Push application from E-goi
*PushApi* | [**GetPushApps**](docs/PushApi.md#getpushapps) | **GET** /push/apps | Get all Push applications from E-goi
*PushApi* | [**PatchPushCampaign**](docs/PushApi.md#patchpushcampaign) | **PATCH** /campaigns/push/{campaign_hash} | Update a specific push campaign
*PushApi* | [**RegisterPushEvent**](docs/PushApi.md#registerpushevent) | **POST** /push/apps/{app_id}/event | Registers an event from the push notification.
*PushApi* | [**RegisterPushToken**](docs/PushApi.md#registerpushtoken) | **POST** /push/apps/{app_id}/token | Registers a Firebase token
*ReportsApi* | [**GetEmailReport**](docs/ReportsApi.md#getemailreport) | **GET** /reports/email/{campaign_hash} | Get email report
*ReportsApi* | [**GetSMSReport**](docs/ReportsApi.md#getsmsreport) | **GET** /reports/sms/{campaign_hash} | Get sms report
*ReportsApi* | [**GetVoiceReport**](docs/ReportsApi.md#getvoicereport) | **GET** /reports/voice/{campaign_hash} | Get voice report
*ReportsApi* | [**GetWebPushReport**](docs/ReportsApi.md#getwebpushreport) | **GET** /reports/web-push/{campaign_hash} | Get webpush report
*SegmentsApi* | [**DeleteSegment**](docs/SegmentsApi.md#deletesegment) | **DELETE** /lists/{list_id}/segments/{segment_id} | Remove segment
*SegmentsApi* | [**GetAllSegments**](docs/SegmentsApi.md#getallsegments) | **GET** /lists/{list_id}/segments | Get all segments
*SendersApi* | [**CreateCellphoneSender**](docs/SendersApi.md#createcellphonesender) | **POST** /senders/cellphone | Create cellphone sender
*SendersApi* | [**CreateEmailSender**](docs/SendersApi.md#createemailsender) | **POST** /senders/email | Create email sender
*SendersApi* | [**CreatePhoneSender**](docs/SendersApi.md#createphonesender) | **POST** /senders/phone | Create phone sender
*SendersApi* | [**DeleteCellphoneSender**](docs/SendersApi.md#deletecellphonesender) | **DELETE** /senders/cellphone/{sender_id} | Remove cellphone sender
*SendersApi* | [**DeleteEmailSender**](docs/SendersApi.md#deleteemailsender) | **DELETE** /senders/email/{sender_id} | Remove email sender
*SendersApi* | [**DeletePhoneSender**](docs/SendersApi.md#deletephonesender) | **DELETE** /senders/phone/{sender_id} | Remove phone sender
*SendersApi* | [**GetAllCellphoneSenders**](docs/SendersApi.md#getallcellphonesenders) | **GET** /senders/cellphone | Get all cellphone senders
*SendersApi* | [**GetAllEmailSenders**](docs/SendersApi.md#getallemailsenders) | **GET** /senders/email | Get all email senders
*SendersApi* | [**GetAllPhoneSenders**](docs/SendersApi.md#getallphonesenders) | **GET** /senders/phone | Get all phone senders
*SendersApi* | [**PutEmailSender**](docs/SendersApi.md#putemailsender) | **PUT** /senders/email/{sender_id} | Update email sender
*SmartSmsApi* | [**ActionSendSmartSms**](docs/SmartSmsApi.md#actionsendsmartsms) | **POST** /campaigns/smart-sms/{campaign_hash}/actions/send | Send smart sms message
*SmartSmsApi* | [**CreateSmartSmsCampaign**](docs/SmartSmsApi.md#createsmartsmscampaign) | **POST** /campaigns/smart-sms | Create new smart sms campaign
*SmartSmsApi* | [**PatchSmartSmsCampaign**](docs/SmartSmsApi.md#patchsmartsmscampaign) | **PATCH** /campaigns/smart-sms/{campaign_hash} | Update a specific smart sms campaign
*SmsApi* | [**ActionSendSms**](docs/SmsApi.md#actionsendsms) | **POST** /campaigns/sms/{campaign_hash}/actions/send | Send sms message
*SmsApi* | [**CreateSmsCampaign**](docs/SmsApi.md#createsmscampaign) | **POST** /campaigns/sms | Create new sms campaign
*SmsApi* | [**PatchSmsCampaign**](docs/SmsApi.md#patchsmscampaign) | **PATCH** /campaigns/sms/{campaign_hash} | Update a specific sms campaign
*SuppressionListApi* | [**CreateSuppressionList**](docs/SuppressionListApi.md#createsuppressionlist) | **POST** /suppression-list | Add to suppression list
*SuppressionListApi* | [**DeleteSuppressionList**](docs/SuppressionListApi.md#deletesuppressionlist) | **DELETE** /suppression-list/{suppression_id} | Delete from suppression list
*SuppressionListApi* | [**GetAllSuppressionList**](docs/SuppressionListApi.md#getallsuppressionlist) | **GET** /suppression-list | Get the suppression list
*TagsApi* | [**CreateTag**](docs/TagsApi.md#createtag) | **POST** /tags | Create new tag
*TagsApi* | [**DeleteTag**](docs/TagsApi.md#deletetag) | **DELETE** /tags/{tag_id} | Remove tag
*TagsApi* | [**GetAllTags**](docs/TagsApi.md#getalltags) | **GET** /tags | Get all tags
*TagsApi* | [**UpdateTag**](docs/TagsApi.md#updatetag) | **PUT** /tags/{tag_id} | Update a specific tag
*TrackEngageApi* | [**GetAllDomains**](docs/TrackEngageApi.md#getalldomains) | **GET** /trackengage/domains | Get all domains
*TrackEngageApi* | [**GetAllGoals**](docs/TrackEngageApi.md#getallgoals) | **GET** /trackengage/goals | Get all goals
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /users/{user_id} | Remove user
*UsersApi* | [**GetAllUsers**](docs/UsersApi.md#getallusers) | **GET** /users | Get all users
*UtilitiesApi* | [**GetAllCountries**](docs/UtilitiesApi.md#getallcountries) | **GET** /utilities/countries | Get all countries
*VoiceApi* | [**ActionSendVoice**](docs/VoiceApi.md#actionsendvoice) | **POST** /campaigns/voice/{campaign_hash}/actions/send | Send voice message
*VoiceApi* | [**CreateVoiceCampaign**](docs/VoiceApi.md#createvoicecampaign) | **POST** /campaigns/voice | Create new voice campaign
*VoiceApi* | [**PatchVoiceCampaign**](docs/VoiceApi.md#patchvoicecampaign) | **PATCH** /campaigns/voice/{campaign_hash} | Update a specific voice campaign
*WebHooksApi* | [**CreateWebhook**](docs/WebHooksApi.md#createwebhook) | **POST** /webhooks | Create new webhook
*WebHooksApi* | [**DeleteWebhook**](docs/WebHooksApi.md#deletewebhook) | **DELETE** /webhooks/{webhook_id} | Remove webhook
*WebHooksApi* | [**GetAllWebhooks**](docs/WebHooksApi.md#getallwebhooks) | **GET** /webhooks | Get all webhooks
*WebpushApi* | [**ActionEnableWebPushRss**](docs/WebpushApi.md#actionenablewebpushrss) | **POST** /campaigns/webpush/rss/{campaign_hash}/actions/enable | Enable a rss webpush campaign
*WebpushApi* | [**ActionSendWebPush**](docs/WebpushApi.md#actionsendwebpush) | **POST** /campaigns/web-push/{campaign_hash}/actions/send | Send webpush message
*WebpushApi* | [**CreateWebPushCampaign**](docs/WebpushApi.md#createwebpushcampaign) | **POST** /campaigns/web-push | Create new webpush campaign
*WebpushApi* | [**CreateWebPushRssCampaign**](docs/WebpushApi.md#createwebpushrsscampaign) | **POST** /campaigns/webpush/rss | Create new webpush rss campaign
*WebpushApi* | [**CreateWebpushSite**](docs/WebpushApi.md#createwebpushsite) | **POST** /webpush/sites | Creates a webpush site
*WebpushApi* | [**GetAllWebPushSites**](docs/WebpushApi.md#getallwebpushsites) | **GET** /webpush/sites | Get all webpush sites
*WebpushApi* | [**PatchWebPushCampaign**](docs/WebpushApi.md#patchwebpushcampaign) | **PATCH** /campaigns/web-push/{campaign_hash} | Update a specific webpush campaign


## Documentation for Models

 - [Model.AbstractCampaignSendRequest](docs/AbstractCampaignSendRequest.md)
 - [Model.AbstractCampaignSendRequestSegments](docs/AbstractCampaignSendRequestSegments.md)
 - [Model.AbstractCampaignTemplate](docs/AbstractCampaignTemplate.md)
 - [Model.AbstractCellphoneSender](docs/AbstractCellphoneSender.md)
 - [Model.AbstractCellphoneSenderAllOf](docs/AbstractCellphoneSenderAllOf.md)
 - [Model.AbstractSegment](docs/AbstractSegment.md)
 - [Model.AbstractSendEmail](docs/AbstractSendEmail.md)
 - [Model.AbstractSendVoice](docs/AbstractSendVoice.md)
 - [Model.AbstractSendVoiceAllOf](docs/AbstractSendVoiceAllOf.md)
 - [Model.AbstractSendVoiceAllOf1](docs/AbstractSendVoiceAllOf1.md)
 - [Model.AbstractSuppresionList](docs/AbstractSuppresionList.md)
 - [Model.AcceptedResponse](docs/AcceptedResponse.md)
 - [Model.ActivateContactsAll](docs/ActivateContactsAll.md)
 - [Model.ActivateContactsMany](docs/ActivateContactsMany.md)
 - [Model.ActivateContactsRequest](docs/ActivateContactsRequest.md)
 - [Model.ActivityCollection](docs/ActivityCollection.md)
 - [Model.AdvancedReport](docs/AdvancedReport.md)
 - [Model.AdvancedReportCampaignsObject](docs/AdvancedReportCampaignsObject.md)
 - [Model.AdvancedReportEmailBouncesColumns](docs/AdvancedReportEmailBouncesColumns.md)
 - [Model.AdvancedReportEmailBouncesOptions](docs/AdvancedReportEmailBouncesOptions.md)
 - [Model.AdvancedReportEmailClicksByContactColumns](docs/AdvancedReportEmailClicksByContactColumns.md)
 - [Model.AdvancedReportEmailClicksByContactOptions](docs/AdvancedReportEmailClicksByContactOptions.md)
 - [Model.AdvancedReportEmailClicksByUrlColumns](docs/AdvancedReportEmailClicksByUrlColumns.md)
 - [Model.AdvancedReportEmailClicksByUrlOptions](docs/AdvancedReportEmailClicksByUrlOptions.md)
 - [Model.AdvancedReportEmailEventsColumns](docs/AdvancedReportEmailEventsColumns.md)
 - [Model.AdvancedReportEmailEventsOptions](docs/AdvancedReportEmailEventsOptions.md)
 - [Model.AdvancedReportEmailUnsubscriptionsColumns](docs/AdvancedReportEmailUnsubscriptionsColumns.md)
 - [Model.AdvancedReportEmailUnsubscriptionsOptions](docs/AdvancedReportEmailUnsubscriptionsOptions.md)
 - [Model.AdvancedReportRange](docs/AdvancedReportRange.md)
 - [Model.AdvancedReportSendsColumns](docs/AdvancedReportSendsColumns.md)
 - [Model.AdvancedReportSendsOptions](docs/AdvancedReportSendsOptions.md)
 - [Model.AdvancedReportSmsBouncesColumns](docs/AdvancedReportSmsBouncesColumns.md)
 - [Model.AdvancedReportSmsBouncesOptions](docs/AdvancedReportSmsBouncesOptions.md)
 - [Model.AdvancedReportSmsEventsColumns](docs/AdvancedReportSmsEventsColumns.md)
 - [Model.AdvancedReportSmsEventsOptions](docs/AdvancedReportSmsEventsOptions.md)
 - [Model.AdvancedReportSubscriptionsColumns](docs/AdvancedReportSubscriptionsColumns.md)
 - [Model.AdvancedReportSubscriptionsOptions](docs/AdvancedReportSubscriptionsOptions.md)
 - [Model.AdvancedReportUnsubscriptionsColumns](docs/AdvancedReportUnsubscriptionsColumns.md)
 - [Model.AdvancedReportUnsubscriptionsOptions](docs/AdvancedReportUnsubscriptionsOptions.md)
 - [Model.AdvancedReportsCollection](docs/AdvancedReportsCollection.md)
 - [Model.AlphanumericCellphoneSender](docs/AlphanumericCellphoneSender.md)
 - [Model.AlphanumericCellphoneSenderPost](docs/AlphanumericCellphoneSenderPost.md)
 - [Model.AlphanumericCellphoneSenderPostAllOf](docs/AlphanumericCellphoneSenderPostAllOf.md)
 - [Model.AppStructure](docs/AppStructure.md)
 - [Model.AppStructureList](docs/AppStructureList.md)
 - [Model.AttachByContacts](docs/AttachByContacts.md)
 - [Model.AttachBySegment](docs/AttachBySegment.md)
 - [Model.AttachTagRequest](docs/AttachTagRequest.md)
 - [Model.AttachTagResponse](docs/AttachTagResponse.md)
 - [Model.AutomaticSegment](docs/AutomaticSegment.md)
 - [Model.AutomaticSegmentAllOf](docs/AutomaticSegmentAllOf.md)
 - [Model.Automation](docs/Automation.md)
 - [Model.AutomationAllOf](docs/AutomationAllOf.md)
 - [Model.AutomationCollection](docs/AutomationCollection.md)
 - [Model.AutomationPost](docs/AutomationPost.md)
 - [Model.AutomationPostAllOf](docs/AutomationPostAllOf.md)
 - [Model.BadRequest](docs/BadRequest.md)
 - [Model.BalanceInfo](docs/BalanceInfo.md)
 - [Model.BalanceInfoBalanceInfo](docs/BalanceInfoBalanceInfo.md)
 - [Model.BaseConflict](docs/BaseConflict.md)
 - [Model.BasicProduct](docs/BasicProduct.md)
 - [Model.BasicSender](docs/BasicSender.md)
 - [Model.BillingInfo](docs/BillingInfo.md)
 - [Model.BillingInfoAllOf](docs/BillingInfoAllOf.md)
 - [Model.BillingInfoAllOfBillingInfo](docs/BillingInfoAllOfBillingInfo.md)
 - [Model.BillingInfoAllOfBillingInfoCountry](docs/BillingInfoAllOfBillingInfoCountry.md)
 - [Model.BulkActionResponse](docs/BulkActionResponse.md)
 - [Model.CName](docs/CName.md)
 - [Model.CNamePost](docs/CNamePost.md)
 - [Model.CNamesCollection](docs/CNamesCollection.md)
 - [Model.Campaign](docs/Campaign.md)
 - [Model.CampaignEmailBaseContent](docs/CampaignEmailBaseContent.md)
 - [Model.CampaignEmailContent](docs/CampaignEmailContent.md)
 - [Model.CampaignEmailContentFile](docs/CampaignEmailContentFile.md)
 - [Model.CampaignEmailContentFileAllOf](docs/CampaignEmailContentFileAllOf.md)
 - [Model.CampaignEmailContentHtml](docs/CampaignEmailContentHtml.md)
 - [Model.CampaignEmailContentHtmlAllOf](docs/CampaignEmailContentHtmlAllOf.md)
 - [Model.CampaignEmailContentHtmlPatch](docs/CampaignEmailContentHtmlPatch.md)
 - [Model.CampaignEmailContentHtmlPatchAllOf](docs/CampaignEmailContentHtmlPatchAllOf.md)
 - [Model.CampaignEmailContentTemplate](docs/CampaignEmailContentTemplate.md)
 - [Model.CampaignEmailContentTemplateAllOf](docs/CampaignEmailContentTemplateAllOf.md)
 - [Model.CampaignEmailContentWebPage](docs/CampaignEmailContentWebPage.md)
 - [Model.CampaignEmailContentWebPageAllOf](docs/CampaignEmailContentWebPageAllOf.md)
 - [Model.CampaignEmailRssContent](docs/CampaignEmailRssContent.md)
 - [Model.CampaignEmailRssContentHtml](docs/CampaignEmailRssContentHtml.md)
 - [Model.CampaignEmailRssContentHtmlAllOf](docs/CampaignEmailRssContentHtmlAllOf.md)
 - [Model.CampaignEmailScheduleRequest](docs/CampaignEmailScheduleRequest.md)
 - [Model.CampaignEmailScheduleRequestAllOf](docs/CampaignEmailScheduleRequestAllOf.md)
 - [Model.CampaignEmailSendNowRequest](docs/CampaignEmailSendNowRequest.md)
 - [Model.CampaignEmailSendRequest](docs/CampaignEmailSendRequest.md)
 - [Model.CampaignGroup](docs/CampaignGroup.md)
 - [Model.CampaignGroupAllOf](docs/CampaignGroupAllOf.md)
 - [Model.CampaignGroupCollection](docs/CampaignGroupCollection.md)
 - [Model.CampaignGroupPost](docs/CampaignGroupPost.md)
 - [Model.CampaignGroupPostAllOf](docs/CampaignGroupPostAllOf.md)
 - [Model.CampaignHash](docs/CampaignHash.md)
 - [Model.CampaignPushContent](docs/CampaignPushContent.md)
 - [Model.CampaignPushContentTemplate](docs/CampaignPushContentTemplate.md)
 - [Model.CampaignPushContentText](docs/CampaignPushContentText.md)
 - [Model.CampaignPushScheduleRequest](docs/CampaignPushScheduleRequest.md)
 - [Model.CampaignPushSendRequest](docs/CampaignPushSendRequest.md)
 - [Model.CampaignScheduleDate](docs/CampaignScheduleDate.md)
 - [Model.CampaignSentLast30Days](docs/CampaignSentLast30Days.md)
 - [Model.CampaignSentLast30DaysErrors](docs/CampaignSentLast30DaysErrors.md)
 - [Model.CampaignSmartSmsHtml](docs/CampaignSmartSmsHtml.md)
 - [Model.CampaignSmartSmsImport](docs/CampaignSmartSmsImport.md)
 - [Model.CampaignSmartSmsOptions](docs/CampaignSmartSmsOptions.md)
 - [Model.CampaignSmartSmsPageContent](docs/CampaignSmartSmsPageContent.md)
 - [Model.CampaignSmartSmsRedirect](docs/CampaignSmartSmsRedirect.md)
 - [Model.CampaignSmartSmsScheduleRequest](docs/CampaignSmartSmsScheduleRequest.md)
 - [Model.CampaignSmartSmsSendRequest](docs/CampaignSmartSmsSendRequest.md)
 - [Model.CampaignSmsContent](docs/CampaignSmsContent.md)
 - [Model.CampaignSmsContentTemplate](docs/CampaignSmsContentTemplate.md)
 - [Model.CampaignSmsContentText](docs/CampaignSmsContentText.md)
 - [Model.CampaignSmsOptions](docs/CampaignSmsOptions.md)
 - [Model.CampaignSmsScheduleRequest](docs/CampaignSmsScheduleRequest.md)
 - [Model.CampaignSmsSendRequest](docs/CampaignSmsSendRequest.md)
 - [Model.CampaignVoiceScheduleRequest](docs/CampaignVoiceScheduleRequest.md)
 - [Model.CampaignVoiceSendRequest](docs/CampaignVoiceSendRequest.md)
 - [Model.CampaignWebPushScheduleRequest](docs/CampaignWebPushScheduleRequest.md)
 - [Model.CampaignWebPushSendRequest](docs/CampaignWebPushSendRequest.md)
 - [Model.CampaignsCollection](docs/CampaignsCollection.md)
 - [Model.Cart](docs/Cart.md)
 - [Model.CartPatchRequest](docs/CartPatchRequest.md)
 - [Model.Catalog](docs/Catalog.md)
 - [Model.CatalogCollection](docs/CatalogCollection.md)
 - [Model.CatalogPost](docs/CatalogPost.md)
 - [Model.CatalogPostRequest](docs/CatalogPostRequest.md)
 - [Model.CellphoneSender](docs/CellphoneSender.md)
 - [Model.CellphoneSenderCollection](docs/CellphoneSenderCollection.md)
 - [Model.CellphoneSenderPost](docs/CellphoneSenderPost.md)
 - [Model.ClientAlreadyEnabled](docs/ClientAlreadyEnabled.md)
 - [Model.ClientAlreadyEnabledErrors](docs/ClientAlreadyEnabledErrors.md)
 - [Model.ClientIsBeingEnabled](docs/ClientIsBeingEnabled.md)
 - [Model.ClientIsBeingEnabledErrors](docs/ClientIsBeingEnabledErrors.md)
 - [Model.CnameExists](docs/CnameExists.md)
 - [Model.CnameExistsErrors](docs/CnameExistsErrors.md)
 - [Model.ComplexContact](docs/ComplexContact.md)
 - [Model.ComplexContactAllOf](docs/ComplexContactAllOf.md)
 - [Model.ComplexContactAllOfEmailStats](docs/ComplexContactAllOfEmailStats.md)
 - [Model.ComplexContactAllOfPushStats](docs/ComplexContactAllOfPushStats.md)
 - [Model.ComplexContactAllOfSmsStats](docs/ComplexContactAllOfSmsStats.md)
 - [Model.ComplexContactAllOfVoiceStats](docs/ComplexContactAllOfVoiceStats.md)
 - [Model.ComplexContactAllOfWebpushStats](docs/ComplexContactAllOfWebpushStats.md)
 - [Model.ComplexField](docs/ComplexField.md)
 - [Model.ComplexFieldAllOf](docs/ComplexFieldAllOf.md)
 - [Model.ComplexList](docs/ComplexList.md)
 - [Model.ComplexListAllOf](docs/ComplexListAllOf.md)
 - [Model.ComplexListAllOfStats](docs/ComplexListAllOfStats.md)
 - [Model.ComplexUser](docs/ComplexUser.md)
 - [Model.ComplexUserAllOf](docs/ComplexUserAllOf.md)
 - [Model.ComplexUserPost](docs/ComplexUserPost.md)
 - [Model.Conflict](docs/Conflict.md)
 - [Model.ConflictAllOf](docs/ConflictAllOf.md)
 - [Model.ConnectedSitesDomain](docs/ConnectedSitesDomain.md)
 - [Model.ConnectedSitesDomainDetail](docs/ConnectedSitesDomainDetail.md)
 - [Model.ConnectedSitesEmbedForm](docs/ConnectedSitesEmbedForm.md)
 - [Model.ConnectedSitesGeneralProductAppDetail](docs/ConnectedSitesGeneralProductAppDetail.md)
 - [Model.ConnectedSitesGeneralProductAppDetailGlobal](docs/ConnectedSitesGeneralProductAppDetailGlobal.md)
 - [Model.ConnectedSitesGeneralProductFormDetail](docs/ConnectedSitesGeneralProductFormDetail.md)
 - [Model.ConnectedSitesGeneralProductFormDetailGlobal](docs/ConnectedSitesGeneralProductFormDetailGlobal.md)
 - [Model.ConnectedSitesGeneralProductTEDetailGlobal](docs/ConnectedSitesGeneralProductTEDetailGlobal.md)
 - [Model.ConnectedSitesProductEmbedFormDetail](docs/ConnectedSitesProductEmbedFormDetail.md)
 - [Model.ConnectedSitesProducts](docs/ConnectedSitesProducts.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactActivity](docs/ContactActivity.md)
 - [Model.ContactActivityAbstractActionsWithData](docs/ContactActivityAbstractActionsWithData.md)
 - [Model.ContactActivityClick](docs/ContactActivityClick.md)
 - [Model.ContactActivityClickAllOf](docs/ContactActivityClickAllOf.md)
 - [Model.ContactActivityClickAllOfActionData](docs/ContactActivityClickAllOfActionData.md)
 - [Model.ContactBaseExtra](docs/ContactBaseExtra.md)
 - [Model.ContactBaseExtraBulk](docs/ContactBaseExtraBulk.md)
 - [Model.ContactBaseExtraFull](docs/ContactBaseExtraFull.md)
 - [Model.ContactBaseExtraPost](docs/ContactBaseExtraPost.md)
 - [Model.ContactBaseFieldsBulkSchema](docs/ContactBaseFieldsBulkSchema.md)
 - [Model.ContactBaseFieldsPostSchema](docs/ContactBaseFieldsPostSchema.md)
 - [Model.ContactBaseFieldsSchema](docs/ContactBaseFieldsSchema.md)
 - [Model.ContactBaseFieldsWithIdSchema](docs/ContactBaseFieldsWithIdSchema.md)
 - [Model.ContactBaseStatusExtra](docs/ContactBaseStatusExtra.md)
 - [Model.ContactBaseStatusExtraBulk](docs/ContactBaseStatusExtraBulk.md)
 - [Model.ContactBaseStatusExtraNoRemoved](docs/ContactBaseStatusExtraNoRemoved.md)
 - [Model.ContactBaseWithStatusFieldsBulkSchema](docs/ContactBaseWithStatusFieldsBulkSchema.md)
 - [Model.ContactBaseWithStatusFieldsNoTokensSchema](docs/ContactBaseWithStatusFieldsNoTokensSchema.md)
 - [Model.ContactBaseWithStatusFieldsNoTokensSchemaBase](docs/ContactBaseWithStatusFieldsNoTokensSchemaBase.md)
 - [Model.ContactBaseWithStatusFieldsSchema](docs/ContactBaseWithStatusFieldsSchema.md)
 - [Model.ContactBaseWithStatusFieldsSchemaBase](docs/ContactBaseWithStatusFieldsSchemaBase.md)
 - [Model.ContactBaseWithStatusNoRemovedFieldsSchema](docs/ContactBaseWithStatusNoRemovedFieldsSchema.md)
 - [Model.ContactBaseWithStatusNoRemovedFieldsSchemaBase](docs/ContactBaseWithStatusNoRemovedFieldsSchemaBase.md)
 - [Model.ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid](docs/ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid.md)
 - [Model.ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos](docs/ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos.md)
 - [Model.ContactBulk](docs/ContactBulk.md)
 - [Model.ContactBulkFile](docs/ContactBulkFile.md)
 - [Model.ContactBulkFileAllOf](docs/ContactBulkFileAllOf.md)
 - [Model.ContactBulkFileAllOf1](docs/ContactBulkFileAllOf1.md)
 - [Model.ContactBulkFileAllOf2](docs/ContactBulkFileAllOf2.md)
 - [Model.ContactBulkFileAllOf3](docs/ContactBulkFileAllOf3.md)
 - [Model.ContactCollection](docs/ContactCollection.md)
 - [Model.ContactExportRequest](docs/ContactExportRequest.md)
 - [Model.ContactExtraFieldCellphone](docs/ContactExtraFieldCellphone.md)
 - [Model.ContactExtraFieldCellphoneBulk](docs/ContactExtraFieldCellphoneBulk.md)
 - [Model.ContactExtraFieldDate](docs/ContactExtraFieldDate.md)
 - [Model.ContactExtraFieldEmail](docs/ContactExtraFieldEmail.md)
 - [Model.ContactExtraFieldEmailBulk](docs/ContactExtraFieldEmailBulk.md)
 - [Model.ContactExtraFieldNumber](docs/ContactExtraFieldNumber.md)
 - [Model.ContactExtraFieldOptions](docs/ContactExtraFieldOptions.md)
 - [Model.ContactExtraFieldPhone](docs/ContactExtraFieldPhone.md)
 - [Model.ContactExtraFieldPhoneBulk](docs/ContactExtraFieldPhoneBulk.md)
 - [Model.ContactExtraFieldText](docs/ContactExtraFieldText.md)
 - [Model.ContactExtraFields](docs/ContactExtraFields.md)
 - [Model.ContactExtraFieldsBulk](docs/ContactExtraFieldsBulk.md)
 - [Model.ContactExtraFieldsBulkSchema](docs/ContactExtraFieldsBulkSchema.md)
 - [Model.ContactExtraFieldsSchema](docs/ContactExtraFieldsSchema.md)
 - [Model.ContactFieldMappingFileBulkSchema](docs/ContactFieldMappingFileBulkSchema.md)
 - [Model.ContactForgetRequest](docs/ContactForgetRequest.md)
 - [Model.ContactInsideBase](docs/ContactInsideBase.md)
 - [Model.ContactInsideBaseBulk](docs/ContactInsideBaseBulk.md)
 - [Model.ContactInsideBasePost](docs/ContactInsideBasePost.md)
 - [Model.ContactInsideBaseWithId](docs/ContactInsideBaseWithId.md)
 - [Model.ContactOtherActivity](docs/ContactOtherActivity.md)
 - [Model.ContactSearchResponse](docs/ContactSearchResponse.md)
 - [Model.ContactStatusFieldsBulkSchema](docs/ContactStatusFieldsBulkSchema.md)
 - [Model.ContactStatusFieldsSchema](docs/ContactStatusFieldsSchema.md)
 - [Model.ContactTags](docs/ContactTags.md)
 - [Model.ContactTagsBulk](docs/ContactTagsBulk.md)
 - [Model.ContactsActionUpdateContactsSchema](docs/ContactsActionUpdateContactsSchema.md)
 - [Model.ContentVoice](docs/ContentVoice.md)
 - [Model.ContentVoiceAudio](docs/ContentVoiceAudio.md)
 - [Model.ContentVoicePatch](docs/ContentVoicePatch.md)
 - [Model.ContentVoiceTemplate](docs/ContentVoiceTemplate.md)
 - [Model.Country](docs/Country.md)
 - [Model.CountryCollection](docs/CountryCollection.md)
 - [Model.CreateCartResponse](docs/CreateCartResponse.md)
 - [Model.CreateContactResponse](docs/CreateContactResponse.md)
 - [Model.CreateOrder](docs/CreateOrder.md)
 - [Model.CreateOrderResponse](docs/CreateOrderResponse.md)
 - [Model.CreateSuppressionListRequest](docs/CreateSuppressionListRequest.md)
 - [Model.CustomAttributes](docs/CustomAttributes.md)
 - [Model.DeactivateContactsAll](docs/DeactivateContactsAll.md)
 - [Model.DeactivateContactsMany](docs/DeactivateContactsMany.md)
 - [Model.DeactivateContactsRequest](docs/DeactivateContactsRequest.md)
 - [Model.DeleteCampaignsConflict](docs/DeleteCampaignsConflict.md)
 - [Model.DeleteFieldsConflict](docs/DeleteFieldsConflict.md)
 - [Model.DeleteListsConflict](docs/DeleteListsConflict.md)
 - [Model.DeleteListsConflictsErrors](docs/DeleteListsConflictsErrors.md)
 - [Model.DeleteSegmentsConflict](docs/DeleteSegmentsConflict.md)
 - [Model.DeleteSegmentsConflictsErrors](docs/DeleteSegmentsConflictsErrors.md)
 - [Model.DeleteSuppressionListConflictsErrors](docs/DeleteSuppressionListConflictsErrors.md)
 - [Model.DetachByContacts](docs/DetachByContacts.md)
 - [Model.DetachBySegment](docs/DetachBySegment.md)
 - [Model.DetachTagRequest](docs/DetachTagRequest.md)
 - [Model.Domain](docs/Domain.md)
 - [Model.DomainAlreadyDefined](docs/DomainAlreadyDefined.md)
 - [Model.DomainAlreadyDefinedErrors](docs/DomainAlreadyDefinedErrors.md)
 - [Model.DomainCollection](docs/DomainCollection.md)
 - [Model.DomainListRequired](docs/DomainListRequired.md)
 - [Model.DomainListRequiredErrors](docs/DomainListRequiredErrors.md)
 - [Model.EmailBouncesCampaignFields](docs/EmailBouncesCampaignFields.md)
 - [Model.EmailBouncesListStatsFields](docs/EmailBouncesListStatsFields.md)
 - [Model.EmailCampaignCreate](docs/EmailCampaignCreate.md)
 - [Model.EmailCampaignPatch](docs/EmailCampaignPatch.md)
 - [Model.EmailCampaignTemplate](docs/EmailCampaignTemplate.md)
 - [Model.EmailCampaignTemplateAllOf](docs/EmailCampaignTemplateAllOf.md)
 - [Model.EmailCampaignTemplateAllOfReplyToData](docs/EmailCampaignTemplateAllOfReplyToData.md)
 - [Model.EmailCampaignTemplateAllOfSenderData](docs/EmailCampaignTemplateAllOfSenderData.md)
 - [Model.EmailClicksByContactCampaignFields](docs/EmailClicksByContactCampaignFields.md)
 - [Model.EmailClicksByContactListStatsFields](docs/EmailClicksByContactListStatsFields.md)
 - [Model.EmailClicksByUrlCampaignFields](docs/EmailClicksByUrlCampaignFields.md)
 - [Model.EmailClicksByUrlListStatsFields](docs/EmailClicksByUrlListStatsFields.md)
 - [Model.EmailEventsCampaignFields](docs/EmailEventsCampaignFields.md)
 - [Model.EmailEventsListStatsFields](docs/EmailEventsListStatsFields.md)
 - [Model.EmailReport](docs/EmailReport.md)
 - [Model.EmailReportByDate](docs/EmailReportByDate.md)
 - [Model.EmailReportByDateDate](docs/EmailReportByDateDate.md)
 - [Model.EmailReportByDomain](docs/EmailReportByDomain.md)
 - [Model.EmailReportByDomainDomain](docs/EmailReportByDomainDomain.md)
 - [Model.EmailReportByEcommerce](docs/EmailReportByEcommerce.md)
 - [Model.EmailReportByEcommerceEcommerce](docs/EmailReportByEcommerceEcommerce.md)
 - [Model.EmailReportByHour](docs/EmailReportByHour.md)
 - [Model.EmailReportByHourHour](docs/EmailReportByHourHour.md)
 - [Model.EmailReportByLocation](docs/EmailReportByLocation.md)
 - [Model.EmailReportByLocationLocation](docs/EmailReportByLocationLocation.md)
 - [Model.EmailReportByReader](docs/EmailReportByReader.md)
 - [Model.EmailReportByReaderReader](docs/EmailReportByReaderReader.md)
 - [Model.EmailReportByUrl](docs/EmailReportByUrl.md)
 - [Model.EmailReportByUrlUrl](docs/EmailReportByUrlUrl.md)
 - [Model.EmailReportByWeekday](docs/EmailReportByWeekday.md)
 - [Model.EmailReportByWeekdayWeekday](docs/EmailReportByWeekdayWeekday.md)
 - [Model.EmailReportOverall](docs/EmailReportOverall.md)
 - [Model.EmailReportOverallOverall](docs/EmailReportOverallOverall.md)
 - [Model.EmailRssCampaignCreate](docs/EmailRssCampaignCreate.md)
 - [Model.EmailSendSegment](docs/EmailSendSegment.md)
 - [Model.EmailSender](docs/EmailSender.md)
 - [Model.EmailSenderAllOf](docs/EmailSenderAllOf.md)
 - [Model.EmailSenderCollection](docs/EmailSenderCollection.md)
 - [Model.EmailSenderPost](docs/EmailSenderPost.md)
 - [Model.EmailSenderPutRequest](docs/EmailSenderPutRequest.md)
 - [Model.EmailUnsubscriptionsCampaignFields](docs/EmailUnsubscriptionsCampaignFields.md)
 - [Model.EmailUnsubscriptionsListStatsFields](docs/EmailUnsubscriptionsListStatsFields.md)
 - [Model.EnableTeConflict](docs/EnableTeConflict.md)
 - [Model.EnableTeConflictsErrors](docs/EnableTeConflictsErrors.md)
 - [Model.EnableTransactionalConflict](docs/EnableTransactionalConflict.md)
 - [Model.EnableTransactionalConflictsErrors](docs/EnableTransactionalConflictsErrors.md)
 - [Model.ExportContactsWebhookData](docs/ExportContactsWebhookData.md)
 - [Model.ExtraFieldId](docs/ExtraFieldId.md)
 - [Model.Field](docs/Field.md)
 - [Model.FieldCollection](docs/FieldCollection.md)
 - [Model.FieldInUse](docs/FieldInUse.md)
 - [Model.FieldInUseErrors](docs/FieldInUseErrors.md)
 - [Model.FieldInUseErrorsFieldInUseData](docs/FieldInUseErrorsFieldInUseData.md)
 - [Model.FieldOption](docs/FieldOption.md)
 - [Model.FieldOptionPost](docs/FieldOptionPost.md)
 - [Model.FieldOptionsCollection](docs/FieldOptionsCollection.md)
 - [Model.Forbidden](docs/Forbidden.md)
 - [Model.Form](docs/Form.md)
 - [Model.GeneralInfo](docs/GeneralInfo.md)
 - [Model.GeneralInfoAllOf](docs/GeneralInfoAllOf.md)
 - [Model.GeneralInfoAllOfGeneralInfo](docs/GeneralInfoAllOfGeneralInfo.md)
 - [Model.GenerateEmailBouncesReport](docs/GenerateEmailBouncesReport.md)
 - [Model.GenerateEmailClicksByContactReport](docs/GenerateEmailClicksByContactReport.md)
 - [Model.GenerateEmailClicksByUrlReport](docs/GenerateEmailClicksByUrlReport.md)
 - [Model.GenerateEmailEventsReport](docs/GenerateEmailEventsReport.md)
 - [Model.GenerateEmailUnsubscriptionsReport](docs/GenerateEmailUnsubscriptionsReport.md)
 - [Model.GenerateFormAnswersReport](docs/GenerateFormAnswersReport.md)
 - [Model.GenerateSendsReport](docs/GenerateSendsReport.md)
 - [Model.GenerateSmsBouncesReport](docs/GenerateSmsBouncesReport.md)
 - [Model.GenerateSmsEventsReport](docs/GenerateSmsEventsReport.md)
 - [Model.GenerateSubscriptionsReport](docs/GenerateSubscriptionsReport.md)
 - [Model.GenerateUnsubscriptionsReport](docs/GenerateUnsubscriptionsReport.md)
 - [Model.Goal](docs/Goal.md)
 - [Model.GoalAutommaticInfo](docs/GoalAutommaticInfo.md)
 - [Model.GoalCollection](docs/GoalCollection.md)
 - [Model.GoalInfo](docs/GoalInfo.md)
 - [Model.GoalManualInfo](docs/GoalManualInfo.md)
 - [Model.GoalTimeInfo](docs/GoalTimeInfo.md)
 - [Model.HasAutomations](docs/HasAutomations.md)
 - [Model.HasAutomationsErrors](docs/HasAutomationsErrors.md)
 - [Model.HasCampaignsLastThirtyDays](docs/HasCampaignsLastThirtyDays.md)
 - [Model.HasCampaignsLastThirtyDaysErrors](docs/HasCampaignsLastThirtyDaysErrors.md)
 - [Model.HasPushApp](docs/HasPushApp.md)
 - [Model.HasPushAppErrors](docs/HasPushAppErrors.md)
 - [Model.HasQueuedCampaigns](docs/HasQueuedCampaigns.md)
 - [Model.HasQueuedCampaignsErrors](docs/HasQueuedCampaignsErrors.md)
 - [Model.HasQueuedOperations](docs/HasQueuedOperations.md)
 - [Model.HasQueuedOperationsErrors](docs/HasQueuedOperationsErrors.md)
 - [Model.HasWebPushSite](docs/HasWebPushSite.md)
 - [Model.HasWebPushSiteErrors](docs/HasWebPushSiteErrors.md)
 - [Model.HashcodeCampaign](docs/HashcodeCampaign.md)
 - [Model.HeaderFooter](docs/HeaderFooter.md)
 - [Model.HeaderFooterFooterLinks](docs/HeaderFooterFooterLinks.md)
 - [Model.HeaderFooterHeaderLinks](docs/HeaderFooterHeaderLinks.md)
 - [Model.HeaderFooterTemplate](docs/HeaderFooterTemplate.md)
 - [Model.ImportBulkFileRequest](docs/ImportBulkFileRequest.md)
 - [Model.ImportBulkFileRequestSchema](docs/ImportBulkFileRequestSchema.md)
 - [Model.ImportBulkRequest](docs/ImportBulkRequest.md)
 - [Model.ImportOrdersBulkBulkRequest](docs/ImportOrdersBulkBulkRequest.md)
 - [Model.ImportOrdersBulkBulkRequestItems](docs/ImportOrdersBulkBulkRequestItems.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InternalServerError](docs/InternalServerError.md)
 - [Model.InvalidSegmentType](docs/InvalidSegmentType.md)
 - [Model.InvalidSegmentTypeErrors](docs/InvalidSegmentTypeErrors.md)
 - [Model.Language](docs/Language.md)
 - [Model.LimitContactsActionSend](docs/LimitContactsActionSend.md)
 - [Model.LimitContactsPercentActionSend](docs/LimitContactsPercentActionSend.md)
 - [Model.LimitContactsValueActionSend](docs/LimitContactsValueActionSend.md)
 - [Model.LimitHourActionSend](docs/LimitHourActionSend.md)
 - [Model.LimitHourActionSendLimitHour](docs/LimitHourActionSendLimitHour.md)
 - [Model.LimitSpeedActionSend](docs/LimitSpeedActionSend.md)
 - [Model.List](docs/List.md)
 - [Model.ListCollection](docs/ListCollection.md)
 - [Model.ListCollection1](docs/ListCollection1.md)
 - [Model.ListLimitReached](docs/ListLimitReached.md)
 - [Model.ListLimitReachedErrors](docs/ListLimitReachedErrors.md)
 - [Model.MessageWebPush](docs/MessageWebPush.md)
 - [Model.MessageWebPushPost](docs/MessageWebPushPost.md)
 - [Model.MessageWebPushRss](docs/MessageWebPushRss.md)
 - [Model.ModuleInfo](docs/ModuleInfo.md)
 - [Model.ModuleInfoModuleInfo](docs/ModuleInfoModuleInfo.md)
 - [Model.ModuleInfoModuleInfoTe](docs/ModuleInfoModuleInfoTe.md)
 - [Model.MyAccount](docs/MyAccount.md)
 - [Model.NameAlreadyExists](docs/NameAlreadyExists.md)
 - [Model.NameAlreadyExistsErrors](docs/NameAlreadyExistsErrors.md)
 - [Model.NotFound](docs/NotFound.md)
 - [Model.NotifyUserIdArrayActionSend](docs/NotifyUserIdArrayActionSend.md)
 - [Model.Now](docs/Now.md)
 - [Model.NumericCellphoneSender](docs/NumericCellphoneSender.md)
 - [Model.NumericCellphoneSenderPost](docs/NumericCellphoneSenderPost.md)
 - [Model.NumericCellphoneSenderPostAllOf](docs/NumericCellphoneSenderPostAllOf.md)
 - [Model.OLimitContactsActionSend](docs/OLimitContactsActionSend.md)
 - [Model.OSegmentsActionSend](docs/OSegmentsActionSend.md)
 - [Model.OSegmentsWithoutContactActionSend](docs/OSegmentsWithoutContactActionSend.md)
 - [Model.Operation](docs/Operation.md)
 - [Model.OperationActionRequest](docs/OperationActionRequest.md)
 - [Model.OperationActionResponse](docs/OperationActionResponse.md)
 - [Model.OperationActionResponseError](docs/OperationActionResponseError.md)
 - [Model.OperationOperationData](docs/OperationOperationData.md)
 - [Model.OperationsCollection](docs/OperationsCollection.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderPatchRequest](docs/OrderPatchRequest.md)
 - [Model.Overall](docs/Overall.md)
 - [Model.OverallOverall](docs/OverallOverall.md)
 - [Model.PatchRequestBaseField](docs/PatchRequestBaseField.md)
 - [Model.PatchRequestField](docs/PatchRequestField.md)
 - [Model.PatchRequestList](docs/PatchRequestList.md)
 - [Model.PayloadTooLarge](docs/PayloadTooLarge.md)
 - [Model.PhoneCampaignTemplate](docs/PhoneCampaignTemplate.md)
 - [Model.PhoneCampaignTemplateAllOf](docs/PhoneCampaignTemplateAllOf.md)
 - [Model.PhoneReport](docs/PhoneReport.md)
 - [Model.PhoneReportAllOf](docs/PhoneReportAllOf.md)
 - [Model.PhoneReportAllOfNetworks](docs/PhoneReportAllOfNetworks.md)
 - [Model.PhoneSender](docs/PhoneSender.md)
 - [Model.PhoneSenderAllOf](docs/PhoneSenderAllOf.md)
 - [Model.PhoneSenderCollection](docs/PhoneSenderCollection.md)
 - [Model.PhoneSenderPost](docs/PhoneSenderPost.md)
 - [Model.Ping](docs/Ping.md)
 - [Model.PlanInfo](docs/PlanInfo.md)
 - [Model.PlanInfoPlanInfo](docs/PlanInfoPlanInfo.md)
 - [Model.PostCNameConflict](docs/PostCNameConflict.md)
 - [Model.PostContactsConflict](docs/PostContactsConflict.md)
 - [Model.PostListsConflict](docs/PostListsConflict.md)
 - [Model.PostProductsConflict](docs/PostProductsConflict.md)
 - [Model.PostRequestList](docs/PostRequestList.md)
 - [Model.PostWebpushSiteConflict](docs/PostWebpushSiteConflict.md)
 - [Model.Product](docs/Product.md)
 - [Model.ProductAllOf](docs/ProductAllOf.md)
 - [Model.ProductAlreadyExists](docs/ProductAlreadyExists.md)
 - [Model.ProductAlreadyExistsErrors](docs/ProductAlreadyExistsErrors.md)
 - [Model.ProductBulkRequest](docs/ProductBulkRequest.md)
 - [Model.ProductCollection](docs/ProductCollection.md)
 - [Model.ProductCustomAttributes](docs/ProductCustomAttributes.md)
 - [Model.ProductPatchRequest](docs/ProductPatchRequest.md)
 - [Model.ProductPatchRequestRelatedProducts](docs/ProductPatchRequestRelatedProducts.md)
 - [Model.ProductPostRequest](docs/ProductPostRequest.md)
 - [Model.PushCampaignPatchRequest](docs/PushCampaignPatchRequest.md)
 - [Model.PushCampaignPatchRequestContent](docs/PushCampaignPatchRequestContent.md)
 - [Model.PushCampaignPatchRequestGeoOptions](docs/PushCampaignPatchRequestGeoOptions.md)
 - [Model.PushCampaignPostRequest](docs/PushCampaignPostRequest.md)
 - [Model.PushCampaignPostRequestActions](docs/PushCampaignPostRequestActions.md)
 - [Model.PushCampaignPostRequestGeoOptions](docs/PushCampaignPostRequestGeoOptions.md)
 - [Model.PushCampaignPostRequestNotificationOptions](docs/PushCampaignPostRequestNotificationOptions.md)
 - [Model.PushEvent](docs/PushEvent.md)
 - [Model.PushNotificationSoundSchema](docs/PushNotificationSoundSchema.md)
 - [Model.PushNotificationSoundSchemaDefault](docs/PushNotificationSoundSchemaDefault.md)
 - [Model.PushNotificationSoundSchemaNone](docs/PushNotificationSoundSchemaNone.md)
 - [Model.PushNotificationSoundSchemaUrl](docs/PushNotificationSoundSchemaUrl.md)
 - [Model.PushReport](docs/PushReport.md)
 - [Model.PushReportAllOf](docs/PushReportAllOf.md)
 - [Model.PushResponse](docs/PushResponse.md)
 - [Model.PushToken](docs/PushToken.md)
 - [Model.PushTokenTwoStepsData](docs/PushTokenTwoStepsData.md)
 - [Model.PushVersions](docs/PushVersions.md)
 - [Model.PushVersionsVersions](docs/PushVersionsVersions.md)
 - [Model.RemoveRequest](docs/RemoveRequest.md)
 - [Model.RemoveResponse](docs/RemoveResponse.md)
 - [Model.RemoveResponseErrors](docs/RemoveResponseErrors.md)
 - [Model.ReportCampaignsAll](docs/ReportCampaignsAll.md)
 - [Model.ReportCampaignsGroup](docs/ReportCampaignsGroup.md)
 - [Model.ReportCampaignsLast](docs/ReportCampaignsLast.md)
 - [Model.ReportCampaignsSpecific](docs/ReportCampaignsSpecific.md)
 - [Model.RequestEntityTooLarge](docs/RequestEntityTooLarge.md)
 - [Model.RequestItemsUnsubscribe](docs/RequestItemsUnsubscribe.md)
 - [Model.RequestItemsUnsubscribeAllOf](docs/RequestItemsUnsubscribeAllOf.md)
 - [Model.RequestTimeout](docs/RequestTimeout.md)
 - [Model.SavedSegment](docs/SavedSegment.md)
 - [Model.SavedSegmentAllOf](docs/SavedSegmentAllOf.md)
 - [Model.SavedSegmentAllOf1](docs/SavedSegmentAllOf1.md)
 - [Model.SavedSegmentAllOf1SegmentFilter](docs/SavedSegmentAllOf1SegmentFilter.md)
 - [Model.SavedSegmentAllOf1SegmentFilterSegmentFilterArray](docs/SavedSegmentAllOf1SegmentFilterSegmentFilterArray.md)
 - [Model.Segment](docs/Segment.md)
 - [Model.SegmentCollection](docs/SegmentCollection.md)
 - [Model.SegmentsActionSend](docs/SegmentsActionSend.md)
 - [Model.SegmentsWithoutContactActionSend](docs/SegmentsWithoutContactActionSend.md)
 - [Model.SendContact](docs/SendContact.md)
 - [Model.SendContactCellphone](docs/SendContactCellphone.md)
 - [Model.SendEmailContact](docs/SendEmailContact.md)
 - [Model.SendNone](docs/SendNone.md)
 - [Model.SendPush](docs/SendPush.md)
 - [Model.SendPushAllOf](docs/SendPushAllOf.md)
 - [Model.SendSegment](docs/SendSegment.md)
 - [Model.SendSmartSms](docs/SendSmartSms.md)
 - [Model.SendSmartSmsAllOf](docs/SendSmartSmsAllOf.md)
 - [Model.SendSmartSmsAllOf1](docs/SendSmartSmsAllOf1.md)
 - [Model.SendSmartSmsAllOf2](docs/SendSmartSmsAllOf2.md)
 - [Model.SendSms](docs/SendSms.md)
 - [Model.SendSmsAllOf](docs/SendSmsAllOf.md)
 - [Model.SendSmsAllOf1](docs/SendSmsAllOf1.md)
 - [Model.SendWebPush](docs/SendWebPush.md)
 - [Model.SendWebPushAllOf](docs/SendWebPushAllOf.md)
 - [Model.SendsCampaignFields](docs/SendsCampaignFields.md)
 - [Model.ServiceUnavailable](docs/ServiceUnavailable.md)
 - [Model.SingleCartObject](docs/SingleCartObject.md)
 - [Model.SingleOrderObject](docs/SingleOrderObject.md)
 - [Model.SmartSmsCampaign](docs/SmartSmsCampaign.md)
 - [Model.SmartSmsCampaignCampaignContent](docs/SmartSmsCampaignCampaignContent.md)
 - [Model.SmartSmsCampaignPatchRequest](docs/SmartSmsCampaignPatchRequest.md)
 - [Model.SmartSmsCampaignPatchRequestCampaignContent](docs/SmartSmsCampaignPatchRequestCampaignContent.md)
 - [Model.SmartSmsCampaignPatchRequestPageContent](docs/SmartSmsCampaignPatchRequestPageContent.md)
 - [Model.SmartSmsSegmentsActionSend](docs/SmartSmsSegmentsActionSend.md)
 - [Model.SmsBouncesCampaignFields](docs/SmsBouncesCampaignFields.md)
 - [Model.SmsBouncesListStatsFields](docs/SmsBouncesListStatsFields.md)
 - [Model.SmsCampaign](docs/SmsCampaign.md)
 - [Model.SmsCampaignPatchRequest](docs/SmsCampaignPatchRequest.md)
 - [Model.SmsCampaignPatchRequestContent](docs/SmsCampaignPatchRequestContent.md)
 - [Model.SmsCampaignTemplate](docs/SmsCampaignTemplate.md)
 - [Model.SmsCampaignTemplateAllOf](docs/SmsCampaignTemplateAllOf.md)
 - [Model.SmsEventsCampaignFields](docs/SmsEventsCampaignFields.md)
 - [Model.SmsEventsListStatsFields](docs/SmsEventsListStatsFields.md)
 - [Model.SmsSegmentsActionSend](docs/SmsSegmentsActionSend.md)
 - [Model.StartAutomationRequest](docs/StartAutomationRequest.md)
 - [Model.StartAutomationResponse](docs/StartAutomationResponse.md)
 - [Model.SubscriptionsListStatsFields](docs/SubscriptionsListStatsFields.md)
 - [Model.SuppressionList](docs/SuppressionList.md)
 - [Model.SuppressionListItems](docs/SuppressionListItems.md)
 - [Model.SuppressionTypeCellphone](docs/SuppressionTypeCellphone.md)
 - [Model.SuppressionTypeCellphoneAllOf](docs/SuppressionTypeCellphoneAllOf.md)
 - [Model.SuppressionTypeCellphoneAllOf1](docs/SuppressionTypeCellphoneAllOf1.md)
 - [Model.SuppressionTypeEmail](docs/SuppressionTypeEmail.md)
 - [Model.SuppressionTypeEmailAllOf](docs/SuppressionTypeEmailAllOf.md)
 - [Model.SuppressionTypeEmailAllOf1](docs/SuppressionTypeEmailAllOf1.md)
 - [Model.SuppressionTypeEmailDomain](docs/SuppressionTypeEmailDomain.md)
 - [Model.SuppressionTypeEmailDomainAllOf](docs/SuppressionTypeEmailDomainAllOf.md)
 - [Model.SuppressionTypeEmailDomainAllOf1](docs/SuppressionTypeEmailDomainAllOf1.md)
 - [Model.SuppressionTypePhone](docs/SuppressionTypePhone.md)
 - [Model.SuppressionTypePhoneAllOf](docs/SuppressionTypePhoneAllOf.md)
 - [Model.SuppressionTypePhoneAllOf1](docs/SuppressionTypePhoneAllOf1.md)
 - [Model.SuppressionTypeUserEmail](docs/SuppressionTypeUserEmail.md)
 - [Model.SuppressionTypeUserEmailAllOf](docs/SuppressionTypeUserEmailAllOf.md)
 - [Model.SuppressionTypeUserEmailAllOf1](docs/SuppressionTypeUserEmailAllOf1.md)
 - [Model.Tag](docs/Tag.md)
 - [Model.TagCollection](docs/TagCollection.md)
 - [Model.TagCollection1](docs/TagCollection1.md)
 - [Model.TagRequest](docs/TagRequest.md)
 - [Model.TagSegment](docs/TagSegment.md)
 - [Model.TagSegmentAllOf](docs/TagSegmentAllOf.md)
 - [Model.TeResponse](docs/TeResponse.md)
 - [Model.TeResponseAllOf](docs/TeResponseAllOf.md)
 - [Model.TooManyRequests](docs/TooManyRequests.md)
 - [Model.Unauthorized](docs/Unauthorized.md)
 - [Model.UniqueFieldInUse](docs/UniqueFieldInUse.md)
 - [Model.UniqueFieldInUseErrors](docs/UniqueFieldInUseErrors.md)
 - [Model.UnprocessableEntity](docs/UnprocessableEntity.md)
 - [Model.UnremovableEntry](docs/UnremovableEntry.md)
 - [Model.UnremovableEntryErrors](docs/UnremovableEntryErrors.md)
 - [Model.UnsubscriptionObject](docs/UnsubscriptionObject.md)
 - [Model.UnsubscriptionsListStatsFields](docs/UnsubscriptionsListStatsFields.md)
 - [Model.UpdateByContact](docs/UpdateByContact.md)
 - [Model.UpdateBySegment](docs/UpdateBySegment.md)
 - [Model.UpdateContactsRequest](docs/UpdateContactsRequest.md)
 - [Model.UpdateForAll](docs/UpdateForAll.md)
 - [Model.UsedInAutomations](docs/UsedInAutomations.md)
 - [Model.UsedInAutomationsErrors](docs/UsedInAutomationsErrors.md)
 - [Model.UsedInRecurringMessages](docs/UsedInRecurringMessages.md)
 - [Model.UsedInRecurringMessagesErrors](docs/UsedInRecurringMessagesErrors.md)
 - [Model.User](docs/User.md)
 - [Model.UserAllOf](docs/UserAllOf.md)
 - [Model.UserCollection](docs/UserCollection.md)
 - [Model.UserPost](docs/UserPost.md)
 - [Model.UserPostAllOf](docs/UserPostAllOf.md)
 - [Model.UserPostRequest](docs/UserPostRequest.md)
 - [Model.UserPostRequestAllOf](docs/UserPostRequestAllOf.md)
 - [Model.VoiceCampaign](docs/VoiceCampaign.md)
 - [Model.VoiceCampaignAllOf](docs/VoiceCampaignAllOf.md)
 - [Model.VoiceCampaignTemplate](docs/VoiceCampaignTemplate.md)
 - [Model.VoiceCampaignTemplateAllOf](docs/VoiceCampaignTemplateAllOf.md)
 - [Model.VoicePatchCampaign](docs/VoicePatchCampaign.md)
 - [Model.VoicePatchCampaignAllOf](docs/VoicePatchCampaignAllOf.md)
 - [Model.WebPushCampaign](docs/WebPushCampaign.md)
 - [Model.WebPushPatchCampaign](docs/WebPushPatchCampaign.md)
 - [Model.WebPushReport](docs/WebPushReport.md)
 - [Model.WebPushReportBrowsers](docs/WebPushReportBrowsers.md)
 - [Model.WebPushReportOperatingSystems](docs/WebPushReportOperatingSystems.md)
 - [Model.WebPushRssCampaign](docs/WebPushRssCampaign.md)
 - [Model.WebPushSite](docs/WebPushSite.md)
 - [Model.WebPushStats](docs/WebPushStats.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookActionSchema](docs/WebhookActionSchema.md)


## Documentation for Authorization


### Apikey

- **Type**: API key

- **API key parameter name**: Apikey
- **Location**: HTTP header

