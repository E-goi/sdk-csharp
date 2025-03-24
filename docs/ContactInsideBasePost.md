
# org.egoi.client.api.Model.ContactInsideBasePost

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactId** | **string** |  | [optional] [readonly] 
**Status** | **string** | Status of the contact | [optional] [default to StatusEnum.Active]
**FirstName** | **string** | First name of the contact | [optional] 
**LastName** | **string** | Last name of the contact | [optional] 
**BirthDate** | **DateTime** | Birth date of the contact | [optional] 
**Language** | [**Language**](Language.md) |  | [optional] 
**Email** | **string** | Email of the contact | [optional] 
**Cellphone** | **string** | Cellphone of the contact (country code followed by phone number, split by &#39;-&#39;) | [optional] 
**Phone** | **string** | Phone of the contact (country code followed by phone number, split by &#39;-&#39;) | [optional] 
**PushTokenAndroid** | [**List&lt;ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid&gt;**](ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenAndroid.md) | Android push token of the contact | [optional] 
**PushTokenIos** | [**List&lt;ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos&gt;**](ContactBaseWithStatusNoRemovedFieldsSchemaBasePushTokenIos.md) | IOS push token of the contact | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

